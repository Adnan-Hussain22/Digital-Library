namespace Digital Library.Reuseables
{
    partial class Shelf
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkbox_bulkadd = new System.Windows.Forms.CheckBox();
            this.textbox_shelfamount = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuMetroTextbox2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_capacity = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.bunifuMetroTextbox1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(391, 205);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkbox_bulkadd);
            this.panel1.Controls.Add(this.textbox_shelfamount);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.bunifuMetroTextbox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textbox_capacity);
            this.panel1.Controls.Add(this.bunifuMetroTextbox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 195);
            this.panel1.TabIndex = 0;
            // 
            // checkbox_bulkadd
            // 
            this.checkbox_bulkadd.AutoSize = true;
            this.checkbox_bulkadd.Location = new System.Drawing.Point(94, 146);
            this.checkbox_bulkadd.Name = "checkbox_bulkadd";
            this.checkbox_bulkadd.Size = new System.Drawing.Size(69, 17);
            this.checkbox_bulkadd.TabIndex = 203;
            this.checkbox_bulkadd.Text = "Bulk Add";
            this.checkbox_bulkadd.UseVisualStyleBackColor = true;
            this.checkbox_bulkadd.CheckedChanged += new System.EventHandler(this.checkbox_bulkadd_CheckedChanged);
            // 
            // textbox_shelfamount
            // 
            this.textbox_shelfamount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_shelfamount.Enabled = false;
            this.textbox_shelfamount.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.textbox_shelfamount.Location = new System.Drawing.Point(96, 103);
            this.textbox_shelfamount.Name = "textbox_shelfamount";
            this.textbox_shelfamount.Size = new System.Drawing.Size(270, 27);
            this.textbox_shelfamount.TabIndex = 202;
            this.textbox_shelfamount.Text = "1";
            this.textbox_shelfamount.WaterMark = "Amount of shelfs..";
            this.textbox_shelfamount.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.textbox_shelfamount.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_shelfamount.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(294, 146);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 37);
            this.btn_add.TabIndex = 201;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 200;
            this.label2.Text = "Amount";
            // 
            // bunifuMetroTextbox2
            // 
            this.bunifuMetroTextbox2.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox2.BorderColorIdle = System.Drawing.Color.Silver;
            this.bunifuMetroTextbox2.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox2.BorderThickness = 1;
            this.bunifuMetroTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox2.isPassword = false;
            this.bunifuMetroTextbox2.Location = new System.Drawing.Point(92, 99);
            this.bunifuMetroTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox2.Name = "bunifuMetroTextbox2";
            this.bunifuMetroTextbox2.Size = new System.Drawing.Size(277, 34);
            this.bunifuMetroTextbox2.TabIndex = 198;
            this.bunifuMetroTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 197;
            this.label1.Text = "Capacity";
            // 
            // textbox_capacity
            // 
            this.textbox_capacity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_capacity.Font = new System.Drawing.Font("Segoe UI Light", 12.5F);
            this.textbox_capacity.Location = new System.Drawing.Point(94, 35);
            this.textbox_capacity.Multiline = true;
            this.textbox_capacity.Name = "textbox_capacity";
            this.textbox_capacity.ReadOnly = true;
            this.textbox_capacity.Size = new System.Drawing.Size(274, 31);
            this.textbox_capacity.TabIndex = 196;
            this.textbox_capacity.WaterMark = "";
            this.textbox_capacity.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.textbox_capacity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.textbox_capacity.WaterMarkForeColor = System.Drawing.Color.DarkGray;
            // 
            // bunifuMetroTextbox1
            // 
            this.bunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.Silver;
            this.bunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.BorderThickness = 1;
            this.bunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.isPassword = false;
            this.bunifuMetroTextbox1.Location = new System.Drawing.Point(92, 33);
            this.bunifuMetroTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox1.Name = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.Size = new System.Drawing.Size(277, 34);
            this.bunifuMetroTextbox1.TabIndex = 195;
            this.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(350, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 25);
            this.label4.TabIndex = 194;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Shelf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Shelf";
            this.Size = new System.Drawing.Size(391, 205);
            this.Load += new System.EventHandler(this.Shelf_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox2;
        private System.Windows.Forms.Label label1;
        private ChreneLib.Controls.TextBoxes.CTextBox textbox_capacity;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox1;
        private ChreneLib.Controls.TextBoxes.CTextBox textbox_shelfamount;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.CheckBox checkbox_bulkadd;
    }
}
