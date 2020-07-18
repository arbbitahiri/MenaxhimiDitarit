﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MenaxhimiDitarit.App_Code;
using MenaxhimiDitarit.BLL;
using MenaxhimiDitarit.BO;
using Telerik.WinControls.UI;

namespace MenaxhimiDitarit
{
    public partial class SubjectList : Form
    {
        private readonly SubjectBLL _subjectBLL;
        private List<Subject> MySubjects;

        public SubjectList()
        {
            InitializeComponent();

            dgvSubjectList.SelectionMode = GridViewSelectionMode.FullRowSelect;

            _subjectBLL = new SubjectBLL();
        }

        #region Methods
        /// <summary>
        /// Refreshes the list
        /// </summary>
        private void RefreshList()
        {
            MySubjects = _subjectBLL.GetAll();
            dgvSubjectList.DataSource = MySubjects;
        }

        /// <summary>
        /// Gets the subject data, that we select in GridView
        /// </summary>
        /// <param name="subjectRow">The selected row</param>
        /// <returns>The data of subject</returns>
        private Subject GetSubject(GridViewRowInfo subjectRow)
        {
            try
            {
                Subject subject = new Subject
                {
                    SubjectID = (int)subjectRow.Cells["SubjectID"].Value,
                    SubjectTitle = (string)subjectRow.Cells["SubjectTitle"].Value,
                    Book = (string)subjectRow.Cells["Book"].Value,
                    Book_Author = (string)subjectRow.Cells["Book_Author"].Value,
                    TeacherID = (int)subjectRow.Cells["TeacherID"].Value,
                    InsertBy = (string)subjectRow.Cells["InsertBy"].Value,
                    InsertDate = (DateTime)subjectRow.Cells["InsertDate"].Value,
                    LUB = (string)subjectRow.Cells["LUB"].Value,
                    LUD = (DateTime)subjectRow.Cells["LUD"].Value,
                    LUN = (int)subjectRow.Cells["LUN"].Value
                };

                return subject;
            }
            catch (Exception)
            {
                MessageDialog.MessageBoxShow("A problem occurred while getting those data!", "Problem",
                            "Ndodhi një problem gjatë marrjes së këtyre të dhënave!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// Opens the form to update the subject
        /// </summary>
        private void UpdateSubject()
        {
            if (dgvSubjectList.SelectedRows.Count > 0)
            {
                var row = dgvSubjectList.SelectedRows[0].Index;
                if (row >= 0)
                {
                    var subject = GetSubject(dgvSubjectList.Rows[row]);
                    if (subject != null)
                    {
                        SubjectCreate subjectUpdate = new SubjectCreate(subject)
                        {
                            StartPosition = FormStartPosition.CenterParent
                        };
                        subjectUpdate.ShowDialog();
                    }
                }
            }
            RefreshList();
        }

        /// <summary>
        /// Deletes the subject
        /// </summary>
        private void DeleteSubject()
        {
            if (dgvSubjectList.SelectedRows.Count > 0)
            {
                var row = dgvSubjectList.SelectedRows[0].Index;
                if (row >= 0)
                {
                    var subject = GetSubject(dgvSubjectList.Rows[row]);
                    if (subject != null)
                    {
                        var result = MessageDialog.MessageBoxShow($"Are you sure you want to delete subject: {subject.SubjectTitle}?", "Sure?",
                            $"A je i/e sigurt që do ta fshini lëndën: {subject.SubjectTitle}?", "Sigurt?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            _subjectBLL.Remove(subject.SubjectID);

                            MessageDialog.MessageBoxShow($"Subject {subject.SubjectTitle} has been deleted successfully!", "Deleted",
                                $"Lënda: {subject.SubjectTitle} u fshi!", "U fshi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                            RefreshList();
                        }
                    }
                }
            }
            RefreshList();
        }

        /// <summary>
        /// Searches the subject
        /// </summary>
        private void SearchSubject()
        {
            try
            {
                if (_subjectBLL != null)
                {
                    if (txtSearchSubject.Text.Trim().Length > 0)
                    {
                        var findSubject = MySubjects.Where(f => f.SubjectTitle.Contains(txtSearchSubject.Text)
                        || f.Teacher.FirstName.Contains(txtSearchSubject.Text) || f.Teacher.LastName.Contains(txtSearchSubject.Text)
                        || f.Teacher.FullName.Contains(txtSearchSubject.Text)).ToList();

                        if (findSubject.Count > 0)
                        {
                            dgvSubjectList.DataSource = findSubject;
                        }
                        else
                        {
                            MessageDialog.MessageBoxShow("Nothing found!", "Empty",
                                "Nuk ka rezultat!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageDialog.MessageBoxShow("Please write a subject title or a teacher name!", "Empty",
                            "Ju lutemi shkruani një lëndën ose një arsimtarë!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageDialog.MessageBoxShow("Subject title or teacher you're trying to search does not exist!", "Doesn't exist",
                        "Lënda ose arsimtari që po përpiqeni të kërkoni nuk ekziston!", "Nuk ekziston", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageDialog.MessageBoxShow("A problem occurred while searching data!", "Problem",
                            "Ndodhi një problem gjatë kërkimit të të dhënave!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Events
        // Form
        private void SubjectListForm_Load(object sender, EventArgs e)
        {
            RefreshList();

            Validation.InitializePrintDocument(printDocument, "Subject List", "Lista e Lëndës");
        }

        // Buttons
        private void btnViewAllSubjects_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnSearchSubject_Click(object sender, EventArgs e)
        {
            SearchSubject();
        }

        private void btnHELP_Click(object sender, EventArgs e)
        {
            MessageDialog.ShowHelp(this, "subjectlist.html");
        }

        // Tool Strip Menus
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateSubject();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteSubject();
        }

        // Textboxes
        private void txtSearchSubject_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchSubject.Text.Length > 0)
            {
                Validation.Capitalize(txtSearchSubject);
            }
        }

        private void txtSearchNameSubject_Click(object sender, EventArgs e)
        {
            txtSearchSubject.Text = "";
        }

        private void txtSearchSubject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchSubject_Click(this, new EventArgs());
            }
        }

        private void txtSearchSubject_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.NoNumber(e);
        }
        #endregion

        #region Menu
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            SubjectCreate addSubject = new SubjectCreate
            {
                StartPosition = FormStartPosition.CenterParent
            };
            addSubject.ShowDialog();

            RefreshList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateSubject();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSubject();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            dgvSubjectList.PrintPreview(printDocument);
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            ExportFile.ExportExcel("SubjectList", "ListaELëndëve", ".xlsx", "Excel Workbook |*.xlsx", dgvSubjectList);

            MessageDialog.MessageBoxShow("Excel file created succesfully!", "Created", "Excel file u krijua me sukses!", "U krijua",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            ExportFile.ExportExcel("SubjectList", "ListaELëndëve", ".pdf", "Pdf Files|*.pdf", dgvSubjectList);

            MessageDialog.MessageBoxShow("PDF file created succesfully!", "Created", "PDF file u krijua me sukses!", "U krijua",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
