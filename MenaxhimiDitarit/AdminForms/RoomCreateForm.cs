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
    public partial class RoomCreateForm : Form
    {
        private readonly RoomBLL _roomBLL;
        private Room _room;
        private readonly bool update = false;

        public RoomCreateForm()
        {
            InitializeComponent();

            _roomBLL = new RoomBLL();
            update = false;
        }

        public RoomCreateForm(Room room)
        {
            InitializeComponent();

            _roomBLL = new RoomBLL();
            _room = room;
            PopulateForm(_room);
        }

        private void PopulateForm(Room room)
        {
            txtID.Text = room.RoomID.ToString();
            txtRoomNo.Text = room.RoomNo.ToString();
            txtRoomType.Text = room.RoomType;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Room room = new Room();

            room.RoomID = int.Parse(txtID.Text);
            room.RoomNo = int.Parse(txtRoomNo.Text);
            room.RoomType = txtRoomType.Text;
            room.InsertBy = UserSession.GetUser.UserName;
            room.InsertDate = DateTime.Now;
            room.LUB = UserSession.GetUser.UserName;
            room.LUD = DateTime.Now;

            if (!update)
                room.LUN++;
            else if (update)
                room.LUN = ++_room.LUN;

            if (!update)
            {
                bool isRegistred = _roomBLL.Add(room);

                if (isRegistred)
                {
                    MessageBox.Show("Subject registred successfully", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Registration failed, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Subject Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
