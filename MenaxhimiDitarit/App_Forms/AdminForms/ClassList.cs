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
using MenaxhimiDitarit.AdminForms;
using MenaxhimiDitarit.App_Code;
using MenaxhimiDitarit.App_Forms.AdminForms;
using MenaxhimiDitarit.BLL;
using MenaxhimiDitarit.BO;
using Telerik.WinControls.UI;

namespace MenaxhimiDitarit
{
    public partial class ClassList : Form
    {
        private readonly ClassBLL _classBLL;
        private List<Class> MyClasses;

        public ClassList()
        {
            InitializeComponent();

            dgvClassesList.SelectionMode = GridViewSelectionMode.FullRowSelect;

            _classBLL = new ClassBLL();
        }

        #region Metodat
        private void RefreshList()
        {
            MyClasses = _classBLL.GetAll();
            dgvClassesList.DataSource = MyClasses;
        }

        private Class GetClass(GridViewRowInfo classRow)
        {
            try
            {
                Class classes = new Class
                {
                    ClassID = (int)classRow.Cells["ClassID"].Value,
                    TeacherID = (int)classRow.Cells["TeacherID"].Value,
                    ClassNo = (int)classRow.Cells["ClassNo"].Value,
                    RoomID = (int)classRow.Cells["RoomID"].Value,
                    InsertBy = (string)classRow.Cells["InsertBy"].Value,
                    InsertDate = (DateTime)classRow.Cells["InsertDate"].Value,
                    LUB = (string)classRow.Cells["LUB"].Value,
                    LUD = (DateTime)classRow.Cells["LUD"].Value,
                    LUN = (int)classRow.Cells["LUN"].Value
                };

                return classes;
            }
            catch (Exception)
            {
                Validation.MessageBoxShow("A problem occurred while getting those data!", "Problem",
                            "Ndodhi një problem gjatë marrjes së këtyre të dhënave!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void UpdateClass()
        {
            if (dgvClassesList.SelectedRows.Count > 0)
            {
                var row = dgvClassesList.SelectedRows[0].Index;
                if (row >= 0)
                {
                    var classes = GetClass(dgvClassesList.Rows[row]);
                    if (classes != null)
                    {
                        ClassCreate classUpdate = new ClassCreate(classes)
                        {
                            StartPosition = FormStartPosition.CenterParent
                        };
                        classUpdate.ShowDialog();
                    }
                }
            }
            RefreshList();
        }

        private void DeleteClass()
        {
            if (dgvClassesList.SelectedRows.Count > 0)
            {
                var row = dgvClassesList.SelectedRows[0].Index;
                if (row >= 0)
                {
                    var classes = GetClass(dgvClassesList.Rows[row]);
                    if (classes != null)
                    {
                        var result = Validation.MessageBoxShow($"Are you sure you want to delete class: {classes.ClassNo}", "Sure?",
                            $"A je i/e sigurt që do ta fshini klasën: {classes.ClassNo}", "Sigurt?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            _classBLL.Remove(classes.ClassID);

                            Validation.MessageBoxShow($"Class: {classes.ClassNo} has been deleted successfully!", "Deleted",
                               $"Klasa: {classes.ClassNo} është fshirë me sukses!", "U fshi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            RefreshList();
                        }
                    }
                }
            }
        }
        #endregion

        private void ClassListForm_Load(object sender, EventArgs e)
        {
            RefreshList();

            Validation.InitializePrintDocument(printDocument, "Class List", "Lista e Klasës");
        }

        #region Button
        private void btnViewAllClass_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (_classBLL != null)
                {
                    if (txtSearchClass.Text.Trim().Length > 0)
                    {
                        var findClass = MyClasses.Where(f => f.ClassNo == int.Parse(txtSearchClass.Text)).ToList();

                        dgvClassesList.DataSource = findClass;
                    }
                    else
                    {
                        Validation.MessageBoxShow("Please write a class number!", "Empty",
                            "Ju lutem shkruani numrin e klasës!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    Validation.MessageBoxShow("Class number does not exist!", "Doesn't exist",
                            "Klasa nuk ekziston!", "Nuk ekziston", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            UpdateClass();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteClass();
        }

        private void viewScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvClassesList.SelectedRows.Count > 0)
            {
                var row = dgvClassesList.SelectedRows[0].Index;
                if (row >= 0)
                {
                    var classes = GetClass(dgvClassesList.Rows[row]);
                    if (classes != null)
                    {
                        ClassScheduler viewSchedule = new ClassScheduler(classes)
                        {
                            StartPosition = FormStartPosition.CenterParent
                        };
                        viewSchedule.ShowDialog();
                    }
                }
            };
        }
        #endregion

        #region Search Textbox
        private void txtSearchClass_Click(object sender, EventArgs e)
        {
            txtSearchClass.Text = "";
        }

        private void txtSearchClass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(this, new EventArgs());
            }
        }

        private void txtSearchClass_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.NoLetter(e);
        }
        #endregion

        #region Menu
        private void btnAddClass_Click(object sender, EventArgs e)
        {
            ClassCreate addClass = new ClassCreate
            {
                StartPosition = FormStartPosition.CenterParent
            };
            addClass.ShowDialog();
            RefreshList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateClass();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteClass();
        }

        private void btnPrintM_Click(object sender, EventArgs e)
        {
            dgvClassesList.PrintPreview(printDocument);
        }

        #region Export
        private void btnExport_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread((ThreadStart)(() =>
            {
                var saveFileDialog = Validation.SaveFile("ClassList", "ListaEKlasës", ".xlsx", "Excel Workbook |*.xlsx");

                saveFileDialog.ShowDialog();

                Validation.ExportToExcel(dgvClassesList, saveFileDialog.FileName, "ClassList", "ListaEKlasës");
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

                Validation.ExportToPDF(dgvClassesList, saveFileDialog.FileName);
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