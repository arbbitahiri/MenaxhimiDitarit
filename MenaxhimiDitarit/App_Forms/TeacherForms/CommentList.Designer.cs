namespace MenaxhimiDitarit.TeacherForms
{
    partial class CommentList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommentList));
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.dtpSelectDay = new System.Windows.Forms.DateTimePicker();
            this.cmbSelectSubject = new System.Windows.Forms.ComboBox();
            this.lblSelectSubject = new System.Windows.Forms.Label();
            this.lblSelectDay = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvCommentList = new Telerik.WinControls.UI.RadGridView();
            this.bsrcComment = new System.Windows.Forms.BindingSource(this.components);
            this.crystalDarkTheme1 = new Telerik.WinControls.Themes.CrystalDarkTheme();
            this.cmsComment = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommentList.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcComment)).BeginInit();
            this.cmsComment.SuspendLayout();
            this.SuspendLayout();
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
            // dgvCommentList
            // 
            this.dgvCommentList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.dgvCommentList.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.dgvCommentList, "dgvCommentList");
            this.dgvCommentList.ForeColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.dgvCommentList.MasterTemplate.AllowAddNewRow = false;
            this.dgvCommentList.MasterTemplate.AllowColumnReorder = false;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "CommentID";
            resources.ApplyResources(gridViewDecimalColumn1, "gridViewDecimalColumn1");
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "CommentID";
            gridViewDecimalColumn1.Width = 85;
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "TopicID";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "TopicID";
            gridViewDecimalColumn2.Width = 85;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Comments";
            resources.ApplyResources(gridViewTextBoxColumn1, "gridViewTextBoxColumn1");
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "Comments";
            gridViewTextBoxColumn1.Width = 100;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Review";
            resources.ApplyResources(gridViewTextBoxColumn2, "gridViewTextBoxColumn2");
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "Review";
            gridViewTextBoxColumn2.Width = 100;
            gridViewTextBoxColumn3.DataType = typeof(MenaxhimiDitarit.BO.Topic);
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "Topic";
            resources.ApplyResources(gridViewTextBoxColumn3, "gridViewTextBoxColumn3");
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "Topic";
            gridViewTextBoxColumn3.Width = 100;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "InsertBy";
            resources.ApplyResources(gridViewTextBoxColumn4, "gridViewTextBoxColumn4");
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "InsertBy";
            gridViewTextBoxColumn4.Width = 85;
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "InsertDate";
            resources.ApplyResources(gridViewDateTimeColumn1, "gridViewDateTimeColumn1");
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "InsertDate";
            gridViewDateTimeColumn1.Width = 150;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "LUB";
            resources.ApplyResources(gridViewTextBoxColumn5, "gridViewTextBoxColumn5");
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "LUB";
            gridViewTextBoxColumn5.Width = 85;
            gridViewDateTimeColumn2.EnableExpressionEditor = false;
            gridViewDateTimeColumn2.FieldName = "LUD";
            resources.ApplyResources(gridViewDateTimeColumn2, "gridViewDateTimeColumn2");
            gridViewDateTimeColumn2.IsAutoGenerated = true;
            gridViewDateTimeColumn2.Name = "LUD";
            gridViewDateTimeColumn2.Width = 150;
            gridViewDecimalColumn3.DataType = typeof(int);
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "LUN";
            resources.ApplyResources(gridViewDecimalColumn3, "gridViewDecimalColumn3");
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.Name = "LUN";
            this.dgvCommentList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn5,
            gridViewDateTimeColumn2,
            gridViewDecimalColumn3});
            this.dgvCommentList.MasterTemplate.DataSource = this.bsrcComment;
            this.dgvCommentList.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgvCommentList.Name = "dgvCommentList";
            this.dgvCommentList.ReadOnly = true;
            this.dgvCommentList.ThemeName = "CrystalDark";
            // 
            // bsrcComment
            // 
            this.bsrcComment.DataSource = typeof(MenaxhimiDitarit.BO.Comment);
            // 
            // cmsComment
            // 
            this.cmsComment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem});
            this.cmsComment.Name = "cmsComment";
            resources.ApplyResources(this.cmsComment, "cmsComment");
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            resources.ApplyResources(this.updateToolStripMenuItem, "updateToolStripMenuItem");
            // 
            // CommentList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.Controls.Add(this.dgvCommentList);
            this.Controls.Add(this.grbSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CommentList";
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommentList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcComment)).EndInit();
            this.cmsComment.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.DateTimePicker dtpSelectDay;
        private System.Windows.Forms.ComboBox cmbSelectSubject;
        private System.Windows.Forms.Label lblSelectSubject;
        private System.Windows.Forms.Label lblSelectDay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private Telerik.WinControls.UI.RadGridView dgvCommentList;
        private Telerik.WinControls.Themes.CrystalDarkTheme crystalDarkTheme1;
        private System.Windows.Forms.BindingSource bsrcComment;
        private System.Windows.Forms.ContextMenuStrip cmsComment;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
    }
}