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
            this.picStaff = new System.Windows.Forms.PictureBox();
            this.dtpAbsenceDate = new System.Windows.Forms.DateTimePicker();
            this.lblExpireDate = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cmbStaff = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.picReasoning = new System.Windows.Forms.PictureBox();
            this.cmbReasoning = new System.Windows.Forms.ComboBox();
            this.lblReasoning = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bsrcUser = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReasoning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcUser)).BeginInit();
            this.SuspendLayout();
            // 
            // picStaff
            // 
            this.picStaff.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_cancel_15;
            this.picStaff.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picStaff.Location = new System.Drawing.Point(618, 207);
            this.picStaff.Name = "picStaff";
            this.picStaff.Size = new System.Drawing.Size(20, 20);
            this.picStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picStaff.TabIndex = 122;
            this.picStaff.TabStop = false;
            // 
            // dtpAbsenceDate
            // 
            this.dtpAbsenceDate.CustomFormat = "ddMMMMyyyy";
            this.dtpAbsenceDate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtpAbsenceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAbsenceDate.Location = new System.Drawing.Point(431, 243);
            this.dtpAbsenceDate.Name = "dtpAbsenceDate";
            this.dtpAbsenceDate.Size = new System.Drawing.Size(181, 25);
            this.dtpAbsenceDate.TabIndex = 94;
            // 
            // lblExpireDate
            // 
            this.lblExpireDate.AutoSize = true;
            this.lblExpireDate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblExpireDate.ForeColor = System.Drawing.Color.White;
            this.lblExpireDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblExpireDate.Location = new System.Drawing.Point(337, 247);
            this.lblExpireDate.Name = "lblExpireDate";
            this.lblExpireDate.Size = new System.Drawing.Size(88, 17);
            this.lblExpireDate.TabIndex = 114;
            this.lblExpireDate.Text = "Absence Date";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panel6.Location = new System.Drawing.Point(430, 274);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(181, 1);
            this.panel6.TabIndex = 113;
            // 
            // cmbStaff
            // 
            this.cmbStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.cmbStaff.DataSource = this.bsrcUser;
            this.cmbStaff.DisplayMember = "FullName";
            this.cmbStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStaff.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbStaff.ForeColor = System.Drawing.Color.White;
            this.cmbStaff.FormattingEnabled = true;
            this.cmbStaff.Location = new System.Drawing.Point(431, 205);
            this.cmbStaff.Name = "cmbStaff";
            this.cmbStaff.Size = new System.Drawing.Size(181, 25);
            this.cmbStaff.TabIndex = 95;
            this.cmbStaff.ValueMember = "UserID";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblRole.ForeColor = System.Drawing.Color.White;
            this.lblRole.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRole.Location = new System.Drawing.Point(391, 209);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(34, 17);
            this.lblRole.TabIndex = 108;
            this.lblRole.Text = "Staff";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panel3.Location = new System.Drawing.Point(430, 236);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(181, 1);
            this.panel3.TabIndex = 107;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnSubmit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSubmit.Location = new System.Drawing.Point(478, 350);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(169, 39);
            this.btnSubmit.TabIndex = 99;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(303, 350);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(169, 39);
            this.btnCancel.TabIndex = 100;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblID.Location = new System.Drawing.Point(405, 175);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 17);
            this.lblID.TabIndex = 106;
            this.lblID.Text = "ID";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panel8.Location = new System.Drawing.Point(432, 198);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(181, 1);
            this.panel8.TabIndex = 93;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtID.ForeColor = System.Drawing.Color.White;
            this.txtID.Location = new System.Drawing.Point(431, 174);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(181, 18);
            this.txtID.TabIndex = 90;
            this.txtID.Text = "-1";
            // 
            // picReasoning
            // 
            this.picReasoning.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_cancel_15;
            this.picReasoning.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picReasoning.Location = new System.Drawing.Point(618, 283);
            this.picReasoning.Name = "picReasoning";
            this.picReasoning.Size = new System.Drawing.Size(20, 20);
            this.picReasoning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picReasoning.TabIndex = 126;
            this.picReasoning.TabStop = false;
            // 
            // cmbReasoning
            // 
            this.cmbReasoning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.cmbReasoning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbReasoning.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbReasoning.ForeColor = System.Drawing.Color.White;
            this.cmbReasoning.FormattingEnabled = true;
            this.cmbReasoning.Items.AddRange(new object[] {
            "Reasonable",
            "Unreasonable"});
            this.cmbReasoning.Location = new System.Drawing.Point(431, 281);
            this.cmbReasoning.Name = "cmbReasoning";
            this.cmbReasoning.Size = new System.Drawing.Size(181, 25);
            this.cmbReasoning.TabIndex = 125;
            // 
            // lblReasoning
            // 
            this.lblReasoning.AutoSize = true;
            this.lblReasoning.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblReasoning.ForeColor = System.Drawing.Color.White;
            this.lblReasoning.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblReasoning.Location = new System.Drawing.Point(356, 285);
            this.lblReasoning.Name = "lblReasoning";
            this.lblReasoning.Size = new System.Drawing.Size(69, 17);
            this.lblReasoning.TabIndex = 124;
            this.lblReasoning.Text = "Reasoning";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panel1.Location = new System.Drawing.Point(431, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 1);
            this.panel1.TabIndex = 123;
            // 
            // bsrcUser
            // 
            this.bsrcUser.DataSource = typeof(MenaxhimiDitarit.BO.User);
            // 
            // StaffAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(950, 563);
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
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.txtID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffAbsence";
            this.Text = "StaffAbsence";
            ((System.ComponentModel.ISupportInitialize)(this.picStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReasoning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcUser)).EndInit();
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
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.PictureBox picReasoning;
        private System.Windows.Forms.ComboBox cmbReasoning;
        private System.Windows.Forms.Label lblReasoning;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource bsrcUser;
    }
}