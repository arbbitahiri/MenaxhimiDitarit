namespace MenaxhimiDitarit.TeacherForms
{
    partial class TopicCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopicCreate));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dtpSelectDate = new System.Windows.Forms.DateTimePicker();
            this.lblSelectDate = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblSelectSubject = new System.Windows.Forms.Label();
            this.lblSelectClass = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbSelectClass = new System.Windows.Forms.ComboBox();
            this.bsrcClassList = new System.Windows.Forms.BindingSource(this.components);
            this.cmbSelectSubject = new System.Windows.Forms.ComboBox();
            this.bsrcSubjectList = new System.Windows.Forms.BindingSource(this.components);
            this.cmbSelectTime = new System.Windows.Forms.ComboBox();
            this.lblSelectTime = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.picClass = new System.Windows.Forms.PictureBox();
            this.picSubject = new System.Windows.Forms.PictureBox();
            this.picTime = new System.Windows.Forms.PictureBox();
            this.picContent = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcClassList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcSubjectList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picContent)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            resources.ApplyResources(this.btnSubmit, "btnSubmit");
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
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
            resources.ApplyResources(this.panel8, "panel8");
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panel8.Name = "panel8";
            // 
            // txtID
            // 
            resources.ApplyResources(this.txtID, "txtID");
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panel5.Name = "panel5";
            // 
            // lblContent
            // 
            resources.ApplyResources(this.lblContent, "lblContent");
            this.lblContent.ForeColor = System.Drawing.Color.White;
            this.lblContent.Name = "lblContent";
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
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panel2.Name = "panel2";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panel1.Name = "panel1";
            // 
            // cmbSelectClass
            // 
            resources.ApplyResources(this.cmbSelectClass, "cmbSelectClass");
            this.cmbSelectClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.cmbSelectClass.DataSource = this.bsrcClassList;
            this.cmbSelectClass.DisplayMember = "ClassNo";
            this.cmbSelectClass.ForeColor = System.Drawing.Color.White;
            this.cmbSelectClass.FormattingEnabled = true;
            this.cmbSelectClass.Name = "cmbSelectClass";
            this.cmbSelectClass.ValueMember = "ClassID";
            this.cmbSelectClass.SelectedIndexChanged += new System.EventHandler(this.cmbSelectClass_SelectedIndexChanged);
            // 
            // bsrcClassList
            // 
            this.bsrcClassList.DataSource = typeof(MenaxhimiDitarit.BO.Class);
            // 
            // cmbSelectSubject
            // 
            resources.ApplyResources(this.cmbSelectSubject, "cmbSelectSubject");
            this.cmbSelectSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.cmbSelectSubject.DataSource = this.bsrcSubjectList;
            this.cmbSelectSubject.DisplayMember = "SubjectTitle";
            this.cmbSelectSubject.ForeColor = System.Drawing.Color.White;
            this.cmbSelectSubject.FormattingEnabled = true;
            this.cmbSelectSubject.Name = "cmbSelectSubject";
            this.cmbSelectSubject.ValueMember = "SubjectID";
            this.cmbSelectSubject.SelectedIndexChanged += new System.EventHandler(this.cmbSelectSubject_SelectedIndexChanged);
            // 
            // bsrcSubjectList
            // 
            this.bsrcSubjectList.DataSource = typeof(MenaxhimiDitarit.BO.Subject);
            // 
            // cmbSelectTime
            // 
            resources.ApplyResources(this.cmbSelectTime, "cmbSelectTime");
            this.cmbSelectTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
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
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panel4.Name = "panel4";
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.panel3.Name = "panel3";
            // 
            // txtContent
            // 
            resources.ApplyResources(this.txtContent, "txtContent");
            this.txtContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContent.ForeColor = System.Drawing.Color.White;
            this.txtContent.Name = "txtContent";
            this.txtContent.TextChanged += new System.EventHandler(this.txtContent_TextChanged);
            // 
            // picClass
            // 
            resources.ApplyResources(this.picClass, "picClass");
            this.picClass.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_cancel_15;
            this.picClass.Name = "picClass";
            this.picClass.TabStop = false;
            this.picClass.MouseHover += new System.EventHandler(this.picClass_MouseHover);
            // 
            // picSubject
            // 
            resources.ApplyResources(this.picSubject, "picSubject");
            this.picSubject.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_cancel_15;
            this.picSubject.Name = "picSubject";
            this.picSubject.TabStop = false;
            this.picSubject.MouseHover += new System.EventHandler(this.picSubject_MouseHover);
            // 
            // picTime
            // 
            resources.ApplyResources(this.picTime, "picTime");
            this.picTime.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_cancel_15;
            this.picTime.Name = "picTime";
            this.picTime.TabStop = false;
            this.picTime.MouseHover += new System.EventHandler(this.picTime_MouseHover);
            // 
            // picContent
            // 
            resources.ApplyResources(this.picContent, "picContent");
            this.picContent.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_cancel_15;
            this.picContent.Name = "picContent";
            this.picContent.TabStop = false;
            this.picContent.MouseHover += new System.EventHandler(this.picContent_MouseHover);
            // 
            // TopicCreate
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.picContent);
            this.Controls.Add(this.picTime);
            this.Controls.Add(this.picSubject);
            this.Controls.Add(this.picClass);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.cmbSelectTime);
            this.Controls.Add(this.lblSelectTime);
            this.Controls.Add(this.panel4);
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
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.lblSelectSubject);
            this.Controls.Add(this.lblSelectClass);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TopicCreate";
            ((System.ComponentModel.ISupportInitialize)(this.bsrcClassList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcSubjectList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picContent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DateTimePicker dtpSelectDate;
        private System.Windows.Forms.Label lblSelectDate;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label lblSelectSubject;
        private System.Windows.Forms.Label lblSelectClass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbSelectClass;
        private System.Windows.Forms.ComboBox cmbSelectSubject;
        private System.Windows.Forms.ComboBox cmbSelectTime;
        private System.Windows.Forms.Label lblSelectTime;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.BindingSource bsrcSubjectList;
        private System.Windows.Forms.BindingSource bsrcClassList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.PictureBox picClass;
        private System.Windows.Forms.PictureBox picSubject;
        private System.Windows.Forms.PictureBox picTime;
        private System.Windows.Forms.PictureBox picContent;
    }
}