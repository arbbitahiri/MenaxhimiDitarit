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
using Telerik.WinControls.UI;

namespace MenaxhimiDitarit.TeacherForms
{
    public partial class CommentList : Form
    {
        private readonly TopicBLL _commentBLL;
        private List<Topic> MyComments;

        public CommentList()
        {
            InitializeComponent();

            _commentBLL = new TopicBLL();
        }

        private void RefreshList()
        {
            MyComments = _commentBLL.GetAllComment();
            dgvCommentList.DataSource = MyComments;
        }

        private Topic GetComment(GridViewRowInfo topicRow)
        {
            try
            {
                Topic comment = new Topic
                {
                    TopicID = (int)topicRow.Cells[0].Value,
                    ClassID = (int)topicRow.Cells[1].Value,
                    SubjectID = (int)topicRow.Cells[2].Value,
                    Date = (DateTime)topicRow.Cells[3].Value,
                    Time = (int)topicRow.Cells[4].Value,
                    Comment = (string)topicRow.Cells["Comment"].Value,
                    Review = (string)topicRow.Cells["Review"].Value,
                    InsertBy = (string)topicRow.Cells["InsertBy"].Value,
                    InsertDate = (DateTime)topicRow.Cells["InsertDate"].Value,
                    LUB = (string)topicRow.Cells["LUB"].Value,
                    LUD = (DateTime)topicRow.Cells["LUD"].Value,
                    LUN = (int)topicRow.Cells["LUN"].Value
                };

                return comment;
            }
            catch (Exception)
            {
                Validation.MessageBoxShow("A problem occurred while getting those data!", "Problem",
                            "Ndodhi një problem gjatë marrjes së këtyre të dhënave!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void CommentList_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (_commentBLL != null)
                {
                    if (cmbSelectSubject.SelectedIndex != -1)
                    {
                        var findComment = MyComments.Where(f => f.SubjectID == Convert.ToInt32(cmbSelectSubject.SelectedValue.ToString())
                        && f.Date == dtpSelectDay.Value.Date).ToList();

                        dgvCommentList.DataSource = findComment;
                    }
                    else
                    {
                        Validation.MessageBoxShow("Please select a subject and a day!", "Empty",
                            "Ju lutemi zgjidhni një lëndë dhe një ditë!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Validation.MessageBoxShow("Comment does not exist!", "Doesn't exist",
                        "Vërejtja nuk ekziston!", "Nuk ekziston", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                Validation.MessageBoxShow("A problem occurred while searching data!", "Problem",
                            "Ndodhi një problem gjatë kërkimit të të dhënave!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvCommentList.SelectedRows.Count > 0)
            {
                var row = dgvCommentList.SelectedRows[0].Index;
                if (row >= 0)
                {
                    var comment = GetComment(dgvCommentList.Rows[row]);
                    if (comment != null)
                    {
                        CommentCreate updateComment = new CommentCreate(comment)
                        {
                            StartPosition = FormStartPosition.CenterParent
                        };
                        updateComment.ShowDialog();
                    }
                }
            }
            RefreshList();
        }

        private void showCommentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvCommentList.SelectedRows.Count > 0)
            {
                var row = dgvCommentList.SelectedRows[0].Index;
                if (row >= 0)
                {
                    var comment = GetComment(dgvCommentList.Rows[row]);
                    if (comment != null)
                    {
                        if (comment.Review != "NONE")
                        {
                            Validation.MessageBoxShow($"Comment: {comment.Comment}\nReview: {comment.Review}", "Comment",
                                $"Vërejtja: {comment.Comment}\nShqyrtimi: {comment.Review}", "Vërejtja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            Validation.MessageBoxShow($"Comment: {comment.Content}", "Comment",
                                $"Vërejtja: {comment.Content}", "Vërejtja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
        //TODO: sa nxensa jan me shqyrtim
    }
}
