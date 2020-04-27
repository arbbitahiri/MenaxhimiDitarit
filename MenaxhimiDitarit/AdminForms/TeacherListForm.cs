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

namespace MenaxhimiDitarit
{
    public partial class TeacherListForm : Form
    {
        private readonly TeacherBLL _teacherBLL;
        private List<Teacher> MyTeachers;

        public TeacherListForm()
        {
            InitializeComponent();

            _teacherBLL = new TeacherBLL();
        }

        private void RefreshList()
        {
            MyTeachers = _teacherBLL.GetAll();
            dgvTeacherList.DataSource = MyTeachers;
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
                    InsertBy = (string)teacherRow.Cells[9].Value,
                    InsertDate = (DateTime)teacherRow.Cells[10].Value,
                    LUB = (string)teacherRow.Cells[11].Value,
                    LUD = (DateTime)teacherRow.Cells[12].Value,
                    LUN = (int)teacherRow.Cells[13].Value
                };

                return teacher;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void txtSearchName_Click(object sender, EventArgs e)
        {
            txtSearchName.Clear();
        }

        private void TeacherListForm_Load(object sender, EventArgs e)
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

                    dgvTeacherList.DataSource = findTeacher;
                }
                else
                    MessageBox.Show("Please write a name!!", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Teacher does not exist!!", "Doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTeacherList.SelectedRows.Count > 0)
            {
                var row = dgvTeacherList.SelectedRows[0].Index;
                if (row >= 0)
                {
                    var teacher = GetTeacher(dgvTeacherList.Rows[row]);
                    if (teacher != null)
                    {
                        TeacherCreateForm teacherUpdate = new TeacherCreateForm(teacher);
                        teacherUpdate.StartPosition = FormStartPosition.CenterParent;
                        teacherUpdate.ShowDialog();
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
