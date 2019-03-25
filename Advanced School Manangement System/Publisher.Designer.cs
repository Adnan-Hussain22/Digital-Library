namespace Advanced_School_Manangement_System
{
    partial class Publisher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Publisher));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_add = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_uplaodimage = new Bunifu.Framework.UI.BunifuFlatButton();
            this.picBox_Image = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textbox_publisherid = new System.Windows.Forms.TextBox();
            this.TextboxAddBk_Bookid = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.textbox_phoneno = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_publishername = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.textbox_address = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 675);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(846, 17);
            this.panel2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 17);
            this.panel1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btn_back);
            this.panel3.Location = new System.Drawing.Point(0, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(846, 51);
            this.panel3.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.5F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(47, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "Add Publisher";
            // 
            // btn_back
            // 
            this.btn_back.Activecolor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_back.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_back.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_back.BorderRadius = 5;
            this.btn_back.ButtonText = "";
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.DisabledColor = System.Drawing.Color.Gray;
            this.btn_back.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_back.Iconimage = null;
            this.btn_back.Iconimage_right = null;
            this.btn_back.Iconimage_right_Selected = null;
            this.btn_back.Iconimage_Selected = null;
            this.btn_back.IconMarginLeft = 0;
            this.btn_back.IconMarginRight = 0;
            this.btn_back.IconRightVisible = true;
            this.btn_back.IconRightZoom = 0D;
            this.btn_back.IconVisible = true;
            this.btn_back.IconZoom = 90D;
            this.btn_back.IsTab = false;
            this.btn_back.Location = new System.Drawing.Point(3, 4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Normalcolor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_back.OnHovercolor = System.Drawing.SystemColors.Control;
            this.btn_back.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_back.selected = false;
            this.btn_back.Size = new System.Drawing.Size(49, 38);
            this.btn_back.TabIndex = 19;
            this.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_back.Textcolor = System.Drawing.Color.White;
            this.btn_back.TextFont = new System.Drawing.Font("Century Gothic", 9.5F);
            this.btn_back.Visible = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Controls.Add(this.btn_add);
            this.panel4.Controls.Add(this.btn_uplaodimage);
            this.panel4.Controls.Add(this.picBox_Image);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.textbox_publisherid);
            this.panel4.Controls.Add(this.TextboxAddBk_Bookid);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.textbox_phoneno);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.textbox_publishername);
            this.panel4.Controls.Add(this.textbox_address);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(0, 72);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(846, 259);
            this.panel4.TabIndex = 13;
            // 
            // btn_add
            // 
            this.btn_add.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.BorderRadius = 5;
            this.btn_add.ButtonText = "Add";
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.DisabledColor = System.Drawing.Color.Gray;
            this.btn_add.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_add.Iconimage = null;
            this.btn_add.Iconimage_right = null;
            this.btn_add.Iconimage_right_Selected = null;
            this.btn_add.Iconimage_Selected = null;
            this.btn_add.IconMarginLeft = 0;
            this.btn_add.IconMarginRight = 0;
            this.btn_add.IconRightVisible = false;
            this.btn_add.IconRightZoom = 0D;
            this.btn_add.IconVisible = false;
            this.btn_add.IconZoom = 90D;
            this.btn_add.IsTab = false;
            this.btn_add.Location = new System.Drawing.Point(555, 194);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_add.OnHovercolor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_add.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_add.selected = false;
            this.btn_add.Size = new System.Drawing.Size(131, 59);
            this.btn_add.TabIndex = 87;
            this.btn_add.Text = "Add";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add.Textcolor = System.Drawing.Color.White;
            this.btn_add.TextFont = new System.Drawing.Font("Century Gothic", 9.5F);
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_uplaodimage
            // 
            this.btn_uplaodimage.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_uplaodimage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_uplaodimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_uplaodimage.BorderRadius = 7;
            this.btn_uplaodimage.ButtonText = "Upload";
            this.btn_uplaodimage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_uplaodimage.DisabledColor = System.Drawing.Color.Gray;
            this.btn_uplaodimage.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_uplaodimage.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_uplaodimage.Iconimage = null;
            this.btn_uplaodimage.Iconimage_right = null;
            this.btn_uplaodimage.Iconimage_right_Selected = null;
            this.btn_uplaodimage.Iconimage_Selected = null;
            this.btn_uplaodimage.IconMarginLeft = 0;
            this.btn_uplaodimage.IconMarginRight = 0;
            this.btn_uplaodimage.IconRightVisible = false;
            this.btn_uplaodimage.IconRightZoom = 0D;
            this.btn_uplaodimage.IconVisible = false;
            this.btn_uplaodimage.IconZoom = 90D;
            this.btn_uplaodimage.IsTab = false;
            this.btn_uplaodimage.Location = new System.Drawing.Point(268, 194);
            this.btn_uplaodimage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_uplaodimage.Name = "btn_uplaodimage";
            this.btn_uplaodimage.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_uplaodimage.OnHovercolor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_uplaodimage.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_uplaodimage.selected = false;
            this.btn_uplaodimage.Size = new System.Drawing.Size(101, 43);
            this.btn_uplaodimage.TabIndex = 86;
            this.btn_uplaodimage.Text = "Upload";
            this.btn_uplaodimage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_uplaodimage.Textcolor = System.Drawing.Color.White;
            this.btn_uplaodimage.TextFont = new System.Drawing.Font("Century Gothic", 9.5F);
            this.btn_uplaodimage.Click += new System.EventHandler(this.btn_uplaodimage_Click);
            // 
            // picBox_Image
            // 
            this.picBox_Image.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBox_Image.BackgroundImage")));
            this.picBox_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBox_Image.Location = new System.Drawing.Point(132, 144);
            this.picBox_Image.Name = "picBox_Image";
            this.picBox_Image.Size = new System.Drawing.Size(126, 93);
            this.picBox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Image.TabIndex = 84;
            this.picBox_Image.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(264, 144);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(187, 21);
            this.label16.TabIndex = 85;
            this.label16.Text = "Upoad Logo (optional)";
            // 
            // textbox_publisherid
            // 
            this.textbox_publisherid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textbox_publisherid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_publisherid.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textbox_publisherid.Location = new System.Drawing.Point(132, 12);
            this.textbox_publisherid.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_publisherid.Multiline = true;
            this.textbox_publisherid.Name = "textbox_publisherid";
            this.textbox_publisherid.ReadOnly = true;
            this.textbox_publisherid.Size = new System.Drawing.Size(262, 31);
            this.textbox_publisherid.TabIndex = 0;
            // 
            // TextboxAddBk_Bookid
            // 
            this.TextboxAddBk_Bookid.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxAddBk_Bookid.BorderColorIdle = System.Drawing.Color.Silver;
            this.TextboxAddBk_Bookid.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxAddBk_Bookid.BorderThickness = 1;
            this.TextboxAddBk_Bookid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxAddBk_Bookid.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextboxAddBk_Bookid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxAddBk_Bookid.isPassword = false;
            this.TextboxAddBk_Bookid.Location = new System.Drawing.Point(130, 10);
            this.TextboxAddBk_Bookid.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxAddBk_Bookid.Name = "TextboxAddBk_Bookid";
            this.TextboxAddBk_Bookid.Size = new System.Drawing.Size(265, 34);
            this.TextboxAddBk_Bookid.TabIndex = 82;
            this.TextboxAddBk_Bookid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 81;
            this.label5.Text = "Contact";
            // 
            // textbox_phoneno
            // 
            this.textbox_phoneno.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textbox_phoneno.BorderColorIdle = System.Drawing.Color.Silver;
            this.textbox_phoneno.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textbox_phoneno.BorderThickness = 1;
            this.textbox_phoneno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_phoneno.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textbox_phoneno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textbox_phoneno.isPassword = false;
            this.textbox_phoneno.Location = new System.Drawing.Point(130, 76);
            this.textbox_phoneno.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_phoneno.Name = "textbox_phoneno";
            this.textbox_phoneno.Size = new System.Drawing.Size(265, 34);
            this.textbox_phoneno.TabIndex = 2;
            this.textbox_phoneno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(421, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 21);
            this.label2.TabIndex = 71;
            this.label2.Text = "Publisher Name";
            // 
            // textbox_publishername
            // 
            this.textbox_publishername.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textbox_publishername.BorderColorIdle = System.Drawing.Color.Silver;
            this.textbox_publishername.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textbox_publishername.BorderThickness = 1;
            this.textbox_publishername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_publishername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textbox_publishername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textbox_publishername.isPassword = false;
            this.textbox_publishername.Location = new System.Drawing.Point(555, 10);
            this.textbox_publishername.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_publishername.Name = "textbox_publishername";
            this.textbox_publishername.Size = new System.Drawing.Size(263, 34);
            this.textbox_publishername.TabIndex = 1;
            this.textbox_publishername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textbox_address
            // 
            this.textbox_address.Location = new System.Drawing.Point(555, 76);
            this.textbox_address.Multiline = true;
            this.textbox_address.Name = "textbox_address";
            this.textbox_address.Size = new System.Drawing.Size(263, 89);
            this.textbox_address.TabIndex = 3;
            this.textbox_address.WaterMark = "Default Watermark...";
            this.textbox_address.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.textbox_address.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_address.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(478, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 64;
            this.label4.Text = "Address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(29, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 21);
            this.label11.TabIndex = 57;
            this.label11.Text = "Publisher Id";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel10.Location = new System.Drawing.Point(0, 337);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(846, 68);
            this.panel10.TabIndex = 37;
            // 
            // Publisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Publisher";
            this.Size = new System.Drawing.Size(846, 692);
            this.Load += new System.EventHandler(this.Publisher_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton btn_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textbox_publisherid;
        private Bunifu.Framework.UI.BunifuMetroTextbox TextboxAddBk_Bookid;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox textbox_phoneno;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox textbox_publishername;
        private ChreneLib.Controls.TextBoxes.CTextBox textbox_address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuFlatButton btn_uplaodimage;
        private System.Windows.Forms.PictureBox picBox_Image;
        private System.Windows.Forms.Label label16;
        private Bunifu.Framework.UI.BunifuFlatButton btn_add;
        private System.Windows.Forms.Panel panel10;
    }
}
