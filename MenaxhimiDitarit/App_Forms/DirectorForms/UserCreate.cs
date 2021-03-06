﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MenaxhimiDitarit.App_Code;
using MenaxhimiDitarit.BLL;
using MenaxhimiDitarit.BO;

namespace MenaxhimiDitarit.DirectorForms
{
    public partial class UserCreate : Form
    {
        private readonly UserBLL _userBLL;
        private List<User> MyUsers;

        private readonly RoleBLL _roleBLL;
        private List<Role> MyRoles;

        private readonly TeacherBLL _teacherBLL;
        private List<Teacher> MyTeachers;

        public UserCreate()
        {
            InitializeComponent();

            _userBLL = new UserBLL();
            _roleBLL = new RoleBLL();
            _teacherBLL = new TeacherBLL();

            MyUsers = _userBLL.GetAllUser();
            MyRoles = _roleBLL.GetAll();
            MyTeachers = _teacherBLL.GetAll();

            cmbRoles.DataSource = MyRoles;

            txtPassword.UseSystemPasswordChar = true;
            txtConfirmPass.UseSystemPasswordChar = true;
        }

        #region Methods
        /// <summary>
        /// Creates the user
        /// </summary>
        private void CreateUser()
        {
            try
            {
                DateTime expireDate = Convert.ToDateTime(dtpExpireDate.Text);

                if (expireDate < DateTime.Now)
                {
                    MessageDialog.MessageBoxShow($"Expire date can't be from: {dtpExpireDate.Value}", "Error",
                        $"Data e skadimit nuk mund të jetë nga {dtpExpireDate.Value}", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Validation.CheckTextbox(this))
                    {
                        User user = new User
                        {
                            UserID = int.Parse(txtID.Text),
                            ExpiresDate = dtpExpireDate.Value,
                            RoleID = Convert.ToInt32(cmbRoles.SelectedValue.ToString()),
                            UserName = txtUsername.Text,
                            UserPassword = Validation.CalculateHash(txtPassword.Text),
                            InsertBy = UserSession.GetUser.UserName,
                            LUB = UserSession.GetUser.UserName,
                            TeacherID = Convert.ToInt32(cmbTeacher.SelectedValue.ToString())
                        };
                        user.LUN++;

                        if (cmbTeacher.SelectedIndex != -1)
                        {
                            user.FirstName = Validation.GetTeacher(Convert.ToInt32(cmbTeacher.SelectedValue.ToString()), MyTeachers, "FirstName");
                            user.LastName = Validation.GetTeacher(Convert.ToInt32(cmbTeacher.SelectedValue.ToString()), MyTeachers, "LastName");
                        }
                        else
                        {
                            user.FirstName = txtFirstName.Text;
                            user.LastName = txtLastName.Text;
                        }

                        var checkUsers = MyUsers.Where(t => t.UserName == txtUsername.Text).ToList();

                        if (checkUsers.Count > 0)
                        {
                            MessageDialog.MessageBoxShow("Username exists!", "Exists",
                                "Nofka ekziston!", "Ekziston", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            bool isRegistred = _userBLL.AddUser(user);

                            if (isRegistred)
                            {
                                MessageDialog.DoYouWantToContinue(this, "User", "Përdoruesi");
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
                        MessageDialog.MessageBoxShow("Please fill all fields!", "Error",
                            "Ju lutem plotësoni të gjitha fushat!", "Kujdes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
            CreateUser();
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
            MessageDialog.ShowHelp(this, "usercreate.html");
        }

        // DateTimePicker
        private void dtpExpireDate_CloseUp(object sender, EventArgs e)
        {
            DateTime expireDate = Convert.ToDateTime(dtpExpireDate.Text);

            if (expireDate < DateTime.Now)
            {
                MessageDialog.MessageBoxShow("Invalid date. Please select a date that isn't in the past!", "Error",
                    "Data e pavlefshme. Ju lutemi zgjidhni një datë që nuk është në të kaluarën!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // TextBoxes
        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.NoNumber(e);
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.NoNumber(e);
        }

        // CheckBox
        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPassword.Checked)
            {
                txtConfirmPass.UseSystemPasswordChar = false;
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtConfirmPass.UseSystemPasswordChar = true;
            }
        }
        #endregion

        #region ErrorProvider
        private void picFirstName_MouseHover(object sender, EventArgs e)
        {
            if (txtFirstName.Text == null)
            {
                MessageDialog.ToolTipShow("First name is required!", "Emri duhet të plotësohet!", picFirstName);
            }
            else if (txtFirstName.Text.Length < 2)
            {
                MessageDialog.ToolTipShow("First name is to short!", "Emri është i shkurtër!", picFirstName);
            }
        }

        private void picLastName_MouseHover(object sender, EventArgs e)
        {
            if (txtLastName.Text == null)
            {
                MessageDialog.ToolTipShow("Last name is required!", "Mbiemri duhet të plotësohet!", picLastName);
            }
            else if (txtLastName.Text.Length < 2)
            {
                MessageDialog.ToolTipShow("Last name is to short!", "Mbiemri është i shkurtër!", picLastName);
            }
        }

        private void picUsername_MouseHover(object sender, EventArgs e)
        {
            if (txtUsername.Text == null)
            {
                MessageDialog.ToolTipShow("Username is required!", "Nofka duhet të plotësohet!", picUsername);
            }
            else if (txtUsername.Text.Length < 2)
            {
                MessageDialog.ToolTipShow("Username is to short!", "Nofka është i shkurtër!", picUsername);
            }
        }

        private void picRole_MouseHover(object sender, EventArgs e)
        {
            MessageDialog.ToolTipShow("Role is required!", "Roli duhet të plotësohet!", picRole);
        }

        private void picPassword_MouseHover(object sender, EventArgs e)
        {
            if (txtPassword.Text == null)
            {
                MessageDialog.ToolTipShow("Password is required!", "Fjalëkalimi duhet të plotësohet!", picPassword);
            }
            else if (txtPassword.Text.Length < 2)
            {
                MessageDialog.ToolTipShow("Password is to short!", "v është i shkurtër!", picPassword);
            }
        }

        private void picValidatePassword_MouseHover(object sender, EventArgs e)
        {
            MessageDialog.ToolTipShow("Password does not match!", "Fjalëkalimi nuk përputhet!", picValidatePassword);
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Length > 0)
            {
                Validation.Capitalize(txtFirstName);
            }

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

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text != null && txtUsername.Text.Length > 2)
            {
                picUsername.Visible = false;
            }
            else
            {
                Validation.SetImageVisibility(picUsername);
            }
        }

        private void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRoles.SelectedIndex != -1)
            {
                picRole.Visible = false;
            }
            else
            {
                Validation.SetImageVisibility(picRole);
            }

            if (cmbRoles.SelectedIndex != 1)
            {
                txtFirstName.Enabled = true;
                txtLastName.Enabled = true;
                cmbTeacher.Enabled = false;

                List<string> EmptyStrings = new List<string>();
                EmptyStrings.Add("NONE");

                cmbTeacher.DataSource = EmptyStrings;

                txtFirstName.Text = string.Empty;
                txtLastName.Text = string.Empty;
            }
            else
            {
                txtFirstName.Enabled = false;
                txtLastName.Enabled = false;
                cmbTeacher.Enabled = true;

                cmbTeacher.DataSource = MyTeachers;

                txtFirstName.Text = "NONE";
                txtLastName.Text = "NONE";
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != null && txtPassword.Text.Length > 2)
            {
                picPassword.Visible = false;
            }
            else
            {
                Validation.SetImageVisibility(picPassword);
            }
        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtConfirmPass.Text)
            {
                picValidatePassword.Image = Properties.Resources.icons8_ok_15;
            }
            else
            {
                Validation.SetImageVisibility(picValidatePassword);
            }
        }
        #endregion
    }
}