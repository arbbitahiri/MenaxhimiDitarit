using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MenaxhimiDitarit.App_Code;
using MenaxhimiDitarit.BLL;
using MenaxhimiDitarit.BO;
using Telerik.WinControls.UI;

namespace MenaxhimiDitarit
{
    public partial class TeacherList : Form
    {
        private readonly TeacherBLL _teacherBLL;
        private List<Teacher> MyTeachers;

        public TeacherList()
        {
            InitializeComponent();

            dgvTeacherList.SelectionMode = GridViewSelectionMode.FullRowSelect;

            _teacherBLL = new TeacherBLL();
        }

        #region Methods
        /// <summary>
        /// Refreshes the list
        /// </summary>
        private void RefreshList()
        {
            MyTeachers = _teacherBLL.GetAll();
            dgvTeacherList.DataSource = MyTeachers;
        }

        /// <summary>
        /// Gets the teacher data, that we select in GridView
        /// </summary>
        /// <param name="teacherRow">The selected row</param>
        /// <returns>The data of teacher</returns>
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
                MessageDialog.MessageBoxShow("A problem occurred while getting those data!", "Problem",
                            "Ndodhi një problem gjatë marrjes së këtyre të dhënave!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// Opens the form to update the teacher
        /// </summary>
        private void UpdateTeacher()
        {
            if (dgvTeacherList.SelectedRows.Count > 0)
            {
                var row = dgvTeacherList.SelectedRows[0].Index;
                if (row >= 0)
                {
                    var teacher = GetTeacher(dgvTeacherList.Rows[row]);
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

        /// <summary>
        /// Searches the teacher, by Name
        /// </summary>
        private void SearchTeacher()
        {
            try
            {
                if (_teacherBLL != null)
                {
                    if (txtSearchName.Text.Trim().Length > 0)
                    {
                        var findTeacher = MyTeachers.Where(f => f.FirstName.Contains(txtSearchName.Text)
                        || f.LastName.Contains(txtSearchName.Text) || f.FullName.Contains(txtSearchName.Text)).ToList();

                        if (findTeacher.Count > 0)
                        {
                            dgvTeacherList.DataSource = findTeacher;
                        }
                        else
                        {
                            MessageDialog.MessageBoxShow("Nothing found!", "Empty",
                                "Nuk ka rezultat!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageDialog.MessageBoxShow("Please write a name!", "Empty",
                            "Ju lutem shkruani një emër!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageDialog.MessageBoxShow("Teacher does not exist!", "Doesn't exist",
                        "Arsimtari nuk ekziston!", "Nuk ekziston", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void TeacherListForm_Load(object sender, EventArgs e)
        {
            RefreshList();

            Validation.InitializePrintDocument(printDocument, "Teacher List", "Lista e Arsimtarit");
        }

        // Buttons
        private void btnViewAllTeachers_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnSearchTeachers_Click(object sender, EventArgs e)
        {
            SearchTeacher();
        }

        private void btnHELP_Click(object sender, EventArgs e)
        {
            MessageDialog.ShowHelp(this, "teacherslist.html");
        }

        // Tool Strip Menu
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateTeacher();
        }

        // Textboxes
        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchName.Text.Length > 0)
            {
                Validation.Capitalize(txtSearchName);
            }
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
        private void btnAddClass_Click(object sender, EventArgs e)
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            dgvTeacherList.PrintPreview(printDocument);
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            ExportFile.ExportExcel("TeacherList", "ListaEArsimtarit", ".xlsx", "Excel Workbook |*.xlsx", dgvTeacherList);

            MessageDialog.MessageBoxShow("Excel file created succesfully!", "Created", "Excel file u krijua me sukses!", "U krijua",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            ExportFile.ExportExcel("TeacherList", "ListaEArsimtarit", ".pdf", "Pdf Files|*.pdf", dgvTeacherList);

            MessageDialog.MessageBoxShow("PDF file created succesfully!", "Created", "PDF file u krijua me sukses!", "U krijua",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}