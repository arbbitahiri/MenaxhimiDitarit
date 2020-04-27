namespace MenaxhimiDitarit
{
    partial class SubjectListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectListForm));
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn3 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn4 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn6 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.btnSearchSubject = new System.Windows.Forms.Button();
            this.btnViewAllSubjects = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearchSubject = new System.Windows.Forms.TextBox();
            this.crystalDarkTheme1 = new Telerik.WinControls.Themes.CrystalDarkTheme();
            this.cmsSubjectContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvSubjectList = new Telerik.WinControls.UI.RadGridView();
            this.bsrcSubjectList = new System.Windows.Forms.BindingSource(this.components);
            this.grbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cmsSubjectContext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjectList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjectList.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcSubjectList)).BeginInit();
            this.SuspendLayout();
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.btnSearchSubject);
            this.grbSearch.Controls.Add(this.btnViewAllSubjects);
            this.grbSearch.Controls.Add(this.pictureBox1);
            this.grbSearch.Controls.Add(this.panel1);
            this.grbSearch.Controls.Add(this.txtSearchSubject);
            this.grbSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSearch.ForeColor = System.Drawing.Color.White;
            this.grbSearch.Location = new System.Drawing.Point(113, 12);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Size = new System.Drawing.Size(446, 111);
            this.grbSearch.TabIndex = 11;
            this.grbSearch.TabStop = false;
            this.grbSearch.Text = "Search";
            // 
            // btnSearchSubject
            // 
            this.btnSearchSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.btnSearchSubject.FlatAppearance.BorderSize = 0;
            this.btnSearchSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnSearchSubject.Location = new System.Drawing.Point(259, 68);
            this.btnSearchSubject.Name = "btnSearchSubject";
            this.btnSearchSubject.Size = new System.Drawing.Size(172, 32);
            this.btnSearchSubject.TabIndex = 9;
            this.btnSearchSubject.Text = "Search";
            this.btnSearchSubject.UseVisualStyleBackColor = false;
            this.btnSearchSubject.Click += new System.EventHandler(this.btnSearchSubject_Click);
            // 
            // btnViewAllSubjects
            // 
            this.btnViewAllSubjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.btnViewAllSubjects.FlatAppearance.BorderSize = 0;
            this.btnViewAllSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAllSubjects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnViewAllSubjects.Location = new System.Drawing.Point(8, 68);
            this.btnViewAllSubjects.Name = "btnViewAllSubjects";
            this.btnViewAllSubjects.Size = new System.Drawing.Size(168, 32);
            this.btnViewAllSubjects.TabIndex = 9;
            this.btnViewAllSubjects.Text = "View All Subjects";
            this.btnViewAllSubjects.UseVisualStyleBackColor = false;
            this.btnViewAllSubjects.Click += new System.EventHandler(this.btnViewAllSubjects_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 25);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panel1.Location = new System.Drawing.Point(17, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 1);
            this.panel1.TabIndex = 7;
            // 
            // txtSearchSubject
            // 
            this.txtSearchSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.txtSearchSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchSubject.ForeColor = System.Drawing.Color.White;
            this.txtSearchSubject.Location = new System.Drawing.Point(47, 30);
            this.txtSearchSubject.Name = "txtSearchSubject";
            this.txtSearchSubject.Size = new System.Drawing.Size(393, 15);
            this.txtSearchSubject.TabIndex = 5;
            this.txtSearchSubject.Text = "Search by Subject Title, Book or Book Author";
            this.txtSearchSubject.Click += new System.EventHandler(this.txtSearchNameSubject_Click);
            this.txtSearchSubject.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchSubject_KeyDown);
            // 
            // cmsSubjectContext
            // 
            this.cmsSubjectContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsSubjectContext.Name = "cmsSubjectContext";
            this.cmsSubjectContext.Size = new System.Drawing.Size(113, 48);
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
            // dgvSubjectList
            // 
            this.dgvSubjectList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.dgvSubjectList.ContextMenuStrip = this.cmsSubjectContext;
            this.dgvSubjectList.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvSubjectList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSubjectList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvSubjectList.ForeColor = System.Drawing.Color.White;
            this.dgvSubjectList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvSubjectList.Location = new System.Drawing.Point(0, 129);
            // 
            // 
            // 
            this.dgvSubjectList.MasterTemplate.AllowAddNewRow = false;
            this.dgvSubjectList.MasterTemplate.AllowCellContextMenu = false;
            this.dgvSubjectList.MasterTemplate.AllowColumnReorder = false;
            gridViewDecimalColumn4.DataType = typeof(int);
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.FieldName = "SubjectID";
            gridViewDecimalColumn4.HeaderText = "SubjectID";
            gridViewDecimalColumn4.IsAutoGenerated = true;
            gridViewDecimalColumn4.Name = "SubjectID";
            gridViewDecimalColumn4.Width = 75;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "SubjectTitle";
            gridViewTextBoxColumn6.HeaderText = "SubjectTitle";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "SubjectTitle";
            gridViewTextBoxColumn6.Width = 100;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "Book";
            gridViewTextBoxColumn7.HeaderText = "Book";
            gridViewTextBoxColumn7.IsAutoGenerated = true;
            gridViewTextBoxColumn7.Name = "Book";
            gridViewTextBoxColumn7.Width = 100;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "Book_Author";
            gridViewTextBoxColumn8.HeaderText = "Book_Author";
            gridViewTextBoxColumn8.IsAutoGenerated = true;
            gridViewTextBoxColumn8.Name = "Book_Author";
            gridViewTextBoxColumn8.Width = 100;
            gridViewDecimalColumn5.DataType = typeof(int);
            gridViewDecimalColumn5.EnableExpressionEditor = false;
            gridViewDecimalColumn5.FieldName = "TeacherID";
            gridViewDecimalColumn5.HeaderText = "TeacherID";
            gridViewDecimalColumn5.IsAutoGenerated = true;
            gridViewDecimalColumn5.Name = "TeacherID";
            gridViewDecimalColumn5.Width = 75;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "InsertBy";
            gridViewTextBoxColumn9.HeaderText = "InsertBy";
            gridViewTextBoxColumn9.IsAutoGenerated = true;
            gridViewTextBoxColumn9.Name = "InsertBy";
            gridViewTextBoxColumn9.Width = 85;
            gridViewDateTimeColumn3.EnableExpressionEditor = false;
            gridViewDateTimeColumn3.FieldName = "InsertDate";
            gridViewDateTimeColumn3.HeaderText = "InsertDate";
            gridViewDateTimeColumn3.IsAutoGenerated = true;
            gridViewDateTimeColumn3.Name = "InsertDate";
            gridViewDateTimeColumn3.Width = 100;
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.FieldName = "LUB";
            gridViewTextBoxColumn10.HeaderText = "LUB";
            gridViewTextBoxColumn10.IsAutoGenerated = true;
            gridViewTextBoxColumn10.Name = "LUB";
            gridViewTextBoxColumn10.Width = 85;
            gridViewDateTimeColumn4.EnableExpressionEditor = false;
            gridViewDateTimeColumn4.FieldName = "LUD";
            gridViewDateTimeColumn4.HeaderText = "LUD";
            gridViewDateTimeColumn4.IsAutoGenerated = true;
            gridViewDateTimeColumn4.Name = "LUD";
            gridViewDateTimeColumn4.Width = 100;
            gridViewDecimalColumn6.DataType = typeof(int);
            gridViewDecimalColumn6.EnableExpressionEditor = false;
            gridViewDecimalColumn6.FieldName = "LUN";
            gridViewDecimalColumn6.HeaderText = "LUN";
            gridViewDecimalColumn6.IsAutoGenerated = true;
            gridViewDecimalColumn6.Name = "LUN";
            this.dgvSubjectList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn4,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewDecimalColumn5,
            gridViewTextBoxColumn9,
            gridViewDateTimeColumn3,
            gridViewTextBoxColumn10,
            gridViewDateTimeColumn4,
            gridViewDecimalColumn6});
            this.dgvSubjectList.MasterTemplate.DataSource = this.bsrcSubjectList;
            this.dgvSubjectList.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.dgvSubjectList.Name = "dgvSubjectList";
            this.dgvSubjectList.ReadOnly = true;
            this.dgvSubjectList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvSubjectList.Size = new System.Drawing.Size(673, 434);
            this.dgvSubjectList.TabIndex = 14;
            this.dgvSubjectList.ThemeName = "CrystalDark";
            // 
            // bsrcSubjectList
            // 
            this.bsrcSubjectList.DataSource = typeof(MenaxhimiDitarit.BO.Subject);
            // 
            // SubjectListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(673, 563);
            this.Controls.Add(this.dgvSubjectList);
            this.Controls.Add(this.grbSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubjectListForm";
            this.Text = "SubjectListForm";
            this.Load += new System.EventHandler(this.SubjectListForm_Load);
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cmsSubjectContext.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjectList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjectList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcSubjectList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.Button btnSearchSubject;
        private System.Windows.Forms.Button btnViewAllSubjects;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearchSubject;
        private Telerik.WinControls.Themes.CrystalDarkTheme crystalDarkTheme1;
        private System.Windows.Forms.ContextMenuStrip cmsSubjectContext;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private Telerik.WinControls.UI.RadGridView dgvSubjectList;
        private System.Windows.Forms.BindingSource bsrcSubjectList;
    }
}