﻿using System;
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

namespace MenaxhimiDitarit.AdminForms
{
    //todo get(id) select all, view schedule
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

        #region Metodat
        private void RefreshList()
        {
            MySchedules = _scheduleBLL.GetAll();
            dgvScheduleList.DataSource = MySchedules;
        }

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
                Validation.MessageBoxShow("A problem occurred while getting those data!", "Problem",
                            "Ndodhi një problem gjatë marrjes së këtyre të dhënave!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

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
        #endregion

        private void ClassScheduletList_Load_1(object sender, EventArgs e)
        {
            RefreshList();

            Validation.InitializePrintDocument(printDocument, "Class Schedule List", "Lista e Orarit të Klasës");
        }

        #region Button
        private void btnViewAll_Click_1(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
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
                        Validation.MessageBoxShow("Please select a class and a day!", "Empty",
                            "Ju lutem zgjedheni një klasë dhe një datë!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Validation.MessageBoxShow("Schedule does not exist!", "Doesn't exist",
                            "Orari nuk ekziston!", "Nuk ekziston", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                Validation.MessageBoxShow("A problem occurred while searching data!", "Problem",
                            "Ndodhi një problem gjatë kërkimit të të dhënave!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateSchedule();
        }

        #region Menu
        private void btnAddClass_Click(object sender, EventArgs e)
        {
            ClassScheduleCreate addSchedule = new ClassScheduleCreate()
            {
                StartPosition = FormStartPosition.CenterParent
            };
            addSchedule.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateSchedule();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            dgvScheduleList.PrintPreview(printDocument);
        }

        #region Export
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread((ThreadStart)(() =>
            {
                var saveFileDialog = Validation.SaveFile("ClassScheduleList", "ListaEOraritTëKlasës", ".xlsx", "Excel Workbook |*.xlsx");

                saveFileDialog.ShowDialog();

                Validation.ExportToExcel(dgvScheduleList, saveFileDialog.FileName, "ClassScheduleList", "ListaEOraritTëKlasës");

                Validation.MessageBoxShow("Excel file created succesfully!", "Created", "Excel file u krijua me sukses!", "U krijua",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }));

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread((ThreadStart)(() =>
            {
                var saveFileDialog = Validation.SaveFile("ClassScheduleList", "ListaEOraritTëKlasës", ".pdf", "Pdf Files|*.pdf");

                saveFileDialog.ShowDialog();

                Validation.ExportToPDF(dgvScheduleList, saveFileDialog.FileName);

                Validation.MessageBoxShow("PDF file created succesfully!", "Created", "PDF file u krijua me sukses!", "U krijua",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }));

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
        }
        #endregion

        #endregion
    }
}
