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

            CustomizeDesign();
        }

        #region Metodat

        #region Menu
        private void CustomizeDesign()
        {
            pnlExport.Visible = false;
            pnlPrint.Visible = false;
        }

        private void HideSubMenu()
        {
            if (pnlExport.Visible == true)
            {
                pnlExport.Visible = false;
            }

            if (pnlPrint.Visible == true)
            {
                pnlPrint.Visible = false;
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

        //Refresh i te dhenave ne DataGrid
        private void RefreshList()
        {
            MyRoles = _rolesBLL.GetAll();
            dgvRoleList.DataSource = MyRoles;
        }
        #endregion

        private void RoleListForm_Load(object sender, EventArgs e)
        {
            RefreshList();
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
                    {
                        Validation.MessageBoxShow("Please write a role!", "Empty",
                            "Ju lutem shkruani rolin!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Validation.MessageBoxShow("Role does not exist!", "Doesn't exist",
                        "Roli nuk ekziston!", "Nuk ekziston", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                Validation.MessageBoxShow("A problem occurred while searching data!", "Problem",
                            "Ndodhi një problem gjatë kërkimit të të dhënave!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Search Textbox
        private void txtSearchUser_Click(object sender, EventArgs e)
        {
            txtSearchUser.Text = "";
        }

        private void txtSearchUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch_Click(this, new EventArgs());
        }

        private void txtSearchUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.NoNumber(e);
        }
        #endregion

        #region Menu

        #region Print
        private void btnPrintM_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlPrint);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {

        }

        private void btnPrintSettings_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Export
        private void btnExport_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlExport);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

        }

        private void btnPDF_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #endregion
    }
}