using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenaxhimiDitarit.BLL;
using MenaxhimiDitarit.BO;
using Telerik.WinControls.UI;

namespace MenaxhimiDitarit.DirectorForms
{
    public partial class DirectorTeacherListForm : Form
    {
        private readonly TeacherBLL _teacherBLL;
        private List<Teacher> MyTeachers;

        public DirectorTeacherListForm()
        {
            InitializeComponent();

            _teacherBLL = new TeacherBLL();
        }

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
            catch (Exception ex)
            {
                string rrrrr = ex.Message;

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

        private void btnSearchTeachers_Click(object sender, EventArgs e)
        {
            if (_teacherBLL != null)
            {
                if (txtSearchName.Text.Trim().Length > 0)
                {
                    var findTeacher = MyTeachers.Where(f => f.FirstName.Contains(txtSearchName.Text) || f.LastName.Contains(txtSearchName.Text)).ToList();

                    dgvTeacherListD.DataSource = findTeacher;
                }
                else
                    MessageBox.Show("Please write a name!!", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Teacher does not exist!!", "Doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

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
                        TeacherCreateForm teacherUpdate = new TeacherCreateForm(teacher);
                        teacherUpdate.StartPosition = FormStartPosition.CenterParent;
                        teacherUpdate.ShowDialog();
                    }
                }
            }
        }

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
                        if (MessageBox.Show($"Are you sure you want to delete {teacher.FirstName} {teacher.LastName}?", "Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                            == DialogResult.OK)
                        {
                            _teacherBLL.Remove(teacher.TeacherID);
                            MessageBox.Show("The selected teacher has been deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshList();
                        }
                        else
                            MessageBox.Show("Please try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void txtSearchName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearchTeachers_Click(this, new EventArgs());
        }
    }
}
