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

            txtPassword.UseSystemPasswordChar = true;
            txtConfirmPass.UseSystemPasswordChar = true;
            txtUsername.Enabled = false;

            PopulateForm(_user);
        }

        #region Methods
        /// <summary>
        /// Populates the form with the adequate data from the list form
        /// </summary>
        /// <param name="user"></param>
        private void PopulateForm(User user)
        {
            txtID.Text = user.UserID.ToString();
            txtUsername.Text = user.UserName;
        }

        /// <summary>
        /// Updates the password
        /// </summary>
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
                        MessageDialog.MessageBoxShow("Password changed successfully!", "Updated",
                            "Fjalëkalimi u përditësua!", "U përditësua", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageDialog.MessageBoxShow("Update failed!", "Error",
                            "Përditësimi dështoi!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageDialog.MessageBoxShow("Please fill all fields!", "Error",
                        "Ju lutem plotësoni të gjitha fushat!", "Kujdes", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            ChangePassword();
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
            MessageDialog.ShowHelp(this, "userchangepassword.html");
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
                MessageDialog.ToolTipShow("Username is required!", "Nofka duhet të plotësohet!", picUsername);
            }
            else if (txtUsername.Text.Length < 2)
            {
                MessageDialog.ToolTipShow("Username is to short!", "Nofka është shumë i vogël!", picPassword);
            }
        }

        private void picPassword_MouseHover(object sender, EventArgs e)
        {
            if (txtPassword.Text == null)
            {
                MessageDialog.ToolTipShow("Password is required!", "Fjalëkalimi duhet të plotësohet!", picPassword);
            }
            else if (txtPassword.Text.Length < 2)
            {
                MessageDialog.ToolTipShow("Password is to short!", "Fjalëkalimi është shumë i vogël!", picPassword);
            }
        }

        private void picValidatePassword_MouseHover(object sender, EventArgs e)
        {
            MessageDialog.ToolTipShow("Password does not match!", "Fjalëkalimi nuk përputhet!", picValidatePassword);
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
