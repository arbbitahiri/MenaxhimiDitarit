using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MenaxhimiDitarit.App_Code;
using MenaxhimiDitarit.BLL;
using MenaxhimiDitarit.BO;
using Telerik.WinControls.UI;

namespace MenaxhimiDitarit.TeacherForms
{
    public partial class TopicList : Form
    {
        private readonly TopicBLL _topicBLL;
        private List<Topic> MyTopics;

        private readonly SubjectBLL _subjectBLL;
        private List<Subject> MySubjects;

        private readonly ClassBLL _classBLL;
        private List<Class> MyClasses;

        public TopicList()
        {
            InitializeComponent();

            dgvTopicList.SelectionMode = GridViewSelectionMode.FullRowSelect;

            _topicBLL = new TopicBLL();
            _subjectBLL = new SubjectBLL();
            _classBLL = new ClassBLL();

            MySubjects = _subjectBLL.GetAll();
            cmbSelectSubject.DataSource = MySubjects;

            MyClasses = _classBLL.GetAll();
            cmbSelectClass.DataSource = MyClasses;

            CustomizeDesign();
        }

        #region Methods

        #region Methods for Panels
        /// <summary>
        /// Hides all the panels in Menu
        /// </summary>
        private void CustomizeDesign()
        {
            pnlClassSchedules.Visible = false;
        }

        /// <summary>
        /// Hides other submenu in Menu when it's button is clicked
        /// </summary>
        private void HideSubMenu()
        {
            if (pnlClassSchedules.Visible == true)
                pnlClassSchedules.Visible = false;
        }

        /// <summary>
        /// Shows the submenu when the button is clicked
        /// </summary>
        /// <param name="subMenu">The panel we want to show</param>
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        #endregion

        /// <summary>
        /// Refreshes the list
        /// </summary>
        private void RefreshList()
        {
            MyTopics = _topicBLL.GetAllTopic();
            dgvTopicList.DataSource = MyTopics;
        }

        /// <summary>
        /// Gets the topic data, that we select in GridView
        /// </summary>
        /// <param name="topicRow">The selected row</param>
        /// <returns>The data of topic</returns>
        private Topic GetTopic(GridViewRowInfo topicRow)
        {
            try
            {
                Topic topic = new Topic
                {
                    TopicID = (int)topicRow.Cells["TopicID"].Value,
                    ClassID = (int)topicRow.Cells["ClassID"].Value,
                    SubjectID = (int)topicRow.Cells["SubjectID"].Value,
                    Date = (DateTime)topicRow.Cells["Date"].Value,
                    Time = (int)topicRow.Cells["Time"].Value,
                    Content = (string)topicRow.Cells["Content"].Value,
                    InsertBy = (string)topicRow.Cells["InsertBy"].Value,
                    InsertDate = (DateTime)topicRow.Cells["InsertDate"].Value,
                    LUB = (string)topicRow.Cells["LUB"].Value,
                    LUD = (DateTime)topicRow.Cells["LUD"].Value,
                    LUN = (int)topicRow.Cells["LUN"].Value
                };

                return topic;
            }
            catch (Exception)
            {
                Validation.MessageBoxShow("A problem occurred while getting those data!", "Problem",
                            "Ndodhi një problem gjatë marrjes së këtyre të dhënave!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// Searches the topic
        /// </summary>
        private void SearchTopic()
        {
            try
            {
                if (_topicBLL != null)
                {
                    if (cmbSelectSubject.SelectedIndex != -1 && cmbSelectClass.SelectedIndex != -1)
                    {
                        var findTopic = MyTopics.Where(f => f.SubjectID == Convert.ToInt32(cmbSelectSubject.SelectedValue.ToString())
                        && f.ClassID == Convert.ToInt32(cmbSelectClass.SelectedValue.ToString()) && f.Date == dtpSelectDay.Value.Date).ToList();

                        dgvTopicList.DataSource = findTopic;
                    }
                    else
                    {
                        Validation.MessageBoxShow("Please select a class, a subject and a day!", "Empty",
                            "Ju lutemi zgjidhni një klasë, një lëndë dhe një ditë!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    Validation.MessageBoxShow("Topic does not exist!", "Doesn't exist",
                        "Tema nuk ekziston!", "Nuk ekziston", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                Validation.MessageBoxShow("A problem occurred while searching data!", "Problem",
                            "Ndodhi një problem gjatë kërkimit të të dhënave!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Opens the form to update the topic
        /// </summary>
        private void UpdateTopic()
        {
            if (dgvTopicList.SelectedRows.Count > 0)
            {
                var row = dgvTopicList.SelectedRows[0].Index;
                if (row >= 0)
                {
                    var topic = GetTopic(dgvTopicList.Rows[row]);
                    if (topic != null)
                    {
                        TopicCreate updateTopic = new TopicCreate(topic)
                        {
                            StartPosition = FormStartPosition.CenterParent
                        };
                        updateTopic.ShowDialog();
                    }
                }
            }
            RefreshList();
        }

        /// <summary>
        /// Deletes the topic
        /// </summary>
        private void DeleteTopic()
        {
            if (dgvTopicList.SelectedRows.Count > 0)
            {
                var row = dgvTopicList.SelectedRows[0].Index;
                if (row >= 0)
                {
                    var topic = GetTopic(dgvTopicList.Rows[row]);
                    if (topic != null)
                    {
                        var result = Validation.MessageBoxShow("Are you sure you want to delete?", "Sure?",
                            "A je i/e sigurt që do ta fshini?", "Sigurt?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            _topicBLL.RemoveTopic(topic.TopicID);

                            Validation.MessageBoxShow("The selected topic has been deleted successfully!", "Deleted",
                                "Tema u fshi me sukses!", "U fshi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            RefreshList();
                        }
                    }
                }
            }
            RefreshList();
        }

        /// <summary>
        /// Shows the full content
        /// </summary>
        private void ShowFullContent()
        {
            if (dgvTopicList.SelectedRows.Count > 0)
            {
                var row = dgvTopicList.SelectedRows[0].Index;
                if (row >= 0)
                {
                    var topic = GetTopic(dgvTopicList.Rows[row]);
                    if (topic != null)
                    {
                        Validation.MessageBoxShow($"Content: {topic.Content}", "Content",
                            $"Tema: {topic.Content}", "Tema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        #endregion

        #region Events
        // Form
        private void TopicListForm_Load(object sender, EventArgs e)
        {
            RefreshList();

            Validation.InitializePrintDocument(printDocument, "Topic List", "Lista e Temave");
        }

        // Grid Formattings
        private void dgvTopicList_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            Validation.CellFormatting(e, "Content", "Përmbajtja");
        }

        private void dgvTopicList_PrintCellFormatting(object sender, PrintCellFormattingEventArgs e)
        {
            Validation.PrintCellFormatting(e, "Content", "Përmbajtja");
        }

        // Buttons
        private void btnViewAll_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchTopic();
        }

        // Tool Strip Menus
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateTopic();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteTopic();
        }

        private void showContentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFullContent();
        }
        #endregion

        #region Menu
        private void btnAddTopic_Click(object sender, EventArgs e)
        {
            TopicCreate addTopic = new TopicCreate
            {
                StartPosition = FormStartPosition.CenterParent
            };
            addTopic.ShowDialog();

            RefreshList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateTopic();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteTopic();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            dgvTopicList.PrintPreview(printDocument);
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            ExportFile.ExportExcel("ClassList", "ListaEKlasës", ".xlsx", "Excel Workbook |*.xlsx", dgvTopicList);

            Validation.MessageBoxShow("Excel file created succesfully!", "Created", "Excel file u krijua me sukses!", "U krijua",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            ExportFile.ExportPDF("ClassList", "ListaEKlasës", ".pdf", "Pdf Files|*.pdf", dgvTopicList);

            Validation.MessageBoxShow("PDF file created succesfully!", "Created", "PDF file u krijua me sukses!", "U krijua",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #region Class Schedules
        private void btnClassSchedule_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlClassSchedules);
        }

        private void btnClass1_Click(object sender, EventArgs e)
        {
            Validation.ShowClassSchedule(1);
        }

        private void btnClass2_Click(object sender, EventArgs e)
        {
            Validation.ShowClassSchedule(2);
        }

        private void btnClass3_Click(object sender, EventArgs e)
        {
            Validation.ShowClassSchedule(3);
        }

        private void btnClass4_Click(object sender, EventArgs e)
        {
            Validation.ShowClassSchedule(4);
        }

        private void btnClass5_Click(object sender, EventArgs e)
        {
            Validation.ShowClassSchedule(5);
        }

        private void btnClass6_Click(object sender, EventArgs e)
        {
            Validation.ShowClassSchedule(6);
        }

        private void btnClass7_Click(object sender, EventArgs e)
        {
            Validation.ShowClassSchedule(7);
        }

        private void btnClass8_Click(object sender, EventArgs e)
        {
            Validation.ShowClassSchedule(8);
        }

        private void btnClass9_Click(object sender, EventArgs e)
        {
            Validation.ShowClassSchedule(9);
        }
        #endregion

        #endregion
    }
}