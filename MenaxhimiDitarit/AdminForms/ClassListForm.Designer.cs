﻿namespace MenaxhimiDitarit
{
    partial class ClassListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassListForm));
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.grbSearchClass = new System.Windows.Forms.GroupBox();
            this.btnSearchClass = new System.Windows.Forms.Button();
            this.btnViewAllClass = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearchClass = new System.Windows.Forms.TextBox();
            this.cmsClassContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crystalDarkTheme1 = new Telerik.WinControls.Themes.CrystalDarkTheme();
            this.dgvClassesList = new Telerik.WinControls.UI.RadGridView();
            this.bsrcClassList = new System.Windows.Forms.BindingSource(this.components);
            this.grbSearchClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cmsClassContext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassesList.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcClassList)).BeginInit();
            this.SuspendLayout();
            // 
            // grbSearchClass
            // 
            this.grbSearchClass.Controls.Add(this.btnSearchClass);
            this.grbSearchClass.Controls.Add(this.btnViewAllClass);
            this.grbSearchClass.Controls.Add(this.pictureBox1);
            this.grbSearchClass.Controls.Add(this.panel1);
            this.grbSearchClass.Controls.Add(this.txtSearchClass);
            this.grbSearchClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbSearchClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSearchClass.ForeColor = System.Drawing.Color.White;
            this.grbSearchClass.Location = new System.Drawing.Point(120, 12);
            this.grbSearchClass.Name = "grbSearchClass";
            this.grbSearchClass.Size = new System.Drawing.Size(432, 111);
            this.grbSearchClass.TabIndex = 11;
            this.grbSearchClass.TabStop = false;
            this.grbSearchClass.Text = "Search";
            // 
            // btnSearchClass
            // 
            this.btnSearchClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.btnSearchClass.FlatAppearance.BorderSize = 0;
            this.btnSearchClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnSearchClass.Location = new System.Drawing.Point(246, 68);
            this.btnSearchClass.Name = "btnSearchClass";
            this.btnSearchClass.Size = new System.Drawing.Size(172, 32);
            this.btnSearchClass.TabIndex = 9;
            this.btnSearchClass.Text = "Search";
            this.btnSearchClass.UseVisualStyleBackColor = false;
            this.btnSearchClass.Click += new System.EventHandler(this.btnSearchClass_Click);
            // 
            // btnViewAllClass
            // 
            this.btnViewAllClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.btnViewAllClass.FlatAppearance.BorderSize = 0;
            this.btnViewAllClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAllClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnViewAllClass.Location = new System.Drawing.Point(8, 68);
            this.btnViewAllClass.Name = "btnViewAllClass";
            this.btnViewAllClass.Size = new System.Drawing.Size(168, 32);
            this.btnViewAllClass.TabIndex = 9;
            this.btnViewAllClass.Text = "View All Classrooms";
            this.btnViewAllClass.UseVisualStyleBackColor = false;
            this.btnViewAllClass.Click += new System.EventHandler(this.btnViewAllClass_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 25);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panel1.Location = new System.Drawing.Point(17, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 1);
            this.panel1.TabIndex = 7;
            // 
            // txtSearchClass
            // 
            this.txtSearchClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.txtSearchClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchClass.ForeColor = System.Drawing.Color.White;
            this.txtSearchClass.Location = new System.Drawing.Point(47, 30);
            this.txtSearchClass.Name = "txtSearchClass";
            this.txtSearchClass.Size = new System.Drawing.Size(371, 15);
            this.txtSearchClass.TabIndex = 5;
            this.txtSearchClass.Text = "Search by ClassNo.";
            this.txtSearchClass.Click += new System.EventHandler(this.txtSearchClass_Click);
            this.txtSearchClass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchClass_KeyDown);
            // 
            // cmsClassContext
            // 
            this.cmsClassContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsClassContext.Name = "cmsClassContext";
            this.cmsClassContext.Size = new System.Drawing.Size(113, 48);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updateToolStripMenuItem.Image")));
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // dgvClassesList
            // 
            this.dgvClassesList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.dgvClassesList.ContextMenuStrip = this.cmsClassContext;
            this.dgvClassesList.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvClassesList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvClassesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvClassesList.ForeColor = System.Drawing.Color.White;
            this.dgvClassesList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvClassesList.Location = new System.Drawing.Point(0, 129);
            // 
            // 
            // 
            this.dgvClassesList.MasterTemplate.AllowAddNewRow = false;
            this.dgvClassesList.MasterTemplate.AllowCellContextMenu = false;
            this.dgvClassesList.MasterTemplate.AllowColumnReorder = false;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ClassID";
            gridViewDecimalColumn1.HeaderText = "ClassID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "ClassID";
            gridViewDecimalColumn1.Width = 75;
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "TeacherID";
            gridViewDecimalColumn2.HeaderText = "TeacherID";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "TeacherID";
            gridViewDecimalColumn2.Width = 75;
            gridViewDecimalColumn3.DataType = typeof(int);
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "ClassNo";
            gridViewDecimalColumn3.HeaderText = "ClassNo";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.Name = "ClassNo";
            gridViewDecimalColumn3.Width = 75;
            gridViewDecimalColumn4.DataType = typeof(int);
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.FieldName = "RoomID";
            gridViewDecimalColumn4.HeaderText = "RoomID";
            gridViewDecimalColumn4.IsAutoGenerated = true;
            gridViewDecimalColumn4.Name = "RoomID";
            gridViewDecimalColumn4.Width = 75;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "InsertBy";
            gridViewTextBoxColumn1.HeaderText = "InsertBy";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "InsertBy";
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 85;
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "InsertDate";
            gridViewDateTimeColumn1.HeaderText = "InsertDate";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "InsertDate";
            gridViewDateTimeColumn1.Width = 100;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "LUB";
            gridViewTextBoxColumn2.HeaderText = "LUB";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "LUB";
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn2.Width = 85;
            gridViewDateTimeColumn2.EnableExpressionEditor = false;
            gridViewDateTimeColumn2.FieldName = "LUD";
            gridViewDateTimeColumn2.HeaderText = "LUD";
            gridViewDateTimeColumn2.IsAutoGenerated = true;
            gridViewDateTimeColumn2.Name = "LUD";
            gridViewDateTimeColumn2.Width = 100;
            gridViewDecimalColumn5.DataType = typeof(int);
            gridViewDecimalColumn5.EnableExpressionEditor = false;
            gridViewDecimalColumn5.FieldName = "LUN";
            gridViewDecimalColumn5.HeaderText = "LUN";
            gridViewDecimalColumn5.IsAutoGenerated = true;
            gridViewDecimalColumn5.Name = "LUN";
            this.dgvClassesList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewDecimalColumn4,
            gridViewTextBoxColumn1,
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn2,
            gridViewDateTimeColumn2,
            gridViewDecimalColumn5});
            this.dgvClassesList.MasterTemplate.DataSource = this.bsrcClassList;
            this.dgvClassesList.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgvClassesList.Name = "dgvClassesList";
            this.dgvClassesList.ReadOnly = true;
            this.dgvClassesList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvClassesList.Size = new System.Drawing.Size(673, 434);
            this.dgvClassesList.TabIndex = 12;
            this.dgvClassesList.ThemeName = "CrystalDark";
            // 
            // bsrcClassList
            // 
            this.bsrcClassList.DataSource = typeof(MenaxhimiDitarit.BO.Class);
            // 
            // ClassListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(673, 563);
            this.Controls.Add(this.dgvClassesList);
            this.Controls.Add(this.grbSearchClass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClassListForm";
            this.Text = "ClassListForm";
            this.Load += new System.EventHandler(this.ClassListForm_Load);
            this.grbSearchClass.ResumeLayout(false);
            this.grbSearchClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cmsClassContext.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassesList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcClassList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbSearchClass;
        private System.Windows.Forms.Button btnSearchClass;
        private System.Windows.Forms.Button btnViewAllClass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearchClass;
        private System.Windows.Forms.ContextMenuStrip cmsClassContext;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private Telerik.WinControls.Themes.CrystalDarkTheme crystalDarkTheme1;
        private Telerik.WinControls.UI.RadGridView dgvClassesList;
        private System.Windows.Forms.BindingSource bsrcClassList;
    }
}