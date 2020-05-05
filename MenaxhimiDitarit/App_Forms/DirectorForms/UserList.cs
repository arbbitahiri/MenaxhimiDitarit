using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                    UserID = (int)userRow.Cells[0].Value,
                    FirstName = (string)userRow.Cells[1].Value,
                    LastName = (string)userRow.Cells[2].Value,
                    UserName = (string)userRow.Cells[3].Value,
                    UserPassword = (string)userRow.Cells[4].Value,
                    ExpiresDate = (DateTime)userRow.Cells[5].Value,
                    RoleID = (int)userRow.Cells[6].Value,
                    LastLoginDate = (DateTime)userRow.Cells[7].Value,
                    LastPasswordChangeDate = (DateTime)userRow.Cells[8].Value,
                    IsPasswordChanged = (bool)userRow.Cells[9].Value,
                    InsertBy = (string)userRow.Cells[12].Value,
                    InsertDate = (DateTime)userRow.Cells[13].Value,
                    LUB = (string)userRow.Cells[14].Value,
                    LUD = (DateTime)userRow.Cells[15].Value,
                    LUN = (int)userRow.Cells[16].Value
                };

                return user;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A problem occurred getting those data!\n{ex.Message}", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Please write a name!!", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("User does not exist!!", "Doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A problem occurred while searching data!\n{ex.Message}", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                            MessageBox.Show("You cannot delete your User Account", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                        {
                            if (MessageBox.Show($"Are you sure you want to delete {user.UserName}?", "Sure?",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                _usersBLL.Remove(user.UserID);
                                MessageBox.Show($"User: {user.UserName} has been deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                RefreshList();
                            }
                            else
                                MessageBox.Show("Please try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show($"Username:\t{user.UserName}\nPassword:\t{user.UserPassword}", "Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        UserUpdatePassword userChangePassword = new UserUpdatePassword(user);
                        userChangePassword.StartPosition = FormStartPosition.CenterParent;
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
