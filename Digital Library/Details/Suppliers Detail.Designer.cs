namespace Digital Library.Details
{
    partial class Suppliers_Detail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Suppliers_Detail));
            this.lblBooksPerPage = new System.Windows.Forms.Label();
            this.radioBtn50 = new System.Windows.Forms.RadioButton();
            this.radioBtn20 = new System.Windows.Forms.RadioButton();
            this.radioBtn10 = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_printToPDF = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblPaginationTotal = new System.Windows.Forms.Label();
            this.lblTotalSuppliers = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbFilterSupplierList = new MetroFramework.Controls.MetroComboBox();
            this.TextBoxSearch = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.SearchContainer = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvSuppliersDetail = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEdit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_back = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliersDetail)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBooksPerPage
            // 
            this.lblBooksPerPage.AutoSize = true;
            this.lblBooksPerPage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBooksPerPage.Location = new System.Drawing.Point(588, 645);
            this.lblBooksPerPage.Name = "lblBooksPerPage";
            this.lblBooksPerPage.Size = new System.Drawing.Size(110, 19);
            this.lblBooksPerPage.TabIndex = 53;
            this.lblBooksPerPage.Text = "Items per page";
            // 
            // radioBtn50
            // 
            this.radioBtn50.AutoSize = true;
            this.radioBtn50.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn50.Location = new System.Drawing.Point(798, 644);
            this.radioBtn50.Name = "radioBtn50";
            this.radioBtn50.Size = new System.Drawing.Size(40, 21);
            this.radioBtn50.TabIndex = 52;
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
            this.radioBtn20.TabIndex = 51;
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
            this.radioBtn10.TabIndex = 50;
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
            this.btnBack.TabIndex = 49;
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
            this.btnNext.TabIndex = 48;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Controls.Add(this.btn_printToPDF);
            this.panel5.Controls.Add(this.lblPaginationTotal);
            this.panel5.Controls.Add(this.lblTotalSuppliers);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.cmbFilterSupplierList);
            this.panel5.Controls.Add(this.TextBoxSearch);
            this.panel5.Controls.Add(this.SearchContainer);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(0, 72);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(846, 111);
            this.panel5.TabIndex = 47;
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
            this.btn_printToPDF.Location = new System.Drawing.Point(634, 28);
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
            this.lblPaginationTotal.Location = new System.Drawing.Point(473, 85);
            this.lblPaginationTotal.Name = "lblPaginationTotal";
            this.lblPaginationTotal.Size = new System.Drawing.Size(161, 21);
            this.lblPaginationTotal.TabIndex = 35;
            this.lblPaginationTotal.Text = "1-20 of 0 items found";
            // 
            // lblTotalSuppliers
            // 
            this.lblTotalSuppliers.AutoSize = true;
            this.lblTotalSuppliers.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTotalSuppliers.Location = new System.Drawing.Point(643, 85);
            this.lblTotalSuppliers.Name = "lblTotalSuppliers";
            this.lblTotalSuppliers.Size = new System.Drawing.Size(131, 21);
            this.lblTotalSuppliers.TabIndex = 34;
            this.lblTotalSuppliers.Text = "Total Suppliers : 0";
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
            // cmbFilterSupplierList
            // 
            this.cmbFilterSupplierList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbFilterSupplierList.FormattingEnabled = true;
            this.cmbFilterSupplierList.ItemHeight = 23;
            this.cmbFilterSupplierList.Items.AddRange(new object[] {
            "All",
            "ID",
            "Name",
            "Address",
            "Contact No"});
            this.cmbFilterSupplierList.Location = new System.Drawing.Point(108, 41);
            this.cmbFilterSupplierList.Name = "cmbFilterSupplierList";
            this.cmbFilterSupplierList.Size = new System.Drawing.Size(144, 29);
            this.cmbFilterSupplierList.TabIndex = 29;
            this.cmbFilterSupplierList.UseSelectable = true;
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
            this.label7.Size = new System.Drawing.Size(258, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Search records or select the edit link to update";
            // 
            // dgvSuppliersDetail
            // 
            this.dgvSuppliersDetail.AllowUserToAddRows = false;
            this.dgvSuppliersDetail.AllowUserToDeleteRows = false;
            this.dgvSuppliersDetail.AllowUserToResizeColumns = false;
            this.dgvSuppliersDetail.AllowUserToResizeRows = false;
            this.dgvSuppliersDetail.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSuppliersDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSuppliersDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSuppliersDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuppliersDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSuppliersDetail.ColumnHeadersHeight = 30;
            this.dgvSuppliersDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnImage,
            this.ColumnFirstName,
            this.ColumnLastName,
            this.ColumnContact,
            this.ColumnAddress,
            this.ColumnEdit,
            this.ColumnDelete});
            this.dgvSuppliersDetail.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvSuppliersDetail.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvSuppliersDetail.Location = new System.Drawing.Point(0, 185);
            this.dgvSuppliersDetail.Name = "dgvSuppliersDetail";
            this.dgvSuppliersDetail.ReadOnly = true;
            this.dgvSuppliersDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSuppliersDetail.RowHeadersVisible = false;
            this.dgvSuppliersDetail.RowTemplate.Height = 40;
            this.dgvSuppliersDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuppliersDetail.Size = new System.Drawing.Size(846, 454);
            this.dgvSuppliersDetail.StandardTab = true;
            this.dgvSuppliersDetail.TabIndex = 46;
            this.dgvSuppliersDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSuppliersDetail_CellContentClick);
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
            // ColumnFirstName
            // 
            this.ColumnFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnFirstName.HeaderText = "First Name";
            this.ColumnFirstName.MinimumWidth = 120;
            this.ColumnFirstName.Name = "ColumnFirstName";
            this.ColumnFirstName.ReadOnly = true;
            // 
            // ColumnLastName
            // 
            this.ColumnLastName.HeaderText = "Last Name";
            this.ColumnLastName.MinimumWidth = 120;
            this.ColumnLastName.Name = "ColumnLastName";
            this.ColumnLastName.ReadOnly = true;
            this.ColumnLastName.Width = 120;
            // 
            // ColumnContact
            // 
            this.ColumnContact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnContact.HeaderText = "Contact";
            this.ColumnContact.MinimumWidth = 120;
            this.ColumnContact.Name = "ColumnContact";
            this.ColumnContact.ReadOnly = true;
            // 
            // ColumnAddress
            // 
            this.ColumnAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnAddress.HeaderText = "Address";
            this.ColumnAddress.MinimumWidth = 120;
            this.ColumnAddress.Name = "ColumnAddress";
            this.ColumnAddress.ReadOnly = true;
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
            this.ColumnDelete.Width = 60;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.btn_back);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(846, 51);
            this.panel3.TabIndex = 45;
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
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.5F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(64, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Suppliers Detail";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 675);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(846, 17);
            this.panel2.TabIndex = 44;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 17);
            this.panel1.TabIndex = 43;
            // 
            // Suppliers_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblBooksPerPage);
            this.Controls.Add(this.radioBtn50);
            this.Controls.Add(this.radioBtn20);
            this.Controls.Add(this.radioBtn10);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.dgvSuppliersDetail);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Suppliers_Detail";
            this.Size = new System.Drawing.Size(846, 692);
            this.Load += new System.EventHandler(this.Suppliers_Detail_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliersDetail)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroComboBox cmbFilterSupplierList;
        private ChreneLib.Controls.TextBoxes.CTextBox TextBoxSearch;
        private Bunifu.Framework.UI.BunifuMetroTextbox SearchContainer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvSuppliersDetail;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton btn_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPaginationTotal;
        private System.Windows.Forms.Label lblTotalSuppliers;
        private Bunifu.Framework.UI.BunifuFlatButton btn_printToPDF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewImageColumn ColumnImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddress;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnEdit;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnDelete;
    }
}
