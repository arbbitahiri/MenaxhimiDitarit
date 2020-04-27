﻿using System;
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
using Telerik.WinControls.UI;

namespace MenaxhimiDitarit
{
    public partial class SubjectListForm : Form
    {
        private readonly SubjectBLL _subjectBLL;
        private List<Subject> MySubjects;

        public SubjectListForm()
        {
            InitializeComponent();

            _subjectBLL = new SubjectBLL();
        }

        private void RefreshList()
        {
            MySubjects = _subjectBLL.GetAll();
            dgvSubjectList.DataSource = MySubjects;
        }

        private Subject GetSubject(GridViewRowInfo subjectRow)
        {
            try
            {
                Subject subject = new Subject
                {
                    SubjectID = (int)subjectRow.Cells[0].Value,
                    SubjectTitle = (string)subjectRow.Cells[1].Value,
                    Book = (string)subjectRow.Cells[2].Value,
                    Book_Author = (string)subjectRow.Cells[3].Value,
                    TeacherID = (int)subjectRow.Cells[4].Value,
                    InsertBy = (string)subjectRow.Cells[5].Value,
                    InsertDate = (DateTime)subjectRow.Cells[6].Value,
                    LUB = (string)subjectRow.Cells[7].Value,
                    LUD = (DateTime)subjectRow.Cells[8].Value,
                    LUN = (int)subjectRow.Cells[9].Value
                };

                return subject;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void txtSearchNameSubject_Click(object sender, EventArgs e)
        {
            txtSearchSubject.Text = "";
        }

        private void btnViewAllSubjects_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void SubjectListForm_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnSearchSubject_Click(object sender, EventArgs e)
        {
            if (_subjectBLL != null)
            {
                if (txtSearchSubject.Text.Trim().Length > 0)
                {
                    var findSubject = MySubjects.Where(f => f.SubjectTitle.Contains(txtSearchSubject.Text) || f.Book.Contains(txtSearchSubject.Text) || f.Book_Author.Contains(txtSearchSubject.Text)).ToList();

                    dgvSubjectList.DataSource = findSubject;
                }
                else
                    MessageBox.Show("Please write a subject title, book or a book author!!", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Subject title, book or book author does not exist!!", "Doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvSubjectList.SelectedRows.Count > 0)
            {
                var row = dgvSubjectList.SelectedRows[0].Index;
                if (row >= 0)
                {
                    var subject = GetSubject(dgvSubjectList.Rows[row]);
                    if (subject != null)
                    {
                        SubjectCreateForm subjectUpdate = new SubjectCreateForm(subject);
                        subjectUpdate.StartPosition = FormStartPosition.CenterParent;
                        subjectUpdate.ShowDialog();
                    }
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvSubjectList.SelectedRows.Count > 0)
            {
                var row = dgvSubjectList.SelectedRows[0].Index;
                if (row >= 0)
                {
                    var subject = GetSubject(dgvSubjectList.Rows[row]);
                    if (subject != null)
                    {
                        if (MessageBox.Show($"Are you sure you want to delete {subject.SubjectTitle}?", "Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                            == DialogResult.OK)
                        {
                            _subjectBLL.Remove(subject.SubjectID);
                            MessageBox.Show($"Subject {subject.SubjectTitle} has been deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshList();
                        }
                        else
                            MessageBox.Show("Please try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void txtSearchSubject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearchSubject_Click(this, new EventArgs());
        }
    }
}
