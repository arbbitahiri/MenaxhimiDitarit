using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MenaxhimiDitarit.App_Code;
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

        private readonly TeacherBLL _teacherBLL;
        private List<Teacher> MyTeachers;

        public UserUpdate(User user)
        {
            InitializeComponent();

            _userBLL = new UserBLL();
            _teacherBLL = new TeacherBLL();
            _roleBLL = new RoleBLL();

            MyRoles = _roleBLL.GetAll();
            MyTeachers = _teacherBLL.GetAll();

            _user = user;

            cmbRoles.DataSource = MyRoles;

            PopulateForm(_user);
        }

        #region Methods
        /// <summary>
        /// Populates the form with the adequate data from the list form
        /// </summary>
        /// <param name="user"></param>
        private void PopulateForm(User user)
        {
            txtID.Text = user.UserID.ToString();
            txtFirstName.Text = user.FirstName;
            txtLastName.Text = user.LastName;
            txtUsername.Text = user.UserName;
            dtpExpireDate.Value = user.ExpiresDate;
            cmbRoles.SelectedItem = MyRoles.FirstOrDefault(f => f.RoleID == user.RoleID);
        }

        /// <summary>
        /// Updates the user
        /// </summary>
        private void UpdateUser()
        {
            try
            {
                DateTime expireDate = Convert.ToDateTime(dtpExpireDate.Text);

                if (expireDate < DateTime.Now)
                {
                    MessageDialog.MessageBoxShow($"Expire date can't be from: {dtpExpireDate.Value}", "Error",
                        $"Data e skadimit nuk mund të jetë nga {dtpExpireDate.Value}", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Validation.CheckTextbox(this))
                    {
                        User user = new User
                        {
                            UserID = int.Parse(txtID.Text),
                            ExpiresDate = dtpExpireDate.Value,
                            RoleID = Convert.ToInt32(cmbRoles.SelectedValue.ToString()),
                            UserName = txtUsername.Text,
                            LUB = UserSession.GetUser.UserName,
                            LUN = ++_user.LUN,
                            TeacherID = Convert.ToInt32(cmbTeacher.SelectedValue.ToString())
                        };

                        if (cmbTeacher.SelectedIndex != -1)
                        {
                            user.FirstName = Validation.GetTeacher(Convert.ToInt32(cmbTeacher.SelectedValue.ToString()), MyTeachers, "FirstName");
                            user.LastName = Validation.GetTeacher(Convert.ToInt32(cmbTeacher.SelectedValue.ToString()), MyTeachers, "LastName");
                        }
                        else
                        {
                            user.FirstName = txtFirstName.Text;
                            user.LastName = txtLastName.Text;
                        }

                        bool isUpdated = _userBLL.AddUser(user);

                        if (isUpdated)
                        {
                            MessageDialog.MessageBoxShow($"User: {user.FullName} updated", "Updated",
                                $"Përdoruesi: {user.FullName} u përditësua!", "U përditësua", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageDialog.MessageBoxShow("Update failed!", "Error",
                                "Përditësimi dështoi!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageDialog.MessageBoxShow("Please fill all fields!", "Error",
                            "Ju lutem plotësoni të gjitha fushat!", "Kujdes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageDialog.MessageBoxShow("A problem occurred while registering data!", "Error",
                    "Ndodhi një problem gjatë regjistrimit të të dhënave!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Events
        // Buttons
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            UpdateUser();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Validation.CloseForm(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Validation.CloseForm(this);
        }

        // DateTimePicker
        private void dtpExpireDate_CloseUp(object sender, EventArgs e)
        {
            DateTime expireDate = Convert.ToDateTime(dtpExpireDate.Text);

            if (expireDate < DateTime.Now)
            {
                MessageDialog.MessageBoxShow("Invalid date. Please select a date that isn't in the past!", "Error",
                    "Data e pavlefshme. Ju lutemi zgjidhni një datë që nuk është në të kaluarën!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // TextBoxes
        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.NoNumber(e);
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.NoNumber(e);
        }
        #endregion

        #region ErrorProvider
        private void picFirstName_MouseHover(object sender, EventArgs e)
        {
            if (txtFirstName.Text == null)
            {
                MessageDialog.ToolTipShow("First name is required!", "Emri duhet të plotësohet!", picFirstName);
            }
            else if (txtFirstName.Text.Length < 2)
            {
                MessageDialog.ToolTipShow("First name is to short!", "Emri është i shkurtë!", picFirstName);
            }
        }

        private void picLastName_MouseHover(object sender, EventArgs e)
        {
            if (txtLastName.Text == null)
            {
                MessageDialog.ToolTipShow("Last name is required!", "Mbiemri duhet të plotësohet!", picLastName);
            }
            else if (txtLastName.Text.Length < 2)
            {
                MessageDialog.ToolTipShow("Last name is to short!", "Mbiemri është i shkurtë!", picLastName);
            }
        }

        private void picRole_MouseHover(object sender, EventArgs e)
        {
            MessageDialog.ToolTipShow("Role is required!", "Roli duhet të plotësohet!", picRole);
        }

        private void picUsername_MouseHover(object sender, EventArgs e)
        {
            if (txtUsername.Text == null)
            {
                MessageDialog.ToolTipShow("Username is required!", "Nofka duhet të plotësohet!", picUsername);
            }
            else if (txtUsername.Text.Length < 2)
            {
                MessageDialog.ToolTipShow("Username is to short!", "Nofka është i shkurtë!", picFirstName);
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Length > 0)
            {
                Validation.Capitalize(txtFirstName);
            }

            if (txtFirstName.Text != null && txtFirstName.Text.Length > 2)
            {
                picFirstName.Visible = false;
            }
            else
            {
                Validation.SetImageVisibility(picFirstName);
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (txtLastName.Text.Length > 0)
            {
                Validation.Capitalize(txtLastName);
            }

            if (txtLastName.Text != null && txtLastName.Text.Length > 2)
            {
                picLastName.Visible = false;
            }
            else
            {
                Validation.SetImageVisibility(picLastName);
            }
        }

        private void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRoles.SelectedIndex != -1)
            {
                picRole.Visible = false;
            }
            else
            {
                Validation.SetImageVisibility(picRole);
            }

            if (cmbRoles.SelectedIndex != 1)
            {
                txtFirstName.Enabled = true;
                txtLastName.Enabled = true;
                cmbTeacher.Enabled = false;

                List<string> EmptyStrings = new List<string>();
                EmptyStrings.Add("NONE");

                cmbTeacher.DataSource = EmptyStrings;

                txtFirstName.Text = string.Empty;
                txtLastName.Text = string.Empty;
            }
            else
            {
                txtFirstName.Enabled = false;
                txtLastName.Enabled = false;
                cmbTeacher.Enabled = true;

                cmbTeacher.DataSource = MyTeachers;

                txtFirstName.Text = "NONE";
                txtLastName.Text = "NONE";
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text != null && txtUsername.Text.Length > 3)
            {
                picUsername.Visible = false;
            }
            else
            {
                Validation.SetImageVisibility(picUsername);
            }
        }
        #endregion
    }
}
