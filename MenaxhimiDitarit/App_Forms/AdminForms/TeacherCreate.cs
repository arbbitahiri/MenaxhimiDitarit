using System;
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
using System.Threading;
using MenaxhimiDitarit.App_Code;

namespace MenaxhimiDitarit
{
    public partial class TeacherCreate : Form
    {
        private readonly TeacherBLL _teacherBLL;
        private Teacher _teacher;
        private List<Teacher> MyTeachers;

        private bool update = false;

        public TeacherCreate()
        {
            InitializeComponent();

            _teacherBLL = new TeacherBLL();
            MyTeachers = _teacherBLL.GetAll();

            update = false;

            CostumizeDesign();
        }

        public TeacherCreate(Teacher teacher)
        {
            InitializeComponent();

            _teacherBLL = new TeacherBLL();

            _teacher = teacher;

            update = teacher != null;

            PopulateForm(_teacher);
            CostumizeDesign();
        }

        #region Metodat
        private void CostumizeDesign()
        {
            txtID.Enabled = false;
            rbtnMale.Checked = true;
        }

        //Popullimi i TextBox-ave dhe DateTimePicker me te dhenat nga Teacher
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
        #endregion

        #region Eventet
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                bool isEmail = Validation.IsValid(@"^([\w\.\-]+)@([\w\-]+)\.([\w]+)$", txtEmail);
                bool isPhone = Validation.IsValid(@"[0-9]{3}[\)-\..\s][0-9]{3}[\)-\..\s][0-9]{3}[\)-\..\s][0-9]{3}", txtPhoneNo);

                if (!isPhone)
                {
                    Validation.MessageBoxShow("The phone number you entered is not valid!", "Warning",
                                    "Numri i telefonit nuk është valid", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (!isEmail)
                    {
                        Validation.MessageBoxShow("The email you entered is not valid!", "Warning",
                                       "Emaili nuk është valid!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        DateTime birthdate = Convert.ToDateTime(dtpBirthday.Text);

                        var age = Validation.GetAge(birthdate);
                        if (age < 18)
                        {
                            Validation.MessageBoxShow("Teacher must be older than 18 years old!", "Error",
                                "Arsimtari nuk duhet të jetë më i vogël se 18 vjet!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (Validation.CheckTextbox(this))
                            {
                                Teacher teacher = new Teacher
                                {
                                    TeacherID = int.Parse(txtID.Text),
                                    FirstName = txtFirstName.Text,
                                    LastName = txtLastName.Text,
                                    Gender = Validation.GetSelectedRBTN(grbGender),
                                    City = txtCity.Text,
                                    Qualification = txtQualification.Text,
                                    DayofBirth = dtpBirthday.Value.Date,
                                    Email = txtEmail.Text,
                                    PhoneNo = txtPhoneNo.Text,

                                    InsertBy = UserSession.GetUser.UserName,
                                    LUB = UserSession.GetUser.UserName
                                };

                                if (!update)
                                    teacher.LUN++;
                                else if (update)
                                    teacher.LUN = ++_teacher.LUN;

                                if (!update)
                                {
                                    //Shikojme nese ekziston nje Emer i tille
                                    var checkTeacher = MyTeachers.Where(t => t.FirstName == txtFirstName.Text).ToList();

                                    if (checkTeacher.Count > 0)
                                    {
                                        var result = Validation.MessageBoxShow($"There is already a teacher called {teacher.FirstName}. Do you still want to continue?", "Warning",
                                           $"Ekziston një arsimtarë me emrin {teacher.FirstName}. Doni të vazhdoni?", "Paralajmërim", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                        if (result == DialogResult.No)
                                        {
                                            teacher = null;
                                            update = false;
                                            txtCity.Text = ""; txtEmail.Text = ""; txtFirstName.Text = ""; txtLastName.Text = "";
                                            txtPhoneNo.Text = ""; txtQualification.Text = "";
                                        }
                                        else
                                        {
                                            bool isRegistred = _teacherBLL.Add(teacher);

                                            if (isRegistred)
                                            {
                                                Validation.MessageBoxShow($"Teacher {teacher.FullName} registred successfully!", "Completed",
                                                    $"Arsimtari {teacher.FullName} u regjistrua me sukses!", "U regjistrua", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                        bool isRegistred = _teacherBLL.Add(teacher);

                                        if (isRegistred)
                                        {
                                            Validation.MessageBoxShow($"Teacher {teacher.FullName} registred successfully!", "Completed",
                                                $"Arsimtari {teacher.FullName} u regjistrua me sukses!", "U regjistrua", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                    bool isUpdated = _teacherBLL.Add(teacher);

                                    if (isUpdated)
                                    {
                                        Validation.MessageBoxShow($"Teacher {teacher.FullName} updated!", "Updated",
                                            $"Arsimtari {teacher.FullName} u përditësua me sukses!", "U përditësua", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    }
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

        private void dtpBirthday_CloseUp(object sender, EventArgs e)
        {
            DateTime birthdate = Convert.ToDateTime(dtpBirthday.Text);

            var age = Validation.GetAge(birthdate);
            if (age < 18)
            {
                Validation.MessageBoxShow("Teacher must be older than 18 years old!", "Error",
                    "Arsimtari nuk duhet të jetë më i vogël se 18 vjet!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region KeyPress
        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.NoNumber(e);
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.NoNumber(e);
        }

        private void txtCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.NoNumber(e);
        }

        private void txtPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.NoLetter(e);
        }
        #endregion

        #region ErrorProvier
        private void picFirstName_MouseHover(object sender, EventArgs e)
        {
            if (txtFirstName.Text == null)
            {
                Validation.ToolTipShow("First name is required!", "Emri duhet të plotësohet!", picFirstName);
            }
            else if (txtFirstName.Text.Length < 2)
            {
                Validation.ToolTipShow("First name is to short!", "Emri është i shkurtë!", picFirstName);
            }
        }

        private void picLastName_MouseHover(object sender, EventArgs e)
        {
            if (txtLastName.Text == null)
            {
                Validation.ToolTipShow("Last name is required!", "Mbiemri duhet të plotësohet!", picLastName);
            }
            else if (txtLastName.Text.Length < 2)
            {
                Validation.ToolTipShow("Last name is to short!", "Mbiemri është i shkurtë!", picLastName);
            }
        }

        private void picCity_MouseHover(object sender, EventArgs e)
        {
            if (txtCity.Text == null)
            {
                Validation.ToolTipShow("City is required!", "Qyteti duhet të plotësohet!", picCity);
            }
            else if (txtCity.Text.Length < 2)
            {
                Validation.ToolTipShow("City is to short!", "Qyteti është i shkurtë!", picCity);
            }
        }

        private void picQualification_MouseHover(object sender, EventArgs e)
        {
            if (txtQualification.Text == null)
            {
                Validation.ToolTipShow("Qualification is required!", "Kualifikimi duhet të plotësohet!", picQualification);
            }
            else if (txtQualification.Text.Length < 4)
            {
                Validation.ToolTipShow("Qualification is to short!", "Kualifikimi është i shkurtë!", picQualification);
            }
        }

        private void picEmail_MouseHover(object sender, EventArgs e)
        {
            bool isEmail = Validation.IsValid(@"^([\w\.\-]+)@([\w\-]+)\.([\w]+)$", txtEmail);

            if (txtEmail.Text == null)
            {
                Validation.ToolTipShow("E-mail is required! Please write in correct format:\nexample@gmail.com",
                    "Email duhet të plotësohet. Ju lutem shkruani në formë korrekte:\nexample@gmail.com", picEmail);
            }
            else if (txtEmail.Text.Length < 10)
            {
                Validation.ToolTipShow("E-mail is to short! Please write in correct format:\nexample@gmail.com",
                    "Email është i shkurtë. Ju lutem shkruani në formë korrekte:\nexample@gmail.com", picEmail);
            }
            else if (!isEmail)
            {
                Validation.ToolTipShow("E-mail is in wrong format. Please write in correct format:\nexample@gmail.com",
                    "Email është në format të gabuar. Ju lutem shkruani në formë korrekte:\nexample@gmail.com", picEmail);
            }
        }

        private void picPhoneNo_MouseHover(object sender, EventArgs e)
        {
            bool isPhone = Validation.IsValid(@"[0-9]{3}[\)-\..\s][0-9]{3}[\)-\..\s][0-9]{3}[\)-\..\s][0-9]{3}", txtPhoneNo);

            if (txtPhoneNo.Text == null)
            {
                Validation.ToolTipShow("Phone number is required! Please write in correct format:\n444 044 444 444\n444-044-444-444",
                    "Numri i telefonit duhet të plotësohet Ju lutem shkruani në formë korrekte:\n555 044 444 444\n444-044-444-444", picPhoneNo);
            }
            else if(txtPhoneNo.Text.Length < 8)
            {
                Validation.ToolTipShow("Phone number is to short! Please write in correct format:\n444 044 444 444\n444-044-444-444",
                    "Numri i telefonit duhet të plotësohet! Ju lutem shkruani në formë korrekte:\n444 044 444 444\n444-044-444-444", picPhoneNo);
            }
            else if (!isPhone)
            {
                Validation.ToolTipShow("Phone number is in wrong format! Please write in correct format:\n444 044 444 444\n444-044-444-444",
                    "Numri i telefonit është në format të gabuar. Ju lutem shkruani në formë korrekte:\n444 044 444 444\n444-044-444-444", picPhoneNo);
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Length > 0)
            {
                Validation.Capitalize(txtFirstName);
            }

            if (txtFirstName.Text != null && txtFirstName.Text.Length > 2)
            {
                picFirstName.Visible = false;
            }
            else
            {
                Validation.SetImageVisibility(picFirstName);
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (txtLastName.Text.Length > 0)
            {
                Validation.Capitalize(txtLastName);
            }

            if (txtLastName.Text != null && txtLastName.Text.Length > 2)
            {
                picLastName.Visible = false;
            }
            else
            {
                Validation.SetImageVisibility(picLastName);
            }
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            if (txtCity.Text.Length > 0)
            {
                Validation.Capitalize(txtCity);
            }

            if (txtCity.Text != null && txtCity.Text.Length > 3)
            {
                picCity.Visible = false;
            }
            else
            {
                Validation.SetImageVisibility(picCity);
            }
        }

        private void txtQualification_TextChanged(object sender, EventArgs e)
        {
            if (txtQualification.Text.Length > 0)
            {
                Validation.Capitalize(txtQualification);
            }

            if (txtQualification.Text != null && txtQualification.Text.Length > 4)
            {
                picQualification.Visible = false;
            }
            else
            {
                Validation.SetImageVisibility(picQualification);
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            bool isEmail = Validation.IsValid(@"^([\w\.\-]+)@([\w\-]+)\.([\w]+)$", txtEmail);

            if (txtEmail.Text != null && txtEmail.Text.Length > 10 && isEmail)
            {
                picEmail.Visible = false;
            }
            else
            {
                Validation.SetImageVisibility(picEmail);
            }
        }

        private void txtPhoneNo_TextChanged(object sender, EventArgs e)
        {
            bool isPhone = Validation.IsValid(@"[0-9]{3}[\)-\..\s]\([0-9]{3}\)[\)-\..\s][0-9]{3}[\)-\..\s][0-9]{4}", txtPhoneNo);

            if (txtPhoneNo.Text != null && txtPhoneNo.Text.Length > 8 && isPhone)
            {
                picPhoneNo.Visible = false;
            }
            else
            {
                Validation.SetImageVisibility(picPhoneNo);
            }
        }
        #endregion
    }
}