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

namespace MenaxhimiDitarit.AdminForms
{
    public partial class ClassCreateForm : Form
    {
        private readonly ClassBLL _classBLL;
        private Class _class;
        private List<Class> MyClass;
        private readonly bool update = false;

        private readonly TeacherBLL _teacherBLL;
        private List<Teacher> _teacher;

        private readonly RoomBLL _roomBLL;
        private List<Room> _room;

        public ClassCreateForm()
        {
            InitializeComponent();

            _classBLL = new ClassBLL();
            _teacherBLL = new TeacherBLL();
            _roomBLL = new RoomBLL();

            _teacher = _teacherBLL.GetAll();
            _room = _roomBLL.GetAll();
            MyClass = _classBLL.GetAll();

            cmbMainTeacher.DataSource = _teacher;
            cmbSelectRoom.DataSource = _room;

            update = false;
        }

        public ClassCreateForm(Class classes)
        {
            InitializeComponent();

            _classBLL = new ClassBLL();
            _teacherBLL = new TeacherBLL();
            _roomBLL = new RoomBLL();

            _class = classes;

            _teacher = _teacherBLL.GetAll();
            _room = _roomBLL.GetAll();

            cmbMainTeacher.DataSource = _teacher;
            cmbSelectRoom.DataSource = _room;

            update = _class != null;
            PopulateForm(_class);
        }

        private void PopulateForm(Class classes)
        {
            txtID.Text = classes.ClassID.ToString();
            cmbMainTeacher.SelectedItem = _teacher.FirstOrDefault(f => f.TeacherID == classes.TeacherID);
            cmbSelectClass.SelectedItem = _class.ClassNo;
            cmbSelectRoom.SelectedItem = _room.FirstOrDefault(f => f.RoomID == classes.RoomID);
        }

        private void btnSubmitClass_Click(object sender, EventArgs e)
        {
            Class classes = new Class();

            classes.ClassID = int.Parse(txtID.Text);
            classes.TeacherID = Convert.ToInt32(cmbMainTeacher.SelectedValue.ToString());
            classes.ClassNo = Convert.ToInt32(cmbSelectClass.SelectedItem.ToString());
            classes.RoomID = Convert.ToInt32(cmbSelectRoom.SelectedValue.ToString());
            classes.InsertBy = UserSession.GetUser.UserName;
            classes.InsertDate = DateTime.Now;
            classes.LUB = UserSession.GetUser.UserName;
            classes.LUD = DateTime.Now;

            if (!update)
                classes.LUN++;
            else if (update)
                classes.LUN = ++_class.LUN;

            if (!update)
            {
                var temp = MyClass.Where(t => t.ClassNo == Convert.ToInt32(cmbSelectClass.SelectedItem.ToString())).ToList();

                if (temp.Count > 0)
                    MessageBox.Show("Class exists", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    bool isRegistred = _classBLL.Add(classes);

                    if (isRegistred)
                    {
                        MessageBox.Show("Class registred successfully", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Registration failed, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Class Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
