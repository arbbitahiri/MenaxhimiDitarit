﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void DisableTextbox()
        {
            foreach (Control ctrl in this.Controls) {
                if (ctrl is TextBox) {
                    TextBox txtb = ctrl as TextBox;
                    txtb.Enabled = false;
                }
            }
        }

        //Popullimi i TextBox-ave me te dhenat nga Class
        private void PopulateForm(Class classes)
        {
            txtMonday1.Text = GetDayTime(classes, "Monday", 1); txtTuesday1.Text = GetDayTime(classes, "Tuesday", 1); txtWednesday1.Text = GetDayTime(classes, "Wednesday", 1);
            txtMonday2.Text = GetDayTime(classes, "Monday", 2); txtTuesday2.Text = GetDayTime(classes, "Tuesday", 2); txtWednesday2.Text = GetDayTime(classes, "Wednesday", 2);
            txtMonday3.Text = GetDayTime(classes, "Monday", 3); txtTuesday3.Text = GetDayTime(classes, "Tuesday", 3); txtWednesday3.Text = GetDayTime(classes, "Wednesday", 3);
            txtMonday4.Text = GetDayTime(classes, "Monday", 4); txtTuesday4.Text = GetDayTime(classes, "Tuesday", 4); txtWednesday4.Text = GetDayTime(classes, "Wednesday", 4);
            txtMonday5.Text = GetDayTime(classes, "Monday", 5); txtTuesday5.Text = GetDayTime(classes, "Tuesday", 5); txtWednesday5.Text = GetDayTime(classes, "Wednesday", 5);
            txtMonday6.Text = GetDayTime(classes, "Monday", 6); txtTuesday6.Text = GetDayTime(classes, "Tuesday", 6); txtWednesday6.Text = GetDayTime(classes, "Wednesday", 6);

            txtThursday1.Text = GetDayTime(classes, "Thursday", 1); txtFriday1.Text = GetDayTime(classes, "Friday", 1);
            txtThursday2.Text = GetDayTime(classes, "Thursday", 2); txtFriday2.Text = GetDayTime(classes, "Friday", 2);
            txtThursday3.Text = GetDayTime(classes, "Thursday", 3); txtFriday3.Text = GetDayTime(classes, "Friday", 3);
            txtThursday4.Text = GetDayTime(classes, "Thursday", 4); txtFriday4.Text = GetDayTime(classes, "Friday", 4);
            txtThursday5.Text = GetDayTime(classes, "Thursday", 5); txtFriday5.Text = GetDayTime(classes, "Friday", 5);
            txtThursday6.Text = GetDayTime(classes, "Thursday", 6); txtFriday6.Text = GetDayTime(classes, "Friday", 6);

        }

        //Marrim emrin e lendes varesisht nga te dhenat e klases, diten dhe oren
        private string GetDayTime(Class classes, string day, int time)
        {
            foreach (var subject in MySubjects)
            {
                foreach (var schedule in MySchedules)
                {
                    if (classes.ClassID == schedule.ClassID)
                    {
                        if (schedule.Day == day && schedule.Time == time && schedule.SubjectID == subject.SubjectID)
                            return subject.SubjectTitle;
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
