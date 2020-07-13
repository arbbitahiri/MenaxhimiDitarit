using MenaxhimiDitarit.App_Code;
using MenaxhimiDitarit.BLL;
using MenaxhimiDitarit.BO;
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
using Telerik.WinControls.UI;

namespace MenaxhimiDitarit.App_Forms.DirectorForms
{
    public partial class StaffAbsenceList : Form
    {
        private readonly UserBLL _staffAbsenceBLL;
        private List<User> MyStaffAbsences;

        private readonly UserBLL _userBLL;
        private List<User> MyUsers;

        public StaffAbsenceList()
        {
            InitializeComponent();

            _staffAbsenceBLL = new UserBLL();
            _userBLL = new UserBLL();

            MyUsers = _userBLL.GetAllUser();
        }

        #region Metodat
        private void RefreshList()
        {
            MyStaffAbsences = _staffAbsenceBLL.GetAllStaffAbsence();
            dgvStaffAbsenceList.DataSource = MyStaffAbsences;
        }

        private User GetStaffAbsence(GridViewRowInfo staffAbsenceRow)
        {
            try
            {
                User staffAbsence = new User
                {
                    UserID = (int)staffAbsenceRow.Cells["UserID"].Value,
                    FirstName = (string)staffAbsenceRow.Cells["FirstName"].Value,
                    LastName = (string)staffAbsenceRow.Cells["LastName"].Value,
                    RoleID = (int)staffAbsenceRow.Cells["RoleID"].Value,
                    StaffAbsenceDate = (DateTime)staffAbsenceRow.Cells["StaffAbsenceDate"].Value,
                    StaffAbsenceReasoning = (string)staffAbsenceRow.Cells["StaffAbsenceReasoning"].Value,
                    InsertBy = (string)staffAbsenceRow.Cells["InsertBy"].Value,
                    InsertDate = (DateTime)staffAbsenceRow.Cells["InsertDate"].Value,
                    LUB = (string)staffAbsenceRow.Cells["LUB"].Value,
                    LUD = (DateTime)staffAbsenceRow.Cells["LUD"].Value,
                    LUN = (int)staffAbsenceRow.Cells["LUN"].Value
                };

                return staffAbsence;
            }
            catch (Exception)
            {
                Validation.MessageBoxShow("A problem occurred while getting those data!", "Problem",
                            "Ndodhi një problem gjatë marrjes së këtyre të dhënave!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        private void UpdateStaffAbsence()
        {
            if (dgvStaffAbsenceList.SelectedRows.Count > 0)
            {
                var row = dgvStaffAbsenceList.SelectedRows[0].Index;
                if (row >= 0)
                {
                    var staffAbsence = GetStaffAbsence(dgvStaffAbsenceList.Rows[row]);
                    if (staffAbsence != null)
                    {
                        StaffAbsence updateStaffAbsence = new StaffAbsence(staffAbsence)
                        {
                            StartPosition = FormStartPosition.CenterParent
                        };
                        updateStaffAbsence.ShowDialog();
                    }
                }
            }
            RefreshList();
        }
        #endregion

        private void StaffAbsenceList_Load(object sender, EventArgs e)
        {
            RefreshList();

            Validation.InitializePrintDocument(printDocument, "Staff Absence List", "Lista e Mungesës të Stafit");
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnSearchTeachers_Click(object sender, EventArgs e)
        {
            try
            {
                if (_staffAbsenceBLL != null)
                {
                    if (txtSearchName.Text.Trim().Length > 0)
                    {
                        var findStaffAbsence = MyUsers.Where(f => f.FirstName.Contains(txtSearchName.Text) && f.LastName.Contains(txtSearchName.Text)
                        && f.FullName.Contains(txtSearchName.Text)).ToList();

                        dgvStaffAbsenceList.DataSource = findStaffAbsence;
                    }
                    else
                    {
                        Validation.MessageBoxShow("Please write a name or surname!", "Empty",
                            "Ju lutemi shkruani emrin ose mbiemrin!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    Validation.MessageBoxShow("Absence does not exist!", "Doesn't exist",
                        "Mungesa nuk ekziston!", "Nuk ekziston", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                Validation.MessageBoxShow("A problem occurred while searching data!", "Problem",
                            "Ndodhi një problem gjatë kërkimit të të dhënave!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateStaffAbsence();
        }

        #region Menu
        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            StaffAbsence addStaffAbsence = new StaffAbsence
            {
                StartPosition = FormStartPosition.CenterParent
            };
            addStaffAbsence.ShowDialog();

            RefreshList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateStaffAbsence();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            dgvStaffAbsenceList.PrintPreview(printDocument);
        }

        #region Export
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread((ThreadStart)(() =>
            {
                var saveFileDialog = Validation.SaveFile("StaffAbsenceList", "ListaEMungesësStafit", ".xlsx", "Excel Workbook |*.xlsx");

                saveFileDialog.ShowDialog();

                Validation.ExportToExcel(dgvStaffAbsenceList, saveFileDialog.FileName, "StaffAbsenceList", "ListaEMungesësStafit");

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
                var saveFileDialog = Validation.SaveFile("StaffAbsenceList", "ListaEMungesësStafit", ".pdf", "Pdf Files|*.pdf");

                saveFileDialog.ShowDialog();

                Validation.ExportToPDF(dgvStaffAbsenceList, saveFileDialog.FileName);

                Validation.MessageBoxShow("PDF file created succesfully!", "Created", "PDF file u krijua me sukses!", "U krijua",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }));

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
        }
        #endregion

        #endregion

        #region Search Textbox
        private void txtSearchName_Click(object sender, EventArgs e)
        {
            txtSearchName.Text = "";
        }

        private void txtSearchName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchTeachers_Click(this, new EventArgs());
            }
        }

        private void txtSearchName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.NoNumber(e);
        }
        #endregion
    }
}
