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
    public partial class UserCreateForm : Form
    {
        private readonly UserBLL _userBLL;
        private User _user;
        private List<User> MyUsers;
        private bool update = false;

        private readonly RoleBLL _roleBLL;
        private readonly List<Role> MyRoles;

        public UserCreateForm()
        {
            InitializeComponent();

            _userBLL = new UserBLL();
            _roleBLL = new RoleBLL();

            MyUsers = _userBLL.GetAll();
            MyRoles = _roleBLL.GetAll();
            cmbRoles.DataSource = MyRoles;

            update = false;
            txtPassword.UseSystemPasswordChar = true;
        }

        public UserCreateForm(User user)
        {
            InitializeComponent();

            _userBLL = new UserBLL();
            _user = user;
            _roleBLL = new RoleBLL();
            MyRoles = _roleBLL.GetAll();
            cmbRoles.DataSource = MyRoles;

            update = _user != null;
            PopulateForm(_user);
            txtPassword.UseSystemPasswordChar = true;
        }

        private void PopulateForm(User user)
        {
            txtID.Text = user.UserID.ToString();
            txtFirstName.Text = user.FirstName;
            txtLastName.Text = user.LastName;
            txtUsername.Text = user.UserName;
            txtPassword.Text = user.UserPassword;
            cmbRoles.SelectedItem = MyRoles.FirstOrDefault(f => f.RoleID == user.RoleID);
        }

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

        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPassword.Checked)
                txtPassword.UseSystemPasswordChar = false;
            else
                txtPassword.UseSystemPasswordChar = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (CheckTextbox()) {
                User user = new User();

                user.UserID = int.Parse(txtID.Text);
                user.FirstName = txtFirstName.Text;
                user.LastName = txtLastName.Text;
                user.ExpiresDate = dtpExpireDate.Value;
                user.RoleID = Convert.ToInt32(cmbRoles.SelectedIndex + 1);
                user.UserName = txtUsername.Text;
                user.UserPassword = txtPassword.Text;
                user.InsertBy = UserSession.GetUser.UserName;
                user.InsertDate = DateTime.Now;
                user.LUB = UserSession.GetUser.UserName;
                user.LUD = DateTime.Now;

                if (!update)
                    user.LUN++;
                else if (update)
                    user.LUN = ++_user.LUN;

                if (!update) {
                    var temp = MyUsers.Where(t => t.UserName == txtUsername.Text).ToList();

                    if (temp.Count > 0)
                        MessageBox.Show("Username exists", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else {
                        bool isRegistred = _userBLL.Add(user);

                        if (isRegistred) {
                            MessageBox.Show("User registred successfully", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                            MessageBox.Show("Registration failed, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else {
                    bool isUpdated = _userBLL.Add(user);

                    if (isUpdated)
                    {
                        MessageBox.Show($"User: {user.FullName} updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Updated failed, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Please fill all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
