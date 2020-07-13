using System;
using System.Windows.Forms;
using MenaxhimiDitarit.App_Code;
using MenaxhimiDitarit.BLL;
using MenaxhimiDitarit.BO;

namespace MenaxhimiDitarit.App_Forms.DirectorForms
{
    public partial class UserUpdatePassword : Form
    {
        private readonly UserBLL _userBLL;
        private User _user;

        public UserUpdatePassword(User user)
        {
            InitializeComponent();

            _userBLL = new UserBLL();

            _user = user;

            txtID.Enabled = false;
            txtPassword.UseSystemPasswordChar = true;
            txtConfirmPass.UseSystemPasswordChar = true;
            txtUsername.Enabled = false;

            PopulateForm(_user);
        }

        #region Methods
        private void PopulateForm(User user)
        {
            txtID.Text = user.UserID.ToString();
            txtUsername.Text = user.UserName;
        }

        private void ChangePassword()
        {
            try
            {
                if (Validation.CheckTextbox(this))
                {
                    User user = new User();

                    user.UserID = int.Parse(txtID.Text);
                    user.UserPassword = Validation.CalculateHash(txtPassword.Text);
                    user.LUB = UserSession.GetUser.UserName;
                    user.LUN = ++_user.LUN;
                    user.IsPasswordChanged = true;

                    bool isUpdated = _userBLL.UpdateUser(user);

                    if (isUpdated)
                    {
                        Validation.MessageBoxShow("Password changed successfully!", "Updated",
                            "Fjalëkalimi u përditësua!", "U përditësua", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        Validation.MessageBoxShow("Update failed!", "Error",
                            "Përditësimi dështoi!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void CloseForm()
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
        #endregion

        #region Events
        // Buttons
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ChangePassword();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CloseForm();
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
        private void picUsername_MouseHover(object sender, EventArgs e)
        {
            if (txtUsername.Text == null)
            {
                Validation.ToolTipShow("Username is required!", "Nofka duhet të plotësohet!", picUsername);
            }
            else if (txtUsername.Text.Length < 2)
            {
                Validation.ToolTipShow("Username is to short!", "Nofka është shumë i vogël!", picPassword);
            }
        }

        private void picPassword_MouseHover(object sender, EventArgs e)
        {
            if (txtPassword.Text == null)
            {
                Validation.ToolTipShow("Password is required!", "Fjalëkalimi duhet të plotësohet!", picPassword);
            }
            else if (txtPassword.Text.Length < 2)
            {
                Validation.ToolTipShow("Password is to short!", "Fjalëkalimi është shumë i vogël!", picPassword);
            }
        }

        private void picValidatePassword_MouseHover(object sender, EventArgs e)
        {
            Validation.ToolTipShow("Password does not match!", "Fjalëkalimi nuk përputhet!", picValidatePassword);
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
