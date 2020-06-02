using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenaxhimiDitarit.App_Forms.MessageBoxes;
using MenaxhimiDitarit.BLL;
using MenaxhimiDitarit.BO;

namespace MenaxhimiDitarit.TeacherForms
{
    public partial class AbsenceCreate : Form
    {
        private readonly TopicBLL _absenceBLL;
        private Topic _absence;
        private List<Topic> MyAbsences;

        private bool update = false;

        private readonly SubjectBLL _subjectBLL;
        private List<Subject> MySubjects;

        private readonly ClassBLL _classBLL;
        private List<Class> MyClasses;

        public AbsenceCreate()
        {
            InitializeComponent();

            _absenceBLL = new TopicBLL();
            _subjectBLL = new SubjectBLL();
            _classBLL = new ClassBLL();

            MyAbsences = _absenceBLL.GetAllAbsence();
            MySubjects = _subjectBLL.GetAll();
            MyClasses = _classBLL.GetAll();

            update = false;

            CustomizeDesign();
        }

        public AbsenceCreate(Topic absence)
        {
            InitializeComponent();

            _absenceBLL = new TopicBLL();
            _subjectBLL = new SubjectBLL();
            _classBLL = new ClassBLL();

            MyAbsences = _absenceBLL.GetAllAbsence();
            MySubjects = _subjectBLL.GetAll();
            MyClasses = _classBLL.GetAll();

            _absence = absence;

            update = _absence != null;

            CustomizeDesign();
            PopulateForm(absence);
        }

        #region Metodat
        private void CustomizeDesign()
        {
            txtID.Enabled = false;
            dtpSelectDate.Enabled = false;
            cmbSelectClass.DataSource = MyClasses;
            cmbSelectSubject.DataSource = MySubjects;
        }

        private void PopulateForm(Topic absence)
        {
            txtID.Text = absence.TopicID.ToString();
            cmbSelectClass.SelectedItem = MyClasses.FirstOrDefault(f => f.ClassID == absence.ClassID);
            cmbSelectSubject.SelectedItem = MySubjects.FirstOrDefault(f => f.SubjectID == absence.SubjectID);
            dtpSelectDate.Value = absence.Date;
            txtNoStudents.Text = absence.NoStudents.ToString();
        }

        private bool CheckTextbox()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox txtb = ctrl as TextBox;
                    if (txtb.Text == string.Empty)
                        return false;
                }
            }
            return true;
        }
        #endregion

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckTextbox())
                {
                    Topic absence = new Topic();

                    absence.TopicID = int.Parse(txtID.Text);
                    absence.ClassID = Convert.ToInt32(cmbSelectClass.SelectedValue.ToString());
                    absence.SubjectID = Convert.ToInt32(cmbSelectSubject.SelectedValue.ToString());
                    absence.Reasoning = cmbReasoning.SelectedItem.ToString();
                    absence.NoStudents = int.Parse(txtNoStudents.Text);
                    absence.Time = Convert.ToInt32(cmbSelectTime.SelectedItem.ToString());
                    absence.Date = dtpSelectDate.Value;
                    absence.InsertBy = UserSession.GetUser.UserName;
                    absence.LUB = UserSession.GetUser.UserName;

                    if (!update)
                        absence.LUN++;
                    else if (update)
                        absence.LUN = ++_absence.LUN;

                    if (!update)
                    {
                        var checkAbsence = MyAbsences.Where(t => t.SubjectID == Convert.ToInt32(cmbSelectSubject.SelectedItem.ToString())
                        && t.ClassID == Convert.ToInt32(cmbSelectClass.SelectedValue.ToString())
                        && t.Time == Convert.ToInt32(cmbSelectTime.SelectedValue.ToString())).ToList();


                        if (checkAbsence.Count > 0)
                            MessageBox.Show($"Absence exists for subject: {absence.Subject.SubjectTitle}" +
                                $" in {absence.Time} hour for class {absence.Class.ClassNo}", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            bool isRegistred = _absenceBLL.AddAbsence(absence);

                            if (isRegistred)
                            {
                                MessageBox.Show("Absence registred successfully", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Registration failed, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        bool isUpdated = _absenceBLL.AddAbsence(absence);

                        if (isUpdated)
                        {
                            MessageBox.Show("Absence updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                            MessageBox.Show("Updated failed, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("Please fill all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A problem occurred while registering data!\n{ex.Message}",
                    "Problem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!CheckTextbox())
            {
                var result = MessageBox.Show(this, "You have written something. Do you want to close?",
                    "Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                    this.Close();
            }
        }

        private void txtNoStudents_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8 && c != 32)
                e.Handled = true;
        }
    }
}
