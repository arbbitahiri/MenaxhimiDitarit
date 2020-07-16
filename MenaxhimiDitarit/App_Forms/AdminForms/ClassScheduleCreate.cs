using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MenaxhimiDitarit.App_Code;
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

            MySubjects = _subjectBLL.GetAll();
            MyClasses = _classBLL.GetAll();
            MySchedules = _scheduleBLL.GetAll();

            CustomizeDesign();

            update = false;
        }

        public ClassScheduleCreate(ClassSchedule schedule)
        {
            InitializeComponent();

            _scheduleBLL = new ClassScheduleBLL();
            _subjectBLL = new SubjectBLL();
            _classBLL = new ClassBLL();

            MySubjects = _subjectBLL.GetAll();
            MyClasses = _classBLL.GetAll();
            MySchedules = _scheduleBLL.GetAll();

            _schedule = schedule;

            CustomizeDesign();

            update = _schedule != null;

            PopulateForm(_schedule);
        }

        #region Methods
        /// <summary>
        /// Puts default value in txtYear, disables txtID and txtYear, and gets the data to combobox
        /// </summary>
        private void CustomizeDesign()
        {
            txtYear.Text = DateTime.Now.Year.ToString();

            txtYear.Enabled = false;

            cmbSelectSubject.DataSource = MySubjects;
            cmbSelectClass.DataSource = MyClasses;
        }

        /// <summary>
        /// Populates the form with the adequate data from the list form
        /// </summary>
        /// <param name="schedule"></param>
        private void PopulateForm(ClassSchedule schedule)
        {
            txtID.Text = schedule.ScheduleID.ToString();
            cmbSelectClass.SelectedItem = schedule.ClassID;
            cmbSelectSubject.SelectedItem = MySubjects.FirstOrDefault(f => f.SubjectID == schedule.SubjectID);
            cmbSelectTime.SelectedItem = schedule.Time;
            cmbSelectDate.SelectedItem = schedule.Day;
        }

        /// <summary>
        /// Creates or updates the schedule, depending on ID
        /// </summary>
        private void CreateSchedule()
        {
            try
            {
                if (Validation.CheckTextbox(this))
                {
                    ClassSchedule schedule = new ClassSchedule
                    {
                        ScheduleID = int.Parse(txtID.Text),
                        ClassID = Convert.ToInt32(cmbSelectClass.SelectedValue.ToString()),
                        SubjectID = Convert.ToInt32(cmbSelectSubject.SelectedValue.ToString()),
                        Time = Convert.ToInt32(cmbSelectTime.SelectedItem.ToString()),
                        Day = cmbSelectDate.SelectedItem.ToString(),
                        Year = int.Parse(txtYear.Text),
                        InsertBy = UserSession.GetUser.UserName,
                        LUB = UserSession.GetUser.UserName
                    };

                    if (!update)
                        schedule.LUN++;
                    else if (update)
                        schedule.LUN = ++_schedule.LUN;

                    if (!update)
                    {
                        var checkSchedules = MySchedules.Where(t => t.ClassID == Convert.ToInt32(cmbSelectClass.SelectedValue.ToString())
                        && t.Day == cmbSelectDate.SelectedItem.ToString() && t.Time == Convert.ToInt32(cmbSelectTime.SelectedItem.ToString())).ToList();

                        if (checkSchedules.Count > 0)
                        {
                            MessageDialog.MessageBoxShow("Schedule exists in that period!", "Exists",
                                   "Orari ekziston për atë periudhë!", "Ekziston", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            bool isRegistred = _scheduleBLL.Add(schedule);

                            if (isRegistred)
                            {
                                MessageDialog.DoYouWantToContinue(this, "Schedule", "Orari");
                            }
                            else
                            {
                                MessageDialog.MessageBoxShow("Registration failed!", "Error",
                                    "Regjistrimi dështoi!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        bool isUpdated = _scheduleBLL.Add(schedule);

                        if (isUpdated)
                        {
                            MessageDialog.MessageBoxShow("Schedule updated.", "Information",
                                "Orari u përditësua.", "U përditësua", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }
                        else
                        {
                            MessageDialog.MessageBoxShow("Update failed!", "Error",
                                "Përditësimi dështoi!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageDialog.MessageBoxShow("Please fill all fields!", "Error",
                        "Ju lutem plotësoni të gjitha fushat!", "Kujdes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageDialog.MessageBoxShow("A problem occurred while registering data!", "Error",
                    "Ndodhi një problem gjatë regjistrimit të të dhënave!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Events
        // Buttons
        private void btnSubmitClass_Click(object sender, EventArgs e)
        {
            CreateSchedule();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Validation.CloseForm(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Validation.CloseForm(this);
        }
        #endregion

        #region ErrorProvider
        private void picClass_MouseHover(object sender, EventArgs e)
        {
            MessageDialog.ToolTipShow("Please select a class!", "Zgjedheni një klasën!", picClass);
        }

        private void picSubject_MouseHover(object sender, EventArgs e)
        {
            MessageDialog.ToolTipShow("Please select a subject!", "Zgjedheni një lëndë!", picSubject);
        }

        private void picTime_MouseHover(object sender, EventArgs e)
        {
            MessageDialog.ToolTipShow("Please select a time!", "Zgjedheni një orë!", picTime);
        }

        private void picDate_MouseHover(object sender, EventArgs e)
        {
            MessageDialog.ToolTipShow("Please select a date!", "Zgjedheni një datë!", picDate);
        }

        private void cmbSelectClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelectClass.SelectedIndex != -1)
            {
                picClass.Visible = false;
            }
            else
            {
                Validation.SetImageVisibility(picClass);
            }
        }

        private void cmbSelectSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelectSubject.SelectedIndex != -1)
            {
                picSubject.Visible = false;
            }
            else
            {
                Validation.SetImageVisibility(picSubject);
            }
        }

        private void cmbSelectTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelectTime.SelectedIndex != -1)
            {
                picTime.Visible = false;
            }
            else
            {
                Validation.SetImageVisibility(picTime);
            }
        }

        private void cmbSelectDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelectDate.SelectedIndex != -1)
            {
                picDate.Visible = false;
            }
            else
            {
                Validation.SetImageVisibility(picDate);
            }
        }
        #endregion
    }
}