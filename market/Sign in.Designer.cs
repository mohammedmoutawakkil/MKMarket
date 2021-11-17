namespace market
{
    partial class Sign_in
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
            this.panelpassword = new System.Windows.Forms.Panel();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.paneluser = new System.Windows.Forms.Panel();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.panelemail = new System.Windows.Forms.Panel();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.singnbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.iconCLOSE = new FontAwesome.Sharp.IconButton();
            this.twiterbtn = new FontAwesome.Sharp.IconButton();
            this.gmailbtn = new FontAwesome.Sharp.IconButton();
            this.facebookbtn = new FontAwesome.Sharp.IconButton();
            this.iconemail = new FontAwesome.Sharp.IconButton();
            this.iconpassword = new FontAwesome.Sharp.IconButton();
            this.iconuser = new FontAwesome.Sharp.IconButton();
            this.iconLOGO = new FontAwesome.Sharp.IconButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblerror = new System.Windows.Forms.Label();
            this.pnl_username_error = new System.Windows.Forms.Panel();
            this.pnl_password_error = new System.Windows.Forms.Panel();
            this.pnl_email_error = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelpassword
            // 
            this.panelpassword.BackColor = System.Drawing.Color.White;
            this.panelpassword.Location = new System.Drawing.Point(84, 241);
            this.panelpassword.Margin = new System.Windows.Forms.Padding(4);
            this.panelpassword.Name = "panelpassword";
            this.panelpassword.Size = new System.Drawing.Size(303, 1);
            this.panelpassword.TabIndex = 17;
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(47)))));
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpassword.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.Color.White;
            this.txtpassword.Location = new System.Drawing.Point(124, 217);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(263, 18);
            this.txtpassword.TabIndex = 16;
            this.txtpassword.Text = "Password";
            this.txtpassword.Click += new System.EventHandler(this.txtpassword_Click);
            // 
            // paneluser
            // 
            this.paneluser.BackColor = System.Drawing.Color.White;
            this.paneluser.Location = new System.Drawing.Point(84, 187);
            this.paneluser.Margin = new System.Windows.Forms.Padding(4);
            this.paneluser.Name = "paneluser";
            this.paneluser.Size = new System.Drawing.Size(303, 1);
            this.paneluser.TabIndex = 14;
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(47)))));
            this.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusername.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.Color.White;
            this.txtusername.Location = new System.Drawing.Point(124, 162);
            this.txtusername.Margin = new System.Windows.Forms.Padding(4);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(263, 18);
            this.txtusername.TabIndex = 13;
            this.txtusername.Text = "User Name";
            this.txtusername.Click += new System.EventHandler(this.txtusername_Click);
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // panelemail
            // 
            this.panelemail.BackColor = System.Drawing.Color.White;
            this.panelemail.Location = new System.Drawing.Point(84, 297);
            this.panelemail.Margin = new System.Windows.Forms.Padding(4);
            this.panelemail.Name = "panelemail";
            this.panelemail.Size = new System.Drawing.Size(303, 1);
            this.panelemail.TabIndex = 20;
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(47)))));
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtemail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.ForeColor = System.Drawing.Color.White;
            this.txtemail.Location = new System.Drawing.Point(124, 272);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(263, 18);
            this.txtemail.TabIndex = 19;
            this.txtemail.Text = "Email";
            this.txtemail.Click += new System.EventHandler(this.txtemail_Click);
            // 
            // singnbtn
            // 
            this.singnbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.singnbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.singnbtn.FlatAppearance.BorderSize = 0;
            this.singnbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.singnbtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singnbtn.ForeColor = System.Drawing.Color.White;
            this.singnbtn.Location = new System.Drawing.Point(84, 346);
            this.singnbtn.Margin = new System.Windows.Forms.Padding(4);
            this.singnbtn.Name = "singnbtn";
            this.singnbtn.Size = new System.Drawing.Size(303, 41);
            this.singnbtn.TabIndex = 21;
            this.singnbtn.Text = "Sign Up";
            this.singnbtn.UseVisualStyleBackColor = false;
            this.singnbtn.Click += new System.EventHandler(this.singnbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.5F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(185, 402);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Sign Up with";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // iconCLOSE
            // 
            this.iconCLOSE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconCLOSE.FlatAppearance.BorderSize = 0;
            this.iconCLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconCLOSE.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconCLOSE.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconCLOSE.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconCLOSE.IconColor = System.Drawing.Color.White;
            this.iconCLOSE.IconSize = 22;
            this.iconCLOSE.Location = new System.Drawing.Point(437, 1);
            this.iconCLOSE.Margin = new System.Windows.Forms.Padding(4);
            this.iconCLOSE.Name = "iconCLOSE";
            this.iconCLOSE.Rotation = 0D;
            this.iconCLOSE.Size = new System.Drawing.Size(29, 21);
            this.iconCLOSE.TabIndex = 26;
            this.iconCLOSE.UseVisualStyleBackColor = true;
            this.iconCLOSE.Click += new System.EventHandler(this.iconCLOSE_Click);
            // 
            // twiterbtn
            // 
            this.twiterbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.twiterbtn.FlatAppearance.BorderSize = 0;
            this.twiterbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twiterbtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.twiterbtn.IconChar = FontAwesome.Sharp.IconChar.Twitter;
            this.twiterbtn.IconColor = System.Drawing.Color.Teal;
            this.twiterbtn.IconSize = 60;
            this.twiterbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.twiterbtn.Location = new System.Drawing.Point(317, 441);
            this.twiterbtn.Margin = new System.Windows.Forms.Padding(4);
            this.twiterbtn.Name = "twiterbtn";
            this.twiterbtn.Rotation = 0D;
            this.twiterbtn.Size = new System.Drawing.Size(67, 62);
            this.twiterbtn.TabIndex = 24;
            this.twiterbtn.UseVisualStyleBackColor = true;
            // 
            // gmailbtn
            // 
            this.gmailbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gmailbtn.FlatAppearance.BorderSize = 0;
            this.gmailbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gmailbtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.gmailbtn.IconChar = FontAwesome.Sharp.IconChar.GooglePlus;
            this.gmailbtn.IconColor = System.Drawing.Color.Teal;
            this.gmailbtn.IconSize = 60;
            this.gmailbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gmailbtn.Location = new System.Drawing.Point(204, 441);
            this.gmailbtn.Margin = new System.Windows.Forms.Padding(4);
            this.gmailbtn.Name = "gmailbtn";
            this.gmailbtn.Rotation = 0D;
            this.gmailbtn.Size = new System.Drawing.Size(67, 62);
            this.gmailbtn.TabIndex = 23;
            this.gmailbtn.UseVisualStyleBackColor = true;
            // 
            // facebookbtn
            // 
            this.facebookbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.facebookbtn.FlatAppearance.BorderSize = 0;
            this.facebookbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.facebookbtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.facebookbtn.IconChar = FontAwesome.Sharp.IconChar.Facebook;
            this.facebookbtn.IconColor = System.Drawing.Color.Teal;
            this.facebookbtn.IconSize = 60;
            this.facebookbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.facebookbtn.Location = new System.Drawing.Point(91, 441);
            this.facebookbtn.Margin = new System.Windows.Forms.Padding(4);
            this.facebookbtn.Name = "facebookbtn";
            this.facebookbtn.Rotation = 0D;
            this.facebookbtn.Size = new System.Drawing.Size(67, 62);
            this.facebookbtn.TabIndex = 22;
            this.facebookbtn.UseVisualStyleBackColor = true;
            // 
            // iconemail
            // 
            this.iconemail.FlatAppearance.BorderSize = 0;
            this.iconemail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconemail.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconemail.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.iconemail.IconColor = System.Drawing.Color.White;
            this.iconemail.IconSize = 30;
            this.iconemail.Location = new System.Drawing.Point(72, 250);
            this.iconemail.Margin = new System.Windows.Forms.Padding(4);
            this.iconemail.Name = "iconemail";
            this.iconemail.Rotation = 0D;
            this.iconemail.Size = new System.Drawing.Size(44, 62);
            this.iconemail.TabIndex = 18;
            this.iconemail.UseVisualStyleBackColor = true;
            // 
            // iconpassword
            // 
            this.iconpassword.FlatAppearance.BorderSize = 0;
            this.iconpassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconpassword.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconpassword.IconChar = FontAwesome.Sharp.IconChar.UnlockAlt;
            this.iconpassword.IconColor = System.Drawing.Color.White;
            this.iconpassword.IconSize = 30;
            this.iconpassword.Location = new System.Drawing.Point(72, 190);
            this.iconpassword.Margin = new System.Windows.Forms.Padding(4);
            this.iconpassword.Name = "iconpassword";
            this.iconpassword.Rotation = 0D;
            this.iconpassword.Size = new System.Drawing.Size(44, 62);
            this.iconpassword.TabIndex = 15;
            this.iconpassword.UseVisualStyleBackColor = true;
            // 
            // iconuser
            // 
            this.iconuser.FlatAppearance.BorderSize = 0;
            this.iconuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconuser.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconuser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconuser.IconColor = System.Drawing.Color.White;
            this.iconuser.IconSize = 30;
            this.iconuser.Location = new System.Drawing.Point(72, 135);
            this.iconuser.Margin = new System.Windows.Forms.Padding(4);
            this.iconuser.Name = "iconuser";
            this.iconuser.Rotation = 0D;
            this.iconuser.Size = new System.Drawing.Size(44, 62);
            this.iconuser.TabIndex = 12;
            this.iconuser.UseVisualStyleBackColor = true;
            // 
            // iconLOGO
            // 
            this.iconLOGO.Cursor = System.Windows.Forms.Cursors.Default;
            this.iconLOGO.FlatAppearance.BorderSize = 0;
            this.iconLOGO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconLOGO.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconLOGO.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.iconLOGO.IconColor = System.Drawing.Color.Teal;
            this.iconLOGO.IconSize = 80;
            this.iconLOGO.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconLOGO.Location = new System.Drawing.Point(164, 31);
            this.iconLOGO.Margin = new System.Windows.Forms.Padding(4);
            this.iconLOGO.Name = "iconLOGO";
            this.iconLOGO.Rotation = 0D;
            this.iconLOGO.Size = new System.Drawing.Size(107, 84);
            this.iconLOGO.TabIndex = 11;
            this.iconLOGO.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror.ForeColor = System.Drawing.Color.DarkRed;
            this.lblerror.Location = new System.Drawing.Point(84, 306);
            this.lblerror.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 19);
            this.lblerror.TabIndex = 27;
            this.lblerror.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_username_error
            // 
            this.pnl_username_error.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnl_username_error.Location = new System.Drawing.Point(386, 162);
            this.pnl_username_error.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_username_error.Name = "pnl_username_error";
            this.pnl_username_error.Size = new System.Drawing.Size(13, 26);
            this.pnl_username_error.TabIndex = 29;
            this.pnl_username_error.Visible = false;
            // 
            // pnl_password_error
            // 
            this.pnl_password_error.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnl_password_error.Location = new System.Drawing.Point(386, 217);
            this.pnl_password_error.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_password_error.Name = "pnl_password_error";
            this.pnl_password_error.Size = new System.Drawing.Size(13, 26);
            this.pnl_password_error.TabIndex = 29;
            this.pnl_password_error.Visible = false;
            // 
            // pnl_email_error
            // 
            this.pnl_email_error.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnl_email_error.Location = new System.Drawing.Point(386, 272);
            this.pnl_email_error.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_email_error.Name = "pnl_email_error";
            this.pnl_email_error.Size = new System.Drawing.Size(13, 26);
            this.pnl_email_error.TabIndex = 29;
            this.pnl_email_error.Visible = false;
            // 
            // Sign_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(469, 534);
            this.Controls.Add(this.pnl_email_error);
            this.Controls.Add(this.pnl_password_error);
            this.Controls.Add(this.pnl_username_error);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.iconCLOSE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.twiterbtn);
            this.Controls.Add(this.gmailbtn);
            this.Controls.Add(this.facebookbtn);
            this.Controls.Add(this.singnbtn);
            this.Controls.Add(this.panelemail);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.panelpassword);
            this.Controls.Add(this.iconemail);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.iconpassword);
            this.Controls.Add(this.paneluser);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.iconuser);
            this.Controls.Add(this.iconLOGO);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Sign_in";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign_in";
            this.Load += new System.EventHandler(this.Sign_in_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Sign_in_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconLOGO;
        private System.Windows.Forms.Panel panelpassword;
        private System.Windows.Forms.TextBox txtpassword;
        private FontAwesome.Sharp.IconButton iconpassword;
        private System.Windows.Forms.Panel paneluser;
        private System.Windows.Forms.TextBox txtusername;
        private FontAwesome.Sharp.IconButton iconuser;
        private System.Windows.Forms.Panel panelemail;
        private System.Windows.Forms.TextBox txtemail;
        private FontAwesome.Sharp.IconButton iconemail;
        private System.Windows.Forms.Button singnbtn;
        private FontAwesome.Sharp.IconButton twiterbtn;
        private FontAwesome.Sharp.IconButton gmailbtn;
        private FontAwesome.Sharp.IconButton facebookbtn;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconCLOSE;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.Panel pnl_username_error;
        private System.Windows.Forms.Panel pnl_password_error;
        private System.Windows.Forms.Panel pnl_email_error;
    }
}