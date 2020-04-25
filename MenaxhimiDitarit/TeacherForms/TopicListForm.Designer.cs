namespace MenaxhimiDitarit.TeacherForms
{
    partial class TopicListForm
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
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.cmbSelectSubject = new System.Windows.Forms.ComboBox();
            this.lblSelectSubject = new System.Windows.Forms.Label();
            this.lblSelectDay = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbSelectTeacher = new System.Windows.Forms.ComboBox();
            this.lblSelectTeacher = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtpSelectDay = new System.Windows.Forms.DateTimePicker();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvTopicList = new System.Windows.Forms.DataGridView();
            this.grbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopicList)).BeginInit();
            this.SuspendLayout();
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.btnSearch);
            this.grbSearch.Controls.Add(this.btnViewAll);
            this.grbSearch.Controls.Add(this.dtpSelectDay);
            this.grbSearch.Controls.Add(this.cmbSelectTeacher);
            this.grbSearch.Controls.Add(this.lblSelectTeacher);
            this.grbSearch.Controls.Add(this.panel4);
            this.grbSearch.Controls.Add(this.cmbSelectSubject);
            this.grbSearch.Controls.Add(this.lblSelectSubject);
            this.grbSearch.Controls.Add(this.lblSelectDay);
            this.grbSearch.Controls.Add(this.panel1);
            this.grbSearch.Controls.Add(this.panel3);
            this.grbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSearch.ForeColor = System.Drawing.Color.White;
            this.grbSearch.Location = new System.Drawing.Point(12, 12);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Size = new System.Drawing.Size(649, 106);
            this.grbSearch.TabIndex = 0;
            this.grbSearch.TabStop = false;
            this.grbSearch.Text = "Search Topic";
            // 
            // cmbSelectSubject
            // 
            this.cmbSelectSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.cmbSelectSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSelectSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectSubject.ForeColor = System.Drawing.Color.White;
            this.cmbSelectSubject.FormattingEnabled = true;
            this.cmbSelectSubject.Location = new System.Drawing.Point(112, 25);
            this.cmbSelectSubject.Name = "cmbSelectSubject";
            this.cmbSelectSubject.Size = new System.Drawing.Size(181, 24);
            this.cmbSelectSubject.TabIndex = 68;
            // 
            // lblSelectSubject
            // 
            this.lblSelectSubject.AutoSize = true;
            this.lblSelectSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectSubject.ForeColor = System.Drawing.Color.White;
            this.lblSelectSubject.Location = new System.Drawing.Point(12, 28);
            this.lblSelectSubject.Name = "lblSelectSubject";
            this.lblSelectSubject.Size = new System.Drawing.Size(94, 16);
            this.lblSelectSubject.TabIndex = 74;
            this.lblSelectSubject.Text = "Select Subject";
            // 
            // lblSelectDay
            // 
            this.lblSelectDay.AutoSize = true;
            this.lblSelectDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDay.ForeColor = System.Drawing.Color.White;
            this.lblSelectDay.Location = new System.Drawing.Point(32, 65);
            this.lblSelectDay.Name = "lblSelectDay";
            this.lblSelectDay.Size = new System.Drawing.Size(74, 16);
            this.lblSelectDay.TabIndex = 72;
            this.lblSelectDay.Text = "Select Day";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panel1.Location = new System.Drawing.Point(112, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 1);
            this.panel1.TabIndex = 71;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panel3.Location = new System.Drawing.Point(112, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(181, 1);
            this.panel3.TabIndex = 69;
            // 
            // cmbSelectTeacher
            // 
            this.cmbSelectTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.cmbSelectTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSelectTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectTeacher.ForeColor = System.Drawing.Color.White;
            this.cmbSelectTeacher.FormattingEnabled = true;
            this.cmbSelectTeacher.Location = new System.Drawing.Point(448, 25);
            this.cmbSelectTeacher.Name = "cmbSelectTeacher";
            this.cmbSelectTeacher.Size = new System.Drawing.Size(181, 24);
            this.cmbSelectTeacher.TabIndex = 75;
            // 
            // lblSelectTeacher
            // 
            this.lblSelectTeacher.AutoSize = true;
            this.lblSelectTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTeacher.ForeColor = System.Drawing.Color.White;
            this.lblSelectTeacher.Location = new System.Drawing.Point(342, 28);
            this.lblSelectTeacher.Name = "lblSelectTeacher";
            this.lblSelectTeacher.Size = new System.Drawing.Size(100, 16);
            this.lblSelectTeacher.TabIndex = 77;
            this.lblSelectTeacher.Text = "Select Teacher";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panel4.Location = new System.Drawing.Point(448, 55);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(181, 1);
            this.panel4.TabIndex = 76;
            // 
            // dtpSelectDay
            // 
            this.dtpSelectDay.CustomFormat = "ddMMMMyyyy";
            this.dtpSelectDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSelectDay.Location = new System.Drawing.Point(112, 64);
            this.dtpSelectDay.Name = "dtpSelectDay";
            this.dtpSelectDay.Size = new System.Drawing.Size(181, 22);
            this.dtpSelectDay.TabIndex = 78;
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.btnViewAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewAll.FlatAppearance.BorderSize = 0;
            this.btnViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnViewAll.Location = new System.Drawing.Point(345, 65);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(116, 28);
            this.btnViewAll.TabIndex = 79;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnSearch.Location = new System.Drawing.Point(513, 65);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(116, 28);
            this.btnSearch.TabIndex = 80;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgvTopicList
            // 
            this.dgvTopicList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopicList.Location = new System.Drawing.Point(12, 124);
            this.dgvTopicList.Name = "dgvTopicList";
            this.dgvTopicList.Size = new System.Drawing.Size(649, 427);
            this.dgvTopicList.TabIndex = 1;
            // 
            // TopicListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(673, 563);
            this.Controls.Add(this.dgvTopicList);
            this.Controls.Add(this.grbSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TopicListForm";
            this.Text = "TopicListForm";
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopicList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.ComboBox cmbSelectSubject;
        private System.Windows.Forms.Label lblSelectSubject;
        private System.Windows.Forms.Label lblSelectDay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpSelectDay;
        private System.Windows.Forms.ComboBox cmbSelectTeacher;
        private System.Windows.Forms.Label lblSelectTeacher;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvTopicList;
    }
}