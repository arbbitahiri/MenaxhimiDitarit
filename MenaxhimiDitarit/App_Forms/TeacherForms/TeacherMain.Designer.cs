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
            this.pnlMain.AutoScroll = true;
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.pnlComments);
            this.pnlMain.Controls.Add(this.btnComments);
            this.pnlMain.Controls.Add(this.pnlAbsences);
            this.pnlMain.Controls.Add(this.btnAbsences);
            this.pnlMain.Controls.Add(this.pnlTopics);
            this.pnlMain.Controls.Add(this.btnTopics);
            this.pnlMain.Controls.Add(this.pnlPicture);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(200, 585);
            this.pnlMain.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSignOut);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 520);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 65);
            this.panel1.TabIndex = 12;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSignOut.FlatAppearance.BorderSize = 0;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_sign_out_50;
            this.btnSignOut.Location = new System.Drawing.Point(100, 0);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(100, 65);
            this.btnSignOut.TabIndex = 9;
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_close_window_50;
            this.btnExit.Location = new System.Drawing.Point(0, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 65);
            this.btnExit.TabIndex = 8;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlComments
            // 
            this.pnlComments.Controls.Add(this.btnAddNewComment);
            this.pnlComments.Controls.Add(this.btnListComments);
            this.pnlComments.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlComments.Location = new System.Drawing.Point(0, 394);
            this.pnlComments.Name = "pnlComments";
            this.pnlComments.Size = new System.Drawing.Size(200, 70);
            this.pnlComments.TabIndex = 6;
            // 
            // btnAddNewComment
            // 
            this.btnAddNewComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.btnAddNewComment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddNewComment.FlatAppearance.BorderSize = 0;
            this.btnAddNewComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewComment.ForeColor = System.Drawing.Color.White;
            this.btnAddNewComment.Location = new System.Drawing.Point(0, 35);
            this.btnAddNewComment.Name = "btnAddNewComment";
            this.btnAddNewComment.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAddNewComment.Size = new System.Drawing.Size(200, 35);
            this.btnAddNewComment.TabIndex = 1;
            this.btnAddNewComment.Text = "Add New Comment";
            this.btnAddNewComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewComment.UseVisualStyleBackColor = false;
            this.btnAddNewComment.Click += new System.EventHandler(this.btnAddNewComment_Click);
            // 
            // btnListComments
            // 
            this.btnListComments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.btnListComments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListComments.FlatAppearance.BorderSize = 0;
            this.btnListComments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListComments.ForeColor = System.Drawing.Color.White;
            this.btnListComments.Location = new System.Drawing.Point(0, 0);
            this.btnListComments.Name = "btnListComments";
            this.btnListComments.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnListComments.Size = new System.Drawing.Size(200, 35);
            this.btnListComments.TabIndex = 2;
            this.btnListComments.Text = "List Comments";
            this.btnListComments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListComments.UseVisualStyleBackColor = false;
            this.btnListComments.Click += new System.EventHandler(this.btnListComments_Click);
            // 
            // btnComments
            // 
            this.btnComments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnComments.FlatAppearance.BorderSize = 0;
            this.btnComments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComments.ForeColor = System.Drawing.Color.White;
            this.btnComments.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_note_25;
            this.btnComments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComments.Location = new System.Drawing.Point(0, 354);
            this.btnComments.Name = "btnComments";
            this.btnComments.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnComments.Size = new System.Drawing.Size(200, 40);
            this.btnComments.TabIndex = 5;
            this.btnComments.Text = "Comments";
            this.btnComments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnComments.UseVisualStyleBackColor = true;
            this.btnComments.Click += new System.EventHandler(this.btnComments_Click);
            // 
            // pnlAbsences
            // 
            this.pnlAbsences.Controls.Add(this.btnAddNAbsence);
            this.pnlAbsences.Controls.Add(this.btnListAbsences);
            this.pnlAbsences.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAbsences.Location = new System.Drawing.Point(0, 284);
            this.pnlAbsences.Name = "pnlAbsences";
            this.pnlAbsences.Size = new System.Drawing.Size(200, 70);
            this.pnlAbsences.TabIndex = 4;
            // 
            // btnAddNAbsence
            // 
            this.btnAddNAbsence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.btnAddNAbsence.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddNAbsence.FlatAppearance.BorderSize = 0;
            this.btnAddNAbsence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNAbsence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNAbsence.ForeColor = System.Drawing.Color.White;
            this.btnAddNAbsence.Location = new System.Drawing.Point(0, 35);
            this.btnAddNAbsence.Name = "btnAddNAbsence";
            this.btnAddNAbsence.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAddNAbsence.Size = new System.Drawing.Size(200, 35);
            this.btnAddNAbsence.TabIndex = 1;
            this.btnAddNAbsence.Text = "Add New Subject";
            this.btnAddNAbsence.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNAbsence.UseVisualStyleBackColor = false;
            this.btnAddNAbsence.Click += new System.EventHandler(this.btnAddNAbsence_Click);
            // 
            // btnListAbsences
            // 
            this.btnListAbsences.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.btnListAbsences.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListAbsences.FlatAppearance.BorderSize = 0;
            this.btnListAbsences.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListAbsences.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListAbsences.ForeColor = System.Drawing.Color.White;
            this.btnListAbsences.Location = new System.Drawing.Point(0, 0);
            this.btnListAbsences.Name = "btnListAbsences";
            this.btnListAbsences.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnListAbsences.Size = new System.Drawing.Size(200, 35);
            this.btnListAbsences.TabIndex = 0;
            this.btnListAbsences.Text = "List Absences";
            this.btnListAbsences.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListAbsences.UseVisualStyleBackColor = false;
            this.btnListAbsences.Click += new System.EventHandler(this.btnListAbsences_Click);
            // 
            // btnAbsences
            // 
            this.btnAbsences.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbsences.FlatAppearance.BorderSize = 0;
            this.btnAbsences.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbsences.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbsences.ForeColor = System.Drawing.Color.White;
            this.btnAbsences.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_report_card_25;
            this.btnAbsences.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbsences.Location = new System.Drawing.Point(0, 244);
            this.btnAbsences.Name = "btnAbsences";
            this.btnAbsences.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAbsences.Size = new System.Drawing.Size(200, 40);
            this.btnAbsences.TabIndex = 3;
            this.btnAbsences.Text = "Absences";
            this.btnAbsences.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbsences.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbsences.UseVisualStyleBackColor = true;
            this.btnAbsences.Click += new System.EventHandler(this.btnAbsences_Click);
            // 
            // pnlTopics
            // 
            this.pnlTopics.Controls.Add(this.btnAddNTopic);
            this.pnlTopics.Controls.Add(this.btnListTopics);
            this.pnlTopics.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopics.Location = new System.Drawing.Point(0, 174);
            this.pnlTopics.Name = "pnlTopics";
            this.pnlTopics.Size = new System.Drawing.Size(200, 70);
            this.pnlTopics.TabIndex = 2;
            // 
            // btnAddNTopic
            // 
            this.btnAddNTopic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.btnAddNTopic.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddNTopic.FlatAppearance.BorderSize = 0;
            this.btnAddNTopic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNTopic.ForeColor = System.Drawing.Color.White;
            this.btnAddNTopic.Location = new System.Drawing.Point(0, 35);
            this.btnAddNTopic.Name = "btnAddNTopic";
            this.btnAddNTopic.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAddNTopic.Size = new System.Drawing.Size(200, 35);
            this.btnAddNTopic.TabIndex = 1;
            this.btnAddNTopic.Text = "Add New Topic";
            this.btnAddNTopic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNTopic.UseVisualStyleBackColor = false;
            this.btnAddNTopic.Click += new System.EventHandler(this.btnAddNTopic_Click);
            // 
            // btnListTopics
            // 
            this.btnListTopics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.btnListTopics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListTopics.FlatAppearance.BorderSize = 0;
            this.btnListTopics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListTopics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListTopics.ForeColor = System.Drawing.Color.White;
            this.btnListTopics.Location = new System.Drawing.Point(0, 0);
            this.btnListTopics.Name = "btnListTopics";
            this.btnListTopics.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnListTopics.Size = new System.Drawing.Size(200, 35);
            this.btnListTopics.TabIndex = 0;
            this.btnListTopics.Text = "List Topics";
            this.btnListTopics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListTopics.UseVisualStyleBackColor = false;
            this.btnListTopics.Click += new System.EventHandler(this.btnListTopics_Click);
            // 
            // btnTopics
            // 
            this.btnTopics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTopics.FlatAppearance.BorderSize = 0;
            this.btnTopics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopics.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopics.ForeColor = System.Drawing.Color.White;
            this.btnTopics.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_outline_25;
            this.btnTopics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTopics.Location = new System.Drawing.Point(0, 134);
            this.btnTopics.Name = "btnTopics";
            this.btnTopics.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnTopics.Size = new System.Drawing.Size(200, 40);
            this.btnTopics.TabIndex = 1;
            this.btnTopics.Text = "Topics";
            this.btnTopics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTopics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTopics.UseVisualStyleBackColor = true;
            this.btnTopics.Click += new System.EventHandler(this.btnTopics_Click);
            // 
            // pnlPicture
            // 
            this.pnlPicture.Controls.Add(this.lblTeacher);
            this.pnlPicture.Controls.Add(this.picTeacher);
            this.pnlPicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPicture.Location = new System.Drawing.Point(0, 0);
            this.pnlPicture.Name = "pnlPicture";
            this.pnlPicture.Size = new System.Drawing.Size(200, 134);
            this.pnlPicture.TabIndex = 0;
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.lblTeacher.Location = new System.Drawing.Point(60, 103);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(81, 24);
            this.lblTeacher.TabIndex = 1;
            this.lblTeacher.Text = "Teacher";
            // 
            // picTeacher
            // 
            this.picTeacher.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_user_100;
            this.picTeacher.Location = new System.Drawing.Point(0, 0);
            this.picTeacher.Name = "picTeacher";
            this.picTeacher.Size = new System.Drawing.Size(200, 100);
            this.picTeacher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picTeacher.TabIndex = 0;
            this.picTeacher.TabStop = false;
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.pnlChildForm.Controls.Add(this.lblSDM);
            this.pnlChildForm.Controls.Add(this.picSchool);
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlChildForm.Location = new System.Drawing.Point(200, 0);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(800, 563);
            this.pnlChildForm.TabIndex = 2;
            // 
            // lblSDM
            // 
            this.lblSDM.AutoSize = true;
            this.lblSDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.lblSDM.Location = new System.Drawing.Point(234, 327);
            this.lblSDM.Name = "lblSDM";
            this.lblSDM.Size = new System.Drawing.Size(332, 31);
            this.lblSDM.TabIndex = 3;
            this.lblSDM.Text = "School Diary Management";
            // 
            // picSchool
            // 
            this.picSchool.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picSchool.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_university_100;
            this.picSchool.Location = new System.Drawing.Point(343, 205);
            this.picSchool.Name = "picSchool";
            this.picSchool.Size = new System.Drawing.Size(114, 99);
            this.picSchool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picSchool.TabIndex = 1;
            this.picSchool.TabStop = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(280, 566);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(0, 16);
            this.lblUsername.TabIndex = 5;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(206, 566);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(74, 16);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "Username:";
            // 
            // lblWelcomeName
            // 
            this.lblWelcomeName.AutoSize = true;
            this.lblWelcomeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeName.ForeColor = System.Drawing.Color.White;
            this.lblWelcomeName.Location = new System.Drawing.Point(925, 567);
            this.lblWelcomeName.Name = "lblWelcomeName";
            this.lblWelcomeName.Size = new System.Drawing.Size(0, 16);
            this.lblWelcomeName.TabIndex = 7;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(859, 566);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(66, 16);
            this.lblWelcome.TabIndex = 8;
            this.lblWelcome.Text = "Welcome";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(562, 566);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 16);
            this.lblDate.TabIndex = 6;
            // 
            // TeacherMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1000, 585);
            this.Controls.Add(this.lblWelcomeName);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TeacherMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher Main";
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