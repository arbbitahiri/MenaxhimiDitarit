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
        private bool IsValid(string reg, TextBox textBox)
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
                bool isEmail = IsValid(@"^([\w\.\-]+)@([\w\-]+)\.([\w]+)$", txtEmail);
                bool isPhone = IsValid(@"^(?:\(?)(\d{3})(?:[\)-\..\s]?)(\d{2})(?:[-\.\s]?)(\d{3})(?:[-\.\s]?)(\d{3})(?!\d)", txtPhoneNo);

                if (!isPhone)
                {
                    MessageBox.Show("The phone number you entered is not valid!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (!isEmail)
                    {
                        MessageBox.Show("The email you entered is not valid!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (CheckTextbox())
                        {
                            Teacher teacher = new Teacher
                            {
                                TeacherID = int.Parse(txtID.Text),
                                FirstName = txtFirstName.Text,
                                LastName = txtLastName.Text,
                                Gender = GetSelectedRBTN(),
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
                                            MessageBox.Show($"Teacher {teacher.FullName} registred successfully",
                                                "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                        MessageBox.Show($"Teacher {teacher.FullName} registred successfully",
                                            "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A problem occurred while registering data!\n{ex.Message}",
                    "Problem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!CheckTextbox())
            {
                var result = MessageBox.Show(this, "you have written something. do you want to close?",
                    "sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                    this.Close();
            }
        }

        private void dtpBirthday_CloseUp(object sender, EventArgs e)
        {
            DateTime birthdate = Convert.ToDateTime(dtpBirthday.Text);

            var age = GetAge(birthdate);
            if (age < 18)
                MessageBox.Show("Teacher must be older than 18 years old!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #region KeyPress
        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (char.IsDigit(c))
                e.Handled = true;
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (char.IsDigit(c))
                e.Handled = true;
        }

        private void txtCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (char.IsDigit(c))
                e.Handled = true;
        }

        private void txtPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8 && c != 32)
                e.Handled = true;
        }
        #endregion

        private void TeacherCreate_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (!txtCity.Text.Equals(""))
                {
                    var result = MessageBox.Show("You have something written, are you sure you want to exit?",
                        "Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                        e.Cancel = true;
                    else
                        e.Cancel = false;
                }
                else
                    e.Cancel = true;
            }
        }

        #region ErrorProvier
        ToolTip toolTip = new ToolTip();

        private void picFirstName_MouseHover(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Equals(""))
            {
                toolTip.Show("First name is required!", picFirstName);
            }
            else if (txtFirstName.Text.Length < 2)
            {
                toolTip.Show("First name is to short!", picFirstName);
            }
        }

        private void picLastName_MouseHover(object sender, EventArgs e)
        {
            if (txtLastName.Text.Equals(""))
            {
                toolTip.Show("Last name is required!", picLastName);
            }
            else if (txtLastName.Text.Length < 2)
            {
                toolTip.Show("Last name is to short!", picLastName);
            }
        }

        private void picCity_MouseHover(object sender, EventArgs e)
        {
            if (txtCity.Text.Equals(""))
            {
                toolTip.Show("City is required!", picCity);
            }
            else if (txtCity.Text.Length < 2)
            {
                toolTip.Show("City is to short!", picCity);
            }
        }

        private void picQualification_MouseHover(object sender, EventArgs e)
        {
            if (txtQualification.Text.Equals(""))
            {
                toolTip.Show("Qualification is required!", picQualification);
            }
            else if (txtQualification.Text.Length < 4)
            {
                toolTip.Show("Qualification is to short!", picQualification);
            }
        }

        private void picEmail_MouseHover(object sender, EventArgs e)
        {
            bool isEmail = IsValid(@"^([\w\.\-]+)@([\w\-]+)\.([\w]+)$", txtEmail);

            if (txtEmail.Text.Equals(""))
            {
                toolTip.Show("E-mail is required! Please write in correct format:\nexample@gmail.com", picEmail);
            }
            else if (txtEmail.Text.Length < 10)
            {
                toolTip.Show("E-mail is to short! Please write in correct format:\nexample@gmail.com", picEmail);
            }
            else if (!isEmail)
            {
                toolTip.Show("E-mail is in wrong format! Please write in correct format:\nexample@gmail.com", picEmail);
            }
        }

        private void picPhoneNo_MouseHover(object sender, EventArgs e)
        {
            bool isPhone = IsValid(@"^(?:\(?)(\d{3})(?:[\)-\..\s]?)(\d{2})(?:[-\.\s]?)(\d{3})(?:[-\.\s]?)(\d{3})(?!\d)", txtPhoneNo);

            if (txtPhoneNo.Text.Equals(""))
            {
                toolTip.Show("Phone number is required! Please write in correct format:\n555 55 555 555\n555-55-555-555", picPhoneNo);
            }
            else if(txtPhoneNo.Text.Length < 8)
            {
                toolTip.Show("Phone number is to short! Please write in correct format:\n555 55 555 555\n555-55-555-555", picPhoneNo);
            }
            else if (!isPhone)
            {
                toolTip.Show("Phone number is in wrong format! Please write in correct format:\n555 55 555 555\n555-55-555-555", picPhoneNo);
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Length > 0)
            {
                Capitalize(txtFirstName);
            }

            if (txtFirstName.Text != null && txtFirstName.Text.Length > 2)
            {
                picFirstName.Visible = false;
            }
            else
                SetImageVisibility(picFirstName);
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (txtLastName.Text.Length > 0)
            {
                Capitalize(txtLastName);
            }

            if (txtLastName.Text != null && txtLastName.Text.Length > 2)
            {
                picLastName.Visible = false;
            }
            else
                SetImageVisibility(picLastName);
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            if (txtCity.Text.Length > 0)
            {
                Capitalize(txtCity);
            }

            if (txtCity.Text != null && txtCity.Text.Length > 3)
            {
                picCity.Visible = false;
            }
            else
                SetImageVisibility(picCity);
        }

        private void txtQualification_TextChanged(object sender, EventArgs e)
        {
            if (txtQualification.Text.Length > 0)
            {
                Capitalize(txtQualification);
            }

            if (txtQualification.Text != null && txtQualification.Text.Length > 4)
            {
                picQualification.Visible = false;
            }
            else
                SetImageVisibility(picQualification);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            bool isEmail = IsValid(@"^([\w\.\-]+)@([\w\-]+)\.([\w]+)$", txtEmail);

            if (txtEmail.Text != null && txtEmail.Text.Length > 10 && isEmail)
            {
                picEmail.Visible = false;
            }
            else
                SetImageVisibility(picEmail);
        }

        private void txtPhoneNo_TextChanged(object sender, EventArgs e)
        {
            bool isPhone = IsValid(@"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$", txtPhoneNo);

            if (txtPhoneNo.Text != null && txtPhoneNo.Text.Length > 8 && isPhone)
            {
                picPhoneNo.Visible = false;
            }
            else
                SetImageVisibility(picPhoneNo);

        }

        private void Capitalize(TextBox textBox)
        {
            StringBuilder stringBuilder = new StringBuilder(textBox.Text.Length);
            bool capitalize = true;
            foreach (char c in textBox.Text)
            {
                stringBuilder.Append(capitalize ? char.ToUpper(c) : char.ToLower(c));
                capitalize = !char.IsLetter(c);
            }
            textBox.Text = stringBuilder.ToString();
            textBox.Select(textBox.Text.Length, 0);
        }

        private void SetImageVisibility(PictureBox pictureBox)
        {
            pictureBox.Image = Properties.Resources.icons8_cancel_15;
            pictureBox.Visible = true;
        }
        #endregion
    }
}