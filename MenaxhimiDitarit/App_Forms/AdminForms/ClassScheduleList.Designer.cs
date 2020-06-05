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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn6 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.RadPrintWatermark radPrintWatermark1 = new Telerik.WinControls.UI.RadPrintWatermark();
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.pnlPicture = new System.Windows.Forms.Panel();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.picClass = new System.Windows.Forms.PictureBox();
            this.btnExportPDF = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
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
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ScheduleID";
            resources.ApplyResources(gridViewDecimalColumn1, "gridViewDecimalColumn1");
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "ScheduleID";
            gridViewDecimalColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDecimalColumn1.Width = 75;
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "ClassID";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "ClassID";
            gridViewDecimalColumn3.DataType = typeof(int);
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "SubjectID";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.IsVisible = false;
            gridViewDecimalColumn3.Name = "SubjectID";
            gridViewDecimalColumn4.DataType = typeof(int);
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.FieldName = "Time";
            resources.ApplyResources(gridViewDecimalColumn4, "gridViewDecimalColumn4");
            gridViewDecimalColumn4.IsAutoGenerated = true;
            gridViewDecimalColumn4.Name = "Time";
            gridViewDecimalColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Day";
            resources.ApplyResources(gridViewTextBoxColumn1, "gridViewTextBoxColumn1");
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "Day";
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 85;
            gridViewDecimalColumn5.DataType = typeof(int);
            gridViewDecimalColumn5.EnableExpressionEditor = false;
            gridViewDecimalColumn5.FieldName = "Year";
            resources.ApplyResources(gridViewDecimalColumn5, "gridViewDecimalColumn5");
            gridViewDecimalColumn5.IsAutoGenerated = true;
            gridViewDecimalColumn5.Name = "Year";
            gridViewDecimalColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn2.DataType = typeof(int);
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Class.ClassNo";
            resources.ApplyResources(gridViewTextBoxColumn2, "gridViewTextBoxColumn2");
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "Class";
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "Subject.SubjectTitle";
            resources.ApplyResources(gridViewTextBoxColumn3, "gridViewTextBoxColumn3");
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "Subject";
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn3.Width = 100;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "InsertBy";
            resources.ApplyResources(gridViewTextBoxColumn4, "gridViewTextBoxColumn4");
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "InsertBy";
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn4.Width = 85;
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "InsertDate";
            resources.ApplyResources(gridViewDateTimeColumn1, "gridViewDateTimeColumn1");
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "InsertDate";
            gridViewDateTimeColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDateTimeColumn1.Width = 170;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "LUB";
            resources.ApplyResources(gridViewTextBoxColumn5, "gridViewTextBoxColumn5");
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "LUB";
            gridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn5.Width = 85;
            gridViewDateTimeColumn2.EnableExpressionEditor = false;
            gridViewDateTimeColumn2.FieldName = "LUD";
            resources.ApplyResources(gridViewDateTimeColumn2, "gridViewDateTimeColumn2");
            gridViewDateTimeColumn2.IsAutoGenerated = true;
            gridViewDateTimeColumn2.Name = "LUD";
            gridViewDateTimeColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDateTimeColumn2.Width = 170;
            gridViewDecimalColumn6.DataType = typeof(int);
            gridViewDecimalColumn6.EnableExpressionEditor = false;
            gridViewDecimalColumn6.FieldName = "LUN";
            resources.ApplyResources(gridViewDecimalColumn6, "gridViewDecimalColumn6");
            gridViewDecimalColumn6.IsAutoGenerated = true;
            gridViewDecimalColumn6.Name = "LUN";
            gridViewDecimalColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.dgvScheduleList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewDecimalColumn4,
            gridViewTextBoxColumn1,
            gridViewDecimalColumn5,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn5,
            gridViewDateTimeColumn2,
            gridViewDecimalColumn6});
            this.dgvScheduleList.MasterTemplate.DataSource = this.bsrcScheduleList;
            this.dgvScheduleList.MasterTemplate.ViewDefinition = tableViewDefinition1;
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
            // printDocument
            // 
            this.printDocument.FooterFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printDocument.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printDocument.Watermark = radPrintWatermark1;
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