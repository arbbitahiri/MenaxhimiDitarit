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
using Telerik.WinControls.UI;

namespace MenaxhimiDitarit.DirectorForms
{
    public partial class RoleListForm : Form
    {
        private readonly RoleBLL _rolesBLL;
        private List<Roles> _roles = null;

        public RoleListForm()
        {
            InitializeComponent();

            _rolesBLL = new RoleBLL();
        }

        private void RefreshList()
        {
            _roles = _rolesBLL.GetAll();
            dgvRoleList.DataSource = _roles;
        }

        private Roles GetRole(GridViewRowInfo roleRow)
        {
            try
            {
                Roles role = new Roles
                {
                    RoleID = (int)roleRow.Cells[0].Value,
                    RoleName = (string)roleRow.Cells[1].Value,
                    InsertBy = (string)roleRow.Cells[2].Value,
                    InsertDate = (DateTime)roleRow.Cells[3].Value,
                    LUB = (string)roleRow.Cells[4].Value,
                    LUD = (DateTime)roleRow.Cells[5].Value,
                    LUN = (int)roleRow.Cells[6].Value
                };

                return role;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void RoleListForm_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void txtSearchUser_Click(object sender, EventArgs e)
        {
            txtSearchUser.Text = "";
        }

        private void btnViewAllRoles_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (_rolesBLL != null)
            {
                if (dgvRoleList.SelectedRows.Count > 0)
                {
                    var findRole = _roles.Where(f => f.RoleName.Contains(txtSearchUser.Text)).ToList();

                    dgvRoleList.DataSource = findRole;
                }
                else
                    MessageBox.Show("Please write a name!!", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Role does not exist!!", "Doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvRoleList.SelectedRows.Count > 0)
            {
                var row = dgvRoleList.SelectedRows[0].Index;
                if (row >= 0)
                {
                    var role = GetRole(dgvRoleList.Rows[row]);
                    if (role != null)
                    {
                        RoleCreateForm roleCreate = new RoleCreateForm(role);
                        roleCreate.ShowDialog();
                    }
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvRoleList.SelectedRows.Count > 0)
            {
                var row = dgvRoleList.SelectedRows[0].Index;
                if (row >= 0)
                {
                    var role = GetRole(dgvRoleList.Rows[row]);
                    if (role != null)
                    {

                        if (MessageBox.Show($"Are you sure you want to delete {role.RoleName}?", "Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                            == DialogResult.OK)
                        {
                            _rolesBLL.Remove(role.RoleID);
                            MessageBox.Show("The selected Role has been deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshList();
                        }
                        else
                            MessageBox.Show("Please try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
