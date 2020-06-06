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

namespace MenaxhimiDitarit.App_Forms.DirectorForms
{
    public partial class Review : Form
    {
        private readonly TopicBLL _reviewBLL;
        private List<Topic> MyReviews;
        private Topic _review;

        private readonly SubjectBLL _subjectBLL;
        private List<Subject> MySubjects;

        private readonly ClassBLL _classBLL;
        private List<Class> MyClasses;

        public Review(Topic review)
        {
            InitializeComponent();

            _reviewBLL = new TopicBLL();
            _subjectBLL = new SubjectBLL();
            _classBLL = new ClassBLL();

            _review = review;

            MyReviews = _reviewBLL.GetAllComment();
            MySubjects = _subjectBLL.GetAll();
            MyClasses = _classBLL.GetAll();

            if (review.Review != "NONE")
            {
                CustomizeDesign();
            }
            else
            {
                CustomizeDesign();
                dtpReviewDate.Enabled = false;
            }

            PopulateForm(_review);
        }

        private void CustomizeDesign()
        {
            txtID.Enabled = false;
            txtSubject.Enabled = false;
            dtpCommentDay.Enabled = false;
            txtComment.Enabled = false;
        }

        private void PopulateForm(Topic review)
        {
            txtID.Text = review.TopicID.ToString();
            txtSubject.Text = review.Subject.ToString();
            dtpCommentDay.Value = review.Date;
            txtComment.Text = review.Comment;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtReview.Text.Equals(""))
                {
                    Topic review = new Topic
                    {
                        TopicID = int.Parse(txtID.Text),
                        Review = txtReview.Text,
                        ReviewDate = dtpReviewDate.Value,
                        InsertBy = UserSession.GetUser.UserName,
                        LUB = UserSession.GetUser.UserName,
                        LUN = ++_review.LUN
                    };

                    bool isUpdated = _reviewBLL.UpdateComment(review);

                    if (isUpdated)
                    {
                        Validation.MessageBoxShow("Comment reviewed", "Reviewed",
                            "Vërejtja u shqyrtua!", "U shqyrtua", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        Validation.MessageBoxShow("Update failed!", "Error",
                            "Përditësimi dështoi!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (!Validation.CheckTextbox(this))
            {
                var result = Validation.MessageBoxShow("You have something written. Are you sure you want to exit form?", "Sure?",
                    "Keni të shkruar diçka. A je i/e sigurt që do të largoheni nga forma?", "Sigurt?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                    this.Close();
            }
        }


        #region ErrorProvider
        ToolTip toolTip = new ToolTip();

        private void picReview_MouseHover(object sender, EventArgs e)
        {
            if (txtReview.Text == null)
            {
                toolTip.Show("Review is required!", picReview);
            }
            else if (txtReview.Text.Length < 4)
            {
                toolTip.Show("Review is to short!", picReview);
            }
        }

        private void txtReview_TextChanged(object sender, EventArgs e)
        {
            if (txtReview.Text != null && txtReview.Text.Length > 5)
                picReview.Visible = false;
            else
                picReview.Image = Properties.Resources.icons8_cancel_15;
        }
        #endregion
    }
}
