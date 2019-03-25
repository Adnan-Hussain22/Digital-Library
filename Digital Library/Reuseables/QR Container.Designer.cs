namespace Digital Library.Reuseables
{
    partial class QR_Container
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
            this.picbox_qrcode = new System.Windows.Forms.PictureBox();
            this.lbl_qrcode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_qrcode)).BeginInit();
            this.SuspendLayout();
            // 
            // picbox_qrcode
            // 
            this.picbox_qrcode.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picbox_qrcode.Location = new System.Drawing.Point(0, 0);
            this.picbox_qrcode.Name = "picbox_qrcode";
            this.picbox_qrcode.Size = new System.Drawing.Size(123, 116);
            this.picbox_qrcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_qrcode.TabIndex = 1;
            this.picbox_qrcode.TabStop = false;
            // 
            // lbl_qrcode
            // 
            this.lbl_qrcode.AutoSize = true;
            this.lbl_qrcode.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qrcode.Location = new System.Drawing.Point(-3, 119);
            this.lbl_qrcode.Name = "lbl_qrcode";
            this.lbl_qrcode.Size = new System.Drawing.Size(41, 17);
            this.lbl_qrcode.TabIndex = 2;
            this.lbl_qrcode.Text = "label1";
            // 
            // QR_Container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.lbl_qrcode);
            this.Controls.Add(this.picbox_qrcode);
            this.Name = "QR_Container";
            this.Size = new System.Drawing.Size(123, 139);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_qrcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox_qrcode;
        private System.Windows.Forms.Label lbl_qrcode;
    }
}
