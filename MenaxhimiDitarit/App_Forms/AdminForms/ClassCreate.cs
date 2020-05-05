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
    public partial class ClassCreate : Form
    {
        private readonly ClassBLL _classBLL;
        private Class _class;
        private List<Class> MyClass;

        private bool update = false;

        private readonly TeacherBLL _teacherBLL;
        private List<Teacher> MyTeachers;

        private readonly RoomBLL _roomBLL;
        private List<Room> MyRooms;

        public ClassCreate()
        {
            InitializeComponent();

            _classBLL = new ClassBLL();
            _teacherBLL = new TeacherBLL();
            _roomBLL = new RoomBLL();

            MyClass = _classBLL.GetAll();

            GetAll();

            update = false;
        }

        public ClassCreate(Class classes)
        {
            InitializeComponent();

            _classBLL = new ClassBLL();
            _teacherBLL = new TeacherBLL();
            _roomBLL = new RoomBLL();

            _class = classes;

            cmbSelectClass.Enabled = false;

            update = _class != null;

            PopulateForm(_class);
            GetAll();
        }

        #region Metodat
        private void GetAll()
        {
            MyTeachers = _teacherBLL.GetAll();
            MyRooms = _roomBLL.GetAll();

            txtID.Enabled = false;
            cmbMainTeacher.DataSource = MyTeachers;
            cmbSelectRoom.DataSource = MyRooms;
        }

        //Popullimi i TextBox-it dhe ComboBox-ave me te dhenat nga Class
        private void PopulateForm(Class classes)
        {
            txtID.Text = classes.ClassID.ToString();
            cmbMainTeacher.SelectedItem = MyTeachers.FirstOrDefault(f => f.TeacherID == classes.TeacherID);
            cmbSelectClass.SelectedItem = _class.ClassNo.ToString();
            cmbSelectRoom.SelectedItem = MyRooms.FirstOrDefault(f => f.RoomID == classes.RoomID);
        }

        //Shikojme nese eshte selektuar e dhena ne ComboBox
        private bool CheckComboBox()
        {
            foreach (Control ctrl in this.Controls) {
                if (ctrl is ComboBox) {
                    ComboBox cmb = ctrl as ComboBox;
                    if (cmb.SelectedIndex > -1)
                        return true;
                }
            }
            return false;
        }
        #endregion

        private void btnSubmitClass_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckComboBox())
                {
                    Class classes = new Class();

                    classes.ClassID = int.Parse(txtID.Text);
                    classes.TeacherID = Convert.ToInt32(cmbMainTeacher.SelectedValue.ToString());
                    classes.ClassNo = Convert.ToInt32(cmbSelectClass.SelectedItem.ToString());
                    classes.RoomID = Convert.ToInt32(cmbSelectRoom.SelectedValue.ToString());
                    classes.InsertBy = UserSession.GetUser.UserName;
                    classes.LUB = UserSession.GetUser.UserName;

                    if (!update)
                        classes.LUN++;
                    else if (update)
                        classes.LUN = ++_class.LUN;

                    if (!update)
                    {
                        var checkClasses = MyClass.Where(t => t.ClassNo == Convert.ToInt32(cmbSelectClass.SelectedItem.ToString())).ToList();

                        if (checkClasses.Count > 0)
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
                        bool isUpdated = _classBLL.Add(classes);

                        if (isUpdated)
                        {
                            MessageBox.Show($"Class: {classes.ClassNo} updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show($"A problem occured while registering data.\n{ex.Message}", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
