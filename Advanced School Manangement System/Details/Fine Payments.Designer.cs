namespace Advanced_School_Manangement_System.Details
{
    partial class Fine_Payments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fine_Payments));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_printToPDF = new Bunifu.Framework.UI.BunifuFlatButton();
            this.radiobtn_all = new System.Windows.Forms.RadioButton();
            this.radiobtn_pending = new System.Windows.Forms.RadioButton();
            this.lblPaginationTotal = new System.Windows.Forms.Label();
            this.lbl_totalrecords = new System.Windows.Forms.Label();
            this.btn_view = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.date_to = new MetroFramework.Controls.MetroDateTime();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.date_from = new MetroFramework.Controls.MetroDateTime();
            this.link_all = new System.Windows.Forms.LinkLabel();
            this.link_6months = new System.Windows.Forms.LinkLabel();
            this.link_30days = new System.Windows.Forms.LinkLabel();
            this.link_7days = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_close = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvFinePaymentDetails = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFineDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPaidAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDueAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRecordsPerPage = new System.Windows.Forms.Label();
            this.radioBtn50 = new System.Windows.Forms.RadioButton();
            this.radioBtn20 = new System.Windows.Forms.RadioButton();
            this.radioBtn10 = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.panel_pagination = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinePaymentDetails)).BeginInit();
            this.panel_pagination.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.btn_printToPDF);
            this.panel3.Controls.Add(this.radiobtn_all);
            this.panel3.Controls.Add(this.radiobtn_pending);
            this.panel3.Controls.Add(this.lblPaginationTotal);
            this.panel3.Controls.Add(this.lbl_totalrecords);
            this.panel3.Controls.Add(this.btn_view);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.date_to);
            this.panel3.Controls.Add(this.bunifuSeparator1);
            this.panel3.Controls.Add(this.date_from);
            this.panel3.Controls.Add(this.link_all);
            this.panel3.Controls.Add(this.link_6months);
            this.panel3.Controls.Add(this.link_30days);
            this.panel3.Controls.Add(this.link_7days);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btn_close);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(846, 162);
            this.panel3.TabIndex = 30;
            // 
            // btn_printToPDF
            // 
            this.btn_printToPDF.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.btn_printToPDF.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_printToPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_printToPDF.BorderRadius = 3;
            this.btn_printToPDF.ButtonText = "Export PDF";
            this.btn_printToPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_printToPDF.DisabledColor = System.Drawing.Color.Gray;
            this.btn_printToPDF.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_printToPDF.Iconimage = null;
            this.btn_printToPDF.Iconimage_right = null;
            this.btn_printToPDF.Iconimage_right_Selected = null;
            this.btn_printToPDF.Iconimage_Selected = null;
            this.btn_printToPDF.IconMarginLeft = 0;
            this.btn_printToPDF.IconMarginRight = 0;
            this.btn_printToPDF.IconRightVisible = false;
            this.btn_printToPDF.IconRightZoom = 0D;
            this.btn_printToPDF.IconVisible = false;
            this.btn_printToPDF.IconZoom = 90D;
            this.btn_printToPDF.IsTab = false;
            this.btn_printToPDF.Location = new System.Drawing.Point(726, 9);
            this.btn_printToPDF.Name = "btn_printToPDF";
            this.btn_printToPDF.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.btn_printToPDF.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(197)))), ((int)(((byte)(245)))));
            this.btn_printToPDF.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btn_printToPDF.selected = false;
            this.btn_printToPDF.Size = new System.Drawing.Size(102, 46);
            this.btn_printToPDF.TabIndex = 36;
            this.btn_printToPDF.Text = "Export PDF";
            this.btn_printToPDF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_printToPDF.Textcolor = System.Drawing.Color.White;
            this.btn_printToPDF.TextFont = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_printToPDF.Click += new System.EventHandler(this.btn_printToPDF_Click);
            // 
            // radiobtn_all
            // 
            this.radiobtn_all.AutoSize = true;
            this.radiobtn_all.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.radiobtn_all.Location = new System.Drawing.Point(442, 132);
            this.radiobtn_all.Name = "radiobtn_all";
            this.radiobtn_all.Size = new System.Drawing.Size(95, 19);
            this.radiobtn_all.TabIndex = 35;
            this.radiobtn_all.TabStop = true;
            this.radiobtn_all.Text = "Non Pending";
            this.radiobtn_all.UseVisualStyleBackColor = true;
            this.radiobtn_all.CheckedChanged += new System.EventHandler(this.radiobtn_nonpending_CheckedChanged);
            // 
            // radiobtn_pending
            // 
            this.radiobtn_pending.AutoSize = true;
            this.radiobtn_pending.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.radiobtn_pending.Location = new System.Drawing.Point(367, 132);
            this.radiobtn_pending.Name = "radiobtn_pending";
            this.radiobtn_pending.Size = new System.Drawing.Size(69, 19);
            this.radiobtn_pending.TabIndex = 34;
            this.radiobtn_pending.TabStop = true;
            this.radiobtn_pending.Text = "Pending";
            this.radiobtn_pending.UseVisualStyleBackColor = true;
            this.radiobtn_pending.CheckedChanged += new System.EventHandler(this.radiobtn_pending_CheckedChanged);
            // 
            // lblPaginationTotal
            // 
            this.lblPaginationTotal.AutoSize = true;
            this.lblPaginationTotal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPaginationTotal.Location = new System.Drawing.Point(632, 136);
            this.lblPaginationTotal.Name = "lblPaginationTotal";
            this.lblPaginationTotal.Size = new System.Drawing.Size(161, 21);
            this.lblPaginationTotal.TabIndex = 33;
            this.lblPaginationTotal.Text = "1-20 of 0 items found";
            this.lblPaginationTotal.Visible = false;
            // 
            // lbl_totalrecords
            // 
            this.lbl_totalrecords.AutoSize = true;
            this.lbl_totalrecords.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_totalrecords.Location = new System.Drawing.Point(363, 10);
            this.lbl_totalrecords.Name = "lbl_totalrecords";
            this.lbl_totalrecords.Size = new System.Drawing.Size(122, 21);
            this.lbl_totalrecords.TabIndex = 32;
            this.lbl_totalrecords.Text = "Total Records : 0";
            this.lbl_totalrecords.Visible = false;
            // 
            // btn_view
            // 
            this.btn_view.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.btn_view.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_view.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_view.BorderRadius = 3;
            this.btn_view.ButtonText = "View";
            this.btn_view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_view.DisabledColor = System.Drawing.Color.Gray;
            this.btn_view.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btn_view.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_view.Iconimage = null;
            this.btn_view.Iconimage_right = null;
            this.btn_view.Iconimage_right_Selected = null;
            this.btn_view.Iconimage_Selected = null;
            this.btn_view.IconMarginLeft = 0;
            this.btn_view.IconMarginRight = 0;
            this.btn_view.IconRightVisible = false;
            this.btn_view.IconRightZoom = 0D;
            this.btn_view.IconVisible = false;
            this.btn_view.IconZoom = 90D;
            this.btn_view.IsTab = false;
            this.btn_view.Location = new System.Drawing.Point(748, 87);
            this.btn_view.Name = "btn_view";
            this.btn_view.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.btn_view.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(197)))), ((int)(((byte)(245)))));
            this.btn_view.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btn_view.selected = false;
            this.btn_view.Size = new System.Drawing.Size(80, 38);
            this.btn_view.TabIndex = 28;
            this.btn_view.Text = "View";
            this.btn_view.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_view.Textcolor = System.Drawing.Color.White;
            this.btn_view.TextFont = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label3.Location = new System.Drawing.Point(536, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "To";
            // 
            // date_to
            // 
            this.date_to.Location = new System.Drawing.Point(566, 92);
            this.date_to.MinimumSize = new System.Drawing.Size(0, 29);
            this.date_to.Name = "date_to";
            this.date_to.Size = new System.Drawing.Size(164, 29);
            this.date_to.TabIndex = 26;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(353, 80);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(2, 77);
            this.bunifuSeparator1.TabIndex = 25;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // date_from
            // 
            this.date_from.Location = new System.Drawing.Point(367, 92);
            this.date_from.MinimumSize = new System.Drawing.Size(0, 29);
            this.date_from.Name = "date_from";
            this.date_from.Size = new System.Drawing.Size(164, 29);
            this.date_from.TabIndex = 24;
            // 
            // link_all
            // 
            this.link_all.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.link_all.AutoSize = true;
            this.link_all.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.link_all.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.link_all.LinkColor = System.Drawing.Color.Gray;
            this.link_all.Location = new System.Drawing.Point(307, 131);
            this.link_all.Name = "link_all";
            this.link_all.Size = new System.Drawing.Size(31, 20);
            this.link_all.TabIndex = 23;
            this.link_all.TabStop = true;
            this.link_all.Text = "All ";
            this.link_all.VisitedLinkColor = System.Drawing.Color.MediumPurple;
            this.link_all.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_all_LinkClicked);
            // 
            // link_6months
            // 
            this.link_6months.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.link_6months.AutoSize = true;
            this.link_6months.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.link_6months.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.link_6months.LinkColor = System.Drawing.Color.Gray;
            this.link_6months.Location = new System.Drawing.Point(199, 131);
            this.link_6months.Name = "link_6months";
            this.link_6months.Size = new System.Drawing.Size(100, 20);
            this.link_6months.TabIndex = 22;
            this.link_6months.TabStop = true;
            this.link_6months.Text = "Last 6 months";
            this.link_6months.VisitedLinkColor = System.Drawing.Color.MediumPurple;
            this.link_6months.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_6months_LinkClicked);
            // 
            // link_30days
            // 
            this.link_30days.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.link_30days.AutoSize = true;
            this.link_30days.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.link_30days.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.link_30days.LinkColor = System.Drawing.Color.Gray;
            this.link_30days.Location = new System.Drawing.Point(102, 131);
            this.link_30days.Name = "link_30days";
            this.link_30days.Size = new System.Drawing.Size(89, 20);
            this.link_30days.TabIndex = 21;
            this.link_30days.TabStop = true;
            this.link_30days.Text = "Last 30 days";
            this.link_30days.VisitedLinkColor = System.Drawing.Color.MediumPurple;
            this.link_30days.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_30days_LinkClicked);
            // 
            // link_7days
            // 
            this.link_7days.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.link_7days.AutoSize = true;
            this.link_7days.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.link_7days.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.link_7days.LinkColor = System.Drawing.Color.Gray;
            this.link_7days.Location = new System.Drawing.Point(13, 131);
            this.link_7days.Name = "link_7days";
            this.link_7days.Size = new System.Drawing.Size(81, 20);
            this.link_7days.TabIndex = 20;
            this.link_7days.TabStop = true;
            this.link_7days.Text = "Last 7 days";
            this.link_7days.VisitedLinkColor = System.Drawing.Color.MediumPurple;
            this.link_7days.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_7days_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(5, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Search Between Paticular Range";
            // 
            // btn_close
            // 
            this.btn_close.Activecolor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_close.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_close.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_close.BackgroundImage")));
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_close.BorderRadius = 5;
            this.btn_close.ButtonText = "";
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.DisabledColor = System.Drawing.Color.Gray;
            this.btn_close.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_close.Iconimage = null;
            this.btn_close.Iconimage_right = null;
            this.btn_close.Iconimage_right_Selected = null;
            this.btn_close.Iconimage_Selected = null;
            this.btn_close.IconMarginLeft = 0;
            this.btn_close.IconMarginRight = 0;
            this.btn_close.IconRightVisible = true;
            this.btn_close.IconRightZoom = 0D;
            this.btn_close.IconVisible = true;
            this.btn_close.IconZoom = 90D;
            this.btn_close.IsTab = false;
            this.btn_close.Location = new System.Drawing.Point(3, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Normalcolor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_close.OnHovercolor = System.Drawing.SystemColors.Control;
            this.btn_close.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_close.selected = false;
            this.btn_close.Size = new System.Drawing.Size(49, 38);
            this.btn_close.TabIndex = 18;
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_close.Textcolor = System.Drawing.Color.White;
            this.btn_close.TextFont = new System.Drawing.Font("Century Gothic", 9.5F);
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(51, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fine Payment Details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 17);
            this.panel1.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 675);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(846, 17);
            this.panel2.TabIndex = 31;
            // 
            // dgvFinePaymentDetails
            // 
            this.dgvFinePaymentDetails.AllowUserToAddRows = false;
            this.dgvFinePaymentDetails.AllowUserToDeleteRows = false;
            this.dgvFinePaymentDetails.AllowUserToResizeColumns = false;
            this.dgvFinePaymentDetails.AllowUserToResizeRows = false;
            this.dgvFinePaymentDetails.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvFinePaymentDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFinePaymentDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvFinePaymentDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFinePaymentDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFinePaymentDetails.ColumnHeadersHeight = 30;
            this.dgvFinePaymentDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnMember,
            this.ColumnFineDate,
            this.ColumnPaidAmount,
            this.ColumnDueAmount,
            this.ColumnStatus});
            this.dgvFinePaymentDetails.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvFinePaymentDetails.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvFinePaymentDetails.Location = new System.Drawing.Point(0, 183);
            this.dgvFinePaymentDetails.Name = "dgvFinePaymentDetails";
            this.dgvFinePaymentDetails.ReadOnly = true;
            this.dgvFinePaymentDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFinePaymentDetails.RowHeadersVisible = false;
            this.dgvFinePaymentDetails.RowTemplate.Height = 60;
            this.dgvFinePaymentDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFinePaymentDetails.Size = new System.Drawing.Size(846, 454);
            this.dgvFinePaymentDetails.StandardTab = true;
            this.dgvFinePaymentDetails.TabIndex = 32;
            // 
            // ColumnId
            // 
            this.ColumnId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            // 
            // ColumnMember
            // 
            this.ColumnMember.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnMember.FillWeight = 150F;
            this.ColumnMember.HeaderText = "Member";
            this.ColumnMember.MinimumWidth = 150;
            this.ColumnMember.Name = "ColumnMember";
            this.ColumnMember.ReadOnly = true;
            // 
            // ColumnFineDate
            // 
            this.ColumnFineDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnFineDate.FillWeight = 110F;
            this.ColumnFineDate.HeaderText = "Fine Date";
            this.ColumnFineDate.MinimumWidth = 100;
            this.ColumnFineDate.Name = "ColumnFineDate";
            this.ColumnFineDate.ReadOnly = true;
            // 
            // ColumnPaidAmount
            // 
            this.ColumnPaidAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPaidAmount.HeaderText = "Paid Amount";
            this.ColumnPaidAmount.MinimumWidth = 100;
            this.ColumnPaidAmount.Name = "ColumnPaidAmount";
            this.ColumnPaidAmount.ReadOnly = true;
            // 
            // ColumnDueAmount
            // 
            this.ColumnDueAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDueAmount.HeaderText = "Due Amount";
            this.ColumnDueAmount.MinimumWidth = 100;
            this.ColumnDueAmount.Name = "ColumnDueAmount";
            this.ColumnDueAmount.ReadOnly = true;
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnStatus.HeaderText = "Status";
            this.ColumnStatus.Name = "ColumnStatus";
            this.ColumnStatus.ReadOnly = true;
            // 
            // lblRecordsPerPage
            // 
            this.lblRecordsPerPage.AutoSize = true;
            this.lblRecordsPerPage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRecordsPerPage.Location = new System.Drawing.Point(590, 8);
            this.lblRecordsPerPage.Name = "lblRecordsPerPage";
            this.lblRecordsPerPage.Size = new System.Drawing.Size(110, 19);
            this.lblRecordsPerPage.TabIndex = 40;
            this.lblRecordsPerPage.Text = "Items per page";
            // 
            // radioBtn50
            // 
            this.radioBtn50.AutoSize = true;
            this.radioBtn50.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn50.Location = new System.Drawing.Point(800, 8);
            this.radioBtn50.Name = "radioBtn50";
            this.radioBtn50.Size = new System.Drawing.Size(40, 21);
            this.radioBtn50.TabIndex = 39;
            this.radioBtn50.TabStop = true;
            this.radioBtn50.Text = "50";
            this.radioBtn50.UseVisualStyleBackColor = true;
            this.radioBtn50.CheckedChanged += new System.EventHandler(this.radioBtn50_CheckedChanged);
            // 
            // radioBtn20
            // 
            this.radioBtn20.AutoSize = true;
            this.radioBtn20.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn20.Location = new System.Drawing.Point(753, 8);
            this.radioBtn20.Name = "radioBtn20";
            this.radioBtn20.Size = new System.Drawing.Size(40, 21);
            this.radioBtn20.TabIndex = 38;
            this.radioBtn20.TabStop = true;
            this.radioBtn20.Text = "20";
            this.radioBtn20.UseVisualStyleBackColor = true;
            this.radioBtn20.CheckedChanged += new System.EventHandler(this.radioBtn20_CheckedChanged);
            // 
            // radioBtn10
            // 
            this.radioBtn10.AutoSize = true;
            this.radioBtn10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn10.Location = new System.Drawing.Point(705, 8);
            this.radioBtn10.Name = "radioBtn10";
            this.radioBtn10.Size = new System.Drawing.Size(40, 21);
            this.radioBtn10.TabIndex = 37;
            this.radioBtn10.TabStop = true;
            this.radioBtn10.Text = "10";
            this.radioBtn10.UseVisualStyleBackColor = true;
            this.radioBtn10.CheckedChanged += new System.EventHandler(this.radioBtn10_CheckedChanged);
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBack.Location = new System.Drawing.Point(97, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 30);
            this.btnBack.TabIndex = 36;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNext.Location = new System.Drawing.Point(2, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 30);
            this.btnNext.TabIndex = 35;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panel_pagination
            // 
            this.panel_pagination.Controls.Add(this.radioBtn50);
            this.panel_pagination.Controls.Add(this.lblRecordsPerPage);
            this.panel_pagination.Controls.Add(this.btnNext);
            this.panel_pagination.Controls.Add(this.btnBack);
            this.panel_pagination.Controls.Add(this.radioBtn20);
            this.panel_pagination.Controls.Add(this.radioBtn10);
            this.panel_pagination.Location = new System.Drawing.Point(0, 639);
            this.panel_pagination.Name = "panel_pagination";
            this.panel_pagination.Size = new System.Drawing.Size(846, 35);
            this.panel_pagination.TabIndex = 41;
            // 
            // Fine_Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_pagination);
            this.Controls.Add(this.dgvFinePaymentDetails);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Fine_Payments";
            this.Size = new System.Drawing.Size(846, 692);
            this.Load += new System.EventHandler(this.Fine_Payments_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinePaymentDetails)).EndInit();
            this.panel_pagination.ResumeLayout(false);
            this.panel_pagination.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel link_all;
        private System.Windows.Forms.LinkLabel link_6months;
        private System.Windows.Forms.LinkLabel link_30days;
        private System.Windows.Forms.LinkLabel link_7days;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroDateTime date_to;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private MetroFramework.Controls.MetroDateTime date_from;
        private Bunifu.Framework.UI.BunifuFlatButton btn_view;
        private System.Windows.Forms.DataGridView dgvFinePaymentDetails;
        private System.Windows.Forms.Label lblRecordsPerPage;
        private System.Windows.Forms.RadioButton radioBtn50;
        private System.Windows.Forms.RadioButton radioBtn20;
        private System.Windows.Forms.RadioButton radioBtn10;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lbl_totalrecords;
        private System.Windows.Forms.Label lblPaginationTotal;
        private System.Windows.Forms.RadioButton radiobtn_all;
        private System.Windows.Forms.RadioButton radiobtn_pending;
        private System.Windows.Forms.Panel panel_pagination;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFineDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPaidAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDueAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private Bunifu.Framework.UI.BunifuFlatButton btn_printToPDF;
    }
}
