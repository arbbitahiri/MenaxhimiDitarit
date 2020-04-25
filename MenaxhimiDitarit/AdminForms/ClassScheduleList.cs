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

namespace MenaxhimiDitarit.AdminForms
{
    public partial class ClassScheduletList : Form
    {
        private Form activeForm = null;

        private readonly ClassScheduleBLL _scheduleBLL;
        private List<ClassSchedule> _schedule;

        public ClassScheduletList()
        {
            InitializeComponent();

            _scheduleBLL = new ClassScheduleBLL();
        }

        private void RefreshList()
        {
            _schedule = _scheduleBLL.GetAll();
            dgvScheduleList.DataSource = _schedule;
        }

        private ClassSchedule GetSchedule(GridViewRowInfo classRow)
        {
            try
            {
                ClassSchedule schedule = new ClassSchedule
                {
                    ScheduleID = (int)classRow.Cells[0].Value,
                    ClassID = (int)classRow.Cells[1].Value,
                    SubjectID = (int)classRow.Cells[2].Value,
                    Time = (int)classRow.Cells[3].Value,
                    Date = (string)classRow.Cells[4].Value,
                    Year = (int)classRow.Cells[5].Value,
                    InsertBy = (string)classRow.Cells[6].Value,
                    InsertDate = (DateTime)classRow.Cells[7].Value,
                    LUB = (string)classRow.Cells[8].Value,
                    LUD = (DateTime)classRow.Cells[9].Value,
                    LUN = (int)classRow.Cells[10].Value
                };

                return schedule;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void ClassScheduletList_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (_scheduleBLL != null)
            {
                if (cmbSelectClass.SelectedIndex != -1 && cmbSelectDay.SelectedIndex != -1)
                {
                    var findSchedule = _schedule.Where(f => f.ClassID == Convert.ToInt32(cmbSelectClass.SelectedIndex + 1) && f.Date == cmbSelectDay.SelectedItem.ToString()).ToList();

                    dgvScheduleList.DataSource = findSchedule;
                }
                else
                    MessageBox.Show("Please write a select class and a day!!", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Schedule does not exist!!", "Doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvScheduleList.SelectedRows.Count > 0)
            {
                var row = dgvScheduleList.SelectedRows[0].Index;
                if (row >= 0)
                {
                    var schedule = GetSchedule(dgvScheduleList.Rows[row]);
                    if (schedule != null)
                    {
                        ClassScheduleCreateForm updateSchedule = new ClassScheduleCreateForm(schedule);
                        updateSchedule.ShowDialog();
                    }
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvScheduleList.SelectedRows.Count > 0)
            {
                var row = dgvScheduleList.SelectedRows[0].Index;
                if (row >= 0)
                {
                    var schedule = GetSchedule(dgvScheduleList.Rows[row]);
                    if (schedule != null)
                    {
                        if (MessageBox.Show($"Are you sure you want to delete?", "Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                            == DialogResult.OK)
                        {
                            _scheduleBLL.Remove(schedule.ClassID);
                            MessageBox.Show("The selected schedule has been deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshList();
                        }
                        else
                            MessageBox.Show("Please try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
