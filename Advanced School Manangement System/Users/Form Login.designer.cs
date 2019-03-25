namespace Login_Win
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextboxUserid = new Bunifu.Framework.UI.BunifuTextbox();
            this.TextboxPassword = new Bunifu.Framework.UI.BunifuTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonSignin = new Bunifu.Framework.UI.BunifuTileButton();
            this.ButtonExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lbl_userId = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 546);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 520);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Copyrights 2017. All Rights Reserved";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.label3.Location = new System.Drawing.Point(2, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 66);
            this.label3.TabIndex = 1;
            this.label3.Text = "The Modern Need For \r\nEvery Library!";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextboxUserid
            // 
            this.TextboxUserid.BackColor = System.Drawing.Color.Black;
            this.TextboxUserid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TextboxUserid.BackgroundImage")));
            this.TextboxUserid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TextboxUserid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextboxUserid.Icon = ((System.Drawing.Image)(resources.GetObject("TextboxUserid.Icon")));
            this.TextboxUserid.Location = new System.Drawing.Point(327, 185);
            this.TextboxUserid.Name = "TextboxUserid";
            this.TextboxUserid.Size = new System.Drawing.Size(310, 42);
            this.TextboxUserid.TabIndex = 0;
            this.TextboxUserid.text = "Library Id";
            this.TextboxUserid.Enter += new System.EventHandler(this.TextboxEmail_Enter);
            this.TextboxUserid.Leave += new System.EventHandler(this.TextboxEmail_Leave);
            // 
            // TextboxPassword
            // 
            this.TextboxPassword.BackColor = System.Drawing.Color.Black;
            this.TextboxPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TextboxPassword.BackgroundImage")));
            this.TextboxPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TextboxPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextboxPassword.Icon = ((System.Drawing.Image)(resources.GetObject("TextboxPassword.Icon")));
            this.TextboxPassword.Location = new System.Drawing.Point(327, 292);
            this.TextboxPassword.Name = "TextboxPassword";
            this.TextboxPassword.Size = new System.Drawing.Size(310, 42);
            this.TextboxPassword.TabIndex = 3;
            this.TextboxPassword.text = "Password";
            this.TextboxPassword.Enter += new System.EventHandler(this.TextboxPassword_Enter);
            this.TextboxPassword.Leave += new System.EventHandler(this.TextboxPassword_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(323, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sign in into your account first!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(306, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Let\'s begin the journey";
            // 
            // ButtonSignin
            // 
            this.ButtonSignin.BackColor = System.Drawing.Color.White;
            this.ButtonSignin.color = System.Drawing.Color.White;
            this.ButtonSignin.colorActive = System.Drawing.Color.White;
            this.ButtonSignin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSignin.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSignin.ForeColor = System.Drawing.Color.Black;
            this.ButtonSignin.Image = null;
            this.ButtonSignin.ImagePosition = 21;
            this.ButtonSignin.ImageZoom = 50;
            this.ButtonSignin.LabelPosition = 28;
            this.ButtonSignin.LabelText = "Sign in";
            this.ButtonSignin.Location = new System.Drawing.Point(314, 407);
            this.ButtonSignin.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ButtonSignin.Name = "ButtonSignin";
            this.ButtonSignin.Size = new System.Drawing.Size(337, 31);
            this.ButtonSignin.TabIndex = 6;
            this.ButtonSignin.Click += new System.EventHandler(this.ButtonSignin_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.Color.Transparent;
            this.ButtonExit.ErrorImage = null;
            this.ButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("ButtonExit.Image")));
            this.ButtonExit.ImageActive = null;
            this.ButtonExit.Location = new System.Drawing.Point(636, 12);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(24, 25);
            this.ButtonExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonExit.TabIndex = 7;
            this.ButtonExit.TabStop = false;
            this.ButtonExit.Zoom = 10;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 5;
            this.bunifuElipse3.TargetControl = this;
            // 
            // lbl_userId
            // 
            this.lbl_userId.AutoSize = true;
            this.lbl_userId.BackColor = System.Drawing.Color.Transparent;
            this.lbl_userId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userId.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_userId.Location = new System.Drawing.Point(336, 164);
            this.lbl_userId.Name = "lbl_userId";
            this.lbl_userId.Size = new System.Drawing.Size(63, 17);
            this.lbl_userId.TabIndex = 9;
            this.lbl_userId.Text = "Library Id";
            this.lbl_userId.Visible = false;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_password.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_password.Location = new System.Drawing.Point(336, 272);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(64, 17);
            this.lbl_password.TabIndex = 11;
            this.lbl_password.Text = "Password";
            this.lbl_password.Visible = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(672, 546);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_userId);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonSignin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextboxPassword);
            this.Controls.Add(this.TextboxUserid);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuTextbox TextboxUserid;
        private Bunifu.Framework.UI.BunifuTextbox TextboxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuTileButton ButtonSignin;
        private Bunifu.Framework.UI.BunifuImageButton ButtonExit;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_userId;
    }
}

