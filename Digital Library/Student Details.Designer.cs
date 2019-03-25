namespace Advanced_School_Manangement_System
{
    partial class Dummy2
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
            this.label7 = new System.Windows.Forms.Label();
            this.cmbFilterStudent = new MetroFramework.Controls.MetroComboBox();
            this.TextBoxSearch = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.SearchContainer = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalStudentMembers = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvStdDetails = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnlastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCNIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateofJoin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateofExpire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStdDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cmbFilterStudent);
            this.panel3.Controls.Add(this.TextBoxSearch);
            this.panel3.Controls.Add(this.SearchContainer);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblTotalStudentMembers);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(-1, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(783, 113);
            this.panel3.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label7.Location = new System.Drawing.Point(10, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Filter by";
            // 
            // cmbFilterStudent
            // 
            this.cmbFilterStudent.FormattingEnabled = true;
            this.cmbFilterStudent.ItemHeight = 23;
            this.cmbFilterStudent.Items.AddRange(new object[] {
            "Select",
            "Member Id",
            "Name",
            "Contact No",
            "Email",
            "Gr No",
            "Date Of Join",
            "Date Of Expire"});
            this.cmbFilterStudent.Location = new System.Drawing.Point(94, 52);
            this.cmbFilterStudent.Name = "cmbFilterStudent";
            this.cmbFilterStudent.Size = new System.Drawing.Size(144, 29);
            this.cmbFilterStudent.TabIndex = 31;
            this.cmbFilterStudent.UseSelectable = true;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TextBoxSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TextBoxSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBoxSearch.Location = new System.Drawing.Point(257, 55);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(313, 22);
            this.TextBoxSearch.TabIndex = 30;
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
            this.SearchContainer.Location = new System.Drawing.Point(252, 50);
            this.SearchContainer.Margin = new System.Windows.Forms.Padding(4);
            this.SearchContainer.Name = "SearchContainer";
            this.SearchContainer.Size = new System.Drawing.Size(322, 31);
            this.SearchContainer.TabIndex = 29;
            this.SearchContainer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Student Details";
            // 
            // lblTotalStudentMembers
            // 
            this.lblTotalStudentMembers.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalStudentMembers.AutoSize = true;
            this.lblTotalStudentMembers.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTotalStudentMembers.Location = new System.Drawing.Point(588, 86);
            this.lblTotalStudentMembers.Name = "lblTotalStudentMembers";
            this.lblTotalStudentMembers.Size = new System.Drawing.Size(132, 21);
            this.lblTotalStudentMembers.TabIndex = 24;
            this.lblTotalStudentMembers.Text = "Total Members : 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 9.5F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(2, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Search Students or double click the records to edit";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvStdDetails, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-7, 116);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 403);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // dgvStdDetails
            // 
            this.dgvStdDetails.AllowUserToAddRows = false;
            this.dgvStdDetails.AllowUserToDeleteRows = false;
            this.dgvStdDetails.AllowUserToResizeColumns = false;
            this.dgvStdDetails.AllowUserToResizeRows = false;
            this.dgvStdDetails.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvStdDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStdDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvStdDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStdDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStdDetails.ColumnHeadersHeight = 30;
            this.dgvStdDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnFirstName,
            this.ColumnlastName,
            this.ColumnCNIC,
            this.ColumnContact,
            this.ColumnEmail,
            this.ColumnDateofJoin,
            this.ColumnDateofExpire});
            this.dgvStdDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStdDetails.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvStdDetails.Location = new System.Drawing.Point(3, 3);
            this.dgvStdDetails.Name = "dgvStdDetails";
            this.dgvStdDetails.ReadOnly = true;
            this.dgvStdDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStdDetails.RowHeadersVisible = false;
            this.dgvStdDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStdDetails.Size = new System.Drawing.Size(788, 397);
            this.dgvStdDetails.TabIndex = 1;
            this.dgvStdDetails.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookDetails_CellDoubleClick);
            // 
            // ColumnId
            // 
            this.ColumnId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            // 
            // ColumnFirstName
            // 
            this.ColumnFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnFirstName.HeaderText = "First Name";
            this.ColumnFirstName.Name = "ColumnFirstName";
            this.ColumnFirstName.ReadOnly = true;
            // 
            // ColumnlastName
            // 
            this.ColumnlastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnlastName.HeaderText = "Last Name";
            this.ColumnlastName.Name = "ColumnlastName";
            this.ColumnlastName.ReadOnly = true;
            // 
            // ColumnCNIC
            // 
            this.ColumnCNIC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCNIC.FillWeight = 150F;
            this.ColumnCNIC.HeaderText = "CNIC";
            this.ColumnCNIC.Name = "ColumnCNIC";
            this.ColumnCNIC.ReadOnly = true;
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
            // Dummy2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 519);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Dummy2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dummy2";
            this.Load += new System.EventHandler(this.Dummy2_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStdDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalStudentMembers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroComboBox cmbFilterStudent;
        private ChreneLib.Controls.TextBoxes.CTextBox TextBoxSearch;
        private Bunifu.Framework.UI.BunifuMetroTextbox SearchContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvStdDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnlastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCNIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateofJoin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateofExpire;
    }
}