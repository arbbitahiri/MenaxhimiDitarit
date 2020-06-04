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

        //Popullimi i TextBox-ave dhe ComboBox-ave me te dhenat nga Topic
        private void PopulateForm(User user)
        {
            txtID.Text = user.UserID.ToString();
            txtUsername.Text = user.UserName;
        }

        //Show/Hide Password
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
                if (Validation.CheckTextbox(this))
                {
                    User user = new User();

                    user.UserID = int.Parse(txtID.Text);
                    user.UserPassword = txtPassword.Text;
                    user.LUB = UserSession.GetUser.UserName;
                    user.LUN = ++_user.LUN;
                    user.IsPasswordChanged = true;

                    bool isUpdated = _userBLL.Update(user);

                    if (isUpdated)
                    {
                        Validation.MessageBoxShow("Password changed successfully!", "Updated",
                            "Fjalëkalimi u përditësua!", "U përditësua", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        Validation.MessageBoxShow("Update failed!", "Error",
                            "Përditësimi dështoi!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    Validation.MessageBoxShow("Please fill all fields!", "Error",
                        "Ju lutem plotësoni të gjitha fushat!", "Kujdes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                Validation.MessageBoxShow("A problem occurred while registering data!", "Error",
                    "Ndodhi një problem gjatë regjistrimit të të dhënave!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!Validation.CheckTextbox(this))
            {
                var result = Validation.MessageBoxShow("You have something written. Are you sure you want to exit form?", "Sure?",
                    "Keni të shkruar diçka. A je i/e sigurt që do të largoheni nga forma?", "Sigurt?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                    this.Close();
            }
        }

        #region ErrorProvider
        private void picPassword_MouseHover(object sender, EventArgs e)
        {
            Validation.ToolTipShow("Password is required!", "Fjalëkalimi duhet të plotësohet!", picPassword);
        }

        private void picUsername_MouseHover(object sender, EventArgs e)
        {
            Validation.ToolTipShow("Username is required!", "Nofka duhet të plotësohet!", picUsername);
        }

        private void picValidatePassword_MouseHover(object sender, EventArgs e)
        {
            Validation.ToolTipShow("Password does not match!", "Fjalëkalimi nuk përputhet!", picValidatePassword);
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text != null && txtUsername.Text.Length > 2)
                picUsername.Visible = false;
            else
                picUsername.Image = Properties.Resources.icons8_cancel_15;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != null && txtPassword.Text.Length > 2)
                picPassword.Visible = false;
            else
                picPassword.Image = Properties.Resources.icons8_cancel_15;
        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtConfirmPass.Text)
                picValidatePassword.Image = Properties.Resources.icons8_ok_15;
            else
                picValidatePassword.Image = Properties.Resources.icons8_cancel_15;
        }
        #endregion
    }
}
