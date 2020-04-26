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
        private readonly ClassScheduleBLL _scheduleBLL;
        private List<ClassSchedule> MySchedules;


        private readonly ClassBLL _classBLL;
        private readonly List<Class> MyClasses;

        public ClassScheduletList()
        {
            InitializeComponent();

            _scheduleBLL = new ClassScheduleBLL();
            _classBLL = new ClassBLL();

            MyClasses = _classBLL.GetAll();
            cmbSelectClass.DataSource = MyClasses;
        }

        private void RefreshList()
        {
            MySchedules = _scheduleBLL.GetAll();
            dgvScheduleList.DataSource = MySchedules;
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
                        ClassScheduleUpdateForm updateSchedule = new ClassScheduleUpdateForm(schedule);
                        updateSchedule.StartPosition = FormStartPosition.CenterParent;
                        updateSchedule.ShowDialog();
                    }
                }
            }
        }

        private void ClassScheduletList_Load_1(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnViewAll_Click_1(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (_scheduleBLL != null)
            {
                if (cmbSelectClass.SelectedIndex != -1 && cmbSelectDay.SelectedIndex != -1)
                {
                    var findSchedule = MySchedules.Where(f => f.ClassID == Convert.ToInt32(cmbSelectClass.SelectedValue.ToString()) && f.Date == cmbSelectDay.SelectedItem.ToString()).ToList();

                    dgvScheduleList.DataSource = findSchedule;
                }
                else
                    MessageBox.Show("Please select class and a day!!", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Schedule does not exist!!", "Doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
