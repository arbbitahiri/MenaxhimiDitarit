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
    public partial class ClassScheduleCreate : Form
    {
        private readonly ClassScheduleBLL _scheduleBLL;
        private ClassSchedule _schedule;
        private List<ClassSchedule> MySchedules;

        private readonly bool update = false;

        private readonly SubjectBLL _subjectBLL;
        private List<Subject> MySubjects;

        private readonly ClassBLL _classBLL;
        private List<Class> MyClasses;

        public ClassScheduleCreate()
        {
            InitializeComponent();

            _scheduleBLL = new ClassScheduleBLL();
            _subjectBLL = new SubjectBLL();
            _classBLL = new ClassBLL();

            GetAll();

            update = false;
        }

        public ClassScheduleCreate(ClassSchedule schedule)
        {
            InitializeComponent();

            _scheduleBLL = new ClassScheduleBLL();
            _subjectBLL = new SubjectBLL();
            _classBLL = new ClassBLL();

            _schedule = schedule;

            GetAll();

            update = _schedule != null;

            PopulateForm(_schedule);
        }

        private void GetAll()
        {
            MySubjects = _subjectBLL.GetAll();
            MyClasses = _classBLL.GetAll();
            MySchedules = _scheduleBLL.GetAll();

            txtID.Enabled = false;
            txtYear.Enabled = false;
            cmbSelectSubject.DataSource = MySubjects;
            cmbSelectClass.DataSource = MyClasses;
        }

        private void PopulateForm(ClassSchedule schedule)
        {
            txtID.Text = schedule.ScheduleID.ToString();
            cmbSelectClass.SelectedItem = schedule.ClassID;
            cmbSelectSubject.SelectedItem = MySubjects.FirstOrDefault(f => f.SubjectID == schedule.SubjectID);
            cmbSelectTime.SelectedItem = schedule.Time;
            cmbSelectDate.SelectedItem = schedule.Day;
        }

        private bool CheckTextbox()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox txtb = ctrl as TextBox;
                    if (txtb.Text == string.Empty)
                        return false;
                }
            }
            return true;
        }

        private void btnSubmitClass_Click(object sender, EventArgs e)
        {
            if (CheckTextbox())
            {
                ClassSchedule schedule = new ClassSchedule();

                schedule.ScheduleID = int.Parse(txtID.Text);
                schedule.ClassID = Convert.ToInt32(cmbSelectClass.SelectedValue.ToString());
                schedule.SubjectID = Convert.ToInt32(cmbSelectSubject.SelectedValue.ToString());
                schedule.Time = Convert.ToInt32(cmbSelectTime.SelectedItem.ToString());
                schedule.Day = cmbSelectDate.SelectedItem.ToString();
                schedule.Year = int.Parse(txtYear.Text);
                schedule.InsertBy = UserSession.GetUser.UserName;
                schedule.LUB = UserSession.GetUser.UserName;

                if (!update)
                    schedule.LUN++;
                else if (update)
                    schedule.LUN = ++_schedule.LUN;

                if (!update)
                {
                    var temp = MySchedules.Where(f => f.ClassID == Convert.ToInt32(cmbSelectClass.SelectedValue.ToString())
                    && f.Day == cmbSelectDate.SelectedItem.ToString() && f.Time == Convert.ToInt32(cmbSelectTime.SelectedItem.ToString())).ToList();

                    if (temp.Count > 0)
                        MessageBox.Show("Schedule exists in that period!", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
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
                }
                else
                {
                    bool isUpdated = _scheduleBLL.Add(schedule);

                    if (isUpdated)
                    {
                        MessageBox.Show("Schedule updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Updated failed, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Plesae fill all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!Char.IsDigit(c) && c != 8)
                e.Handled = true;
        }
    }
}