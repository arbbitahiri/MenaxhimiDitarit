using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        private void RefreshList()
        {
            MyRoles = _rolesBLL.GetAll();
            dgvRoleList.DataSource = MyRoles;
        }

        private void RoleListForm_Load(object sender, EventArgs e)
        {
            RefreshList();

            Validation.InitializePrintDocument(printDocument, "Role List", "Lista e Roleve");
        }

        #region Button
        private void btnViewAllRoles_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

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
        #endregion

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
        private void btnPrint_Click(object sender, EventArgs e)
        {
            dgvRoleList.PrintPreview(printDocument);
        }

        #region Export
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread((ThreadStart)(() =>
            {
                var saveFileDialog = Validation.SaveFile("RoleList", "ListaERoleve", ".xlsx", "Excel Workbook |*.xlsx");

                saveFileDialog.ShowDialog();

                Validation.ExportToExcel(dgvRoleList, saveFileDialog.FileName, "RoleList", "ListaERoleve");

                Validation.MessageBoxShow("Excel file created succesfully!", "Created", "Excel file u krijua me sukses!", "U krijua",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }));

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread((ThreadStart)(() =>
            {
                var saveFileDialog = Validation.SaveFile("RoleList", "ListaERoleve", ".pdf", "Pdf Files|*.pdf");

                saveFileDialog.ShowDialog();

                Validation.ExportToPDF(dgvRoleList, saveFileDialog.FileName);

                Validation.MessageBoxShow("PDF file created succesfully!", "Created", "PDF file u krijua me sukses!", "U krijua",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }));

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
        }
        #endregion

        #endregion
    }
}