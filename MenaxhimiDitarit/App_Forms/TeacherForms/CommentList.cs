using MenaxhimiDitarit.App_Code;
using MenaxhimiDitarit.BLL;
using MenaxhimiDitarit.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Primitives;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace MenaxhimiDitarit.TeacherForms
{
    public partial class CommentList : Form
    {
        private readonly TopicBLL _commentBLL;
        private List<Topic> MyComments;

        private readonly SubjectBLL _subjectBLL;
        private List<Subject> MySubjects;
        public CommentList()
        {
            InitializeComponent();

            _commentBLL = new TopicBLL();
            _subjectBLL = new SubjectBLL();

            MySubjects = _subjectBLL.GetAll();
            cmbSelectSubject.DataSource = MySubjects;
        }

        #region Methods
        /// <summary>
        /// Refreshes the list
        /// </summary>
        private void RefreshList()
        {
            MyComments = _commentBLL.GetAllComment();
            dgvCommentList.DataSource = MyComments;
        }

        /// <summary>
        /// Gets the comment data, that we select in GridView
        /// </summary>
        /// <param name="commentRow">The selected row</param>
        /// <returns>The data of comment</returns>
        private Topic GetComment(GridViewRowInfo commentRow)
        {
            try
            {
                Topic comment = new Topic
                {
                    TopicID = (int)commentRow.Cells["TopicID"].Value,
                    ClassID = (int)commentRow.Cells["ClassID"].Value,
                    SubjectID = (int)commentRow.Cells["SubjectID"].Value,
                    Date = (DateTime)commentRow.Cells["Date"].Value,
                    Time = (int)commentRow.Cells["Time"].Value,
                    Comment = (string)commentRow.Cells["Comment"].Value,
                    Review = (string)commentRow.Cells["Review"].Value,
                    InsertBy = (string)commentRow.Cells["InsertBy"].Value,
                    InsertDate = (DateTime)commentRow.Cells["InsertDate"].Value,
                    LUB = (string)commentRow.Cells["LUB"].Value,
                    LUD = (DateTime)commentRow.Cells["LUD"].Value,
                    LUN = (int)commentRow.Cells["LUN"].Value
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

        /// <summary>
        /// Opens the form to update the comment
        /// </summary>
        private void UpdateComment()
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

        /// <summary>
        /// Searches the comment
        /// </summary>
        private void SearchComment()
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
                            "Ju lutemi zgjidhni një lëndë dhe një ditë!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        /// <summary>
        /// Shows full comment
        /// </summary>
        private void ShowComment()
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
        #endregion

        #region Events
        private void CommentList_Load(object sender, EventArgs e)
        {
            RefreshList();

            Validation.InitializePrintDocument(printDocument, "Comment List", "Lista e Vërejtjes");
        }

        // Grid Formattings
        private void MasterTemplate_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            Validation.CellFormatting(e, "Comment", "Vërejtja");
            Validation.CellFormatting(e, "Review", "Shqyrtimi");
        }

        private void MasterTemplate_PrintCellFormatting(object sender, PrintCellFormattingEventArgs e)
        {
            Validation.PrintCellFormatting(e, "Comment", "Vërejtja");
            Validation.PrintCellFormatting(e, "Review", "Shqyrtimi");
        }

        // Buttons
        private void btnViewAll_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchComment();
        }

        // Tool Strip Menus
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateComment();
        }

        private void showCommentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowComment();
        }
        #endregion

        #region Menu
        private void btnAddComment_Click(object sender, EventArgs e)
        {
            CommentCreate addComment = new CommentCreate
            {
                StartPosition = FormStartPosition.CenterParent
            };
            addComment.ShowDialog();

            RefreshList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateComment();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            dgvCommentList.PrintPreview(printDocument);
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            ExportFile.ExportExcel("CommentList", "ListaEVërejtjes", ".xlsx", "Excel Workbook |*.xlsx", dgvCommentList);

            Validation.MessageBoxShow("Excel file created succesfully!", "Created", "Excel file u krijua me sukses!", "U krijua",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            ExportFile.ExportPDF("CommentList", "ListaEVërejtjes", ".pdf", "Pdf Files|*.pdf", dgvCommentList);

            Validation.MessageBoxShow("PDF file created succesfully!", "Created", "PDF file u krijua me sukses!", "U krijua",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}