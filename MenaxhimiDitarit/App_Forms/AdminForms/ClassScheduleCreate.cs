using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        #region Metodat
        private void CustomizeDesign()
        {
            txtYear.Text = DateTime.Now.Year.ToString();

            txtID.Enabled = false;
            txtYear.Enabled = false;

            cmbSelectSubject.DataSource = MySubjects;
            cmbSelectClass.DataSource = MyClasses;
        }

        //Popullimi i TextBox-it dhe ComboBox-ave me te dhenat nga ClassSchedule
        private void PopulateForm(ClassSchedule schedule)
        {
            txtID.Text = schedule.ScheduleID.ToString();
            cmbSelectClass.SelectedItem = schedule.ClassID;
            cmbSelectSubject.SelectedItem = MySubjects.FirstOrDefault(f => f.SubjectID == schedule.SubjectID);
            cmbSelectTime.SelectedItem = schedule.Time;
            cmbSelectDate.SelectedItem = schedule.Day;
        }
        #endregion

        private void btnSubmitClass_Click(object sender, EventArgs e)
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
                        //Shikojme nese ekziton orari i till
                        var checkSchedules = MySchedules.Where(t => t.ClassID == Convert.ToInt32(cmbSelectClass.SelectedValue.ToString())
                        && t.Day == cmbSelectDate.SelectedItem.ToString() && t.Time == Convert.ToInt32(cmbSelectTime.SelectedItem.ToString())).ToList();

                        if (checkSchedules.Count > 0)
                        {
                            Validation.MessageBoxShow("Schedule exists in that period!", "Exists",
                                   "Orari ekziston për atë periudhë!", "Ekziston", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            bool isRegistred = _scheduleBLL.Add(schedule);

                            if (isRegistred)
                            {
                                var result = Validation.MessageBoxShow("Schedule registred successfully. Do you want to continue?", "Registered",
                                    "Orari u regjistrua me sukses. Doni të vazhdoni?", "U regjistrua", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                                if (result != DialogResult.Yes)
                                {
                                    this.Close();
                                }
                            }
                            else
                            {
                                Validation.MessageBoxShow("Registration failed!", "Error",
                                    "Regjistrimi dështoi!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        bool isUpdated = _scheduleBLL.Add(schedule);

                        if (isUpdated)
                        {
                            Validation.MessageBoxShow("Schedule updated.", "Information",
                                "Orari u përditësua.", "U përditësua", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }
                        else
                        {
                            Validation.MessageBoxShow("Update failed!", "Error",
                                "Përditësimi dështoi!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    Validation.MessageBoxShow("Please fill all fields!", "Error",
                        "Ju lutem plotësoni të gjitha fushat!", "Kujdes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                Validation.MessageBoxShow("A problem occurred while registering data!", "Error",
                    "Ndodhi një problem gjatë regjistrimit të të dhënave!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Validation.CheckTextbox(this))
            {
                var result = Validation.MessageBoxShow("You have something written. Are you sure you want to exit form?", "Sure?",
                    "Keni të shkruar diçka. A je i/e sigurt që do të largoheni nga forma?", "Sigurt?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                    this.Close();
            }
            else
            {
                this.Close();
            }
        }

        #region ErrorProvider
        private void picClass_MouseHover(object sender, EventArgs e)
        {
            Validation.ToolTipShow("Please select a class!", "Zgjedheni një klasën!", picClass);
        }

        private void picSubject_MouseHover(object sender, EventArgs e)
        {
            Validation.ToolTipShow("Please select a subject!", "Zgjedheni një lëndë!", picSubject);
        }

        private void picTime_MouseHover(object sender, EventArgs e)
        {
            Validation.ToolTipShow("Please select a time!", "Zgjedheni një orë!", picTime);
        }

        private void picDate_MouseHover(object sender, EventArgs e)
        {
            Validation.ToolTipShow("Please select a date!", "Zgjedheni një datë!", picDate);
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