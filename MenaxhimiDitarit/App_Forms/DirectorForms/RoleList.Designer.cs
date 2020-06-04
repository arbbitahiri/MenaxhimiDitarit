namespace MenaxhimiDitarit.DirectorForms
{
    partial class RoleList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoleList));
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn15 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn22 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn23 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn15 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn24 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn16 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn16 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition8 = new Telerik.WinControls.UI.TableViewDefinition();
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.dgvRoleList = new Telerik.WinControls.UI.RadGridView();
            this.bsrcRoleList = new System.Windows.Forms.BindingSource(this.components);
            this.crystalDarkTheme1 = new Telerik.WinControls.Themes.CrystalDarkTheme();
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
            this.pnlPicture = new System.Windows.Forms.Panel();
            this.lblRole = new System.Windows.Forms.Label();
            this.picClass = new System.Windows.Forms.PictureBox();
            this.grbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoleList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoleList.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcRoleList)).BeginInit();
            this.pnlClassMain.SuspendLayout();
            this.pnlExport.SuspendLayout();
            this.pnlPrint.SuspendLayout();
            this.pnlPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClass)).BeginInit();
            this.SuspendLayout();
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.btnSearch);
            this.grbSearch.Controls.Add(this.btnViewAll);
            this.grbSearch.Controls.Add(this.pictureBox1);
            this.grbSearch.Controls.Add(this.panel1);
            this.grbSearch.Controls.Add(this.txtSearchUser);
            resources.ApplyResources(this.grbSearch, "grbSearch");
            this.grbSearch.ForeColor = System.Drawing.Color.White;
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
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
            this.btnViewAll.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnViewAll, "btnViewAll");
            this.btnViewAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAllRoles_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_search_25;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.txtSearchUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtSearchUser, "txtSearchUser");
            this.txtSearchUser.ForeColor = System.Drawing.Color.White;
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Click += new System.EventHandler(this.txtSearchUser_Click);
            this.txtSearchUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchUser_KeyDown);
            this.txtSearchUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchUser_KeyPress);
            // 
            // dgvRoleList
            // 
            this.dgvRoleList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.dgvRoleList.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.dgvRoleList, "dgvRoleList");
            this.dgvRoleList.ForeColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.dgvRoleList.MasterTemplate.AllowAddNewRow = false;
            this.dgvRoleList.MasterTemplate.AllowCellContextMenu = false;
            this.dgvRoleList.MasterTemplate.AllowColumnReorder = false;
            gridViewDecimalColumn15.DataType = typeof(int);
            gridViewDecimalColumn15.EnableExpressionEditor = false;
            gridViewDecimalColumn15.FieldName = "RoleID";
            resources.ApplyResources(gridViewDecimalColumn15, "gridViewDecimalColumn15");
            gridViewDecimalColumn15.IsAutoGenerated = true;
            gridViewDecimalColumn15.Name = "RoleID";
            gridViewDecimalColumn15.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDecimalColumn15.Width = 75;
            gridViewTextBoxColumn22.EnableExpressionEditor = false;
            gridViewTextBoxColumn22.FieldName = "RoleName";
            resources.ApplyResources(gridViewTextBoxColumn22, "gridViewTextBoxColumn22");
            gridViewTextBoxColumn22.IsAutoGenerated = true;
            gridViewTextBoxColumn22.Name = "RoleName";
            gridViewTextBoxColumn22.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn22.Width = 100;
            gridViewTextBoxColumn23.EnableExpressionEditor = false;
            gridViewTextBoxColumn23.FieldName = "InsertBy";
            resources.ApplyResources(gridViewTextBoxColumn23, "gridViewTextBoxColumn23");
            gridViewTextBoxColumn23.IsAutoGenerated = true;
            gridViewTextBoxColumn23.Name = "InsertBy";
            gridViewTextBoxColumn23.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn23.Width = 85;
            gridViewDateTimeColumn15.EnableExpressionEditor = false;
            gridViewDateTimeColumn15.FieldName = "InsertDate";
            resources.ApplyResources(gridViewDateTimeColumn15, "gridViewDateTimeColumn15");
            gridViewDateTimeColumn15.IsAutoGenerated = true;
            gridViewDateTimeColumn15.Name = "InsertDate";
            gridViewDateTimeColumn15.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDateTimeColumn15.Width = 170;
            gridViewTextBoxColumn24.EnableExpressionEditor = false;
            gridViewTextBoxColumn24.FieldName = "LUB";
            resources.ApplyResources(gridViewTextBoxColumn24, "gridViewTextBoxColumn24");
            gridViewTextBoxColumn24.IsAutoGenerated = true;
            gridViewTextBoxColumn24.Name = "LUB";
            gridViewTextBoxColumn24.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn24.Width = 85;
            gridViewDateTimeColumn16.EnableExpressionEditor = false;
            gridViewDateTimeColumn16.FieldName = "LUD";
            resources.ApplyResources(gridViewDateTimeColumn16, "gridViewDateTimeColumn16");
            gridViewDateTimeColumn16.IsAutoGenerated = true;
            gridViewDateTimeColumn16.Name = "LUD";
            gridViewDateTimeColumn16.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDateTimeColumn16.Width = 170;
            gridViewDecimalColumn16.DataType = typeof(int);
            gridViewDecimalColumn16.EnableExpressionEditor = false;
            gridViewDecimalColumn16.FieldName = "LUN";
            resources.ApplyResources(gridViewDecimalColumn16, "gridViewDecimalColumn16");
            gridViewDecimalColumn16.IsAutoGenerated = true;
            gridViewDecimalColumn16.Name = "LUN";
            gridViewDecimalColumn16.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.dgvRoleList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn15,
            gridViewTextBoxColumn22,
            gridViewTextBoxColumn23,
            gridViewDateTimeColumn15,
            gridViewTextBoxColumn24,
            gridViewDateTimeColumn16,
            gridViewDecimalColumn16});
            this.dgvRoleList.MasterTemplate.DataSource = this.bsrcRoleList;
            this.dgvRoleList.MasterTemplate.ViewDefinition = tableViewDefinition8;
            this.dgvRoleList.Name = "dgvRoleList";
            this.dgvRoleList.ReadOnly = true;
            this.dgvRoleList.ThemeName = "CrystalDark";
            // 
            // bsrcRoleList
            // 
            this.bsrcRoleList.DataSource = typeof(MenaxhimiDitarit.BO.Role);
            // 
            // pnlClassMain
            // 
            this.pnlClassMain.Controls.Add(this.pnlExport);
            this.pnlClassMain.Controls.Add(this.btnExport);
            this.pnlClassMain.Controls.Add(this.pnlPrint);
            this.pnlClassMain.Controls.Add(this.btnPrintM);
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
            // pnlPicture
            // 
            this.pnlPicture.Controls.Add(this.lblRole);
            this.pnlPicture.Controls.Add(this.picClass);
            resources.ApplyResources(this.pnlPicture, "pnlPicture");
            this.pnlPicture.Name = "pnlPicture";
            // 
            // lblRole
            // 
            resources.ApplyResources(this.lblRole, "lblRole");
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.lblRole.Name = "lblRole";
            // 
            // picClass
            // 
            this.picClass.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_people_100;
            resources.ApplyResources(this.picClass, "picClass");
            this.picClass.Name = "picClass";
            this.picClass.TabStop = false;
            // 
            // RoleList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.Controls.Add(this.pnlClassMain);
            this.Controls.Add(this.dgvRoleList);
            this.Controls.Add(this.grbSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoleList";
            this.Load += new System.EventHandler(this.RoleListForm_Load);
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoleList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoleList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcRoleList)).EndInit();
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
        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearchUser;
        private Telerik.WinControls.UI.RadGridView dgvRoleList;
        private Telerik.WinControls.Themes.CrystalDarkTheme crystalDarkTheme1;
        private System.Windows.Forms.BindingSource bsrcRoleList;
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
        private System.Windows.Forms.Panel pnlPicture;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.PictureBox picClass;
    }
}