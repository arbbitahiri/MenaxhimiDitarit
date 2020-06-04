﻿using System;
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
using Telerik.WinControls.UI;

namespace MenaxhimiDitarit
{
    public partial class TeacherList : Form
    {
        private readonly TeacherBLL _teacherBLL;
        private List<Teacher> MyTeachers;

        public TeacherList()
        {
            InitializeComponent();

            dgvTeacherList.SelectionMode = GridViewSelectionMode.FullRowSelect;

            _teacherBLL = new TeacherBLL();

            CustomizeDesign();
        }

        #region Metodat

        #region Menu
        private void CustomizeDesign()
        {
            pnlExport.Visible = false;
            pnlPrint.Visible = false;
        }

        private void HideSubMenu()
        {
            if (pnlExport.Visible == true)
            {
                pnlExport.Visible = false;
            }

            if (pnlPrint.Visible == true)
            {
                pnlPrint.Visible = false;
            }
        }

        private void ShowSubMenu(Panel panel)
        {
            if (panel.Visible == false)
            {
                HideSubMenu();
                panel.Visible = true;
            }
            else
                panel.Visible = false;
        }
        #endregion

        //Refresh i te dhenave ne DataGrid
        private void RefreshList()
        {
            MyTeachers = _teacherBLL.GetAll();
            dgvTeacherList.DataSource = MyTeachers;
        }

        //Mirren te dhenat nga rreshti i klikuar
        private Teacher GetTeacher(GridViewRowInfo teacherRow)
        {
            try
            {
                Teacher teacher = new Teacher
                {
                    TeacherID = (int)teacherRow.Cells["TeacherID"].Value,
                    FirstName = (string)teacherRow.Cells["FirstName"].Value,
                    LastName = (string)teacherRow.Cells["LastName"].Value,
                    Gender = (string)teacherRow.Cells["Gender"].Value,
                    City = (string)teacherRow.Cells["City"].Value,
                    Qualification = (string)teacherRow.Cells["Qualification"].Value,
                    DayofBirth = (DateTime)teacherRow.Cells["DayofBirth"].Value,
                    Email = (string)teacherRow.Cells["Email"].Value,
                    PhoneNo = (string)teacherRow.Cells["PhoneNo"].Value,
                    InsertBy = (string)teacherRow.Cells["InsertBy"].Value,
                    InsertDate = (DateTime)teacherRow.Cells["InsertDate"].Value,
                    LUB = (string)teacherRow.Cells["LUB"].Value,
                    LUD = (DateTime)teacherRow.Cells["LUD"].Value,
                    LUN = (int)teacherRow.Cells["LUN"].Value
                };

                return teacher;
            }
            catch (Exception)
            {
                Validation.MessageBoxShow("A problem occurred while getting those data!", "Problem",
                            "Ndodhi një problem gjatë marrjes së këtyre të dhënave!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void UpdateTeacher()
        {
            if (dgvTeacherList.SelectedRows.Count > 0)
            {
                var row = dgvTeacherList.SelectedRows[0].Index;
                if (row >= 0)
                {
                    var teacher = GetTeacher(dgvTeacherList.Rows[row]);
                    if (teacher != null)
                    {
                        TeacherCreate teacherUpdate = new TeacherCreate(teacher)
                        {
                            StartPosition = FormStartPosition.CenterParent
                        };
                        teacherUpdate.ShowDialog();
                    }
                }
            }
            RefreshList();
        }
        #endregion

        private void TeacherListForm_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnViewAllTeachers_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        //Kerkojm te dhenat ne DataGrid
        private void btnSearchTeachers_Click(object sender, EventArgs e)
        {
            try
            {
                if (_teacherBLL != null)
                {
                    if (txtSearchName.Text.Trim().Length > 0)
                    {
                        //Shikojme nese teksti i shkruar ne TextBox eshte FirstName apo LastName apo te gjithe emrin FullName
                        var findTeacher = MyTeachers.Where(f => f.FirstName.Contains(txtSearchName.Text)
                        || f.LastName.Contains(txtSearchName.Text) || f.FullName.Contains(txtSearchName.Text)).ToList();

                        dgvTeacherList.DataSource = findTeacher;
                    }
                    else
                    {
                        Validation.MessageBoxShow("Please write a name!", "Empty",
                            "Ju lutem shkruani një emër!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Validation.MessageBoxShow("Teacher does not exist!", "Doesn't exist",
                        "Arsimtari nuk ekziston!", "Nuk ekziston", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                Validation.MessageBoxShow("A problem occurred while searching data!", "Problem",
                            "Ndodhi një problem gjatë kërkimit të të dhënave!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Update te dhenat per rreshtin e klikuar ne DataGrid
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateTeacher();
        }

        #region Search Textbox
        private void txtSearchName_Click(object sender, EventArgs e)
        {
            txtSearchName.Clear();
        }

        private void txtSearchName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearchTeachers_Click(this, new EventArgs());
        }

        private void txtSearchName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.NoNumber(e);
        }
        #endregion

        #region Menu
        private void btnAddClass_Click(object sender, EventArgs e)
        {
            TeacherCreate addTeacher = new TeacherCreate
            {
                StartPosition = FormStartPosition.CenterParent
            };
            addTeacher.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateTeacher();
        }

        #region Print
        private void btnPrintM_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlPrint);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {

        }

        private void btnPrintSettings_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Export
        private void btnExport_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlExport);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

        }

        private void btnPDF_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #endregion
    }
}
