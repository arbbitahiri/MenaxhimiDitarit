﻿using System;
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

        public AbsenceCreate()
        {
            InitializeComponent();

            _absenceBLL = new TopicBLL();
            _subjectBLL = new SubjectBLL();
            _classBLL = new ClassBLL();

            MyAbsences = _absenceBLL.GetAllAbsence();
            MySubjects = _subjectBLL.GetAll();
            MyClasses = _classBLL.GetAll();

            update = false;

            CustomizeDesign();
        }

        public AbsenceCreate(Topic absence)
        {
            InitializeComponent();

            _absenceBLL = new TopicBLL();
            _subjectBLL = new SubjectBLL();
            _classBLL = new ClassBLL();

            MyAbsences = _absenceBLL.GetAllAbsence();
            MySubjects = _subjectBLL.GetAll();
            MyClasses = _classBLL.GetAll();

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

                    if (!update)
                    {
                        var checkAbsence = MyAbsences.Where(t => t.SubjectID == Convert.ToInt32(cmbSelectSubject.SelectedItem.ToString())
                        && t.ClassID == Convert.ToInt32(cmbSelectClass.SelectedValue.ToString())
                        && t.Time == Convert.ToInt32(cmbSelectTime.SelectedValue.ToString())).ToList();

                        if (checkAbsence.Count > 0)
                        {
                            Validation.MessageBoxShow($"Absence exists for subject: {absence.Subject.SubjectTitle} in {absence.Time} hour for class {absence.Class.ClassNo}", "Exists",
                                $"Mungesa ekziston për lëndën: {absence.Subject.SubjectTitle} në orën e {absence.Time} për klasën {absence.Class.ClassNo}!", "Ekziston", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    Validation.MessageBoxShow("Please fill all fields!", "Error",
                        "Ju lutem plotësoni të gjitha fushat!", "Kujdes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                Validation.MessageBoxShow("A problem occurred while registering data!", "Error",
                    "Ndodhi një problem gjatë regjistrimit të të dhënave!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!Validation.CheckTextbox(this))
            {
                var result = Validation.MessageBoxShow("You have something written. Are you sure you want to exit form?", "Sure?",
                    "Keni të shkruar diçka. A je i/e sigurt që do të largoheni nga forma?", "Sigurt?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                    this.Close();
            }
        }

        private void txtNoStudents_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.NoLetter(e);
        }
    }
}
