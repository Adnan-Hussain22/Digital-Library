namespace Digital Library.Details
{
    partial class Return_Books_Detail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Return_Books_Detail));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblBooksPerPage = new System.Windows.Forms.Label();
            this.radioBtn50 = new System.Windows.Forms.RadioButton();
            this.radioBtn20 = new System.Windows.Forms.RadioButton();
            this.radioBtn10 = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ButtonBack = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_printToPDF = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblPaginationTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbFilterList = new MetroFramework.Controls.MetroComboBox();
            this.lblTotalBooks = new System.Windows.Forms.Label();
            this.TextBoxSearch = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.SearchContainer = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvReturnBooksDetail = new System.Windows.Forms.DataGridView();
            this.ColumnMainId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIssueId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHolderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHolderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHolderCNIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBookAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEdit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnBooksDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBooksPerPage
            // 
            this.lblBooksPerPage.AutoSize = true;
            this.lblBooksPerPage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBooksPerPage.Location = new System.Drawing.Point(588, 645);
            this.lblBooksPerPage.Name = "lblBooksPerPage";
            this.lblBooksPerPage.Size = new System.Drawing.Size(110, 19);
            this.lblBooksPerPage.TabIndex = 45;
            this.lblBooksPerPage.Text = "Items per page";
            // 
            // radioBtn50
            // 
            this.radioBtn50.AutoSize = true;
            this.radioBtn50.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn50.Location = new System.Drawing.Point(798, 644);
            this.radioBtn50.Name = "radioBtn50";
            this.radioBtn50.Size = new System.Drawing.Size(40, 21);
            this.radioBtn50.TabIndex = 44;
            this.radioBtn50.TabStop = true;
            this.radioBtn50.Text = "50";
            this.radioBtn50.UseVisualStyleBackColor = true;
            this.radioBtn50.Click += new System.EventHandler(this.radioBtn50_CheckedChanged);
            // 
            // radioBtn20
            // 
            this.radioBtn20.AutoSize = true;
            this.radioBtn20.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn20.Location = new System.Drawing.Point(751, 645);
            this.radioBtn20.Name = "radioBtn20";
            this.radioBtn20.Size = new System.Drawing.Size(40, 21);
            this.radioBtn20.TabIndex = 43;
            this.radioBtn20.TabStop = true;
            this.radioBtn20.Text = "20";
            this.radioBtn20.UseVisualStyleBackColor = true;
            this.radioBtn20.Click += new System.EventHandler(this.radioBtn20_CheckedChanged);
            // 
            // radioBtn10
            // 
            this.radioBtn10.AutoSize = true;
            this.radioBtn10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn10.Location = new System.Drawing.Point(703, 645);
            this.radioBtn10.Name = "radioBtn10";
            this.radioBtn10.Size = new System.Drawing.Size(40, 21);
            this.radioBtn10.TabIndex = 42;
            this.radioBtn10.TabStop = true;
            this.radioBtn10.Text = "10";
            this.radioBtn10.UseVisualStyleBackColor = true;
            this.radioBtn10.Click += new System.EventHandler(this.radioBtn10_CheckedChanged);
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBack.Location = new System.Drawing.Point(99, 641);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 30);
            this.btnBack.TabIndex = 41;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNext.Location = new System.Drawing.Point(4, 641);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 30);
            this.btnNext.TabIndex = 40;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.ButtonBack);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(846, 51);
            this.panel3.TabIndex = 39;
            // 
            // ButtonBack
            // 
            this.ButtonBack.Activecolor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonBack.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ButtonBack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonBack.BackgroundImage")));
            this.ButtonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonBack.BorderRadius = 5;
            this.ButtonBack.ButtonText = "";
            this.ButtonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonBack.DisabledColor = System.Drawing.Color.Gray;
            this.ButtonBack.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtonBack.Iconimage = null;
            this.ButtonBack.Iconimage_right = null;
            this.ButtonBack.Iconimage_right_Selected = null;
            this.ButtonBack.Iconimage_Selected = null;
            this.ButtonBack.IconMarginLeft = 0;
            this.ButtonBack.IconMarginRight = 0;
            this.ButtonBack.IconRightVisible = true;
            this.ButtonBack.IconRightZoom = 0D;
            this.ButtonBack.IconVisible = true;
            this.ButtonBack.IconZoom = 90D;
            this.ButtonBack.IsTab = false;
            this.ButtonBack.Location = new System.Drawing.Point(4, 3);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Normalcolor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonBack.OnHovercolor = System.Drawing.SystemColors.Control;
            this.ButtonBack.OnHoverTextColor = System.Drawing.Color.White;
            this.ButtonBack.selected = false;
            this.ButtonBack.Size = new System.Drawing.Size(49, 38);
            this.ButtonBack.TabIndex = 18;
            this.ButtonBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonBack.Textcolor = System.Drawing.Color.White;
            this.ButtonBack.TextFont = new System.Drawing.Font("Century Gothic", 9.5F);
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.5F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(64, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Return Books Detail";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 675);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(846, 17);
            this.panel2.TabIndex = 38;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 17);
            this.panel1.TabIndex = 37;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Controls.Add(this.btn_printToPDF);
            this.panel5.Controls.Add(this.lblPaginationTotal);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.cmbFilterList);
            this.panel5.Controls.Add(this.lblTotalBooks);
            this.panel5.Controls.Add(this.TextBoxSearch);
            this.panel5.Controls.Add(this.SearchContainer);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(0, 72);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(846, 111);
            this.panel5.TabIndex = 36;
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
            this.btn_printToPDF.Location = new System.Drawing.Point(638, 24);
            this.btn_printToPDF.Name = "btn_printToPDF";
            this.btn_printToPDF.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.btn_printToPDF.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(197)))), ((int)(((byte)(245)))));
            this.btn_printToPDF.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btn_printToPDF.selected = false;
            this.btn_printToPDF.Size = new System.Drawing.Size(102, 46);
            this.btn_printToPDF.TabIndex = 37;
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
            this.lblPaginationTotal.Location = new System.Drawing.Point(527, 85);
            this.lblPaginationTotal.Name = "lblPaginationTotal";
            this.lblPaginationTotal.Size = new System.Drawing.Size(161, 21);
            this.lblPaginationTotal.TabIndex = 31;
            this.lblPaginationTotal.Text = "1-20 of 0 items found";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label4.Location = new System.Drawing.Point(24, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Filter by";
            // 
            // cmbFilterList
            // 
            this.cmbFilterList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbFilterList.FormattingEnabled = true;
            this.cmbFilterList.ItemHeight = 23;
            this.cmbFilterList.Items.AddRange(new object[] {
            "All",
            "Issuance QR Code",
            "Book Title",
            "Book Holder",
            "Holder CNIC",
            "Return Date",
            "Fine"});
            this.cmbFilterList.Location = new System.Drawing.Point(108, 37);
            this.cmbFilterList.Name = "cmbFilterList";
            this.cmbFilterList.Size = new System.Drawing.Size(144, 29);
            this.cmbFilterList.TabIndex = 29;
            this.cmbFilterList.UseSelectable = true;
            // 
            // lblTotalBooks
            // 
            this.lblTotalBooks.AutoSize = true;
            this.lblTotalBooks.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTotalBooks.Location = new System.Drawing.Point(697, 85);
            this.lblTotalBooks.Name = "lblTotalBooks";
            this.lblTotalBooks.Size = new System.Drawing.Size(122, 21);
            this.lblTotalBooks.TabIndex = 28;
            this.lblTotalBooks.Text = "Total Records : 0";
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TextBoxSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TextBoxSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxSearch.Location = new System.Drawing.Point(271, 40);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(313, 22);
            this.TextBoxSearch.TabIndex = 27;
            this.TextBoxSearch.WaterMark = "Type here to search";
            this.TextBoxSearch.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.TextBoxSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 9.5F);
            this.TextBoxSearch.WaterMarkForeColor = System.Drawing.Color.LightGray;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
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
            this.SearchContainer.Location = new System.Drawing.Point(266, 35);
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
            this.label7.Location = new System.Drawing.Point(20, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(248, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Search Books or Select the records to update";
            // 
            // dgvReturnBooksDetail
            // 
            this.dgvReturnBooksDetail.AllowUserToAddRows = false;
            this.dgvReturnBooksDetail.AllowUserToDeleteRows = false;
            this.dgvReturnBooksDetail.AllowUserToResizeColumns = false;
            this.dgvReturnBooksDetail.AllowUserToResizeRows = false;
            this.dgvReturnBooksDetail.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvReturnBooksDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReturnBooksDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvReturnBooksDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReturnBooksDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReturnBooksDetail.ColumnHeadersHeight = 30;
            this.dgvReturnBooksDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMainId,
            this.ColumnIssueId,
            this.ColumnHolderId,
            this.ColumnBookId,
            this.ColumnHolderName,
            this.ColumnHolderCNIC,
            this.ColumnBookTitle,
            this.ColumnBookAuthor,
            this.ColumnReturnDate,
            this.ColumnFine,
            this.ColumnEdit,
            this.ColumnDelete});
            this.dgvReturnBooksDetail.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvReturnBooksDetail.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvReturnBooksDetail.Location = new System.Drawing.Point(0, 185);
            this.dgvReturnBooksDetail.Name = "dgvReturnBooksDetail";
            this.dgvReturnBooksDetail.ReadOnly = true;
            this.dgvReturnBooksDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvReturnBooksDetail.RowHeadersVisible = false;
            this.dgvReturnBooksDetail.RowTemplate.Height = 60;
            this.dgvReturnBooksDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReturnBooksDetail.Size = new System.Drawing.Size(846, 454);
            this.dgvReturnBooksDetail.StandardTab = true;
            this.dgvReturnBooksDetail.TabIndex = 35;
            this.dgvReturnBooksDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookDetails_CellContentClick);
            // 
            // ColumnMainId
            // 
            this.ColumnMainId.HeaderText = "Main Id";
            this.ColumnMainId.Name = "ColumnMainId";
            this.ColumnMainId.ReadOnly = true;
            this.ColumnMainId.Visible = false;
            // 
            // ColumnIssueId
            // 
            this.ColumnIssueId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnIssueId.HeaderText = "Issue Id";
            this.ColumnIssueId.Name = "ColumnIssueId";
            this.ColumnIssueId.ReadOnly = true;
            this.ColumnIssueId.Visible = false;
            // 
            // ColumnHolderId
            // 
            this.ColumnHolderId.HeaderText = "Holder Id";
            this.ColumnHolderId.Name = "ColumnHolderId";
            this.ColumnHolderId.ReadOnly = true;
            this.ColumnHolderId.Visible = false;
            // 
            // ColumnBookId
            // 
            this.ColumnBookId.HeaderText = "BookId";
            this.ColumnBookId.Name = "ColumnBookId";
            this.ColumnBookId.ReadOnly = true;
            this.ColumnBookId.Visible = false;
            // 
            // ColumnHolderName
            // 
            this.ColumnHolderName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnHolderName.HeaderText = "Holder Name";
            this.ColumnHolderName.Name = "ColumnHolderName";
            this.ColumnHolderName.ReadOnly = true;
            this.ColumnHolderName.Width = 115;
            // 
            // ColumnHolderCNIC
            // 
            this.ColumnHolderCNIC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnHolderCNIC.HeaderText = "Holder CNIC";
            this.ColumnHolderCNIC.MinimumWidth = 120;
            this.ColumnHolderCNIC.Name = "ColumnHolderCNIC";
            this.ColumnHolderCNIC.ReadOnly = true;
            this.ColumnHolderCNIC.Width = 120;
            // 
            // ColumnBookTitle
            // 
            this.ColumnBookTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnBookTitle.HeaderText = "Book Title";
            this.ColumnBookTitle.MinimumWidth = 120;
            this.ColumnBookTitle.Name = "ColumnBookTitle";
            this.ColumnBookTitle.ReadOnly = true;
            // 
            // ColumnBookAuthor
            // 
            this.ColumnBookAuthor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnBookAuthor.HeaderText = "Book Author";
            this.ColumnBookAuthor.MinimumWidth = 120;
            this.ColumnBookAuthor.Name = "ColumnBookAuthor";
            this.ColumnBookAuthor.ReadOnly = true;
            this.ColumnBookAuthor.Visible = false;
            // 
            // ColumnReturnDate
            // 
            this.ColumnReturnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnReturnDate.HeaderText = "Return Date";
            this.ColumnReturnDate.MinimumWidth = 100;
            this.ColumnReturnDate.Name = "ColumnReturnDate";
            this.ColumnReturnDate.ReadOnly = true;
            this.ColumnReturnDate.Width = 108;
            // 
            // ColumnFine
            // 
            this.ColumnFine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnFine.HeaderText = "Fine";
            this.ColumnFine.MinimumWidth = 100;
            this.ColumnFine.Name = "ColumnFine";
            this.ColumnFine.ReadOnly = true;
            // 
            // ColumnEdit
            // 
            this.ColumnEdit.HeaderText = "Edit";
            this.ColumnEdit.Name = "ColumnEdit";
            this.ColumnEdit.ReadOnly = true;
            this.ColumnEdit.Text = "Edit";
            this.ColumnEdit.ToolTipText = "Edit the record";
            this.ColumnEdit.UseColumnTextForLinkValue = true;
            this.ColumnEdit.Width = 80;
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.HeaderText = "Delete";
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.ReadOnly = true;
            this.ColumnDelete.Text = "Delete";
            this.ColumnDelete.ToolTipText = "Delete this record ?";
            this.ColumnDelete.UseColumnTextForLinkValue = true;
            this.ColumnDelete.Width = 80;
            // 
            // Return_Books_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Controls.Add(this.dgvReturnBooksDetail);
            this.Name = "Return_Books_Detail";
            this.Size = new System.Drawing.Size(846, 692);
            this.Load += new System.EventHandler(this.Return_Books_Detail_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnBooksDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBooksPerPage;
        private System.Windows.Forms.RadioButton radioBtn50;
        private System.Windows.Forms.RadioButton radioBtn20;
        private System.Windows.Forms.RadioButton radioBtn10;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton ButtonBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblPaginationTotal;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroComboBox cmbFilterList;
        private System.Windows.Forms.Label lblTotalBooks;
        private ChreneLib.Controls.TextBoxes.CTextBox TextBoxSearch;
        private Bunifu.Framework.UI.BunifuMetroTextbox SearchContainer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvReturnBooksDetail;
        private Bunifu.Framework.UI.BunifuFlatButton btn_printToPDF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMainId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIssueId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHolderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHolderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHolderCNIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBookAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFine;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnEdit;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnDelete;
    }
}
