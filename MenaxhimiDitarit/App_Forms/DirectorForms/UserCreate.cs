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
                    MessageBox.Show($"Expire date can't be from: {dtpExpireDate.Value}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtConfirmPass.Text)
                picValidatePassword.Image = Properties.Resources.icons8_ok_15;
            else
                picValidatePassword.Image = Properties.Resources.icons8_cancel_15;
        }

        //Shikojme nese data e zgjedhur ne DateTimePicker nuk eshte date e kaluar
        private void dtpExpireDate_CloseUp(object sender, EventArgs e)
        {
            DateTime expireDate = Convert.ToDateTime(dtpExpireDate.Text);

            if (expireDate < DateTime.Now)
                MessageBox.Show("Can't select date!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
