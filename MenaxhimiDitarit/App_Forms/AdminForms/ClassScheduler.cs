using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MenaxhimiDitarit.BO;
using MenaxhimiDitarit.BLL;



namespace MenaxhimiDitarit.App_Forms.AdminForms
{
    public partial class ClassScheduler : Form
    {
        private Class _class;

        private readonly SubjectBLL _subjectBLL;
        private List<Subject> MySubjects;

        private readonly ClassScheduleBLL _scheduleBLL;
        private List<ClassSchedule> MySchedules;

        public ClassScheduler(Class classes)
        {
            InitializeComponent();

            _subjectBLL = new SubjectBLL();
            _scheduleBLL = new ClassScheduleBLL();

            _class = classes;

            MySubjects = _subjectBLL.GetAll();
            MySchedules = _scheduleBLL.GetAll();

            DisableTextbox();
            PopulateForm(_class);
        }

        /// <summary>
        /// Disables all textoxes in the form
        /// </summary>
        private void DisableTextbox()
        {
            foreach (Control ctrl in this.Controls) {
                if (ctrl is TextBox) {
                    TextBox txtb = ctrl as TextBox;
                    txtb.Enabled = false;
                }
            }
        }

        /// <summary>
        /// Populates the form with the adequate data from the list form
        /// </summary>
        /// <param name="classes"></param>
        private void PopulateForm(Class classes)
        {
            txtMonday1.Text = GetSubjectTitle(classes, "Monday", 1); txtTuesday1.Text = GetSubjectTitle(classes, "Tuesday", 1);
            txtMonday2.Text = GetSubjectTitle(classes, "Monday", 2); txtTuesday2.Text = GetSubjectTitle(classes, "Tuesday", 2);
            txtMonday3.Text = GetSubjectTitle(classes, "Monday", 3); txtTuesday3.Text = GetSubjectTitle(classes, "Tuesday", 3);
            txtMonday4.Text = GetSubjectTitle(classes, "Monday", 4); txtTuesday4.Text = GetSubjectTitle(classes, "Tuesday", 4);
            txtMonday5.Text = GetSubjectTitle(classes, "Monday", 5); txtTuesday5.Text = GetSubjectTitle(classes, "Tuesday", 5);
            txtMonday6.Text = GetSubjectTitle(classes, "Monday", 6); txtTuesday6.Text = GetSubjectTitle(classes, "Tuesday", 6);

            txtWednesday1.Text = GetSubjectTitle(classes, "Wednesday", 1);
            txtWednesday2.Text = GetSubjectTitle(classes, "Wednesday", 2);
            txtWednesday3.Text = GetSubjectTitle(classes, "Wednesday", 3);
            txtWednesday4.Text = GetSubjectTitle(classes, "Wednesday", 4);
            txtWednesday5.Text = GetSubjectTitle(classes, "Wednesday", 5);
            txtWednesday6.Text = GetSubjectTitle(classes, "Wednesday", 6);

            txtThursday1.Text = GetSubjectTitle(classes, "Thursday", 1); txtFriday1.Text = GetSubjectTitle(classes, "Friday", 1);
            txtThursday2.Text = GetSubjectTitle(classes, "Thursday", 2); txtFriday2.Text = GetSubjectTitle(classes, "Friday", 2);
            txtThursday3.Text = GetSubjectTitle(classes, "Thursday", 3); txtFriday3.Text = GetSubjectTitle(classes, "Friday", 3);
            txtThursday4.Text = GetSubjectTitle(classes, "Thursday", 4); txtFriday4.Text = GetSubjectTitle(classes, "Friday", 4);
            txtThursday5.Text = GetSubjectTitle(classes, "Thursday", 5); txtFriday5.Text = GetSubjectTitle(classes, "Friday", 5);
            txtThursday6.Text = GetSubjectTitle(classes, "Thursday", 6); txtFriday6.Text = GetSubjectTitle(classes, "Friday", 6);
        }

        /// <summary>
        /// Gets the SubjectTitle depending on day and time
        /// </summary>
        /// <param name="classes"></param>
        /// <param name="day">Day of the subject</param>
        /// <param name="time">Time of the subject</param>
        /// <returns>The subject title</returns>
        private string GetSubjectTitle(Class classes, string day, int time)
        {
            foreach (var subject in MySubjects)
            {
                foreach (var schedule in MySchedules)
                {
                    if (classes.ClassID == schedule.ClassID)
                    {
                        if (schedule.Day == day && schedule.Time == time && schedule.SubjectID == subject.SubjectID)
                        {
                            return subject.SubjectTitle;
                        }
                    }
                }
            }
            return null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
