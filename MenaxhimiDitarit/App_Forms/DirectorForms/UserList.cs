using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        //Refresh i te dhenave ne DataGrid
        private void RefreshList()
        {
            MyUsers = _usersBLL.GetAll();
            dgvUserList.DataSource = MyUsers;
        }

        //Mirren te dhenat nga rreshti i klikuar
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

        private void UserListForm_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnViewAllUsers_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        //Kerkojm te dhenat ne DataGrid
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (_usersBLL != null)
                {
                    if (txtSearchUserByNU.Text.Trim().Length > 0)
                    {
                        //Shikojme nese teksti i shkruar ne TextBox eshte FirstName apo LastName
                        var findUsers = MyUsers.Where(f => f.FirstName.Contains(txtSearchUserByNU.Text)
                        || f.UserName.Contains(txtSearchUserByNU.Text)).ToList();

                        dgvUserList.DataSource = findUsers;
                    }
                    else
                    {
                        Validation.MessageBoxShow("Please write a name!", "Empty",
                            "Ju lutem shkruani emrin apo mbiemrin e përdoruesit!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        //Update te dhenat per rreshtin e klikuar ne DataGrid
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
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

        //Delete te dhenat per rreshtin e klikuar ne DataGrid
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
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
                                _usersBLL.Remove(user.UserID);

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

        //Shfaqim passwordin per rreshtin e klikuar ne DataGrid
        private void showPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvUserList.SelectedRows.Count > 0)
            {
                var row = dgvUserList.SelectedRows[0].Index;
                if (row >= 0)
                {
                    var user = GetUser(dgvUserList.Rows[row]);
                    if (user != null)
                    {
                        Validation.MessageBoxShow($"Username:\t{user.UserName}\nPassword:\t{user.UserPassword}", "Password",
                            $"Nofka:\t{user.UserName}\nFjalëkalimi:\t{user.UserPassword}?", "Fjalëkalimi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        //Update passwordin per rreshtin e klikuar ne DataGrid
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void txtSearchUserByNU_Click(object sender, EventArgs e)
        {
            txtSearchUserByNU.Text = "";
        }

        private void txtSearchUserByNU_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch_Click(this, new EventArgs());
        }

        //Hide Password me karakter
        private void dgvUserList_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.CellElement.Text != null)
            {
                dgvUserList.Rows[e.RowIndex].Tag = e.CellElement.Text;
                e.CellElement.Text = new string('\u25CF', e.CellElement.ToString().Length);
            }
        }
    }
}
