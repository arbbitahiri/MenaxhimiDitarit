namespace MenaxhimiDitarit.App_Forms.DirectorForms
{
    partial class Review
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Review));
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblComment = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDay = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtpCommentDay = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.picReview = new System.Windows.Forms.PictureBox();
            this.dtpReviewDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmbSelectSubject = new System.Windows.Forms.ComboBox();
            this.bsrcSubject = new System.Windows.Forms.BindingSource(this.components);
            this.txtReview = new System.Windows.Forms.TextBox();
            this.lblReview = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHELP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picReview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // txtComment
            // 
            this.txtComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.txtComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtComment, "txtComment");
            this.txtComment.ForeColor = System.Drawing.Color.White;
            this.txtComment.Name = "txtComment";
            this.txtComment.ReadOnly = true;
            this.txtComment.TextChanged += new System.EventHandler(this.txtComment_TextChanged);
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
            // lblRoomNo
            // 
            resources.ApplyResources(this.lblRoomNo, "lblRoomNo");
            this.lblRoomNo.ForeColor = System.Drawing.Color.White;
            this.lblRoomNo.Name = "lblRoomNo";
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
            // lblComment
            // 
            resources.ApplyResources(this.lblComment, "lblComment");
            this.lblComment.ForeColor = System.Drawing.Color.White;
            this.lblComment.Name = "lblComment";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // lblDay
            // 
            resources.ApplyResources(this.lblDay, "lblDay");
            this.lblDay.ForeColor = System.Drawing.Color.White;
            this.lblDay.Name = "lblDay";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // dtpCommentDay
            // 
            resources.ApplyResources(this.dtpCommentDay, "dtpCommentDay");
            this.dtpCommentDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCommentDay.Name = "dtpCommentDay";
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
            // picReview
            // 
            this.picReview.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_cancel_15;
            resources.ApplyResources(this.picReview, "picReview");
            this.picReview.Name = "picReview";
            this.picReview.TabStop = false;
            this.picReview.MouseHover += new System.EventHandler(this.picReview_MouseHover);
            // 
            // dtpReviewDate
            // 
            resources.ApplyResources(this.dtpReviewDate, "dtpReviewDate");
            this.dtpReviewDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReviewDate.Name = "dtpReviewDate";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
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
            // 
            // bsrcSubject
            // 
            this.bsrcSubject.DataSource = typeof(MenaxhimiDitarit.BO.Subject);
            // 
            // txtReview
            // 
            this.txtReview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.txtReview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtReview, "txtReview");
            this.txtReview.ForeColor = System.Drawing.Color.White;
            this.txtReview.Name = "txtReview";
            this.txtReview.TextChanged += new System.EventHandler(this.txtReview_TextChanged);
            // 
            // lblReview
            // 
            resources.ApplyResources(this.lblReview, "lblReview");
            this.lblReview.ForeColor = System.Drawing.Color.White;
            this.lblReview.Name = "lblReview";
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
            // 
            // Review
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHELP);
            this.Controls.Add(this.cmbSelectSubject);
            this.Controls.Add(this.dtpReviewDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.picReview);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dtpCommentDay);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblReview);
            this.Controls.Add(this.txtReview);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.lblRoomNo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtComment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Review";
            ((System.ComponentModel.ISupportInitialize)(this.picReview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrcSubject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dtpCommentDay;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox picReview;
        private System.Windows.Forms.DateTimePicker dtpReviewDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cmbSelectSubject;
        private System.Windows.Forms.BindingSource bsrcSubject;
        private System.Windows.Forms.TextBox txtReview;
        private System.Windows.Forms.Label lblReview;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHELP;
    }
}