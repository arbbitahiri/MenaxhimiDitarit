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
    public partial class UserUpdate : Form
    {
        private readonly UserBLL _userBLL;
        private User _user;

        private readonly RoleBLL _roleBLL;
        private readonly List<Role> MyRoles;

        ToolTip toolTip = new ToolTip();

        public UserUpdate(User user)
        {
            InitializeComponent();

            _userBLL = new UserBLL();

            _roleBLL = new RoleBLL();
            MyRoles = _roleBLL.GetAll();

            _user = user;

            txtID.Enabled = false;
            cmbRoles.DataSource = MyRoles;

            PopulateForm(_user);
        }

        #region Metodat
        //Popullimi i TextBox-ave dhe ComboBox-ave me te dhenat nga Topic
        private void PopulateForm(User user)
        {
            txtID.Text = user.UserID.ToString();
            txtFirstName.Text = user.FirstName;
            txtLastName.Text = user.LastName;
            txtUsername.Text = user.UserName;
            dtpExpireDate.Value = user.ExpiresDate;
            cmbRoles.SelectedItem = MyRoles.FirstOrDefault(f => f.RoleID == user.RoleID);
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime expireDate = Convert.ToDateTime(dtpExpireDate.Text);

                if (expireDate < DateTime.Now)
                    MessageBox.Show($"Expire date can't be from: {dtpExpireDate.Value}",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        user.LUB = UserSession.GetUser.UserName;
                        user.LUN = ++_user.LUN;

                        bool isUpdated = _userBLL.Add(user);

                        if (isUpdated)
                        {
                            MessageBox.Show($"User: {user.FullName} updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                            MessageBox.Show("Updated failed, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Please fill all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        //Shikojme nese data e zgjedhur ne DateTimePicker nuk eshte date e kaluar
        private void dtpExpireDate_CloseUp(object sender, EventArgs e)
        {
            DateTime expireDate = Convert.ToDateTime(dtpExpireDate.Text);

            if (expireDate < DateTime.Now)
                MessageBox.Show("Can't select date from the past!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (txtFirstName.Text != null && txtFirstName.Text.Length > 2)
                picLastName.Visible = false;
            else
                picLastName.Image = Properties.Resources.icons8_cancel_15;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (txtLastName.Text != null && txtLastName.Text.Length > 2)
                picLastName.Visible = false;
            else
                picLastName.Image = Properties.Resources.icons8_cancel_15;
        }

        private void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRoles.SelectedIndex != -1)
                picRole.Visible = false;
            else
                picRole.Image = Properties.Resources.icons8_cancel_15;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text != null && txtUsername.Text.Length > 2)
                picUsername.Visible = false;
            else
                picUsername.Image = Properties.Resources.icons8_cancel_15;
        }

        private void picFirstName_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Role is required!", picFirstName);
        }

        private void picLastName_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Role is required!", picLastName);
        }

        private void picRole_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Role is required!", picRole);
        }

        private void picUsername_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Role is required!", picUsername);
        }
    }
}
