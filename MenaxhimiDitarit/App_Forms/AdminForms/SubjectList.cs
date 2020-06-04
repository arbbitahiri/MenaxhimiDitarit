using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        //Refresh i te dhenave ne DataGrid
        private void RefreshList()
        {
            MySubjects = _subjectBLL.GetAll();
            dgvSubjectList.DataSource = MySubjects;
        }

        //Mirren te dhenat nga rreshti i klikuar
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
                Validation.MessageBoxShow("A problem occurred while getting those data!", "Problem",
                            "Ndodhi një problem gjatë marrjes së këtyre të dhënave!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        //Kerkojm te dhenat ne DataGrid
        private void btnSearchSubject_Click(object sender, EventArgs e)
        {
            try
            {
                if (_subjectBLL != null)
                {
                    if (txtSearchSubject.Text.Trim().Length > 0)
                    {
                        //Shikojme nese teksti i shkruar ne TextBox eshte emri i lendes apo emri i arsimtarit
                        var findSubject = MySubjects.Where(f => f.SubjectTitle.Contains(txtSearchSubject.Text)
                        || f.Teacher.FirstName.Contains(txtSearchSubject.Text) || f.Teacher.LastName.Contains(txtSearchSubject.Text)
                        || f.Teacher.FullName.Contains(txtSearchSubject.Text)).ToList();

                        dgvSubjectList.DataSource = findSubject;
                    }
                    else
                    {
                        Validation.MessageBoxShow("Please write a subject title or a teacher name!", "Empty",
                            "Ju lutemi shkruani një lëndën ose një arsimtarë!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Validation.MessageBoxShow("Subject title or teacher you're trying to search does not exist!", "Doesn't exist",
                        "Lënda ose arsimtari që po përpiqeni të kërkoni nuk ekziston!", "Nuk ekziston", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                Validation.MessageBoxShow("A problem occurred while searching data!", "Problem",
                            "Ndodhi një problem gjatë kërkimit të të dhënave!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Update te dhenat per rreshtin e klikuar ne DataGrid
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

        //Delete te dhenat per rreshtin e klikuar ne DataGrid
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
                        var result = Validation.MessageBoxShow($"Are you sure you want to delete subject: {subject.SubjectTitle}?", "Sure?",
                            $"A je i/e sigurt që do ta fshini lëndën: {subject.SubjectTitle}?", "Sigurt?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            _subjectBLL.Remove(subject.SubjectID);

                            Validation.MessageBoxShow($"Subject {subject.SubjectTitle} has been deleted successfully!", "Deleted",
                                $"Lënda: {subject.SubjectTitle} u fshi!", "U fshi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            RefreshList();
                        }
                    }
                }
            }
            RefreshList();
        }

        private void txtSearchSubject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearchSubject_Click(this, new EventArgs());
        }
    }
}
