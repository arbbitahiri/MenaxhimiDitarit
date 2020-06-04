namespace MenaxhimiDitarit
{
    partial class TeacherList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherList));
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn23 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn100 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn101 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn102 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn103 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn104 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn34 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn105 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn106 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn107 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn35 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn108 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn36 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn24 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition12 = new Telerik.WinControls.UI.TableViewDefinition();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.btnSearchTeachers = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.crystalDarkTheme1 = new Telerik.WinControls.Themes.CrystalDarkTheme();
            this.cmsTeacherContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvTeacherList = new Telerik.WinControls.UI.RadGridView();
            this.bsrcTeacherList = new System.Windows.Forms.BindingSource(this.components);
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
            this.lblTeacher = new System.Windows.Forms.Label();
            this.picClass = new System.Windows.Forms.PictureBox();
            this.grbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cmsTeacherContext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherList.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcTeacherList)).BeginInit();
            this.pnlClassMain.SuspendLayout();
            this.pnlExport.SuspendLayout();
            this.pnlPrint.SuspendLayout();
            this.pnlPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClass)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // txtSearchName
            // 
            this.txtSearchName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.txtSearchName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtSearchName, "txtSearchName");
            this.txtSearchName.ForeColor = System.Drawing.Color.White;
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Click += new System.EventHandler(this.txtSearchName_Click);
            this.txtSearchName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchName_KeyDown);
            this.txtSearchName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchName_KeyPress);
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.btnSearchTeachers);
            this.grbSearch.Controls.Add(this.btnViewAll);
            this.grbSearch.Controls.Add(this.pictureBox1);
            this.grbSearch.Controls.Add(this.panel1);
            this.grbSearch.Controls.Add(this.txtSearchName);
            this.grbSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.grbSearch, "grbSearch");
            this.grbSearch.ForeColor = System.Drawing.Color.White;
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.TabStop = false;
            // 
            // btnSearchTeachers
            // 
            this.btnSearchTeachers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.btnSearchTeachers.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnSearchTeachers, "btnSearchTeachers");
            this.btnSearchTeachers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnSearchTeachers.Name = "btnSearchTeachers";
            this.btnSearchTeachers.UseVisualStyleBackColor = false;
            this.btnSearchTeachers.Click += new System.EventHandler(this.btnSearchTeachers_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.btnViewAll.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnViewAll, "btnViewAll");
            this.btnViewAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAllTeachers_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_search_25;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // cmsTeacherContext
            // 
            this.cmsTeacherContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.cmsTeacherContext.Name = "cmsTeacherContext";
            resources.ApplyResources(this.cmsTeacherContext, "cmsTeacherContext");
            // 
            // updateToolStripMenuItem
            // 
            resources.ApplyResources(this.updateToolStripMenuItem, "updateToolStripMenuItem");
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            resources.ApplyResources(this.exportToolStripMenuItem, "exportToolStripMenuItem");
            // 
            // dgvTeacherList
            // 
            this.dgvTeacherList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.dgvTeacherList.ContextMenuStrip = this.cmsTeacherContext;
            this.dgvTeacherList.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.dgvTeacherList, "dgvTeacherList");
            this.dgvTeacherList.ForeColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.dgvTeacherList.MasterTemplate.AllowAddNewRow = false;
            this.dgvTeacherList.MasterTemplate.AllowCellContextMenu = false;
            this.dgvTeacherList.MasterTemplate.AllowColumnReorder = false;
            gridViewDecimalColumn23.DataType = typeof(int);
            gridViewDecimalColumn23.EnableExpressionEditor = false;
            gridViewDecimalColumn23.FieldName = "TeacherID";
            resources.ApplyResources(gridViewDecimalColumn23, "gridViewDecimalColumn23");
            gridViewDecimalColumn23.IsAutoGenerated = true;
            gridViewDecimalColumn23.Name = "TeacherID";
            gridViewDecimalColumn23.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDecimalColumn23.Width = 75;
            gridViewTextBoxColumn100.EnableExpressionEditor = false;
            gridViewTextBoxColumn100.FieldName = "FirstName";
            resources.ApplyResources(gridViewTextBoxColumn100, "gridViewTextBoxColumn100");
            gridViewTextBoxColumn100.IsAutoGenerated = true;
            gridViewTextBoxColumn100.Name = "FirstName";
            gridViewTextBoxColumn100.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn100.Width = 100;
            gridViewTextBoxColumn101.EnableExpressionEditor = false;
            gridViewTextBoxColumn101.FieldName = "LastName";
            resources.ApplyResources(gridViewTextBoxColumn101, "gridViewTextBoxColumn101");
            gridViewTextBoxColumn101.IsAutoGenerated = true;
            gridViewTextBoxColumn101.Name = "LastName";
            gridViewTextBoxColumn101.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn101.Width = 100;
            gridViewTextBoxColumn102.EnableExpressionEditor = false;
            gridViewTextBoxColumn102.FieldName = "Gender";
            resources.ApplyResources(gridViewTextBoxColumn102, "gridViewTextBoxColumn102");
            gridViewTextBoxColumn102.IsAutoGenerated = true;
            gridViewTextBoxColumn102.Name = "Gender";
            gridViewTextBoxColumn102.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn102.Width = 75;
            gridViewTextBoxColumn103.EnableExpressionEditor = false;
            gridViewTextBoxColumn103.FieldName = "City";
            resources.ApplyResources(gridViewTextBoxColumn103, "gridViewTextBoxColumn103");
            gridViewTextBoxColumn103.IsAutoGenerated = true;
            gridViewTextBoxColumn103.Name = "City";
            gridViewTextBoxColumn103.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn103.Width = 85;
            gridViewTextBoxColumn104.EnableExpressionEditor = false;
            gridViewTextBoxColumn104.FieldName = "Qualification";
            resources.ApplyResources(gridViewTextBoxColumn104, "gridViewTextBoxColumn104");
            gridViewTextBoxColumn104.IsAutoGenerated = true;
            gridViewTextBoxColumn104.Name = "Qualification";
            gridViewTextBoxColumn104.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn104.Width = 85;
            gridViewDateTimeColumn34.EnableExpressionEditor = false;
            gridViewDateTimeColumn34.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.ShortDate;
            gridViewDateTimeColumn34.FieldName = "DayofBirth";
            resources.ApplyResources(gridViewDateTimeColumn34, "gridViewDateTimeColumn34");
            gridViewDateTimeColumn34.IsAutoGenerated = true;
            gridViewDateTimeColumn34.Name = "DayofBirth";
            gridViewDateTimeColumn34.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDateTimeColumn34.Width = 100;
            gridViewTextBoxColumn105.EnableExpressionEditor = false;
            gridViewTextBoxColumn105.FieldName = "Email";
            resources.ApplyResources(gridViewTextBoxColumn105, "gridViewTextBoxColumn105");
            gridViewTextBoxColumn105.IsAutoGenerated = true;
            gridViewTextBoxColumn105.Name = "Email";
            gridViewTextBoxColumn105.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn105.Width = 200;
            gridViewTextBoxColumn106.EnableExpressionEditor = false;
            gridViewTextBoxColumn106.FieldName = "PhoneNo";
            resources.ApplyResources(gridViewTextBoxColumn106, "gridViewTextBoxColumn106");
            gridViewTextBoxColumn106.IsAutoGenerated = true;
            gridViewTextBoxColumn106.Name = "PhoneNo";
            gridViewTextBoxColumn106.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn106.Width = 125;
            gridViewTextBoxColumn107.EnableExpressionEditor = false;
            gridViewTextBoxColumn107.FieldName = "InsertBy";
            gridViewTextBoxColumn107.IsAutoGenerated = true;
            gridViewTextBoxColumn107.Name = "InsertBy";
            gridViewTextBoxColumn107.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn107.Width = 85;
            gridViewDateTimeColumn35.EnableExpressionEditor = false;
            gridViewDateTimeColumn35.FieldName = "InsertDate";
            gridViewDateTimeColumn35.IsAutoGenerated = true;
            gridViewDateTimeColumn35.Name = "InsertDate";
            gridViewDateTimeColumn35.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDateTimeColumn35.Width = 170;
            gridViewTextBoxColumn108.EnableExpressionEditor = false;
            gridViewTextBoxColumn108.FieldName = "LUB";
            gridViewTextBoxColumn108.IsAutoGenerated = true;
            gridViewTextBoxColumn108.Name = "LUB";
            gridViewTextBoxColumn108.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn108.Width = 85;
            gridViewDateTimeColumn36.EnableExpressionEditor = false;
            gridViewDateTimeColumn36.FieldName = "LUD";
            gridViewDateTimeColumn36.IsAutoGenerated = true;
            gridViewDateTimeColumn36.Name = "LUD";
            gridViewDateTimeColumn36.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDateTimeColumn36.Width = 170;
            gridViewDecimalColumn24.DataType = typeof(int);
            gridViewDecimalColumn24.EnableExpressionEditor = false;
            gridViewDecimalColumn24.FieldName = "LUN";
            gridViewDecimalColumn24.IsAutoGenerated = true;
            gridViewDecimalColumn24.Name = "LUN";
            gridViewDecimalColumn24.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.dgvTeacherList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn23,
            gridViewTextBoxColumn100,
            gridViewTextBoxColumn101,
            gridViewTextBoxColumn102,
            gridViewTextBoxColumn103,
            gridViewTextBoxColumn104,
            gridViewDateTimeColumn34,
            gridViewTextBoxColumn105,
            gridViewTextBoxColumn106,
            gridViewTextBoxColumn107,
            gridViewDateTimeColumn35,
            gridViewTextBoxColumn108,
            gridViewDateTimeColumn36,
            gridViewDecimalColumn24});
            this.dgvTeacherList.MasterTemplate.DataSource = this.bsrcTeacherList;
            this.dgvTeacherList.MasterTemplate.ViewDefinition = tableViewDefinition12;
            this.dgvTeacherList.Name = "dgvTeacherList";
            this.dgvTeacherList.ReadOnly = true;
            this.dgvTeacherList.ThemeName = "CrystalDark";
            // 
            // bsrcTeacherList
            // 
            this.bsrcTeacherList.DataSource = typeof(MenaxhimiDitarit.BO.Teacher);
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
            this.pnlPicture.Controls.Add(this.lblTeacher);
            this.pnlPicture.Controls.Add(this.picClass);
            resources.ApplyResources(this.pnlPicture, "pnlPicture");
            this.pnlPicture.Name = "pnlPicture";
            // 
            // lblTeacher
            // 
            resources.ApplyResources(this.lblTeacher, "lblTeacher");
            this.lblTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.lblTeacher.Name = "lblTeacher";
            // 
            // picClass
            // 
            this.picClass.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_teacher_100;
            resources.ApplyResources(this.picClass, "picClass");
            this.picClass.Name = "picClass";
            this.picClass.TabStop = false;
            // 
            // TeacherList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.Controls.Add(this.pnlClassMain);
            this.Controls.Add(this.dgvTeacherList);
            this.Controls.Add(this.grbSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeacherList";
            this.Load += new System.EventHandler(this.TeacherListForm_Load);
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cmsTeacherContext.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcTeacherList)).EndInit();
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

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSearchTeachers;
        private System.Windows.Forms.Button btnViewAll;
        private Telerik.WinControls.Themes.CrystalDarkTheme crystalDarkTheme1;
        private System.Windows.Forms.ContextMenuStrip cmsTeacherContext;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private Telerik.WinControls.UI.RadGridView dgvTeacherList;
        private System.Windows.Forms.BindingSource bsrcTeacherList;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
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
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.PictureBox picClass;
    }
}