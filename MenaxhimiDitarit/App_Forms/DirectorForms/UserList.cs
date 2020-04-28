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
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace MenaxhimiDitarit.DirectorForms
{
    public partial class UserList : Form
    {
        private readonly UserBLL _usersBLL;
        private List<User> MyUsers = null;

        private readonly RoleBLL _roleBLL;
        private List<Role> MyRoles = null;

        public UserList()
        {
            InitializeComponent();

            _usersBLL = new UserBLL();
            _roleBLL = new RoleBLL();

            dgvUserList.SelectionMode = GridViewSelectionMode.FullRowSelect;
        }

        private void RefreshList()
        {
            MyUsers = _usersBLL.GetAll();
            MyRoles = _roleBLL.GetAll();
            dgvUserList.DataSource = MyUsers;
        }

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
                    InsertBy = (string)userRow.Cells[9].Value,
                    InsertDate = (DateTime)userRow.Cells[10].Value,
                    LUB = (string)userRow.Cells[11].Value,
                    LUD = (DateTime)userRow.Cells[12].Value,
                    LUN = (int)userRow.Cells[13].Value
                };

                return user;
            }
            catch (Exception)
            {
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (_usersBLL != null)
            {
                if (txtSearchUserByNU.Text.Trim().Length > 0)
                {
                    var findUsersByNU = MyUsers.Where(f => f.FirstName.Contains(txtSearchUserByNU.Text) || f.UserName.Contains(txtSearchUserByNU.Text)).ToList();

                    dgvUserList.DataSource = findUsersByNU;
                }
                else
                    MessageBox.Show("Please write a name!!", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("User does not exist!!", "Doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

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
                        UserCreate userUpdate = new UserCreate(user);
                        userUpdate.StartPosition = FormStartPosition.CenterParent;
                        userUpdate.ShowDialog();
                    }
                }
            }
            RefreshList();
        }

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


                        if (MessageBox.Show($"Are you sure you want to delete {user.UserName}?", "Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                            == DialogResult.OK)
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

        private void txtSearchUserByNU_Click(object sender, EventArgs e)
        {
            txtSearchUserByNU.Text = "";
        }

        private void txtSearchUserByNU_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch_Click(this, new EventArgs());
        }
    }
}
