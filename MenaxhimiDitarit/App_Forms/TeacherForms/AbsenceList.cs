using MenaxhimiDitarit.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenaxhimiDitarit.BO;
using Telerik.WinControls.UI;
using MenaxhimiDitarit.App_Code;

namespace MenaxhimiDitarit.TeacherForms
{
    public partial class AbsenceList : Form
    {
        private readonly TopicBLL _absenceBLL;
        private List<Topic> MyAbsences;

        public AbsenceList()
        {
            InitializeComponent();

            _absenceBLL = new TopicBLL();
        }

        private void RefreshList()
        {
            MyAbsences = _absenceBLL.GetAllAbsence();
            dgvAbsenceList.DataSource = MyAbsences;
        }

        private Topic GetAbsence(GridViewRowInfo absenceRow)
        {
            try
            {
                Topic absence = new Topic
                {
                    TopicID = (int)absenceRow.Cells["TopicID"].Value,
                    ClassID = (int)absenceRow.Cells["ClassID"].Value,
                    SubjectID = (int)absenceRow.Cells["SubjectID"].Value,
                    Date = (DateTime)absenceRow.Cells["Date"].Value,
                    Time = (int)absenceRow.Cells["Time"].Value,
                    Reasoning = (string)absenceRow.Cells["Reasoning"].Value,
                    NoStudents = (int)absenceRow.Cells["NoStudents"].Value,
                    InsertBy = (string)absenceRow.Cells["InsertBy"].Value,
                    InsertDate = (DateTime)absenceRow.Cells["InsertDate"].Value,
                    LUB = (string)absenceRow.Cells["LUB"].Value,
                    LUD = (DateTime)absenceRow.Cells["LUD"].Value,
                    LUN = (int)absenceRow.Cells["LUN"].Value
                };

                return absence;
            }
            catch (Exception)
            {
                Validation.MessageBoxShow("A problem occurred while getting those data!", "Problem",
                            "Ndodhi një problem gjatë marrjes së këtyre të dhënave!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        private void AbsenceList_Load(object sender, EventArgs e)
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
                if (_absenceBLL != null)
                {
                    if (cmbSelectSubject.SelectedIndex != -1)
                    {
                        var findAbsence = MyAbsences.Where(f => f.SubjectID == Convert.ToInt32(cmbSelectSubject.SelectedValue.ToString())
                        && f.Date == dtpSelectDay.Value.Date).ToList();

                        dgvAbsenceList.DataSource = findAbsence;
                    }
                    else
                    {
                        Validation.MessageBoxShow("Please select a subject and a day!", "Empty",
                            "Ju lutemi zgjidhni një lëndë dhe një ditë!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Validation.MessageBoxShow("Absence does not exist!", "Doesn't exist",
                        "Mungesa nuk ekziston!", "Nuk ekziston", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (dgvAbsenceList.SelectedRows.Count > 0)
            {
                var row = dgvAbsenceList.SelectedRows[0].Index;
                if (row >= 0)
                {
                    var absence = GetAbsence(dgvAbsenceList.Rows[row]);
                    if (absence != null)
                    {
                        AbsenceCreate updateAbsence = new AbsenceCreate(absence)
                        {
                            StartPosition = FormStartPosition.CenterParent
                        };
                        updateAbsence.ShowDialog();
                    }
                }
            }
            RefreshList();
        }

        //TODO: Charts per reasoning
    }
}
