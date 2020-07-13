using System;
using System.Windows.Forms;

namespace MenaxhimiDitarit.TeacherForms
{
    public partial class TeacherMain : Form
    {
        private Form activeForm = null;

        public TeacherMain()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        #region Methods for Panels
        /// <summary>
        /// Hides all the panels in Menu
        /// </summary>
        private void CustomizeDesign() {
            pnlTopics.Visible = false;
            pnlAbsences.Visible = false;
            pnlComments.Visible = false;
        }

        /// <summary>
        /// Hides other submenu in Menu when it's button is clicked
        /// </summary>
        private void HideSubMenu() {
            if (pnlTopics.Visible == true)
                pnlTopics.Visible = false;

            if (pnlAbsences.Visible == true)
                pnlAbsences.Visible = false;

            if (pnlComments.Visible == true)
                pnlComments.Visible = false;
        }

        /// <summary>
        /// Shows the submenu when the button is clicked
        /// </summary>
        /// <param name="subMenu">The panel we want to show</param>
        private void ShowSubMenu(Panel subMenu) {
            if (subMenu.Visible == false) {
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
        private void OpenChildForm(Form childForm) {
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

        #region Topics
        private void btnTopics_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlTopics);
        }

        private void btnListTopics_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TopicList());

            HideSubMenu();
        }

        private void btnAddNTopic_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TopicCreate());

            HideSubMenu();
        }
        #endregion

        #region Absences
        private void btnAbsences_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlAbsences);
        }

        private void btnListAbsences_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AbsenceList());

            HideSubMenu();
        }

        private void btnAddNAbsence_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AbsenceCreate());

            HideSubMenu();
        }

        #endregion

        #region Comments
        private void btnComments_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlComments);
        }

        private void btnListComments_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CommentList());

            HideSubMenu();
        }

        private void btnAddNewComment_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CommentCreate());

            HideSubMenu();
        }
        #endregion

        private void TeacherMainForm_Shown(object sender, EventArgs e)
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
