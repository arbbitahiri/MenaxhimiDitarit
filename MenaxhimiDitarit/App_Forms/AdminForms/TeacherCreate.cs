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

        //Marrim tekstin te RadioButton-it
        private string GetSelectedRBTN()
        {
            foreach (Control ctrl in grbGender.Controls)
            {
                if (ctrl is RadioButton && ((RadioButton)ctrl).Checked == true)
                    return ctrl.Text;
            }
            return null;
        }

        //Marrim moshen
        private int GetAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            if (birthDate > today.AddYears(-age))
                age--;
            return age;
        }

        //Shikojme nese TextBox-at jane te mbushur me te dhena
        private bool CheckTextbox()
        {
            foreach (Control ctrl in this.Controls) {
                if (ctrl is TextBox) {
                    TextBox txtb = ctrl as TextBox;
                    if (txtb.Text == string.Empty)
                        return false;
                }
            }
            return true;
        }

        //Shikojme nese Email esht valid
        private bool CheckEmail(string reg, TextBox textBox)
        {
            Regex regex = new Regex(reg);

            if (regex.IsMatch(textBox.Text))
                return true;
            else
                return false;
        }
        #endregion

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                bool isEmail = CheckEmail(@"^([\w\.\-]+)@([\w\-]+)\.([\w]+)$", txtEmail);

                if (!isEmail)
                    MessageBox.Show("The email you entered is not valid!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (CheckTextbox())
                    {
                        Teacher teacher = new Teacher();

                        teacher.TeacherID = int.Parse(txtID.Text);
                        teacher.FirstName = txtFirstName.Text;
                        teacher.LastName = txtLastName.Text;
                        teacher.Gender = GetSelectedRBTN();
                        teacher.City = txtCity.Text;
                        teacher.Qualification = txtQualification.Text;
                        teacher.DayofBirth = dtpBirthday.Value.Date;
                        teacher.Email = txtEmail.Text;
                        teacher.PhoneNo = txtPhoneNo.Text;
                        teacher.InsertBy = UserSession.GetUser.UserName;
                        teacher.LUB = UserSession.GetUser.UserName;

                        if (!update)
                            teacher.LUN++;
                        else if (update)
                            teacher.LUN = ++_teacher.LUN;

                        if (!update)
                        {
                            //Shikojme nese ekziston nje Emer i tille
                            var temp = MyTeachers.Where(t => t.FirstName == txtFirstName.Text).ToList();

                            if (temp.Count > 0)
                            {
                                if (MessageBox.Show($"There is already a teacher called {teacher.FirstName}. Do you want to continue?",
                                    "Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
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
                                        MessageBox.Show($"Teacher {teacher.FullName} registred successfully", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Close();
                                    }
                                    else
                                        MessageBox.Show("Registration failed, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                bool isRegistred = _teacherBLL.Add(teacher);

                                if (isRegistred)
                                {
                                    MessageBox.Show($"Teacher {teacher.FullName} registred successfully", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                    MessageBox.Show("Registration failed, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            bool isUpdated = _teacherBLL.Add(teacher);

                            if (isUpdated)
                            {
                                MessageBox.Show($"Teacher: {teacher.FullName} updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Updated failed, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                        MessageBox.Show("Please fill all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"A problem occurred while registering data!\n{ex.Message}", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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