using MenaxhimiDitarit.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MenaxhimiDitarit.BO;
using Telerik.WinControls.UI;
using MenaxhimiDitarit.App_Code;

namespace MenaxhimiDitarit.TeacherForms
{
    public partial class AbsenceList : Form
    {
        private readonly TopicBLL _absenceBLL;
        private List<Topic> MyAbsences;

        private readonly SubjectBLL _subjectBLL;
        private List<Subject> MySubjects;

        public AbsenceList()
        {
            InitializeComponent();

            _absenceBLL = new TopicBLL();
            _subjectBLL = new SubjectBLL();

            MySubjects = _subjectBLL.GetAll();
            cmbSelectSubject.DataSource = MySubjects;

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
            MyAbsences = _absenceBLL.GetAllAbsence();
            dgvAbsenceList.DataSource = MyAbsences;
        }

        /// <summary>
        /// Gets the absence data, that we select in GridView
        /// </summary>
        /// <param name="absenceRow">The selected row</param>
        /// <returns>The data of absence</returns>
        private Topic GetAbsence(GridViewRowInfo absenceRow)
        {
            try
            {
                Topic absence = new Topic
                {
                    TopicID = (int)absenceRow.Cells["TopicID"].Value,
                    ClassID = (int)absenceRow.Cells["ClassID"].Value,
                    SubjectID = (int)absenceRow.Cells["SubjectID"].Value,
                    Date = (DateTime)absenceRow.Cells["Date"].Value,
                    Time = (int)absenceRow.Cells["Time"].Value,
                    Reasoning = (string)absenceRow.Cells["Reasoning"].Value,
                    NoStudents = (int)absenceRow.Cells["NoStudents"].Value,
                    InsertBy = (string)absenceRow.Cells["InsertBy"].Value,
                    InsertDate = (DateTime)absenceRow.Cells["InsertDate"].Value,
                    LUB = (string)absenceRow.Cells["LUB"].Value,
                    LUD = (DateTime)absenceRow.Cells["LUD"].Value,
                    LUN = (int)absenceRow.Cells["LUN"].Value
                };

                return absence;
            }
            catch (Exception)
            {
                MessageDialog.MessageBoxShow("A problem occurred while getting those data!", "Problem",
                            "Ndodhi një problem gjatë marrjes së këtyre të dhënave!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        /// <summary>
        /// Opens the form to update the absence
        /// </summary>
        private void UpdateAbsence()
        {
            if (dgvAbsenceList.SelectedRows.Count > 0)
            {
                var row = dgvAbsenceList.SelectedRows[0].Index;
                if (row >= 0)
                {
                    var absence = GetAbsence(dgvAbsenceList.Rows[row]);
                    if (absence != null)
                    {
                        AbsenceCreate updateAbsence = new AbsenceCreate(absence)
                        {
                            StartPosition = FormStartPosition.CenterParent
                        };
                        updateAbsence.ShowDialog();
                    }
                }
            }
            RefreshList();
        }

        /// <summary>
        /// Searches the absence
        /// </summary>
        private void SearchAbsence()
        {
            try
            {
                if (_absenceBLL != null)
                {
                    if (cmbSelectSubject.SelectedIndex != -1)
                    {
                        var findAbsence = MyAbsences.Where(f => f.SubjectID == Convert.ToInt32(cmbSelectSubject.SelectedValue.ToString())
                        && f.Date == dtpSelectDay.Value.Date).ToList();

                        dgvAbsenceList.DataSource = findAbsence;
                    }
                    else
                    {
                        MessageDialog.MessageBoxShow("Please select a subject and a day!", "Empty",
                            "Ju lutemi zgjidhni një lëndë dhe një ditë!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageDialog.MessageBoxShow("Absence does not exist!", "Doesn't exist",
                        "Mungesa nuk ekziston!", "Nuk ekziston", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageDialog.MessageBoxShow("A problem occurred while searching data!", "Problem",
                            "Ndodhi një problem gjatë kërkimit të të dhënave!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Events
        // Form
        private void AbsenceList_Load(object sender, EventArgs e)
        {
            RefreshList();

            Validation.InitializePrintDocument(printDocument, "Absence List", "Lista e Mungesës");
        }

        // Grid Formatting
        private void MasterTemplate_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            Validation.CellFormatting(e, "Reason", "Arsyeja");
        }

        private void MasterTemplate_PrintCellFormatting(object sender, PrintCellFormattingEventArgs e)
        {
            Validation.PrintCellFormatting(e, "Reason", "Arsyeja");
        }

        // Buttons
        private void btnViewAll_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchAbsence();
        }

        // Tool Strip Menu
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateAbsence();
        }
        #endregion

        #region Menu
        private void btnAddComment_Click(object sender, EventArgs e)
        {
            AbsenceCreate addAbsence = new AbsenceCreate
            {
                StartPosition = FormStartPosition.CenterParent
            };
            addAbsence.ShowDialog();

            RefreshList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAbsence();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            dgvAbsenceList.PrintPreview(printDocument);
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            ExportFile.ExportExcel("AbsenceList", "ListaEMungesës", ".xlsx", "Excel Workbook |*.xlsx", dgvAbsenceList);

            MessageDialog.MessageBoxShow("Excel file created succesfully!", "Created", "Excel file u krijua me sukses!", "U krijua",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            ExportFile.ExportExcel("AbsenceList", "ListaEMungesës", ".pdf", "Pdf Files|*.pdf", dgvAbsenceList);

            MessageDialog.MessageBoxShow("PDF file created succesfully!", "Created", "PDF file u krijua me sukses!", "U krijua",
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