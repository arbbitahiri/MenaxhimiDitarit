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
    public partial class RoomCreate : Form
    {
        private readonly RoomBLL _roomBLL;
        private Room _room;
        private List<Room> MyRooms;

        private bool update = false;

        public RoomCreate()
        {
            InitializeComponent();

            _roomBLL = new RoomBLL();
            MyRooms = _roomBLL.GetAll();
            update = false;

            txtID.Enabled = false;
        }

        public RoomCreate(Room room)
        {
            InitializeComponent();

            _roomBLL = new RoomBLL();
            _room = room;

            update = room != null;
            PopulateForm(_room);

            txtID.Enabled = false;
        }

        #region Metodat
        //Popullimi i TextBox-ave dhe ComboBox-ave me te dhenat nga Topic
        private void PopulateForm(Room room)
        {
            txtID.Text = room.RoomID.ToString();
            txtRoomNo.Text = room.RoomNo.ToString();
            txtRoomType.Text = room.RoomType;
        }

        //Shikojme nese TextBox-at jane te mbushur me te dhena
        private bool CheckTextbox()
        {
            foreach (Control ctrl in this.Controls) {
                if (ctrl is TextBox) {
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
                    Room room = new Room();

                    room.RoomID = int.Parse(txtID.Text);
                    room.RoomNo = int.Parse(txtRoomNo.Text);
                    room.RoomType = txtRoomType.Text;
                    room.InsertBy = UserSession.GetUser.UserName;
                    room.LUB = UserSession.GetUser.UserName;

                    if (!update)
                        room.LUN++;
                    else if (update)
                        room.LUN = ++_room.LUN;

                    if (!update)
                    {
                        var checkRooms = MyRooms.Where(t => t.RoomNo == int.Parse(txtRoomNo.Text)).ToList();

                        if (checkRooms.Count > 0)
                            MessageBox.Show("Room exists", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            bool isRegistred = _roomBLL.Add(room);

                            if (isRegistred)
                            {
                                MessageBox.Show("Room registred successfully", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Registration failed, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        bool isUpdated = _roomBLL.Add(room);

                        if (isUpdated)
                        {
                            MessageBox.Show($"Room No: {room.RoomNo} updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show($"A problem occurred while registering data!\n{ex.Message}", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
