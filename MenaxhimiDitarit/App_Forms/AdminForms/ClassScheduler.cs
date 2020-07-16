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

        private readonly ClassBLL _classBLL;
        private List<Class> MyClasses;

        private readonly SubjectBLL _subjectBLL;
        private List<Subject> MySubjects;

        private readonly ClassScheduleBLL _scheduleBLL;
        private List<ClassSchedule> MySchedules;

        public ClassScheduler(Class classes)
        {
            InitializeComponent();

            _classBLL = new ClassBLL();
            _subjectBLL = new SubjectBLL();
            _scheduleBLL = new ClassScheduleBLL();

            _class = classes;

            MyClasses = _classBLL.GetAll();
            MySubjects = _subjectBLL.GetAll();
            MySchedules = _scheduleBLL.GetAll();

            DisableTextbox();
            PopulateFormClass(_class);
        }

        public ClassScheduler(int classNo)
        {
            InitializeComponent();

            _classBLL = new ClassBLL();
            _subjectBLL = new SubjectBLL();
            _scheduleBLL = new ClassScheduleBLL();

            MyClasses = _classBLL.GetAll();
            MySubjects = _subjectBLL.GetAll();
            MySchedules = _scheduleBLL.GetAll();

            DisableTextbox();
            PopulateFormTopic(classNo);
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
        private void PopulateFormClass(Class classes)
        {
            txtMonday1.Text = GetSubjectTitleClass(classes, "Monday", 1); txtTuesday1.Text = GetSubjectTitleClass(classes, "Tuesday", 1);
            txtMonday2.Text = GetSubjectTitleClass(classes, "Monday", 2); txtTuesday2.Text = GetSubjectTitleClass(classes, "Tuesday", 2);
            txtMonday3.Text = GetSubjectTitleClass(classes, "Monday", 3); txtTuesday3.Text = GetSubjectTitleClass(classes, "Tuesday", 3);
            txtMonday4.Text = GetSubjectTitleClass(classes, "Monday", 4); txtTuesday4.Text = GetSubjectTitleClass(classes, "Tuesday", 4);
            txtMonday5.Text = GetSubjectTitleClass(classes, "Monday", 5); txtTuesday5.Text = GetSubjectTitleClass(classes, "Tuesday", 5);
            txtMonday6.Text = GetSubjectTitleClass(classes, "Monday", 6); txtTuesday6.Text = GetSubjectTitleClass(classes, "Tuesday", 6);

            txtWednesday1.Text = GetSubjectTitleClass(classes, "Wednesday", 1);
            txtWednesday2.Text = GetSubjectTitleClass(classes, "Wednesday", 2);
            txtWednesday3.Text = GetSubjectTitleClass(classes, "Wednesday", 3);
            txtWednesday4.Text = GetSubjectTitleClass(classes, "Wednesday", 4);
            txtWednesday5.Text = GetSubjectTitleClass(classes, "Wednesday", 5);
            txtWednesday6.Text = GetSubjectTitleClass(classes, "Wednesday", 6);

            txtThursday1.Text = GetSubjectTitleClass(classes, "Thursday", 1); txtFriday1.Text = GetSubjectTitleClass(classes, "Friday", 1);
            txtThursday2.Text = GetSubjectTitleClass(classes, "Thursday", 2); txtFriday2.Text = GetSubjectTitleClass(classes, "Friday", 2);
            txtThursday3.Text = GetSubjectTitleClass(classes, "Thursday", 3); txtFriday3.Text = GetSubjectTitleClass(classes, "Friday", 3);
            txtThursday4.Text = GetSubjectTitleClass(classes, "Thursday", 4); txtFriday4.Text = GetSubjectTitleClass(classes, "Friday", 4);
            txtThursday5.Text = GetSubjectTitleClass(classes, "Thursday", 5); txtFriday5.Text = GetSubjectTitleClass(classes, "Friday", 5);
            txtThursday6.Text = GetSubjectTitleClass(classes, "Thursday", 6); txtFriday6.Text = GetSubjectTitleClass(classes, "Friday", 6);
        }

        /// <summary>
        /// Populates the form with the adequate data from the list form
        /// </summary>
        /// <param name="classes"></param>
        private void PopulateFormTopic(int classNo)
        {
            txtMonday1.Text = GetSubjectTitleTopic(classNo, "Monday", 1); txtTuesday1.Text = GetSubjectTitleTopic(classNo, "Tuesday", 1);
            txtMonday2.Text = GetSubjectTitleTopic(classNo, "Monday", 2); txtTuesday2.Text = GetSubjectTitleTopic(classNo, "Tuesday", 2);
            txtMonday3.Text = GetSubjectTitleTopic(classNo, "Monday", 3); txtTuesday3.Text = GetSubjectTitleTopic(classNo, "Tuesday", 3);
            txtMonday4.Text = GetSubjectTitleTopic(classNo, "Monday", 4); txtTuesday4.Text = GetSubjectTitleTopic(classNo, "Tuesday", 4);
            txtMonday5.Text = GetSubjectTitleTopic(classNo, "Monday", 5); txtTuesday5.Text = GetSubjectTitleTopic(classNo, "Tuesday", 5);
            txtMonday6.Text = GetSubjectTitleTopic(classNo, "Monday", 6); txtTuesday6.Text = GetSubjectTitleTopic(classNo, "Tuesday", 6);

            txtWednesday1.Text = GetSubjectTitleTopic(classNo, "Wednesday", 1);
            txtWednesday2.Text = GetSubjectTitleTopic(classNo, "Wednesday", 2);
            txtWednesday3.Text = GetSubjectTitleTopic(classNo, "Wednesday", 3);
            txtWednesday4.Text = GetSubjectTitleTopic(classNo, "Wednesday", 4);
            txtWednesday5.Text = GetSubjectTitleTopic(classNo, "Wednesday", 5);
            txtWednesday6.Text = GetSubjectTitleTopic(classNo, "Wednesday", 6);

            txtThursday1.Text = GetSubjectTitleTopic(classNo, "Thursday", 1); txtFriday1.Text = GetSubjectTitleTopic(classNo, "Friday", 1);
            txtThursday2.Text = GetSubjectTitleTopic(classNo, "Thursday", 2); txtFriday2.Text = GetSubjectTitleTopic(classNo, "Friday", 2);
            txtThursday3.Text = GetSubjectTitleTopic(classNo, "Thursday", 3); txtFriday3.Text = GetSubjectTitleTopic(classNo, "Friday", 3);
            txtThursday4.Text = GetSubjectTitleTopic(classNo, "Thursday", 4); txtFriday4.Text = GetSubjectTitleTopic(classNo, "Friday", 4);
            txtThursday5.Text = GetSubjectTitleTopic(classNo, "Thursday", 5); txtFriday5.Text = GetSubjectTitleTopic(classNo, "Friday", 5);
            txtThursday6.Text = GetSubjectTitleTopic(classNo, "Thursday", 6); txtFriday6.Text = GetSubjectTitleTopic(classNo, "Friday", 6);
        }

        /// <summary>
        /// Gets the SubjectTitle depending on day and time
        /// </summary>
        /// <param name="classes"></param>
        /// <param name="day">Day of the subject</param>
        /// <param name="time">Time of the subject</param>
        /// <returns>The subject title</returns>
        private string GetSubjectTitleClass(Class classes, string day, int time)
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

        /// <summary>
        /// Gets the SubjectTitle depending on day and time
        /// </summary>
        /// <param name="classes"></param>
        /// <param name="day">Day of the subject</param>
        /// <param name="time">Time of the subject</param>
        /// <returns>The subject title</returns>
        private string GetSubjectTitleTopic(int classNo, string day, int time)
        {
            foreach (var subject in MySubjects)
            {
                foreach (var schedule in MySchedules)
                {
                    if (GetClassID(classNo) == schedule.ClassID)
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

        /// <summary>
        /// Gets the class ID depending on the Class Number
        /// </summary>
        /// <param name="classNo">The class number</param>
        /// <returns>The class ID</returns>
        private int GetClassID(int classNo)
        {
            foreach (var id in MyClasses)
            {
                if (classNo == id.ClassNo)
                {
                    return id.ClassID;
                }
            }
            return 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
