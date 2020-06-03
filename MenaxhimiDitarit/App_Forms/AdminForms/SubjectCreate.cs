using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenaxhimiDitarit.App_Code;
using MenaxhimiDitarit.BLL;
using MenaxhimiDitarit.BO;

namespace MenaxhimiDitarit
{
    public partial class SubjectCreate : Form
    {
        private readonly SubjectBLL _subjectBLL;
        private Subject _subject;
        private List<Subject> MySubjects;

        private readonly bool update = false;

        private readonly TeacherBLL _teacherBLL;
        private List<Teacher> MyTeachers;

        public SubjectCreate()
        {
            InitializeComponent();

            _subjectBLL = new SubjectBLL();
            _teacherBLL = new TeacherBLL();

            MySubjects = _subjectBLL.GetAll();
            MyTeachers = _teacherBLL.GetAll();

            cmbTeacher.DataSource = MyTeachers;

            update = false;

            txtID.Enabled = false;
        }

        public SubjectCreate(Subject subject)
        {
            InitializeComponent();

            _subjectBLL = new SubjectBLL();
            _teacherBLL = new TeacherBLL();

            MySubjects = _subjectBLL.GetAll();
            MyTeachers = _teacherBLL.GetAll();

            _subject = subject;

            update = _subject != null;

            txtSubjectTitle.Enabled = false;

            PopulateForm(_subject);

            cmbTeacher.DataSource = MyTeachers;

            txtID.Enabled = false;
        }

        //Popullimi i TextBox-ave dhe ComboBox-it me te dhenat nga Subject
        private void PopulateForm(Subject subject)
        {
            txtID.Text = subject.SubjectID.ToString();
            txtSubjectTitle.Text = subject.SubjectTitle;
            txtSubjectBook.Text = subject.Book;
            txtBookAuthor.Text = subject.Book_Author;
            cmbTeacher.SelectedItem = MyTeachers.FirstOrDefault(f => f.TeacherID == subject.TeacherID);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validation.CheckTextbox(this))
                {
                    Subject subject = new Subject
                    {
                        SubjectID = int.Parse(txtID.Text),
                        SubjectTitle = txtSubjectTitle.Text,
                        Book = txtSubjectBook.Text,
                        Book_Author = txtBookAuthor.Text,
                        InsertBy = UserSession.GetUser.UserName,
                        LUB = UserSession.GetUser.UserName,
                        TeacherID = Convert.ToInt32(cmbTeacher.SelectedValue.ToString())
                    };

                    if (!update)
                        subject.LUN++;
                    else if (update)
                        subject.LUN = ++_subject.LUN;

                    if (!update)
                    {
                        //Shikojme nese eksiston nje lend e till
                        var checkSubjects = MySubjects.Where(t => t.SubjectTitle == txtSubjectTitle.Text).ToList();

                        if (checkSubjects.Count > 0)
                            Validation.MessageBoxShow("Subject exists!", "Exists",
                                "Lënda ekziston!", "Ekziston", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            bool isRegistred = _subjectBLL.Add(subject);

                            if (isRegistred)
                            {
                                Validation.MessageBoxShow($"Subject: {subject.SubjectTitle} registred successfully", "Registered",
                                    $"Lënda: {subject.SubjectTitle} u regjistrua me sukses", "U regjistrua", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                Validation.MessageBoxShow("Registration failed!", "Error",
                                    "Regjistrimi dështoi!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        bool isUpdated = _subjectBLL.Add(subject);

                        if (isUpdated)
                        {
                            Validation.MessageBoxShow($"Subject: {subject.SubjectTitle} updated", "Updated",
                                $"Lënda: {subject.SubjectTitle} u përditësua!", "U përditësua", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                            Validation.MessageBoxShow("Update failed!", "Error",
                                "Përditësimi dështoi!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    Validation.MessageBoxShow("Please fill all fields!", "Error",
                        "Ju lutem plotësoni të gjitha fushat!", "Kujdes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                Validation.MessageBoxShow("A problem occurred while registering data!", "Error",
                    "Ndodhi një problem gjatë regjistrimit të të dhënave!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!Validation.CheckTextbox(this))
            {
                var result = Validation.MessageBoxShow("You have something written. Are you sure you want to exit form?", "Sure?",
                    "Keni të shkruar diçka. A je i/e sigurt që do të largoheni nga forma?", "Sigurt?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                    this.Close();
            }
        }

        private void txtBookAuthor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.NoNumber(e);
        }

        #region ErrorProvider
        private void picSubjectTitle_MouseHover(object sender, EventArgs e)
        {
            Validation.ToolTipShow("A title is required!", "Emri i lëndës duhet të plotësohet!", picSubjectTitle);
        }

        private void picBook_MouseHover(object sender, EventArgs e)
        {
            Validation.ToolTipShow("A book is required!", "Një libër duhet të plotësohet!", picBook);
        }

        private void picBAuthor_MouseHover(object sender, EventArgs e)
        {
            Validation.ToolTipShow("An author is required!", "Autori i librit duhet të plotësohet!", picBAuthor);
        }

        private void picTeacher_MouseHover(object sender, EventArgs e)
        {
            Validation.ToolTipShow("Please select a teacher!", "Zgjedh arsimtarin!", picTeacher);
        }

        private void txtSubjectTitle_TextChanged(object sender, EventArgs e)
        {
            if (txtSubjectTitle.Text != null && txtSubjectTitle.Text.Length > 2)
            {
                picSubjectTitle.Visible = false;
            }
            else
                picSubjectTitle.Image = Properties.Resources.icons8_cancel_15;
        }

        private void txtSubjectBook_TextChanged(object sender, EventArgs e)
        {
            if (txtSubjectBook.Text != null && txtSubjectBook.Text.Length > 2)
            {
                picBook.Visible = false;
            }
            else
                picBook.Image = Properties.Resources.icons8_cancel_15;
        }

        private void txtBookAuthor_TextChanged(object sender, EventArgs e)
        {
            if (txtBookAuthor.Text != null && txtBookAuthor.Text.Length > 2)
            {
                picBAuthor.Visible = false;
            }
            else
                picBAuthor.Image = Properties.Resources.icons8_cancel_15;
        }

        private void cmbTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTeacher.SelectedIndex != -1)
            {
                picTeacher.Visible = false;
            }
            else
                picTeacher.Image = Properties.Resources.icons8_cancel_15;
        }
        #endregion
    }
}
