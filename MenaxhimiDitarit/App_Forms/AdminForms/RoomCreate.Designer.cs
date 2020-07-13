namespace MenaxhimiDitarit
{
    partial class RoomCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomCreate));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.picRoomNo = new System.Windows.Forms.PictureBox();
            this.picRoomType = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picRoomNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoomType)).BeginInit();
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
            // lblRoomType
            // 
            resources.ApplyResources(this.lblRoomType, "lblRoomType");
            this.lblRoomType.ForeColor = System.Drawing.Color.White;
            this.lblRoomType.Name = "lblRoomType";
            // 
            // lblRoomNo
            // 
            resources.ApplyResources(this.lblRoomNo, "lblRoomNo");
            this.lblRoomNo.ForeColor = System.Drawing.Color.White;
            this.lblRoomNo.Name = "lblRoomNo";
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
            // txtRoomType
            // 
            resources.ApplyResources(this.txtRoomType, "txtRoomType");
            this.txtRoomType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.txtRoomType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRoomType.ForeColor = System.Drawing.Color.White;
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.TextChanged += new System.EventHandler(this.txtRoomType_TextChanged);
            // 
            // txtRoomNo
            // 
            resources.ApplyResources(this.txtRoomNo, "txtRoomNo");
            this.txtRoomNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.txtRoomNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRoomNo.ForeColor = System.Drawing.Color.White;
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.TextChanged += new System.EventHandler(this.txtRoomNo_TextChanged);
            // 
            // picRoomNo
            // 
            resources.ApplyResources(this.picRoomNo, "picRoomNo");
            this.picRoomNo.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_cancel_15;
            this.picRoomNo.Name = "picRoomNo";
            this.picRoomNo.TabStop = false;
            this.picRoomNo.MouseHover += new System.EventHandler(this.picRoomNo_MouseHover);
            // 
            // picRoomType
            // 
            resources.ApplyResources(this.picRoomType, "picRoomType");
            this.picRoomType.Image = global::MenaxhimiDitarit.Properties.Resources.icons8_cancel_15;
            this.picRoomType.Name = "picRoomType";
            this.picRoomType.TabStop = false;
            this.picRoomType.MouseHover += new System.EventHandler(this.picRoomType_MouseHover);
            // 
            // RoomCreate
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.picRoomType);
            this.Controls.Add(this.picRoomNo);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.lblRoomNo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtRoomType);
            this.Controls.Add(this.txtRoomNo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomCreate";
            ((System.ComponentModel.ISupportInitialize)(this.picRoomNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoomType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.PictureBox picRoomNo;
        private System.Windows.Forms.PictureBox picRoomType;
    }
}