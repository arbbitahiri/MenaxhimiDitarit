using MenaxhimiDitarit.BLL;
using MenaxhimiDitarit.BO;
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
    public partial class CommentCreate : Form
    {
        private readonly TopicBLL _commentBLL;
        private List<Topic> MyComments;
        private Topic _comment;

        private bool update = false;

        private readonly SubjectBLL _subjectBLL;
        private List<Subject> MySubjects;

        private readonly ClassBLL _classBLL;
        private List<Class> MyClasses;

        public CommentCreate()
        {
            InitializeComponent();

            _commentBLL = new TopicBLL();
            _subjectBLL = new SubjectBLL();
            _classBLL = new ClassBLL();

            MyComments = _commentBLL.GetAllComment();
            MySubjects = _subjectBLL.GetAll();
            MyClasses = _classBLL.GetAll();

            update = false;

            CustomizeDesign();
        }

        public CommentCreate(Topic comment)
        {
            InitializeComponent();

            _commentBLL = new TopicBLL();
            _subjectBLL = new SubjectBLL();
            _classBLL = new ClassBLL();

            _comment = comment;

            MyComments = _commentBLL.GetAllComment();
            MySubjects = _subjectBLL.GetAll();
            MyClasses = _classBLL.GetAll();

            update = _comment != null;

            cmbSelectClass.Enabled = false;
            cmbSelectSubject.Enabled = false;
            cmbSelectTime.Enabled = false;
            CustomizeDesign();

            PopulateForm(_comment);
        }

        private void CustomizeDesign()
        {
            txtID.Enabled = false;
            dtpSelectDate.Enabled = false;
            cmbSelectClass.DataSource = MyClasses;
            cmbSelectSubject.DataSource = MySubjects;
        }

        private void PopulateForm(Topic comment)
        {
            txtID.Text = comment.TopicID.ToString();
            cmbSelectClass.SelectedItem = MyClasses.FirstOrDefault(f => f.ClassID == comment.ClassID);
            cmbSelectSubject.SelectedItem = MySubjects.FirstOrDefault(f => f.SubjectID == comment.SubjectID);
            dtpSelectDate.Value = comment.Date;
            txtComent.Text = comment.Comment;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtComent.Text.Equals(""))
                {
                    Topic comment = new Topic();

                    comment.TopicID = int.Parse(txtID.Text);
                    comment.ClassID = Convert.ToInt32(cmbSelectClass.SelectedValue.ToString());
                    comment.SubjectID = Convert.ToInt32(cmbSelectSubject.SelectedValue.ToString());
                    comment.Comment = txtComent.Text;
                    comment.Time = Convert.ToInt32(cmbSelectTime.SelectedItem.ToString());
                    comment.Date = dtpSelectDate.Value;
                    comment.InsertBy = UserSession.GetUser.UserName;
                    comment.LUB = UserSession.GetUser.UserName;

                    if (!update)
                        comment.LUN++;
                    else if (update)
                        comment.LUN = ++_comment.LUN;

                    if (!update)
                    {
                        var checkComment = MyComments.Where(t => t.SubjectID == Convert.ToInt32(cmbSelectSubject.SelectedItem.ToString())
                        && t.ClassID == Convert.ToInt32(cmbSelectClass.SelectedValue.ToString())
                        && t.Time == Convert.ToInt32(cmbSelectTime.SelectedValue.ToString())).ToList();

                        if (checkComment.Count > 0)
                            MessageBox.Show($"Comment exists for subject: {comment.Subject.SubjectTitle}" +
                                $" in {comment.Time} hour for class {comment.Class.ClassNo}", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            bool isRegistred = _commentBLL.AddComment(comment);

                            if (isRegistred)
                            {
                                MessageBox.Show("Comment registred successfully", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Registration failed, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        bool isUpdated = _commentBLL.AddComment(comment);

                        if (isUpdated)
                        {
                            MessageBox.Show("Comment updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                            MessageBox.Show("Updated failed, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("Please fill all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A problem occurred while registering data!\n{ex.Message}",
                    "Problem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
