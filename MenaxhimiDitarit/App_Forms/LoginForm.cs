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
using MenaxhimiDitarit.App_Code;

namespace MenaxhimiDitarit
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            txtPassword.UseSystemPasswordChar = true;
            btnLogin.Enabled = false;
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

            if (username.Trim() != "" && password != "")
            {
                if (cmbLanguage.SelectedIndex != -1)
                {
                    User user = AdministrationBLL.Login(username, password);

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
                            {
                                Validation.MessageBoxShow("You don't have access!", "Access denied",
                                    "Ju nuk keni qasje!", "Hyrja ndalohet!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            Validation.MessageBoxShow("Your user has expired!", "Access denied",
                                    "Llogaria juaj nuk është aktive!", "Hyrja ndalohet!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        Validation.MessageBoxShow("Username or Password is incorrect!", "Incorrect",
                                    "Nofka apo fjalëkalimi janë të gabuara!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ju lutem zgjidheni gjuhën!\nPlease choose a language!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Ju lutem plotësoni të gjitha fushat!\nPlease fill your credentials!",
                    "Kujdes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }

            if (!chbShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, new EventArgs());
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "")
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }

        private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLanguage.SelectedIndex == 0)
            {
                TranslateForm.ChangeLanguages("en-UK");
            }
            else if (cmbLanguage.SelectedIndex == 1)
            {
                TranslateForm.ChangeLanguages("sq-XK");
            }
        }
    }
}
