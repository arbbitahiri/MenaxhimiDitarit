using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using MenaxhimiDitarit.App_Code;
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

        #region Metodat
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
                    RoomID = (int)roomRow.Cells["RoomID"].Value,
                    RoomNo = (int)roomRow.Cells["RoomNo"].Value,
                    RoomType = (string)roomRow.Cells["RoomType"].Value,
                    InsertBy = (string)roomRow.Cells["InsertBy"].Value,
                    InsertDate = (DateTime)roomRow.Cells["InsertDate"].Value,
                    LUB = (string)roomRow.Cells["LUB"].Value,
                    LUD = (DateTime)roomRow.Cells["LUD"].Value,
                    LUN = (int)roomRow.Cells["LUN"].Value
                };

                return room;
            }
            catch (Exception)
            {
                Validation.MessageBoxShow("A problem occurred while getting those data!", "Problem",
                            "Ndodhi një problem gjatë marrjes së këtyre të dhënave!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void DeleteRoom()
        {
            if (dgvRoomList.SelectedRows.Count > 0)
            {
                var row = dgvRoomList.SelectedRows[0].Index;
                if (row >= 0)
                {
                    var room = GetRoom(dgvRoomList.Rows[row]);
                    if (room != null)
                    {
                        var result = Validation.MessageBoxShow($"Are you sure you want to delete {room.RoomNo} - {room.RoomType}?", "Sure?",
                            $"A je i/e sigurt që do ta fshini sallën: {room.RoomNo} - {room.RoomType}?", "Sigurt?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            _roomBLL.Remove(room.RoomID);

                            Validation.MessageBoxShow($"Room: {room.RoomNo} has been deleted successfully!", "Deleted",
                                $"Salla: {room.RoomNo} u fshi!", "U fshi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            RefreshList();
                        }
                    }
                }
            }
            RefreshList();
        }

        private void UpdateRoom()
        {
            if (dgvRoomList.SelectedRows.Count > 0)
            {
                var row = dgvRoomList.SelectedRows[0].Index;
                if (row >= 0)
                {
                    var room = GetRoom(dgvRoomList.Rows[row]);
                    if (room != null)
                    {
                        RoomCreate roomUpdate = new RoomCreate(room)
                        {
                            StartPosition = FormStartPosition.CenterParent
                        };
                        roomUpdate.ShowDialog();
                    }
                }
            }
            RefreshList();
        }
        #endregion

        private void RoomListForm_Load(object sender, EventArgs e)
        {
            RefreshList();

            Validation.InitializePrintDocument(printDocument, "Room List", "Lista e Sallës");
        }

        #region Buttons
        private void btnViewAllSubjects_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnSearchSubject_Click(object sender, EventArgs e)
        {
            try
            {
                if (_roomBLL != null)
                {
                    if (txtSearchSubject.Text.Trim().Length > 0)
                    {
                        var findRoom = MyRooms.Where(f => f.RoomType.Contains(txtSearchSubject.Text)).ToList();

                        dgvRoomList.DataSource = findRoom;
                    }
                    else
                    {
                        Validation.MessageBoxShow("Please write a room type!", "Empty",
                            "Ju lutem shkruani llojin e sallës!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    Validation.MessageBoxShow("Room type does not exist!", "Doesn't exist",
                        "Lloji i sallës nuk ekziston!", "Nuk ekziston", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                Validation.MessageBoxShow("A problem occurred while searching data!", "Problem",
                            "Ndodhi një problem gjatë kërkimit të të dhënave!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Tool Strip Menu
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateRoom();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteRoom();
        }
        #endregion

        #region Search Textbox
        private void txtSearchSubject_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchSubject.Text.Length > 0)
            {
                Validation.Capitalize(txtSearchSubject);
            }
        }

        private void txtSearchSubject_Click(object sender, EventArgs e)
        {
            txtSearchSubject.Text = "";
        }

        private void txtSearchSubject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchSubject_Click(this, new EventArgs());
            }
        }

        private void txtSearchSubject_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.NoNumber(e);
        }
        #endregion

        #region Menu

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            RoomCreate addRoom = new RoomCreate
            {
                StartPosition = FormStartPosition.CenterParent
            };
            addRoom.ShowDialog();

            RefreshList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateRoom();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteRoom();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            dgvRoomList.PrintPreview(printDocument);
        }

        #region Export
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread((ThreadStart)(() =>
            {
                var saveFileDialog = Validation.SaveFile("RoomList", "ListaESallës", ".xlsx", "Excel Workbook |*.xlsx");

                saveFileDialog.ShowDialog();

                Validation.ExportToExcel(dgvRoomList, saveFileDialog.FileName, "RoomList", "ListaESallës");
            }));

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();

            Validation.MessageBoxShow("Excel file created succesfully!", "Created", "Excel file u krijua me sukses!", "U krijua",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread((ThreadStart)(() =>
            {
                var saveFileDialog = Validation.SaveFile("RoomList", "ListaESallës", ".pdf", "Pdf Files|*.pdf");

                saveFileDialog.ShowDialog();

                Validation.ExportToPDF(dgvRoomList, saveFileDialog.FileName);
            }));

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();

            Validation.MessageBoxShow("PDF file created succesfully!", "Created", "PDF file u krijua me sukses!", "U krijua",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #endregion
    }
}