using MenaxhimiDitarit.AdminForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenaxhimiDitarit
{
    public partial class AdminMainForm : Form
    {
        private Form activeForm = null;

        public AdminMainForm()
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
        }

        private void HideSubMenu()
        {
            if (pnlTeachers.Visible == true)
                pnlTeachers.Visible = false;

            if (pnlClassR.Visible == true)
                pnlClassR.Visible = false;

            if (pnlSubjects.Visible == true)
                pnlSubjects.Visible = false;
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
            OpenChildForm(new TeacherListForm());

            HideSubMenu();
        }

        private void btnAddNTacher_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TeacherCreateForm());

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
            OpenChildForm(new SubjectListForm());

            HideSubMenu();
        }

        private void btnAddNSubject_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SubjectCreateForm());

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
            OpenChildForm(new ClassListForm());

            HideSubMenu();
        }

        private void btnAddClassRSchedule_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ClassScheduletList());

            HideSubMenu();
        }

        private void btnAddNewClass_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ClassCreateForm());

            HideSubMenu();
        }

        private void btnAddNewRoom_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RoomCreateForm());

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
            OpenChildForm(new RoomListForm());

            HideSubMenu();
        }

        private void btnAddNewRoom_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new RoomCreateForm());

            HideSubMenu();
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            this.Close();
        }

        private void AdminMainForm_Shown(object sender, EventArgs e)
        {
            lblUsername.Text = UserSession.GetUser.UserName;
        }
    }
}
