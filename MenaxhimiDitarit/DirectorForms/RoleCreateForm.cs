using MenaxhimiDitarit.BLL;
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
        private readonly RoleBLL _roleBLL;
        private Role _role;
        private List<Role> MyRoles;
        private bool update = false;

        public RoleCreateForm()
        {
            InitializeComponent();

            _roleBLL = new RoleBLL();
            MyRoles = _roleBLL.GetAll();
            update = false;
        }

        public RoleCreateForm(Role role)
        {
            InitializeComponent();

            _roleBLL = new RoleBLL();
            MyRoles = _roleBLL.GetAll();
            _role = role;
            update = _role != null;
            PopulateForm(_role);
        }

        private void PopulateForm(Role role)
        {
            txtID.Text = role.RoleID.ToString();
            txtRoleName.Text = role.RoleName;
        }

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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (CheckTextbox()) {
                Role role = new Role();

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

                if (!update) {
                    var temp = MyRoles.Where(t => t.RoleName == txtRoleName.Text).ToList();

                    if (temp.Count > 0)
                        MessageBox.Show("Role exists", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else {
                        bool isRegistred = _roleBLL.Add(role);

                        if (isRegistred) {
                            MessageBox.Show("Role registered successfully", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                            MessageBox.Show("Registration failed, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else {
                    bool isUpdated = _roleBLL.Add(role);

                    if (isUpdated) {
                        MessageBox.Show($"Role: {role.RoleName} updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Updated failed, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Please fill all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
