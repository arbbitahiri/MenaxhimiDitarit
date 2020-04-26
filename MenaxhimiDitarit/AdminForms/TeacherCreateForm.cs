﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MenaxhimiDitarit.BLL;
using MenaxhimiDitarit.BO;

namespace MenaxhimiDitarit
{
    public partial class TeacherCreateForm : Form
    {
        private readonly TeacherBLL _teacherBLL;
        private Teacher _teacher;
        private readonly bool update = false;

        public TeacherCreateForm()
        {
            InitializeComponent();

            _teacherBLL = new TeacherBLL();
            update = false;
        }

        public TeacherCreateForm(Teacher teacher)
        {
            InitializeComponent();

            _teacherBLL = new TeacherBLL();
            this._teacher = teacher;
            PopulateForm(this._teacher);
        }

        private void PopulateForm(Teacher teacher)
        {
            txtID.Text = teacher.TeacherID.ToString();
            txtFirstName.Text = teacher.FirstName;
            txtLastName.Text = teacher.LastName;
            txtCity.Text = teacher.City;
            txtQualification.Text = teacher.Qualification;
            dtpBirthday.Text = teacher.DayofBirth.ToString();
            txtEmail.Text = teacher.Email;
            txtPhoneNo.Text = teacher.PhoneNo;
        }

        private string GetSelectedRBTN()
        {
            foreach (Control ctrl in grbGender.Controls)
            {
                if (ctrl is RadioButton && ((RadioButton)ctrl).Checked == true)
                    return ctrl.Text;
            }
            return null;
        }

        private int GetAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            if (birthDate > today.AddYears(-age))
                age--;
            return age;
        }

        private bool CheckTextBox(string reg, TextBox textBox)
        {
            Regex regex = new Regex(reg);

            if (regex.IsMatch(textBox.Text))
                return true;
            else
                return false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool isEmail = CheckTextBox(@"^([\w]+)@([\w]+)\.([\w]+)$", txtEmail);
            if (isEmail)
            {
                Teacher teacher = new Teacher();

                teacher.TeacherID = int.Parse(txtID.Text);
                teacher.FirstName = txtFirstName.Text;
                teacher.LastName = txtLastName.Text;
                teacher.Gender = GetSelectedRBTN();
                teacher.City = txtCity.Text;
                teacher.Qualification = txtQualification.Text;
                teacher.DayofBirth = DateTime.Parse(dtpBirthday.Text);
                teacher.Email = txtEmail.Text;
                teacher.PhoneNo = txtPhoneNo.Text;
                teacher.InsertBy = UserSession.GetUser.UserName;
                teacher.InsertDate = DateTime.Now;
                teacher.LUB = UserSession.GetUser.UserName;
                teacher.LUD = DateTime.Now;

                if (!update)
                    teacher.LUN++;
                else if (update)
                    teacher.LUN = ++this._teacher.LUN;

                if (!update)
                {
                    bool isRegistred = _teacherBLL.Add(teacher);

                    if (isRegistred)
                    {
                        MessageBox.Show("Teacher registred successfully", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Registration failed, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Teacher Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
                MessageBox.Show("Please write a valid e-mail", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!Char.IsDigit(c) && c != 8 && c != 32)
                e.Handled = true;
        }

        private void dtpBirthday_CloseUp(object sender, EventArgs e)
        {
            DateTime birthdate = Convert.ToDateTime(dtpBirthday.Text);

            var age = GetAge(birthdate);
            if (age < 18)
                MessageBox.Show("Teacher must be older than 18 years old!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
