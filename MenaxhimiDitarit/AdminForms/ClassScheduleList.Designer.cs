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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn11 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn12 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn13 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn14 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn9 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn10 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn11 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn12 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn15 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            this.crystalDarkTheme1 = new Telerik.WinControls.Themes.CrystalDarkTheme();
            this.bsrcScheduleList = new System.Windows.Forms.BindingSource(this.components);
            this.cmsScheduleContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvScheduleList = new Telerik.WinControls.UI.RadGridView();
            this.grbSearchSchedule = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.cmbSelectDay = new System.Windows.Forms.ComboBox();
            this.lblSelectDay = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbSelectClass = new System.Windows.Forms.ComboBox();
            this.lblSelectClass = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcScheduleList)).BeginInit();
            this.cmsScheduleContext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduleList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduleList.MasterTemplate)).BeginInit();
            this.grbSearchSchedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // bsrcScheduleList
            // 
            this.bsrcScheduleList.DataSource = typeof(MenaxhimiDitarit.BO.ClassSchedule);
            // 
            // cmsScheduleContext
            // 
            this.cmsScheduleContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem});
            this.cmsScheduleContext.Name = "contextMenuStrip1";
            this.cmsScheduleContext.Size = new System.Drawing.Size(113, 26);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updateToolStripMenuItem.Image")));
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // dgvScheduleList
            // 
            this.dgvScheduleList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.dgvScheduleList.ContextMenuStrip = this.cmsScheduleContext;
            this.dgvScheduleList.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvScheduleList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvScheduleList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvScheduleList.ForeColor = System.Drawing.Color.White;
            this.dgvScheduleList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvScheduleList.Location = new System.Drawing.Point(0, 151);
            // 
            // 
            // 
            this.dgvScheduleList.MasterTemplate.AllowAddNewRow = false;
            this.dgvScheduleList.MasterTemplate.AllowCellContextMenu = false;
            this.dgvScheduleList.MasterTemplate.AllowColumnReorder = false;
            gridViewDecimalColumn11.DataType = typeof(int);
            gridViewDecimalColumn11.EnableExpressionEditor = false;
            gridViewDecimalColumn11.FieldName = "ScheduleID";
            gridViewDecimalColumn11.HeaderText = "ScheduleID";
            gridViewDecimalColumn11.IsAutoGenerated = true;
            gridViewDecimalColumn11.Name = "ScheduleID";
            gridViewDecimalColumn11.Width = 75;
            gridViewDecimalColumn12.DataType = typeof(int);
            gridViewDecimalColumn12.EnableExpressionEditor = false;
            gridViewDecimalColumn12.FieldName = "ClassID";
            gridViewDecimalColumn12.HeaderText = "ClassID";
            gridViewDecimalColumn12.IsAutoGenerated = true;
            gridViewDecimalColumn12.Name = "ClassID";
            gridViewDecimalColumn12.Width = 75;
            gridViewDecimalColumn13.DataType = typeof(int);
            gridViewDecimalColumn13.EnableExpressionEditor = false;
            gridViewDecimalColumn13.FieldName = "SubjectID";
            gridViewDecimalColumn13.HeaderText = "SubjectID";
            gridViewDecimalColumn13.IsAutoGenerated = true;
            gridViewDecimalColumn13.Name = "SubjectID";
            gridViewDecimalColumn13.Width = 75;
            gridViewDecimalColumn14.DataType = typeof(int);
            gridViewDecimalColumn14.EnableExpressionEditor = false;
            gridViewDecimalColumn14.FieldName = "Time";
            gridViewDecimalColumn14.HeaderText = "Time";
            gridViewDecimalColumn14.IsAutoGenerated = true;
            gridViewDecimalColumn14.Name = "Time";
            gridViewDateTimeColumn9.DataType = typeof(string);
            gridViewDateTimeColumn9.EnableExpressionEditor = false;
            gridViewDateTimeColumn9.FieldName = "Date";
            gridViewDateTimeColumn9.HeaderText = "Date";
            gridViewDateTimeColumn9.IsAutoGenerated = true;
            gridViewDateTimeColumn9.Name = "Date";
            gridViewDateTimeColumn9.Width = 100;
            gridViewDateTimeColumn10.DataType = typeof(int);
            gridViewDateTimeColumn10.EnableExpressionEditor = false;
            gridViewDateTimeColumn10.FieldName = "Year";
            gridViewDateTimeColumn10.HeaderText = "Year";
            gridViewDateTimeColumn10.IsAutoGenerated = true;
            gridViewDateTimeColumn10.Name = "Year";
            gridViewDateTimeColumn10.Width = 75;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "InsertBy";
            gridViewTextBoxColumn5.HeaderText = "InsertBy";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "InsertBy";
            gridViewTextBoxColumn5.Width = 85;
            gridViewDateTimeColumn11.EnableExpressionEditor = false;
            gridViewDateTimeColumn11.FieldName = "InsertDate";
            gridViewDateTimeColumn11.HeaderText = "InsertDate";
            gridViewDateTimeColumn11.IsAutoGenerated = true;
            gridViewDateTimeColumn11.Name = "InsertDate";
            gridViewDateTimeColumn11.Width = 100;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "LUB";
            gridViewTextBoxColumn6.HeaderText = "LUB";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "LUB";
            gridViewTextBoxColumn6.Width = 85;
            gridViewDateTimeColumn12.EnableExpressionEditor = false;
            gridViewDateTimeColumn12.FieldName = "LUD";
            gridViewDateTimeColumn12.HeaderText = "LUD";
            gridViewDateTimeColumn12.IsAutoGenerated = true;
            gridViewDateTimeColumn12.Name = "LUD";
            gridViewDateTimeColumn12.Width = 100;
            gridViewDecimalColumn15.DataType = typeof(int);
            gridViewDecimalColumn15.EnableExpressionEditor = false;
            gridViewDecimalColumn15.FieldName = "LUN";
            gridViewDecimalColumn15.HeaderText = "LUN";
            gridViewDecimalColumn15.IsAutoGenerated = true;
            gridViewDecimalColumn15.Name = "LUN";
            this.dgvScheduleList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn11,
            gridViewDecimalColumn12,
            gridViewDecimalColumn13,
            gridViewDecimalColumn14,
            gridViewDateTimeColumn9,
            gridViewDateTimeColumn10,
            gridViewTextBoxColumn5,
            gridViewDateTimeColumn11,
            gridViewTextBoxColumn6,
            gridViewDateTimeColumn12,
            gridViewDecimalColumn15});
            this.dgvScheduleList.MasterTemplate.DataSource = this.bsrcScheduleList;
            this.dgvScheduleList.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.dgvScheduleList.Name = "dgvScheduleList";
            this.dgvScheduleList.ReadOnly = true;
            this.dgvScheduleList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvScheduleList.Size = new System.Drawing.Size(673, 412);
            this.dgvScheduleList.TabIndex = 5;
            this.dgvScheduleList.ThemeName = "CrystalDark";
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
            this.grbSearchSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSearchSchedule.ForeColor = System.Drawing.Color.White;
            this.grbSearchSchedule.Location = new System.Drawing.Point(12, 3);
            this.grbSearchSchedule.Name = "grbSearchSchedule";
            this.grbSearchSchedule.Size = new System.Drawing.Size(649, 133);
            this.grbSearchSchedule.TabIndex = 4;
            this.grbSearchSchedule.TabStop = false;
            this.grbSearchSchedule.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnSearch.Location = new System.Drawing.Point(342, 78);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(146, 28);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.btnViewAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewAll.FlatAppearance.BorderSize = 0;
            this.btnViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnViewAll.Location = new System.Drawing.Point(156, 78);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(146, 28);
            this.btnViewAll.TabIndex = 4;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click_1);
            // 
            // cmbSelectDay
            // 
            this.cmbSelectDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.cmbSelectDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSelectDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectDay.ForeColor = System.Drawing.Color.White;
            this.cmbSelectDay.FormattingEnabled = true;
            this.cmbSelectDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.cmbSelectDay.Location = new System.Drawing.Point(432, 27);
            this.cmbSelectDay.Name = "cmbSelectDay";
            this.cmbSelectDay.Size = new System.Drawing.Size(181, 24);
            this.cmbSelectDay.TabIndex = 1;
            // 
            // lblSelectDay
            // 
            this.lblSelectDay.AutoSize = true;
            this.lblSelectDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDay.ForeColor = System.Drawing.Color.White;
            this.lblSelectDay.Location = new System.Drawing.Point(352, 30);
            this.lblSelectDay.Name = "lblSelectDay";
            this.lblSelectDay.Size = new System.Drawing.Size(74, 16);
            this.lblSelectDay.TabIndex = 62;
            this.lblSelectDay.Text = "Select Day";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panel2.Location = new System.Drawing.Point(432, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(181, 1);
            this.panel2.TabIndex = 61;
            // 
            // cmbSelectClass
            // 
            this.cmbSelectClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.cmbSelectClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSelectClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectClass.ForeColor = System.Drawing.Color.White;
            this.cmbSelectClass.FormattingEnabled = true;
            this.cmbSelectClass.Items.AddRange(new object[] {
            "Class 1",
            "Class 2",
            "Class 3",
            "Class 4",
            "Class 5",
            "Class 6",
            "Class 7",
            "Class 8",
            "Class 9"});
            this.cmbSelectClass.Location = new System.Drawing.Point(125, 27);
            this.cmbSelectClass.Name = "cmbSelectClass";
            this.cmbSelectClass.Size = new System.Drawing.Size(181, 24);
            this.cmbSelectClass.TabIndex = 0;
            // 
            // lblSelectClass
            // 
            this.lblSelectClass.AutoSize = true;
            this.lblSelectClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectClass.ForeColor = System.Drawing.Color.White;
            this.lblSelectClass.Location = new System.Drawing.Point(36, 30);
            this.lblSelectClass.Name = "lblSelectClass";
            this.lblSelectClass.Size = new System.Drawing.Size(83, 16);
            this.lblSelectClass.TabIndex = 59;
            this.lblSelectClass.Text = "Select Class";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panel3.Location = new System.Drawing.Point(125, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(181, 1);
            this.panel3.TabIndex = 58;
            // 
            // ClassScheduletList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(673, 563);
            this.Controls.Add(this.dgvScheduleList);
            this.Controls.Add(this.grbSearchSchedule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClassScheduletList";
            this.Text = "ClassScheduleList";
            this.Load += new System.EventHandler(this.ClassScheduletList_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.bsrcScheduleList)).EndInit();
            this.cmsScheduleContext.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduleList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduleList)).EndInit();
            this.grbSearchSchedule.ResumeLayout(false);
            this.grbSearchSchedule.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.Themes.CrystalDarkTheme crystalDarkTheme1;
        private System.Windows.Forms.BindingSource bsrcScheduleList;
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
    }
}