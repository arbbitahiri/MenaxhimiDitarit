using MenaxhimiDitarit.App_Code;
using MenaxhimiDitarit.BLL;
using MenaxhimiDitarit.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MenaxhimiDitarit.App_Forms.DirectorForms
{
    public partial class StaffAbsence : Form
    {
        private readonly UserBLL _staffAbsenceBLL;
        private User _staffAbsence;
        private List<User> MyStaffAbsences;

        private bool update = false;

        private readonly UserBLL _userBLL;
        private List<User> MyUsers;

        public StaffAbsence()
        {
            InitializeComponent();

            _staffAbsenceBLL = new UserBLL();
            _userBLL = new UserBLL();

            update = false;

            MyStaffAbsences = _staffAbsenceBLL.GetAllStaffAbsence();
            MyUsers = _userBLL.GetAllUser();

            cmbStaff.DataSource = MyUsers;

            CustomizeDesign();
        }

        public StaffAbsence(User staffAbsence)
        {
            InitializeComponent();

            _staffAbsenceBLL = new UserBLL();
            _userBLL = new UserBLL();

            MyStaffAbsences = _staffAbsenceBLL.GetAllStaffAbsence();
            MyUsers = _userBLL.GetAllUser();

            _staffAbsence = staffAbsence;

            update = _staffAbsence != null;

            CustomizeDesign();
            PopulateForm(staffAbsence);
        }

        #region Metodat
        private void CustomizeDesign()
        {
            txtID.Enabled = false;
            dtpAbsenceDate.Enabled = false;
        }

        private void PopulateForm(User staffAbsence)
        {
            txtID.Text = staffAbsence.UserID.ToString();
            cmbStaff.SelectedItem = MyUsers.FirstOrDefault(f => f.UserID == staffAbsence.UserID);
            dtpAbsenceDate.Value = staffAbsence.StaffAbsenceDate;
        }
        #endregion

        #region Buttons
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                User staffAbsence = new User
                {
                    UserID = int.Parse(txtID.Text),
                    RoleID = UserSession.GetUser.RoleID,
                    FirstName = UserSession.GetUser.FirstName,
                    LastName = UserSession.GetUser.LastName,
                    StaffAbsenceReasoning = cmbReasoning.SelectedItem.ToString(),
                    StaffAbsenceDate = dtpAbsenceDate.Value,
                    InsertBy = UserSession.GetUser.UserName,
                    LUB = UserSession.GetUser.UserName
                };

                if (!update)
                    staffAbsence.LUN++;
                else if (update)
                    staffAbsence.LUN = ++_staffAbsence.LUN;

                var checkStaffAbsence = MyStaffAbsences.Where(t => t.UserID == Convert.ToInt32(cmbStaff.SelectedValue.ToString())
                && t.StaffAbsenceDate == DateTime.Parse(dtpAbsenceDate.Value.ToShortDateString())).ToList();

                if (checkStaffAbsence.Count > 0)
                {
                    Validation.MessageBoxShow("Can't create absence for that time!", "Error",
                        "Nuk mund të krijojë mungesë për atë kohë!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (!update)
                    {
                        bool isRegistred = _staffAbsenceBLL.AddStaffAbsence(staffAbsence);

                        if (isRegistred)
                        {
                            Validation.MessageBoxShow("Absence registered successfully!", "Registered",
                                "Mungesa u regjistrua me sukses!", "U regjistrua", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            Validation.MessageBoxShow("Registration failed!", "Error",
                                "Regjistrimi dështoi!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        bool isUpdated = _staffAbsenceBLL.AddStaffAbsence(staffAbsence);

                        if (isUpdated)
                        {
                            Validation.MessageBoxShow("Absence updated", "Updated",
                                "Mungesa u përditësua", "U përditësua", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            Validation.MessageBoxShow("Update failed!", "Error",
                                "Përditësimi dështoi!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string eee = ex.Message;
                Validation.MessageBoxShow("A problem occurred while registering data!", "Error",
                    "Ndodhi një problem gjatë regjistrimit të të dhënave!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Validation.CheckTextbox(this))
            {
                var result = Validation.MessageBoxShow("You have something written. Are you sure you want to exit form?", "Sure?",
                    "Keni të shkruar diçka. A je i/e sigurt që do të largoheni nga forma?", "Sigurt?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                    this.Close();
            }
            else
            {
                this.Close();
            }
        }
        #endregion

        #region Error Providers
        private void picStaff_MouseHover(object sender, EventArgs e)
        {
            Validation.ToolTipShow("Staff is required!", "Stafi duhet të plotësohet!", picStaff);
        }

        private void picReasoning_MouseHover(object sender, EventArgs e)
        {
            Validation.ToolTipShow("Reason is required!", "Arsyeja duhet të plotësohet!", picReasoning);
        }

        private void cmbStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStaff.SelectedIndex != -1)
            {
                picStaff.Visible = false;
            }
            else
            {
                Validation.SetImageVisibility(picStaff);
            }
        }

        private void cmbReasoning_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbReasoning.SelectedIndex != -1)
            {
                picReasoning.Visible = false;
            }
            else
            {
                Validation.SetImageVisibility(picReasoning);
            }
        }
        #endregion
    }
}
