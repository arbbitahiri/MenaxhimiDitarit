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
using Telerik.WinControls.UI;

namespace MenaxhimiDitarit.AdminForms
{
    public partial class RoomListForm : Form
    {
        private readonly RoomBLL _roomBLL;
        private List<Room> MyRooms;

        public RoomListForm()
        {
            InitializeComponent();

            _roomBLL = new RoomBLL();
        }

        private void RefreshList()
        {
            MyRooms = _roomBLL.GetAll();
            dgvRoomList.DataSource = MyRooms;
        }

        private Room GetRoom(GridViewRowInfo roomRow)
        {
            try
            {
                Room room = new Room
                {
                    RoomID = (int)roomRow.Cells[0].Value,
                    RoomNo = (int)roomRow.Cells[1].Value,
                    RoomType = (string)roomRow.Cells[2].Value,
                    InsertBy = (string)roomRow.Cells[3].Value,
                    InsertDate = (DateTime)roomRow.Cells[4].Value,
                    LUB = (string)roomRow.Cells[5].Value,
                    LUD = (DateTime)roomRow.Cells[6].Value,
                    LUN = (int)roomRow.Cells[7].Value
                };

                return room;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void txtSearchSubject_Click(object sender, EventArgs e)
        {
            txtSearchSubject.Text = "";
        }

        private void btnViewAllSubjects_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void RoomListForm_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnSearchSubject_Click(object sender, EventArgs e)
        {
            if (_roomBLL != null)
            {
                if (txtSearchSubject.Text.Trim().Length > 0)
                {
                    var findRoom = MyRooms.Where(f => f.RoomType.Contains(txtSearchSubject.Text)).ToList();

                    dgvRoomList.DataSource = findRoom;
                }
                else
                    MessageBox.Show("Please write a room type!!", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Room type does not exist!!", "Doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvRoomList.SelectedRows.Count > 0)
            {
                var row = dgvRoomList.SelectedRows[0].Index;
                if (row >= 0)
                {
                    var room = GetRoom(dgvRoomList.Rows[row]);
                    if (room != null)
                    {
                        RoomCreateForm roomUpdate = new RoomCreateForm(room);
                        roomUpdate.StartPosition = FormStartPosition.CenterParent;
                        roomUpdate.ShowDialog();
                    }
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvRoomList.SelectedRows.Count > 0)
            {
                var row = dgvRoomList.SelectedRows[0].Index;
                if (row >= 0)
                {
                    var room = GetRoom(dgvRoomList.Rows[row]);
                    if (room != null)
                    {
                        if (MessageBox.Show($"Are you sure you want to delete {room.RoomID}. {room.RoomNo} - {room.RoomType}?", "Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                            == DialogResult.OK)
                        {
                            _roomBLL.Remove(room.RoomID);
                            MessageBox.Show($"Room: {room.RoomNo} has been deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshList();
                        }
                        else
                            MessageBox.Show("Please try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void txtSearchSubject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearchSubject_Click(this, new EventArgs());
        }
    }
}
