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
                var result = MessageBox.Show(this, "You have written something. Do you want to close?",
                    "Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                    this.Close();
            }
        }

        private void txtPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8 && c != 32)
                e.Handled = true;
        }

        private void dtpBirthday_CloseUp(object sender, EventArgs e)
        {
            DateTime birthdate = Convert.ToDateTime(dtpBirthday.Text);

            var age = GetAge(birthdate);
            if (age < 18)
                MessageBox.Show("Teacher must be older than 18 years old!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

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

        private void TeacherCreate_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (!CheckTextbox())
                {
                    var result = MessageBox.Show("You have something written, are you sure you want to exit?",
                        "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                        e.Cancel = false;
                    else if (result == DialogResult.No)
                        e.Cancel = true;
                }
                else
                    e.Cancel = true;
            }
        }

        private void txtFirstName_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtFirstName.Text != "")
            {
                string firstName = txtFirstName.Text;
                string fnToUpper = char.ToUpper(firstName[0]) + firstName.Substring(1);

                txtFirstName.Text = fnToUpper;
            }
        }

        private void txtLastName_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtLastName.Text != "")
            {
                string lastName = txtLastName.Text;
                string lnToUpper = char.ToUpper(lastName[0]) + lastName.Substring(1);

                txtLastName.Text = lnToUpper;
            }
        }

        private void txtCity_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtCity.Text != "")
            {
                string city = txtCity.Text;
                string cityToUpper = char.ToUpper(city[0]) + city.Substring(1);

                txtCity.Text = cityToUpper;
            }
        }

        #region ErrorProviers
        ToolTip toolTip = new ToolTip();

        private void picFirstName_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("First name is required!", picFirstName);
        }

        private void picLastName_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Last name is required!", picLastName);
        }

        private void picCity_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("City is required!", picCity);
        }

        private void picQualification_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Qualification is required!", picQualification);
        }

        private void picEmail_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("E-mail is required!", picEmail);
        }

        private void picPhoneNo_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Phone number is required!", picPhoneNo);
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (txtFirstName.Text != null && txtFirstName.Text.Length > 2)
                picFirstName.Visible = false;
            else
            {
                picFirstName.Image = Properties.Resources.icons8_cancel_15;
                picFirstName.Visible = true;
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (txtLastName.Text != null && txtLastName.Text.Length > 2)
                picLastName.Visible = false;
            else
            {
                picLastName.Image = Properties.Resources.icons8_cancel_15;
                picLastName.Visible = true;
            }
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            if (txtCity.Text != null && txtCity.Text.Length > 2)
                picCity.Visible = false;
            else
            {
                picCity.Image = Properties.Resources.icons8_cancel_15;
                picCity.Visible = true;
            }
        }

        private void txtQualification_TextChanged(object sender, EventArgs e)
        {
            if (txtQualification.Text != null && txtQualification.Text.Length > 2)
                picQualification.Visible = false;
            else
            {
                picQualification.Image = Properties.Resources.icons8_cancel_15;
                picQualification.Visible = true;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text != null && txtEmail.Text.Length > 2)
                picEmail.Visible = false;
            else
            {
                picEmail.Image = Properties.Resources.icons8_cancel_15;
                picEmail.Visible = true;
            }
        }

        private void txtPhoneNo_TextChanged(object sender, EventArgs e)
        {
            if (txtPhoneNo.Text != null && txtPhoneNo.Text.Length > 2)
                picPhoneNo.Visible = false;
            else
            {
                picPhoneNo.Image = Properties.Resources.icons8_cancel_15;
                picPhoneNo.Visible = true;
            }
        }
        #endregion
    }
}