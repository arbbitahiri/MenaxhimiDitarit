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
        private readonly UsersBLL _usersBLL;
        private Users _user;
        private readonly bool update = false;

        private readonly RoleBLL _roleBLL;
        private readonly List<Roles> roles;

        public UserCreateForm()
        {
            InitializeComponent();

            _usersBLL = new UsersBLL();
            update = false;
            _roleBLL = new RoleBLL();
            roles = _roleBLL.GetAll();
            cmbRoles.DataSource = roles;
        }

        public UserCreateForm(Users user)
        {
            InitializeComponent();

            _usersBLL = new UsersBLL();
            this._user = user;
            _roleBLL = new RoleBLL();
            roles = _roleBLL.GetAll();
            cmbRoles.DataSource = roles;

            update = this._user != null;
            PopulateForm(this._user);
        }

        private void PopulateForm(Users user)
        {
            txtID.Text = user.UserID.ToString();
            txtFirstName.Text = user.FirstName;
            txtLastName.Text = user.LastName;
            txtUsername.Text = user.UserName;
            txtPassword.Text = user.UserPassword;
            cmbRoles.SelectedItem = roles.FirstOrDefault(f => f.RoleID == user.RoleID);
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
            Users user = new Users();

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
                user.LUN = ++this._user.LUN;

            if (!update)
            {
                bool isRegistred = _usersBLL.Add(user);

                if (isRegistred) {
                    MessageBox.Show("User registred successfully", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Registration failed, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                MessageBox.Show("User Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
