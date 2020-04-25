﻿namespace MenaxhimiDitarit.DirectorForms
{
    partial class DirectorMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectorMainForm));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlReview = new System.Windows.Forms.Panel();
            this.btnReviewComments = new System.Windows.Forms.Button();
            this.btnReview = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlRoles = new System.Windows.Forms.Panel();
            this.btnAddNRole = new System.Windows.Forms.Button();
            this.btnRolesList = new System.Windows.Forms.Button();
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
            this.picSchool = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlReview.SuspendLayout();
            this.pnlRoles.SuspendLayout();
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
            this.pnlMain.AutoScroll = true;
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.pnlMain.Controls.Add(this.pnlReview);
            this.pnlMain.Controls.Add(this.btnReview);
            this.pnlMain.Controls.Add(this.btnClose);
            this.pnlMain.Controls.Add(this.pnlRoles);
            this.pnlMain.Controls.Add(this.btnRoles);
            this.pnlMain.Controls.Add(this.pnlUsers);
            this.pnlMain.Controls.Add(this.btnUsers);
            this.pnlMain.Controls.Add(this.pnlTeachers);
            this.pnlMain.Controls.Add(this.btnTeachers);
            this.pnlMain.Controls.Add(this.pnlPic);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(200, 600);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlReview
            // 
            this.pnlReview.Controls.Add(this.btnReviewComments);
            this.pnlReview.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReview.Location = new System.Drawing.Point(0, 504);
            this.pnlReview.Name = "pnlReview";
            this.pnlReview.Size = new System.Drawing.Size(200, 35);
            this.pnlReview.TabIndex = 11;
            // 
            // btnReviewComments
            // 
            this.btnReviewComments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.btnReviewComments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReviewComments.FlatAppearance.BorderSize = 0;
            this.btnReviewComments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReviewComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReviewComments.ForeColor = System.Drawing.Color.White;
            this.btnReviewComments.Location = new System.Drawing.Point(0, 0);
            this.btnReviewComments.Name = "btnReviewComments";
            this.btnReviewComments.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnReviewComments.Size = new System.Drawing.Size(200, 35);
            this.btnReviewComments.TabIndex = 2;
            this.btnReviewComments.Text = "Review Comments";
            this.btnReviewComments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReviewComments.UseVisualStyleBackColor = false;
            this.btnReviewComments.Click += new System.EventHandler(this.btnReviewComments_Click);
            // 
            // btnReview
            // 
            this.btnReview.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReview.FlatAppearance.BorderSize = 0;
            this.btnReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReview.ForeColor = System.Drawing.Color.White;
            this.btnReview.Image = ((System.Drawing.Image)(resources.GetObject("btnReview.Image")));
            this.btnReview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReview.Location = new System.Drawing.Point(0, 464);
            this.btnReview.Name = "btnReview";
            this.btnReview.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnReview.Size = new System.Drawing.Size(200, 40);
            this.btnReview.TabIndex = 10;
            this.btnReview.Text = "Reviews";
            this.btnReview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReview.UseVisualStyleBackColor = true;
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(0, 550);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 50);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlRoles
            // 
            this.pnlRoles.Controls.Add(this.btnAddNRole);
            this.pnlRoles.Controls.Add(this.btnRolesList);
            this.pnlRoles.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRoles.Location = new System.Drawing.Point(0, 394);
            this.pnlRoles.Name = "pnlRoles";
            this.pnlRoles.Size = new System.Drawing.Size(200, 70);
            this.pnlRoles.TabIndex = 7;
            // 
            // btnAddNRole
            // 
            this.btnAddNRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.btnAddNRole.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddNRole.FlatAppearance.BorderSize = 0;
            this.btnAddNRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNRole.ForeColor = System.Drawing.Color.White;
            this.btnAddNRole.Location = new System.Drawing.Point(0, 35);
            this.btnAddNRole.Name = "btnAddNRole";
            this.btnAddNRole.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAddNRole.Size = new System.Drawing.Size(200, 35);
            this.btnAddNRole.TabIndex = 2;
            this.btnAddNRole.Text = "Add New Role";
            this.btnAddNRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNRole.UseVisualStyleBackColor = false;
            this.btnAddNRole.Click += new System.EventHandler(this.btnAddNRole_Click);
            // 
            // btnRolesList
            // 
            this.btnRolesList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.btnRolesList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRolesList.FlatAppearance.BorderSize = 0;
            this.btnRolesList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRolesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRolesList.ForeColor = System.Drawing.Color.White;
            this.btnRolesList.Location = new System.Drawing.Point(0, 0);
            this.btnRolesList.Name = "btnRolesList";
            this.btnRolesList.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnRolesList.Size = new System.Drawing.Size(200, 35);
            this.btnRolesList.TabIndex = 1;
            this.btnRolesList.Text = "List Roles";
            this.btnRolesList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRolesList.UseVisualStyleBackColor = false;
            this.btnRolesList.Click += new System.EventHandler(this.btnRolesList_Click);
            // 
            // btnRoles
            // 
            this.btnRoles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoles.FlatAppearance.BorderSize = 0;
            this.btnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoles.ForeColor = System.Drawing.Color.White;
            this.btnRoles.Image = ((System.Drawing.Image)(resources.GetObject("btnRoles.Image")));
            this.btnRoles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoles.Location = new System.Drawing.Point(0, 354);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnRoles.Size = new System.Drawing.Size(200, 40);
            this.btnRoles.TabIndex = 6;
            this.btnRoles.Text = "Roles";
            this.btnRoles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRoles.UseVisualStyleBackColor = true;
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // pnlUsers
            // 
            this.pnlUsers.Controls.Add(this.btnAddNUser);
            this.pnlUsers.Controls.Add(this.btnListUsers);
            this.pnlUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUsers.Location = new System.Drawing.Point(0, 284);
            this.pnlUsers.Name = "pnlUsers";
            this.pnlUsers.Size = new System.Drawing.Size(200, 70);
            this.pnlUsers.TabIndex = 5;
            // 
            // btnAddNUser
            // 
            this.btnAddNUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.btnAddNUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddNUser.FlatAppearance.BorderSize = 0;
            this.btnAddNUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNUser.ForeColor = System.Drawing.Color.White;
            this.btnAddNUser.Location = new System.Drawing.Point(0, 35);
            this.btnAddNUser.Name = "btnAddNUser";
            this.btnAddNUser.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAddNUser.Size = new System.Drawing.Size(200, 35);
            this.btnAddNUser.TabIndex = 2;
            this.btnAddNUser.Text = "Add New User";
            this.btnAddNUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNUser.UseVisualStyleBackColor = false;
            this.btnAddNUser.Click += new System.EventHandler(this.btnAddNUser_Click);
            // 
            // btnListUsers
            // 
            this.btnListUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.btnListUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListUsers.FlatAppearance.BorderSize = 0;
            this.btnListUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListUsers.ForeColor = System.Drawing.Color.White;
            this.btnListUsers.Location = new System.Drawing.Point(0, 0);
            this.btnListUsers.Name = "btnListUsers";
            this.btnListUsers.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnListUsers.Size = new System.Drawing.Size(200, 35);
            this.btnListUsers.TabIndex = 1;
            this.btnListUsers.Text = "List Users";
            this.btnListUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListUsers.UseVisualStyleBackColor = false;
            this.btnListUsers.Click += new System.EventHandler(this.btnListUsers_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(0, 244);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnUsers.Size = new System.Drawing.Size(200, 40);
            this.btnUsers.TabIndex = 4;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // pnlTeachers
            // 
            this.pnlTeachers.Controls.Add(this.btnAddNTeacher);
            this.pnlTeachers.Controls.Add(this.btnListTeachers);
            this.pnlTeachers.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTeachers.Location = new System.Drawing.Point(0, 174);
            this.pnlTeachers.Name = "pnlTeachers";
            this.pnlTeachers.Size = new System.Drawing.Size(200, 70);
            this.pnlTeachers.TabIndex = 3;
            // 
            // btnAddNTeacher
            // 
            this.btnAddNTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.btnAddNTeacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddNTeacher.FlatAppearance.BorderSize = 0;
            this.btnAddNTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNTeacher.ForeColor = System.Drawing.Color.White;
            this.btnAddNTeacher.Location = new System.Drawing.Point(0, 35);
            this.btnAddNTeacher.Name = "btnAddNTeacher";
            this.btnAddNTeacher.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAddNTeacher.Size = new System.Drawing.Size(200, 35);
            this.btnAddNTeacher.TabIndex = 2;
            this.btnAddNTeacher.Text = "Add New Teacher";
            this.btnAddNTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNTeacher.UseVisualStyleBackColor = false;
            this.btnAddNTeacher.Click += new System.EventHandler(this.btnAddNTeacher_Click);
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
            this.btnListTeachers.Size = new System.Drawing.Size(200, 35);
            this.btnListTeachers.TabIndex = 1;
            this.btnListTeachers.Text = "List Teachers";
            this.btnListTeachers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListTeachers.UseVisualStyleBackColor = false;
            this.btnListTeachers.Click += new System.EventHandler(this.btnListTeachers_Click);
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
            this.btnTeachers.Size = new System.Drawing.Size(200, 40);
            this.btnTeachers.TabIndex = 2;
            this.btnTeachers.Text = "Teachers";
            this.btnTeachers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeachers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTeachers.UseVisualStyleBackColor = true;
            this.btnTeachers.Click += new System.EventHandler(this.btnTeachers_Click);
            // 
            // pnlPic
            // 
            this.pnlPic.Controls.Add(this.lblDirector);
            this.pnlPic.Controls.Add(this.picDirector);
            this.pnlPic.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPic.Location = new System.Drawing.Point(0, 0);
            this.pnlPic.Name = "pnlPic";
            this.pnlPic.Size = new System.Drawing.Size(200, 134);
            this.pnlPic.TabIndex = 0;
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.lblDirector.Location = new System.Drawing.Point(63, 103);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(75, 24);
            this.lblDirector.TabIndex = 2;
            this.lblDirector.Text = "Director";
            // 
            // picDirector
            // 
            this.picDirector.Dock = System.Windows.Forms.DockStyle.Top;
            this.picDirector.Image = ((System.Drawing.Image)(resources.GetObject("picDirector.Image")));
            this.picDirector.Location = new System.Drawing.Point(0, 0);
            this.picDirector.Name = "picDirector";
            this.picDirector.Size = new System.Drawing.Size(200, 100);
            this.picDirector.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picDirector.TabIndex = 1;
            this.picDirector.TabStop = false;
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.pnlChildForm.Controls.Add(this.picSchool);
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlChildForm.Location = new System.Drawing.Point(200, 0);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(673, 563);
            this.pnlChildForm.TabIndex = 2;
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
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(286, 575);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(0, 16);
            this.lblUsername.TabIndex = 3;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(206, 575);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(74, 16);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "Username:";
            // 
            // DirectorMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(873, 600);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.lblUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DirectorMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DirectorMainForm";
            this.Shown += new System.EventHandler(this.DirectorMainForm_Shown);
            this.pnlMain.ResumeLayout(false);
            this.pnlReview.ResumeLayout(false);
            this.pnlRoles.ResumeLayout(false);
            this.pnlUsers.ResumeLayout(false);
            this.pnlTeachers.ResumeLayout(false);
            this.pnlPic.ResumeLayout(false);
            this.pnlPic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDirector)).EndInit();
            this.pnlChildForm.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnlRoles;
        private System.Windows.Forms.Button btnAddNRole;
        private System.Windows.Forms.Button btnRolesList;
        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Panel pnlUsers;
        private System.Windows.Forms.Button btnAddNUser;
        private System.Windows.Forms.Button btnListUsers;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnAddNTeacher;
        private System.Windows.Forms.Button btnListTeachers;
        private System.Windows.Forms.Panel pnlChildForm;
        private System.Windows.Forms.PictureBox picSchool;
        private System.Windows.Forms.Panel pnlReview;
        private System.Windows.Forms.Button btnReviewComments;
        private System.Windows.Forms.Button btnReview;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblUser;
    }
}