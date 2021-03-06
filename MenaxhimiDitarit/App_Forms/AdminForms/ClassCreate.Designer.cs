﻿namespace MenaxhimiDitarit.AdminForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassCreate));
            this.btnSubmitClass = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblSelectRoom = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.picMainTeacher = new System.Windows.Forms.PictureBox();
            this.picClass = new System.Windows.Forms.PictureBox();
            this.picRoom = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHELP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmitClass
            // 
            resources.ApplyResources(this.btnSubmitClass, "btnSubmitClass");
            this.btnSubmitClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.btnSubmitClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitClass.FlatAppearance.BorderSize = 0;
            this.btnSubmitClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnSubmitClass.Name = "btnSubmitClass";
            this.btnSubmitClass.UseVisualStyleBackColor = false;
            this.btnSubmitClass.Click += new System.EventHandler(this.btnSubmitClass_Click);
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
            // lblSelectRoom
            // 
            resources.ApplyResources(this.lblSelectRoom, "lblSelectRoom");
            this.lblSelectRoom.ForeColor = System.Drawing.Color.White;
            this.lblSelectRoom.Name = "lblSelectRoom";
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panel3.Name = "panel3";
            // 
            // txtID
            // 
            resources.ApplyResources(this.txtID, "txtID");
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            // 
            // lblClass
            // 
            resources.ApplyResources(this.lblClass, "lblClass");
            this.lblClass.ForeColor = System.Drawing.Color.White;
            this.lblClass.Name = "lblClass";
            // 
            // lblMainTeacher
            // 
            resources.ApplyResources(this.lblMainTeacher, "lblMainTeacher");
            this.lblMainTeacher.ForeColor = System.Drawing.Color.White;
            this.lblMainTeacher.Name = "lblMainTeacher";
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
            // cmbMainTeacher
            // 
            resources.ApplyResources(this.cmbMainTeacher, "cmbMainTeacher");
            this.cmbMainTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.cmbMainTeacher.DataSource = this.bsrcTeacher;
            this.cmbMainTeacher.DisplayMember = "FullName";
            this.cmbMainTeacher.ForeColor = System.Drawing.Color.White;
            this.cmbMainTeacher.FormattingEnabled = true;
            this.cmbMainTeacher.Name = "cmbMainTeacher";
            this.cmbMainTeacher.ValueMember = "TeacherID";
            this.cmbMainTeacher.SelectedIndexChanged += new System.EventHandler(this.cmbMainTeacher_SelectedIndexChanged);
            // 
            // bsrcTeacher
            // 
            this.bsrcTeacher.DataSource = typeof(MenaxhimiDitarit.BO.Teacher);
            // 
            // cmbSelectClass
            // 
            resources.ApplyResources(this.cmbSelectClass, "cmbSelectClass");
            this.cmbSelectClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.cmbSelectClass.ForeColor = System.Drawing.Color.White;
            this.cmbSelectClass.FormattingEnabled = true;
            this.cmbSelectClass.Items.AddRange(new object[] {
            resources.GetString("cmbSelectClass.Items"),
            resources.GetString("cmbSelectClass.Items1"),
            resources.GetString("cmbSelectClass.Items2"),
            resources.GetString("cmbSelectClass.Items3"),
            resources.GetString("cmbSelectClass.Items4"),
            resources.GetString("cmbSelectClass.Items5"),
            resources.GetString("cmbSelectClass.Items6"),
            resources.GetString("cmbSelectClass.Items7"),
            resources.GetString("cmbSelectClass.Items8")});
            this.cmbSelectClass.Name = "cmbSelectClass";
            this.cmbSelectClass.SelectedIndexChanged += new System.EventHandler(this.cmbSelectClass_SelectedIndexChanged);
            // 
            // cmbSelectRoom
            // 
            resources.ApplyResources(this.cmbSelectRoom, "cmbSelectRoom");
            this.cmbSelectRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.cmbSelectRoom.DataSource = this.bsrcRoom;
            this.cmbSelectRoom.DisplayMember = "RoomType";
            this.cmbSelectRoom.ForeColor = System.Drawing.Color.White;
            this.cmbSelectRoom.FormattingEnabled = true;
            this.cmbSelectRoom.Name = "cmbSelectRoom";
            this.cmbSelectRoom.ValueMember = "RoomID";
            this.cmbSelectRoom.SelectedIndexChanged += new System.EventHandler(this.cmbSelectRoom_SelectedIndexChanged);
            // 
            // bsrcRoom
            // 
            this.bsrcRoom.DataSource = typeof(MenaxhimiDitarit.BO.Room);
            // 
            // picMainTeacher
            // 
            resources.ApplyResources(this.picMainTeacher, "picMainTeacher");
            this.picMainTeacher.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_cancel_15;
            this.picMainTeacher.Name = "picMainTeacher";
            this.picMainTeacher.TabStop = false;
            this.picMainTeacher.MouseHover += new System.EventHandler(this.picMainTeacher_MouseHover);
            // 
            // picClass
            // 
            resources.ApplyResources(this.picClass, "picClass");
            this.picClass.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_cancel_15;
            this.picClass.Name = "picClass";
            this.picClass.TabStop = false;
            this.picClass.MouseHover += new System.EventHandler(this.picClass_MouseHover);
            // 
            // picRoom
            // 
            resources.ApplyResources(this.picRoom, "picRoom");
            this.picRoom.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_cancel_15;
            this.picRoom.Name = "picRoom";
            this.picRoom.TabStop = false;
            this.picRoom.MouseHover += new System.EventHandler(this.picRoom_MouseHover);
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
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHELP
            // 
            resources.ApplyResources(this.btnHELP, "btnHELP");
            this.btnHELP.FlatAppearance.BorderSize = 0;
            this.btnHELP.ForeColor = System.Drawing.Color.White;
            this.btnHELP.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_help_50;
            this.btnHELP.Name = "btnHELP";
            this.btnHELP.UseVisualStyleBackColor = true;
            this.btnHELP.Click += new System.EventHandler(this.btnHELP_Click);
            // 
            // ClassCreate
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHELP);
            this.Controls.Add(this.picRoom);
            this.Controls.Add(this.picClass);
            this.Controls.Add(this.picMainTeacher);
            this.Controls.Add(this.cmbSelectRoom);
            this.Controls.Add(this.cmbSelectClass);
            this.Controls.Add(this.cmbMainTeacher);
            this.Controls.Add(this.btnSubmitClass);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblSelectRoom);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblMainTeacher);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClassCreate";
            ((System.ComponentModel.ISupportInitialize)(this.bsrcTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmitClass;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblSelectRoom;
        private System.Windows.Forms.Panel panel3;
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
        private System.Windows.Forms.PictureBox picMainTeacher;
        private System.Windows.Forms.PictureBox picClass;
        private System.Windows.Forms.PictureBox picRoom;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHELP;
    }
}