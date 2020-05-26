namespace MenaxhimiDitarit.TeacherForms
{
    partial class AbsenceList
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbsenceList));
            this.dgvAbsenceList = new Telerik.WinControls.UI.RadGridView();
            this.cmsAbsence = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bsrcAbsence = new System.Windows.Forms.BindingSource(this.components);
            this.crystalDarkTheme1 = new Telerik.WinControls.Themes.CrystalDarkTheme();
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.dtpSelectDay = new System.Windows.Forms.DateTimePicker();
            this.cmbSelectSubject = new System.Windows.Forms.ComboBox();
            this.lblSelectSubject = new System.Windows.Forms.Label();
            this.lblSelectDay = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsenceList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsenceList.MasterTemplate)).BeginInit();
            this.cmsAbsence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcAbsence)).BeginInit();
            this.grbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAbsenceList
            // 
            this.dgvAbsenceList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.dgvAbsenceList.ContextMenuStrip = this.cmsAbsence;
            this.dgvAbsenceList.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.dgvAbsenceList, "dgvAbsenceList");
            this.dgvAbsenceList.ForeColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.dgvAbsenceList.MasterTemplate.AllowAddNewRow = false;
            this.dgvAbsenceList.MasterTemplate.AllowCellContextMenu = false;
            this.dgvAbsenceList.MasterTemplate.AllowColumnReorder = false;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "AbsencesID";
            resources.ApplyResources(gridViewDecimalColumn1, "gridViewDecimalColumn1");
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "AbsencesID";
            gridViewDecimalColumn1.Width = 85;
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "TopicID";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "TopicID";
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Reasoning";
            resources.ApplyResources(gridViewTextBoxColumn1, "gridViewTextBoxColumn1");
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "Reasoning";
            gridViewTextBoxColumn1.Width = 100;
            gridViewDecimalColumn3.DataType = typeof(int);
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "NoStudents";
            resources.ApplyResources(gridViewDecimalColumn3, "gridViewDecimalColumn3");
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.Name = "NoStudents";
            gridViewDecimalColumn3.Width = 85;
            gridViewTextBoxColumn2.DataType = typeof(MenaxhimiDitarit.BO.Topic);
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Topic";
            resources.ApplyResources(gridViewTextBoxColumn2, "gridViewTextBoxColumn2");
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "Topic";
            gridViewTextBoxColumn2.Width = 100;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "InsertBy";
            resources.ApplyResources(gridViewTextBoxColumn3, "gridViewTextBoxColumn3");
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "InsertBy";
            gridViewTextBoxColumn3.Width = 85;
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "InsertDate";
            resources.ApplyResources(gridViewDateTimeColumn1, "gridViewDateTimeColumn1");
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "InsertDate";
            gridViewDateTimeColumn1.Width = 150;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "LUB";
            resources.ApplyResources(gridViewTextBoxColumn4, "gridViewTextBoxColumn4");
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "LUB";
            gridViewTextBoxColumn4.Width = 85;
            gridViewDateTimeColumn2.EnableExpressionEditor = false;
            gridViewDateTimeColumn2.FieldName = "LUD";
            resources.ApplyResources(gridViewDateTimeColumn2, "gridViewDateTimeColumn2");
            gridViewDateTimeColumn2.IsAutoGenerated = true;
            gridViewDateTimeColumn2.Name = "LUD";
            gridViewDateTimeColumn2.Width = 150;
            gridViewDecimalColumn4.DataType = typeof(int);
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.FieldName = "LUN";
            resources.ApplyResources(gridViewDecimalColumn4, "gridViewDecimalColumn4");
            gridViewDecimalColumn4.IsAutoGenerated = true;
            gridViewDecimalColumn4.Name = "LUN";
            this.dgvAbsenceList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewTextBoxColumn1,
            gridViewDecimalColumn3,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn4,
            gridViewDateTimeColumn2,
            gridViewDecimalColumn4});
            this.dgvAbsenceList.MasterTemplate.DataSource = this.bsrcAbsence;
            this.dgvAbsenceList.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgvAbsenceList.Name = "dgvAbsenceList";
            this.dgvAbsenceList.ReadOnly = true;
            this.dgvAbsenceList.ThemeName = "CrystalDark";
            // 
            // cmsAbsence
            // 
            this.cmsAbsence.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem});
            this.cmsAbsence.Name = "cmsAbsence";
            resources.ApplyResources(this.cmsAbsence, "cmsAbsence");
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            resources.ApplyResources(this.updateToolStripMenuItem, "updateToolStripMenuItem");
            // 
            // bsrcAbsence
            // 
            this.bsrcAbsence.DataSource = typeof(MenaxhimiDitarit.BO.Absence);
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
            // AbsenceList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.Controls.Add(this.grbSearch);
            this.Controls.Add(this.dgvAbsenceList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AbsenceList";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsenceList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsenceList)).EndInit();
            this.cmsAbsence.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsrcAbsence)).EndInit();
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadGridView dgvAbsenceList;
        private Telerik.WinControls.Themes.CrystalDarkTheme crystalDarkTheme1;
        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.DateTimePicker dtpSelectDay;
        private System.Windows.Forms.ComboBox cmbSelectSubject;
        private System.Windows.Forms.Label lblSelectSubject;
        private System.Windows.Forms.Label lblSelectDay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.BindingSource bsrcAbsence;
        private System.Windows.Forms.ContextMenuStrip cmsAbsence;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
    }
}