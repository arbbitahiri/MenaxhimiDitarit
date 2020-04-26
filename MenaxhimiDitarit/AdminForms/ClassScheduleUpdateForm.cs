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

namespace MenaxhimiDitarit.AdminForms
{
    public partial class ClassScheduleUpdateForm : Form
    {
        private readonly ClassScheduleBLL _scheduleBLL;
        private ClassSchedule _schedule;
        private readonly bool update = false;

        private readonly SubjectBLL _subjectBLL;
        private List<Subject> _subject;

        public ClassScheduleUpdateForm()
        {
            InitializeComponent();

            _scheduleBLL = new ClassScheduleBLL();
            _subjectBLL = new SubjectBLL();

            _subject = _subjectBLL.GetAll();
            cmbSelectSubject.DataSource = _subject;

            update = false;
        }

        public ClassScheduleUpdateForm(ClassSchedule schedule)
        {
            InitializeComponent();

            _scheduleBLL = new ClassScheduleBLL();
            _subjectBLL = new SubjectBLL();

            _schedule = schedule;

            _subject = _subjectBLL.GetAll();
            cmbSelectSubject.DataSource = _subject;

            update = _schedule != null;

            PopulateForm(_schedule);
        }

        private void PopulateForm(ClassSchedule schedule)
        {
            txtID.Text = schedule.ScheduleID.ToString();
            cmbSelectClass.SelectedItem = schedule.ClassID;
            cmbSelectSubject.SelectedItem = _subject.FirstOrDefault(f => f.SubjectID == schedule.SubjectID);
            cmbSelectTime.SelectedItem = schedule.Time;
            cmbSelectDate.SelectedItem = schedule.Date;
        }

        private void btnSubmitClass_Click(object sender, EventArgs e)
        {
            ClassSchedule schedule = new ClassSchedule();

            schedule.ScheduleID = int.Parse(txtID.Text);
            schedule.ClassID = Convert.ToInt32(cmbSelectClass.SelectedIndex + 1);
            schedule.SubjectID = Convert.ToInt32(cmbSelectSubject.SelectedIndex + 1);
            schedule.Time = Convert.ToInt32(cmbSelectTime.SelectedValue.ToString());
            schedule.Date = cmbSelectTime.SelectedValue.ToString();
            //schedule.InsertBy = UserSession.GetUser.UserName;
            //schedule.InsertDate = DateTime.Now;
            schedule.LUB = UserSession.GetUser.UserName;
            schedule.LUD = DateTime.Now;

            if (!update)
                schedule.LUN++;
            else if (update)
                schedule.LUN = ++_schedule.LUN;

            if (!update)
            {
                bool isRegistred = _scheduleBLL.Add(schedule);

                if (isRegistred)
                {
                    MessageBox.Show("Schedule registred successfully", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Registration failed, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Schedule Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
