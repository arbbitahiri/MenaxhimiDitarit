namespace MenaxhimiDitarit
{
    partial class ClassListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassListForm));
            this.dgvClassList = new System.Windows.Forms.DataGridView();
            this.grbSearchClass = new System.Windows.Forms.GroupBox();
            this.btnSearchClass = new System.Windows.Forms.Button();
            this.btnViewAllClass = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearchClass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassList)).BeginInit();
            this.grbSearchClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClassList
            // 
            this.dgvClassList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassList.Location = new System.Drawing.Point(12, 129);
            this.dgvClassList.Name = "dgvClassList";
            this.dgvClassList.Size = new System.Drawing.Size(649, 422);
            this.dgvClassList.TabIndex = 14;
            // 
            // grbSearchClass
            // 
            this.grbSearchClass.Controls.Add(this.btnSearchClass);
            this.grbSearchClass.Controls.Add(this.btnViewAllClass);
            this.grbSearchClass.Controls.Add(this.pictureBox1);
            this.grbSearchClass.Controls.Add(this.panel1);
            this.grbSearchClass.Controls.Add(this.txtSearchClass);
            this.grbSearchClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbSearchClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSearchClass.ForeColor = System.Drawing.Color.White;
            this.grbSearchClass.Location = new System.Drawing.Point(120, 12);
            this.grbSearchClass.Name = "grbSearchClass";
            this.grbSearchClass.Size = new System.Drawing.Size(432, 111);
            this.grbSearchClass.TabIndex = 11;
            this.grbSearchClass.TabStop = false;
            this.grbSearchClass.Text = "Search";
            // 
            // btnSearchClass
            // 
            this.btnSearchClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.btnSearchClass.FlatAppearance.BorderSize = 0;
            this.btnSearchClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnSearchClass.Location = new System.Drawing.Point(246, 68);
            this.btnSearchClass.Name = "btnSearchClass";
            this.btnSearchClass.Size = new System.Drawing.Size(172, 32);
            this.btnSearchClass.TabIndex = 9;
            this.btnSearchClass.Text = "Search";
            this.btnSearchClass.UseVisualStyleBackColor = false;
            // 
            // btnViewAllClass
            // 
            this.btnViewAllClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.btnViewAllClass.FlatAppearance.BorderSize = 0;
            this.btnViewAllClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAllClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnViewAllClass.Location = new System.Drawing.Point(8, 68);
            this.btnViewAllClass.Name = "btnViewAllClass";
            this.btnViewAllClass.Size = new System.Drawing.Size(168, 32);
            this.btnViewAllClass.TabIndex = 9;
            this.btnViewAllClass.Text = "View All Classrooms";
            this.btnViewAllClass.UseVisualStyleBackColor = false;
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
            this.panel1.Size = new System.Drawing.Size(401, 1);
            this.panel1.TabIndex = 7;
            // 
            // txtSearchClass
            // 
            this.txtSearchClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.txtSearchClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchClass.ForeColor = System.Drawing.Color.White;
            this.txtSearchClass.Location = new System.Drawing.Point(47, 30);
            this.txtSearchClass.Name = "txtSearchClass";
            this.txtSearchClass.Size = new System.Drawing.Size(371, 15);
            this.txtSearchClass.TabIndex = 5;
            this.txtSearchClass.Text = "Search by Name";
            // 
            // ClassListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(673, 563);
            this.Controls.Add(this.dgvClassList);
            this.Controls.Add(this.grbSearchClass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClassListForm";
            this.Text = "ClassListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassList)).EndInit();
            this.grbSearchClass.ResumeLayout(false);
            this.grbSearchClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClassList;
        private System.Windows.Forms.GroupBox grbSearchClass;
        private System.Windows.Forms.Button btnSearchClass;
        private System.Windows.Forms.Button btnViewAllClass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearchClass;
    }
}