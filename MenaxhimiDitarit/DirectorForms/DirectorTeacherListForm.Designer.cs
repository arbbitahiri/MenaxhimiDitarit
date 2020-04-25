namespace MenaxhimiDitarit.DirectorForms
{
    partial class DirectorTeacherListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectorTeacherListForm));
            this.dgvTeacherList = new System.Windows.Forms.DataGridView();
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.btnSearchTeachers = new System.Windows.Forms.Button();
            this.btnViewAllTeachers = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.btnUpdateTeacher = new System.Windows.Forms.Button();
            this.btnDeleteTeacher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherList)).BeginInit();
            this.grbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTeacherList
            // 
            this.dgvTeacherList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacherList.Location = new System.Drawing.Point(12, 129);
            this.dgvTeacherList.Name = "dgvTeacherList";
            this.dgvTeacherList.Size = new System.Drawing.Size(649, 422);
            this.dgvTeacherList.TabIndex = 13;
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.btnSearchTeachers);
            this.grbSearch.Controls.Add(this.btnViewAllTeachers);
            this.grbSearch.Controls.Add(this.pictureBox1);
            this.grbSearch.Controls.Add(this.panel1);
            this.grbSearch.Controls.Add(this.txtSearchName);
            this.grbSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSearch.ForeColor = System.Drawing.Color.White;
            this.grbSearch.Location = new System.Drawing.Point(20, 12);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Size = new System.Drawing.Size(446, 111);
            this.grbSearch.TabIndex = 11;
            this.grbSearch.TabStop = false;
            this.grbSearch.Text = "Search";
            // 
            // btnSearchTeachers
            // 
            this.btnSearchTeachers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.btnSearchTeachers.FlatAppearance.BorderSize = 0;
            this.btnSearchTeachers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchTeachers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnSearchTeachers.Location = new System.Drawing.Point(259, 68);
            this.btnSearchTeachers.Name = "btnSearchTeachers";
            this.btnSearchTeachers.Size = new System.Drawing.Size(172, 32);
            this.btnSearchTeachers.TabIndex = 9;
            this.btnSearchTeachers.Text = "Search";
            this.btnSearchTeachers.UseVisualStyleBackColor = false;
            // 
            // btnViewAllTeachers
            // 
            this.btnViewAllTeachers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.btnViewAllTeachers.FlatAppearance.BorderSize = 0;
            this.btnViewAllTeachers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAllTeachers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnViewAllTeachers.Location = new System.Drawing.Point(8, 68);
            this.btnViewAllTeachers.Name = "btnViewAllTeachers";
            this.btnViewAllTeachers.Size = new System.Drawing.Size(168, 32);
            this.btnViewAllTeachers.TabIndex = 9;
            this.btnViewAllTeachers.Text = "View All Teachers";
            this.btnViewAllTeachers.UseVisualStyleBackColor = false;
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
            // txtSearchName
            // 
            this.txtSearchName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.txtSearchName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchName.ForeColor = System.Drawing.Color.White;
            this.txtSearchName.Location = new System.Drawing.Point(47, 30);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(393, 15);
            this.txtSearchName.TabIndex = 5;
            this.txtSearchName.Text = "Search by Name";
            // 
            // btnUpdateTeacher
            // 
            this.btnUpdateTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.btnUpdateTeacher.FlatAppearance.BorderSize = 0;
            this.btnUpdateTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnUpdateTeacher.Location = new System.Drawing.Point(483, 19);
            this.btnUpdateTeacher.Name = "btnUpdateTeacher";
            this.btnUpdateTeacher.Size = new System.Drawing.Size(168, 42);
            this.btnUpdateTeacher.TabIndex = 12;
            this.btnUpdateTeacher.Text = "Update Teacher";
            this.btnUpdateTeacher.UseVisualStyleBackColor = false;
            // 
            // btnDeleteTeacher
            // 
            this.btnDeleteTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.btnDeleteTeacher.FlatAppearance.BorderSize = 0;
            this.btnDeleteTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnDeleteTeacher.Location = new System.Drawing.Point(483, 75);
            this.btnDeleteTeacher.Name = "btnDeleteTeacher";
            this.btnDeleteTeacher.Size = new System.Drawing.Size(168, 42);
            this.btnDeleteTeacher.TabIndex = 14;
            this.btnDeleteTeacher.Text = "Delete Teacher";
            this.btnDeleteTeacher.UseVisualStyleBackColor = false;
            // 
            // DirectorTeacherListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(673, 563);
            this.Controls.Add(this.btnDeleteTeacher);
            this.Controls.Add(this.dgvTeacherList);
            this.Controls.Add(this.grbSearch);
            this.Controls.Add(this.btnUpdateTeacher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DirectorTeacherListForm";
            this.Text = "DirectorTeacherListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherList)).EndInit();
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTeacherList;
        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.Button btnSearchTeachers;
        private System.Windows.Forms.Button btnViewAllTeachers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Button btnUpdateTeacher;
        private System.Windows.Forms.Button btnDeleteTeacher;
    }
}