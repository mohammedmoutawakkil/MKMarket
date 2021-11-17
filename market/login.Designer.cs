namespace market
{
    partial class login
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
            this.txtusername = new System.Windows.Forms.TextBox();
            this.paneluser = new System.Windows.Forms.Panel();
            this.panelpassword = new System.Windows.Forms.Panel();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSingIn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.twiterbtn = new FontAwesome.Sharp.IconButton();
            this.gmailbtn = new FontAwesome.Sharp.IconButton();
            this.facebookbtn = new FontAwesome.Sharp.IconButton();
            this.iconpassword = new FontAwesome.Sharp.IconButton();
            this.iconuser = new FontAwesome.Sharp.IconButton();
            this.iconCLOSE = new FontAwesome.Sharp.IconButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pnl_username_error = new System.Windows.Forms.Panel();
            this.pnl_password_error = new System.Windows.Forms.Panel();
            this.iconLOGO = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(47)))));
            this.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusername.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.Color.White;
            this.txtusername.Location = new System.Drawing.Point(121, 190);
            this.txtusername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(263, 18);
            this.txtusername.TabIndex = 1;
            this.txtusername.Text = "User Name";
            this.txtusername.Click += new System.EventHandler(this.txtusername_Click);
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // paneluser
            // 
            this.paneluser.BackColor = System.Drawing.Color.White;
            this.paneluser.Location = new System.Drawing.Point(82, 214);
            this.paneluser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.paneluser.Name = "paneluser";
            this.paneluser.Size = new System.Drawing.Size(302, 2);
            this.paneluser.TabIndex = 2;
            // 
            // panelpassword
            // 
            this.panelpassword.BackColor = System.Drawing.Color.White;
            this.panelpassword.Location = new System.Drawing.Point(82, 276);
            this.panelpassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelpassword.Name = "panelpassword";
            this.panelpassword.Size = new System.Drawing.Size(302, 2);
            this.panelpassword.TabIndex = 5;
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(47)))));
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpassword.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.Color.White;
            this.txtpassword.Location = new System.Drawing.Point(121, 251);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(263, 18);
            this.txtpassword.TabIndex = 4;
            this.txtpassword.Text = "Password";
            this.txtpassword.Click += new System.EventHandler(this.txtpassword_Click);
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginbtn.FlatAppearance.BorderSize = 0;
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.Color.White;
            this.loginbtn.Location = new System.Drawing.Point(84, 320);
            this.loginbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(300, 41);
            this.loginbtn.TabIndex = 6;
            this.loginbtn.Text = "log In";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 378);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Don\'t have an acount?";
            // 
            // lblSingIn
            // 
            this.lblSingIn.AutoSize = true;
            this.lblSingIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSingIn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSingIn.ForeColor = System.Drawing.Color.Teal;
            this.lblSingIn.Location = new System.Drawing.Point(285, 378);
            this.lblSingIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSingIn.Name = "lblSingIn";
            this.lblSingIn.Size = new System.Drawing.Size(69, 22);
            this.lblSingIn.TabIndex = 12;
            this.lblSingIn.Text = "Sing In";
            this.lblSingIn.Click += new System.EventHandler(this.lblSingIn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(188, 410);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Login with";
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
            this.twiterbtn.Location = new System.Drawing.Point(311, 446);
            this.twiterbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.twiterbtn.Name = "twiterbtn";
            this.twiterbtn.Rotation = 0D;
            this.twiterbtn.Size = new System.Drawing.Size(67, 62);
            this.twiterbtn.TabIndex = 9;
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
            this.gmailbtn.Location = new System.Drawing.Point(197, 446);
            this.gmailbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gmailbtn.Name = "gmailbtn";
            this.gmailbtn.Rotation = 0D;
            this.gmailbtn.Size = new System.Drawing.Size(67, 62);
            this.gmailbtn.TabIndex = 8;
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
            this.facebookbtn.Location = new System.Drawing.Point(84, 446);
            this.facebookbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.facebookbtn.Name = "facebookbtn";
            this.facebookbtn.Rotation = 0D;
            this.facebookbtn.Size = new System.Drawing.Size(67, 62);
            this.facebookbtn.TabIndex = 7;
            this.facebookbtn.UseVisualStyleBackColor = true;
            this.facebookbtn.Click += new System.EventHandler(this.facebookbtn_Click);
            // 
            // iconpassword
            // 
            this.iconpassword.FlatAppearance.BorderSize = 0;
            this.iconpassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconpassword.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconpassword.IconChar = FontAwesome.Sharp.IconChar.UnlockAlt;
            this.iconpassword.IconColor = System.Drawing.Color.White;
            this.iconpassword.IconSize = 30;
            this.iconpassword.Location = new System.Drawing.Point(69, 224);
            this.iconpassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconpassword.Name = "iconpassword";
            this.iconpassword.Rotation = 0D;
            this.iconpassword.Size = new System.Drawing.Size(44, 62);
            this.iconpassword.TabIndex = 3;
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
            this.iconuser.Location = new System.Drawing.Point(69, 162);
            this.iconuser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconuser.Name = "iconuser";
            this.iconuser.Rotation = 0D;
            this.iconuser.Size = new System.Drawing.Size(44, 62);
            this.iconuser.TabIndex = 0;
            this.iconuser.UseVisualStyleBackColor = true;
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
            this.iconCLOSE.Location = new System.Drawing.Point(437, 2);
            this.iconCLOSE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconCLOSE.Name = "iconCLOSE";
            this.iconCLOSE.Rotation = 0D;
            this.iconCLOSE.Size = new System.Drawing.Size(29, 21);
            this.iconCLOSE.TabIndex = 27;
            this.iconCLOSE.UseVisualStyleBackColor = true;
            this.iconCLOSE.Click += new System.EventHandler(this.iconCLOSE_Click);
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
            // pnl_username_error
            // 
            this.pnl_username_error.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnl_username_error.Location = new System.Drawing.Point(371, 190);
            this.pnl_username_error.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_username_error.Name = "pnl_username_error";
            this.pnl_username_error.Size = new System.Drawing.Size(13, 26);
            this.pnl_username_error.TabIndex = 28;
            this.pnl_username_error.Visible = false;
            // 
            // pnl_password_error
            // 
            this.pnl_password_error.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnl_password_error.Location = new System.Drawing.Point(371, 251);
            this.pnl_password_error.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_password_error.Name = "pnl_password_error";
            this.pnl_password_error.Size = new System.Drawing.Size(13, 26);
            this.pnl_password_error.TabIndex = 29;
            this.pnl_password_error.Visible = false;
            // 
            // iconLOGO
            // 
            this.iconLOGO.FlatAppearance.BorderSize = 0;
            this.iconLOGO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconLOGO.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconLOGO.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.iconLOGO.IconColor = System.Drawing.Color.Teal;
            this.iconLOGO.IconSize = 80;
            this.iconLOGO.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconLOGO.Location = new System.Drawing.Point(164, 30);
            this.iconLOGO.Margin = new System.Windows.Forms.Padding(4);
            this.iconLOGO.Name = "iconLOGO";
            this.iconLOGO.Rotation = 0D;
            this.iconLOGO.Size = new System.Drawing.Size(107, 84);
            this.iconLOGO.TabIndex = 10;
            this.iconLOGO.UseVisualStyleBackColor = true;
            this.iconLOGO.Click += new System.EventHandler(this.iconLOGO_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(469, 534);
            this.Controls.Add(this.pnl_password_error);
            this.Controls.Add(this.pnl_username_error);
            this.Controls.Add(this.iconCLOSE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSingIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconLOGO);
            this.Controls.Add(this.twiterbtn);
            this.Controls.Add(this.gmailbtn);
            this.Controls.Add(this.facebookbtn);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.panelpassword);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.iconpassword);
            this.Controls.Add(this.paneluser);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.iconuser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.login_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconuser;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Panel paneluser;
        private System.Windows.Forms.Panel panelpassword;
        private System.Windows.Forms.TextBox txtpassword;
        private FontAwesome.Sharp.IconButton iconpassword;
        private System.Windows.Forms.Button loginbtn;
        private FontAwesome.Sharp.IconButton facebookbtn;
        private FontAwesome.Sharp.IconButton gmailbtn;
        private FontAwesome.Sharp.IconButton twiterbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSingIn;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconCLOSE;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel pnl_username_error;
        private System.Windows.Forms.Panel pnl_password_error;
        private FontAwesome.Sharp.IconButton iconLOGO;
    }
}