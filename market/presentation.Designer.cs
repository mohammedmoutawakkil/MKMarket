namespace market
{
    partial class presentation
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.circulP = new CircularProgressBar.CircularProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Turquoise;
            this.label3.Location = new System.Drawing.Point(70, 407);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Copyright © MK Markers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Turquoise;
            this.label2.Location = new System.Drawing.Point(126, 351);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Loading...";
            // 
            // circulP
            // 
            this.circulP.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circulP.AnimationSpeed = 500;
            this.circulP.BackColor = System.Drawing.Color.Transparent;
            this.circulP.Font = new System.Drawing.Font("Palatino Linotype", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circulP.ForeColor = System.Drawing.Color.Turquoise;
            this.circulP.InnerColor = System.Drawing.Color.Transparent;
            this.circulP.InnerMargin = 2;
            this.circulP.InnerWidth = -1;
            this.circulP.Location = new System.Drawing.Point(75, 143);
            this.circulP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.circulP.MarqueeAnimationSpeed = 2000;
            this.circulP.Name = "circulP";
            this.circulP.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.circulP.OuterMargin = -25;
            this.circulP.OuterWidth = 26;
            this.circulP.ProgressColor = System.Drawing.Color.Turquoise;
            this.circulP.ProgressWidth = 13;
            this.circulP.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.circulP.Size = new System.Drawing.Size(200, 185);
            this.circulP.StartAngle = 270;
            this.circulP.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circulP.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circulP.SubscriptText = "";
            this.circulP.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circulP.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circulP.SuperscriptText = "";
            this.circulP.TabIndex = 7;
            this.circulP.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circulP.Value = 12;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::market.Properties.Resources._49ad159a_523b_4b02_97c4_9d2fe130aae6_200x200;
            this.pictureBox1.Location = new System.Drawing.Point(96, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // presentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(340, 465);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.circulP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "presentation";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "presentation";
            this.Load += new System.EventHandler(this.presentation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CircularProgressBar.CircularProgressBar circulP;
        private System.Windows.Forms.Timer timer1;
    }
}