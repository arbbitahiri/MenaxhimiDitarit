﻿using System;
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
            cmbSelectSubject.Enabled = false;
            PopulateForm(absence);
        }

        #region Methods
        /// <summary>
        /// Disables textbox and datetimepicker, and gets data to combobox
        /// </summary>
        private void CustomizeDesign()
        {
            dtpSelectDate.Enabled = false;
            cmbSelectClass.DataSource = MyClasses;
            //cmbSelectSubject.DataSource = Validation.GetSubjects(UserSession.GetUser.TeacherID, MySubjects);
        }

        /// <summary>
        /// Populates the form with the adequate data from the list form
        /// </summary>
        /// <param name="absence"></param>
        private void PopulateForm(Topic absence)
        {
            txtID.Text = absence.TopicID.ToString();
            cmbSelectClass.SelectedItem = MyClasses.FirstOrDefault(f => f.ClassID == absence.ClassID);
            cmbSelectSubject.SelectedItem = MySubjects.FirstOrDefault(f => f.SubjectID == absence.SubjectID);
            dtpSelectDate.Value = absence.Date;
            txtNoStudents.Text = absence.NoStudents.ToString();
        }

        /// <summary>
        /// Creates or updates the absence, depending on ID
        /// </summary>
        private void CreateAbsence()
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
                            && t.Date == DateTime.Parse(dtpSelectDate.Value.ToShortDateString()) && t.Reasoning == cmbReasoning.Text).ToList();

                            if (checkAbsence.Count > 0)
                            {
                                MessageDialog.MessageBoxShow("Absence exists!", "Exists",
                                    "Mungesa ekziston!", "Ekziston", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                bool isRegistred = _absenceBLL.AddAbsence(absence);

                                if (isRegistred)
                                {
                                    MessageDialog.DoYouWantToContinue(this, "Absence", "Mungesa");
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
                            bool isUpdated = _absenceBLL.AddAbsence(absence);

                            if (isUpdated)
                            {
                                MessageDialog.MessageBoxShow("Absence updated", "Updated",
                                    "Mungesa u përditësua", "U përditësua", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        MessageDialog.MessageBoxShow("Can't create absence for that time!", "Error",
                            "Nuk mund të krijojë mungesë për atë kohë!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CreateAbsence();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Validation.CloseForm(this);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Validation.CloseForm(this);
        }

        private void btnHELP_Click(object sender, EventArgs e)
        {
            MessageDialog.ShowHelp(this, "absencecreate.html");
        }
        #endregion

        #region ErrorProvider
        private void txtNoStudents_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.NoLetter(e);
        }

        private void picClass_MouseHover(object sender, EventArgs e)
        {
            MessageDialog.ToolTipShow("Class is required!", "Klasa duhet të plotësohet!", picClass);
        }

        private void picSubjetct_MouseHover(object sender, EventArgs e)
        {
            MessageDialog.ToolTipShow("Subject is required!", "Lënda duhet të plotësohet!", picSubject);
        }

        private void picTime_MouseHover(object sender, EventArgs e)
        {
            MessageDialog.ToolTipShow("Time is required!", "Ora duhet të plotësohet!", picTime);
        }

        private void picReasoning_MouseHover(object sender, EventArgs e)
        {
            MessageDialog.ToolTipShow("Select a reason!", "Zgjedh arsyen!", picReasoning);
        }

        private void picNoStudents_MouseHover(object sender, EventArgs e)
        {
            MessageDialog.ToolTipShow("Write numbers of students that are absence!", "Shkruaj numrat e studentëve që mungojnë!", picNoStudents);
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
