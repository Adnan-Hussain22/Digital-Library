namespace Advanced_School_Manangement_System
{
    partial class Dummy3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalStaffMembers = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbFilterStaff = new MetroFramework.Controls.MetroComboBox();
            this.TextBoxSearch = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.SearchContainer = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvStaffDetails = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStaffId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateofJoin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateofExpire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.lblTotalStaffMembers);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cmbFilterStaff);
            this.panel3.Controls.Add(this.TextBoxSearch);
            this.panel3.Controls.Add(this.SearchContainer);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(-1, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(784, 105);
            this.panel3.TabIndex = 7;
            // 
            // lblTotalStaffMembers
            // 
            this.lblTotalStaffMembers.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalStaffMembers.AutoSize = true;
            this.lblTotalStaffMembers.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTotalStaffMembers.Location = new System.Drawing.Point(560, 79);
            this.lblTotalStaffMembers.Name = "lblTotalStaffMembers";
            this.lblTotalStaffMembers.Size = new System.Drawing.Size(167, 21);
            this.lblTotalStaffMembers.TabIndex = 36;
            this.lblTotalStaffMembers.Text = "Total Staff Members : 0";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(4, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 21);
            this.label6.TabIndex = 35;
            this.label6.Text = "Member Staff Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label7.Location = new System.Drawing.Point(6, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Filter by";
            // 
            // cmbFilterStaff
            // 
            this.cmbFilterStaff.FormattingEnabled = true;
            this.cmbFilterStaff.ItemHeight = 23;
            this.cmbFilterStaff.Items.AddRange(new object[] {
            "Select",
            "Member Id",
            "Name",
            "Contact No",
            "Email",
            "Staff Id",
            "Date Of Join",
            "Date Of Expire"});
            this.cmbFilterStaff.Location = new System.Drawing.Point(90, 37);
            this.cmbFilterStaff.Name = "cmbFilterStaff";
            this.cmbFilterStaff.Size = new System.Drawing.Size(144, 29);
            this.cmbFilterStaff.TabIndex = 33;
            this.cmbFilterStaff.UseSelectable = true;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TextBoxSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TextBoxSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxSearch.Location = new System.Drawing.Point(253, 40);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(313, 22);
            this.TextBoxSearch.TabIndex = 32;
            this.TextBoxSearch.WaterMark = "Type here to search";
            this.TextBoxSearch.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.TextBoxSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 9.5F);
            this.TextBoxSearch.WaterMarkForeColor = System.Drawing.Color.LightGray;
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
            this.SearchContainer.Location = new System.Drawing.Point(248, 35);
            this.SearchContainer.Margin = new System.Windows.Forms.Padding(4);
            this.SearchContainer.Name = "SearchContainer";
            this.SearchContainer.Size = new System.Drawing.Size(322, 31);
            this.SearchContainer.TabIndex = 31;
            this.SearchContainer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 9.5F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(3, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Search Students or double click the records to edit";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvStaffDetails, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-3, 109);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 411);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // dgvStaffDetails
            // 
            this.dgvStaffDetails.AllowUserToAddRows = false;
            this.dgvStaffDetails.AllowUserToDeleteRows = false;
            this.dgvStaffDetails.AllowUserToResizeColumns = false;
            this.dgvStaffDetails.AllowUserToResizeRows = false;
            this.dgvStaffDetails.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvStaffDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStaffDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaffDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStaffDetails.ColumnHeadersHeight = 30;
            this.dgvStaffDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnName,
            this.ColumnStaffId,
            this.ColumnContact,
            this.ColumnEmail,
            this.ColumnDateofJoin,
            this.ColumnDateofExpire});
            this.dgvStaffDetails.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvStaffDetails.Location = new System.Drawing.Point(3, 3);
            this.dgvStaffDetails.Name = "dgvStaffDetails";
            this.dgvStaffDetails.ReadOnly = true;
            this.dgvStaffDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStaffDetails.RowHeadersVisible = false;
            this.dgvStaffDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaffDetails.Size = new System.Drawing.Size(788, 405);
            this.dgvStaffDetails.TabIndex = 0;
            this.dgvStaffDetails.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaffDetails_CellDoubleClick);
            this.dgvStaffDetails.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaffDetails_CellEnter);
            this.dgvStaffDetails.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvStaffDetails_KeyDown);
            // 
            // ColumnId
            // 
            this.ColumnId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnStaffId
            // 
            this.ColumnStaffId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnStaffId.FillWeight = 150F;
            this.ColumnStaffId.HeaderText = "Staff Id";
            this.ColumnStaffId.Name = "ColumnStaffId";
            this.ColumnStaffId.ReadOnly = true;
            // 
            // ColumnContact
            // 
            this.ColumnContact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnContact.HeaderText = "Contact";
            this.ColumnContact.Name = "ColumnContact";
            this.ColumnContact.ReadOnly = true;
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnEmail.HeaderText = "Email";
            this.ColumnEmail.Name = "ColumnEmail";
            this.ColumnEmail.ReadOnly = true;
            // 
            // ColumnDateofJoin
            // 
            this.ColumnDateofJoin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDateofJoin.HeaderText = "Date of Join";
            this.ColumnDateofJoin.Name = "ColumnDateofJoin";
            this.ColumnDateofJoin.ReadOnly = true;
            // 
            // ColumnDateofExpire
            // 
            this.ColumnDateofExpire.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDateofExpire.HeaderText = "Date of Expire";
            this.ColumnDateofExpire.Name = "ColumnDateofExpire";
            this.ColumnDateofExpire.ReadOnly = true;
            // 
            // Dummy3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 519);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Dummy3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dummy3";
            this.Load += new System.EventHandler(this.Dummy3_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroComboBox cmbFilterStaff;
        private ChreneLib.Controls.TextBoxes.CTextBox TextBoxSearch;
        private Bunifu.Framework.UI.BunifuMetroTextbox SearchContainer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvStaffDetails;
        private System.Windows.Forms.Label lblTotalStaffMembers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStaffId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateofJoin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateofExpire;
    }
}