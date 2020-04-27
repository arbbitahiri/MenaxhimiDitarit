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
        private List<Role> MyRoles = null;

        public RoleListForm()
        {
            InitializeComponent();

            dgvRoleList.SelectionMode = GridViewSelectionMode.FullRowSelect;

            _rolesBLL = new RoleBLL();
            MyRoles = _rolesBLL.GetAll();
        }

        private void RefreshList()
        {
            MyRoles = _rolesBLL.GetAll();
            dgvRoleList.DataSource = MyRoles;
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
                    var findRole = MyRoles.Where(f => f.RoleName.Contains(txtSearchUser.Text)).ToList();

                    dgvRoleList.DataSource = findRole;
                }
                else
                    MessageBox.Show("Please write a name!!", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Role does not exist!!", "Doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txtSearchUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch_Click(this, new EventArgs());
        }
    }
}








//private Role GetRole(GridViewRowInfo roleRow)
//{
//    try
//    {
//        Role role = new Role
//        {
//            RoleID = (int)roleRow.Cells[0].Value,
//            RoleName = (string)roleRow.Cells[1].Value,
//            InsertBy = (string)roleRow.Cells[2].Value,
//            InsertDate = (DateTime)roleRow.Cells[3].Value,
//            LUB = (string)roleRow.Cells[4].Value,
//            LUD = (DateTime)roleRow.Cells[5].Value,
//            LUN = (int)roleRow.Cells[6].Value
//        };

//        return role;
//    }
//    catch (Exception)
//    {
//        return null;
//    }
//}
