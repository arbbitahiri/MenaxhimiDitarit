using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

            txtID.Enabled = false;
            cmbTeacher.DataSource = MyTeachers;

            update = false;
        }

        public SubjectCreate(Subject subject)
        {
            InitializeComponent();

            _subjectBLL = new SubjectBLL();
            _teacherBLL = new TeacherBLL();

            MyTeachers = _teacherBLL.GetAll();
            cmbTeacher.DataSource = MyTeachers;

            _subject = subject;

            update = _subject != null;
            PopulateForm(_subject);

            txtID.Enabled = false;
            txtSubjectTitle.Enabled = false;
        }

        private void PopulateForm(Subject subject)
        {
            txtID.Text = subject.SubjectID.ToString();
            txtSubjectTitle.Text = subject.SubjectTitle;
            txtSubjectBook.Text = subject.Book;
            txtBookAuthor.Text = subject.Book_Author;
            cmbTeacher.SelectedItem = MyTeachers.FirstOrDefault(f => f.TeacherID == subject.TeacherID);
        }

        private bool CheckTextbox()
        {
            foreach (Control ctrl in this.Controls) {
                if (ctrl is TextBox) {
                    TextBox txtb = ctrl as TextBox;
                    if (txtb.Text == string.Empty)
                        return false;
                }
            }
            return true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (CheckTextbox()) {
                Subject subject = new Subject();

                subject.SubjectID = int.Parse(txtID.Text);
                subject.SubjectTitle = txtSubjectTitle.Text;
                subject.Book = txtSubjectBook.Text;
                subject.Book_Author = txtBookAuthor.Text;
                subject.InsertBy = UserSession.GetUser.UserName;
                subject.LUB = UserSession.GetUser.UserName;
                subject.TeacherID = Convert.ToInt32(cmbTeacher.SelectedValue.ToString());

                if (!update)
                    subject.LUN++;
                else if (update)
                    subject.LUN = ++_subject.LUN;

                if (!update) {
                    var temp = MySubjects.Where(t => t.SubjectTitle == txtSubjectTitle.Text).ToList();

                    if (temp.Count > 0)
                        MessageBox.Show("Subject exists", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else {
                        bool isRegistred = _subjectBLL.Add(subject);

                        if (isRegistred) {
                            MessageBox.Show($"Subject: {subject.SubjectTitle} registred successfully", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                            MessageBox.Show("Registration failed, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else {
                    bool isUpdated = _subjectBLL.Add(subject);

                    if (isUpdated) {
                        MessageBox.Show($"Subject: {subject.SubjectTitle} updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Updated failed, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Please fill all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
