namespace MenaxhimiDitarit.AdminForms
{
    partial class RoomList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomList));
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn7 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn8 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn5 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn6 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn9 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.RadPrintWatermark radPrintWatermark3 = new Telerik.WinControls.UI.RadPrintWatermark();
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.btnSearchSubject = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearchSubject = new System.Windows.Forms.TextBox();
            this.dgvRoomList = new Telerik.WinControls.UI.RadGridView();
            this.cmsRoomContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bsrcRoomList = new System.Windows.Forms.BindingSource(this.components);
            this.crystalDarkTheme1 = new Telerik.WinControls.Themes.CrystalDarkTheme();
            this.pnlClassMain = new System.Windows.Forms.Panel();
            this.btnExportPDF = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.pnlPicture = new System.Windows.Forms.Panel();
            this.lblRoom = new System.Windows.Forms.Label();
            this.picClass = new System.Windows.Forms.PictureBox();
            this.printDocument = new Telerik.WinControls.UI.RadPrintDocument();
            this.grbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomList.MasterTemplate)).BeginInit();
            this.cmsRoomContext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcRoomList)).BeginInit();
            this.pnlClassMain.SuspendLayout();
            this.pnlPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClass)).BeginInit();
            this.SuspendLayout();
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.btnSearchSubject);
            this.grbSearch.Controls.Add(this.btnViewAll);
            this.grbSearch.Controls.Add(this.pictureBox1);
            this.grbSearch.Controls.Add(this.panel1);
            this.grbSearch.Controls.Add(this.txtSearchSubject);
            this.grbSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.grbSearch, "grbSearch");
            this.grbSearch.ForeColor = System.Drawing.Color.White;
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.TabStop = false;
            // 
            // btnSearchSubject
            // 
            this.btnSearchSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.btnSearchSubject.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnSearchSubject, "btnSearchSubject");
            this.btnSearchSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnSearchSubject.Name = "btnSearchSubject";
            this.btnSearchSubject.UseVisualStyleBackColor = false;
            this.btnSearchSubject.Click += new System.EventHandler(this.btnSearchSubject_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.btnViewAll.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnViewAll, "btnViewAll");
            this.btnViewAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAllSubjects_Click);
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
            // txtSearchSubject
            // 
            this.txtSearchSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.txtSearchSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtSearchSubject, "txtSearchSubject");
            this.txtSearchSubject.ForeColor = System.Drawing.Color.White;
            this.txtSearchSubject.Name = "txtSearchSubject";
            this.txtSearchSubject.Click += new System.EventHandler(this.txtSearchSubject_Click);
            this.txtSearchSubject.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchSubject_KeyDown);
            this.txtSearchSubject.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchSubject_KeyPress);
            // 
            // dgvRoomList
            // 
            this.dgvRoomList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.dgvRoomList.ContextMenuStrip = this.cmsRoomContext;
            this.dgvRoomList.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.dgvRoomList, "dgvRoomList");
            this.dgvRoomList.ForeColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.dgvRoomList.MasterTemplate.AllowAddNewRow = false;
            this.dgvRoomList.MasterTemplate.AllowCellContextMenu = false;
            this.dgvRoomList.MasterTemplate.AllowColumnReorder = false;
            gridViewDecimalColumn7.DataType = typeof(int);
            gridViewDecimalColumn7.EnableExpressionEditor = false;
            gridViewDecimalColumn7.FieldName = "RoomID";
            resources.ApplyResources(gridViewDecimalColumn7, "gridViewDecimalColumn7");
            gridViewDecimalColumn7.IsAutoGenerated = true;
            gridViewDecimalColumn7.Name = "RoomID";
            gridViewDecimalColumn7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDecimalColumn7.Width = 75;
            gridViewDecimalColumn8.DataType = typeof(int);
            gridViewDecimalColumn8.EnableExpressionEditor = false;
            gridViewDecimalColumn8.FieldName = "RoomNo";
            resources.ApplyResources(gridViewDecimalColumn8, "gridViewDecimalColumn8");
            gridViewDecimalColumn8.IsAutoGenerated = true;
            gridViewDecimalColumn8.Name = "RoomNo";
            gridViewDecimalColumn8.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDecimalColumn8.Width = 75;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "RoomType";
            resources.ApplyResources(gridViewTextBoxColumn7, "gridViewTextBoxColumn7");
            gridViewTextBoxColumn7.IsAutoGenerated = true;
            gridViewTextBoxColumn7.Name = "RoomType";
            gridViewTextBoxColumn7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn7.Width = 100;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "InsertBy";
            resources.ApplyResources(gridViewTextBoxColumn8, "gridViewTextBoxColumn8");
            gridViewTextBoxColumn8.IsAutoGenerated = true;
            gridViewTextBoxColumn8.Name = "InsertBy";
            gridViewTextBoxColumn8.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn8.Width = 85;
            gridViewDateTimeColumn5.EnableExpressionEditor = false;
            gridViewDateTimeColumn5.FieldName = "InsertDate";
            resources.ApplyResources(gridViewDateTimeColumn5, "gridViewDateTimeColumn5");
            gridViewDateTimeColumn5.IsAutoGenerated = true;
            gridViewDateTimeColumn5.Name = "InsertDate";
            gridViewDateTimeColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDateTimeColumn5.Width = 170;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "LUB";
            resources.ApplyResources(gridViewTextBoxColumn9, "gridViewTextBoxColumn9");
            gridViewTextBoxColumn9.IsAutoGenerated = true;
            gridViewTextBoxColumn9.Name = "LUB";
            gridViewTextBoxColumn9.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn9.Width = 85;
            gridViewDateTimeColumn6.EnableExpressionEditor = false;
            gridViewDateTimeColumn6.FieldName = "LUD";
            resources.ApplyResources(gridViewDateTimeColumn6, "gridViewDateTimeColumn6");
            gridViewDateTimeColumn6.IsAutoGenerated = true;
            gridViewDateTimeColumn6.Name = "LUD";
            gridViewDateTimeColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDateTimeColumn6.Width = 170;
            gridViewDecimalColumn9.DataType = typeof(int);
            gridViewDecimalColumn9.EnableExpressionEditor = false;
            gridViewDecimalColumn9.FieldName = "LUN";
            resources.ApplyResources(gridViewDecimalColumn9, "gridViewDecimalColumn9");
            gridViewDecimalColumn9.IsAutoGenerated = true;
            gridViewDecimalColumn9.Name = "LUN";
            gridViewDecimalColumn9.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.dgvRoomList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn7,
            gridViewDecimalColumn8,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewDateTimeColumn5,
            gridViewTextBoxColumn9,
            gridViewDateTimeColumn6,
            gridViewDecimalColumn9});
            this.dgvRoomList.MasterTemplate.DataSource = this.bsrcRoomList;
            this.dgvRoomList.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.dgvRoomList.Name = "dgvRoomList";
            this.dgvRoomList.ReadOnly = true;
            this.dgvRoomList.ThemeName = "CrystalDark";
            // 
            // cmsRoomContext
            // 
            this.cmsRoomContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsRoomContext.Name = "cmsRoomContext";
            resources.ApplyResources(this.cmsRoomContext, "cmsRoomContext");
            // 
            // updateToolStripMenuItem
            // 
            resources.ApplyResources(this.updateToolStripMenuItem, "updateToolStripMenuItem");
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // bsrcRoomList
            // 
            this.bsrcRoomList.DataSource = typeof(MenaxhimiDitarit.BO.Room);
            // 
            // pnlClassMain
            // 
            this.pnlClassMain.Controls.Add(this.btnExportPDF);
            this.pnlClassMain.Controls.Add(this.btnExportExcel);
            this.pnlClassMain.Controls.Add(this.btnPrint);
            this.pnlClassMain.Controls.Add(this.btnDelete);
            this.pnlClassMain.Controls.Add(this.btnUpdate);
            this.pnlClassMain.Controls.Add(this.btnAddNew);
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
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_delete_trash_20;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            // btnAddNew
            // 
            resources.ApplyResources(this.btnAddNew, "btnAddNew");
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_add_new_20;
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // pnlPicture
            // 
            this.pnlPicture.Controls.Add(this.lblRoom);
            this.pnlPicture.Controls.Add(this.picClass);
            resources.ApplyResources(this.pnlPicture, "pnlPicture");
            this.pnlPicture.Name = "pnlPicture";
            // 
            // lblRoom
            // 
            resources.ApplyResources(this.lblRoom, "lblRoom");
            this.lblRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.lblRoom.Name = "lblRoom";
            // 
            // picClass
            // 
            this.picClass.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_room_100;
            resources.ApplyResources(this.picClass, "picClass");
            this.picClass.Name = "picClass";
            this.picClass.TabStop = false;
            // 
            // printDocument
            // 
            this.printDocument.FooterFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printDocument.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printDocument.Watermark = radPrintWatermark3;
            // 
            // RoomList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.Controls.Add(this.pnlClassMain);
            this.Controls.Add(this.dgvRoomList);
            this.Controls.Add(this.grbSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomList";
            this.Load += new System.EventHandler(this.RoomListForm_Load);
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomList)).EndInit();
            this.cmsRoomContext.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsrcRoomList)).EndInit();
            this.pnlClassMain.ResumeLayout(false);
            this.pnlClassMain.PerformLayout();
            this.pnlPicture.ResumeLayout(false);
            this.pnlPicture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.Button btnSearchSubject;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearchSubject;
        private Telerik.WinControls.UI.RadGridView dgvRoomList;
        private Telerik.WinControls.Themes.CrystalDarkTheme crystalDarkTheme1;
        private System.Windows.Forms.BindingSource bsrcRoomList;
        private System.Windows.Forms.ContextMenuStrip cmsRoomContext;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Panel pnlClassMain;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Panel pnlPicture;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.PictureBox picClass;
        private System.Windows.Forms.Button btnExportPDF;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnPrint;
        private Telerik.WinControls.UI.RadPrintDocument printDocument;
    }
}