using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenaxhimiDitarit.DirectorForms
{
    public partial class DirectorMainForm : Form
    {
        private Form activeForm = null;

        public DirectorMainForm()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        #region Methods for Panels
        private void CustomizeDesign()
        {
            pnlTeachers.Visible = false;
            pnlUsers.Visible = false;
            pnlRoles.Visible = false;
            pnlReview.Visible = false;
        }

        private void HideSubMenu()
        {
            if (pnlTeachers.Visible == true)
                pnlTeachers.Visible = false;

            if (pnlUsers.Visible == true)
                pnlUsers.Visible = false;

            if (pnlRoles.Visible == true)
                pnlRoles.Visible = false;

            if (pnlReview.Visible == true)
                pnlReview.Visible = false;
        }

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
            OpenChildForm(new DirectorTeacherListForm());

            HideSubMenu();
        }

        private void btnAddNTeacher_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TeacherCreateForm());

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
            OpenChildForm(new UserListForm());

            HideSubMenu();
        }

        private void btnAddNUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserCreateForm());

            HideSubMenu();
        }

        #endregion

        #region Roles
        private void btnRoles_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlRoles);
        }

        private void btnRolesList_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RoleListForm());

            HideSubMenu();
        }
        private void btnAddNRole_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RoleCreateForm());

            HideSubMenu();
        }

        #endregion

        #region Review
        private void btnReview_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlReview);
        }

        private void btnReviewComments_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReviewCommentForm());

            HideSubMenu();
        }
        #endregion

        private void DirectorMainForm_Shown(object sender, EventArgs e)
        {
            lblUsername.Text = UserSession.GetUser.UserName;
            lblWelcomeName.Text = UserSession.GetUser.FirstName;
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
