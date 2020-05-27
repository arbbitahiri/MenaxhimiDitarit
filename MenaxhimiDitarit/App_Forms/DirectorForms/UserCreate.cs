using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenaxhimiDitarit.App_Forms.MessageBoxes;
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

        ToolTip toolTip = new ToolTip();

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

        //Show/Hide Password
        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPassword.Checked) {
                txtConfirmPass.UseSystemPasswordChar = false;
                txtPassword.UseSystemPasswordChar = false;
            }
            else {
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
                    OKCancel oK = new OKCancel("Information", $"Expire date can't be from:\n {dtpExpireDate.Value}", Properties.Resources.icons8_user_100)
                    {
                        StartPosition = FormStartPosition.CenterScreen
                    };
                    oK.ShowDialog();
                }
                //MessageBox.Show($"Expire date can't be from: {dtpExpireDate.Value}",
                //    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (CheckTextbox())
                    {
                        User user = new User();

                        user.UserID = int.Parse(txtID.Text);
                        user.FirstName = txtFirstName.Text;
                        user.LastName = txtLastName.Text;
                        user.ExpiresDate = dtpExpireDate.Value;
                        user.RoleID = Convert.ToInt32(cmbRoles.SelectedValue.ToString());
                        user.UserName = txtUsername.Text;
                        user.UserPassword = txtPassword.Text;
                        user.InsertBy = UserSession.GetUser.UserName;
                        user.LUB = UserSession.GetUser.UserName;
                        user.LUN++;

                        //Shikojme nese ekziston nje Username i till
                        var checkUsers = MyUsers.Where(t => t.UserName == txtUsername.Text).ToList();

                        if (checkUsers.Count > 0)
                            MessageBox.Show("Username exists", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            bool isRegistred = _userBLL.Add(user);

                            if (isRegistred)
                            {
                                MessageBox.Show("User registred successfully", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Registration failed, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        OKCancel oK = new OKCancel("Warning", "Please fill all fields!", Properties.Resources.icons8_user_100)
                        {
                            StartPosition = FormStartPosition.CenterScreen
                        };
                        oK.ShowDialog();
                    }
                        //MessageBox.Show("Please fill all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtConfirmPass.Text)
                picValidatePassword.Image = Properties.Resources.icons8_ok_15;
            else
                picValidatePassword.Image = Properties.Resources.icons8_cancel_15;
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (txtFirstName.Text != null && txtFirstName.Text.Length > 2)
                picFirstName.Visible = false;
            else
                picFirstName.Image = Properties.Resources.icons8_cancel_15;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (txtLastName.Text != null && txtLastName.Text.Length > 2)
                picLastName.Visible = false;
            else
                picLastName.Image = Properties.Resources.icons8_cancel_15;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text != null && txtUsername.Text.Length > 2)
                picUsername.Visible = false;
            else
                picUsername.Image = Properties.Resources.icons8_cancel_15;
        }

        private void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRoles.SelectedIndex != -1)
                picRole.Visible = false;
            else
                picRole.Image = Properties.Resources.icons8_cancel_15;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != null && txtPassword.Text.Length > 2)
                picPassword.Visible = false;
            else
                picPassword.Image = Properties.Resources.icons8_cancel_15;
        }

        //Shikojme nese data e zgjedhur ne DateTimePicker nuk eshte date e kaluar
        private void dtpExpireDate_CloseUp(object sender, EventArgs e)
        {
            DateTime expireDate = Convert.ToDateTime(dtpExpireDate.Text);

            if (expireDate < DateTime.Now)
                MessageBox.Show("Can't select date from the past!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void picFirstName_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("First name is required!", picFirstName);
        }

        private void picLastName_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Last name is required!", picLastName);
        }

        private void picUsername_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Username is required!", picUsername);
        }

        private void picPassword_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Password is required!", picPassword);
        }

        private void picValidatePassword_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Password does not match!", picValidatePassword);
        }

        private void picRole_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Role is required!", picRole);
        }
    }
}