namespace MenaxhimiDitarit.DirectorForms
{
    partial class DirectorMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectorMain));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReview = new System.Windows.Forms.Button();
            this.btnRoles = new System.Windows.Forms.Button();
            this.pnlUsers = new System.Windows.Forms.Panel();
            this.btnAddNUser = new System.Windows.Forms.Button();
            this.btnListUsers = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.pnlTeachers = new System.Windows.Forms.Panel();
            this.btnAddNTeacher = new System.Windows.Forms.Button();
            this.btnListTeachers = new System.Windows.Forms.Button();
            this.btnTeachers = new System.Windows.Forms.Button();
            this.pnlPic = new System.Windows.Forms.Panel();
            this.lblDirector = new System.Windows.Forms.Label();
            this.picDirector = new System.Windows.Forms.PictureBox();
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
            this.pnlUsers.SuspendLayout();
            this.pnlTeachers.SuspendLayout();
            this.pnlPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDirector)).BeginInit();
            this.pnlChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSchool)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            resources.ApplyResources(this.pnlMain, "pnlMain");
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.btnReview);
            this.pnlMain.Controls.Add(this.btnRoles);
            this.pnlMain.Controls.Add(this.pnlUsers);
            this.pnlMain.Controls.Add(this.btnUsers);
            this.pnlMain.Controls.Add(this.pnlTeachers);
            this.pnlMain.Controls.Add(this.btnTeachers);
            this.pnlMain.Controls.Add(this.pnlPic);
            this.pnlMain.Name = "pnlMain";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.btnSignOut);
            this.panel1.Controls.Add(this.btnExit);
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
            // btnReview
            // 
            resources.ApplyResources(this.btnReview, "btnReview");
            this.btnReview.FlatAppearance.BorderSize = 0;
            this.btnReview.ForeColor = System.Drawing.Color.White;
            this.btnReview.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_chat_20;
            this.btnReview.Name = "btnReview";
            this.btnReview.UseVisualStyleBackColor = true;
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // btnRoles
            // 
            resources.ApplyResources(this.btnRoles, "btnRoles");
            this.btnRoles.FlatAppearance.BorderSize = 0;
            this.btnRoles.ForeColor = System.Drawing.Color.White;
            this.btnRoles.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_people_25;
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.UseVisualStyleBackColor = true;
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // pnlUsers
            // 
            resources.ApplyResources(this.pnlUsers, "pnlUsers");
            this.pnlUsers.Controls.Add(this.btnAddNUser);
            this.pnlUsers.Controls.Add(this.btnListUsers);
            this.pnlUsers.Name = "pnlUsers";
            // 
            // btnAddNUser
            // 
            resources.ApplyResources(this.btnAddNUser, "btnAddNUser");
            this.btnAddNUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.btnAddNUser.FlatAppearance.BorderSize = 0;
            this.btnAddNUser.ForeColor = System.Drawing.Color.White;
            this.btnAddNUser.Name = "btnAddNUser";
            this.btnAddNUser.UseVisualStyleBackColor = false;
            this.btnAddNUser.Click += new System.EventHandler(this.btnAddNUser_Click);
            // 
            // btnListUsers
            // 
            resources.ApplyResources(this.btnListUsers, "btnListUsers");
            this.btnListUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.btnListUsers.FlatAppearance.BorderSize = 0;
            this.btnListUsers.ForeColor = System.Drawing.Color.White;
            this.btnListUsers.Name = "btnListUsers";
            this.btnListUsers.UseVisualStyleBackColor = false;
            this.btnListUsers.Click += new System.EventHandler(this.btnListUsers_Click);
            // 
            // btnUsers
            // 
            resources.ApplyResources(this.btnUsers, "btnUsers");
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_user_account_25;
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // pnlTeachers
            // 
            resources.ApplyResources(this.pnlTeachers, "pnlTeachers");
            this.pnlTeachers.Controls.Add(this.btnAddNTeacher);
            this.pnlTeachers.Controls.Add(this.btnListTeachers);
            this.pnlTeachers.Name = "pnlTeachers";
            // 
            // btnAddNTeacher
            // 
            resources.ApplyResources(this.btnAddNTeacher, "btnAddNTeacher");
            this.btnAddNTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.btnAddNTeacher.FlatAppearance.BorderSize = 0;
            this.btnAddNTeacher.ForeColor = System.Drawing.Color.White;
            this.btnAddNTeacher.Name = "btnAddNTeacher";
            this.btnAddNTeacher.UseVisualStyleBackColor = false;
            this.btnAddNTeacher.Click += new System.EventHandler(this.btnAddNTeacher_Click);
            // 
            // btnListTeachers
            // 
            resources.ApplyResources(this.btnListTeachers, "btnListTeachers");
            this.btnListTeachers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.btnListTeachers.FlatAppearance.BorderSize = 0;
            this.btnListTeachers.ForeColor = System.Drawing.Color.White;
            this.btnListTeachers.Name = "btnListTeachers";
            this.btnListTeachers.UseVisualStyleBackColor = false;
            this.btnListTeachers.Click += new System.EventHandler(this.btnListTeachers_Click);
            // 
            // btnTeachers
            // 
            resources.ApplyResources(this.btnTeachers, "btnTeachers");
            this.btnTeachers.FlatAppearance.BorderSize = 0;
            this.btnTeachers.ForeColor = System.Drawing.Color.White;
            this.btnTeachers.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_teacher_25;
            this.btnTeachers.Name = "btnTeachers";
            this.btnTeachers.UseVisualStyleBackColor = true;
            this.btnTeachers.Click += new System.EventHandler(this.btnTeachers_Click);
            // 
            // pnlPic
            // 
            resources.ApplyResources(this.pnlPic, "pnlPic");
            this.pnlPic.Controls.Add(this.lblDirector);
            this.pnlPic.Controls.Add(this.picDirector);
            this.pnlPic.Name = "pnlPic";
            // 
            // lblDirector
            // 
            resources.ApplyResources(this.lblDirector, "lblDirector");
            this.lblDirector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.lblDirector.Name = "lblDirector";
            // 
            // picDirector
            // 
            resources.ApplyResources(this.picDirector, "picDirector");
            this.picDirector.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_school_director_100;
            this.picDirector.Name = "picDirector";
            this.picDirector.TabStop = false;
            // 
            // pnlChildForm
            // 
            resources.ApplyResources(this.pnlChildForm, "pnlChildForm");
            this.pnlChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.pnlChildForm.Controls.Add(this.lblSDM);
            this.pnlChildForm.Controls.Add(this.picSchool);
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
            this.picSchool.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_school_100;
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
            // DirectorMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblWelcomeName);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.lblUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DirectorMain";
            this.Shown += new System.EventHandler(this.DirectorMainForm_Shown);
            this.pnlMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlUsers.ResumeLayout(false);
            this.pnlTeachers.ResumeLayout(false);
            this.pnlPic.ResumeLayout(false);
            this.pnlPic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDirector)).EndInit();
            this.pnlChildForm.ResumeLayout(false);
            this.pnlChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSchool)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlPic;
        private System.Windows.Forms.PictureBox picDirector;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Panel pnlTeachers;
        private System.Windows.Forms.Button btnTeachers;
        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Panel pnlUsers;
        private System.Windows.Forms.Button btnAddNUser;
        private System.Windows.Forms.Button btnListUsers;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnAddNTeacher;
        private System.Windows.Forms.Button btnListTeachers;
        private System.Windows.Forms.Panel pnlChildForm;
        private System.Windows.Forms.PictureBox picSchool;
        private System.Windows.Forms.Button btnReview;
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