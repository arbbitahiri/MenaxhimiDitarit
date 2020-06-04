namespace MenaxhimiDitarit.TeacherForms
{
    partial class AbsenceList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbsenceList));
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn49 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn50 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn51 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn25 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn52 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn49 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn50 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn53 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn51 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn52 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn53 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn26 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn54 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn27 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn54 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition9 = new Telerik.WinControls.UI.TableViewDefinition();
            this.dgvAbsenceList = new Telerik.WinControls.UI.RadGridView();
            this.cmsAbsence = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bsrcTopicAbsence = new System.Windows.Forms.BindingSource(this.components);
            this.crystalDarkTheme1 = new Telerik.WinControls.Themes.CrystalDarkTheme();
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.dtpSelectDay = new System.Windows.Forms.DateTimePicker();
            this.cmbSelectSubject = new System.Windows.Forms.ComboBox();
            this.lblSelectSubject = new System.Windows.Forms.Label();
            this.lblSelectDay = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlAbsenceMain = new System.Windows.Forms.Panel();
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
            this.btnAddComment = new System.Windows.Forms.Button();
            this.pnlPicture = new System.Windows.Forms.Panel();
            this.lblAbsence = new System.Windows.Forms.Label();
            this.picClass = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsenceList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsenceList.MasterTemplate)).BeginInit();
            this.cmsAbsence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcTopicAbsence)).BeginInit();
            this.grbSearch.SuspendLayout();
            this.pnlAbsenceMain.SuspendLayout();
            this.pnlExport.SuspendLayout();
            this.pnlPrint.SuspendLayout();
            this.pnlPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClass)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAbsenceList
            // 
            this.dgvAbsenceList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.dgvAbsenceList.ContextMenuStrip = this.cmsAbsence;
            this.dgvAbsenceList.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.dgvAbsenceList, "dgvAbsenceList");
            this.dgvAbsenceList.ForeColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.dgvAbsenceList.MasterTemplate.AllowAddNewRow = false;
            this.dgvAbsenceList.MasterTemplate.AllowCellContextMenu = false;
            this.dgvAbsenceList.MasterTemplate.AllowColumnReorder = false;
            gridViewDecimalColumn49.DataType = typeof(int);
            gridViewDecimalColumn49.EnableExpressionEditor = false;
            gridViewDecimalColumn49.FieldName = "TopicID";
            resources.ApplyResources(gridViewDecimalColumn49, "gridViewDecimalColumn49");
            gridViewDecimalColumn49.IsAutoGenerated = true;
            gridViewDecimalColumn49.Name = "TopicID";
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
            gridViewDateTimeColumn25.EnableExpressionEditor = false;
            gridViewDateTimeColumn25.FieldName = "Date";
            resources.ApplyResources(gridViewDateTimeColumn25, "gridViewDateTimeColumn25");
            gridViewDateTimeColumn25.IsAutoGenerated = true;
            gridViewDateTimeColumn25.Name = "Date";
            gridViewDateTimeColumn25.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDateTimeColumn25.Width = 165;
            gridViewDecimalColumn52.DataType = typeof(int);
            gridViewDecimalColumn52.EnableExpressionEditor = false;
            gridViewDecimalColumn52.FieldName = "Time";
            resources.ApplyResources(gridViewDecimalColumn52, "gridViewDecimalColumn52");
            gridViewDecimalColumn52.IsAutoGenerated = true;
            gridViewDecimalColumn52.Name = "Time";
            gridViewDecimalColumn52.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDecimalColumn52.Width = 75;
            gridViewTextBoxColumn49.EnableExpressionEditor = false;
            gridViewTextBoxColumn49.FieldName = "Content";
            gridViewTextBoxColumn49.IsAutoGenerated = true;
            gridViewTextBoxColumn49.IsVisible = false;
            gridViewTextBoxColumn49.Name = "Content";
            gridViewTextBoxColumn50.EnableExpressionEditor = false;
            gridViewTextBoxColumn50.FieldName = "Reasoning";
            resources.ApplyResources(gridViewTextBoxColumn50, "gridViewTextBoxColumn50");
            gridViewTextBoxColumn50.IsAutoGenerated = true;
            gridViewTextBoxColumn50.Name = "Reasoning";
            gridViewTextBoxColumn50.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn50.Width = 100;
            gridViewDecimalColumn53.DataType = typeof(int);
            gridViewDecimalColumn53.EnableExpressionEditor = false;
            gridViewDecimalColumn53.FieldName = "NoStudents";
            resources.ApplyResources(gridViewDecimalColumn53, "gridViewDecimalColumn53");
            gridViewDecimalColumn53.IsAutoGenerated = true;
            gridViewDecimalColumn53.Name = "NoStudents";
            gridViewDecimalColumn53.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDecimalColumn53.Width = 85;
            gridViewTextBoxColumn51.DataType = typeof(MenaxhimiDitarit.BO.Class);
            gridViewTextBoxColumn51.EnableExpressionEditor = false;
            gridViewTextBoxColumn51.FieldName = "Class";
            resources.ApplyResources(gridViewTextBoxColumn51, "gridViewTextBoxColumn51");
            gridViewTextBoxColumn51.IsAutoGenerated = true;
            gridViewTextBoxColumn51.Name = "Class";
            gridViewTextBoxColumn51.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn51.Width = 75;
            gridViewTextBoxColumn52.DataType = typeof(MenaxhimiDitarit.BO.Subject);
            gridViewTextBoxColumn52.EnableExpressionEditor = false;
            gridViewTextBoxColumn52.FieldName = "Subject";
            resources.ApplyResources(gridViewTextBoxColumn52, "gridViewTextBoxColumn52");
            gridViewTextBoxColumn52.IsAutoGenerated = true;
            gridViewTextBoxColumn52.Name = "Subject";
            gridViewTextBoxColumn52.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn52.Width = 100;
            gridViewTextBoxColumn53.EnableExpressionEditor = false;
            gridViewTextBoxColumn53.FieldName = "InsertBy";
            gridViewTextBoxColumn53.IsAutoGenerated = true;
            gridViewTextBoxColumn53.IsVisible = false;
            gridViewTextBoxColumn53.Name = "InsertBy";
            gridViewTextBoxColumn53.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn53.Width = 85;
            gridViewDateTimeColumn26.EnableExpressionEditor = false;
            gridViewDateTimeColumn26.FieldName = "InsertDate";
            gridViewDateTimeColumn26.IsAutoGenerated = true;
            gridViewDateTimeColumn26.IsVisible = false;
            gridViewDateTimeColumn26.Name = "InsertDate";
            gridViewDateTimeColumn26.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDateTimeColumn26.Width = 150;
            gridViewTextBoxColumn54.EnableExpressionEditor = false;
            gridViewTextBoxColumn54.FieldName = "LUB";
            gridViewTextBoxColumn54.IsAutoGenerated = true;
            gridViewTextBoxColumn54.IsVisible = false;
            gridViewTextBoxColumn54.Name = "LUB";
            gridViewTextBoxColumn54.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn54.Width = 85;
            gridViewDateTimeColumn27.EnableExpressionEditor = false;
            gridViewDateTimeColumn27.FieldName = "LUD";
            gridViewDateTimeColumn27.IsAutoGenerated = true;
            gridViewDateTimeColumn27.IsVisible = false;
            gridViewDateTimeColumn27.Name = "LUD";
            gridViewDateTimeColumn27.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDateTimeColumn27.Width = 150;
            gridViewDecimalColumn54.DataType = typeof(int);
            gridViewDecimalColumn54.EnableExpressionEditor = false;
            gridViewDecimalColumn54.FieldName = "LUN";
            gridViewDecimalColumn54.IsAutoGenerated = true;
            gridViewDecimalColumn54.IsVisible = false;
            gridViewDecimalColumn54.Name = "LUN";
            gridViewDecimalColumn54.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.dgvAbsenceList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn49,
            gridViewDecimalColumn50,
            gridViewDecimalColumn51,
            gridViewDateTimeColumn25,
            gridViewDecimalColumn52,
            gridViewTextBoxColumn49,
            gridViewTextBoxColumn50,
            gridViewDecimalColumn53,
            gridViewTextBoxColumn51,
            gridViewTextBoxColumn52,
            gridViewTextBoxColumn53,
            gridViewDateTimeColumn26,
            gridViewTextBoxColumn54,
            gridViewDateTimeColumn27,
            gridViewDecimalColumn54});
            this.dgvAbsenceList.MasterTemplate.DataSource = this.bsrcTopicAbsence;
            this.dgvAbsenceList.MasterTemplate.ViewDefinition = tableViewDefinition9;
            this.dgvAbsenceList.Name = "dgvAbsenceList";
            this.dgvAbsenceList.ReadOnly = true;
            this.dgvAbsenceList.ThemeName = "CrystalDark";
            // 
            // cmsAbsence
            // 
            this.cmsAbsence.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem});
            this.cmsAbsence.Name = "cmsAbsence";
            resources.ApplyResources(this.cmsAbsence, "cmsAbsence");
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_update_20__1_;
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            resources.ApplyResources(this.updateToolStripMenuItem, "updateToolStripMenuItem");
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // bsrcTopicAbsence
            // 
            this.bsrcTopicAbsence.DataSource = typeof(MenaxhimiDitarit.BO.Topic);
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.btnSearch);
            this.grbSearch.Controls.Add(this.btnViewAll);
            this.grbSearch.Controls.Add(this.dtpSelectDay);
            this.grbSearch.Controls.Add(this.cmbSelectSubject);
            this.grbSearch.Controls.Add(this.lblSelectSubject);
            this.grbSearch.Controls.Add(this.lblSelectDay);
            this.grbSearch.Controls.Add(this.panel1);
            this.grbSearch.Controls.Add(this.panel3);
            resources.ApplyResources(this.grbSearch, "grbSearch");
            this.grbSearch.ForeColor = System.Drawing.Color.White;
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.TabStop = false;
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
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // dtpSelectDay
            // 
            resources.ApplyResources(this.dtpSelectDay, "dtpSelectDay");
            this.dtpSelectDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSelectDay.Name = "dtpSelectDay";
            // 
            // cmbSelectSubject
            // 
            this.cmbSelectSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            resources.ApplyResources(this.cmbSelectSubject, "cmbSelectSubject");
            this.cmbSelectSubject.ForeColor = System.Drawing.Color.White;
            this.cmbSelectSubject.FormattingEnabled = true;
            this.cmbSelectSubject.Name = "cmbSelectSubject";
            // 
            // lblSelectSubject
            // 
            resources.ApplyResources(this.lblSelectSubject, "lblSelectSubject");
            this.lblSelectSubject.ForeColor = System.Drawing.Color.White;
            this.lblSelectSubject.Name = "lblSelectSubject";
            // 
            // lblSelectDay
            // 
            resources.ApplyResources(this.lblSelectDay, "lblSelectDay");
            this.lblSelectDay.ForeColor = System.Drawing.Color.White;
            this.lblSelectDay.Name = "lblSelectDay";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // pnlAbsenceMain
            // 
            this.pnlAbsenceMain.Controls.Add(this.pnlExport);
            this.pnlAbsenceMain.Controls.Add(this.btnExport);
            this.pnlAbsenceMain.Controls.Add(this.pnlPrint);
            this.pnlAbsenceMain.Controls.Add(this.btnPrintM);
            this.pnlAbsenceMain.Controls.Add(this.btnUpdate);
            this.pnlAbsenceMain.Controls.Add(this.btnAddComment);
            this.pnlAbsenceMain.Controls.Add(this.pnlPicture);
            resources.ApplyResources(this.pnlAbsenceMain, "pnlAbsenceMain");
            this.pnlAbsenceMain.Name = "pnlAbsenceMain";
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
            // btnAddComment
            // 
            resources.ApplyResources(this.btnAddComment, "btnAddComment");
            this.btnAddComment.FlatAppearance.BorderSize = 0;
            this.btnAddComment.ForeColor = System.Drawing.Color.White;
            this.btnAddComment.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_add_new_20;
            this.btnAddComment.Name = "btnAddComment";
            this.btnAddComment.UseVisualStyleBackColor = true;
            this.btnAddComment.Click += new System.EventHandler(this.btnAddComment_Click);
            // 
            // pnlPicture
            // 
            this.pnlPicture.Controls.Add(this.lblAbsence);
            this.pnlPicture.Controls.Add(this.picClass);
            resources.ApplyResources(this.pnlPicture, "pnlPicture");
            this.pnlPicture.Name = "pnlPicture";
            // 
            // lblAbsence
            // 
            resources.ApplyResources(this.lblAbsence, "lblAbsence");
            this.lblAbsence.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.lblAbsence.Name = "lblAbsence";
            // 
            // picClass
            // 
            this.picClass.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_report_card_100;
            resources.ApplyResources(this.picClass, "picClass");
            this.picClass.Name = "picClass";
            this.picClass.TabStop = false;
            // 
            // AbsenceList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.Controls.Add(this.pnlAbsenceMain);
            this.Controls.Add(this.grbSearch);
            this.Controls.Add(this.dgvAbsenceList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AbsenceList";
            this.Load += new System.EventHandler(this.AbsenceList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsenceList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsenceList)).EndInit();
            this.cmsAbsence.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsrcTopicAbsence)).EndInit();
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            this.pnlAbsenceMain.ResumeLayout(false);
            this.pnlAbsenceMain.PerformLayout();
            this.pnlExport.ResumeLayout(false);
            this.pnlPrint.ResumeLayout(false);
            this.pnlPicture.ResumeLayout(false);
            this.pnlPicture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadGridView dgvAbsenceList;
        private Telerik.WinControls.Themes.CrystalDarkTheme crystalDarkTheme1;
        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.DateTimePicker dtpSelectDay;
        private System.Windows.Forms.ComboBox cmbSelectSubject;
        private System.Windows.Forms.Label lblSelectSubject;
        private System.Windows.Forms.Label lblSelectDay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ContextMenuStrip cmsAbsence;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.BindingSource bsrcTopicAbsence;
        private System.Windows.Forms.Panel pnlAbsenceMain;
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
        private System.Windows.Forms.Button btnAddComment;
        private System.Windows.Forms.Panel pnlPicture;
        private System.Windows.Forms.Label lblAbsence;
        private System.Windows.Forms.PictureBox picClass;
    }
}