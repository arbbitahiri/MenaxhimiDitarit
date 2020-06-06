using MenaxhimiDitarit.App_Code;
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

        #region Metodat
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
        #endregion

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtComent.Text.Equals(""))
                {
                    Topic comment = new Topic
                    {
                        TopicID = int.Parse(txtID.Text),
                        ClassID = Convert.ToInt32(cmbSelectClass.SelectedValue.ToString()),
                        SubjectID = Convert.ToInt32(cmbSelectSubject.SelectedValue.ToString()),
                        Comment = txtComent.Text,
                        Time = Convert.ToInt32(cmbSelectTime.SelectedItem.ToString()),
                        Date = dtpSelectDate.Value,
                        InsertBy = UserSession.GetUser.UserName,
                        LUB = UserSession.GetUser.UserName
                    };

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
                        {
                            Validation.MessageBoxShow($"Comment exists for subject: {comment.Subject.SubjectTitle} in {comment.Time} hour for class {comment.Class.ClassNo}", "Exists",
                                $"Vërejtja ekziston për lëndën: {comment.Subject.SubjectTitle} në orën e {comment.Time} për klasën {comment.Class.ClassNo}!", "Ekziston", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            bool isRegistred = _commentBLL.AddComment(comment);

                            if (isRegistred)
                            {
                                Validation.MessageBoxShow("Cooment registered successfully!", "Registered",
                                    "Vërejtja u regjistrua me sukses!", "U regjistrua", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                Validation.MessageBoxShow("Registration failed!", "Error",
                                    "Regjistrimi dështoi!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        bool isUpdated = _commentBLL.AddComment(comment);

                        if (isUpdated)
                        {
                            Validation.MessageBoxShow("Comment updated", "Updated",
                                "Vërejtja u përditësua!", "U përditësua", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            Validation.MessageBoxShow("Update failed!", "Error",
                                "Përditësimi dështoi!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    Validation.MessageBoxShow("Please fill all fields!", "Error",
                        "Ju lutem plotësoni të gjitha fushat!", "Kujdes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                Validation.MessageBoxShow("A problem occurred while registering data!", "Error",
                    "Ndodhi një problem gjatë regjistrimit të të dhënave!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Validation.CheckTextbox(this))
            {
                var result = Validation.MessageBoxShow("You have something written. Are you sure you want to exit form?", "Sure?",
                    "Keni të shkruar diçka. A je i/e sigurt që do të largoheni nga forma?", "Sigurt?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                    this.Close();
            }
            else
            {
                this.Close();
            }
        }
    }
}
