using System;
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

namespace MenaxhimiDitarit.DirectorForms
{
    public partial class UserCreate : Form
    {
        private readonly UserBLL _userBLL;
        private List<User> MyUsers;

        private readonly RoleBLL _roleBLL;
        private List<Role> MyRoles;

        public UserCreate()
        {
            InitializeComponent();

            _userBLL = new UserBLL();
            _roleBLL = new RoleBLL();

            MyUsers = _userBLL.GetAll();
            MyRoles = _roleBLL.GetAll();

            cmbRoles.DataSource = MyRoles;

            txtID.Enabled = false;
            txtPassword.UseSystemPasswordChar = true;
            txtConfirmPass.UseSystemPasswordChar = true;
        }

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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime expireDate = Convert.ToDateTime(dtpExpireDate.Text);

                if (expireDate < DateTime.Now)
                {
                    Validation.MessageBoxShow($"Expire date can't be from: {dtpExpireDate.Value}", "Error",
                        $"Data e skadimit nuk mund të jetë nga {dtpExpireDate.Value}", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Validation.CheckTextbox(this))
                    {
                        User user = new User
                        {
                            UserID = int.Parse(txtID.Text),
                            FirstName = txtFirstName.Text,
                            LastName = txtLastName.Text,
                            ExpiresDate = dtpExpireDate.Value,
                            RoleID = Convert.ToInt32(cmbRoles.SelectedValue.ToString()),
                            UserName = txtUsername.Text,
                            UserPassword = Validation.CalculateHash(txtPassword.Text),
                            InsertBy = UserSession.GetUser.UserName,
                            LUB = UserSession.GetUser.UserName
                        };
                        user.LUN++;

                        var checkUsers = MyUsers.Where(t => t.UserName == txtUsername.Text).ToList();

                        if (checkUsers.Count > 0)
                        {
                            Validation.MessageBoxShow("Username exists!", "Exists",
                                "Nofka ekziston!", "Ekziston", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            bool isRegistred = _userBLL.Add(user);

                            if (isRegistred)
                            {
                                Validation.MessageBoxShow("User registered successfully!", "Registered",
                                    "Perdoruesi u regjistrua me sukses!", "U regjistrua", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        Validation.MessageBoxShow("Please fill all fields!", "Error",
                            "Ju lutem plotësoni të gjitha fushat!", "Kujdes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private void dtpExpireDate_CloseUp(object sender, EventArgs e)
        {
            DateTime expireDate = Convert.ToDateTime(dtpExpireDate.Text);

            if (expireDate < DateTime.Now)
            {
                Validation.MessageBoxShow("Invalid date. Please select a date that isn't in the past!", "Error",
                    "Data e pavlefshme. Ju lutemi zgjidhni një datë që nuk është në të kaluarën!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region ErrorProvider
        private void picFirstName_MouseHover(object sender, EventArgs e)
        {
            if (txtFirstName.Text == null)
            {
                Validation.ToolTipShow("First name is required!", "Emri duhet të plotësohet!", picFirstName);
            }
            else if (txtFirstName.Text.Length < 2)
            {
                Validation.ToolTipShow("First name is to short!", "Emri është i shkurtër!", picFirstName);
            }
        }

        private void picLastName_MouseHover(object sender, EventArgs e)
        {
            if (txtFirstName.Text == null)
            {
                Validation.ToolTipShow("Last name is required!", "Mbiemri duhet të plotësohet!", picLastName);
            }
            else if (txtFirstName.Text.Length < 2)
            {
                Validation.ToolTipShow("Last name is to short!", "Mbiemri është i shkurtër!", picLastName);
            }
        }

        private void picUsername_MouseHover(object sender, EventArgs e)
        {
            if (txtFirstName.Text == null)
            {
                Validation.ToolTipShow("Username is required!", "Nofka duhet të plotësohet!", picUsername);
            }
            else if (txtFirstName.Text.Length < 2)
            {
                Validation.ToolTipShow("Username is to short!", "Nofka është i shkurtër!", picUsername);
            }
        }

        private void picRole_MouseHover(object sender, EventArgs e)
        {
            Validation.ToolTipShow("Role is required!", "Roli duhet të plotësohet!", picRole);
        }

        private void picPassword_MouseHover(object sender, EventArgs e)
        {
            if (txtFirstName.Text == null)
            {
                Validation.ToolTipShow("Password is required!", "Fjalëkalimi duhet të plotësohet!", picPassword);
            }
            else if (txtFirstName.Text.Length < 2)
            {
                Validation.ToolTipShow("Password is to short!", "v është i shkurtër!", picPassword);
            }
        }

        private void picValidatePassword_MouseHover(object sender, EventArgs e)
        {
            Validation.ToolTipShow("Password does not match!", "Fjalëkalimi nuk përputhet!", picValidatePassword);
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

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.NoNumber(e);
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.NoNumber(e);
        }
    }
}