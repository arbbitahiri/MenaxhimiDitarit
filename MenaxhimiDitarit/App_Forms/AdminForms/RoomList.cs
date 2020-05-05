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
    public partial class RoomList : Form
    {
        private readonly RoomBLL _roomBLL;
        private List<Room> MyRooms;

        public RoomList()
        {
            InitializeComponent();

            dgvRoomList.SelectionMode = GridViewSelectionMode.FullRowSelect;

            _roomBLL = new RoomBLL();
        }

        //Refresh i te dhenave ne DataGrid
        private void RefreshList()
        {
            MyRooms = _roomBLL.GetAll();
            dgvRoomList.DataSource = MyRooms;
        }

        //Mirren te dhenat nga rreshti i klikuar
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
            catch (Exception ex)
            {
                MessageBox.Show($"A problem occurred getting those data!\n{ex.Message}",
                    "Problem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        //Kerkojm te dhenat ne DataGrid
        private void btnSearchSubject_Click(object sender, EventArgs e)
        {
            try
            {
                if (_roomBLL != null)
                {
                    if (txtSearchSubject.Text.Trim().Length > 0)
                    {
                        //Shikojme nese teksti i shkruar ne TextBox eshte RoomType
                        var findRoom = MyRooms.Where(f => f.RoomType.Contains(txtSearchSubject.Text)).ToList();

                        dgvRoomList.DataSource = findRoom;
                    }
                    else
                        MessageBox.Show("Please write a room type!!", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Room type does not exist!!", "Doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A problem occurred while searching data!\n{ex.Message}",
                    "Problem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Update te dhenat per rreshtin e klikuar ne DataGrid
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
                        RoomCreate roomUpdate = new RoomCreate(room);
                        roomUpdate.StartPosition = FormStartPosition.CenterParent;
                        roomUpdate.ShowDialog();
                    }
                }
            }
            RefreshList();
        }

        //Delete te dhenat per rreshtin e klikuar ne DataGrid
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
                        if (MessageBox.Show($"Are you sure you want to delete {room.RoomNo} - {room.RoomType}?",
                            "Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            _roomBLL.Remove(room.RoomID);

                            MessageBox.Show($"Room: {room.RoomNo} has been deleted successfully!",
                                "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            RefreshList();
                        }
                        else
                            MessageBox.Show("Please try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            RefreshList();
        }

        private void txtSearchSubject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearchSubject_Click(this, new EventArgs());
        }
    }
}
