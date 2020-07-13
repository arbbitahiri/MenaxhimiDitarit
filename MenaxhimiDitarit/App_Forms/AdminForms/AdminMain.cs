using MenaxhimiDitarit.AdminForms;
using System;
using System.Windows.Forms;

namespace MenaxhimiDitarit
{
    public partial class AdminMain : Form
    {
        private Form activeForm;

        public AdminMain()
        {
            InitializeComponent();

            CustomizeDesign();
        }

        #region Methods for Panels
        private void CustomizeDesign()
        {
            pnlTeachers.Visible = false;
            pnlClassR.Visible = false;
            pnlSubjects.Visible = false;
            pnlRoom.Visible = false;
            pnlSchedule.Visible = false;
        }

        private void HideSubMenu()
        {
            if (pnlTeachers.Visible == true)
                pnlTeachers.Visible = false;

            if (pnlClassR.Visible == true)
                pnlClassR.Visible = false;

            if (pnlSubjects.Visible == true)
                pnlSubjects.Visible = false;

            if (pnlRoom.Visible == true)
                pnlRoom.Visible = false;

            if (pnlSchedule.Visible == true)
                pnlSchedule.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false) {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

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
            OpenChildForm(new TeacherList());

            HideSubMenu();
        }

        private void btnAddNTacher_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TeacherCreate());

            HideSubMenu();
        }
        #endregion

        #region Subjects
        private void btnSubjects_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubjects);
        }

        private void btnListSubjects_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SubjectList());

            HideSubMenu();
        }

        private void btnAddNSubject_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SubjectCreate());

            HideSubMenu();
        }
        #endregion

        #region Classes
        private void btnClassR_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlClassR);
        }

        private void btnListClassR_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new ClassList());

            HideSubMenu();
        }

        private void btnAddNewClass_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ClassCreate());

            HideSubMenu();
        }
        #endregion

        #region Rooms
        private void btnRoom_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlRoom);
        }

        private void btnListRooms_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RoomList());

            HideSubMenu();
        }

        private void btnAddNewRoom_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new RoomCreate());

            HideSubMenu();
        }
        #endregion

        #region Schedule
        private void btnSchedule_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSchedule);
        }

        private void btnListSchedules_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ClassScheduletList());

            HideSubMenu();
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ClassScheduleCreate());

            HideSubMenu();
        }
        #endregion

        private void AdminMainForm_Shown(object sender, EventArgs e)
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
    }
}
