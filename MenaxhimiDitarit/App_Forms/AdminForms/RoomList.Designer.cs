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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
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
            this.grbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomList.MasterTemplate)).BeginInit();
            this.cmsRoomContext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcRoomList)).BeginInit();
            this.SuspendLayout();
            // 
            // grbSearch
            // 
            resources.ApplyResources(this.grbSearch, "grbSearch");
            this.grbSearch.Controls.Add(this.btnSearchSubject);
            this.grbSearch.Controls.Add(this.btnViewAll);
            this.grbSearch.Controls.Add(this.pictureBox1);
            this.grbSearch.Controls.Add(this.panel1);
            this.grbSearch.Controls.Add(this.txtSearchSubject);
            this.grbSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "RoomID";
            resources.ApplyResources(gridViewDecimalColumn1, "gridViewDecimalColumn1");
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "RoomID";
            gridViewDecimalColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDecimalColumn1.Width = 75;
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "RoomNo";
            resources.ApplyResources(gridViewDecimalColumn2, "gridViewDecimalColumn2");
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "RoomNo";
            gridViewDecimalColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDecimalColumn2.Width = 75;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "RoomType";
            resources.ApplyResources(gridViewTextBoxColumn1, "gridViewTextBoxColumn1");
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "RoomType";
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 100;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "InsertBy";
            resources.ApplyResources(gridViewTextBoxColumn2, "gridViewTextBoxColumn2");
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "InsertBy";
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn2.Width = 85;
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "InsertDate";
            resources.ApplyResources(gridViewDateTimeColumn1, "gridViewDateTimeColumn1");
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "InsertDate";
            gridViewDateTimeColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDateTimeColumn1.Width = 170;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "LUB";
            resources.ApplyResources(gridViewTextBoxColumn3, "gridViewTextBoxColumn3");
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "LUB";
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn3.Width = 85;
            gridViewDateTimeColumn2.EnableExpressionEditor = false;
            gridViewDateTimeColumn2.FieldName = "LUD";
            resources.ApplyResources(gridViewDateTimeColumn2, "gridViewDateTimeColumn2");
            gridViewDateTimeColumn2.IsAutoGenerated = true;
            gridViewDateTimeColumn2.Name = "LUD";
            gridViewDateTimeColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDateTimeColumn2.Width = 170;
            gridViewDecimalColumn3.DataType = typeof(int);
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "LUN";
            resources.ApplyResources(gridViewDecimalColumn3, "gridViewDecimalColumn3");
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.Name = "LUN";
            gridViewDecimalColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.dgvRoomList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn3,
            gridViewDateTimeColumn2,
            gridViewDecimalColumn3});
            this.dgvRoomList.MasterTemplate.DataSource = this.bsrcRoomList;
            this.dgvRoomList.MasterTemplate.ViewDefinition = tableViewDefinition1;
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
            // RoomList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
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
    }
}