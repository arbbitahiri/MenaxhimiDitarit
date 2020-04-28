namespace MenaxhimiDitarit.AdminForms
{
    partial class ClassCreate
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
            this.btnSubmitClass = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblSelectRoom = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblMainTeacher = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbMainTeacher = new System.Windows.Forms.ComboBox();
            this.bsrcTeacher = new System.Windows.Forms.BindingSource(this.components);
            this.cmbSelectClass = new System.Windows.Forms.ComboBox();
            this.cmbSelectRoom = new System.Windows.Forms.ComboBox();
            this.bsrcRoom = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsrcTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmitClass
            // 
            this.btnSubmitClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.btnSubmitClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitClass.FlatAppearance.BorderSize = 0;
            this.btnSubmitClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnSubmitClass.Location = new System.Drawing.Point(339, 326);
            this.btnSubmitClass.Name = "btnSubmitClass";
            this.btnSubmitClass.Size = new System.Drawing.Size(169, 39);
            this.btnSubmitClass.TabIndex = 4;
            this.btnSubmitClass.Text = "Submit";
            this.btnSubmitClass.UseVisualStyleBackColor = false;
            this.btnSubmitClass.Click += new System.EventHandler(this.btnSubmitClass_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnCancel.Location = new System.Drawing.Point(164, 326);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(169, 39);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblSelectRoom
            // 
            this.lblSelectRoom.AutoSize = true;
            this.lblSelectRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectRoom.ForeColor = System.Drawing.Color.White;
            this.lblSelectRoom.Location = new System.Drawing.Point(198, 279);
            this.lblSelectRoom.Name = "lblSelectRoom";
            this.lblSelectRoom.Size = new System.Drawing.Size(86, 16);
            this.lblSelectRoom.TabIndex = 54;
            this.lblSelectRoom.Text = "Select Room";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panel3.Location = new System.Drawing.Point(290, 306);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(181, 1);
            this.panel3.TabIndex = 53;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(263, 173);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 16);
            this.lblID.TabIndex = 51;
            this.lblID.Text = "ID";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panel8.Location = new System.Drawing.Point(290, 194);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(181, 1);
            this.panel8.TabIndex = 50;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.White;
            this.txtID.Location = new System.Drawing.Point(290, 174);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(181, 15);
            this.txtID.TabIndex = 0;
            this.txtID.Text = "-1";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.ForeColor = System.Drawing.Color.White;
            this.lblClass.Location = new System.Drawing.Point(201, 241);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(83, 16);
            this.lblClass.TabIndex = 47;
            this.lblClass.Text = "Select Class";
            // 
            // lblMainTeacher
            // 
            this.lblMainTeacher.AutoSize = true;
            this.lblMainTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTeacher.ForeColor = System.Drawing.Color.White;
            this.lblMainTeacher.Location = new System.Drawing.Point(193, 204);
            this.lblMainTeacher.Name = "lblMainTeacher";
            this.lblMainTeacher.Size = new System.Drawing.Size(91, 16);
            this.lblMainTeacher.TabIndex = 48;
            this.lblMainTeacher.Text = "Main Teacher";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panel2.Location = new System.Drawing.Point(290, 268);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(181, 1);
            this.panel2.TabIndex = 45;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panel1.Location = new System.Drawing.Point(290, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 1);
            this.panel1.TabIndex = 46;
            // 
            // cmbMainTeacher
            // 
            this.cmbMainTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.cmbMainTeacher.DataSource = this.bsrcTeacher;
            this.cmbMainTeacher.DisplayMember = "FullName";
            this.cmbMainTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMainTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMainTeacher.ForeColor = System.Drawing.Color.White;
            this.cmbMainTeacher.FormattingEnabled = true;
            this.cmbMainTeacher.Location = new System.Drawing.Point(290, 201);
            this.cmbMainTeacher.Name = "cmbMainTeacher";
            this.cmbMainTeacher.Size = new System.Drawing.Size(181, 24);
            this.cmbMainTeacher.TabIndex = 1;
            this.cmbMainTeacher.ValueMember = "TeacherID";
            // 
            // bsrcTeacher
            // 
            this.bsrcTeacher.DataSource = typeof(MenaxhimiDitarit.BO.Teacher);
            // 
            // cmbSelectClass
            // 
            this.cmbSelectClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.cmbSelectClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSelectClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectClass.ForeColor = System.Drawing.Color.White;
            this.cmbSelectClass.FormattingEnabled = true;
            this.cmbSelectClass.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbSelectClass.Location = new System.Drawing.Point(290, 238);
            this.cmbSelectClass.Name = "cmbSelectClass";
            this.cmbSelectClass.Size = new System.Drawing.Size(181, 24);
            this.cmbSelectClass.TabIndex = 2;
            // 
            // cmbSelectRoom
            // 
            this.cmbSelectRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.cmbSelectRoom.DataSource = this.bsrcRoom;
            this.cmbSelectRoom.DisplayMember = "RoomType";
            this.cmbSelectRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSelectRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectRoom.ForeColor = System.Drawing.Color.White;
            this.cmbSelectRoom.FormattingEnabled = true;
            this.cmbSelectRoom.Location = new System.Drawing.Point(290, 276);
            this.cmbSelectRoom.Name = "cmbSelectRoom";
            this.cmbSelectRoom.Size = new System.Drawing.Size(181, 24);
            this.cmbSelectRoom.TabIndex = 3;
            this.cmbSelectRoom.ValueMember = "RoomID";
            // 
            // bsrcRoom
            // 
            this.bsrcRoom.DataSource = typeof(MenaxhimiDitarit.BO.Room);
            // 
            // ClassCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(673, 563);
            this.Controls.Add(this.cmbSelectRoom);
            this.Controls.Add(this.cmbSelectClass);
            this.Controls.Add(this.cmbMainTeacher);
            this.Controls.Add(this.btnSubmitClass);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblSelectRoom);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblMainTeacher);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClassCreate";
            this.Text = "Create Class";
            ((System.ComponentModel.ISupportInitialize)(this.bsrcTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmitClass;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblSelectRoom;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblMainTeacher;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbMainTeacher;
        private System.Windows.Forms.ComboBox cmbSelectClass;
        private System.Windows.Forms.ComboBox cmbSelectRoom;
        private System.Windows.Forms.BindingSource bsrcRoom;
        private System.Windows.Forms.BindingSource bsrcTeacher;
    }
}