using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenaxhimiDitarit.TeacherForms
{
    public partial class TeacherMainForm : Form
    {
        private Form activeForm = null;

        public TeacherMainForm()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        #region Methods for Panels
        private void CustomizeDesign() {
            pnlTopics.Visible = false;
            pnlAbsences.Visible = false;
            pnlComments.Visible = false;
        }

        private void HideSubMenu() {
            if (pnlTopics.Visible == true)
                pnlTopics.Visible = false;

            if (pnlAbsences.Visible == true)
                pnlAbsences.Visible = false;

            if (pnlComments.Visible == true)
                pnlComments.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu) {
            if (subMenu.Visible == false) {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

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
            OpenChildForm(new TopicListForm());

            HideSubMenu();
        }

        private void btnAddNTopic_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TopicCreateForm());

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
            OpenChildForm(new AbsenceListForm());

            HideSubMenu();
        }

        private void btnAddNAbsence_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AbsenceCreateForm());

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
            OpenChildForm(new CommentListForm());

            HideSubMenu();
        }

        private void btnAddNewComment_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CommentCreateForm());

            HideSubMenu();
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            this.Close();
        }

        private void TeacherMainForm_Shown(object sender, EventArgs e)
        {
            lblUsername.Text = UserSession.GetUser.UserName;
        }
    }
}
