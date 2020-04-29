using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenaxhimiDitarit.BO;
using MenaxhimiDitarit.BLL;
using MenaxhimiDitarit.TeacherForms;
using MenaxhimiDitarit.DirectorForms;

namespace MenaxhimiDitarit
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            txtPassword.UseSystemPasswordChar = true;
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            DateTime dateNow = DateTime.Now;

            if (username.Trim() != "" && password != "")
            {
                User user = AdministrationBLL.Login(username, password, dateNow);

                if (user != null)
                {
                    UserSession.GetUser = user;

                    if (user.ExpiresDate > DateTime.Now)
                    {
                        if (user.RoleID == 1)
                        {
                            AdminMain adminForm = new AdminMain();
                            this.Hide();
                            adminForm.StartPosition = FormStartPosition.CenterScreen;
                            adminForm.ShowDialog();
                        }
                        else if (user.RoleID == 2)
                        {
                            TeacherMain teacherForm = new TeacherMain();
                            this.Hide();
                            teacherForm.StartPosition = FormStartPosition.CenterScreen;
                            teacherForm.ShowDialog();
                        }
                        else if (user.RoleID == 4)
                        {
                            DirectorMain directorForm = new DirectorMain();
                            this.Hide();
                            directorForm.StartPosition = FormStartPosition.CenterScreen;
                            directorForm.ShowDialog();
                        }
                        else
                            MessageBox.Show("You don't have access!", "Access denied!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("Your user has expired!", "Access denied!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Username or Password is incorrect!", "Incorrect!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Please fill your credentials!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPassword.Checked)
                txtPassword.UseSystemPasswordChar = false;
            else
                txtPassword.UseSystemPasswordChar = true;
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(this, new EventArgs());
        }
    }
}
