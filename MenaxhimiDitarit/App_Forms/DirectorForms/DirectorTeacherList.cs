using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using MenaxhimiDitarit.App_Code;
using MenaxhimiDitarit.BLL;
using MenaxhimiDitarit.BO;
using Telerik.WinControls.UI;

namespace MenaxhimiDitarit.DirectorForms
{
    public partial class DirectorTeacherList : Form
    {
        private readonly TeacherBLL _teacherBLL;
        private List<Teacher> MyTeachers;

        public DirectorTeacherList()
        {
            InitializeComponent();

            _teacherBLL = new TeacherBLL();
        }

        #region Metodat
        private void RefreshList()
        {
            MyTeachers = _teacherBLL.GetAll();
            dgvTeacherListD.DataSource = MyTeachers;
        }

        private Teacher GetTeacher(GridViewRowInfo teacherRow)
        {
            try
            {
                Teacher teacher = new Teacher
                {
                    TeacherID = (int)teacherRow.Cells["TeacherID"].Value,
                    FirstName = (string)teacherRow.Cells["FirstName"].Value,
                    LastName = (string)teacherRow.Cells["LastName"].Value,
                    Gender = (string)teacherRow.Cells["Gender"].Value,
                    City = (string)teacherRow.Cells["City"].Value,
                    Qualification = (string)teacherRow.Cells["Qualification"].Value,
                    DayofBirth = (DateTime)teacherRow.Cells["DayofBirth"].Value,
                    Email = (string)teacherRow.Cells["Email"].Value,
                    PhoneNo = (string)teacherRow.Cells["PhoneNo"].Value,
                    InsertBy = (string)teacherRow.Cells["InsertBy"].Value,
                    InsertDate = (DateTime)teacherRow.Cells["InsertDate"].Value,
                    LUB = (string)teacherRow.Cells["LUB"].Value,
                    LUD = (DateTime)teacherRow.Cells["LUD"].Value,
                    LUN = (int)teacherRow.Cells["LUN"].Value
                };

                return teacher;
            }
            catch (Exception)
            {
                Validation.MessageBoxShow("A problem occurred while getting those data!", "Problem",
                            "Ndodhi një problem gjatë marrjes së këtyre të dhënave!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void UpdateTeacher()
        {
            if (dgvTeacherListD.SelectedRows.Count > 0)
            {
                var row = dgvTeacherListD.SelectedRows[0].Index;
                if (row >= 0)
                {
                    var teacher = GetTeacher(dgvTeacherListD.Rows[row]);
                    if (teacher != null)
                    {
                        TeacherCreate teacherUpdate = new TeacherCreate(teacher)
                        {
                            StartPosition = FormStartPosition.CenterParent
                        };
                        teacherUpdate.ShowDialog();
                    }
                }
            }
            RefreshList();
        }

        private void DeleteTeacher()
        {
            if (dgvTeacherListD.SelectedRows.Count > 0)
            {
                var row = dgvTeacherListD.SelectedRows[0].Index;
                if (row >= 0)
                {
                    var teacher = GetTeacher(dgvTeacherListD.Rows[row]);
                    if (teacher != null)
                    {
                        var result = Validation.MessageBoxShow($"Are you sure you want to delete {teacher.FullName}?", "Sure?",
                            $"A je i/e sigurt që do ta fshini: {teacher.FullName}?", "Sigurt?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            _teacherBLL.Remove(teacher.TeacherID);

                            Validation.MessageBoxShow($"Teacher: {teacher.FullName} has been deleted successfully!", "Deleted",
                                $"Arsimtari: {teacher.FullName} u fshi!", "U fshi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            RefreshList();
                        }
                    }
                }
            }
            RefreshList();
        }
        #endregion

        private void DirectorTeacherListForm_Load(object sender, EventArgs e)
        {
            RefreshList();

            Validation.InitializePrintDocument(printDocument, "Teacher List", "Lista e Arsimtarit");
        }

        #region Button
        private void btnViewAllTeachers_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnSearchTeachers_Click(object sender, EventArgs e)
        {
            try
            {
                if (_teacherBLL != null)
                {
                    if (txtSearchName.Text.Trim().Length > 0)
                    {
                        var findTeacher = MyTeachers.Where(f => f.FirstName.Contains(txtSearchName.Text)
                        || f.LastName.Contains(txtSearchName.Text) || f.FullName.Contains(txtSearchName.Text)).ToList();

                        dgvTeacherListD.DataSource = findTeacher;
                    }
                    else
                    {
                        Validation.MessageBoxShow("Please write a name!", "Empty",
                            "Ju lutem shkruani një emër!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    Validation.MessageBoxShow("Teacher does not exist!", "Doesn't exist",
                        "Arsimtari nuk ekziston!", "Nuk ekziston", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            UpdateTeacher();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteTeacher();
        }
        #endregion

        #region Search Textbox
        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            Validation.Capitalize(txtSearchName);
        }

        private void txtSearchName_Click(object sender, EventArgs e)
        {
            txtSearchName.Clear();
        }

        private void txtSearchName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchTeachers_Click(this, new EventArgs());
            }
        }

        private void txtSearchName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.NoNumber(e);
        }
        #endregion

        #region Menu
        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            TeacherCreate addTeacher = new TeacherCreate
            {
                StartPosition = FormStartPosition.CenterParent
            };
            addTeacher.ShowDialog();
            RefreshList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateTeacher();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteTeacher();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            dgvTeacherListD.PrintPreview(printDocument);
        }

        #region Export
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread((ThreadStart)(() =>
            {
                var saveFileDialog = Validation.SaveFile("TeacherList", "ListaEArsimtarit", ".xlsx", "Excel Workbook |*.xlsx");

                saveFileDialog.ShowDialog();

                Validation.ExportToExcel(dgvTeacherListD, saveFileDialog.FileName, "TeacherList", "ListaEArsimtarit");
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
                var saveFileDialog = Validation.SaveFile("TeacherList", "ListaEArsimtarit", ".pdf", "Pdf Files|*.pdf");

                saveFileDialog.ShowDialog();

                Validation.ExportToPDF(dgvTeacherListD, saveFileDialog.FileName);
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