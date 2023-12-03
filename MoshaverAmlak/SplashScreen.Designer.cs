namespace MoshaverAmlak
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.CircleProgressbar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.SplashScreenTimer = new System.Windows.Forms.Timer(this.components);
            this.StatusLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(58, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 278);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Label9.Location = new System.Drawing.Point(53, 306);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(323, 33);
            this.Label9.TabIndex = 5;
            this.Label9.Text = "Property System Management";
            // 
            // CircleProgressbar
            // 
            this.CircleProgressbar.animated = false;
            this.CircleProgressbar.animationIterval = 5;
            this.CircleProgressbar.animationSpeed = 300;
            this.CircleProgressbar.BackColor = System.Drawing.Color.Transparent;
            this.CircleProgressbar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CircleProgressbar.BackgroundImage")));
            this.CircleProgressbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CircleProgressbar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CircleProgressbar.LabelVisible = true;
            this.CircleProgressbar.LineProgressThickness = 3;
            this.CircleProgressbar.LineThickness = 2;
            this.CircleProgressbar.Location = new System.Drawing.Point(124, 362);
            this.CircleProgressbar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CircleProgressbar.MaxValue = 100;
            this.CircleProgressbar.Name = "CircleProgressbar";
            this.CircleProgressbar.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.CircleProgressbar.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.CircleProgressbar.Size = new System.Drawing.Size(172, 172);
            this.CircleProgressbar.TabIndex = 7;
            this.CircleProgressbar.Value = 0;
            // 
            // SplashScreenTimer
            // 
            this.SplashScreenTimer.Enabled = true;
            this.SplashScreenTimer.Interval = 10;
            this.SplashScreenTimer.Tick += new System.EventHandler(this.SplashScreenTimer_Tick);
            // 
            // StatusLable
            // 
            this.StatusLable.AutoSize = true;
            this.StatusLable.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLable.ForeColor = System.Drawing.Color.White;
            this.StatusLable.Location = new System.Drawing.Point(164, 550);
            this.StatusLable.Name = "StatusLable";
            this.StatusLable.Size = new System.Drawing.Size(51, 19);
            this.StatusLable.TabIndex = 8;
            this.StatusLable.Text = "label1";
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(416, 648);
            this.Controls.Add(this.StatusLable);
            this.Controls.Add(this.CircleProgressbar);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Label Label9;
        private Bunifu.Framework.UI.BunifuCircleProgressbar CircleProgressbar;
        private System.Windows.Forms.Timer SplashScreenTimer;
        private System.Windows.Forms.Label StatusLable;
    }
}