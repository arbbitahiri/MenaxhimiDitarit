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
            //this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username.Trim() != "" && password != "") {
                Users user = AdministrationBLL.Login(username, password);

                if (user != null) {
                    UserSession.GetUser = user;

                    if (user.UserName == "admin") {
                        AdminMainForm adminForm = new AdminMainForm();
                        this.Hide();
                        adminForm.ShowDialog();
                        //this.Close();
                    }
                    else if (user.UserName == "teacher") {
                        TeacherMainForm teacherForm = new TeacherMainForm();
                        this.Hide();
                        teacherForm.ShowDialog();
                        //this.Close();
                    }
                    else if (user.UserName == "director") {
                        DirectorMainForm directorForm = new DirectorMainForm();
                        this.Hide();
                        directorForm.ShowDialog();
                        //this.Close();
                    }
                    else
                        MessageBox.Show("You don't have access!", "Access denied!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Username or Passwod is incorrect!", "Incorrect!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Please fill your credentials", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            if (e.KeyCode == Keys.Tab)
                txtPassword_Click(this, new EventArgs());
        }
    }
}
