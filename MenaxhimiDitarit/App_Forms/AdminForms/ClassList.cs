using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenaxhimiDitarit.AdminForms;
using MenaxhimiDitarit.App_Code;
using MenaxhimiDitarit.App_Forms.AdminForms;
using MenaxhimiDitarit.BLL;
using MenaxhimiDitarit.BO;
using Telerik.WinControls.UI;

namespace MenaxhimiDitarit
{
    public partial class ClassList : Form
    {
        private readonly ClassBLL _classBLL;
        private List<Class> MyClasses;

        public ClassList()
        {
            InitializeComponent();

            dgvClassesList.SelectionMode = GridViewSelectionMode.FullRowSelect;

            _classBLL = new ClassBLL();

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
            MyClasses = _classBLL.GetAll();
            dgvClassesList.DataSource = MyClasses;
        }

        //Mirren te dhenat nga rreshti i klikua
        private Class GetClass(GridViewRowInfo classRow)
        {
            try
            {
                Class classes = new Class
                {
                    ClassID = (int)classRow.Cells["ClassID"].Value,
                    TeacherID = (int)classRow.Cells["TeacherID"].Value,
                    ClassNo = (int)classRow.Cells["ClassNo"].Value,
                    RoomID = (int)classRow.Cells["RoomID"].Value,
                    InsertBy = (string)classRow.Cells["InsertBy"].Value,
                    InsertDate = (DateTime)classRow.Cells["InsertDate"].Value,
                    LUB = (string)classRow.Cells["LUB"].Value,
                    LUD = (DateTime)classRow.Cells["LUD"].Value,
                    LUN = (int)classRow.Cells["LUN"].Value
                };

                return classes;
            }
            catch (Exception)
            {
                Validation.MessageBoxShow("A problem occurred while getting those data!", "Problem",
                            "Ndodhi një problem gjatë marrjes së këtyre të dhënave!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void UpdateClass()
        {
            if (dgvClassesList.SelectedRows.Count > 0)
            {
                var row = dgvClassesList.SelectedRows[0].Index;
                if (row >= 0)
                {
                    var classes = GetClass(dgvClassesList.Rows[row]);
                    if (classes != null)
                    {
                        ClassCreate classUpdate = new ClassCreate(classes)
                        {
                            StartPosition = FormStartPosition.CenterParent
                        };
                        classUpdate.ShowDialog();
                    }
                }
            }
            RefreshList();
        }

        private void DeleteClass()
        {
            if (dgvClassesList.SelectedRows.Count > 0)
            {
                var row = dgvClassesList.SelectedRows[0].Index;
                if (row >= 0)
                {
                    var classes = GetClass(dgvClassesList.Rows[row]);
                    if (classes != null)
                    {
                        var result = Validation.MessageBoxShow($"Are you sure you want to delete class: {classes.ClassNo}", "Sure?",
                            $"A je i/e sigurt që do ta fshini klasën: {classes.ClassNo}", "Sigurt?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            _classBLL.Remove(classes.ClassID);

                            Validation.MessageBoxShow($"Class: {classes.ClassNo} has been deleted successfully!", "Deleted",
                               $"Klasa: {classes.ClassNo} është fshirë me sukses!", "U fshi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            RefreshList();
                        }
                    }
                }
            }
        }
        #endregion

        private void btnViewAllClass_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void ClassListForm_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        //Kerkojm te dhenat ne DataGrid
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (_classBLL != null)
                {
                    if (txtSearchClass.Text.Trim().Length > 0)
                    {
                        //Shikojme nese teksti i shkruar ne TextBox eshte ClassNo
                        var findClass = MyClasses.Where(f => f.ClassNo == int.Parse(txtSearchClass.Text)).ToList();

                        dgvClassesList.DataSource = findClass;
                    }
                    else
                    {
                        Validation.MessageBoxShow("Please write a class number!", "Empty",
                            "Ju lutem shkruani numrin e klasës!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Validation.MessageBoxShow("Class number does not exist!", "Doesn't exist",
                            "Klasa nuk ekziston!", "Nuk ekziston", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            UpdateClass();
        }

        //Delete te dhenat per rreshtin e klikuar ne DataGrid
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteClass();
        }

        //Shikojme orarin per klasen e krijuar ne DataGrid
        private void viewScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvClassesList.SelectedRows.Count > 0)
            {
                var row = dgvClassesList.SelectedRows[0].Index;
                if (row >= 0)
                {
                    var classes = GetClass(dgvClassesList.Rows[row]);
                    if (classes != null)
                    {
                        ClassScheduler viewSchedule = new ClassScheduler(classes)
                        {
                            StartPosition = FormStartPosition.CenterParent
                        };
                        viewSchedule.ShowDialog();
                    }
                }
            };
        }

        private void txtSearchClass_Click(object sender, EventArgs e)
        {
            txtSearchClass.Text = "";
        }

        private void txtSearchClass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(this, new EventArgs());
            }
        }

        //Lejon qe ne TextBox te shkruhet vetem numer dhe te mund te fshihet
        private void txtSearchClass_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.NoLetter(e);
        }

        #region Menu
        private void btnAddClass_Click(object sender, EventArgs e)
        {
            ClassCreate addClass = new ClassCreate
            {
                StartPosition = FormStartPosition.CenterParent
            };
            addClass.ShowDialog();
            RefreshList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateClass();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteClass();
        }

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
