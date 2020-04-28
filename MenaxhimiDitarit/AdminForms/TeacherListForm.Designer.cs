namespace MenaxhimiDitarit
{
    partial class TeacherListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherListForm));
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn3 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
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
            this.grbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cmsTeacherContext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherList.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcTeacherList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panel1.Location = new System.Drawing.Point(49, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 1);
            this.panel1.TabIndex = 7;
            // 
            // txtSearchName
            // 
            this.txtSearchName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.txtSearchName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchName.ForeColor = System.Drawing.Color.White;
            this.txtSearchName.Location = new System.Drawing.Point(49, 31);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(312, 15);
            this.txtSearchName.TabIndex = 0;
            this.txtSearchName.Text = "Search by Name";
            this.txtSearchName.Click += new System.EventHandler(this.txtSearchName_Click);
            this.txtSearchName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchName_KeyDown);
            // 
            // grbSearch
            // 
            this.grbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbSearch.Controls.Add(this.btnSearchTeachers);
            this.grbSearch.Controls.Add(this.btnViewAll);
            this.grbSearch.Controls.Add(this.pictureBox1);
            this.grbSearch.Controls.Add(this.panel1);
            this.grbSearch.Controls.Add(this.txtSearchName);
            this.grbSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSearch.ForeColor = System.Drawing.Color.White;
            this.grbSearch.Location = new System.Drawing.Point(146, 12);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Size = new System.Drawing.Size(380, 111);
            this.grbSearch.TabIndex = 0;
            this.grbSearch.TabStop = false;
            this.grbSearch.Text = "Search Teacher";
            // 
            // btnSearchTeachers
            // 
            this.btnSearchTeachers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.btnSearchTeachers.FlatAppearance.BorderSize = 0;
            this.btnSearchTeachers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchTeachers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnSearchTeachers.Location = new System.Drawing.Point(241, 64);
            this.btnSearchTeachers.Name = "btnSearchTeachers";
            this.btnSearchTeachers.Size = new System.Drawing.Size(120, 32);
            this.btnSearchTeachers.TabIndex = 1;
            this.btnSearchTeachers.Text = "Search";
            this.btnSearchTeachers.UseVisualStyleBackColor = false;
            this.btnSearchTeachers.Click += new System.EventHandler(this.btnSearchTeachers_Click);
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
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAllTeachers_Click);
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
            // cmsTeacherContext
            // 
            this.cmsTeacherContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem});
            this.cmsTeacherContext.Name = "cmsTeacherContext";
            this.cmsTeacherContext.Size = new System.Drawing.Size(113, 26);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updateToolStripMenuItem.Image")));
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // dgvTeacherList
            // 
            this.dgvTeacherList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.dgvTeacherList.ContextMenuStrip = this.cmsTeacherContext;
            this.dgvTeacherList.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvTeacherList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvTeacherList.ForeColor = System.Drawing.Color.White;
            this.dgvTeacherList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvTeacherList.Location = new System.Drawing.Point(0, 137);
            // 
            // 
            // 
            this.dgvTeacherList.MasterTemplate.AllowAddNewRow = false;
            this.dgvTeacherList.MasterTemplate.AllowCellContextMenu = false;
            this.dgvTeacherList.MasterTemplate.AllowColumnReorder = false;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "TeacherID";
            gridViewDecimalColumn1.HeaderText = "TeacherID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "TeacherID";
            gridViewDecimalColumn1.Width = 75;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "FirstName";
            gridViewTextBoxColumn1.HeaderText = "FirstName";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "FirstName";
            gridViewTextBoxColumn1.Width = 100;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "LastName";
            gridViewTextBoxColumn2.HeaderText = "LastName";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "LastName";
            gridViewTextBoxColumn2.Width = 100;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "Gender";
            gridViewTextBoxColumn3.HeaderText = "Gender";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "Gender";
            gridViewTextBoxColumn3.Width = 75;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "City";
            gridViewTextBoxColumn4.HeaderText = "City";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "City";
            gridViewTextBoxColumn4.Width = 85;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "Qualification";
            gridViewTextBoxColumn5.HeaderText = "Qualification";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "Qualification";
            gridViewTextBoxColumn5.Width = 85;
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "DayofBirth";
            gridViewDateTimeColumn1.HeaderText = "DayofBirth";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "DayofBirth";
            gridViewDateTimeColumn1.Width = 100;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "Email";
            gridViewTextBoxColumn6.HeaderText = "Email";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "Email";
            gridViewTextBoxColumn6.Width = 125;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "PhoneNo";
            gridViewTextBoxColumn7.HeaderText = "PhoneNo";
            gridViewTextBoxColumn7.IsAutoGenerated = true;
            gridViewTextBoxColumn7.Name = "PhoneNo";
            gridViewTextBoxColumn7.Width = 100;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "InsertBy";
            gridViewTextBoxColumn8.HeaderText = "InsertBy";
            gridViewTextBoxColumn8.IsAutoGenerated = true;
            gridViewTextBoxColumn8.Name = "InsertBy";
            gridViewTextBoxColumn8.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn8.Width = 85;
            gridViewDateTimeColumn2.EnableExpressionEditor = false;
            gridViewDateTimeColumn2.FieldName = "InsertDate";
            gridViewDateTimeColumn2.HeaderText = "InsertDate";
            gridViewDateTimeColumn2.IsAutoGenerated = true;
            gridViewDateTimeColumn2.Name = "InsertDate";
            gridViewDateTimeColumn2.Width = 100;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "LUB";
            gridViewTextBoxColumn9.HeaderText = "LUB";
            gridViewTextBoxColumn9.IsAutoGenerated = true;
            gridViewTextBoxColumn9.Name = "LUB";
            gridViewTextBoxColumn9.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn9.Width = 85;
            gridViewDateTimeColumn3.EnableExpressionEditor = false;
            gridViewDateTimeColumn3.FieldName = "LUD";
            gridViewDateTimeColumn3.HeaderText = "LUD";
            gridViewDateTimeColumn3.IsAutoGenerated = true;
            gridViewDateTimeColumn3.Name = "LUD";
            gridViewDateTimeColumn3.Width = 100;
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "LUN";
            gridViewDecimalColumn2.HeaderText = "LUN";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "LUN";
            this.dgvTeacherList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewDateTimeColumn2,
            gridViewTextBoxColumn9,
            gridViewDateTimeColumn3,
            gridViewDecimalColumn2});
            this.dgvTeacherList.MasterTemplate.DataSource = this.bsrcTeacherList;
            this.dgvTeacherList.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgvTeacherList.Name = "dgvTeacherList";
            this.dgvTeacherList.ReadOnly = true;
            this.dgvTeacherList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvTeacherList.Size = new System.Drawing.Size(673, 426);
            this.dgvTeacherList.TabIndex = 9;
            this.dgvTeacherList.ThemeName = "CrystalDark";
            // 
            // bsrcTeacherList
            // 
            this.bsrcTeacherList.DataSource = typeof(MenaxhimiDitarit.BO.Teacher);
            // 
            // TeacherListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(673, 563);
            this.Controls.Add(this.dgvTeacherList);
            this.Controls.Add(this.grbSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeacherListForm";
            this.Text = "TeacherList";
            this.Load += new System.EventHandler(this.TeacherListForm_Load);
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cmsTeacherContext.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcTeacherList)).EndInit();
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
    }
}