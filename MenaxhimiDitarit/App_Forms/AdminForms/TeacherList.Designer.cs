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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn14 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn4 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn15 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn16 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn17 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn5 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn18 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn6 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.RadPrintWatermark radPrintWatermark2 = new Telerik.WinControls.UI.RadPrintWatermark();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.btnSearchTeachers = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.crystalDarkTheme1 = new Telerik.WinControls.Themes.CrystalDarkTheme();
            this.cmsTeacherContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvTeacherList = new Telerik.WinControls.UI.RadGridView();
            this.bsrcTeacherList = new System.Windows.Forms.BindingSource(this.components);
            this.pnlClassMain = new System.Windows.Forms.Panel();
            this.btnExportPDF = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.pnlPicture = new System.Windows.Forms.Panel();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.picClass = new System.Windows.Forms.PictureBox();
            this.printDocument = new Telerik.WinControls.UI.RadPrintDocument();
            this.grbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cmsTeacherContext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherList.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcTeacherList)).BeginInit();
            this.pnlClassMain.SuspendLayout();
            this.pnlPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClass)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panel1.Name = "panel1";
            // 
            // txtSearchName
            // 
            resources.ApplyResources(this.txtSearchName, "txtSearchName");
            this.txtSearchName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.txtSearchName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchName.ForeColor = System.Drawing.Color.White;
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Click += new System.EventHandler(this.txtSearchName_Click);
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            this.txtSearchName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchName_KeyDown);
            this.txtSearchName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchName_KeyPress);
            // 
            // grbSearch
            // 
            resources.ApplyResources(this.grbSearch, "grbSearch");
            this.grbSearch.Controls.Add(this.btnSearchTeachers);
            this.grbSearch.Controls.Add(this.btnViewAll);
            this.grbSearch.Controls.Add(this.pictureBox1);
            this.grbSearch.Controls.Add(this.panel1);
            this.grbSearch.Controls.Add(this.txtSearchName);
            this.grbSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbSearch.ForeColor = System.Drawing.Color.White;
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.TabStop = false;
            // 
            // btnSearchTeachers
            // 
            resources.ApplyResources(this.btnSearchTeachers, "btnSearchTeachers");
            this.btnSearchTeachers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.btnSearchTeachers.FlatAppearance.BorderSize = 0;
            this.btnSearchTeachers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnSearchTeachers.Name = "btnSearchTeachers";
            this.btnSearchTeachers.UseVisualStyleBackColor = false;
            this.btnSearchTeachers.Click += new System.EventHandler(this.btnSearchTeachers_Click);
            // 
            // btnViewAll
            // 
            resources.ApplyResources(this.btnViewAll, "btnViewAll");
            this.btnViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.btnViewAll.FlatAppearance.BorderSize = 0;
            this.btnViewAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAllTeachers_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_search_25;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // cmsTeacherContext
            // 
            resources.ApplyResources(this.cmsTeacherContext, "cmsTeacherContext");
            this.cmsTeacherContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem});
            this.cmsTeacherContext.Name = "cmsTeacherContext";
            // 
            // updateToolStripMenuItem
            // 
            resources.ApplyResources(this.updateToolStripMenuItem, "updateToolStripMenuItem");
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // dgvTeacherList
            // 
            resources.ApplyResources(this.dgvTeacherList, "dgvTeacherList");
            this.dgvTeacherList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.dgvTeacherList.ContextMenuStrip = this.cmsTeacherContext;
            this.dgvTeacherList.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvTeacherList.ForeColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.dgvTeacherList.MasterTemplate.AllowAddNewRow = false;
            this.dgvTeacherList.MasterTemplate.AllowCellContextMenu = false;
            this.dgvTeacherList.MasterTemplate.AllowColumnReorder = false;
            this.dgvTeacherList.MasterTemplate.Caption = resources.GetString("dgvTeacherList.MasterTemplate.Caption");
            gridViewDecimalColumn3.DataType = typeof(int);
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            resources.ApplyResources(gridViewDecimalColumn3, "gridViewDecimalColumn3");
            gridViewDecimalColumn3.FieldName = "TeacherID";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.Name = "TeacherID";
            gridViewDecimalColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDecimalColumn3.Width = 75;
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            resources.ApplyResources(gridViewTextBoxColumn10, "gridViewTextBoxColumn10");
            gridViewTextBoxColumn10.FieldName = "FirstName";
            gridViewTextBoxColumn10.IsAutoGenerated = true;
            gridViewTextBoxColumn10.Name = "FirstName";
            gridViewTextBoxColumn10.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn10.Width = 100;
            gridViewTextBoxColumn11.EnableExpressionEditor = false;
            resources.ApplyResources(gridViewTextBoxColumn11, "gridViewTextBoxColumn11");
            gridViewTextBoxColumn11.FieldName = "LastName";
            gridViewTextBoxColumn11.IsAutoGenerated = true;
            gridViewTextBoxColumn11.Name = "LastName";
            gridViewTextBoxColumn11.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn11.Width = 100;
            gridViewTextBoxColumn12.EnableExpressionEditor = false;
            resources.ApplyResources(gridViewTextBoxColumn12, "gridViewTextBoxColumn12");
            gridViewTextBoxColumn12.FieldName = "Gender";
            gridViewTextBoxColumn12.IsAutoGenerated = true;
            gridViewTextBoxColumn12.Name = "Gender";
            gridViewTextBoxColumn12.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn12.Width = 75;
            gridViewTextBoxColumn13.EnableExpressionEditor = false;
            resources.ApplyResources(gridViewTextBoxColumn13, "gridViewTextBoxColumn13");
            gridViewTextBoxColumn13.FieldName = "City";
            gridViewTextBoxColumn13.IsAutoGenerated = true;
            gridViewTextBoxColumn13.Name = "City";
            gridViewTextBoxColumn13.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn13.Width = 100;
            gridViewTextBoxColumn14.EnableExpressionEditor = false;
            resources.ApplyResources(gridViewTextBoxColumn14, "gridViewTextBoxColumn14");
            gridViewTextBoxColumn14.FieldName = "Qualification";
            gridViewTextBoxColumn14.IsAutoGenerated = true;
            gridViewTextBoxColumn14.Name = "Qualification";
            gridViewTextBoxColumn14.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn14.Width = 100;
            resources.ApplyResources(gridViewDateTimeColumn4, "gridViewDateTimeColumn4");
            gridViewDateTimeColumn4.EnableExpressionEditor = false;
            gridViewDateTimeColumn4.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.ShortDate;
            gridViewDateTimeColumn4.FieldName = "DayofBirth";
            gridViewDateTimeColumn4.IsAutoGenerated = true;
            gridViewDateTimeColumn4.Name = "DayofBirth";
            gridViewDateTimeColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDateTimeColumn4.Width = 150;
            gridViewTextBoxColumn15.EnableExpressionEditor = false;
            resources.ApplyResources(gridViewTextBoxColumn15, "gridViewTextBoxColumn15");
            gridViewTextBoxColumn15.FieldName = "Email";
            gridViewTextBoxColumn15.IsAutoGenerated = true;
            gridViewTextBoxColumn15.Name = "Email";
            gridViewTextBoxColumn15.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn15.Width = 200;
            gridViewTextBoxColumn16.EnableExpressionEditor = false;
            resources.ApplyResources(gridViewTextBoxColumn16, "gridViewTextBoxColumn16");
            gridViewTextBoxColumn16.FieldName = "PhoneNo";
            gridViewTextBoxColumn16.IsAutoGenerated = true;
            gridViewTextBoxColumn16.Name = "PhoneNo";
            gridViewTextBoxColumn16.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn16.Width = 130;
            gridViewTextBoxColumn17.EnableExpressionEditor = false;
            resources.ApplyResources(gridViewTextBoxColumn17, "gridViewTextBoxColumn17");
            gridViewTextBoxColumn17.FieldName = "InsertBy";
            gridViewTextBoxColumn17.IsAutoGenerated = true;
            gridViewTextBoxColumn17.IsVisible = false;
            gridViewTextBoxColumn17.Name = "InsertBy";
            gridViewTextBoxColumn17.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn17.Width = 85;
            resources.ApplyResources(gridViewDateTimeColumn5, "gridViewDateTimeColumn5");
            gridViewDateTimeColumn5.EnableExpressionEditor = false;
            gridViewDateTimeColumn5.FieldName = "InsertDate";
            gridViewDateTimeColumn5.IsAutoGenerated = true;
            gridViewDateTimeColumn5.IsVisible = false;
            gridViewDateTimeColumn5.Name = "InsertDate";
            gridViewDateTimeColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDateTimeColumn5.Width = 170;
            gridViewTextBoxColumn18.EnableExpressionEditor = false;
            resources.ApplyResources(gridViewTextBoxColumn18, "gridViewTextBoxColumn18");
            gridViewTextBoxColumn18.FieldName = "LUB";
            gridViewTextBoxColumn18.IsAutoGenerated = true;
            gridViewTextBoxColumn18.IsVisible = false;
            gridViewTextBoxColumn18.Name = "LUB";
            gridViewTextBoxColumn18.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn18.Width = 85;
            resources.ApplyResources(gridViewDateTimeColumn6, "gridViewDateTimeColumn6");
            gridViewDateTimeColumn6.EnableExpressionEditor = false;
            gridViewDateTimeColumn6.FieldName = "LUD";
            gridViewDateTimeColumn6.IsAutoGenerated = true;
            gridViewDateTimeColumn6.IsVisible = false;
            gridViewDateTimeColumn6.Name = "LUD";
            gridViewDateTimeColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDateTimeColumn6.Width = 170;
            gridViewDecimalColumn4.DataType = typeof(int);
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            resources.ApplyResources(gridViewDecimalColumn4, "gridViewDecimalColumn4");
            gridViewDecimalColumn4.FieldName = "LUN";
            gridViewDecimalColumn4.IsAutoGenerated = true;
            gridViewDecimalColumn4.IsVisible = false;
            gridViewDecimalColumn4.Name = "LUN";
            gridViewDecimalColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.dgvTeacherList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn3,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12,
            gridViewTextBoxColumn13,
            gridViewTextBoxColumn14,
            gridViewDateTimeColumn4,
            gridViewTextBoxColumn15,
            gridViewTextBoxColumn16,
            gridViewTextBoxColumn17,
            gridViewDateTimeColumn5,
            gridViewTextBoxColumn18,
            gridViewDateTimeColumn6,
            gridViewDecimalColumn4});
            this.dgvTeacherList.MasterTemplate.DataSource = this.bsrcTeacherList;
            this.dgvTeacherList.MasterTemplate.ViewDefinition = tableViewDefinition2;
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
            resources.ApplyResources(this.pnlClassMain, "pnlClassMain");
            this.pnlClassMain.Controls.Add(this.btnExportPDF);
            this.pnlClassMain.Controls.Add(this.btnExportExcel);
            this.pnlClassMain.Controls.Add(this.btnPrint);
            this.pnlClassMain.Controls.Add(this.btnUpdate);
            this.pnlClassMain.Controls.Add(this.btnAddClass);
            this.pnlClassMain.Controls.Add(this.pnlPicture);
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
            resources.ApplyResources(this.pnlPicture, "pnlPicture");
            this.pnlPicture.Controls.Add(this.lblTeacher);
            this.pnlPicture.Controls.Add(this.picClass);
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
            resources.ApplyResources(this.picClass, "picClass");
            this.picClass.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_teacher_100;
            this.picClass.Name = "picClass";
            this.picClass.TabStop = false;
            // 
            // printDocument
            // 
            this.printDocument.FooterFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printDocument.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printDocument.Watermark = radPrintWatermark2;
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
        private System.Windows.Forms.Panel pnlClassMain;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.Panel pnlPicture;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.PictureBox picClass;
        private System.Windows.Forms.Button btnExportPDF;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnPrint;
        private Telerik.WinControls.UI.RadPrintDocument printDocument;
    }
}