﻿namespace MenaxhimiDitarit.App_Forms.DirectorForms
{
    partial class UserUpdatePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserUpdatePassword));
            this.picValidatePassword = new System.Windows.Forms.PictureBox();
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.chbShowPassword = new System.Windows.Forms.CheckBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.picPassword = new System.Windows.Forms.PictureBox();
            this.picUsername = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picValidatePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsername)).BeginInit();
            this.SuspendLayout();
            // 
            // picValidatePassword
            // 
            this.picValidatePassword.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_cancel_15;
            resources.ApplyResources(this.picValidatePassword, "picValidatePassword");
            this.picValidatePassword.Name = "picValidatePassword";
            this.picValidatePassword.TabStop = false;
            this.picValidatePassword.MouseHover += new System.EventHandler(this.picValidatePassword_MouseHover);
            // 
            // lblConfirmPass
            // 
            resources.ApplyResources(this.lblConfirmPass, "lblConfirmPass");
            this.lblConfirmPass.ForeColor = System.Drawing.Color.White;
            this.lblConfirmPass.Name = "lblConfirmPass";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.Name = "panel7";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.txtConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtConfirmPass, "txtConfirmPass");
            this.txtConfirmPass.ForeColor = System.Drawing.Color.White;
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.TextChanged += new System.EventHandler(this.txtConfirmPass_TextChanged);
            // 
            // chbShowPassword
            // 
            resources.ApplyResources(this.chbShowPassword, "chbShowPassword");
            this.chbShowPassword.ForeColor = System.Drawing.Color.White;
            this.chbShowPassword.Name = "chbShowPassword";
            this.chbShowPassword.UseVisualStyleBackColor = true;
            this.chbShowPassword.CheckedChanged += new System.EventHandler(this.chbShowPassword_CheckedChanged);
            // 
            // lblPassword
            // 
            resources.ApplyResources(this.lblPassword, "lblPassword");
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Name = "lblPassword";
            // 
            // lblUsername
            // 
            resources.ApplyResources(this.lblUsername, "lblUsername");
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Name = "lblUsername";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtUsername, "txtUsername");
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
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
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtID, "txtID");
            this.txtID.ForeColor = System.Drawing.Color.White;
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            // 
            // picPassword
            // 
            this.picPassword.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_cancel_15;
            resources.ApplyResources(this.picPassword, "picPassword");
            this.picPassword.Name = "picPassword";
            this.picPassword.TabStop = false;
            this.picPassword.MouseHover += new System.EventHandler(this.picPassword_MouseHover);
            // 
            // picUsername
            // 
            this.picUsername.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_cancel_15;
            resources.ApplyResources(this.picUsername, "picUsername");
            this.picUsername.Name = "picUsername";
            this.picUsername.TabStop = false;
            this.picUsername.MouseHover += new System.EventHandler(this.picUsername_MouseHover);
            // 
            // UserUpdatePassword
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.picUsername);
            this.Controls.Add(this.picPassword);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.picValidatePassword);
            this.Controls.Add(this.lblConfirmPass);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.chbShowPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserUpdatePassword";
            ((System.ComponentModel.ISupportInitialize)(this.picValidatePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsername)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picValidatePassword;
        private System.Windows.Forms.Label lblConfirmPass;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.CheckBox chbShowPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.PictureBox picPassword;
        private System.Windows.Forms.PictureBox picUsername;
    }
}