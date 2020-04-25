using System;
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

namespace MenaxhimiDitarit
{
    public partial class TeacherCreateForm : Form
    {
        private readonly TeacherBLL _teacherBLL;
        private Teacher _teacher;
        private readonly bool update = false;

        public TeacherCreateForm()
        {
            InitializeComponent();

            _teacherBLL = new TeacherBLL();
            update = false;
        }

        public TeacherCreateForm(Teacher teacher)
        {
            InitializeComponent();

            _teacherBLL = new TeacherBLL();
            this._teacher = teacher;
            PopulateForm(this._teacher);
        }

        private void PopulateForm(Teacher teacher)
        {
            txtID.Text = teacher.TeacherID.ToString();
            txtFirstName.Text = teacher.FirstName;
            txtLastName.Text = teacher.LastName;
            txtCity.Text = teacher.City;
            txtQualification.Text = teacher.Qualification;
            dtpBirthday.Text = teacher.DayofBirth.ToString();
            txtEmail.Text = teacher.Email;
            txtPhoneNo.Text = teacher.PhoneNo;
        }

        private string GetSelectedRBTN()
        {
            foreach (Control ctrl in grbGender.Controls)
            {
                if (ctrl is RadioButton && ((RadioButton)ctrl).Checked == true)
                    return ctrl.Text;
            }
            return null;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();

            teacher.TeacherID = int.Parse(txtID.Text);
            teacher.FirstName = txtFirstName.Text;
            teacher.LastName = txtLastName.Text;
            teacher.Gender = GetSelectedRBTN();
            teacher.City = txtCity.Text;
            teacher.Qualification = txtQualification.Text;
            teacher.DayofBirth = DateTime.Parse(dtpBirthday.Text);
            teacher.Email = txtEmail.Text;
            teacher.PhoneNo = txtPhoneNo.Text;
            teacher.InsertBy = UserSession.GetUser.UserName;
            teacher.InsertDate = DateTime.Now;
            teacher.LUB = UserSession.GetUser.UserName;
            teacher.LUD = DateTime.Now;

            if (!update)
                teacher.LUN++;
            else if (update)
                teacher.LUN = ++this._teacher.LUN;

            if (!update)
            {
                bool isRegistred = _teacherBLL.Add(teacher);

                if (isRegistred)
                {
                    MessageBox.Show("Teacher registred successfully", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Registration failed, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Teacher Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
