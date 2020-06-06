namespace MenaxhimiDitarit.TeacherForms
{
    partial class CommentCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommentCreate));
            this.cmbSelectSubject = new System.Windows.Forms.ComboBox();
            this.bsrcComment = new System.Windows.Forms.BindingSource(this.components);
            this.cmbSelectClass = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dtpSelectDate = new System.Windows.Forms.DateTimePicker();
            this.lblSelectDate = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblComment = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblSelectSubject = new System.Windows.Forms.Label();
            this.lblSelectClass = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbSelectTime = new System.Windows.Forms.ComboBox();
            this.lblSelectTime = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.picComment = new System.Windows.Forms.PictureBox();
            this.picClass = new System.Windows.Forms.PictureBox();
            this.picSubject = new System.Windows.Forms.PictureBox();
            this.picTime = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcComment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTime)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSelectSubject
            // 
            this.cmbSelectSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.cmbSelectSubject.DataSource = this.bsrcComment;
            this.cmbSelectSubject.DisplayMember = "Subject";
            resources.ApplyResources(this.cmbSelectSubject, "cmbSelectSubject");
            this.cmbSelectSubject.ForeColor = System.Drawing.Color.White;
            this.cmbSelectSubject.FormattingEnabled = true;
            this.cmbSelectSubject.Name = "cmbSelectSubject";
            this.cmbSelectSubject.ValueMember = "SubjectID";
            this.cmbSelectSubject.SelectedIndexChanged += new System.EventHandler(this.cmbSelectSubject_SelectedIndexChanged);
            // 
            // bsrcComment
            // 
            this.bsrcComment.DataSource = typeof(MenaxhimiDitarit.BO.Topic);
            // 
            // cmbSelectClass
            // 
            this.cmbSelectClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.cmbSelectClass.DataSource = this.bsrcComment;
            this.cmbSelectClass.DisplayMember = "Class";
            resources.ApplyResources(this.cmbSelectClass, "cmbSelectClass");
            this.cmbSelectClass.ForeColor = System.Drawing.Color.White;
            this.cmbSelectClass.FormattingEnabled = true;
            this.cmbSelectClass.Name = "cmbSelectClass";
            this.cmbSelectClass.ValueMember = "ClassID";
            this.cmbSelectClass.SelectedIndexChanged += new System.EventHandler(this.cmbSelectClass_SelectedIndexChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnSubmit, "btnSubmit");
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
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
            // lblID
            // 
            resources.ApplyResources(this.lblID, "lblID");
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Name = "lblID";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            resources.ApplyResources(this.panel8, "panel8");
            this.panel8.Name = "panel8";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtID, "txtID");
            this.txtID.ForeColor = System.Drawing.Color.White;
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            // 
            // dtpSelectDate
            // 
            resources.ApplyResources(this.dtpSelectDate, "dtpSelectDate");
            this.dtpSelectDate.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpSelectDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSelectDate.Name = "dtpSelectDate";
            // 
            // lblSelectDate
            // 
            resources.ApplyResources(this.lblSelectDate, "lblSelectDate");
            this.lblSelectDate.ForeColor = System.Drawing.Color.White;
            this.lblSelectDate.Name = "lblSelectDate";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // lblComment
            // 
            resources.ApplyResources(this.lblComment, "lblComment");
            this.lblComment.ForeColor = System.Drawing.Color.White;
            this.lblComment.Name = "lblComment";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // txtComment
            // 
            this.txtComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.txtComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtComment, "txtComment");
            this.txtComment.ForeColor = System.Drawing.Color.White;
            this.txtComment.Name = "txtComment";
            this.txtComment.TextChanged += new System.EventHandler(this.txtComent_TextChanged);
            // 
            // lblSelectSubject
            // 
            resources.ApplyResources(this.lblSelectSubject, "lblSelectSubject");
            this.lblSelectSubject.ForeColor = System.Drawing.Color.White;
            this.lblSelectSubject.Name = "lblSelectSubject";
            // 
            // lblSelectClass
            // 
            resources.ApplyResources(this.lblSelectClass, "lblSelectClass");
            this.lblSelectClass.ForeColor = System.Drawing.Color.White;
            this.lblSelectClass.Name = "lblSelectClass";
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
            // cmbSelectTime
            // 
            this.cmbSelectTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
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
            this.cmbSelectTime.SelectedIndexChanged += new System.EventHandler(this.cmbSelectTime_SelectedIndexChanged);
            // 
            // lblSelectTime
            // 
            resources.ApplyResources(this.lblSelectTime, "lblSelectTime");
            this.lblSelectTime.ForeColor = System.Drawing.Color.White;
            this.lblSelectTime.Name = "lblSelectTime";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // picComment
            // 
            this.picComment.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_cancel_15;
            resources.ApplyResources(this.picComment, "picComment");
            this.picComment.Name = "picComment";
            this.picComment.TabStop = false;
            this.picComment.MouseHover += new System.EventHandler(this.picContent_MouseHover);
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
            // CommentCreate
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.Controls.Add(this.picTime);
            this.Controls.Add(this.picSubject);
            this.Controls.Add(this.picClass);
            this.Controls.Add(this.picComment);
            this.Controls.Add(this.cmbSelectTime);
            this.Controls.Add(this.lblSelectTime);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.cmbSelectSubject);
            this.Controls.Add(this.cmbSelectClass);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dtpSelectDate);
            this.Controls.Add(this.lblSelectDate);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.lblSelectSubject);
            this.Controls.Add(this.lblSelectClass);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CommentCreate";
            ((System.ComponentModel.ISupportInitialize)(this.bsrcComment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSelectSubject;
        private System.Windows.Forms.ComboBox cmbSelectClass;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DateTimePicker dtpSelectDate;
        private System.Windows.Forms.Label lblSelectDate;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label lblSelectSubject;
        private System.Windows.Forms.Label lblSelectClass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbSelectTime;
        private System.Windows.Forms.Label lblSelectTime;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.BindingSource bsrcComment;
        private System.Windows.Forms.PictureBox picComment;
        private System.Windows.Forms.PictureBox picClass;
        private System.Windows.Forms.PictureBox picSubject;
        private System.Windows.Forms.PictureBox picTime;
    }
}