namespace Advanced_School_Manangement_System
{
    partial class CustomPanelDashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomPanelDashboard));
            this.pnlRightBackColor = new System.Windows.Forms.Panel();
            this.Data = new System.Windows.Forms.Label();
            this.pnlLeftBackColor = new System.Windows.Forms.Panel();
            this.LeftPicture = new System.Windows.Forms.PictureBox();
            this.Names = new System.Windows.Forms.Label();
            this.pnlSlider = new System.Windows.Forms.Panel();
            this.Slider = new System.Windows.Forms.Timer(this.components);
            this.ReverseSlider = new System.Windows.Forms.Timer(this.components);
            this.PositionCheck = new System.Windows.Forms.Timer(this.components);
            this.pnlRightBackColor.SuspendLayout();
            this.pnlLeftBackColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRightBackColor
            // 
            this.pnlRightBackColor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRightBackColor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlRightBackColor.Controls.Add(this.Data);
            this.pnlRightBackColor.Controls.Add(this.pnlLeftBackColor);
            this.pnlRightBackColor.Controls.Add(this.Names);
            this.pnlRightBackColor.Location = new System.Drawing.Point(0, 0);
            this.pnlRightBackColor.Name = "pnlRightBackColor";
            this.pnlRightBackColor.Size = new System.Drawing.Size(252, 72);
            this.pnlRightBackColor.TabIndex = 0;
            this.pnlRightBackColor.MouseEnter += new System.EventHandler(this.LeftPicture_MouseEnter);
            // 
            // Data
            // 
            this.Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Data.AutoSize = true;
            this.Data.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Data.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.Data.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.Data.Location = new System.Drawing.Point(124, 8);
            this.Data.Margin = new System.Windows.Forms.Padding(0);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(71, 28);
            this.Data.TabIndex = 1;
            this.Data.Text = "1,6893";
            this.Data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLeftBackColor
            // 
            this.pnlLeftBackColor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLeftBackColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.pnlLeftBackColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlLeftBackColor.Controls.Add(this.LeftPicture);
            this.pnlLeftBackColor.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftBackColor.Name = "pnlLeftBackColor";
            this.pnlLeftBackColor.Size = new System.Drawing.Size(78, 72);
            this.pnlLeftBackColor.TabIndex = 0;
            this.pnlLeftBackColor.MouseEnter += new System.EventHandler(this.LeftPicture_MouseEnter);
            this.pnlLeftBackColor.MouseLeave += new System.EventHandler(this.Data_MouseLeave);
            // 
            // LeftPicture
            // 
            this.LeftPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LeftPicture.Image = ((System.Drawing.Image)(resources.GetObject("LeftPicture.Image")));
            this.LeftPicture.Location = new System.Drawing.Point(8, 10);
            this.LeftPicture.Name = "LeftPicture";
            this.LeftPicture.Size = new System.Drawing.Size(62, 50);
            this.LeftPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LeftPicture.TabIndex = 0;
            this.LeftPicture.TabStop = false;
            // 
            // Names
            // 
            this.Names.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Names.AutoSize = true;
            this.Names.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Names.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Names.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.Names.Location = new System.Drawing.Point(108, 38);
            this.Names.Margin = new System.Windows.Forms.Padding(0);
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(103, 25);
            this.Names.TabIndex = 1;
            this.Names.Text = "MEMBERS";
            this.Names.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSlider
            // 
            this.pnlSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.pnlSlider.Location = new System.Drawing.Point(0, 72);
            this.pnlSlider.Name = "pnlSlider";
            this.pnlSlider.Size = new System.Drawing.Size(0, 2);
            this.pnlSlider.TabIndex = 1;
            // 
            // Slider
            // 
            this.Slider.Interval = 10;
            this.Slider.Tick += new System.EventHandler(this.Slider_Tick);
            // 
            // ReverseSlider
            // 
            this.ReverseSlider.Interval = 10;
            this.ReverseSlider.Tick += new System.EventHandler(this.ReverseSlider_Tick);
            // 
            // PositionCheck
            // 
            this.PositionCheck.Interval = 200;
            this.PositionCheck.Tick += new System.EventHandler(this.PositionCheck_Tick);
            // 
            // CustomPanelDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlSlider);
            this.Controls.Add(this.pnlRightBackColor);
            this.Name = "CustomPanelDashboard";
            this.Size = new System.Drawing.Size(252, 74);
            this.pnlRightBackColor.ResumeLayout(false);
            this.pnlRightBackColor.PerformLayout();
            this.pnlLeftBackColor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LeftPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRightBackColor;
        private System.Windows.Forms.Panel pnlLeftBackColor;
        private System.Windows.Forms.PictureBox LeftPicture;
        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.Label Names;
        private System.Windows.Forms.Panel pnlSlider;
        private System.Windows.Forms.Timer Slider;
        private System.Windows.Forms.Timer ReverseSlider;
        private System.Windows.Forms.Timer PositionCheck;
    }
}
