using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenaxhimiDitarit.AdminForms;
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
                    ClassID = (int)classRow.Cells[0].Value,
                    TeacherID = (int)classRow.Cells[1].Value,
                    ClassNo = (int)classRow.Cells[2].Value,
                    RoomID = (int)classRow.Cells[3].Value,
                    InsertBy = (string)classRow.Cells[4].Value,
                    InsertDate = (DateTime)classRow.Cells[5].Value,
                    LUB = (string)classRow.Cells[6].Value,
                    LUD = (DateTime)classRow.Cells[7].Value,
                    LUN = (int)classRow.Cells[8].Value
                };

                return classes;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void btnViewAllClass_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void ClassListForm_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (_classBLL != null)
            {
                if (txtSearchClass.Text.Trim().Length > 0)
                {
                    var findClass = MyClasses.Where(f => f.ClassNo == int.Parse(txtSearchClass.Text)).ToList();

                    dgvClassesList.DataSource = findClass;
                }
                else
                    MessageBox.Show("Please write a class number!!", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Class number does not exist!!", "Doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvClassesList.SelectedRows.Count > 0)
            {
                var row = dgvClassesList.SelectedRows[0].Index;
                if (row >= 0)
                {
                    var classes = GetClass(dgvClassesList.Rows[row]);
                    if (classes != null)
                    {
                        ClassCreate classUpdate = new ClassCreate(classes);
                        classUpdate.StartPosition = FormStartPosition.CenterParent;
                        classUpdate.ShowDialog();
                    }
                }
            }
            RefreshList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvClassesList.SelectedRows.Count > 0)
            {
                var row = dgvClassesList.SelectedRows[0].Index;
                if (row >= 0)
                {
                    var classes = GetClass(dgvClassesList.Rows[row]);
                    if (classes != null)
                    {
                        if (MessageBox.Show($"Are you sure you want to delete class: {classes.ClassNo}?", "Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                            == DialogResult.OK)
                        {
                            _classBLL.Remove(classes.ClassID);
                            MessageBox.Show($"Class: {classes.ClassNo} has been deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshList();
                        }
                        else
                            MessageBox.Show("Please try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
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
                        ClassScheduler viewSchedule = new ClassScheduler(classes);
                        viewSchedule.StartPosition = FormStartPosition.CenterParent;
                        viewSchedule.ShowDialog();
                    }
                }
            };
        }

        private void txtSearchClass_Click(object sender, EventArgs e)
        {
            txtSearchClass.Text = "";
        }

        private void txtSearchClass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch_Click(this, new EventArgs());
        }
    }
}
