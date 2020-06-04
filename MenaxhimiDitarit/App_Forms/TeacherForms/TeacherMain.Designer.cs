namespace MenaxhimiDitarit.TeacherForms
{
    partial class TeacherMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherMain));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlComments = new System.Windows.Forms.Panel();
            this.btnAddNewComment = new System.Windows.Forms.Button();
            this.btnListComments = new System.Windows.Forms.Button();
            this.btnComments = new System.Windows.Forms.Button();
            this.pnlAbsences = new System.Windows.Forms.Panel();
            this.btnAddNAbsence = new System.Windows.Forms.Button();
            this.btnListAbsences = new System.Windows.Forms.Button();
            this.btnAbsences = new System.Windows.Forms.Button();
            this.pnlTopics = new System.Windows.Forms.Panel();
            this.btnAddNTopic = new System.Windows.Forms.Button();
            this.btnListTopics = new System.Windows.Forms.Button();
            this.btnTopics = new System.Windows.Forms.Button();
            this.pnlPicture = new System.Windows.Forms.Panel();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.picTeacher = new System.Windows.Forms.PictureBox();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.lblSDM = new System.Windows.Forms.Label();
            this.picSchool = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblWelcomeName = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlComments.SuspendLayout();
            this.pnlAbsences.SuspendLayout();
            this.pnlTopics.SuspendLayout();
            this.pnlPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTeacher)).BeginInit();
            this.pnlChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSchool)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            resources.ApplyResources(this.pnlMain, "pnlMain");
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.pnlComments);
            this.pnlMain.Controls.Add(this.btnComments);
            this.pnlMain.Controls.Add(this.pnlAbsences);
            this.pnlMain.Controls.Add(this.btnAbsences);
            this.pnlMain.Controls.Add(this.pnlTopics);
            this.pnlMain.Controls.Add(this.btnTopics);
            this.pnlMain.Controls.Add(this.pnlPicture);
            this.pnlMain.Name = "pnlMain";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSignOut);
            this.panel1.Controls.Add(this.btnExit);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btnSignOut
            // 
            resources.ApplyResources(this.btnSignOut, "btnSignOut");
            this.btnSignOut.FlatAppearance.BorderSize = 0;
            this.btnSignOut.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_sign_out_50;
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_close_window_50;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlComments
            // 
            this.pnlComments.Controls.Add(this.btnAddNewComment);
            this.pnlComments.Controls.Add(this.btnListComments);
            resources.ApplyResources(this.pnlComments, "pnlComments");
            this.pnlComments.Name = "pnlComments";
            // 
            // btnAddNewComment
            // 
            this.btnAddNewComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            resources.ApplyResources(this.btnAddNewComment, "btnAddNewComment");
            this.btnAddNewComment.FlatAppearance.BorderSize = 0;
            this.btnAddNewComment.ForeColor = System.Drawing.Color.White;
            this.btnAddNewComment.Name = "btnAddNewComment";
            this.btnAddNewComment.UseVisualStyleBackColor = false;
            this.btnAddNewComment.Click += new System.EventHandler(this.btnAddNewComment_Click);
            // 
            // btnListComments
            // 
            this.btnListComments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            resources.ApplyResources(this.btnListComments, "btnListComments");
            this.btnListComments.FlatAppearance.BorderSize = 0;
            this.btnListComments.ForeColor = System.Drawing.Color.White;
            this.btnListComments.Name = "btnListComments";
            this.btnListComments.UseVisualStyleBackColor = false;
            this.btnListComments.Click += new System.EventHandler(this.btnListComments_Click);
            // 
            // btnComments
            // 
            resources.ApplyResources(this.btnComments, "btnComments");
            this.btnComments.FlatAppearance.BorderSize = 0;
            this.btnComments.ForeColor = System.Drawing.Color.White;
            this.btnComments.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_messaging_20;
            this.btnComments.Name = "btnComments";
            this.btnComments.UseVisualStyleBackColor = true;
            this.btnComments.Click += new System.EventHandler(this.btnComments_Click);
            // 
            // pnlAbsences
            // 
            this.pnlAbsences.Controls.Add(this.btnAddNAbsence);
            this.pnlAbsences.Controls.Add(this.btnListAbsences);
            resources.ApplyResources(this.pnlAbsences, "pnlAbsences");
            this.pnlAbsences.Name = "pnlAbsences";
            // 
            // btnAddNAbsence
            // 
            this.btnAddNAbsence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            resources.ApplyResources(this.btnAddNAbsence, "btnAddNAbsence");
            this.btnAddNAbsence.FlatAppearance.BorderSize = 0;
            this.btnAddNAbsence.ForeColor = System.Drawing.Color.White;
            this.btnAddNAbsence.Name = "btnAddNAbsence";
            this.btnAddNAbsence.UseVisualStyleBackColor = false;
            this.btnAddNAbsence.Click += new System.EventHandler(this.btnAddNAbsence_Click);
            // 
            // btnListAbsences
            // 
            this.btnListAbsences.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            resources.ApplyResources(this.btnListAbsences, "btnListAbsences");
            this.btnListAbsences.FlatAppearance.BorderSize = 0;
            this.btnListAbsences.ForeColor = System.Drawing.Color.White;
            this.btnListAbsences.Name = "btnListAbsences";
            this.btnListAbsences.UseVisualStyleBackColor = false;
            this.btnListAbsences.Click += new System.EventHandler(this.btnListAbsences_Click);
            // 
            // btnAbsences
            // 
            resources.ApplyResources(this.btnAbsences, "btnAbsences");
            this.btnAbsences.FlatAppearance.BorderSize = 0;
            this.btnAbsences.ForeColor = System.Drawing.Color.White;
            this.btnAbsences.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_report_card_25;
            this.btnAbsences.Name = "btnAbsences";
            this.btnAbsences.UseVisualStyleBackColor = true;
            this.btnAbsences.Click += new System.EventHandler(this.btnAbsences_Click);
            // 
            // pnlTopics
            // 
            this.pnlTopics.Controls.Add(this.btnAddNTopic);
            this.pnlTopics.Controls.Add(this.btnListTopics);
            resources.ApplyResources(this.pnlTopics, "pnlTopics");
            this.pnlTopics.Name = "pnlTopics";
            // 
            // btnAddNTopic
            // 
            this.btnAddNTopic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            resources.ApplyResources(this.btnAddNTopic, "btnAddNTopic");
            this.btnAddNTopic.FlatAppearance.BorderSize = 0;
            this.btnAddNTopic.ForeColor = System.Drawing.Color.White;
            this.btnAddNTopic.Name = "btnAddNTopic";
            this.btnAddNTopic.UseVisualStyleBackColor = false;
            this.btnAddNTopic.Click += new System.EventHandler(this.btnAddNTopic_Click);
            // 
            // btnListTopics
            // 
            this.btnListTopics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            resources.ApplyResources(this.btnListTopics, "btnListTopics");
            this.btnListTopics.FlatAppearance.BorderSize = 0;
            this.btnListTopics.ForeColor = System.Drawing.Color.White;
            this.btnListTopics.Name = "btnListTopics";
            this.btnListTopics.UseVisualStyleBackColor = false;
            this.btnListTopics.Click += new System.EventHandler(this.btnListTopics_Click);
            // 
            // btnTopics
            // 
            resources.ApplyResources(this.btnTopics, "btnTopics");
            this.btnTopics.FlatAppearance.BorderSize = 0;
            this.btnTopics.ForeColor = System.Drawing.Color.White;
            this.btnTopics.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_outline_25;
            this.btnTopics.Name = "btnTopics";
            this.btnTopics.UseVisualStyleBackColor = true;
            this.btnTopics.Click += new System.EventHandler(this.btnTopics_Click);
            // 
            // pnlPicture
            // 
            this.pnlPicture.Controls.Add(this.lblTeacher);
            this.pnlPicture.Controls.Add(this.picTeacher);
            resources.ApplyResources(this.pnlPicture, "pnlPicture");
            this.pnlPicture.Name = "pnlPicture";
            // 
            // lblTeacher
            // 
            resources.ApplyResources(this.lblTeacher, "lblTeacher");
            this.lblTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.lblTeacher.Name = "lblTeacher";
            // 
            // picTeacher
            // 
            this.picTeacher.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_user_100;
            resources.ApplyResources(this.picTeacher, "picTeacher");
            this.picTeacher.Name = "picTeacher";
            this.picTeacher.TabStop = false;
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.pnlChildForm.Controls.Add(this.lblSDM);
            this.pnlChildForm.Controls.Add(this.picSchool);
            resources.ApplyResources(this.pnlChildForm, "pnlChildForm");
            this.pnlChildForm.Name = "pnlChildForm";
            // 
            // lblSDM
            // 
            resources.ApplyResources(this.lblSDM, "lblSDM");
            this.lblSDM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.lblSDM.Name = "lblSDM";
            // 
            // picSchool
            // 
            resources.ApplyResources(this.picSchool, "picSchool");
            this.picSchool.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_university_100;
            this.picSchool.Name = "picSchool";
            this.picSchool.TabStop = false;
            // 
            // lblUsername
            // 
            resources.ApplyResources(this.lblUsername, "lblUsername");
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Name = "lblUsername";
            // 
            // lblUser
            // 
            resources.ApplyResources(this.lblUser, "lblUser");
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Name = "lblUser";
            // 
            // lblWelcomeName
            // 
            resources.ApplyResources(this.lblWelcomeName, "lblWelcomeName");
            this.lblWelcomeName.ForeColor = System.Drawing.Color.White;
            this.lblWelcomeName.Name = "lblWelcomeName";
            // 
            // lblWelcome
            // 
            resources.ApplyResources(this.lblWelcome, "lblWelcome");
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Name = "lblWelcome";
            // 
            // lblDate
            // 
            resources.ApplyResources(this.lblDate, "lblDate");
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Name = "lblDate";
            // 
            // TeacherMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.lblWelcomeName);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeacherMain";
            this.Shown += new System.EventHandler(this.TeacherMainForm_Shown);
            this.pnlMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlComments.ResumeLayout(false);
            this.pnlAbsences.ResumeLayout(false);
            this.pnlTopics.ResumeLayout(false);
            this.pnlPicture.ResumeLayout(false);
            this.pnlPicture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTeacher)).EndInit();
            this.pnlChildForm.ResumeLayout(false);
            this.pnlChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSchool)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlComments;
        private System.Windows.Forms.Button btnAddNewComment;
        private System.Windows.Forms.Button btnListComments;
        private System.Windows.Forms.Button btnComments;
        private System.Windows.Forms.Panel pnlAbsences;
        private System.Windows.Forms.Button btnAddNAbsence;
        private System.Windows.Forms.Button btnListAbsences;
        private System.Windows.Forms.Button btnAbsences;
        private System.Windows.Forms.Panel pnlTopics;
        private System.Windows.Forms.Button btnAddNTopic;
        private System.Windows.Forms.Button btnListTopics;
        private System.Windows.Forms.Button btnTopics;
        private System.Windows.Forms.Panel pnlPicture;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.PictureBox picTeacher;
        private System.Windows.Forms.Panel pnlChildForm;
        private System.Windows.Forms.PictureBox picSchool;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblWelcomeName;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSDM;
        private System.Windows.Forms.Label lblDate;
    }
}