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

        private void AbsenceList_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            RefreshList();
        }
    }
}
