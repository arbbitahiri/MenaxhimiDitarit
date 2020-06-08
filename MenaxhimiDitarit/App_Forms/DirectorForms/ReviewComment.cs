using MenaxhimiDitarit.App_Code;
using MenaxhimiDitarit.App_Forms.DirectorForms;
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

namespace MenaxhimiDitarit.DirectorForms
{
    public partial class ReviewComment : Form
    {
        private readonly TopicBLL _reviewBLL;
        private List<Topic> MyReview;

        private readonly SubjectBLL _subjectBLL;
        private List<Subject> MySubjects;

        public ReviewComment()
        {
            InitializeComponent();

            _reviewBLL = new TopicBLL();
            _subjectBLL = new SubjectBLL();

            MySubjects = _subjectBLL.GetAll();
            cmbSelectSubject.DataSource = MySubjects;
        }

        #region Metodat
        private void RefreshList()
        {
            MyReview = _reviewBLL.GetAllComment();
            dgvReviewCommentList.DataSource = MyReview;
        }

        private Topic GetReview(GridViewRowInfo reviewRow)
        {
            try
            {
                Topic comment = new Topic
                {
                    TopicID = (int)reviewRow.Cells["TopicID"].Value,
                    ClassID = (int)reviewRow.Cells["ClassID"].Value,
                    SubjectID = (int)reviewRow.Cells["SubjectID"].Value,
                    Date = (DateTime)reviewRow.Cells["Date"].Value,
                    Time = (int)reviewRow.Cells["Time"].Value,
                    Comment = (string)reviewRow.Cells["Comment"].Value,
                    Review = (string)reviewRow.Cells["Review"].Value,
                    ReviewDate = (DateTime)reviewRow.Cells["Date"].Value,
                    InsertBy = (string)reviewRow.Cells["InsertBy"].Value,
                    InsertDate = (DateTime)reviewRow.Cells["InsertDate"].Value,
                    LUB = (string)reviewRow.Cells["LUB"].Value,
                    LUD = (DateTime)reviewRow.Cells["LUD"].Value,
                    LUN = (int)reviewRow.Cells["LUN"].Value
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

        private void UpdateReview()
        {
            if (dgvReviewCommentList.SelectedRows.Count > 0)
            {
                var row = dgvReviewCommentList.SelectedRows[0].Index;
                if (row >= 0)
                {
                    var review = GetReview(dgvReviewCommentList.Rows[row]);
                    if (review != null)
                    {
                        Review updateReview = new Review(review)
                        {
                            StartPosition = FormStartPosition.CenterParent
                        };
                        updateReview.ShowDialog();
                    }
                }
            }
            RefreshList();
        }
        #endregion

        private void ReviewComment_Load(object sender, EventArgs e)
        {
            RefreshList();

            Validation.InitializePrintDocument(printDocument, "Review List", "Lista e Shqyrtimeve të Vërejtjeve");
        }

        #region Grid Formatting
        private void dgvReviewCommentList_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            Validation.CellFormatting(e, "Comment", "Vërejtja");
            Validation.CellFormatting(e, "Review", "Shqyrtimi");
        }

        private void dgvReviewCommentList_PrintCellFormatting(object sender, PrintCellFormattingEventArgs e)
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
                if (_reviewBLL != null)
                {
                    if (cmbSelectSubject.SelectedIndex != -1)
                    {
                        var findReview = MyReview.Where(f => f.SubjectID == Convert.ToInt32(cmbSelectSubject.SelectedValue.ToString())
                        && f.Date == dtpSelectDay.Value.Date).ToList();

                        dgvReviewCommentList.DataSource = findReview;
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
        private void reviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateReview();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateReview();
        }
        #endregion

        #region Menu
        private void btnReview_Click(object sender, EventArgs e)
        {
            UpdateReview();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateReview();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            dgvReviewCommentList.PrintPreview(printDocument);
        }

        #region Export
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread((ThreadStart)(() =>
            {
                var saveFileDialog = Validation.SaveFile("ReviewList", "ListaEShqyrtimeveTëVërejtjeve", ".xlsx", "Excel Workbook |*.xlsx");

                saveFileDialog.ShowDialog();

                Validation.ExportToExcel(dgvReviewCommentList, saveFileDialog.FileName, "ReviewList", "ListaEShqyrtimeveTëVërejtjeve");

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
                var saveFileDialog = Validation.SaveFile("ReviewList", "ListaEShqyrtimeveTëVërejtjeve", ".pdf", "Pdf Files|*.pdf");

                saveFileDialog.ShowDialog();

                Validation.ExportToPDF(dgvReviewCommentList, saveFileDialog.FileName);

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