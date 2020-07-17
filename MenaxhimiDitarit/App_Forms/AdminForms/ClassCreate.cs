using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

        #region Methods
        /// <summary>
        /// Disables txtID, and gets data to combobox
        /// </summary>
        private void CustomizeDesign()
        {
            cmbMainTeacher.DataSource = MyTeachers;
            cmbSelectRoom.DataSource = MyRooms;
        }

        /// <summary>
        /// Populates the form with the adequate data from the list form
        /// </summary>
        /// <param name="classes"></param>
        private void PopulateForm(Class classes)
        {
            txtID.Text = classes.ClassID.ToString();
            cmbMainTeacher.SelectedItem = MyTeachers.FirstOrDefault(f => f.TeacherID == classes.TeacherID);
            cmbSelectClass.SelectedItem = classes.ClassNo.ToString();
            cmbSelectRoom.SelectedItem = MyRooms.FirstOrDefault(f => f.RoomID == classes.RoomID);
        }

        /// <summary>
        /// Creates or updates the class, depending on ID
        /// </summary>
        private void CreateClass()
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
                            MessageDialog.MessageBoxShow("Class exists!", "Warning",
                                    "Klasa ekziston", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            bool isRegistred = _classBLL.Add(classes);

                            if (isRegistred)
                            {
                                MessageDialog.DoYouWantToContinue(this, "Class", "Klasa");
                            }
                            else
                            {
                                MessageDialog.MessageBoxShow("Registration failed!", "Error",
                                    "Regjistrimi dështoi!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        bool isUpdated = _classBLL.Add(classes);

                        if (isUpdated)
                        {
                            MessageDialog.MessageBoxShow($"Class: {classes.ClassNo} updated", "Updated",
                                   $"Klasa: {classes.ClassNo} u përditësua", "U përditësua", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageDialog.MessageBoxShow("Update failed!", "Error",
                                "Përditësimi dështoi!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageDialog.MessageBoxShow("Please fill all fields!", "Warning",
                        "Ju lutem plotësoni të gjitha fushat!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageDialog.MessageBoxShow("A problem occured while registering data.", "Problem",
                       "Ndodhi një problem gjatë regjistrimit të të dhënave.", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Events
        // Buttons
        private void btnSubmitClass_Click(object sender, EventArgs e)
        {
            CreateClass();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Validation.CloseForm(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Validation.CloseForm(this);
        }

        private void btnHELP_Click(object sender, EventArgs e)
        {
            MessageDialog.ShowHelp(this, "classescreate.html");
        }
        #endregion

        #region ErrorProvider
        private void picMainTeacher_MouseHover(object sender, EventArgs e)
        {
            MessageDialog.ToolTipShow("Please select a teacher!", "Zgjedheni kujdestarin!", picMainTeacher);
        }

        private void picClass_MouseHover(object sender, EventArgs e)
        {
            MessageDialog.ToolTipShow("Please select a class!", "Zgjedheni klasën!", picMainTeacher);
        }

        private void picRoom_MouseHover(object sender, EventArgs e)
        {
            MessageDialog.ToolTipShow("Please select a room!", "Zgjedheni sallën!", picMainTeacher);
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
