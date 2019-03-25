namespace Advanced_School_Manangement_System.Reuseables
{
    partial class Add_Specific
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Label();
            this.textbox_reuseableText1 = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.textbox_reuseableText2 = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(287, 35);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(85, 33);
            this.btn_add.TabIndex = 76;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_close
            // 
            this.btn_close.AutoSize = true;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(356, 4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(17, 16);
            this.btn_close.TabIndex = 77;
            this.btn_close.Text = "X";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // textbox_reuseableText1
            // 
            this.textbox_reuseableText1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_reuseableText1.Location = new System.Drawing.Point(4, 28);
            this.textbox_reuseableText1.Name = "textbox_reuseableText1";
            this.textbox_reuseableText1.Size = new System.Drawing.Size(277, 25);
            this.textbox_reuseableText1.TabIndex = 81;
            this.textbox_reuseableText1.WaterMark = "Default Watermark...";
            this.textbox_reuseableText1.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.textbox_reuseableText1.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_reuseableText1.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // textbox_reuseableText2
            // 
            this.textbox_reuseableText2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_reuseableText2.Location = new System.Drawing.Point(4, 59);
            this.textbox_reuseableText2.Name = "textbox_reuseableText2";
            this.textbox_reuseableText2.Size = new System.Drawing.Size(277, 25);
            this.textbox_reuseableText2.TabIndex = 82;
            this.textbox_reuseableText2.Visible = false;
            this.textbox_reuseableText2.WaterMark = "Default Watermark...";
            this.textbox_reuseableText2.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.textbox_reuseableText2.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_reuseableText2.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // Add_Specific
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.textbox_reuseableText2);
            this.Controls.Add(this.textbox_reuseableText1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_add);
            this.Name = "Add_Specific";
            this.Size = new System.Drawing.Size(376, 90);
            this.Load += new System.EventHandler(this.Add_Specific_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label btn_close;
        private ChreneLib.Controls.TextBoxes.CTextBox textbox_reuseableText1;
        private ChreneLib.Controls.TextBoxes.CTextBox textbox_reuseableText2;
    }
}
