namespace Digital Library
{
    partial class AddSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSubject));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbleSubjectNotAvilable = new System.Windows.Forms.Label();
            this.lblSubjectIsAvilable = new System.Windows.Forms.Label();
            this.lblinstruction = new System.Windows.Forms.Label();
            this.textboxSubjectName = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ButtnAvailability = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Textboxcontainer = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BttnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BttnNew = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BttnAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BttnUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.dgv_SubjectDetails = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalSubjects = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SubjectDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 605);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(846, 17);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 17);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(846, 50);
            this.panel3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.5F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(48, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Subjects";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.lbleSubjectNotAvilable);
            this.panel4.Controls.Add(this.lblSubjectIsAvilable);
            this.panel4.Controls.Add(this.lblinstruction);
            this.panel4.Controls.Add(this.textboxSubjectName);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.ButtnAvailability);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.Textboxcontainer);
            this.panel4.Location = new System.Drawing.Point(0, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(846, 64);
            this.panel4.TabIndex = 6;
            // 
            // lbleSubjectNotAvilable
            // 
            this.lbleSubjectNotAvilable.AutoSize = true;
            this.lbleSubjectNotAvilable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lbleSubjectNotAvilable.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbleSubjectNotAvilable.Location = new System.Drawing.Point(651, 44);
            this.lbleSubjectNotAvilable.Name = "lbleSubjectNotAvilable";
            this.lbleSubjectNotAvilable.Size = new System.Drawing.Size(79, 15);
            this.lbleSubjectNotAvilable.TabIndex = 22;
            this.lbleSubjectNotAvilable.Text = "Not Available";
            this.lbleSubjectNotAvilable.Visible = false;
            // 
            // lblSubjectIsAvilable
            // 
            this.lblSubjectIsAvilable.AutoSize = true;
            this.lblSubjectIsAvilable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblSubjectIsAvilable.ForeColor = System.Drawing.Color.Red;
            this.lblSubjectIsAvilable.Location = new System.Drawing.Point(620, 44);
            this.lblSubjectIsAvilable.Name = "lblSubjectIsAvilable";
            this.lblSubjectIsAvilable.Size = new System.Drawing.Size(151, 15);
            this.lblSubjectIsAvilable.TabIndex = 21;
            this.lblSubjectIsAvilable.Text = "Subject is already available";
            this.lblSubjectIsAvilable.Visible = false;
            // 
            // lblinstruction
            // 
            this.lblinstruction.AutoSize = true;
            this.lblinstruction.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Italic);
            this.lblinstruction.Location = new System.Drawing.Point(19, 42);
            this.lblinstruction.Name = "lblinstruction";
            this.lblinstruction.Size = new System.Drawing.Size(245, 15);
            this.lblinstruction.TabIndex = 20;
            this.lblinstruction.Text = "Add subjects or double click on the record to edit";
            // 
            // textboxSubjectName
            // 
            this.textboxSubjectName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textboxSubjectName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textboxSubjectName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textboxSubjectName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxSubjectName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textboxSubjectName.Location = new System.Drawing.Point(163, 11);
            this.textboxSubjectName.Name = "textboxSubjectName";
            this.textboxSubjectName.Size = new System.Drawing.Size(342, 22);
            this.textboxSubjectName.TabIndex = 18;
            this.textboxSubjectName.WaterMark = "Name of subject";
            this.textboxSubjectName.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.textboxSubjectName.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 9.5F);
            this.textboxSubjectName.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(619, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 21);
            this.label13.TabIndex = 17;
            this.label13.Text = "Check Availability";
            this.label13.Visible = false;
            // 
            // ButtnAvailability
            // 
            this.ButtnAvailability.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(190)))), ((int)(((byte)(220)))));
            this.ButtnAvailability.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(190)))), ((int)(((byte)(220)))));
            this.ButtnAvailability.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtnAvailability.BorderRadius = 5;
            this.ButtnAvailability.ButtonText = "";
            this.ButtnAvailability.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtnAvailability.DisabledColor = System.Drawing.Color.Gray;
            this.ButtnAvailability.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtnAvailability.Iconimage = ((System.Drawing.Image)(resources.GetObject("ButtnAvailability.Iconimage")));
            this.ButtnAvailability.Iconimage_right = null;
            this.ButtnAvailability.Iconimage_right_Selected = null;
            this.ButtnAvailability.Iconimage_Selected = null;
            this.ButtnAvailability.IconMarginLeft = 0;
            this.ButtnAvailability.IconMarginRight = 0;
            this.ButtnAvailability.IconRightVisible = false;
            this.ButtnAvailability.IconRightZoom = 0D;
            this.ButtnAvailability.IconVisible = true;
            this.ButtnAvailability.IconZoom = 50D;
            this.ButtnAvailability.IsTab = false;
            this.ButtnAvailability.Location = new System.Drawing.Point(573, 4);
            this.ButtnAvailability.Name = "ButtnAvailability";
            this.ButtnAvailability.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(190)))), ((int)(((byte)(220)))));
            this.ButtnAvailability.OnHovercolor = System.Drawing.Color.SkyBlue;
            this.ButtnAvailability.OnHoverTextColor = System.Drawing.Color.White;
            this.ButtnAvailability.selected = false;
            this.ButtnAvailability.Size = new System.Drawing.Size(41, 39);
            this.ButtnAvailability.TabIndex = 16;
            this.ButtnAvailability.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtnAvailability.Textcolor = System.Drawing.Color.White;
            this.ButtnAvailability.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtnAvailability.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Subject Name";
            // 
            // Textboxcontainer
            // 
            this.Textboxcontainer.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Textboxcontainer.BorderColorIdle = System.Drawing.Color.Silver;
            this.Textboxcontainer.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Textboxcontainer.BorderThickness = 1;
            this.Textboxcontainer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textboxcontainer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textboxcontainer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Textboxcontainer.isPassword = false;
            this.Textboxcontainer.Location = new System.Drawing.Point(160, 6);
            this.Textboxcontainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Textboxcontainer.Name = "Textboxcontainer";
            this.Textboxcontainer.Size = new System.Drawing.Size(346, 31);
            this.Textboxcontainer.TabIndex = 4;
            this.Textboxcontainer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Controls.Add(this.lblTotalSubjects);
            this.panel5.Controls.Add(this.flowLayoutPanel3);
            this.panel5.Controls.Add(this.flowLayoutPanel2);
            this.panel5.Controls.Add(this.flowLayoutPanel1);
            this.panel5.Controls.Add(this.BttnDelete);
            this.panel5.Controls.Add(this.BttnNew);
            this.panel5.Controls.Add(this.BttnAdd);
            this.panel5.Controls.Add(this.BttnUpdate);
            this.panel5.Location = new System.Drawing.Point(0, 140);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(846, 50);
            this.panel5.TabIndex = 7;
            // 
            // BttnDelete
            // 
            this.BttnDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BttnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BttnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BttnDelete.BorderRadius = 7;
            this.BttnDelete.ButtonText = "Delete";
            this.BttnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BttnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.BttnDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.BttnDelete.Iconimage = null;
            this.BttnDelete.Iconimage_right = null;
            this.BttnDelete.Iconimage_right_Selected = null;
            this.BttnDelete.Iconimage_Selected = null;
            this.BttnDelete.IconMarginLeft = 0;
            this.BttnDelete.IconMarginRight = 0;
            this.BttnDelete.IconRightVisible = true;
            this.BttnDelete.IconRightZoom = 0D;
            this.BttnDelete.IconVisible = true;
            this.BttnDelete.IconZoom = 90D;
            this.BttnDelete.IsTab = false;
            this.BttnDelete.Location = new System.Drawing.Point(182, 6);
            this.BttnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BttnDelete.Name = "BttnDelete";
            this.BttnDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BttnDelete.OnHovercolor = System.Drawing.SystemColors.ActiveCaption;
            this.BttnDelete.OnHoverTextColor = System.Drawing.Color.Black;
            this.BttnDelete.selected = false;
            this.BttnDelete.Size = new System.Drawing.Size(73, 38);
            this.BttnDelete.TabIndex = 14;
            this.BttnDelete.Text = "Delete";
            this.BttnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BttnDelete.Textcolor = System.Drawing.Color.White;
            this.BttnDelete.TextFont = new System.Drawing.Font("Century Gothic", 9.5F);
            this.BttnDelete.Click += new System.EventHandler(this.BttnDelete_Click);
            // 
            // BttnNew
            // 
            this.BttnNew.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BttnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BttnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BttnNew.BorderRadius = 7;
            this.BttnNew.ButtonText = "New";
            this.BttnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BttnNew.DisabledColor = System.Drawing.Color.Gray;
            this.BttnNew.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnNew.Iconcolor = System.Drawing.Color.Transparent;
            this.BttnNew.Iconimage = null;
            this.BttnNew.Iconimage_right = null;
            this.BttnNew.Iconimage_right_Selected = null;
            this.BttnNew.Iconimage_Selected = null;
            this.BttnNew.IconMarginLeft = 0;
            this.BttnNew.IconMarginRight = 0;
            this.BttnNew.IconRightVisible = true;
            this.BttnNew.IconRightZoom = 0D;
            this.BttnNew.IconVisible = true;
            this.BttnNew.IconZoom = 90D;
            this.BttnNew.IsTab = false;
            this.BttnNew.Location = new System.Drawing.Point(267, 6);
            this.BttnNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BttnNew.Name = "BttnNew";
            this.BttnNew.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BttnNew.OnHovercolor = System.Drawing.SystemColors.ActiveCaption;
            this.BttnNew.OnHoverTextColor = System.Drawing.Color.Black;
            this.BttnNew.selected = false;
            this.BttnNew.Size = new System.Drawing.Size(86, 38);
            this.BttnNew.TabIndex = 13;
            this.BttnNew.Text = "New";
            this.BttnNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BttnNew.Textcolor = System.Drawing.Color.White;
            this.BttnNew.TextFont = new System.Drawing.Font("Century Gothic", 9.5F);
            this.BttnNew.Click += new System.EventHandler(this.BttnNew_Click);
            // 
            // BttnAdd
            // 
            this.BttnAdd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BttnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BttnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BttnAdd.BorderRadius = 7;
            this.BttnAdd.ButtonText = "Add";
            this.BttnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BttnAdd.DisabledColor = System.Drawing.Color.Gray;
            this.BttnAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.BttnAdd.Iconimage = null;
            this.BttnAdd.Iconimage_right = null;
            this.BttnAdd.Iconimage_right_Selected = null;
            this.BttnAdd.Iconimage_Selected = null;
            this.BttnAdd.IconMarginLeft = 0;
            this.BttnAdd.IconMarginRight = 0;
            this.BttnAdd.IconRightVisible = true;
            this.BttnAdd.IconRightZoom = 0D;
            this.BttnAdd.IconVisible = true;
            this.BttnAdd.IconZoom = 90D;
            this.BttnAdd.IsTab = false;
            this.BttnAdd.Location = new System.Drawing.Point(10, 6);
            this.BttnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BttnAdd.Name = "BttnAdd";
            this.BttnAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BttnAdd.OnHovercolor = System.Drawing.SystemColors.ActiveCaption;
            this.BttnAdd.OnHoverTextColor = System.Drawing.Color.Black;
            this.BttnAdd.selected = false;
            this.BttnAdd.Size = new System.Drawing.Size(74, 38);
            this.BttnAdd.TabIndex = 12;
            this.BttnAdd.Text = "Add";
            this.BttnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BttnAdd.Textcolor = System.Drawing.Color.White;
            this.BttnAdd.TextFont = new System.Drawing.Font("Century Gothic", 9.5F);
            this.BttnAdd.Click += new System.EventHandler(this.BttnAdd_Click);
            // 
            // BttnUpdate
            // 
            this.BttnUpdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BttnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BttnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BttnUpdate.BorderRadius = 7;
            this.BttnUpdate.ButtonText = "Update";
            this.BttnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BttnUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.BttnUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.BttnUpdate.Iconimage = null;
            this.BttnUpdate.Iconimage_right = null;
            this.BttnUpdate.Iconimage_right_Selected = null;
            this.BttnUpdate.Iconimage_Selected = null;
            this.BttnUpdate.IconMarginLeft = 0;
            this.BttnUpdate.IconMarginRight = 0;
            this.BttnUpdate.IconRightVisible = true;
            this.BttnUpdate.IconRightZoom = 0D;
            this.BttnUpdate.IconVisible = true;
            this.BttnUpdate.IconZoom = 90D;
            this.BttnUpdate.IsTab = false;
            this.BttnUpdate.Location = new System.Drawing.Point(96, 6);
            this.BttnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BttnUpdate.Name = "BttnUpdate";
            this.BttnUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BttnUpdate.OnHovercolor = System.Drawing.SystemColors.ActiveCaption;
            this.BttnUpdate.OnHoverTextColor = System.Drawing.Color.Black;
            this.BttnUpdate.selected = false;
            this.BttnUpdate.Size = new System.Drawing.Size(74, 38);
            this.BttnUpdate.TabIndex = 11;
            this.BttnUpdate.Text = "Update";
            this.BttnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BttnUpdate.Textcolor = System.Drawing.Color.White;
            this.BttnUpdate.TextFont = new System.Drawing.Font("Century Gothic", 9.5F);
            this.BttnUpdate.Click += new System.EventHandler(this.BttnUpdate_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(88, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1, 48);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(175, 1);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1, 48);
            this.flowLayoutPanel2.TabIndex = 16;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(260, 1);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1, 48);
            this.flowLayoutPanel3.TabIndex = 17;
            // 
            // dgv_SubjectDetails
            // 
            this.dgv_SubjectDetails.AllowUserToAddRows = false;
            this.dgv_SubjectDetails.AllowUserToDeleteRows = false;
            this.dgv_SubjectDetails.AllowUserToResizeColumns = false;
            this.dgv_SubjectDetails.AllowUserToResizeRows = false;
            this.dgv_SubjectDetails.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_SubjectDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_SubjectDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SubjectDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_SubjectDetails.ColumnHeadersHeight = 30;
            this.dgv_SubjectDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnSubject});
            this.dgv_SubjectDetails.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_SubjectDetails.Location = new System.Drawing.Point(0, 192);
            this.dgv_SubjectDetails.Name = "dgv_SubjectDetails";
            this.dgv_SubjectDetails.ReadOnly = true;
            this.dgv_SubjectDetails.RowHeadersVisible = false;
            this.dgv_SubjectDetails.Size = new System.Drawing.Size(846, 410);
            this.dgv_SubjectDetails.TabIndex = 8;
            this.dgv_SubjectDetails.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SubjectDetails_CellDoubleClick);
            this.dgv_SubjectDetails.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SubjectDetails_CellEnter);
            this.dgv_SubjectDetails.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_SubjectDetails_KeyDown);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "ID";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            // 
            // ColumnSubject
            // 
            this.ColumnSubject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnSubject.HeaderText = "Subject";
            this.ColumnSubject.Name = "ColumnSubject";
            this.ColumnSubject.ReadOnly = true;
            // 
            // lblTotalSubjects
            // 
            this.lblTotalSubjects.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalSubjects.AutoSize = true;
            this.lblTotalSubjects.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTotalSubjects.Location = new System.Drawing.Point(606, 13);
            this.lblTotalSubjects.Name = "lblTotalSubjects";
            this.lblTotalSubjects.Size = new System.Drawing.Size(124, 21);
            this.lblTotalSubjects.TabIndex = 22;
            this.lblTotalSubjects.Text = "Total Subjects : 0";
            // 
            // AddSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_SubjectDetails);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddSubject";
            this.Size = new System.Drawing.Size(846, 622);
            this.Load += new System.EventHandler(this.AddSubject_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SubjectDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbleSubjectNotAvilable;
        private System.Windows.Forms.Label lblSubjectIsAvilable;
        private System.Windows.Forms.Label lblinstruction;
        private ChreneLib.Controls.TextBoxes.CTextBox textboxSubjectName;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuFlatButton ButtnAvailability;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox Textboxcontainer;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuFlatButton BttnDelete;
        private Bunifu.Framework.UI.BunifuFlatButton BttnNew;
        private Bunifu.Framework.UI.BunifuFlatButton BttnAdd;
        private Bunifu.Framework.UI.BunifuFlatButton BttnUpdate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dgv_SubjectDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubject;
        private System.Windows.Forms.Label lblTotalSubjects;
    }
}
