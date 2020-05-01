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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomList));
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
            this.grbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbSearch.Controls.Add(this.btnSearchSubject);
            this.grbSearch.Controls.Add(this.btnViewAll);
            this.grbSearch.Controls.Add(this.pictureBox1);
            this.grbSearch.Controls.Add(this.panel1);
            this.grbSearch.Controls.Add(this.txtSearchSubject);
            this.grbSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSearch.ForeColor = System.Drawing.Color.White;
            this.grbSearch.Location = new System.Drawing.Point(146, 12);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Size = new System.Drawing.Size(380, 111);
            this.grbSearch.TabIndex = 0;
            this.grbSearch.TabStop = false;
            this.grbSearch.Text = "Search Room";
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
            this.btnSearchSubject.TabIndex = 1;
            this.btnSearchSubject.Text = "Search";
            this.btnSearchSubject.UseVisualStyleBackColor = false;
            this.btnSearchSubject.Click += new System.EventHandler(this.btnSearchSubject_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.btnViewAll.FlatAppearance.BorderSize = 0;
            this.btnViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnViewAll.Location = new System.Drawing.Point(19, 64);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(120, 32);
            this.btnViewAll.TabIndex = 2;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAllSubjects_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_search_25;
            this.pictureBox1.Location = new System.Drawing.Point(19, 25);
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
            this.txtSearchSubject.Text = "Search by Room Type";
            this.txtSearchSubject.Click += new System.EventHandler(this.txtSearchSubject_Click);
            this.txtSearchSubject.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchSubject_KeyDown);
            // 
            // dgvRoomList
            // 
            this.dgvRoomList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.dgvRoomList.ContextMenuStrip = this.cmsRoomContext;
            this.dgvRoomList.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvRoomList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvRoomList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvRoomList.ForeColor = System.Drawing.Color.White;
            this.dgvRoomList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvRoomList.Location = new System.Drawing.Point(0, 137);
            // 
            // 
            // 
            this.dgvRoomList.MasterTemplate.AllowAddNewRow = false;
            this.dgvRoomList.MasterTemplate.AllowCellContextMenu = false;
            this.dgvRoomList.MasterTemplate.AllowColumnReorder = false;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "RoomID";
            gridViewDecimalColumn1.HeaderText = "RoomID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "RoomID";
            gridViewDecimalColumn1.Width = 75;
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "RoomNo";
            gridViewDecimalColumn2.HeaderText = "RoomNo";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "RoomNo";
            gridViewDecimalColumn2.Width = 75;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "RoomType";
            gridViewTextBoxColumn1.HeaderText = "Room Type";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "RoomType";
            gridViewTextBoxColumn1.Width = 100;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "InsertBy";
            gridViewTextBoxColumn2.HeaderText = "InsertBy";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "InsertBy";
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn2.Width = 85;
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "InsertDate";
            gridViewDateTimeColumn1.HeaderText = "InsertDate";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "InsertDate";
            gridViewDateTimeColumn1.Width = 100;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "LUB";
            gridViewTextBoxColumn3.HeaderText = "LUB";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "LUB";
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn3.Width = 85;
            gridViewDateTimeColumn2.EnableExpressionEditor = false;
            gridViewDateTimeColumn2.FieldName = "LUD";
            gridViewDateTimeColumn2.HeaderText = "LUD";
            gridViewDateTimeColumn2.IsAutoGenerated = true;
            gridViewDateTimeColumn2.Name = "LUD";
            gridViewDateTimeColumn2.Width = 100;
            gridViewDecimalColumn3.DataType = typeof(int);
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "LUN";
            gridViewDecimalColumn3.HeaderText = "LUN";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.Name = "LUN";
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
            this.dgvRoomList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvRoomList.Size = new System.Drawing.Size(673, 426);
            this.dgvRoomList.TabIndex = 13;
            this.dgvRoomList.ThemeName = "CrystalDark";
            // 
            // cmsRoomContext
            // 
            this.cmsRoomContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsRoomContext.Name = "cmsRoomContext";
            this.cmsRoomContext.Size = new System.Drawing.Size(113, 48);
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
            // bsrcRoomList
            // 
            this.bsrcRoomList.DataSource = typeof(MenaxhimiDitarit.BO.Room);
            // 
            // RoomList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(673, 563);
            this.Controls.Add(this.dgvRoomList);
            this.Controls.Add(this.grbSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RoomList";
            this.Text = "Room List";
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