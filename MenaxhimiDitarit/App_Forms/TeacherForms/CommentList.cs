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
using System.Threading;
using System.Threading.Tasks;
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

        #region Metodat
        private void RefreshList()
        {
            MyComments = _commentBLL.GetAllComment();
            dgvCommentList.DataSource = MyComments;
        }

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
        #endregion

        private void CommentList_Load(object sender, EventArgs e)
        {
            RefreshList();

            Validation.InitializePrintDocument(printDocument, "Comment List", "Lista e Vërejtjes");
        }

        #region Grid Formatting
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
        #endregion

        #region Button
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
        #endregion

        #region Tool Strip Menu
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateComment();
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
        #endregion

        #region Menu
        private void btnAddComment_Click(object sender, EventArgs e)
        {
            CommentCreate addComment = new CommentCreate
            {
                StartPosition = FormStartPosition.CenterParent
            };
            addComment.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateComment();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            dgvCommentList.PrintPreview(printDocument);
        }

        #region Export
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread((ThreadStart)(() =>
            {
                var saveFileDialog = Validation.SaveFile("CommentList", "ListaEVërejtjes", ".xlsx", "Excel Workbook |*.xlsx");

                saveFileDialog.ShowDialog();

                Validation.ExportToExcel(dgvCommentList, saveFileDialog.FileName, "CommentList", "ListaEVërejtjes");

                Validation.MessageBoxShow("Excel file created succesfully!", "Created", "Excel file u krijua me sukses!", "U krijua",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }));

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread((ThreadStart)(() =>
            {
                var saveFileDialog = Validation.SaveFile("CommentList", "ListaEVërejtjes", ".pdf", "Pdf Files|*.pdf");

                saveFileDialog.ShowDialog();

                Validation.ExportToPDF(dgvCommentList, saveFileDialog.FileName);

                Validation.MessageBoxShow("PDF file created succesfully!", "Created", "PDF file u krijua me sukses!", "U krijua",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }));

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
        }
        #endregion

        #endregion
    }
}