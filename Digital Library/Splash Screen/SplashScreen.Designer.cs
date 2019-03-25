namespace Advanced_School_Manangement_System.Splash_Screen
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
            this.picbxSplashScreen = new System.Windows.Forms.PictureBox();
            this.Loading = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picbxSplashScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // picbxSplashScreen
            // 
            this.picbxSplashScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picbxSplashScreen.Image = ((System.Drawing.Image)(resources.GetObject("picbxSplashScreen.Image")));
            this.picbxSplashScreen.Location = new System.Drawing.Point(0, 0);
            this.picbxSplashScreen.Name = "picbxSplashScreen";
            this.picbxSplashScreen.Size = new System.Drawing.Size(620, 300);
            this.picbxSplashScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbxSplashScreen.TabIndex = 0;
            this.picbxSplashScreen.TabStop = false;
            // 
            // Loading
            // 
            this.Loading.Interval = 600;
            this.Loading.Tick += new System.EventHandler(this.Loading_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(109)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(620, 300);
            this.Controls.Add(this.picbxSplashScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbxSplashScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbxSplashScreen;
        private System.Windows.Forms.Timer Loading;
    }
}