namespace MenaxhimiDitarit.AdminForms
{
    partial class ClassScheduleCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassScheduleCreate));
            this.cmbSelectTime = new System.Windows.Forms.ComboBox();
            this.cmbSelectSubject = new System.Windows.Forms.ComboBox();
            this.bsrcSubject = new System.Windows.Forms.BindingSource(this.components);
            this.cmbSelectClass = new System.Windows.Forms.ComboBox();
            this.bsrcClass = new System.Windows.Forms.BindingSource(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbSelectDate = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblYear = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnSubmitClass = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.picClass = new System.Windows.Forms.PictureBox();
            this.picSubject = new System.Windows.Forms.PictureBox();
            this.picTime = new System.Windows.Forms.PictureBox();
            this.picDate = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHELP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDate)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSelectTime
            // 
            this.cmbSelectTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.cmbSelectTime.DisplayMember = "RoomType";
            resources.ApplyResources(this.cmbSelectTime, "cmbSelectTime");
            this.cmbSelectTime.ForeColor = System.Drawing.Color.White;
            this.cmbSelectTime.FormattingEnabled = true;
            this.cmbSelectTime.Items.AddRange(new object[] {
            resources.GetString("cmbSelectTime.Items"),
            resources.GetString("cmbSelectTime.Items1"),
            resources.GetString("cmbSelectTime.Items2"),
            resources.GetString("cmbSelectTime.Items3"),
            resources.GetString("cmbSelectTime.Items4"),
            resources.GetString("cmbSelectTime.Items5")});
            this.cmbSelectTime.Name = "cmbSelectTime";
            this.cmbSelectTime.ValueMember = "RoomID";
            this.cmbSelectTime.SelectedIndexChanged += new System.EventHandler(this.cmbSelectTime_SelectedIndexChanged);
            // 
            // cmbSelectSubject
            // 
            this.cmbSelectSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.cmbSelectSubject.DataSource = this.bsrcSubject;
            this.cmbSelectSubject.DisplayMember = "SubjectTitle";
            resources.ApplyResources(this.cmbSelectSubject, "cmbSelectSubject");
            this.cmbSelectSubject.ForeColor = System.Drawing.Color.White;
            this.cmbSelectSubject.FormattingEnabled = true;
            this.cmbSelectSubject.Name = "cmbSelectSubject";
            this.cmbSelectSubject.ValueMember = "SubjectID";
            this.cmbSelectSubject.SelectedIndexChanged += new System.EventHandler(this.cmbSelectSubject_SelectedIndexChanged);
            // 
            // bsrcSubject
            // 
            this.bsrcSubject.DataSource = typeof(MenaxhimiDitarit.BO.Subject);
            // 
            // cmbSelectClass
            // 
            this.cmbSelectClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.cmbSelectClass.DataSource = this.bsrcClass;
            this.cmbSelectClass.DisplayMember = "ClassNo";
            resources.ApplyResources(this.cmbSelectClass, "cmbSelectClass");
            this.cmbSelectClass.ForeColor = System.Drawing.Color.White;
            this.cmbSelectClass.FormattingEnabled = true;
            this.cmbSelectClass.Name = "cmbSelectClass";
            this.cmbSelectClass.ValueMember = "ClassID";
            this.cmbSelectClass.SelectedIndexChanged += new System.EventHandler(this.cmbSelectClass_SelectedIndexChanged);
            // 
            // bsrcClass
            // 
            this.bsrcClass.DataSource = typeof(MenaxhimiDitarit.BO.Class);
            // 
            // lblTime
            // 
            resources.ApplyResources(this.lblTime, "lblTime");
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Name = "lblTime";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtID, "txtID");
            this.txtID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            // 
            // lblSubject
            // 
            resources.ApplyResources(this.lblSubject, "lblSubject");
            this.lblSubject.ForeColor = System.Drawing.Color.White;
            this.lblSubject.Name = "lblSubject";
            // 
            // lblClass
            // 
            resources.ApplyResources(this.lblClass, "lblClass");
            this.lblClass.ForeColor = System.Drawing.Color.White;
            this.lblClass.Name = "lblClass";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // cmbSelectDate
            // 
            this.cmbSelectDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.cmbSelectDate.DisplayMember = "RoomType";
            resources.ApplyResources(this.cmbSelectDate, "cmbSelectDate");
            this.cmbSelectDate.ForeColor = System.Drawing.Color.White;
            this.cmbSelectDate.FormattingEnabled = true;
            this.cmbSelectDate.Items.AddRange(new object[] {
            resources.GetString("cmbSelectDate.Items"),
            resources.GetString("cmbSelectDate.Items1"),
            resources.GetString("cmbSelectDate.Items2"),
            resources.GetString("cmbSelectDate.Items3"),
            resources.GetString("cmbSelectDate.Items4")});
            this.cmbSelectDate.Name = "cmbSelectDate";
            this.cmbSelectDate.ValueMember = "RoomID";
            this.cmbSelectDate.SelectedIndexChanged += new System.EventHandler(this.cmbSelectDate_SelectedIndexChanged);
            // 
            // lblDate
            // 
            resources.ApplyResources(this.lblDate, "lblDate");
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Name = "lblDate";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // lblYear
            // 
            resources.ApplyResources(this.lblYear, "lblYear");
            this.lblYear.ForeColor = System.Drawing.Color.White;
            this.lblYear.Name = "lblYear";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtYear, "txtYear");
            this.txtYear.ForeColor = System.Drawing.Color.White;
            this.txtYear.Name = "txtYear";
            // 
            // btnSubmitClass
            // 
            this.btnSubmitClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.btnSubmitClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitClass.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnSubmitClass, "btnSubmitClass");
            this.btnSubmitClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnSubmitClass.Name = "btnSubmitClass";
            this.btnSubmitClass.UseVisualStyleBackColor = false;
            this.btnSubmitClass.Click += new System.EventHandler(this.btnSubmitClass_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // picClass
            // 
            this.picClass.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_cancel_15;
            resources.ApplyResources(this.picClass, "picClass");
            this.picClass.Name = "picClass";
            this.picClass.TabStop = false;
            this.picClass.MouseHover += new System.EventHandler(this.picClass_MouseHover);
            // 
            // picSubject
            // 
            this.picSubject.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_cancel_15;
            resources.ApplyResources(this.picSubject, "picSubject");
            this.picSubject.Name = "picSubject";
            this.picSubject.TabStop = false;
            this.picSubject.MouseHover += new System.EventHandler(this.picSubject_MouseHover);
            // 
            // picTime
            // 
            this.picTime.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_cancel_15;
            resources.ApplyResources(this.picTime, "picTime");
            this.picTime.Name = "picTime";
            this.picTime.TabStop = false;
            this.picTime.MouseHover += new System.EventHandler(this.picTime_MouseHover);
            // 
            // picDate
            // 
            this.picDate.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_cancel_15;
            resources.ApplyResources(this.picDate, "picDate");
            this.picDate.Name = "picDate";
            this.picDate.TabStop = false;
            this.picDate.MouseHover += new System.EventHandler(this.picDate_MouseHover);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_delete_35;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHELP
            // 
            resources.ApplyResources(this.btnHELP, "btnHELP");
            this.btnHELP.FlatAppearance.BorderSize = 0;
            this.btnHELP.ForeColor = System.Drawing.Color.White;
            this.btnHELP.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_help_50;
            this.btnHELP.Name = "btnHELP";
            this.btnHELP.UseVisualStyleBackColor = true;
            this.btnHELP.Click += new System.EventHandler(this.btnHELP_Click);
            // 
            // ClassScheduleCreate
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.cmbSelectDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.cmbSelectTime);
            this.Controls.Add(this.cmbSelectSubject);
            this.Controls.Add(this.cmbSelectClass);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHELP);
            this.Controls.Add(this.picDate);
            this.Controls.Add(this.picTime);
            this.Controls.Add(this.picSubject);
            this.Controls.Add(this.picClass);
            this.Controls.Add(this.btnSubmitClass);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClassScheduleCreate";
            ((System.ComponentModel.ISupportInitialize)(this.bsrcSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSelectTime;
        private System.Windows.Forms.ComboBox cmbSelectSubject;
        private System.Windows.Forms.ComboBox cmbSelectClass;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbSelectDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnSubmitClass;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource bsrcSubject;
        private System.Windows.Forms.BindingSource bsrcClass;
        private System.Windows.Forms.PictureBox picClass;
        private System.Windows.Forms.PictureBox picSubject;
        private System.Windows.Forms.PictureBox picTime;
        private System.Windows.Forms.PictureBox picDate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHELP;
    }
}