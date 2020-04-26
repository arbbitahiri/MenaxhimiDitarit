﻿using MenaxhimiDitarit.BLL;
using MenaxhimiDitarit.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenaxhimiDitarit.DirectorForms
{
    public partial class RoleCreateForm : Form
    {
        private readonly RoleBLL _rolesBLL;
        private Roles _role;
        private List<Roles> MyRoles;
        private bool update = false;

        public RoleCreateForm()
        {
            InitializeComponent();

            _rolesBLL = new RoleBLL();
            MyRoles = _rolesBLL.GetAll();
            update = false;
        }

        public RoleCreateForm(Roles role)
        {
            InitializeComponent();

            _rolesBLL = new RoleBLL();
            MyRoles = _rolesBLL.GetAll();
            _role = role;
            update = _role != null;
            PopulateForm(_role);
        }

        private void PopulateForm(Roles role)
        {
            txtID.Text = role.RoleID.ToString();
            txtRoleName.Text = role.RoleName;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Roles role = new Roles();

            role.RoleID = int.Parse(txtID.Text);
            role.RoleName = txtRoleName.Text;
            role.InsertBy = UserSession.GetUser.UserName;
            role.InsertDate = DateTime.Now;
            role.LUB = UserSession.GetUser.UserName;
            role.LUD = DateTime.Now;

            if (!update)
                role.LUN++;
            else if (update)
                role.LUN = ++_role.LUN;

            if (!update)
            {
                var temp = MyRoles.Where(t => t.RoleName == txtRoleName.Text).ToList();

                if (temp.Count > 0)
                    MessageBox.Show("Role exists", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    bool isRegistred = _rolesBLL.Add(role);

                    if (isRegistred)
                    {
                        MessageBox.Show("Role registered successfully", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Registration failed, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Role updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
