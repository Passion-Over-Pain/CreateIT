namespace CreateTech
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.cbxRemember = new System.Windows.Forms.CheckBox();
            this.lbltime = new System.Windows.Forms.Label();
            this.eye = new System.Windows.Forms.PictureBox();
            this.profilepic = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilepic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Black;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmail.Location = new System.Drawing.Point(63, 379);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 19);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.Black;
            this.txtemail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtemail.Location = new System.Drawing.Point(121, 376);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(132, 26);
            this.txtemail.TabIndex = 2;
            this.txtemail.Text = "example@email.com";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Black;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPassword.Location = new System.Drawing.Point(42, 420);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(77, 19);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.Black;
            this.txtpassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtpassword.Location = new System.Drawing.Point(121, 417);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(132, 26);
            this.txtpassword.TabIndex = 4;
            this.txtpassword.Text = "password";
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.Black;
            this.btnSignIn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSignIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnSignIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSignIn.Location = new System.Drawing.Point(144, 485);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(75, 26);
            this.btnSignIn.TabIndex = 5;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.Black;
            this.btnCreateAccount.FlatAppearance.BorderSize = 0;
            this.btnCreateAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCreateAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAccount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateAccount.Location = new System.Drawing.Point(93, 517);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(174, 26);
            this.btnCreateAccount.TabIndex = 7;
            this.btnCreateAccount.Text = "Create a new account";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(144, 549);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 26);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.Black;
            this.pnlBackground.Controls.Add(this.cbxRemember);
            this.pnlBackground.Controls.Add(this.lbltime);
            this.pnlBackground.Controls.Add(this.btnClose);
            this.pnlBackground.Controls.Add(this.eye);
            this.pnlBackground.Controls.Add(this.btnCreateAccount);
            this.pnlBackground.Controls.Add(this.btnSignIn);
            this.pnlBackground.Controls.Add(this.txtpassword);
            this.pnlBackground.Controls.Add(this.lblPassword);
            this.pnlBackground.Controls.Add(this.txtemail);
            this.pnlBackground.Controls.Add(this.lblEmail);
            this.pnlBackground.Controls.Add(this.profilepic);
            this.pnlBackground.Controls.Add(this.pictureBox2);
            this.pnlBackground.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.pnlBackground.Location = new System.Drawing.Point(-4, -9);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(349, 664);
            this.pnlBackground.TabIndex = 1;
            this.pnlBackground.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBackground_MouseMove);
            // 
            // cbxRemember
            // 
            this.cbxRemember.AutoSize = true;
            this.cbxRemember.Location = new System.Drawing.Point(46, 462);
            this.cbxRemember.Name = "cbxRemember";
            this.cbxRemember.Size = new System.Drawing.Size(121, 19);
            this.cbxRemember.TabIndex = 20;
            this.cbxRemember.Text = "Remember Me 🙂";
            this.cbxRemember.UseVisualStyleBackColor = true;
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.BackColor = System.Drawing.Color.Black;
            this.lbltime.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltime.Location = new System.Drawing.Point(124, 18);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(79, 31);
            this.lbltime.TabIndex = 19;
            this.lbltime.Text = "12:00";
            // 
            // eye
            // 
            this.eye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(5)))), ((int)(((byte)(20)))));
            this.eye.Image = global::CreateTech.Properties.Resources.eye;
            this.eye.Location = new System.Drawing.Point(259, 399);
            this.eye.Name = "eye";
            this.eye.Size = new System.Drawing.Size(45, 43);
            this.eye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eye.TabIndex = 8;
            this.eye.TabStop = false;
            this.eye.Click += new System.EventHandler(this.eye_Click);
            // 
            // profilepic
            // 
            this.profilepic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profilepic.BackgroundImage")));
            this.profilepic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.profilepic.Image = global::CreateTech.Properties.Resources.Profile_Icon;
            this.profilepic.Location = new System.Drawing.Point(121, 95);
            this.profilepic.Name = "profilepic";
            this.profilepic.Size = new System.Drawing.Size(98, 99);
            this.profilepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilepic.TabIndex = 10;
            this.profilepic.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-51, -8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(446, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(339, 635);
            this.Controls.Add(this.pnlBackground);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilepic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.PictureBox eye;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox profilepic;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.CheckBox cbxRemember;
    }
}

