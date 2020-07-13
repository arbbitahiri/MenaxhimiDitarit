using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using MenaxhimiDitarit.App_Code;
using MenaxhimiDitarit.App_Forms.DirectorForms;
using MenaxhimiDitarit.BLL;
using MenaxhimiDitarit.BO;
using Telerik.WinControls.UI;

namespace MenaxhimiDitarit.DirectorForms
{
    public partial class UserList : Form
    {
        private readonly UserBLL _usersBLL;
        private List<User> MyUsers = null;

        public UserList()
        {
            InitializeComponent();

            _usersBLL = new UserBLL();

            dgvUserList.SelectionMode = GridViewSelectionMode.FullRowSelect;

            CustomizeDesign();
        }

        #region Methods
        /// <summary>
        /// Methods for menu in the right
        /// </summary>
        #region Menu
        private void CustomizeDesign()
        {
            pnlUpdate.Visible = false;
        }

        private void HideSubMenu()
        {
            if (pnlUpdate.Visible == true)
            {
                pnlUpdate.Visible = false;
            }
        }

        private void ShowSubMenu(Panel panel)
        {
            if (panel.Visible == false)
            {
                HideSubMenu();
                panel.Visible = true;
            }
            else
                panel.Visible = false;
        }
        #endregion

        /// <summary>
        /// Refreshes the list
        /// </summary>
        private void RefreshList()
        {
            MyUsers = _usersBLL.GetAllUser();
            dgvUserList.DataSource = MyUsers;
        }

        /// <summary>
        /// Gets the user data, that we select in GridView
        /// </summary>
        /// <param name="userRow">The selected row</param>
        /// <returns>The data of user</returns>
        private User GetUser(GridViewRowInfo userRow)
        {
            try
            {
                User user = new User
                {
                    UserID = (int)userRow.Cells["UserID"].Value,
                    FirstName = (string)userRow.Cells["FirstName"].Value,
                    LastName = (string)userRow.Cells["LastName"].Value,
                    UserName = (string)userRow.Cells["UserName"].Value,
                    UserPassword = (string)userRow.Cells["UserPassword"].Value,
                    ExpiresDate = (DateTime)userRow.Cells["ExpiresDate"].Value,
                    RoleID = (int)userRow.Cells["RoleID"].Value,
                    LastLoginDate = (DateTime)userRow.Cells["LastLoginDate"].Value,
                    LastPasswordChangeDate = (DateTime)userRow.Cells["LastPasswordChangeDate"].Value,
                    IsPasswordChanged = (bool)userRow.Cells["IsPasswordChanged"].Value,
                    InsertBy = (string)userRow.Cells["InsertBy"].Value,
                    InsertDate = (DateTime)userRow.Cells["InsertDate"].Value,
                    LUB = (string)userRow.Cells["LUB"].Value,
                    LUD = (DateTime)userRow.Cells["LUD"].Value,
                    LUN = (int)userRow.Cells["LUN"].Value
                };

                return user;
            }
            catch (Exception)
            {
                Validation.MessageBoxShow("A problem occurred while getting those data!", "Problem",
                            "Ndodhi një problem gjatë marrjes së këtyre të dhënave!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// Opens the form to update the user
        /// </summary>
        private void UpdateUser()
        {
            if (dgvUserList.SelectedRows.Count > 0)
            {
                var row = dgvUserList.SelectedRows[0].Index;
                if (row >= 0)
                {
                    var user = GetUser(dgvUserList.Rows[row]);
                    if (user != null)
                    {
                        UserUpdate userUpdate = new UserUpdate(user)
                        {
                            StartPosition = FormStartPosition.CenterParent
                        };
                        userUpdate.ShowDialog();
                    }
                }
            }
            RefreshList();
        }

        /// <summary>
        /// Deletes the user
        /// </summary>
        private void DeleteUser()
        {
            if (dgvUserList.SelectedRows.Count > 0)
            {
                var row = dgvUserList.SelectedRows[0].Index;
                if (row >= 0)
                {
                    var user = GetUser(dgvUserList.Rows[row]);
                    if (user != null)
                    {
                        if (UserSession.GetUser.UserName == user.UserName)
                        {
                            Validation.MessageBoxShow("You cannot delete your user account!", "Warning",
                                "Nuk mund ta fshini llogarinë tënde!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            var result = Validation.MessageBoxShow($"Are you sure you want to delete {user.UserName}?", "Sure?",
                                $"A je i/e sigurt që do ta fshini përdoruesin: {user.UserName}?", "Sigurt?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                _usersBLL.RemoveUser(user.UserID);

                                Validation.MessageBoxShow($"Username: {user.UserName} has been deleted successfully!", "Deleted",
                                    $"Përdoruesi: {user.UserName} u fshi!", "U fshi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                RefreshList();
                            }
                        }
                    }
                }
            }
            RefreshList();
        }

        /// <summary>
        /// Opens the form to change the password, depending on the selected row
        /// </summary>
        private void ChangePassword()
        {
            if (dgvUserList.SelectedRows.Count > 0)
            {
                var row = dgvUserList.SelectedRows[0].Index;
                if (row >= 0)
                {
                    var user = GetUser(dgvUserList.Rows[row]);
                    if (user != null)
                    {
                        UserUpdatePassword userChangePassword = new UserUpdatePassword(user)
                        {
                            StartPosition = FormStartPosition.CenterParent
                        };
                        userChangePassword.ShowDialog();
                    }
                }
            }
            RefreshList();
        }

        /// <summary>
        /// Searches user by Name
        /// </summary>
        private void SearchUser()
        {
            try
            {
                if (_usersBLL != null)
                {
                    if (txtSearchUserByNU.Text.Trim().Length > 0)
                    {
                        var findUsers = MyUsers.Where(f => f.FirstName.Contains(txtSearchUserByNU.Text)
                        || f.UserName.Contains(txtSearchUserByNU.Text) || f.FullName.Contains(txtSearchUserByNU.Text)).ToList();

                        dgvUserList.DataSource = findUsers;
                    }
                    else
                    {
                        Validation.MessageBoxShow("Please write a name!", "Empty",
                            "Ju lutem shkruani emrin apo mbiemrin e përdoruesit!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    Validation.MessageBoxShow("User does not exist!", "Doesn't exist",
                        "Përdoruesi nuk ekziston!", "Nuk ekziston", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                Validation.MessageBoxShow("A problem occurred while searching data!", "Problem",
                            "Ndodhi një problem gjatë kërkimit të të dhënave!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Events
        // Form
        private void UserListForm_Load(object sender, EventArgs e)
        {
            RefreshList();

            Validation.InitializePrintDocument(printDocument, "User List", "Lista e Përdoruesve");
        }

        // Buttons
        private void btnViewAllUsers_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchUser();
        }

        // Tool Strip Menus
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateUser();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword();
        }

        // Textboxes
        private void txtSearchUserByNU_Click(object sender, EventArgs e)
        {
            txtSearchUserByNU.Text = "";
        }

        private void txtSearchUserByNU_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(this, new EventArgs());
            }
        }

        private void txtSearchUserByNU_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.NoNumber(e);
        }
        #endregion

        #region Menu
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            UserCreate addUser = new UserCreate
            {
                StartPosition = FormStartPosition.CenterParent
            };
            addUser.ShowDialog();
            RefreshList();
        }

        #region Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlUpdate);
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            UpdateUser();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword();
        }
        #endregion

        private void btnDeleteU_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }

        private void btnPrintUser_Click(object sender, EventArgs e)
        {
            dgvUserList.PrintPreview(printDocument);
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            ExportFile.ExportExcel("UserList", "ListaEPërdoruesve", ".xlsx", "Excel Workbook |*.xlsx", dgvUserList);

            Validation.MessageBoxShow("Excel file created succesfully!", "Created", "Excel file u krijua me sukses!", "U krijua",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            ExportFile.ExportExcel("UserList", "ListaEPërdoruesve", ".pdf", "Pdf Files|*.pdf", dgvUserList);

            Validation.MessageBoxShow("PDF file created succesfully!", "Created", "PDF file u krijua me sukses!", "U krijua",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}