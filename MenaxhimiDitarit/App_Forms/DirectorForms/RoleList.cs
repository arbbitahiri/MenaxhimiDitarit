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
                        Validation.MessageBoxShow("Please write a role!", "Empty",
                            "Ju lutem shkruani rolin!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    Validation.MessageBoxShow("Role does not exist!", "Doesn't exist",
                        "Roli nuk ekziston!", "Nuk ekziston", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                Validation.MessageBoxShow("A problem occurred while searching data!", "Problem",
                            "Ndodhi një problem gjatë kërkimit të të dhënave!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearchUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch_Click(this, new EventArgs());
        }
    }
}