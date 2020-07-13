using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MenaxhimiDitarit.App_Code;
using MenaxhimiDitarit.BLL;
using MenaxhimiDitarit.BO;

namespace MenaxhimiDitarit.TeacherForms
{
    public partial class AbsenceCreate : Form
    {
        private readonly TopicBLL _absenceBLL;
        private Topic _absence;
        private List<Topic> MyAbsences;

        private bool update = false;

        private readonly SubjectBLL _subjectBLL;
        private List<Subject> MySubjects;

        private readonly ClassBLL _classBLL;
        private List<Class> MyClasses;

        private readonly ClassScheduleBLL _scheduleBLL;
        private List<ClassSchedule> MySchedules;

        public AbsenceCreate()
        {
            InitializeComponent();

            _absenceBLL = new TopicBLL();
            _subjectBLL = new SubjectBLL();
            _classBLL = new ClassBLL();
            _scheduleBLL = new ClassScheduleBLL();

            update = false;

            MySubjects = _subjectBLL.GetAll();
            MyClasses = _classBLL.GetAll();
            MySchedules = _scheduleBLL.GetAll();
            MyAbsences = _absenceBLL.GetAllTopic();

            CustomizeDesign();
        }

        public AbsenceCreate(Topic absence)
        {
            InitializeComponent();

            _absenceBLL = new TopicBLL();
            _subjectBLL = new SubjectBLL();
            _classBLL = new ClassBLL();
            _scheduleBLL = new ClassScheduleBLL();

            MyAbsences = _absenceBLL.GetAllAbsence();
            MySubjects = _subjectBLL.GetAll();
            MyClasses = _classBLL.GetAll();
            MySchedules = _scheduleBLL.GetAll();

            _absence = absence;

            update = _absence != null;

            CustomizeDesign();
            PopulateForm(absence);
        }

        #region Metodat
        private void CustomizeDesign()
        {
            txtID.Enabled = false;
            dtpSelectDate.Enabled = false;
            cmbSelectClass.DataSource = MyClasses;
            cmbSelectSubject.DataSource = MySubjects;
        }

        private void PopulateForm(Topic absence)
        {
            txtID.Text = absence.TopicID.ToString();
            cmbSelectClass.SelectedItem = MyClasses.FirstOrDefault(f => f.ClassID == absence.ClassID);
            cmbSelectSubject.SelectedItem = MySubjects.FirstOrDefault(f => f.SubjectID == absence.SubjectID);
            dtpSelectDate.Value = absence.Date;
            txtNoStudents.Text = absence.NoStudents.ToString();
        }
        #endregion

        #region Buttons
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validation.CheckTextbox(this))
                {
                    Topic absence = new Topic
                    {
                        TopicID = int.Parse(txtID.Text),
                        ClassID = Convert.ToInt32(cmbSelectClass.SelectedValue.ToString()),
                        SubjectID = Convert.ToInt32(cmbSelectSubject.SelectedValue.ToString()),
                        Reasoning = cmbReasoning.SelectedItem.ToString(),
                        NoStudents = int.Parse(txtNoStudents.Text),
                        Time = Convert.ToInt32(cmbSelectTime.SelectedItem.ToString()),
                        Date = dtpSelectDate.Value,
                        InsertBy = UserSession.GetUser.UserName,
                        LUB = UserSession.GetUser.UserName
                    };

                    if (!update)
                        absence.LUN++;
                    else if (update)
                        absence.LUN = ++_absence.LUN;

                    var checkSchedule = MySchedules.Where(t => t.ClassID == Convert.ToInt32(cmbSelectClass.SelectedValue.ToString())
                        && t.SubjectID == Convert.ToInt32(cmbSelectSubject.SelectedValue.ToString()) && t.Time == int.Parse(cmbSelectTime.Text)
                        && t.Day == dtpSelectDate.Value.DayOfWeek.ToString()).ToList();

                    if (checkSchedule.Count > 0)
                    {
                        if (!update)
                        {
                            var checkAbsence = MyAbsences.Where(t => t.ClassID == Convert.ToInt32(cmbSelectClass.SelectedValue.ToString())
                            && t.SubjectID == Convert.ToInt32(cmbSelectSubject.SelectedValue.ToString()) && t.Time == int.Parse(cmbSelectTime.Text)
                            && t.Date == DateTime.Parse(dtpSelectDate.Value.ToShortDateString())).ToList();

                            if (checkAbsence.Count > 0)
                            {
                                Validation.MessageBoxShow("Absence exists!", "Exists",
                                    "Mungesa ekziston!", "Ekziston", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                bool isRegistred = _absenceBLL.AddAbsence(absence);

                                if (isRegistred)
                                {
                                    Validation.MessageBoxShow("Absence registered successfully!", "Registered",
                                        "Mungesa u regjistrua me sukses!", "U regjistrua", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
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
                            bool isUpdated = _absenceBLL.AddAbsence(absence);

                            if (isUpdated)
                            {
                                Validation.MessageBoxShow("Absence updated", "Updated",
                                    "Mungesa u përditësua", "U përditësua", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        Validation.MessageBoxShow("Can't create absence for that time!", "Error",
                            "Nuk mund të krijojë mungesë për atë kohë!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Validation.MessageBoxShow("Please fill all fields!", "Error",
                        "Ju lutem plotësoni të gjitha fushat!", "Kujdes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                string eee = ex.Message;
                Validation.MessageBoxShow("A problem occurred while registering data!", "Error",
                    "Ndodhi një problem gjatë regjistrimit të të dhënave!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        #endregion

        #region ErrorProvider
        private void txtNoStudents_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.NoLetter(e);
        }

        private void picClass_MouseHover(object sender, EventArgs e)
        {
            Validation.ToolTipShow("Class is required!", "Klasa duhet të plotësohet!", picClass);
        }

        private void picSubjetct_MouseHover(object sender, EventArgs e)
        {
            Validation.ToolTipShow("Subject is required!", "Lënda duhet të plotësohet!", picSubject);
        }

        private void picTime_MouseHover(object sender, EventArgs e)
        {
            Validation.ToolTipShow("Time is required!", "Ora duhet të plotësohet!", picTime);
        }

        private void picReasoning_MouseHover(object sender, EventArgs e)
        {
            Validation.ToolTipShow("Select a reason!", "Zgjedh arsyen!", picReasoning);
        }

        private void picNoStudents_MouseHover(object sender, EventArgs e)
        {
            Validation.ToolTipShow("Write numbers of students that are absence!", "Shkruaj numrat e studentëve që mungojnë!", picNoStudents);
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

        private void cmbReasoning_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbReasoning.SelectedIndex != -1)
            {
                picReasoning.Visible = false;
            }
            else
            {
                Validation.SetImageVisibility(picReasoning);
            }
        }

        private void txtNoStudents_TextChanged(object sender, EventArgs e)
        {
            if (txtNoStudents.Text != null)
            {
                picNoStudents.Visible = false;
            }
            else
            {
                Validation.SetImageVisibility(picNoStudents);
            }
        }
        #endregion
    }
}
