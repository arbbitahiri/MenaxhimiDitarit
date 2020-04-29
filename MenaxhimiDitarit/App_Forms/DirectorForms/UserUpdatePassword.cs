using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenaxhimiDitarit.BLL;
using MenaxhimiDitarit.BO;

namespace MenaxhimiDitarit.App_Forms.DirectorForms
{
    public partial class UserUpdatePassword : Form
    {
        private readonly UserBLL _userBLL;
        private User _user;
        private List<User> MyUsers;

        public UserUpdatePassword(User user)
        {
            InitializeComponent();

            _userBLL = new UserBLL();
            MyUsers = _userBLL.GetAll();

            _user = user;

            txtID.Enabled = false;
            txtPassword.UseSystemPasswordChar = true;
            txtConfirmPass.UseSystemPasswordChar = true;
            txtUsername.Enabled = false;

            PopulateForm(_user);
        }

        private void PopulateForm(User user)
        {
            txtID.Text = user.UserID.ToString();
            txtUsername.Text = user.UserName;
        }

        private bool CheckTextbox()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox txtb = ctrl as TextBox;
                    if (txtb.Text == string.Empty)
                        return false;
                }
            }
            return true;
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
            if (CheckTextbox())
            {
                User user = new User();

                user.UserID = int.Parse(txtID.Text);
                user.UserPassword = txtPassword.Text;
                user.LUB = UserSession.GetUser.UserName;
                user.LUD = DateTime.Now;
                user.LUN = ++_user.LUN;
                user.LastPasswordChangeDate = DateTime.Now;
                user.IsPasswordChanged = true;

                var temp = MyUsers.Where(t => t.UserPassword == txtPassword.Text).ToList();

                if (temp.Count > 0)
                    MessageBox.Show("You can't change it to the old password!", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    bool isUpdated = _userBLL.Update(user);

                    if (isUpdated)
                    {
                        MessageBox.Show("Password changed successfully", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Update failed, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Please fill all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtConfirmPass.Text)
                picValidatePassword.Image = Properties.Resources.icons8_ok_15;
            else
                picValidatePassword.Image = Properties.Resources.icons8_cancel_15;
        }
    }
}
