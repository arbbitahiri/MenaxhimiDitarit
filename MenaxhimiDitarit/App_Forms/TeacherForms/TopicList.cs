using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
        }

        #region Metodat
        private void RefreshList()
        {
            MyTopics = _topicBLL.GetAllTopic();
            dgvTopicList.DataSource = MyTopics;
        }

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
        #endregion

        private void TopicListForm_Load(object sender, EventArgs e)
        {
            RefreshList();

            Validation.InitializePrintDocument(printDocument, "Topic List", "Lista e Temave");
        }

        #region Grid Formatting
        private void dgvTopicList_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            Validation.CellFormatting(e, "Content", "Përmbajtja");
        }

        private void dgvTopicList_PrintCellFormatting(object sender, PrintCellFormattingEventArgs e)
        {
            Validation.PrintCellFormatting(e, "Content", "Përmbajtja");
        }
        #endregion

        #region Button
        private void btnViewAll_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
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
        #endregion

        #region Tool Strip Menu
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

        #region Export
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread((ThreadStart)(() =>
            {
                var saveFileDialog = Validation.SaveFile("ClassList", "ListaEKlasës", ".xlsx", "Excel Workbook |*.xlsx");

                saveFileDialog.ShowDialog();

                Validation.ExportToExcel(dgvTopicList, saveFileDialog.FileName, "ClassList", "ListaEKlasës");
            }));

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();

            Validation.MessageBoxShow("Excel file created succesfully!", "Created", "Excel file u krijua me sukses!", "U krijua",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread((ThreadStart)(() =>
            {
                var saveFileDialog = Validation.SaveFile("ClassList", "ListaEKlasës", ".pdf", "Pdf Files|*.pdf");

                saveFileDialog.ShowDialog();

                Validation.ExportToPDF(dgvTopicList, saveFileDialog.FileName);
            }));

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();

            Validation.MessageBoxShow("PDF file created succesfully!", "Created", "PDF file u krijua me sukses!", "U krijua",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #endregion
    }
}