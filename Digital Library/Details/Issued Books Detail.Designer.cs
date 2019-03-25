namespace Digital Library.Details
{
    partial class Issued_Books_Detail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Issued_Books_Detail));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_back = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_printToPDF = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblPaginationTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_filter = new MetroFramework.Controls.MetroComboBox();
            this.textbox_search = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.SearchContainer = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblBooksPerPage = new System.Windows.Forms.Label();
            this.radioBtn50 = new System.Windows.Forms.RadioButton();
            this.radioBtn20 = new System.Windows.Forms.RadioButton();
            this.radioBtn10 = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.dgv_IssueDetails = new System.Windows.Forms.DataGridView();
            this.ColumnIssueId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBookTtile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHolder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHolderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCNIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIssueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLibrarian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLibrarianId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEdit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IssueDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.btn_back);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(846, 51);
            this.panel3.TabIndex = 32;
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
            this.btn_back.Location = new System.Drawing.Point(4, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Normalcolor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_back.OnHovercolor = System.Drawing.SystemColors.Control;
            this.btn_back.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_back.selected = false;
            this.btn_back.Size = new System.Drawing.Size(49, 38);
            this.btn_back.TabIndex = 18;
            this.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_back.Textcolor = System.Drawing.Color.White;
            this.btn_back.TextFont = new System.Drawing.Font("Century Gothic", 9.5F);
            this.btn_back.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.5F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(64, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Issued Books Detail";
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.AutoSize = true;
            this.lblTotalRecords.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTotalRecords.Location = new System.Drawing.Point(695, 5);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(122, 21);
            this.lblTotalRecords.TabIndex = 34;
            this.lblTotalRecords.Text = "Total Records : 0";
            this.lblTotalRecords.Visible = false;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 17);
            this.panel1.TabIndex = 30;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Controls.Add(this.btn_printToPDF);
            this.panel5.Controls.Add(this.lblPaginationTotal);
            this.panel5.Controls.Add(this.lblTotalRecords);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.cmb_filter);
            this.panel5.Controls.Add(this.textbox_search);
            this.panel5.Controls.Add(this.SearchContainer);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(0, 72);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(846, 111);
            this.panel5.TabIndex = 29;
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
            this.btn_printToPDF.Location = new System.Drawing.Point(635, 32);
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
            // lblPaginationTotal
            // 
            this.lblPaginationTotal.AutoSize = true;
            this.lblPaginationTotal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPaginationTotal.Location = new System.Drawing.Point(602, 86);
            this.lblPaginationTotal.Name = "lblPaginationTotal";
            this.lblPaginationTotal.Size = new System.Drawing.Size(161, 21);
            this.lblPaginationTotal.TabIndex = 35;
            this.lblPaginationTotal.Text = "1-20 of 0 items found";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label4.Location = new System.Drawing.Point(24, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Filter by";
            // 
            // cmb_filter
            // 
            this.cmb_filter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmb_filter.FormattingEnabled = true;
            this.cmb_filter.ItemHeight = 23;
            this.cmb_filter.Items.AddRange(new object[] {
            "All",
            "Title",
            "Category",
            "Class",
            "Subject",
            "Edition"});
            this.cmb_filter.Location = new System.Drawing.Point(108, 41);
            this.cmb_filter.Name = "cmb_filter";
            this.cmb_filter.Size = new System.Drawing.Size(144, 29);
            this.cmb_filter.TabIndex = 29;
            this.cmb_filter.UseSelectable = true;
            // 
            // textbox_search
            // 
            this.textbox_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textbox_search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textbox_search.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textbox_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_search.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textbox_search.Location = new System.Drawing.Point(271, 44);
            this.textbox_search.Name = "textbox_search";
            this.textbox_search.Size = new System.Drawing.Size(313, 22);
            this.textbox_search.TabIndex = 27;
            this.textbox_search.WaterMark = "Type here to search";
            this.textbox_search.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.textbox_search.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 9.5F);
            this.textbox_search.WaterMarkForeColor = System.Drawing.Color.LightGray;
            this.textbox_search.TextChanged += new System.EventHandler(this.textbox_search_TextChanged);
            // 
            // SearchContainer
            // 
            this.SearchContainer.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchContainer.BorderColorIdle = System.Drawing.Color.Silver;
            this.SearchContainer.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchContainer.BorderThickness = 1;
            this.SearchContainer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchContainer.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SearchContainer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchContainer.isPassword = false;
            this.SearchContainer.Location = new System.Drawing.Point(266, 39);
            this.SearchContainer.Margin = new System.Windows.Forms.Padding(4);
            this.SearchContainer.Name = "SearchContainer";
            this.SearchContainer.Size = new System.Drawing.Size(322, 31);
            this.SearchContainer.TabIndex = 26;
            this.SearchContainer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 9.5F, System.Drawing.FontStyle.Italic);
            this.label7.Location = new System.Drawing.Point(14, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(258, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Search records or select the edit link to update";
            // 
            // lblBooksPerPage
            // 
            this.lblBooksPerPage.AutoSize = true;
            this.lblBooksPerPage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBooksPerPage.Location = new System.Drawing.Point(586, 648);
            this.lblBooksPerPage.Name = "lblBooksPerPage";
            this.lblBooksPerPage.Size = new System.Drawing.Size(110, 19);
            this.lblBooksPerPage.TabIndex = 40;
            this.lblBooksPerPage.Text = "Items per page";
            // 
            // radioBtn50
            // 
            this.radioBtn50.AutoSize = true;
            this.radioBtn50.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn50.Location = new System.Drawing.Point(796, 647);
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
            this.radioBtn20.Location = new System.Drawing.Point(749, 648);
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
            this.radioBtn10.Location = new System.Drawing.Point(701, 648);
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
            this.btnBack.Location = new System.Drawing.Point(97, 644);
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
            this.btnNext.Location = new System.Drawing.Point(2, 644);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 30);
            this.btnNext.TabIndex = 35;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // dgv_IssueDetails
            // 
            this.dgv_IssueDetails.AllowUserToAddRows = false;
            this.dgv_IssueDetails.AllowUserToDeleteRows = false;
            this.dgv_IssueDetails.AllowUserToResizeColumns = false;
            this.dgv_IssueDetails.AllowUserToResizeRows = false;
            this.dgv_IssueDetails.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_IssueDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_IssueDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_IssueDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_IssueDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_IssueDetails.ColumnHeadersHeight = 30;
            this.dgv_IssueDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIssueId,
            this.ColumnBookTtile,
            this.ColumnBookId,
            this.ColumnAuthor,
            this.ColumnHolder,
            this.ColumnHolderId,
            this.ColumnCNIC,
            this.ColumnIssueDate,
            this.ColumnDueDate,
            this.ColumnLibrarian,
            this.ColumnLibrarianId,
            this.ColumnEdit,
            this.ColumnDelete});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_IssueDetails.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_IssueDetails.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_IssueDetails.Location = new System.Drawing.Point(0, 185);
            this.dgv_IssueDetails.MultiSelect = false;
            this.dgv_IssueDetails.Name = "dgv_IssueDetails";
            this.dgv_IssueDetails.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_IssueDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_IssueDetails.RowHeadersVisible = false;
            this.dgv_IssueDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_IssueDetails.Size = new System.Drawing.Size(846, 455);
            this.dgv_IssueDetails.TabIndex = 41;
            this.dgv_IssueDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIssuedBooksDetail_CellContentClick);
            // 
            // ColumnIssueId
            // 
            this.ColumnIssueId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnIssueId.HeaderText = "Id";
            this.ColumnIssueId.Name = "ColumnIssueId";
            this.ColumnIssueId.ReadOnly = true;
            this.ColumnIssueId.Visible = false;
            // 
            // ColumnBookTtile
            // 
            this.ColumnBookTtile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnBookTtile.HeaderText = "Book Title";
            this.ColumnBookTtile.Name = "ColumnBookTtile";
            this.ColumnBookTtile.ReadOnly = true;
            // 
            // ColumnBookId
            // 
            this.ColumnBookId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnBookId.HeaderText = "Book Id";
            this.ColumnBookId.Name = "ColumnBookId";
            this.ColumnBookId.ReadOnly = true;
            this.ColumnBookId.Visible = false;
            // 
            // ColumnAuthor
            // 
            this.ColumnAuthor.HeaderText = "Author";
            this.ColumnAuthor.Name = "ColumnAuthor";
            this.ColumnAuthor.ReadOnly = true;
            this.ColumnAuthor.Visible = false;
            // 
            // ColumnHolder
            // 
            this.ColumnHolder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnHolder.HeaderText = "Book Holder";
            this.ColumnHolder.Name = "ColumnHolder";
            this.ColumnHolder.ReadOnly = true;
            // 
            // ColumnHolderId
            // 
            this.ColumnHolderId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnHolderId.HeaderText = "Holder Id";
            this.ColumnHolderId.Name = "ColumnHolderId";
            this.ColumnHolderId.ReadOnly = true;
            this.ColumnHolderId.Visible = false;
            // 
            // ColumnCNIC
            // 
            this.ColumnCNIC.HeaderText = "CNIC";
            this.ColumnCNIC.Name = "ColumnCNIC";
            this.ColumnCNIC.ReadOnly = true;
            this.ColumnCNIC.Visible = false;
            // 
            // ColumnIssueDate
            // 
            this.ColumnIssueDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnIssueDate.HeaderText = "Issue Date";
            this.ColumnIssueDate.Name = "ColumnIssueDate";
            this.ColumnIssueDate.ReadOnly = true;
            // 
            // ColumnDueDate
            // 
            this.ColumnDueDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDueDate.HeaderText = "Due Date";
            this.ColumnDueDate.Name = "ColumnDueDate";
            this.ColumnDueDate.ReadOnly = true;
            // 
            // ColumnLibrarian
            // 
            this.ColumnLibrarian.HeaderText = "Librarian";
            this.ColumnLibrarian.Name = "ColumnLibrarian";
            this.ColumnLibrarian.ReadOnly = true;
            // 
            // ColumnLibrarianId
            // 
            this.ColumnLibrarianId.HeaderText = "Librarian Id";
            this.ColumnLibrarianId.Name = "ColumnLibrarianId";
            this.ColumnLibrarianId.ReadOnly = true;
            this.ColumnLibrarianId.Visible = false;
            // 
            // ColumnEdit
            // 
            this.ColumnEdit.HeaderText = "Edit";
            this.ColumnEdit.MinimumWidth = 60;
            this.ColumnEdit.Name = "ColumnEdit";
            this.ColumnEdit.ReadOnly = true;
            this.ColumnEdit.Text = "Edit";
            this.ColumnEdit.ToolTipText = "Edit the record";
            this.ColumnEdit.UseColumnTextForLinkValue = true;
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.HeaderText = "Delete";
            this.ColumnDelete.MinimumWidth = 60;
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.ReadOnly = true;
            this.ColumnDelete.Text = "Delete";
            this.ColumnDelete.ToolTipText = "Delete the record";
            this.ColumnDelete.UseColumnTextForLinkValue = true;
            // 
            // Issued_Books_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_IssueDetails);
            this.Controls.Add(this.lblBooksPerPage);
            this.Controls.Add(this.radioBtn50);
            this.Controls.Add(this.radioBtn20);
            this.Controls.Add(this.radioBtn10);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Name = "Issued_Books_Detail";
            this.Size = new System.Drawing.Size(846, 692);
            this.Load += new System.EventHandler(this.Issued_Books_Detail_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IssueDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton btn_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroComboBox cmb_filter;
        private ChreneLib.Controls.TextBoxes.CTextBox textbox_search;
        private Bunifu.Framework.UI.BunifuMetroTextbox SearchContainer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblBooksPerPage;
        private System.Windows.Forms.RadioButton radioBtn50;
        private System.Windows.Forms.RadioButton radioBtn20;
        private System.Windows.Forms.RadioButton radioBtn10;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DataGridView dgv_IssueDetails;
        private System.Windows.Forms.Label lblPaginationTotal;
        private System.Windows.Forms.Label lblTotalRecords;
        private Bunifu.Framework.UI.BunifuFlatButton btn_printToPDF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIssueId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBookTtile;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHolder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHolderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCNIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIssueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLibrarian;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLibrarianId;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnEdit;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnDelete;
    }
}
