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
    public partial class RoleList : Form
    {
        private readonly RoleBLL _rolesBLL;
        private List<Role> MyRoles = null;

        public RoleList()
        {
            InitializeComponent();

            dgvRoleList.SelectionMode = GridViewSelectionMode.FullRowSelect;

            _rolesBLL = new RoleBLL();
            MyRoles = _rolesBLL.GetAll();
        }

        //Refresh i te dhenave ne DataGrid
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

        //Kerkojm te dhenat ne DataGrid
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (_rolesBLL != null)
                {
                    if (dgvRoleList.SelectedRows.Count > 0)
                    {
                        //Shikojme nese teksti i shkruar ne TextBox eshte RoleName
                        var findRole = MyRoles.Where(f => f.RoleName.Contains(txtSearchUser.Text)).ToList();

                        dgvRoleList.DataSource = findRole;
                    }
                    else
                        MessageBox.Show("Please write a name!!", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Role does not exist!!", "Doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"A problem occurred while searching data!\n{ex.Message}",
                    "Problem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSearchUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch_Click(this, new EventArgs());
        }
    }
}