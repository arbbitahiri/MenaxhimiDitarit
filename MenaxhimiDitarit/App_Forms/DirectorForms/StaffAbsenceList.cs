using MenaxhimiDitarit.App_Code;
using MenaxhimiDitarit.BLL;
using MenaxhimiDitarit.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
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
            MyStaffAbsences = _staffAbsenceBLL.GetAllStaffAbsence();
        }

        #region Methods
        /// <summary>
        /// Refreshes the list
        /// </summary>
        private void RefreshList()
        {
            MyStaffAbsences = _staffAbsenceBLL.GetAllStaffAbsence();
            dgvStaffAbsenceList.DataSource = MyStaffAbsences;
        }

        /// <summary>
        /// Gets the staff data, that we select in GridView
        /// </summary>
        /// <param name="staffAbsenceRow">The selected row</param>
        /// <returns>The data of staff</returns>
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
                MessageDialog.MessageBoxShow("A problem occurred while getting those data!", "Problem",
                            "Ndodhi një problem gjatë marrjes së këtyre të dhënave!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        /// <summary>
        /// Opens the form to update the absence of staff
        /// </summary>
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

        /// <summary>
        /// Searches for absences staff, by Name
        /// </summary>
        private void SearchStaffAbsence()
        {
            try
            {
                if (_staffAbsenceBLL != null)
                {
                    if (txtSearchName.Text.Trim().Length > 0)
                    {
                        var findStaffAbsence = MyStaffAbsences.Where(f => f.FirstName.Contains(txtSearchName.Text)
                        || f.LastName.Contains(txtSearchName.Text) || f.FullName.Contains(txtSearchName.Text)).ToList();

                        if (findStaffAbsence.Count > 0)
                        {
                            dgvStaffAbsenceList.DataSource = findStaffAbsence;
                        }
                        else
                        {
                            MessageDialog.MessageBoxShow("Nothing found!", "Empty",
                                "Nuk ka rezultat!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageDialog.MessageBoxShow("Please write a name or surname!", "Empty",
                            "Ju lutemi shkruani emrin ose mbiemrin!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageDialog.MessageBoxShow("Absence does not exist!", "Doesn't exist",
                        "Mungesa nuk ekziston!", "Nuk ekziston", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageDialog.MessageBoxShow("A problem occurred while searching data!", "Problem",
                            "Ndodhi një problem gjatë kërkimit të të dhënave!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Events
        // Form
        private void StaffAbsenceList_Load(object sender, EventArgs e)
        {
            RefreshList();

            Validation.InitializePrintDocument(printDocument, "Staff Absence List", "Lista e Mungesës të Stafit");
        }

        // Buttons
        private void btnViewAll_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnSearchTeachers_Click(object sender, EventArgs e)
        {
            SearchStaffAbsence();
        }

        private void btnHELP_Click(object sender, EventArgs e)
        {
            MessageDialog.ShowHelp(this, "staffabsencelist.html");
        }

        // Tool Strip Menu
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateStaffAbsence();
        }

        // Textboxes
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

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            ExportFile.ExportExcel("StaffAbsenceList", "ListaEMungesësStafit", ".xlsx", "Excel Workbook |*.xlsx", dgvStaffAbsenceList);

            MessageDialog.MessageBoxShow("Excel file created succesfully!", "Created", "Excel file u krijua me sukses!", "U krijua",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            ExportFile.ExportExcel("StaffAbsenceList", "ListaEMungesësStafit", ".pdf", "Pdf Files|*.pdf", dgvStaffAbsenceList);

            MessageDialog.MessageBoxShow("PDF file created succesfully!", "Created", "PDF file u krijua me sukses!", "U krijua",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
