namespace MenaxhimiDitarit.App_Forms.DirectorForms
{
    partial class StaffAbsence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffAbsence));
            this.picStaff = new System.Windows.Forms.PictureBox();
            this.dtpAbsenceDate = new System.Windows.Forms.DateTimePicker();
            this.lblExpireDate = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cmbStaff = new System.Windows.Forms.ComboBox();
            this.bsrcUser = new System.Windows.Forms.BindingSource(this.components);
            this.lblRole = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.picReasoning = new System.Windows.Forms.PictureBox();
            this.cmbReasoning = new System.Windows.Forms.ComboBox();
            this.lblReasoning = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHELP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReasoning)).BeginInit();
            this.SuspendLayout();
            // 
            // picStaff
            // 
            this.picStaff.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_cancel_15;
            resources.ApplyResources(this.picStaff, "picStaff");
            this.picStaff.Name = "picStaff";
            this.picStaff.TabStop = false;
            this.picStaff.MouseHover += new System.EventHandler(this.picStaff_MouseHover);
            // 
            // dtpAbsenceDate
            // 
            resources.ApplyResources(this.dtpAbsenceDate, "dtpAbsenceDate");
            this.dtpAbsenceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAbsenceDate.Name = "dtpAbsenceDate";
            // 
            // lblExpireDate
            // 
            resources.ApplyResources(this.lblExpireDate, "lblExpireDate");
            this.lblExpireDate.ForeColor = System.Drawing.Color.White;
            this.lblExpireDate.Name = "lblExpireDate";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // cmbStaff
            // 
            this.cmbStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.cmbStaff.DataSource = this.bsrcUser;
            this.cmbStaff.DisplayMember = "FullName";
            resources.ApplyResources(this.cmbStaff, "cmbStaff");
            this.cmbStaff.ForeColor = System.Drawing.Color.White;
            this.cmbStaff.FormattingEnabled = true;
            this.cmbStaff.Name = "cmbStaff";
            this.cmbStaff.ValueMember = "UserID";
            this.cmbStaff.SelectedIndexChanged += new System.EventHandler(this.cmbStaff_SelectedIndexChanged);
            // 
            // bsrcUser
            // 
            this.bsrcUser.DataSource = typeof(MenaxhimiDitarit.BO.User);
            // 
            // lblRole
            // 
            resources.ApplyResources(this.lblRole, "lblRole");
            this.lblRole.ForeColor = System.Drawing.Color.White;
            this.lblRole.Name = "lblRole";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnSubmit, "btnSubmit");
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtID, "txtID");
            this.txtID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            // 
            // picReasoning
            // 
            this.picReasoning.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_cancel_15;
            resources.ApplyResources(this.picReasoning, "picReasoning");
            this.picReasoning.Name = "picReasoning";
            this.picReasoning.TabStop = false;
            this.picReasoning.MouseHover += new System.EventHandler(this.picReasoning_MouseHover);
            // 
            // cmbReasoning
            // 
            this.cmbReasoning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            resources.ApplyResources(this.cmbReasoning, "cmbReasoning");
            this.cmbReasoning.ForeColor = System.Drawing.Color.White;
            this.cmbReasoning.FormattingEnabled = true;
            this.cmbReasoning.Items.AddRange(new object[] {
            resources.GetString("cmbReasoning.Items"),
            resources.GetString("cmbReasoning.Items1")});
            this.cmbReasoning.Name = "cmbReasoning";
            this.cmbReasoning.SelectedIndexChanged += new System.EventHandler(this.cmbReasoning_SelectedIndexChanged);
            // 
            // lblReasoning
            // 
            resources.ApplyResources(this.lblReasoning, "lblReasoning");
            this.lblReasoning.ForeColor = System.Drawing.Color.White;
            this.lblReasoning.Name = "lblReasoning";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_delete_35;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnHELP
            // 
            resources.ApplyResources(this.btnHELP, "btnHELP");
            this.btnHELP.FlatAppearance.BorderSize = 0;
            this.btnHELP.ForeColor = System.Drawing.Color.White;
            this.btnHELP.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_help_50;
            this.btnHELP.Name = "btnHELP";
            this.btnHELP.UseVisualStyleBackColor = true;
            // 
            // StaffAbsence
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHELP);
            this.Controls.Add(this.picReasoning);
            this.Controls.Add(this.cmbReasoning);
            this.Controls.Add(this.lblReasoning);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picStaff);
            this.Controls.Add(this.dtpAbsenceDate);
            this.Controls.Add(this.lblExpireDate);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.cmbStaff);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffAbsence";
            ((System.ComponentModel.ISupportInitialize)(this.picStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReasoning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picStaff;
        private System.Windows.Forms.DateTimePicker dtpAbsenceDate;
        private System.Windows.Forms.Label lblExpireDate;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cmbStaff;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.PictureBox picReasoning;
        private System.Windows.Forms.ComboBox cmbReasoning;
        private System.Windows.Forms.Label lblReasoning;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource bsrcUser;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHELP;
    }
}