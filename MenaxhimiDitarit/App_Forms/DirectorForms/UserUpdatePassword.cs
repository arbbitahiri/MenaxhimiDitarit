﻿using System;
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

        #region Metodat
        //Popullimi i TextBox-ave dhe ComboBox-ave me te dhenat nga Topic
        private void PopulateForm(User user)
        {
            txtID.Text = user.UserID.ToString();
            txtUsername.Text = user.UserName;
        }

        //Shikojme nese TextBox-at jane te mbushur me te dhena
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
        #endregion

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
                if (CheckTextbox())
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
                        MessageBox.Show("Password changed successfully", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Update failed, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Please fill all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A problem occurred while registering data!\n{ex.Message}",
                    "Problem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Ndrojme foton varesisht a jane a eshte ConfirmPass = Password
        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtConfirmPass.Text)
                picValidatePassword.Image = Properties.Resources.icons8_ok_15;
            else
                picValidatePassword.Image = Properties.Resources.icons8_cancel_15;
        }
    }
}
