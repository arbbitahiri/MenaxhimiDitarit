using MenaxhimiDitarit.App_Code;
using MenaxhimiDitarit.App_Forms.DirectorForms;
using System;
using System.Windows.Forms;

namespace MenaxhimiDitarit.DirectorForms
{
    public partial class DirectorMain : Form
    {
        private Form activeForm = null;

        public DirectorMain()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        #region Methods for Panels
        /// <summary>
        /// Hides all the panels in Menu
        /// </summary>
        private void CustomizeDesign()
        {
            pnlTeachers.Visible = false;
            pnlUsers.Visible = false;
            pnlStaff.Visible = false;
        }

        /// <summary>
        /// Hides other submenu in Menu when it's button is clicked
        /// </summary>
        private void HideSubMenu()
        {
            if (pnlTeachers.Visible == true)
                pnlTeachers.Visible = false;

            if (pnlUsers.Visible == true)
                pnlUsers.Visible = false;

            if (pnlStaff.Visible == true)
                pnlStaff.Visible = false;
        }

        /// <summary>
        /// Shows the submenu when the button is clicked
        /// </summary>
        /// <param name="subMenu">The panel we want to show</param>
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        /// <summary>
        /// Opens the form in the panel on the right
        /// </summary>
        /// <param name="childForm"></param>
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }
        #endregion

        #region Teachers
        private void btnTeachers_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlTeachers);
        }

        private void btnListTeachers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DirectorTeacherList());

            HideSubMenu();
        }

        private void btnAddNTeacher_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TeacherCreate());

            HideSubMenu();
        }

        #endregion

        #region Users
        private void btnUsers_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlUsers);
        }

        private void btnListUsers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserList());

            HideSubMenu();
        }

        private void btnAddNUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserCreate());

            HideSubMenu();
        }

        #endregion

        #region Staff
        private void btnStaff_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlStaff);
        }

        private void btnListStaff_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StaffAbsenceList());

            HideSubMenu();
        }

        private void btnAddAbsenceStaff_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StaffAbsence());

            HideSubMenu();
        }
        #endregion

        private void btnRoles_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new RoleList());
        }

        private void btnReview_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new ReviewComment());
        }

        private void DirectorMainForm_Shown(object sender, EventArgs e)
        {
            lblUsername.Text = UserSession.GetUser.UserName;
            lblWelcomeName.Text = UserSession.GetUser.FirstName;
            lblDate.Text = DateTime.Now.ToShortDateString();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHELP_Click(object sender, EventArgs e)
        {
            MessageDialog.ShowHelp(this, "directormenu.html");
        }
    }
}
