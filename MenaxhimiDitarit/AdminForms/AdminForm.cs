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
    public partial class AdminForm : Form
    {
        private Form activeForm = null;

        public AdminForm()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void CustomizeDesign()
        {
            pnlArsimtaret.Visible = false;
            pnlClassR.Visible = false;
            pnlLendet.Visible = false;
        }

        private void HideSubMenu()
        {
            if (pnlArsimtaret.Visible == true)
                pnlArsimtaret.Visible = false;

            if (pnlClassR.Visible == true)
                pnlClassR.Visible = false;

            if (pnlLendet.Visible == true)
                pnlLendet.Visible = false;
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

        #region Teachers
        private void btnTeachers_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlArsimtaret);
        }

        private void btnListTeachers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TeacherListForm());

            //kodi

            HideSubMenu();
        }

        private void btnAddNTacher_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TeacherCreateForm());

            //kodi

            HideSubMenu();
        }
        #endregion

        #region Subjects
        private void btnSubjects_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlLendet);
        }

        private void btnListSubjects_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SubjectListForm());

            //kodi

            HideSubMenu();
        }

        private void btnAddNSubject_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SubjectCreateForm());

            //kodi

            HideSubMenu();
        }
        #endregion

        #region Classrooms
        private void btnClassR_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlClassR);
        }

        private void btnListClassR_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new ClassListForm());

            //kodi

            HideSubMenu();
        }

        private void btnAddClassRSchedule_Click(object sender, EventArgs e)
        {
            //kodi

            HideSubMenu();
        }

        private void btnAddNewClass_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ClassCreateForm());

            //kodi

            HideSubMenu();
        }

        private void btnAddNewRoom_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RoomCreateForm());

            //kodi

            HideSubMenu();

        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
