namespace MenaxhimiDitarit.AdminForms
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn49 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn50 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn51 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn52 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn41 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn53 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn42 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn43 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn44 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn17 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn45 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn18 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn54 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition9 = new Telerik.WinControls.UI.TableViewDefinition();
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
            this.pnlExport = new System.Windows.Forms.Panel();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.pnlPrint = new System.Windows.Forms.Panel();
            this.btnPrintSettings = new System.Windows.Forms.Button();
            this.btnPrintPreview = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnPrintM = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.pnlPicture = new System.Windows.Forms.Panel();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.picClass = new System.Windows.Forms.PictureBox();
            this.cmsScheduleContext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduleList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduleList.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcScheduleList)).BeginInit();
            this.grbSearchSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcClass)).BeginInit();
            this.pnlClassMain.SuspendLayout();
            this.pnlExport.SuspendLayout();
            this.pnlPrint.SuspendLayout();
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
            gridViewDecimalColumn49.DataType = typeof(int);
            gridViewDecimalColumn49.EnableExpressionEditor = false;
            gridViewDecimalColumn49.FieldName = "ScheduleID";
            resources.ApplyResources(gridViewDecimalColumn49, "gridViewDecimalColumn49");
            gridViewDecimalColumn49.IsAutoGenerated = true;
            gridViewDecimalColumn49.Name = "ScheduleID";
            gridViewDecimalColumn49.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDecimalColumn49.Width = 75;
            gridViewDecimalColumn50.DataType = typeof(int);
            gridViewDecimalColumn50.EnableExpressionEditor = false;
            gridViewDecimalColumn50.FieldName = "ClassID";
            gridViewDecimalColumn50.IsAutoGenerated = true;
            gridViewDecimalColumn50.IsVisible = false;
            gridViewDecimalColumn50.Name = "ClassID";
            gridViewDecimalColumn51.DataType = typeof(int);
            gridViewDecimalColumn51.EnableExpressionEditor = false;
            gridViewDecimalColumn51.FieldName = "SubjectID";
            gridViewDecimalColumn51.IsAutoGenerated = true;
            gridViewDecimalColumn51.IsVisible = false;
            gridViewDecimalColumn51.Name = "SubjectID";
            gridViewDecimalColumn52.DataType = typeof(int);
            gridViewDecimalColumn52.EnableExpressionEditor = false;
            gridViewDecimalColumn52.FieldName = "Time";
            resources.ApplyResources(gridViewDecimalColumn52, "gridViewDecimalColumn52");
            gridViewDecimalColumn52.IsAutoGenerated = true;
            gridViewDecimalColumn52.Name = "Time";
            gridViewDecimalColumn52.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn41.EnableExpressionEditor = false;
            gridViewTextBoxColumn41.FieldName = "Day";
            resources.ApplyResources(gridViewTextBoxColumn41, "gridViewTextBoxColumn41");
            gridViewTextBoxColumn41.IsAutoGenerated = true;
            gridViewTextBoxColumn41.Name = "Day";
            gridViewTextBoxColumn41.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn41.Width = 85;
            gridViewDecimalColumn53.DataType = typeof(int);
            gridViewDecimalColumn53.EnableExpressionEditor = false;
            gridViewDecimalColumn53.FieldName = "Year";
            resources.ApplyResources(gridViewDecimalColumn53, "gridViewDecimalColumn53");
            gridViewDecimalColumn53.IsAutoGenerated = true;
            gridViewDecimalColumn53.Name = "Year";
            gridViewDecimalColumn53.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn42.DataType = typeof(int);
            gridViewTextBoxColumn42.EnableExpressionEditor = false;
            gridViewTextBoxColumn42.FieldName = "Class.ClassNo";
            resources.ApplyResources(gridViewTextBoxColumn42, "gridViewTextBoxColumn42");
            gridViewTextBoxColumn42.IsAutoGenerated = true;
            gridViewTextBoxColumn42.Name = "Class";
            gridViewTextBoxColumn42.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn43.EnableExpressionEditor = false;
            gridViewTextBoxColumn43.FieldName = "Subject.SubjectTitle";
            resources.ApplyResources(gridViewTextBoxColumn43, "gridViewTextBoxColumn43");
            gridViewTextBoxColumn43.IsAutoGenerated = true;
            gridViewTextBoxColumn43.Name = "Subject";
            gridViewTextBoxColumn43.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn43.Width = 100;
            gridViewTextBoxColumn44.EnableExpressionEditor = false;
            gridViewTextBoxColumn44.FieldName = "InsertBy";
            resources.ApplyResources(gridViewTextBoxColumn44, "gridViewTextBoxColumn44");
            gridViewTextBoxColumn44.IsAutoGenerated = true;
            gridViewTextBoxColumn44.Name = "InsertBy";
            gridViewTextBoxColumn44.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn44.Width = 85;
            gridViewDateTimeColumn17.EnableExpressionEditor = false;
            gridViewDateTimeColumn17.FieldName = "InsertDate";
            resources.ApplyResources(gridViewDateTimeColumn17, "gridViewDateTimeColumn17");
            gridViewDateTimeColumn17.IsAutoGenerated = true;
            gridViewDateTimeColumn17.Name = "InsertDate";
            gridViewDateTimeColumn17.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDateTimeColumn17.Width = 170;
            gridViewTextBoxColumn45.EnableExpressionEditor = false;
            gridViewTextBoxColumn45.FieldName = "LUB";
            resources.ApplyResources(gridViewTextBoxColumn45, "gridViewTextBoxColumn45");
            gridViewTextBoxColumn45.IsAutoGenerated = true;
            gridViewTextBoxColumn45.Name = "LUB";
            gridViewTextBoxColumn45.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn45.Width = 85;
            gridViewDateTimeColumn18.EnableExpressionEditor = false;
            gridViewDateTimeColumn18.FieldName = "LUD";
            resources.ApplyResources(gridViewDateTimeColumn18, "gridViewDateTimeColumn18");
            gridViewDateTimeColumn18.IsAutoGenerated = true;
            gridViewDateTimeColumn18.Name = "LUD";
            gridViewDateTimeColumn18.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDateTimeColumn18.Width = 170;
            gridViewDecimalColumn54.DataType = typeof(int);
            gridViewDecimalColumn54.EnableExpressionEditor = false;
            gridViewDecimalColumn54.FieldName = "LUN";
            resources.ApplyResources(gridViewDecimalColumn54, "gridViewDecimalColumn54");
            gridViewDecimalColumn54.IsAutoGenerated = true;
            gridViewDecimalColumn54.Name = "LUN";
            gridViewDecimalColumn54.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.dgvScheduleList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn49,
            gridViewDecimalColumn50,
            gridViewDecimalColumn51,
            gridViewDecimalColumn52,
            gridViewTextBoxColumn41,
            gridViewDecimalColumn53,
            gridViewTextBoxColumn42,
            gridViewTextBoxColumn43,
            gridViewTextBoxColumn44,
            gridViewDateTimeColumn17,
            gridViewTextBoxColumn45,
            gridViewDateTimeColumn18,
            gridViewDecimalColumn54});
            this.dgvScheduleList.MasterTemplate.DataSource = this.bsrcScheduleList;
            this.dgvScheduleList.MasterTemplate.ViewDefinition = tableViewDefinition9;
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
            this.pnlClassMain.Controls.Add(this.pnlExport);
            this.pnlClassMain.Controls.Add(this.btnExport);
            this.pnlClassMain.Controls.Add(this.pnlPrint);
            this.pnlClassMain.Controls.Add(this.btnPrintM);
            this.pnlClassMain.Controls.Add(this.btnUpdate);
            this.pnlClassMain.Controls.Add(this.btnAddClass);
            this.pnlClassMain.Controls.Add(this.pnlPicture);
            resources.ApplyResources(this.pnlClassMain, "pnlClassMain");
            this.pnlClassMain.Name = "pnlClassMain";
            // 
            // pnlExport
            // 
            this.pnlExport.Controls.Add(this.btnPDF);
            this.pnlExport.Controls.Add(this.btnExcel);
            resources.ApplyResources(this.pnlExport, "pnlExport");
            this.pnlExport.Name = "pnlExport";
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            resources.ApplyResources(this.btnPDF, "btnPDF");
            this.btnPDF.FlatAppearance.BorderSize = 0;
            this.btnPDF.ForeColor = System.Drawing.Color.White;
            this.btnPDF.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_export_pdf_20;
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            resources.ApplyResources(this.btnExcel, "btnExcel");
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_microsoft_excel_20;
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnExport
            // 
            resources.ApplyResources(this.btnExport, "btnExport");
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Name = "btnExport";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // pnlPrint
            // 
            this.pnlPrint.Controls.Add(this.btnPrintSettings);
            this.pnlPrint.Controls.Add(this.btnPrintPreview);
            this.pnlPrint.Controls.Add(this.btnPrint);
            resources.ApplyResources(this.pnlPrint, "pnlPrint");
            this.pnlPrint.Name = "pnlPrint";
            // 
            // btnPrintSettings
            // 
            this.btnPrintSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            resources.ApplyResources(this.btnPrintSettings, "btnPrintSettings");
            this.btnPrintSettings.FlatAppearance.BorderSize = 0;
            this.btnPrintSettings.ForeColor = System.Drawing.Color.White;
            this.btnPrintSettings.Name = "btnPrintSettings";
            this.btnPrintSettings.UseVisualStyleBackColor = false;
            this.btnPrintSettings.Click += new System.EventHandler(this.btnPrintSettings_Click);
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            resources.ApplyResources(this.btnPrintPreview, "btnPrintPreview");
            this.btnPrintPreview.FlatAppearance.BorderSize = 0;
            this.btnPrintPreview.ForeColor = System.Drawing.Color.White;
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.UseVisualStyleBackColor = false;
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            resources.ApplyResources(this.btnPrint, "btnPrint");
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPrintM
            // 
            resources.ApplyResources(this.btnPrintM, "btnPrintM");
            this.btnPrintM.FlatAppearance.BorderSize = 0;
            this.btnPrintM.ForeColor = System.Drawing.Color.White;
            this.btnPrintM.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_print_20;
            this.btnPrintM.Name = "btnPrintM";
            this.btnPrintM.UseVisualStyleBackColor = true;
            this.btnPrintM.Click += new System.EventHandler(this.btnPrintM_Click);
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
            this.pnlExport.ResumeLayout(false);
            this.pnlPrint.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnlExport;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Panel pnlPrint;
        private System.Windows.Forms.Button btnPrintSettings;
        private System.Windows.Forms.Button btnPrintPreview;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnPrintM;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.Panel pnlPicture;
        private System.Windows.Forms.Label lblSchedule;
        private System.Windows.Forms.PictureBox picClass;
    }
}