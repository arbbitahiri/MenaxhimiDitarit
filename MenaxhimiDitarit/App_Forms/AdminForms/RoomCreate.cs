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

        private void PopulateForm(Room room)
        {
            txtID.Text = room.RoomID.ToString();
            txtRoomNo.Text = room.RoomNo.ToString();
            txtRoomType.Text = room.RoomType;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
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
                            Validation.MessageBoxShow("Room exists!", "Exists",
                                "Salla ekziston!", "Ekziston", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            bool isRegistred = _roomBLL.Add(room);

                            if (isRegistred)
                            {
                                Validation.MessageBoxShow("Room registered successfully!", "Registered",
                                    "Salla u regjistrua me sukses!", "U regjistrua", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        bool isUpdated = _roomBLL.Add(room);

                        if (isUpdated)
                        {
                            Validation.MessageBoxShow($"Room No: {room.RoomNo} updated", "Updated",
                                $"Salla: {room.RoomNo} u përditësua!", "U përditësua", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    Validation.MessageBoxShow("Please fill all fields!", "Error",
                        "Ju lutem plotësoni të gjitha fushat!", "Kujdes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                Validation.MessageBoxShow("A problem occurred while registering data!", "Error",
                    "Ndodhi një problem gjatë regjistrimit të të dhënave!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Validation.CheckTextbox(this))
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
        private void picRoomNo_MouseHover(object sender, EventArgs e)
        {
            if (txtRoomNo.Text == null)
            {
                Validation.ToolTipShow("Room number is required!", "Numri i sallës duhet të plotësohet!", picRoomNo);
            }
            else if (txtRoomNo.Text.Length < 2)
            {
                Validation.ToolTipShow("Room number is to short!", "Numri i sallës është i vogël!", picRoomNo);
            }
        }

        private void picRoomType_MouseHover(object sender, EventArgs e)
        {
            if (txtRoomType.Text == null)
            {
                Validation.ToolTipShow("Room type is required!", "Lloji i sallës duhet të plotësohet!", picRoomType);
            }
            else if (txtRoomType.Text.Length < 2)
            {
                Validation.ToolTipShow("Room type is to short!", "Lloji i sallës është i vogël!", picRoomNo);
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
