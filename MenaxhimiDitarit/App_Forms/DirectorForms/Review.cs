using MenaxhimiDitarit.App_Code;
using MenaxhimiDitarit.BLL;
using MenaxhimiDitarit.BO;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public Review(Topic review)
        {
            InitializeComponent();

            _reviewBLL = new TopicBLL();
            _subjectBLL = new SubjectBLL();

            _review = review;

            MyReviews = _reviewBLL.GetAllComment();
            MySubjects = _subjectBLL.GetAll();

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

        #region Methods
        /// <summary>
        /// Disables textbox and datetimepicker, and gets data to combobox
        /// </summary>
        private void CustomizeDesign()
        {
            cmbSelectSubject.Enabled = false;
            dtpCommentDay.Enabled = false;
            txtComment.Enabled = false;

            cmbSelectSubject.DataSource = MySubjects;
        }

        /// <summary>
        /// Populates the form with the adequate data from the list form
        /// </summary>
        /// <param name="review"></param>
        private void PopulateForm(Topic review)
        {
            txtID.Text = review.TopicID.ToString();
            cmbSelectSubject.SelectedItem = MySubjects.FirstOrDefault(f => f.SubjectID == review.SubjectID);
            dtpCommentDay.Value = review.Date;
            txtComment.Text = review.Comment;
        }

        /// <summary>
        /// Creates or updates the review, depending on ID
        /// </summary>
        private void CreateReview()
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
                        MessageDialog.MessageBoxShow("Comment reviewed", "Reviewed",
                            "Vërejtja u shqyrtua!", "U shqyrtua", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageDialog.MessageBoxShow("Update failed!", "Error",
                            "Përditësimi dështoi!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageDialog.MessageBoxShow("Please fill all fields!", "Error",
                        "Ju lutem plotësoni të gjitha fushat!", "Kujdes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageDialog.MessageBoxShow("A problem occurred while registering data!", "Error",
                    "Ndodhi një problem gjatë regjistrimit të të dhënave!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Events
        // Buttons
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CreateReview();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Validation.CloseForm(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Validation.CloseForm(this);
        }

        private void btnHELP_Click(object sender, EventArgs e)
        {
            MessageDialog.ShowHelp(this, "reviewcomment.html");
        }

        // TextBox
        private void txtComment_TextChanged(object sender, EventArgs e)
        {
            Validation.Capitalize(txtComment);
        }
        #endregion

        #region ErrorProvider
        private void picReview_MouseHover(object sender, EventArgs e)
        {
            if (txtReview.Text == null)
            {
                MessageDialog.ToolTipShow("Review is required!", "Shqyrtimi duhet të plotësohet!", picReview);
            }
            else if (txtReview.Text.Length < 4)
            {
                MessageDialog.ToolTipShow("Review is to short!", "Shqyrtimi është i shkurtë!", picReview);
            }
        }

        private void txtReview_TextChanged(object sender, EventArgs e)
        {
            if (txtReview.Text.Length > 0)
            {
                Validation.Capitalize(txtReview);
            }

            if (txtReview.Text != null && txtReview.Text.Length > 5)
            {
                picReview.Visible = false;
            }
            else
            {
                Validation.SetImageVisibility(picReview);
            }
        }
        #endregion
    }
}
