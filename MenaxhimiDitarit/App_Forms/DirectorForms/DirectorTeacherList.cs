using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        //Refresh i te dhenave ne DataGrid
        private void RefreshList()
        {
            MyTeachers = _teacherBLL.GetAll();
            dgvTeacherListD.DataSource = MyTeachers;
        }

        //Mirren te dhenat nga rreshti i klikuar
        private Teacher GetTeacher(GridViewRowInfo teacherRow)
        {
            try
            {
                Teacher teacher = new Teacher
                {
                    TeacherID = (int)teacherRow.Cells[0].Value,
                    FirstName = (string)teacherRow.Cells[1].Value,
                    LastName = (string)teacherRow.Cells[2].Value,
                    Gender = (string)teacherRow.Cells[3].Value,
                    City = (string)teacherRow.Cells[4].Value,
                    Qualification = (string)teacherRow.Cells[5].Value,
                    DayofBirth = (DateTime)teacherRow.Cells[6].Value,
                    Email = (string)teacherRow.Cells[7].Value,
                    PhoneNo = (string)teacherRow.Cells[8].Value,
                    InsertBy = (string)teacherRow.Cells[10].Value,
                    InsertDate = (DateTime)teacherRow.Cells[11].Value,
                    LUB = (string)teacherRow.Cells[12].Value,
                    LUD = (DateTime)teacherRow.Cells[13].Value,
                    LUN = (int)teacherRow.Cells[14].Value
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

        private void txtSearchName_Click(object sender, EventArgs e)
        {
            txtSearchName.Clear();
        }

        private void DirectorTeacherListForm_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnViewAllTeachers_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        //Kerkojm te dhenat ne DataGrid
        private void btnSearchTeachers_Click(object sender, EventArgs e)
        {
            try
            {
                if (_teacherBLL != null)
                {
                    if (txtSearchName.Text.Trim().Length > 0)
                    {
                        //Shikojme nese teksti i shkruar ne TextBox eshte FirstName apo LastName
                        var findTeacher = MyTeachers.Where(f => f.FirstName.Contains(txtSearchName.Text)
                        || f.LastName.Contains(txtSearchName.Text)).ToList();

                        dgvTeacherListD.DataSource = findTeacher;
                    }
                    else
                    {
                        Validation.MessageBoxShow("Please write a name!", "Empty",
                            "Ju lutem shkruani një emër!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        //Update te dhenat per rreshtin e klikuar ne DataGrid
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
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

        //Delete te dhenat per rreshtin e klikuar ne DataGrid
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void txtSearchName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearchTeachers_Click(this, new EventArgs());
        }
    }
}
