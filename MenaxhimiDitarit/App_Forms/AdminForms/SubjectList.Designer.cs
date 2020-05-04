﻿namespace MenaxhimiDitarit
{
    partial class SubjectList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectList));
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.btnSearchSubject = new System.Windows.Forms.Button();
            this.btnViewAllSubjects = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearchSubject = new System.Windows.Forms.TextBox();
            this.crystalDarkTheme1 = new Telerik.WinControls.Themes.CrystalDarkTheme();
            this.cmsSubjectContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvSubjectList = new Telerik.WinControls.UI.RadGridView();
            this.bsrcSubjectList = new System.Windows.Forms.BindingSource(this.components);
            this.grbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cmsSubjectContext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjectList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjectList.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcSubjectList)).BeginInit();
            this.SuspendLayout();
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.btnSearchSubject);
            this.grbSearch.Controls.Add(this.btnViewAllSubjects);
            this.grbSearch.Controls.Add(this.pictureBox1);
            this.grbSearch.Controls.Add(this.panel1);
            this.grbSearch.Controls.Add(this.txtSearchSubject);
            this.grbSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSearch.ForeColor = System.Drawing.Color.White;
            this.grbSearch.Location = new System.Drawing.Point(210, 12);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Size = new System.Drawing.Size(380, 111);
            this.grbSearch.TabIndex = 0;
            this.grbSearch.TabStop = false;
            this.grbSearch.Text = "Search";
            // 
            // btnSearchSubject
            // 
            this.btnSearchSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.btnSearchSubject.FlatAppearance.BorderSize = 0;
            this.btnSearchSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnSearchSubject.Location = new System.Drawing.Point(241, 64);
            this.btnSearchSubject.Name = "btnSearchSubject";
            this.btnSearchSubject.Size = new System.Drawing.Size(120, 32);
            this.btnSearchSubject.TabIndex = 3;
            this.btnSearchSubject.Text = "Search";
            this.btnSearchSubject.UseVisualStyleBackColor = false;
            this.btnSearchSubject.Click += new System.EventHandler(this.btnSearchSubject_Click);
            // 
            // btnViewAllSubjects
            // 
            this.btnViewAllSubjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.btnViewAllSubjects.FlatAppearance.BorderSize = 0;
            this.btnViewAllSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAllSubjects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnViewAllSubjects.Location = new System.Drawing.Point(19, 64);
            this.btnViewAllSubjects.Name = "btnViewAllSubjects";
            this.btnViewAllSubjects.Size = new System.Drawing.Size(120, 32);
            this.btnViewAllSubjects.TabIndex = 2;
            this.btnViewAllSubjects.Text = "View All";
            this.btnViewAllSubjects.UseVisualStyleBackColor = false;
            this.btnViewAllSubjects.Click += new System.EventHandler(this.btnViewAllSubjects_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_search_25;
            this.pictureBox1.Location = new System.Drawing.Point(19, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 25);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panel1.Location = new System.Drawing.Point(49, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 1);
            this.panel1.TabIndex = 7;
            // 
            // txtSearchSubject
            // 
            this.txtSearchSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.txtSearchSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchSubject.ForeColor = System.Drawing.Color.White;
            this.txtSearchSubject.Location = new System.Drawing.Point(49, 31);
            this.txtSearchSubject.Name = "txtSearchSubject";
            this.txtSearchSubject.Size = new System.Drawing.Size(312, 15);
            this.txtSearchSubject.TabIndex = 0;
            this.txtSearchSubject.Text = "Search by Subject Title or Teacher Name";
            this.txtSearchSubject.Click += new System.EventHandler(this.txtSearchNameSubject_Click);
            this.txtSearchSubject.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchSubject_KeyDown);
            // 
            // cmsSubjectContext
            // 
            this.cmsSubjectContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsSubjectContext.Name = "cmsSubjectContext";
            this.cmsSubjectContext.Size = new System.Drawing.Size(113, 48);
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
            // dgvSubjectList
            // 
            this.dgvSubjectList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.dgvSubjectList.ContextMenuStrip = this.cmsSubjectContext;
            this.dgvSubjectList.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvSubjectList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSubjectList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvSubjectList.ForeColor = System.Drawing.Color.White;
            this.dgvSubjectList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvSubjectList.Location = new System.Drawing.Point(0, 137);
            // 
            // 
            // 
            this.dgvSubjectList.MasterTemplate.AllowAddNewRow = false;
            this.dgvSubjectList.MasterTemplate.AllowCellContextMenu = false;
            this.dgvSubjectList.MasterTemplate.AllowColumnReorder = false;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "SubjectID";
            gridViewDecimalColumn1.HeaderText = "SubjectID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "SubjectID";
            gridViewDecimalColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDecimalColumn1.Width = 75;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "SubjectTitle";
            gridViewTextBoxColumn1.HeaderText = "Subject Title";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "SubjectTitle";
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 100;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Book";
            gridViewTextBoxColumn2.HeaderText = "Book";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "Book";
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn2.Width = 85;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "Book_Author";
            gridViewTextBoxColumn3.HeaderText = "Book Author";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "Book_Author";
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn3.Width = 100;
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "TeacherID";
            gridViewDecimalColumn2.HeaderText = "TeacherID";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "TeacherID";
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "Teacher.FullName";
            gridViewTextBoxColumn4.HeaderText = "Teacher";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "Teacher";
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn4.Width = 150;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "InsertBy";
            gridViewTextBoxColumn5.HeaderText = "InsertBy";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "InsertBy";
            gridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn5.Width = 85;
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "InsertDate";
            gridViewDateTimeColumn1.HeaderText = "InsertDate";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "InsertDate";
            gridViewDateTimeColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDateTimeColumn1.Width = 170;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "LUB";
            gridViewTextBoxColumn6.HeaderText = "LUB";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "LUB";
            gridViewTextBoxColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn6.Width = 85;
            gridViewDateTimeColumn2.EnableExpressionEditor = false;
            gridViewDateTimeColumn2.FieldName = "LUD";
            gridViewDateTimeColumn2.HeaderText = "LUD";
            gridViewDateTimeColumn2.IsAutoGenerated = true;
            gridViewDateTimeColumn2.Name = "LUD";
            gridViewDateTimeColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDateTimeColumn2.Width = 170;
            gridViewDecimalColumn3.DataType = typeof(int);
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "LUN";
            gridViewDecimalColumn3.HeaderText = "LUN";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.Name = "LUN";
            gridViewDecimalColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.dgvSubjectList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewDecimalColumn2,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn6,
            gridViewDateTimeColumn2,
            gridViewDecimalColumn3});
            this.dgvSubjectList.MasterTemplate.DataSource = this.bsrcSubjectList;
            this.dgvSubjectList.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgvSubjectList.Name = "dgvSubjectList";
            this.dgvSubjectList.ReadOnly = true;
            this.dgvSubjectList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvSubjectList.Size = new System.Drawing.Size(800, 426);
            this.dgvSubjectList.TabIndex = 14;
            this.dgvSubjectList.ThemeName = "CrystalDark";
            // 
            // bsrcSubjectList
            // 
            this.bsrcSubjectList.DataSource = typeof(MenaxhimiDitarit.BO.Subject);
            // 
            // SubjectList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(800, 563);
            this.Controls.Add(this.dgvSubjectList);
            this.Controls.Add(this.grbSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SubjectList";
            this.Text = "Subject List";
            this.Load += new System.EventHandler(this.SubjectListForm_Load);
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cmsSubjectContext.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjectList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjectList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcSubjectList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.Button btnSearchSubject;
        private System.Windows.Forms.Button btnViewAllSubjects;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearchSubject;
        private Telerik.WinControls.Themes.CrystalDarkTheme crystalDarkTheme1;
        private System.Windows.Forms.ContextMenuStrip cmsSubjectContext;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private Telerik.WinControls.UI.RadGridView dgvSubjectList;
        private System.Windows.Forms.BindingSource bsrcSubjectList;
    }
}