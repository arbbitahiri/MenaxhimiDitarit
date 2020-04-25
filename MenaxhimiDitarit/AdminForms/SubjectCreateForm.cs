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
    public partial class SubjectCreateForm : Form
    {
        private readonly SubjectBLL _subjectBLL;
        private Subject _subject;
        private readonly bool update = false;

        private readonly TeacherBLL _teacherBLL;
        private List<Teacher> _teacher;

        public SubjectCreateForm()
        {
            InitializeComponent();

            _subjectBLL = new SubjectBLL();
            _teacherBLL = new TeacherBLL();

            _teacher = _teacherBLL.GetAll();
            cmbTeacher.DataSource = _teacher;

            update = false;
        }

        public SubjectCreateForm(Subject subject)
        {
            InitializeComponent();

            _subjectBLL = new SubjectBLL();
            _teacherBLL = new TeacherBLL();

            _teacher = _teacherBLL.GetAll();
            cmbTeacher.DataSource = _teacher;

            _subject = subject;
            update = this._subject != null;
            PopulateForm(_subject);
        }

        private void PopulateForm(Subject subject)
        {
            txtID.Text = subject.SubjectID.ToString();
            txtSubjectTitle.Text = subject.SubjectTitle;
            txtSubjectBook.Text = subject.Book;
            txtBookAuthor.Text = subject.Book_Author;
            cmbTeacher.SelectedItem = _teacher.FirstOrDefault(f => f.TeacherID == subject.TeacherID);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Subject subject = new Subject();

            subject.SubjectID = int.Parse(txtID.Text);
            subject.SubjectTitle = txtSubjectTitle.Text;
            subject.Book = txtSubjectBook.Text;
            subject.Book_Author = txtBookAuthor.Text;
            subject.InsertBy = UserSession.GetUser.UserName;
            subject.InsertDate = DateTime.Now;
            subject.LUB = UserSession.GetUser.UserName;
            subject.LUD = DateTime.Now;
            subject.TeacherID = Convert.ToInt32(cmbTeacher.SelectedValue.ToString());

            if (!update)
                subject.LUN++;
            else if (update)
                subject.LUN = ++_subject.LUN;

            if (!update)
            {
                bool isRegistred = _subjectBLL.Add(subject);

                if (isRegistred)
                {
                    MessageBox.Show("Subject registred successfully", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Registration failed, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Subject Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
