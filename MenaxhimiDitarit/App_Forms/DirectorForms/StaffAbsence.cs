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

            cmbStaff.DataSource = MyUsers;

            CustomizeDesign();
            PopulateForm(staffAbsence);
        }

        #region Methods
        /// <summary>
        /// Disables txtID and dtpAbsenceDate (textbox and datetimepicker)
        /// </summary>
        private void CustomizeDesign()
        {
            dtpAbsenceDate.Enabled = false;
        }

        /// <summary>
        /// Populates the form with the adequate data from the list form
        /// </summary>
        /// <param name="staffAbsence"></param>
        private void PopulateForm(User staffAbsence)
        {
            txtID.Text = staffAbsence.UserID.ToString();
            cmbStaff.SelectedItem = MyStaffAbsences.FirstOrDefault(f => f.UserID == staffAbsence.UserID);
            dtpAbsenceDate.Value = staffAbsence.StaffAbsenceDate;
        }

        /// <summary>
        /// Gets the name of the user depending on his/her id
        /// </summary>
        /// <param name="name">First or Last name</param>
        /// <param name="nameID">His/her id</param>
        /// <returns>First or Last name depending on the parameter "name"</returns>
        private string GetName(string name, int nameID)
        {
            foreach (var id in MyUsers)
            {
                if (nameID == id.UserID)
                {
                    if (name == "FirstName")
                    {
                        return id.FirstName;
                    }
                    else if (name == "LastName")
                    {
                        return id.LastName;
                    }
                    else
                    {
                        return "No data available!";
                    }
                }
            }
            return "No data available!";
        }

        /// <summary>
        /// Creates or updates the absence of staff, depending on ID
        /// </summary>
        private void CreateStaffAbsence()
        {
            try
            {
                User staffAbsence = new User
                {
                    UserID = int.Parse(txtID.Text),
                    RoleID = UserSession.GetUser.RoleID,
                    FirstName = GetName("FirstName", Convert.ToInt32(cmbStaff.SelectedValue.ToString())),
                    LastName = GetName("LastName", Convert.ToInt32(cmbStaff.SelectedValue.ToString())),
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
                    MessageDialog.MessageBoxShow("Can't create absence for that time!", "Error",
                        "Nuk mund të krijojë mungesë për atë kohë!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (!update)
                    {
                        bool isRegistred = _staffAbsenceBLL.AddStaffAbsence(staffAbsence);

                        if (isRegistred)
                        {
                            MessageDialog.DoYouWantToContinue(this, "Absence", "Mungesa");
                        }
                        else
                        {
                            MessageDialog.MessageBoxShow("Registration failed!", "Error",
                                "Regjistrimi dështoi!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        bool isUpdated = _staffAbsenceBLL.AddStaffAbsence(staffAbsence);

                        if (isUpdated)
                        {
                            MessageDialog.MessageBoxShow("Absence updated", "Updated",
                                "Mungesa u përditësua", "U përditësua", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageDialog.MessageBoxShow("Update failed!", "Error",
                                "Përditësimi dështoi!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageDialog.MessageBoxShow("A problem occurred while registering data!", "Error",
                    "Ndodhi një problem gjatë regjistrimit të të dhënave!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Events
        // Buttons
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CreateStaffAbsence();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Validation.CloseForm(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Validation.CloseForm(this);
        }

        private void btnHELP_Click(object sender, EventArgs e)
        {
            MessageDialog.ShowHelp(this, "staffabsencecreate.html");
        }
        #endregion

        #region Error Providers
        private void picStaff_MouseHover(object sender, EventArgs e)
        {
            MessageDialog.ToolTipShow("Staff is required!", "Stafi duhet të plotësohet!", picStaff);
        }

        private void picReasoning_MouseHover(object sender, EventArgs e)
        {
            MessageDialog.ToolTipShow("Reason is required!", "Arsyeja duhet të plotësohet!", picReasoning);
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
