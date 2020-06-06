namespace MenaxhimiDitarit.App_Forms.DirectorForms
{
    partial class UserUpdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserUpdate));
            this.dtpExpireDate = new System.Windows.Forms.DateTimePicker();
            this.lblExpireDate = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.bsrcRole = new System.Windows.Forms.BindingSource(this.components);
            this.lblRole = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.picFirstName = new System.Windows.Forms.PictureBox();
            this.picLastName = new System.Windows.Forms.PictureBox();
            this.picRole = new System.Windows.Forms.PictureBox();
            this.picUsername = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsername)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpExpireDate
            // 
            resources.ApplyResources(this.dtpExpireDate, "dtpExpireDate");
            this.dtpExpireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpireDate.Name = "dtpExpireDate";
            this.dtpExpireDate.CloseUp += new System.EventHandler(this.dtpExpireDate_CloseUp);
            // 
            // lblExpireDate
            // 
            resources.ApplyResources(this.lblExpireDate, "lblExpireDate");
            this.lblExpireDate.ForeColor = System.Drawing.Color.White;
            this.lblExpireDate.Name = "lblExpireDate";
            // 
            // panel6
            // 
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panel6.Name = "panel6";
            // 
            // cmbRoles
            // 
            resources.ApplyResources(this.cmbRoles, "cmbRoles");
            this.cmbRoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.cmbRoles.DataSource = this.bsrcRole;
            this.cmbRoles.DisplayMember = "RoleName";
            this.cmbRoles.ForeColor = System.Drawing.Color.White;
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.ValueMember = "RoleID";
            this.cmbRoles.SelectedIndexChanged += new System.EventHandler(this.cmbRoles_SelectedIndexChanged);
            // 
            // bsrcRole
            // 
            this.bsrcRole.DataSource = typeof(MenaxhimiDitarit.BO.Role);
            // 
            // lblRole
            // 
            resources.ApplyResources(this.lblRole, "lblRole");
            this.lblRole.ForeColor = System.Drawing.Color.White;
            this.lblRole.Name = "lblRole";
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panel3.Name = "panel3";
            // 
            // lblID
            // 
            resources.ApplyResources(this.lblID, "lblID");
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Name = "lblID";
            // 
            // panel8
            // 
            resources.ApplyResources(this.panel8, "panel8");
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panel8.Name = "panel8";
            // 
            // txtID
            // 
            resources.ApplyResources(this.txtID, "txtID");
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.ForeColor = System.Drawing.Color.White;
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            // 
            // lblLastName
            // 
            resources.ApplyResources(this.lblLastName, "lblLastName");
            this.lblLastName.ForeColor = System.Drawing.Color.White;
            this.lblLastName.Name = "lblLastName";
            // 
            // lblFirstName
            // 
            resources.ApplyResources(this.lblFirstName, "lblFirstName");
            this.lblFirstName.ForeColor = System.Drawing.Color.White;
            this.lblFirstName.Name = "lblFirstName";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panel2.Name = "panel2";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panel1.Name = "panel1";
            // 
            // txtLastName
            // 
            resources.ApplyResources(this.txtLastName, "txtLastName");
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.ForeColor = System.Drawing.Color.White;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtFirstName
            // 
            resources.ApplyResources(this.txtFirstName, "txtFirstName");
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.ForeColor = System.Drawing.Color.White;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // lblUsername
            // 
            resources.ApplyResources(this.lblUsername, "lblUsername");
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Name = "lblUsername";
            // 
            // panel5
            // 
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panel5.Name = "panel5";
            // 
            // txtUsername
            // 
            resources.ApplyResources(this.txtUsername, "txtUsername");
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // btnSubmit
            // 
            resources.ApplyResources(this.btnSubmit, "btnSubmit");
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // picFirstName
            // 
            resources.ApplyResources(this.picFirstName, "picFirstName");
            this.picFirstName.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_cancel_15;
            this.picFirstName.Name = "picFirstName";
            this.picFirstName.TabStop = false;
            this.picFirstName.MouseHover += new System.EventHandler(this.picFirstName_MouseHover);
            // 
            // picLastName
            // 
            resources.ApplyResources(this.picLastName, "picLastName");
            this.picLastName.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_cancel_15;
            this.picLastName.Name = "picLastName";
            this.picLastName.TabStop = false;
            this.picLastName.MouseHover += new System.EventHandler(this.picLastName_MouseHover);
            // 
            // picRole
            // 
            resources.ApplyResources(this.picRole, "picRole");
            this.picRole.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_cancel_15;
            this.picRole.Name = "picRole";
            this.picRole.TabStop = false;
            this.picRole.MouseHover += new System.EventHandler(this.picRole_MouseHover);
            // 
            // picUsername
            // 
            resources.ApplyResources(this.picUsername, "picUsername");
            this.picUsername.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_cancel_15;
            this.picUsername.Name = "picUsername";
            this.picUsername.TabStop = false;
            this.picUsername.MouseHover += new System.EventHandler(this.picUsername_MouseHover);
            // 
            // UserUpdate
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.Controls.Add(this.picUsername);
            this.Controls.Add(this.picRole);
            this.Controls.Add(this.picLastName);
            this.Controls.Add(this.picFirstName);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.dtpExpireDate);
            this.Controls.Add(this.lblExpireDate);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.cmbRoles);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserUpdate";
            ((System.ComponentModel.ISupportInitialize)(this.bsrcRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsername)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpExpireDate;
        private System.Windows.Forms.Label lblExpireDate;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource bsrcRole;
        private System.Windows.Forms.PictureBox picFirstName;
        private System.Windows.Forms.PictureBox picLastName;
        private System.Windows.Forms.PictureBox picRole;
        private System.Windows.Forms.PictureBox picUsername;
    }
}