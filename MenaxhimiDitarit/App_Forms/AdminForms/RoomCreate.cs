using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MenaxhimiDitarit.App_Code;
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
        }

        public RoomCreate(Room room)
        {
            InitializeComponent();

            _roomBLL = new RoomBLL();
            _room = room;

            update = room != null;
            PopulateForm(_room);
        }

        #region Methods
        /// <summary>
        /// Populates the form with the adequate data from the list form
        /// </summary>
        /// <param name="room"></param>
        private void PopulateForm(Room room)
        {
            txtID.Text = room.RoomID.ToString();
            txtRoomNo.Text = room.RoomNo.ToString();
            txtRoomType.Text = room.RoomType;
        }

        /// <summary>
        /// Creates or updates the room, depending on ID
        /// </summary>
        private void CreateRoom()
        {
            try
            {
                if (Validation.CheckTextbox(this))
                {
                    Room room = new Room
                    {
                        RoomID = int.Parse(txtID.Text),
                        RoomNo = int.Parse(txtRoomNo.Text),
                        RoomType = txtRoomType.Text,
                        InsertBy = UserSession.GetUser.UserName,
                        LUB = UserSession.GetUser.UserName
                    };

                    if (!update)
                        room.LUN++;
                    else if (update)
                        room.LUN = ++_room.LUN;

                    if (!update)
                    {
                        var checkRooms = MyRooms.Where(t => t.RoomNo == int.Parse(txtRoomNo.Text)).ToList();
                        if (checkRooms.Count > 0)
                        {
                            MessageDialog.MessageBoxShow("Room exists!", "Exists",
                                "Salla ekziston!", "Ekziston", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            bool isRegistred = _roomBLL.Add(room);

                            if (isRegistred)
                            {
                                MessageDialog.DoYouWantToContinue(this, "Room", "Salla");
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
                        bool isUpdated = _roomBLL.Add(room);

                        if (isUpdated)
                        {
                            MessageDialog.MessageBoxShow($"Room No: {room.RoomNo} updated", "Updated",
                                $"Salla: {room.RoomNo} u përditësua!", "U përditësua", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageDialog.MessageBoxShow("Please fill all fields!", "Error",
                        "Ju lutem plotësoni të gjitha fushat!", "Kujdes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageDialog.MessageBoxShow("A problem occurred while registering data!", "Error",
                    "Ndodhi një problem gjatë regjistrimit të të dhënave!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Events
        // Buttons
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CreateRoom();
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
            MessageDialog.ShowHelp(this, "roomcreate.html");
        }
        #endregion

        #region ErrorProvider
        private void picRoomNo_MouseHover(object sender, EventArgs e)
        {
            if (txtRoomNo.Text == null)
            {
                MessageDialog.ToolTipShow("Room number is required!", "Numri i sallës duhet të plotësohet!", picRoomNo);
            }
            else if (txtRoomNo.Text.Length < 2)
            {
                MessageDialog.ToolTipShow("Room number is to short!", "Numri i sallës është i vogël!", picRoomNo);
            }
        }

        private void picRoomType_MouseHover(object sender, EventArgs e)
        {
            if (txtRoomType.Text == null)
            {
                MessageDialog.ToolTipShow("Room type is required!", "Lloji i sallës duhet të plotësohet!", picRoomType);
            }
            else if (txtRoomType.Text.Length < 2)
            {
                MessageDialog.ToolTipShow("Room type is to short!", "Lloji i sallës është i vogël!", picRoomNo);
            }
        }

        private void txtRoomNo_TextChanged(object sender, EventArgs e)
        {
            if (txtRoomNo.Text != null && txtRoomNo.Text.Length > 2)
            {
                picRoomNo.Visible = false;
            }
            else
            {
                Validation.SetImageVisibility(picRoomNo);
            }
        }

        private void txtRoomType_TextChanged(object sender, EventArgs e)
        {
            if (txtRoomType.Text.Length > 0)
            {
                Validation.Capitalize(txtRoomType);
            }

            if (txtRoomType.Text != null && txtRoomType.Text.Length > 2)
            {
                picRoomType.Visible = false;
            }
            else
            {
                Validation.SetImageVisibility(picRoomType);
            }
        }
        #endregion
    }
}
