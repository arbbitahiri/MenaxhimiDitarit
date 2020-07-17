using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MenaxhimiDitarit.App_Code;
using MenaxhimiDitarit.BLL;
using MenaxhimiDitarit.BO;
using Telerik.WinControls.UI;

namespace MenaxhimiDitarit.AdminForms
{
    public partial class ClassScheduletList : Form
    {
        private readonly ClassScheduleBLL _scheduleBLL;
        private List<ClassSchedule> MySchedules;

        private readonly ClassBLL _classBLL;
        private readonly List<Class> MyClasses;

        public ClassScheduletList()
        {
            InitializeComponent();

            dgvScheduleList.SelectionMode = GridViewSelectionMode.FullRowSelect;

            _scheduleBLL = new ClassScheduleBLL();
            _classBLL = new ClassBLL();

            MyClasses = _classBLL.GetAll();
            cmbSelectClass.DataSource = MyClasses;
        }

        #region Methods
        /// <summary>
        /// Refreshes the list
        /// </summary>
        private void RefreshList()
        {
            MySchedules = _scheduleBLL.GetAll();
            dgvScheduleList.DataSource = MySchedules;
        }

        /// <summary>
        /// Gets the schedule data, that we select in GridView
        /// </summary>
        /// <param name="scheduleRow">The selected row</param>
        /// <returns>The data of schedule</returns>
        private ClassSchedule GetSchedule(GridViewRowInfo scheduleRow)
        {
            try
            {
                ClassSchedule schedule = new ClassSchedule
                {
                    ScheduleID = (int)scheduleRow.Cells["ScheduleID"].Value,
                    ClassID = (int)scheduleRow.Cells["ClassID"].Value,
                    SubjectID = (int)scheduleRow.Cells["SubjectID"].Value,
                    Time = (int)scheduleRow.Cells["Time"].Value,
                    Day = (string)scheduleRow.Cells["Day"].Value,
                    Year = (int)scheduleRow.Cells["Year"].Value,
                    InsertBy = (string)scheduleRow.Cells["InsertBy"].Value,
                    InsertDate = (DateTime)scheduleRow.Cells["InsertDate"].Value,
                    LUB = (string)scheduleRow.Cells["LUB"].Value,
                    LUD = (DateTime)scheduleRow.Cells["LUD"].Value,
                    LUN = (int)scheduleRow.Cells["LUN"].Value
                };

                return schedule;
            }
            catch (Exception)
            {
                MessageDialog.MessageBoxShow("A problem occurred while getting those data!", "Problem",
                            "Ndodhi një problem gjatë marrjes së këtyre të dhënave!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// Opens the form to update the schedule
        /// </summary>
        private void UpdateSchedule()
        {
            if (dgvScheduleList.SelectedRows.Count > 0)
            {
                var row = dgvScheduleList.SelectedRows[0].Index;
                if (row >= 0)
                {
                    var schedule = GetSchedule(dgvScheduleList.Rows[row]);
                    if (schedule != null)
                    {
                        ClassScheduleCreate updateSchedule = new ClassScheduleCreate(schedule)
                        {
                            StartPosition = FormStartPosition.CenterParent
                        };
                        updateSchedule.ShowDialog();
                    }
                }
            }
            RefreshList();
        }

        /// <summary>
        /// Searches the class
        /// </summary>
        private void SearchClass()
        {
            try
            {
                if (_scheduleBLL != null)
                {
                    if (cmbSelectClass.SelectedIndex != -1 && cmbSelectDay.SelectedIndex != -1)
                    {
                        var findSchedule = MySchedules.Where(f => f.ClassID == Convert.ToInt32(cmbSelectClass.SelectedValue.ToString())
                        && f.Day == cmbSelectDay.SelectedItem.ToString()).ToList();

                        dgvScheduleList.DataSource = findSchedule;
                    }
                    else
                    {
                        MessageDialog.MessageBoxShow("Please select a class and a day!", "Empty",
                            "Ju lutem zgjedheni një klasë dhe një datë!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageDialog.MessageBoxShow("Schedule does not exist!", "Doesn't exist",
                            "Orari nuk ekziston!", "Nuk ekziston", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void ClassScheduletList_Load_1(object sender, EventArgs e)
        {
            RefreshList();

            Validation.InitializePrintDocument(printDocument, "Class Schedule List", "Lista e Orarit të Klasës");
        }

        // Buttons
        private void btnViewAll_Click_1(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            SearchClass();
        }

        private void btnHELP_Click(object sender, EventArgs e)
        {
            MessageDialog.ShowHelp(this, "schedulelist.html");
        }

        // Tool Strip Menu
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateSchedule();
        }
        #endregion

        #region Menu
        private void btnAddClass_Click(object sender, EventArgs e)
        {
            ClassScheduleCreate addSchedule = new ClassScheduleCreate()
            {
                StartPosition = FormStartPosition.CenterParent
            };
            addSchedule.ShowDialog();
            RefreshList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateSchedule();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            dgvScheduleList.PrintPreview(printDocument);
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            ExportFile.ExportExcel("ClassScheduleList", "ListaEOraritTëKlasës", ".xlsx", "Excel Workbook |*.xlsx", dgvScheduleList);

            MessageDialog.MessageBoxShow("Excel file created succesfully!", "Created", "Excel file u krijua me sukses!", "U krijua",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            ExportFile.ExportExcel("ClassScheduleList", "ListaEOraritTëKlasës", ".pdf", "Pdf Files|*.pdf", dgvScheduleList);

            MessageDialog.MessageBoxShow("PDF file created succesfully!", "Created", "PDF file u krijua me sukses!", "U krijua",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
