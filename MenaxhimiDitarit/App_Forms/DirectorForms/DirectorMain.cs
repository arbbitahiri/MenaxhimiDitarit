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
    public partial class DirectorMain : Form
    {
        private Form activeForm = null;

        public DirectorMain()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        #region Methodat per Panel-et
        private void CustomizeDesign()
        {
            pnlTeachers.Visible = false;
            pnlUsers.Visible = false;
        }

        private void HideSubMenu()
        {
            if (pnlTeachers.Visible == true)
                pnlTeachers.Visible = false;

            if (pnlUsers.Visible == true)
                pnlUsers.Visible = false;
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

        private void btnRoles_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RoleList());
        }

        private void btnReview_Click(object sender, EventArgs e)
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
    }
}
