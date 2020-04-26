namespace MenaxhimiDitarit
{
    partial class AdminMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainForm));
            this.pnlPicture = new System.Windows.Forms.Panel();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.picAdmin = new System.Windows.Forms.PictureBox();
            this.btnTeachers = new System.Windows.Forms.Button();
            this.pnlTeachers = new System.Windows.Forms.Panel();
            this.btnAddNTacher = new System.Windows.Forms.Button();
            this.btnListTeachers = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlRoom = new System.Windows.Forms.Panel();
            this.btnAddNewRoom = new System.Windows.Forms.Button();
            this.btnListRooms = new System.Windows.Forms.Button();
            this.btnRoom = new System.Windows.Forms.Button();
            this.pnlClassR = new System.Windows.Forms.Panel();
            this.btnViewClassSchedule = new System.Windows.Forms.Button();
            this.btnAddNewClass = new System.Windows.Forms.Button();
            this.btnListClass = new System.Windows.Forms.Button();
            this.btnClass = new System.Windows.Forms.Button();
            this.pnlSubjects = new System.Windows.Forms.Panel();
            this.btnAddNSubject = new System.Windows.Forms.Button();
            this.btnListSubjects = new System.Windows.Forms.Button();
            this.btnSubjects = new System.Windows.Forms.Button();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.picSchool = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblWelcomeName = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).BeginInit();
            this.pnlTeachers.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlRoom.SuspendLayout();
            this.pnlClassR.SuspendLayout();
            this.pnlSubjects.SuspendLayout();
            this.pnlChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSchool)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPicture
            // 
            this.pnlPicture.Controls.Add(this.lblAdmin);
            this.pnlPicture.Controls.Add(this.picAdmin);
            this.pnlPicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPicture.Location = new System.Drawing.Point(0, 0);
            this.pnlPicture.Name = "pnlPicture";
            this.pnlPicture.Size = new System.Drawing.Size(183, 134);
            this.pnlPicture.TabIndex = 0;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.lblAdmin.Location = new System.Drawing.Point(36, 103);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(128, 24);
            this.lblAdmin.TabIndex = 1;
            this.lblAdmin.Text = "Administration";
            // 
            // picAdmin
            // 
            this.picAdmin.Image = ((System.Drawing.Image)(resources.GetObject("picAdmin.Image")));
            this.picAdmin.Location = new System.Drawing.Point(0, 0);
            this.picAdmin.Name = "picAdmin";
            this.picAdmin.Size = new System.Drawing.Size(200, 100);
            this.picAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picAdmin.TabIndex = 0;
            this.picAdmin.TabStop = false;
            // 
            // btnTeachers
            // 
            this.btnTeachers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTeachers.FlatAppearance.BorderSize = 0;
            this.btnTeachers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeachers.ForeColor = System.Drawing.Color.White;
            this.btnTeachers.Image = ((System.Drawing.Image)(resources.GetObject("btnTeachers.Image")));
            this.btnTeachers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeachers.Location = new System.Drawing.Point(0, 134);
            this.btnTeachers.Name = "btnTeachers";
            this.btnTeachers.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnTeachers.Size = new System.Drawing.Size(183, 40);
            this.btnTeachers.TabIndex = 1;
            this.btnTeachers.Text = "Teachers";
            this.btnTeachers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeachers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTeachers.UseVisualStyleBackColor = true;
            this.btnTeachers.Click += new System.EventHandler(this.btnTeachers_Click);
            // 
            // pnlTeachers
            // 
            this.pnlTeachers.Controls.Add(this.btnAddNTacher);
            this.pnlTeachers.Controls.Add(this.btnListTeachers);
            this.pnlTeachers.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTeachers.Location = new System.Drawing.Point(0, 174);
            this.pnlTeachers.Name = "pnlTeachers";
            this.pnlTeachers.Size = new System.Drawing.Size(183, 70);
            this.pnlTeachers.TabIndex = 2;
            // 
            // btnAddNTacher
            // 
            this.btnAddNTacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.btnAddNTacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddNTacher.FlatAppearance.BorderSize = 0;
            this.btnAddNTacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNTacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNTacher.ForeColor = System.Drawing.Color.White;
            this.btnAddNTacher.Location = new System.Drawing.Point(0, 35);
            this.btnAddNTacher.Name = "btnAddNTacher";
            this.btnAddNTacher.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAddNTacher.Size = new System.Drawing.Size(183, 35);
            this.btnAddNTacher.TabIndex = 1;
            this.btnAddNTacher.Text = "Add New Teacher";
            this.btnAddNTacher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNTacher.UseVisualStyleBackColor = false;
            this.btnAddNTacher.Click += new System.EventHandler(this.btnAddNTacher_Click);
            // 
            // btnListTeachers
            // 
            this.btnListTeachers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.btnListTeachers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListTeachers.FlatAppearance.BorderSize = 0;
            this.btnListTeachers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListTeachers.ForeColor = System.Drawing.Color.White;
            this.btnListTeachers.Location = new System.Drawing.Point(0, 0);
            this.btnListTeachers.Name = "btnListTeachers";
            this.btnListTeachers.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnListTeachers.Size = new System.Drawing.Size(183, 35);
            this.btnListTeachers.TabIndex = 0;
            this.btnListTeachers.Text = "List Teachers";
            this.btnListTeachers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListTeachers.UseVisualStyleBackColor = false;
            this.btnListTeachers.Click += new System.EventHandler(this.btnListTeachers_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.AutoScroll = true;
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.pnlRoom);
            this.pnlMain.Controls.Add(this.btnRoom);
            this.pnlMain.Controls.Add(this.pnlClassR);
            this.pnlMain.Controls.Add(this.btnClass);
            this.pnlMain.Controls.Add(this.pnlSubjects);
            this.pnlMain.Controls.Add(this.btnSubjects);
            this.pnlMain.Controls.Add(this.pnlTeachers);
            this.pnlMain.Controls.Add(this.btnTeachers);
            this.pnlMain.Controls.Add(this.pnlPicture);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(200, 600);
            this.pnlMain.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSignOut);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 609);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 65);
            this.panel1.TabIndex = 11;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSignOut.FlatAppearance.BorderSize = 0;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Image = ((System.Drawing.Image)(resources.GetObject("btnSignOut.Image")));
            this.btnSignOut.Location = new System.Drawing.Point(83, 0);
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
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(0, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 65);
            this.btnExit.TabIndex = 8;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlRoom
            // 
            this.pnlRoom.Controls.Add(this.btnAddNewRoom);
            this.pnlRoom.Controls.Add(this.btnListRooms);
            this.pnlRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRoom.Location = new System.Drawing.Point(0, 539);
            this.pnlRoom.Name = "pnlRoom";
            this.pnlRoom.Size = new System.Drawing.Size(183, 70);
            this.pnlRoom.TabIndex = 10;
            // 
            // btnAddNewRoom
            // 
            this.btnAddNewRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.btnAddNewRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddNewRoom.FlatAppearance.BorderSize = 0;
            this.btnAddNewRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddNewRoom.Location = new System.Drawing.Point(0, 35);
            this.btnAddNewRoom.Name = "btnAddNewRoom";
            this.btnAddNewRoom.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAddNewRoom.Size = new System.Drawing.Size(183, 35);
            this.btnAddNewRoom.TabIndex = 1;
            this.btnAddNewRoom.Text = "Add New Room";
            this.btnAddNewRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewRoom.UseVisualStyleBackColor = false;
            this.btnAddNewRoom.Click += new System.EventHandler(this.btnAddNewRoom_Click_1);
            // 
            // btnListRooms
            // 
            this.btnListRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.btnListRooms.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListRooms.FlatAppearance.BorderSize = 0;
            this.btnListRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListRooms.ForeColor = System.Drawing.Color.White;
            this.btnListRooms.Location = new System.Drawing.Point(0, 0);
            this.btnListRooms.Name = "btnListRooms";
            this.btnListRooms.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnListRooms.Size = new System.Drawing.Size(183, 35);
            this.btnListRooms.TabIndex = 2;
            this.btnListRooms.Text = "List Rooms";
            this.btnListRooms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListRooms.UseVisualStyleBackColor = false;
            this.btnListRooms.Click += new System.EventHandler(this.btnListRooms_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoom.FlatAppearance.BorderSize = 0;
            this.btnRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoom.ForeColor = System.Drawing.Color.White;
            this.btnRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnRoom.Image")));
            this.btnRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoom.Location = new System.Drawing.Point(0, 499);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnRoom.Size = new System.Drawing.Size(183, 40);
            this.btnRoom.TabIndex = 9;
            this.btnRoom.Text = "Rooms";
            this.btnRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRoom.UseVisualStyleBackColor = true;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // pnlClassR
            // 
            this.pnlClassR.Controls.Add(this.btnViewClassSchedule);
            this.pnlClassR.Controls.Add(this.btnAddNewClass);
            this.pnlClassR.Controls.Add(this.btnListClass);
            this.pnlClassR.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlClassR.Location = new System.Drawing.Point(0, 394);
            this.pnlClassR.Name = "pnlClassR";
            this.pnlClassR.Size = new System.Drawing.Size(183, 105);
            this.pnlClassR.TabIndex = 6;
            // 
            // btnViewClassSchedule
            // 
            this.btnViewClassSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.btnViewClassSchedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewClassSchedule.FlatAppearance.BorderSize = 0;
            this.btnViewClassSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewClassSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewClassSchedule.ForeColor = System.Drawing.Color.White;
            this.btnViewClassSchedule.Location = new System.Drawing.Point(0, 70);
            this.btnViewClassSchedule.Name = "btnViewClassSchedule";
            this.btnViewClassSchedule.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnViewClassSchedule.Size = new System.Drawing.Size(183, 35);
            this.btnViewClassSchedule.TabIndex = 0;
            this.btnViewClassSchedule.Text = "View Class Schedule";
            this.btnViewClassSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewClassSchedule.UseVisualStyleBackColor = false;
            this.btnViewClassSchedule.Click += new System.EventHandler(this.btnAddClassRSchedule_Click);
            // 
            // btnAddNewClass
            // 
            this.btnAddNewClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.btnAddNewClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddNewClass.FlatAppearance.BorderSize = 0;
            this.btnAddNewClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewClass.ForeColor = System.Drawing.Color.White;
            this.btnAddNewClass.Location = new System.Drawing.Point(0, 35);
            this.btnAddNewClass.Name = "btnAddNewClass";
            this.btnAddNewClass.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAddNewClass.Size = new System.Drawing.Size(183, 35);
            this.btnAddNewClass.TabIndex = 1;
            this.btnAddNewClass.Text = "Add New Class";
            this.btnAddNewClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewClass.UseVisualStyleBackColor = false;
            this.btnAddNewClass.Click += new System.EventHandler(this.btnAddNewClass_Click);
            // 
            // btnListClass
            // 
            this.btnListClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.btnListClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListClass.FlatAppearance.BorderSize = 0;
            this.btnListClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListClass.ForeColor = System.Drawing.Color.White;
            this.btnListClass.Location = new System.Drawing.Point(0, 0);
            this.btnListClass.Name = "btnListClass";
            this.btnListClass.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnListClass.Size = new System.Drawing.Size(183, 35);
            this.btnListClass.TabIndex = 2;
            this.btnListClass.Text = "List Classes";
            this.btnListClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListClass.UseVisualStyleBackColor = false;
            this.btnListClass.Click += new System.EventHandler(this.btnListClassR_Click_1);
            // 
            // btnClass
            // 
            this.btnClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClass.FlatAppearance.BorderSize = 0;
            this.btnClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClass.ForeColor = System.Drawing.Color.White;
            this.btnClass.Image = ((System.Drawing.Image)(resources.GetObject("btnClass.Image")));
            this.btnClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClass.Location = new System.Drawing.Point(0, 354);
            this.btnClass.Name = "btnClass";
            this.btnClass.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnClass.Size = new System.Drawing.Size(183, 40);
            this.btnClass.TabIndex = 5;
            this.btnClass.Text = "Classes";
            this.btnClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClass.UseVisualStyleBackColor = true;
            this.btnClass.Click += new System.EventHandler(this.btnClassR_Click);
            // 
            // pnlSubjects
            // 
            this.pnlSubjects.Controls.Add(this.btnAddNSubject);
            this.pnlSubjects.Controls.Add(this.btnListSubjects);
            this.pnlSubjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubjects.Location = new System.Drawing.Point(0, 284);
            this.pnlSubjects.Name = "pnlSubjects";
            this.pnlSubjects.Size = new System.Drawing.Size(183, 70);
            this.pnlSubjects.TabIndex = 4;
            // 
            // btnAddNSubject
            // 
            this.btnAddNSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.btnAddNSubject.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddNSubject.FlatAppearance.BorderSize = 0;
            this.btnAddNSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNSubject.ForeColor = System.Drawing.Color.White;
            this.btnAddNSubject.Location = new System.Drawing.Point(0, 35);
            this.btnAddNSubject.Name = "btnAddNSubject";
            this.btnAddNSubject.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAddNSubject.Size = new System.Drawing.Size(183, 35);
            this.btnAddNSubject.TabIndex = 1;
            this.btnAddNSubject.Text = "Add New Subject";
            this.btnAddNSubject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNSubject.UseVisualStyleBackColor = false;
            this.btnAddNSubject.Click += new System.EventHandler(this.btnAddNSubject_Click);
            // 
            // btnListSubjects
            // 
            this.btnListSubjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.btnListSubjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListSubjects.FlatAppearance.BorderSize = 0;
            this.btnListSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListSubjects.ForeColor = System.Drawing.Color.White;
            this.btnListSubjects.Location = new System.Drawing.Point(0, 0);
            this.btnListSubjects.Name = "btnListSubjects";
            this.btnListSubjects.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnListSubjects.Size = new System.Drawing.Size(183, 35);
            this.btnListSubjects.TabIndex = 0;
            this.btnListSubjects.Text = "List Subjects";
            this.btnListSubjects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListSubjects.UseVisualStyleBackColor = false;
            this.btnListSubjects.Click += new System.EventHandler(this.btnListSubjects_Click);
            // 
            // btnSubjects
            // 
            this.btnSubjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubjects.FlatAppearance.BorderSize = 0;
            this.btnSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubjects.ForeColor = System.Drawing.Color.White;
            this.btnSubjects.Image = ((System.Drawing.Image)(resources.GetObject("btnSubjects.Image")));
            this.btnSubjects.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubjects.Location = new System.Drawing.Point(0, 244);
            this.btnSubjects.Name = "btnSubjects";
            this.btnSubjects.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSubjects.Size = new System.Drawing.Size(183, 40);
            this.btnSubjects.TabIndex = 3;
            this.btnSubjects.Text = "Subjects";
            this.btnSubjects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubjects.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubjects.UseVisualStyleBackColor = true;
            this.btnSubjects.Click += new System.EventHandler(this.btnSubjects_Click);
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.pnlChildForm.Controls.Add(this.picSchool);
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlChildForm.Location = new System.Drawing.Point(200, 0);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(673, 563);
            this.pnlChildForm.TabIndex = 1;
            // 
            // picSchool
            // 
            this.picSchool.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picSchool.Image = ((System.Drawing.Image)(resources.GetObject("picSchool.Image")));
            this.picSchool.Location = new System.Drawing.Point(279, 232);
            this.picSchool.Name = "picSchool";
            this.picSchool.Size = new System.Drawing.Size(114, 99);
            this.picSchool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picSchool.TabIndex = 0;
            this.picSchool.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(206, 574);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(74, 16);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Username:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(286, 574);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(0, 16);
            this.lblUsername.TabIndex = 2;
            // 
            // lblWelcomeName
            // 
            this.lblWelcomeName.AutoSize = true;
            this.lblWelcomeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeName.ForeColor = System.Drawing.Color.White;
            this.lblWelcomeName.Location = new System.Drawing.Point(779, 574);
            this.lblWelcomeName.Name = "lblWelcomeName";
            this.lblWelcomeName.Size = new System.Drawing.Size(0, 16);
            this.lblWelcomeName.TabIndex = 3;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(707, 574);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(66, 16);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Welcome";
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(873, 600);
            this.Controls.Add(this.lblWelcomeName);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMainForm";
            this.Shown += new System.EventHandler(this.AdminMainForm_Shown);
            this.pnlPicture.ResumeLayout(false);
            this.pnlPicture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).EndInit();
            this.pnlTeachers.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlRoom.ResumeLayout(false);
            this.pnlClassR.ResumeLayout(false);
            this.pnlSubjects.ResumeLayout(false);
            this.pnlChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSchool)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPicture;
        private System.Windows.Forms.PictureBox picAdmin;
        private System.Windows.Forms.Button btnTeachers;
        private System.Windows.Forms.Panel pnlTeachers;
        private System.Windows.Forms.Button btnAddNTacher;
        private System.Windows.Forms.Button btnListTeachers;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlSubjects;
        private System.Windows.Forms.Button btnAddNSubject;
        private System.Windows.Forms.Button btnListSubjects;
        private System.Windows.Forms.Button btnSubjects;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Panel pnlChildForm;
        private System.Windows.Forms.PictureBox picSchool;
        private System.Windows.Forms.Panel pnlClassR;
        private System.Windows.Forms.Button btnViewClassSchedule;
        private System.Windows.Forms.Button btnAddNewClass;
        private System.Windows.Forms.Button btnListClass;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Panel pnlRoom;
        private System.Windows.Forms.Button btnAddNewRoom;
        private System.Windows.Forms.Button btnListRooms;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Label lblWelcomeName;
        private System.Windows.Forms.Label lblWelcome;
    }
}