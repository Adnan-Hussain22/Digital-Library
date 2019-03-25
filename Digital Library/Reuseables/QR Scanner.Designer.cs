namespace Advanced_School_Manangement_System.Reuseables
{
    partial class QR_Scanner
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
            this.btn_scancode = new System.Windows.Forms.Button();
            this.btn_opencamera = new System.Windows.Forms.Button();
            this.cmb_capturedevices = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_close = new System.Windows.Forms.Label();
            this.timer_laserline = new System.Windows.Forms.Timer(this.components);
            this.laser_line = new System.Windows.Forms.Panel();
            this.picbox_frame = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_frame)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_scancode
            // 
            this.btn_scancode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_scancode.Location = new System.Drawing.Point(173, 257);
            this.btn_scancode.Name = "btn_scancode";
            this.btn_scancode.Size = new System.Drawing.Size(75, 40);
            this.btn_scancode.TabIndex = 6;
            this.btn_scancode.Text = "Scan Code";
            this.btn_scancode.UseVisualStyleBackColor = true;
            this.btn_scancode.Click += new System.EventHandler(this.btn_scancode_Click);
            // 
            // btn_opencamera
            // 
            this.btn_opencamera.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_opencamera.Location = new System.Drawing.Point(92, 257);
            this.btn_opencamera.Name = "btn_opencamera";
            this.btn_opencamera.Size = new System.Drawing.Size(75, 40);
            this.btn_opencamera.TabIndex = 5;
            this.btn_opencamera.Text = "Camera";
            this.btn_opencamera.UseVisualStyleBackColor = true;
            this.btn_opencamera.Click += new System.EventHandler(this.btn_opencamera_Click);
            // 
            // cmb_capturedevices
            // 
            this.cmb_capturedevices.FormattingEnabled = true;
            this.cmb_capturedevices.Location = new System.Drawing.Point(19, 35);
            this.cmb_capturedevices.Name = "cmb_capturedevices";
            this.cmb_capturedevices.Size = new System.Drawing.Size(239, 21);
            this.cmb_capturedevices.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Devices";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_close
            // 
            this.btn_close.AutoSize = true;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(253, 4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(19, 20);
            this.btn_close.TabIndex = 9;
            this.btn_close.Text = "X";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // timer_laserline
            // 
            this.timer_laserline.Interval = 8;
            // 
            // laser_line
            // 
            this.laser_line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(8)))), ((int)(((byte)(24)))));
            this.laser_line.Location = new System.Drawing.Point(33, 226);
            this.laser_line.Name = "laser_line";
            this.laser_line.Size = new System.Drawing.Size(208, 2);
            this.laser_line.TabIndex = 12;
            this.laser_line.Visible = false;
            // 
            // picbox_frame
            // 
            this.picbox_frame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbox_frame.Location = new System.Drawing.Point(28, 67);
            this.picbox_frame.Name = "picbox_frame";
            this.picbox_frame.Size = new System.Drawing.Size(219, 180);
            this.picbox_frame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_frame.TabIndex = 11;
            this.picbox_frame.TabStop = false;
            // 
            // QR_Scanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.laser_line);
            this.Controls.Add(this.picbox_frame);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_capturedevices);
            this.Controls.Add(this.btn_scancode);
            this.Controls.Add(this.btn_opencamera);
            this.Name = "QR_Scanner";
            this.Size = new System.Drawing.Size(275, 314);
            this.Load += new System.EventHandler(this.QR_Scanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_frame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_scancode;
        private System.Windows.Forms.Button btn_opencamera;
        private System.Windows.Forms.ComboBox cmb_capturedevices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label btn_close;
        private System.Windows.Forms.Timer timer_laserline;
        private System.Windows.Forms.Panel laser_line;
        private System.Windows.Forms.PictureBox picbox_frame;
    }
}
