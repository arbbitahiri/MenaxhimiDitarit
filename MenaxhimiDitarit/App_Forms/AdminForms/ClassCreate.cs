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

            MyTeachers = _teacherBLL.GetAll();
            MyRooms = _roomBLL.GetAll();
            MyClass = _classBLL.GetAll();

            CustomizeDesign();

            update = false;
        }

        public ClassCreate(Class classes)
        {
            InitializeComponent();

            _classBLL = new ClassBLL();
            _teacherBLL = new TeacherBLL();
            _roomBLL = new RoomBLL();

            MyTeachers = _teacherBLL.GetAll();
            MyRooms = _roomBLL.GetAll();

            _class = classes;

            cmbSelectClass.Enabled = false;

            update = _class != null;

            PopulateForm(_class);
            CustomizeDesign();
        }

        #region Metodat
        private void CustomizeDesign()
        {
            txtID.Enabled = false;
            cmbMainTeacher.DataSource = MyTeachers;
            cmbSelectRoom.DataSource = MyRooms;
        }

        //Popullimi i TextBox-it dhe ComboBox-ave me te dhenat nga Class
        private void PopulateForm(Class classes)
        {
            txtID.Text = classes.ClassID.ToString();
            cmbMainTeacher.SelectedItem = MyTeachers.FirstOrDefault(f => f.TeacherID == classes.TeacherID);
            cmbSelectClass.SelectedItem = classes.ClassNo.ToString();
            cmbSelectRoom.SelectedItem = MyRooms.FirstOrDefault(f => f.RoomID == classes.RoomID);
        }
        #endregion

        private void btnSubmitClass_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validation.CheckComboBox(this))
                {
                    Class classes = new Class
                    {
                        ClassID = int.Parse(txtID.Text),
                        TeacherID = Convert.ToInt32(cmbMainTeacher.SelectedValue.ToString()),
                        ClassNo = Convert.ToInt32(cmbSelectClass.SelectedItem.ToString()),
                        RoomID = Convert.ToInt32(cmbSelectRoom.SelectedValue.ToString()),
                        InsertBy = UserSession.GetUser.UserName,
                        LUB = UserSession.GetUser.UserName
                    };

                    if (!update)
                        classes.LUN++;
                    else if (update)
                        classes.LUN = ++_class.LUN;

                    if (!update)
                    {
                        var checkClasses = MyClass.Where(t => t.ClassNo == Convert.ToInt32(cmbSelectClass.SelectedItem.ToString())).ToList();

                        if (checkClasses.Count > 0)
                        {
                            Validation.MessageBoxShow("Class exists!", "Warning",
                                    "Klasa ekziston", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            bool isRegistred = _classBLL.Add(classes);

                            if (isRegistred)
                            {
                                Validation.MessageBoxShow("Class registered successfully", "Registered",
                                   "Klasa u regjistrua me sukses", "U regjistrua", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                Validation.MessageBoxShow("Registration failed!", "Error",
                                    "Regjistrimi dështoi!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        bool isUpdated = _classBLL.Add(classes);

                        if (isUpdated)
                        {
                            Validation.MessageBoxShow($"Class: {classes.ClassNo} updated", "Updated",
                                   $"Klasa: {classes.ClassNo} u përditësua", "U përditësua", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            Validation.MessageBoxShow("Update failed!", "Error",
                                "Përditësimi dështoi!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    Validation.MessageBoxShow("Please fill all fields!", "Warning",
                        "Ju lutem plotësoni të gjitha fushat!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                Validation.MessageBoxShow("A problem occured while registering data.", "Problem",
                       "Ndodhi një problem gjatë regjistrimit të të dhënave.", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Validation.CheckComboBox(this))
            {
                var result = Validation.MessageBoxShow("You have something written. Are you sure you want to exit form?", "Sure?",
                    "Keni të shkruar diçka. A je i/e sigurt që do të largoheni nga forma?", "Sigurt?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                    this.Close();
            }
            else
            {
                this.Close();
            }
        }

        #region ErrorProvider
        private void picMainTeacher_MouseHover(object sender, EventArgs e)
        {
            Validation.ToolTipShow("Please select a teacher!", "Zgjedheni kujdestarin!", picMainTeacher);
        }

        private void picClass_MouseHover(object sender, EventArgs e)
        {
            Validation.ToolTipShow("Please select a class!", "Zgjedheni klasën!", picMainTeacher);
        }

        private void picRoom_MouseHover(object sender, EventArgs e)
        {
            Validation.ToolTipShow("Please select a room!", "Zgjedheni sallën!", picMainTeacher);
        }

        private void cmbMainTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMainTeacher.SelectedIndex != -1)
            {
                picMainTeacher.Visible = false;
            }
            else
            {
                Validation.SetImageVisibility(picMainTeacher);
            }
        }

        private void cmbSelectClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelectClass.SelectedIndex != -1)
            {
                picClass.Visible = false;
            }
            else
            {
                Validation.SetImageVisibility(picClass);
            }
        }

        private void cmbSelectRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelectRoom.SelectedIndex != -1)
            {
                picRoom.Visible = false;
            }
            else
            {
                Validation.SetImageVisibility(picRoom);
            }
        }
        #endregion
    }
}
