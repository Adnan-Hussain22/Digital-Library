namespace Digital Library.Details
{
    partial class Book_Details
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book_Details));
            this.dgvBookDetails = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPubYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEdition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNoOfCopies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEdit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_printToPDF = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblPaginationTotal = new System.Windows.Forms.Label();
            this.lblTotalBooks = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbFilterMemberList = new MetroFramework.Controls.MetroComboBox();
            this.TextBoxSearch = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.SearchContainer = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ButtonBack = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBooksPerPage = new System.Windows.Forms.Label();
            this.radioBtn50 = new System.Windows.Forms.RadioButton();
            this.radioBtn20 = new System.Windows.Forms.RadioButton();
            this.radioBtn10 = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookDetails)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBookDetails
            // 
            this.dgvBookDetails.AllowUserToAddRows = false;
            this.dgvBookDetails.AllowUserToDeleteRows = false;
            this.dgvBookDetails.AllowUserToResizeColumns = false;
            this.dgvBookDetails.AllowUserToResizeRows = false;
            this.dgvBookDetails.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvBookDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBookDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvBookDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBookDetails.ColumnHeadersHeight = 30;
            this.dgvBookDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnImage,
            this.ColumnTitle,
            this.ColumnAuthor,
            this.ColumnSubject,
            this.ColumnCategory,
            this.ColumnPublisher,
            this.ColumnPrice,
            this.ColumnSupplier,
            this.ColumnISBN,
            this.ColumnPubYear,
            this.ColumnEdition,
            this.ColumnNoOfCopies,
            this.ColumnDetails,
            this.ColumnEdit,
            this.ColumnDelete});
            this.dgvBookDetails.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvBookDetails.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvBookDetails.Location = new System.Drawing.Point(0, 185);
            this.dgvBookDetails.Name = "dgvBookDetails";
            this.dgvBookDetails.ReadOnly = true;
            this.dgvBookDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBookDetails.RowHeadersVisible = false;
            this.dgvBookDetails.RowTemplate.Height = 40;
            this.dgvBookDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookDetails.Size = new System.Drawing.Size(846, 454);
            this.dgvBookDetails.StandardTab = true;
            this.dgvBookDetails.TabIndex = 24;
            this.dgvBookDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookDetails_CellContentClick);
            // 
            // ColumnId
            // 
            this.ColumnId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            // 
            // ColumnImage
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            this.ColumnImage.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnImage.HeaderText = "Image";
            this.ColumnImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColumnImage.MinimumWidth = 130;
            this.ColumnImage.Name = "ColumnImage";
            this.ColumnImage.ReadOnly = true;
            this.ColumnImage.Width = 130;
            // 
            // ColumnTitle
            // 
            this.ColumnTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnTitle.HeaderText = "Title";
            this.ColumnTitle.MinimumWidth = 100;
            this.ColumnTitle.Name = "ColumnTitle";
            this.ColumnTitle.ReadOnly = true;
            // 
            // ColumnAuthor
            // 
            this.ColumnAuthor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnAuthor.HeaderText = "Author";
            this.ColumnAuthor.Name = "ColumnAuthor";
            this.ColumnAuthor.ReadOnly = true;
            this.ColumnAuthor.Visible = false;
            this.ColumnAuthor.Width = 77;
            // 
            // ColumnSubject
            // 
            this.ColumnSubject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnSubject.HeaderText = "Subject";
            this.ColumnSubject.Name = "ColumnSubject";
            this.ColumnSubject.ReadOnly = true;
            this.ColumnSubject.Width = 78;
            // 
            // ColumnCategory
            // 
            this.ColumnCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnCategory.HeaderText = "Category";
            this.ColumnCategory.Name = "ColumnCategory";
            this.ColumnCategory.ReadOnly = true;
            this.ColumnCategory.Width = 90;
            // 
            // ColumnPublisher
            // 
            this.ColumnPublisher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnPublisher.HeaderText = "Publisher";
            this.ColumnPublisher.Name = "ColumnPublisher";
            this.ColumnPublisher.ReadOnly = true;
            this.ColumnPublisher.Width = 90;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnPrice.HeaderText = "Price";
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.ReadOnly = true;
            this.ColumnPrice.Width = 63;
            // 
            // ColumnSupplier
            // 
            this.ColumnSupplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnSupplier.HeaderText = "Supplier";
            this.ColumnSupplier.Name = "ColumnSupplier";
            this.ColumnSupplier.ReadOnly = true;
            this.ColumnSupplier.Width = 83;
            // 
            // ColumnISBN
            // 
            this.ColumnISBN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnISBN.HeaderText = "ISBN";
            this.ColumnISBN.Name = "ColumnISBN";
            this.ColumnISBN.ReadOnly = true;
            this.ColumnISBN.Width = 63;
            // 
            // ColumnPubYear
            // 
            this.ColumnPubYear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnPubYear.HeaderText = "Publication Year";
            this.ColumnPubYear.Name = "ColumnPubYear";
            this.ColumnPubYear.ReadOnly = true;
            this.ColumnPubYear.Width = 131;
            // 
            // ColumnEdition
            // 
            this.ColumnEdition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnEdition.HeaderText = "Edition";
            this.ColumnEdition.Name = "ColumnEdition";
            this.ColumnEdition.ReadOnly = true;
            this.ColumnEdition.Width = 76;
            // 
            // ColumnNoOfCopies
            // 
            this.ColumnNoOfCopies.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnNoOfCopies.HeaderText = "No of Copies";
            this.ColumnNoOfCopies.Name = "ColumnNoOfCopies";
            this.ColumnNoOfCopies.ReadOnly = true;
            this.ColumnNoOfCopies.Width = 113;
            // 
            // ColumnDetails
            // 
            this.ColumnDetails.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnDetails.HeaderText = "Details";
            this.ColumnDetails.Name = "ColumnDetails";
            this.ColumnDetails.ReadOnly = true;
            this.ColumnDetails.Width = 75;
            // 
            // ColumnEdit
            // 
            this.ColumnEdit.HeaderText = "Edit";
            this.ColumnEdit.Name = "ColumnEdit";
            this.ColumnEdit.ReadOnly = true;
            this.ColumnEdit.Text = "Edit";
            this.ColumnEdit.ToolTipText = "Edit the record";
            this.ColumnEdit.UseColumnTextForLinkValue = true;
            this.ColumnEdit.VisitedLinkColor = System.Drawing.Color.Blue;
            this.ColumnEdit.Width = 60;
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.HeaderText = "Delete";
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.ReadOnly = true;
            this.ColumnDelete.Text = "Delete";
            this.ColumnDelete.ToolTipText = "Delete this record ?";
            this.ColumnDelete.UseColumnTextForLinkValue = true;
            this.ColumnDelete.VisitedLinkColor = System.Drawing.Color.Blue;
            this.ColumnDelete.Width = 60;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Controls.Add(this.btn_printToPDF);
            this.panel5.Controls.Add(this.lblPaginationTotal);
            this.panel5.Controls.Add(this.lblTotalBooks);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.cmbFilterMemberList);
            this.panel5.Controls.Add(this.TextBoxSearch);
            this.panel5.Controls.Add(this.SearchContainer);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(0, 72);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(846, 111);
            this.panel5.TabIndex = 25;
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
            this.btn_printToPDF.Location = new System.Drawing.Point(647, 29);
            this.btn_printToPDF.Name = "btn_printToPDF";
            this.btn_printToPDF.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.btn_printToPDF.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(197)))), ((int)(((byte)(245)))));
            this.btn_printToPDF.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btn_printToPDF.selected = false;
            this.btn_printToPDF.Size = new System.Drawing.Size(102, 46);
            this.btn_printToPDF.TabIndex = 35;
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
            this.lblPaginationTotal.Location = new System.Drawing.Point(537, 85);
            this.lblPaginationTotal.Name = "lblPaginationTotal";
            this.lblPaginationTotal.Size = new System.Drawing.Size(161, 21);
            this.lblPaginationTotal.TabIndex = 31;
            this.lblPaginationTotal.Text = "1-20 of 0 items found";
            // 
            // lblTotalBooks
            // 
            this.lblTotalBooks.AutoSize = true;
            this.lblTotalBooks.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTotalBooks.Location = new System.Drawing.Point(711, 85);
            this.lblTotalBooks.Name = "lblTotalBooks";
            this.lblTotalBooks.Size = new System.Drawing.Size(108, 21);
            this.lblTotalBooks.TabIndex = 28;
            this.lblTotalBooks.Text = "Total Books : 0";
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
            // cmbFilterMemberList
            // 
            this.cmbFilterMemberList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbFilterMemberList.FormattingEnabled = true;
            this.cmbFilterMemberList.ItemHeight = 23;
            this.cmbFilterMemberList.Items.AddRange(new object[] {
            "All",
            "QR Code",
            "Title",
            "Author",
            "Category",
            "Subject",
            "Edition",
            "Publisher",
            "Supplier",
            "ISBN"});
            this.cmbFilterMemberList.Location = new System.Drawing.Point(108, 41);
            this.cmbFilterMemberList.Name = "cmbFilterMemberList";
            this.cmbFilterMemberList.Size = new System.Drawing.Size(144, 29);
            this.cmbFilterMemberList.TabIndex = 29;
            this.cmbFilterMemberList.UseSelectable = true;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TextBoxSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TextBoxSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxSearch.Location = new System.Drawing.Point(271, 44);
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
            this.label7.Location = new System.Drawing.Point(20, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(248, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Search Books or Select the records to update";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(15, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 21);
            this.label6.TabIndex = 24;
            this.label6.Text = "Book Details";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.ButtonBack);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(846, 51);
            this.panel3.TabIndex = 28;
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
            this.label1.Size = new System.Drawing.Size(132, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Book Details";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 675);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(846, 17);
            this.panel2.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 17);
            this.panel1.TabIndex = 26;
            // 
            // lblBooksPerPage
            // 
            this.lblBooksPerPage.AutoSize = true;
            this.lblBooksPerPage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBooksPerPage.Location = new System.Drawing.Point(588, 645);
            this.lblBooksPerPage.Name = "lblBooksPerPage";
            this.lblBooksPerPage.Size = new System.Drawing.Size(110, 19);
            this.lblBooksPerPage.TabIndex = 34;
            this.lblBooksPerPage.Text = "Items per page";
            // 
            // radioBtn50
            // 
            this.radioBtn50.AutoSize = true;
            this.radioBtn50.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn50.Location = new System.Drawing.Point(798, 644);
            this.radioBtn50.Name = "radioBtn50";
            this.radioBtn50.Size = new System.Drawing.Size(40, 21);
            this.radioBtn50.TabIndex = 33;
            this.radioBtn50.TabStop = true;
            this.radioBtn50.Text = "50";
            this.radioBtn50.UseVisualStyleBackColor = true;
            this.radioBtn50.CheckedChanged += new System.EventHandler(this.radioBtn50_CheckedChanged);
            // 
            // radioBtn20
            // 
            this.radioBtn20.AutoSize = true;
            this.radioBtn20.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn20.Location = new System.Drawing.Point(751, 645);
            this.radioBtn20.Name = "radioBtn20";
            this.radioBtn20.Size = new System.Drawing.Size(40, 21);
            this.radioBtn20.TabIndex = 32;
            this.radioBtn20.TabStop = true;
            this.radioBtn20.Text = "20";
            this.radioBtn20.UseVisualStyleBackColor = true;
            this.radioBtn20.CheckedChanged += new System.EventHandler(this.radioBtn20_CheckedChanged);
            // 
            // radioBtn10
            // 
            this.radioBtn10.AutoSize = true;
            this.radioBtn10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn10.Location = new System.Drawing.Point(703, 645);
            this.radioBtn10.Name = "radioBtn10";
            this.radioBtn10.Size = new System.Drawing.Size(40, 21);
            this.radioBtn10.TabIndex = 31;
            this.radioBtn10.TabStop = true;
            this.radioBtn10.Text = "10";
            this.radioBtn10.UseVisualStyleBackColor = true;
            this.radioBtn10.CheckedChanged += new System.EventHandler(this.radioBtn10_CheckedChanged);
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBack.Location = new System.Drawing.Point(99, 641);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 30);
            this.btnBack.TabIndex = 30;
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
            this.btnNext.TabIndex = 29;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Book_Details
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
            this.Controls.Add(this.dgvBookDetails);
            this.Name = "Book_Details";
            this.Size = new System.Drawing.Size(846, 692);
            this.Load += new System.EventHandler(this.Book_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookDetails)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBookDetails;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblPaginationTotal;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroComboBox cmbFilterMemberList;
        private System.Windows.Forms.Label lblTotalBooks;
        private ChreneLib.Controls.TextBoxes.CTextBox TextBoxSearch;
        private Bunifu.Framework.UI.BunifuMetroTextbox SearchContainer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton ButtonBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBooksPerPage;
        private System.Windows.Forms.RadioButton radioBtn50;
        private System.Windows.Forms.RadioButton radioBtn20;
        private System.Windows.Forms.RadioButton radioBtn10;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private Bunifu.Framework.UI.BunifuFlatButton btn_printToPDF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewImageColumn ColumnImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPublisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPubYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEdition;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNoOfCopies;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDetails;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnEdit;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnDelete;
    }
}
