﻿namespace MenaxhimiDitarit.AdminForms
{
    partial class ClassScheduletList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassScheduletList));
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn7 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn8 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn9 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn10 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn11 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn3 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn4 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn12 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.RadPrintWatermark radPrintWatermark2 = new Telerik.WinControls.UI.RadPrintWatermark();
            this.crystalDarkTheme1 = new Telerik.WinControls.Themes.CrystalDarkTheme();
            this.cmsScheduleContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvScheduleList = new Telerik.WinControls.UI.RadGridView();
            this.bsrcScheduleList = new System.Windows.Forms.BindingSource(this.components);
            this.grbSearchSchedule = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.cmbSelectDay = new System.Windows.Forms.ComboBox();
            this.lblSelectDay = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbSelectClass = new System.Windows.Forms.ComboBox();
            this.bsrcClass = new System.Windows.Forms.BindingSource(this.components);
            this.lblSelectClass = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlClassMain = new System.Windows.Forms.Panel();
            this.btnExportPDF = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.pnlPicture = new System.Windows.Forms.Panel();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.picClass = new System.Windows.Forms.PictureBox();
            this.printDocument = new Telerik.WinControls.UI.RadPrintDocument();
            this.cmsScheduleContext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduleList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduleList.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcScheduleList)).BeginInit();
            this.grbSearchSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcClass)).BeginInit();
            this.pnlClassMain.SuspendLayout();
            this.pnlPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClass)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsScheduleContext
            // 
            this.cmsScheduleContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem});
            this.cmsScheduleContext.Name = "contextMenuStrip1";
            resources.ApplyResources(this.cmsScheduleContext, "cmsScheduleContext");
            // 
            // updateToolStripMenuItem
            // 
            resources.ApplyResources(this.updateToolStripMenuItem, "updateToolStripMenuItem");
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // dgvScheduleList
            // 
            this.dgvScheduleList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.dgvScheduleList.ContextMenuStrip = this.cmsScheduleContext;
            this.dgvScheduleList.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.dgvScheduleList, "dgvScheduleList");
            this.dgvScheduleList.ForeColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.dgvScheduleList.MasterTemplate.AllowAddNewRow = false;
            this.dgvScheduleList.MasterTemplate.AllowCellContextMenu = false;
            this.dgvScheduleList.MasterTemplate.AllowColumnReorder = false;
            gridViewDecimalColumn7.DataType = typeof(int);
            gridViewDecimalColumn7.EnableExpressionEditor = false;
            gridViewDecimalColumn7.FieldName = "ScheduleID";
            resources.ApplyResources(gridViewDecimalColumn7, "gridViewDecimalColumn7");
            gridViewDecimalColumn7.IsAutoGenerated = true;
            gridViewDecimalColumn7.Name = "ScheduleID";
            gridViewDecimalColumn7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDecimalColumn7.Width = 75;
            gridViewDecimalColumn8.DataType = typeof(int);
            gridViewDecimalColumn8.EnableExpressionEditor = false;
            gridViewDecimalColumn8.FieldName = "ClassID";
            gridViewDecimalColumn8.IsAutoGenerated = true;
            gridViewDecimalColumn8.IsVisible = false;
            gridViewDecimalColumn8.Name = "ClassID";
            gridViewDecimalColumn9.DataType = typeof(int);
            gridViewDecimalColumn9.EnableExpressionEditor = false;
            gridViewDecimalColumn9.FieldName = "SubjectID";
            gridViewDecimalColumn9.IsAutoGenerated = true;
            gridViewDecimalColumn9.IsVisible = false;
            gridViewDecimalColumn9.Name = "SubjectID";
            gridViewDecimalColumn10.DataType = typeof(int);
            gridViewDecimalColumn10.EnableExpressionEditor = false;
            gridViewDecimalColumn10.FieldName = "Time";
            resources.ApplyResources(gridViewDecimalColumn10, "gridViewDecimalColumn10");
            gridViewDecimalColumn10.IsAutoGenerated = true;
            gridViewDecimalColumn10.Name = "Time";
            gridViewDecimalColumn10.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDecimalColumn10.Width = 75;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "Day";
            resources.ApplyResources(gridViewTextBoxColumn6, "gridViewTextBoxColumn6");
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "Day";
            gridViewTextBoxColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn6.Width = 90;
            gridViewDecimalColumn11.DataType = typeof(int);
            gridViewDecimalColumn11.EnableExpressionEditor = false;
            gridViewDecimalColumn11.FieldName = "Year";
            resources.ApplyResources(gridViewDecimalColumn11, "gridViewDecimalColumn11");
            gridViewDecimalColumn11.IsAutoGenerated = true;
            gridViewDecimalColumn11.Name = "Year";
            gridViewDecimalColumn11.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDecimalColumn11.Width = 75;
            gridViewTextBoxColumn7.DataType = typeof(int);
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "Class.ClassNo";
            resources.ApplyResources(gridViewTextBoxColumn7, "gridViewTextBoxColumn7");
            gridViewTextBoxColumn7.IsAutoGenerated = true;
            gridViewTextBoxColumn7.Name = "Class";
            gridViewTextBoxColumn7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn7.Width = 75;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "Subject.SubjectTitle";
            resources.ApplyResources(gridViewTextBoxColumn8, "gridViewTextBoxColumn8");
            gridViewTextBoxColumn8.IsAutoGenerated = true;
            gridViewTextBoxColumn8.Name = "Subject";
            gridViewTextBoxColumn8.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn8.Width = 100;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "InsertBy";
            gridViewTextBoxColumn9.IsAutoGenerated = true;
            gridViewTextBoxColumn9.IsVisible = false;
            gridViewTextBoxColumn9.Name = "InsertBy";
            gridViewTextBoxColumn9.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn9.Width = 85;
            gridViewDateTimeColumn3.EnableExpressionEditor = false;
            gridViewDateTimeColumn3.FieldName = "InsertDate";
            gridViewDateTimeColumn3.IsAutoGenerated = true;
            gridViewDateTimeColumn3.IsVisible = false;
            gridViewDateTimeColumn3.Name = "InsertDate";
            gridViewDateTimeColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDateTimeColumn3.Width = 170;
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.FieldName = "LUB";
            gridViewTextBoxColumn10.IsAutoGenerated = true;
            gridViewTextBoxColumn10.IsVisible = false;
            gridViewTextBoxColumn10.Name = "LUB";
            gridViewTextBoxColumn10.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn10.Width = 85;
            gridViewDateTimeColumn4.EnableExpressionEditor = false;
            gridViewDateTimeColumn4.FieldName = "LUD";
            gridViewDateTimeColumn4.IsAutoGenerated = true;
            gridViewDateTimeColumn4.IsVisible = false;
            gridViewDateTimeColumn4.Name = "LUD";
            gridViewDateTimeColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDateTimeColumn4.Width = 170;
            gridViewDecimalColumn12.DataType = typeof(int);
            gridViewDecimalColumn12.EnableExpressionEditor = false;
            gridViewDecimalColumn12.FieldName = "LUN";
            gridViewDecimalColumn12.IsAutoGenerated = true;
            gridViewDecimalColumn12.IsVisible = false;
            gridViewDecimalColumn12.Name = "LUN";
            gridViewDecimalColumn12.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.dgvScheduleList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn7,
            gridViewDecimalColumn8,
            gridViewDecimalColumn9,
            gridViewDecimalColumn10,
            gridViewTextBoxColumn6,
            gridViewDecimalColumn11,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewDateTimeColumn3,
            gridViewTextBoxColumn10,
            gridViewDateTimeColumn4,
            gridViewDecimalColumn12});
            this.dgvScheduleList.MasterTemplate.DataSource = this.bsrcScheduleList;
            this.dgvScheduleList.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.dgvScheduleList.Name = "dgvScheduleList";
            this.dgvScheduleList.ReadOnly = true;
            this.dgvScheduleList.ThemeName = "CrystalDark";
            // 
            // bsrcScheduleList
            // 
            this.bsrcScheduleList.DataSource = typeof(MenaxhimiDitarit.BO.ClassSchedule);
            // 
            // grbSearchSchedule
            // 
            this.grbSearchSchedule.Controls.Add(this.btnSearch);
            this.grbSearchSchedule.Controls.Add(this.btnViewAll);
            this.grbSearchSchedule.Controls.Add(this.cmbSelectDay);
            this.grbSearchSchedule.Controls.Add(this.lblSelectDay);
            this.grbSearchSchedule.Controls.Add(this.panel2);
            this.grbSearchSchedule.Controls.Add(this.cmbSelectClass);
            this.grbSearchSchedule.Controls.Add(this.lblSelectClass);
            this.grbSearchSchedule.Controls.Add(this.panel3);
            resources.ApplyResources(this.grbSearchSchedule, "grbSearchSchedule");
            this.grbSearchSchedule.ForeColor = System.Drawing.Color.White;
            this.grbSearchSchedule.Name = "grbSearchSchedule";
            this.grbSearchSchedule.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.btnViewAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewAll.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnViewAll, "btnViewAll");
            this.btnViewAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click_1);
            // 
            // cmbSelectDay
            // 
            this.cmbSelectDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            resources.ApplyResources(this.cmbSelectDay, "cmbSelectDay");
            this.cmbSelectDay.ForeColor = System.Drawing.Color.White;
            this.cmbSelectDay.FormattingEnabled = true;
            this.cmbSelectDay.Items.AddRange(new object[] {
            resources.GetString("cmbSelectDay.Items"),
            resources.GetString("cmbSelectDay.Items1"),
            resources.GetString("cmbSelectDay.Items2"),
            resources.GetString("cmbSelectDay.Items3"),
            resources.GetString("cmbSelectDay.Items4")});
            this.cmbSelectDay.Name = "cmbSelectDay";
            // 
            // lblSelectDay
            // 
            resources.ApplyResources(this.lblSelectDay, "lblSelectDay");
            this.lblSelectDay.ForeColor = System.Drawing.Color.White;
            this.lblSelectDay.Name = "lblSelectDay";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // cmbSelectClass
            // 
            this.cmbSelectClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.cmbSelectClass.DataSource = this.bsrcClass;
            this.cmbSelectClass.DisplayMember = "ClassNo";
            resources.ApplyResources(this.cmbSelectClass, "cmbSelectClass");
            this.cmbSelectClass.ForeColor = System.Drawing.Color.White;
            this.cmbSelectClass.FormattingEnabled = true;
            this.cmbSelectClass.Name = "cmbSelectClass";
            this.cmbSelectClass.ValueMember = "ClassID";
            // 
            // bsrcClass
            // 
            this.bsrcClass.DataSource = typeof(MenaxhimiDitarit.BO.Class);
            // 
            // lblSelectClass
            // 
            resources.ApplyResources(this.lblSelectClass, "lblSelectClass");
            this.lblSelectClass.ForeColor = System.Drawing.Color.White;
            this.lblSelectClass.Name = "lblSelectClass";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // pnlClassMain
            // 
            this.pnlClassMain.Controls.Add(this.btnExportPDF);
            this.pnlClassMain.Controls.Add(this.btnExportExcel);
            this.pnlClassMain.Controls.Add(this.btnPrint);
            this.pnlClassMain.Controls.Add(this.btnUpdate);
            this.pnlClassMain.Controls.Add(this.btnAddClass);
            this.pnlClassMain.Controls.Add(this.pnlPicture);
            resources.ApplyResources(this.pnlClassMain, "pnlClassMain");
            this.pnlClassMain.Name = "pnlClassMain";
            // 
            // btnExportPDF
            // 
            resources.ApplyResources(this.btnExportPDF, "btnExportPDF");
            this.btnExportPDF.FlatAppearance.BorderSize = 0;
            this.btnExportPDF.ForeColor = System.Drawing.Color.White;
            this.btnExportPDF.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_export_pdf_20;
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.UseVisualStyleBackColor = true;
            this.btnExportPDF.Click += new System.EventHandler(this.btnExportPDF_Click);
            // 
            // btnExportExcel
            // 
            resources.ApplyResources(this.btnExportExcel, "btnExportExcel");
            this.btnExportExcel.FlatAppearance.BorderSize = 0;
            this.btnExportExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportExcel.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_microsoft_excel_20;
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnPrint
            // 
            resources.ApplyResources(this.btnPrint, "btnPrint");
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_print_20;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnUpdate
            // 
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_update_left_rotation_20;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddClass
            // 
            resources.ApplyResources(this.btnAddClass, "btnAddClass");
            this.btnAddClass.FlatAppearance.BorderSize = 0;
            this.btnAddClass.ForeColor = System.Drawing.Color.White;
            this.btnAddClass.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_add_new_20;
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // pnlPicture
            // 
            this.pnlPicture.Controls.Add(this.lblSchedule);
            this.pnlPicture.Controls.Add(this.picClass);
            resources.ApplyResources(this.pnlPicture, "pnlPicture");
            this.pnlPicture.Name = "pnlPicture";
            // 
            // lblSchedule
            // 
            resources.ApplyResources(this.lblSchedule, "lblSchedule");
            this.lblSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.lblSchedule.Name = "lblSchedule";
            // 
            // picClass
            // 
            this.picClass.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_schedule_100;
            resources.ApplyResources(this.picClass, "picClass");
            this.picClass.Name = "picClass";
            this.picClass.TabStop = false;
            // 
            // printDocument
            // 
            this.printDocument.FooterFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printDocument.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printDocument.Watermark = radPrintWatermark2;
            // 
            // ClassScheduletList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.Controls.Add(this.pnlClassMain);
            this.Controls.Add(this.dgvScheduleList);
            this.Controls.Add(this.grbSearchSchedule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClassScheduletList";
            this.Load += new System.EventHandler(this.ClassScheduletList_Load_1);
            this.cmsScheduleContext.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduleList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduleList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcScheduleList)).EndInit();
            this.grbSearchSchedule.ResumeLayout(false);
            this.grbSearchSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcClass)).EndInit();
            this.pnlClassMain.ResumeLayout(false);
            this.pnlClassMain.PerformLayout();
            this.pnlPicture.ResumeLayout(false);
            this.pnlPicture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.Themes.CrystalDarkTheme crystalDarkTheme1;
        private System.Windows.Forms.ContextMenuStrip cmsScheduleContext;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private Telerik.WinControls.UI.RadGridView dgvScheduleList;
        private System.Windows.Forms.GroupBox grbSearchSchedule;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.ComboBox cmbSelectDay;
        private System.Windows.Forms.Label lblSelectDay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbSelectClass;
        private System.Windows.Forms.Label lblSelectClass;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.BindingSource bsrcClass;
        private System.Windows.Forms.BindingSource bsrcScheduleList;
        private System.Windows.Forms.Panel pnlClassMain;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.Panel pnlPicture;
        private System.Windows.Forms.Label lblSchedule;
        private System.Windows.Forms.PictureBox picClass;
        private System.Windows.Forms.Button btnExportPDF;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnPrint;
        private Telerik.WinControls.UI.RadPrintDocument printDocument;
    }
}