namespace Digital Library
{
    partial class FrmLibDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLibDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menustripMain = new System.Windows.Forms.MenuStrip();
            this.MenuDashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMasterEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrpMenuCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrpMenuSubject = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrpMenuPublishers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrpMenuSuppliers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrpMenuBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrpMenuMembers = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMembers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrpMemberStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrpMemberStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCirculation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrpmenuIssueBook = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrpmenuReturnBook = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBooksReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrpmenuReturnBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSystemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStpmenuOperators = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStpmenuLibrarianDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStpmenuMasterSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuReports = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrpMenuBooksDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrpMenuMemberssDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrpMenuPublishersDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrpMenuSuppliersDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrpMenuIssuedBooksDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrpMenuIssuedReturnBooksDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrpMenuFinePaymentDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPeriodicals = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrpMenuAddJournalMagazines = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.menustripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(78)))), ((int)(((byte)(98)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-10, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 79);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(62, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 42);
            this.label1.TabIndex = 7;
            this.label1.Text = "Welcome";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(5, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 48);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_main.Location = new System.Drawing.Point(254, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(846, 692);
            this.panel_main.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(78)))), ((int)(((byte)(98)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.menustripMain);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 692);
            this.panel2.TabIndex = 5;
            // 
            // menustripMain
            // 
            this.menustripMain.AutoSize = false;
            this.menustripMain.BackColor = System.Drawing.Color.Transparent;
            this.menustripMain.Dock = System.Windows.Forms.DockStyle.None;
            this.menustripMain.GripMargin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.menustripMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menustripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuDashboard,
            this.MenuMasterEntry,
            this.MenuMembers,
            this.MenuCirculation,
            this.MenuBooksReturn,
            this.MenuSystemSettings,
            this.MenuReports,
            this.MenuPeriodicals});
            this.menustripMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menustripMain.Location = new System.Drawing.Point(0, 0);
            this.menustripMain.Margin = new System.Windows.Forms.Padding(50);
            this.menustripMain.Name = "menustripMain";
            this.menustripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menustripMain.Size = new System.Drawing.Size(263, 670);
            this.menustripMain.TabIndex = 6;
            this.menustripMain.Text = "menuStrip1";
            // 
            // MenuDashboard
            // 
            this.MenuDashboard.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuDashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MenuDashboard.Image = ((System.Drawing.Image)(resources.GetObject("MenuDashboard.Image")));
            this.MenuDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MenuDashboard.Margin = new System.Windows.Forms.Padding(2, 110, 0, 0);
            this.MenuDashboard.Name = "MenuDashboard";
            this.MenuDashboard.Size = new System.Drawing.Size(163, 28);
            this.MenuDashboard.Text = "  Dashboard";
            this.MenuDashboard.Click += new System.EventHandler(this.MenuDashboard_Click);
            // 
            // MenuMasterEntry
            // 
            this.MenuMasterEntry.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstrpMenuCategory,
            this.toolstrpMenuSubject,
            this.toolstrpMenuPublishers,
            this.toolstrpMenuSuppliers,
            this.toolstrpMenuBooks,
            this.toolstrpMenuMembers});
            this.MenuMasterEntry.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.MenuMasterEntry.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MenuMasterEntry.Image = ((System.Drawing.Image)(resources.GetObject("MenuMasterEntry.Image")));
            this.MenuMasterEntry.Margin = new System.Windows.Forms.Padding(2, 30, 0, 0);
            this.MenuMasterEntry.Name = "MenuMasterEntry";
            this.MenuMasterEntry.Size = new System.Drawing.Size(172, 28);
            this.MenuMasterEntry.Text = "  Master Entry";
            // 
            // toolstrpMenuCategory
            // 
            this.toolstrpMenuCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(78)))), ((int)(((byte)(98)))));
            this.toolstrpMenuCategory.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.toolstrpMenuCategory.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.toolstrpMenuCategory.Name = "toolstrpMenuCategory";
            this.toolstrpMenuCategory.Size = new System.Drawing.Size(152, 24);
            this.toolstrpMenuCategory.Text = "Category";
            this.toolstrpMenuCategory.Click += new System.EventHandler(this.toolstrpMenuCategory_Click);
            // 
            // toolstrpMenuSubject
            // 
            this.toolstrpMenuSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(78)))), ((int)(((byte)(98)))));
            this.toolstrpMenuSubject.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.toolstrpMenuSubject.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.toolstrpMenuSubject.Name = "toolstrpMenuSubject";
            this.toolstrpMenuSubject.Size = new System.Drawing.Size(152, 24);
            this.toolstrpMenuSubject.Text = "Subject";
            this.toolstrpMenuSubject.Click += new System.EventHandler(this.toolstrpMenuSubject_Click);
            // 
            // toolstrpMenuPublishers
            // 
            this.toolstrpMenuPublishers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(78)))), ((int)(((byte)(98)))));
            this.toolstrpMenuPublishers.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.toolstrpMenuPublishers.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.toolstrpMenuPublishers.Name = "toolstrpMenuPublishers";
            this.toolstrpMenuPublishers.Size = new System.Drawing.Size(152, 24);
            this.toolstrpMenuPublishers.Text = "Publishers";
            this.toolstrpMenuPublishers.Click += new System.EventHandler(this.toolstrpMenuPublishers_Click);
            // 
            // toolstrpMenuSuppliers
            // 
            this.toolstrpMenuSuppliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(78)))), ((int)(((byte)(98)))));
            this.toolstrpMenuSuppliers.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.toolstrpMenuSuppliers.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.toolstrpMenuSuppliers.Name = "toolstrpMenuSuppliers";
            this.toolstrpMenuSuppliers.Size = new System.Drawing.Size(152, 24);
            this.toolstrpMenuSuppliers.Text = "Suppliers";
            this.toolstrpMenuSuppliers.Click += new System.EventHandler(this.toolstrpMenuSuppliers_Click);
            // 
            // toolstrpMenuBooks
            // 
            this.toolstrpMenuBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(78)))), ((int)(((byte)(98)))));
            this.toolstrpMenuBooks.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.toolstrpMenuBooks.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.toolstrpMenuBooks.Name = "toolstrpMenuBooks";
            this.toolstrpMenuBooks.Size = new System.Drawing.Size(152, 24);
            this.toolstrpMenuBooks.Text = "Books";
            this.toolstrpMenuBooks.Click += new System.EventHandler(this.toolstrpMenuBooks_Click);
            // 
            // toolstrpMenuMembers
            // 
            this.toolstrpMenuMembers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(78)))), ((int)(((byte)(98)))));
            this.toolstrpMenuMembers.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.toolstrpMenuMembers.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.toolstrpMenuMembers.Name = "toolstrpMenuMembers";
            this.toolstrpMenuMembers.Size = new System.Drawing.Size(152, 24);
            this.toolstrpMenuMembers.Text = "Members";
            this.toolstrpMenuMembers.Click += new System.EventHandler(this.toolstrpMenuMembers_Click);
            // 
            // MenuMembers
            // 
            this.MenuMembers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstrpMemberStudent,
            this.toolstrpMemberStaff});
            this.MenuMembers.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.MenuMembers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MenuMembers.Image = ((System.Drawing.Image)(resources.GetObject("MenuMembers.Image")));
            this.MenuMembers.Margin = new System.Windows.Forms.Padding(2, 30, 0, 0);
            this.MenuMembers.Name = "MenuMembers";
            this.MenuMembers.Size = new System.Drawing.Size(146, 28);
            this.MenuMembers.Text = "  Members";
            this.MenuMembers.Visible = false;
            // 
            // toolstrpMemberStudent
            // 
            this.toolstrpMemberStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(78)))), ((int)(((byte)(98)))));
            this.toolstrpMemberStudent.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.toolstrpMemberStudent.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.toolstrpMemberStudent.Image = ((System.Drawing.Image)(resources.GetObject("toolstrpMemberStudent.Image")));
            this.toolstrpMemberStudent.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolstrpMemberStudent.Name = "toolstrpMemberStudent";
            this.toolstrpMemberStudent.Size = new System.Drawing.Size(201, 24);
            this.toolstrpMemberStudent.Text = "Member Student";
            this.toolstrpMemberStudent.Click += new System.EventHandler(this.toolstrpMemberStudent_Click);
            // 
            // toolstrpMemberStaff
            // 
            this.toolstrpMemberStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(78)))), ((int)(((byte)(98)))));
            this.toolstrpMemberStaff.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.toolstrpMemberStaff.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.toolstrpMemberStaff.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolstrpMemberStaff.Name = "toolstrpMemberStaff";
            this.toolstrpMemberStaff.Size = new System.Drawing.Size(201, 24);
            this.toolstrpMemberStaff.Text = "Member Staff";
            // 
            // MenuCirculation
            // 
            this.MenuCirculation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstrpmenuIssueBook,
            this.toolstrpmenuReturnBook});
            this.MenuCirculation.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuCirculation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MenuCirculation.Image = ((System.Drawing.Image)(resources.GetObject("MenuCirculation.Image")));
            this.MenuCirculation.Margin = new System.Windows.Forms.Padding(2, 30, 0, 0);
            this.MenuCirculation.Name = "MenuCirculation";
            this.MenuCirculation.Size = new System.Drawing.Size(216, 28);
            this.MenuCirculation.Text = "  Book Circulation";
            // 
            // toolstrpmenuIssueBook
            // 
            this.toolstrpmenuIssueBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(78)))), ((int)(((byte)(98)))));
            this.toolstrpmenuIssueBook.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.toolstrpmenuIssueBook.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.toolstrpmenuIssueBook.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolstrpmenuIssueBook.Name = "toolstrpmenuIssueBook";
            this.toolstrpmenuIssueBook.Size = new System.Drawing.Size(173, 24);
            this.toolstrpmenuIssueBook.Text = "Issue Books ";
            this.toolstrpmenuIssueBook.ToolTipText = "Issue books to members";
            this.toolstrpmenuIssueBook.Click += new System.EventHandler(this.toolstrpmenuIssueBooks_Click);
            // 
            // toolstrpmenuReturnBook
            // 
            this.toolstrpmenuReturnBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(78)))), ((int)(((byte)(98)))));
            this.toolstrpmenuReturnBook.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.toolstrpmenuReturnBook.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.toolstrpmenuReturnBook.Name = "toolstrpmenuReturnBook";
            this.toolstrpmenuReturnBook.Size = new System.Drawing.Size(173, 24);
            this.toolstrpmenuReturnBook.Text = "Return Books";
            this.toolstrpmenuReturnBook.Click += new System.EventHandler(this.toolstrpmenuReturnBooks_Click);
            // 
            // MenuBooksReturn
            // 
            this.MenuBooksReturn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstrpmenuReturnBooks});
            this.MenuBooksReturn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.MenuBooksReturn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MenuBooksReturn.Image = ((System.Drawing.Image)(resources.GetObject("MenuBooksReturn.Image")));
            this.MenuBooksReturn.Margin = new System.Windows.Forms.Padding(2, 30, 0, 0);
            this.MenuBooksReturn.Name = "MenuBooksReturn";
            this.MenuBooksReturn.Size = new System.Drawing.Size(181, 28);
            this.MenuBooksReturn.Text = "  Return Books";
            this.MenuBooksReturn.Visible = false;
            // 
            // toolstrpmenuReturnBooks
            // 
            this.toolstrpmenuReturnBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(78)))), ((int)(((byte)(98)))));
            this.toolstrpmenuReturnBooks.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.toolstrpmenuReturnBooks.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.toolstrpmenuReturnBooks.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolstrpmenuReturnBooks.Name = "toolstrpmenuReturnBooks";
            this.toolstrpmenuReturnBooks.Size = new System.Drawing.Size(173, 24);
            this.toolstrpmenuReturnBooks.Text = "Return Books";
            // 
            // MenuSystemSettings
            // 
            this.MenuSystemSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStpmenuOperators,
            this.toolStpmenuLibrarianDetails,
            this.toolStpmenuMasterSettings});
            this.MenuSystemSettings.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.MenuSystemSettings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MenuSystemSettings.Image = ((System.Drawing.Image)(resources.GetObject("MenuSystemSettings.Image")));
            this.MenuSystemSettings.Margin = new System.Windows.Forms.Padding(2, 30, 0, 0);
            this.MenuSystemSettings.Name = "MenuSystemSettings";
            this.MenuSystemSettings.Size = new System.Drawing.Size(203, 28);
            this.MenuSystemSettings.Text = "  System Settings";
            // 
            // toolStpmenuOperators
            // 
            this.toolStpmenuOperators.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(78)))), ((int)(((byte)(98)))));
            this.toolStpmenuOperators.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.toolStpmenuOperators.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.toolStpmenuOperators.Name = "toolStpmenuOperators";
            this.toolStpmenuOperators.Size = new System.Drawing.Size(193, 24);
            this.toolStpmenuOperators.Text = "Add Librarain";
            this.toolStpmenuOperators.Click += new System.EventHandler(this.toolStpmenuOperators_Click);
            // 
            // toolStpmenuLibrarianDetails
            // 
            this.toolStpmenuLibrarianDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(78)))), ((int)(((byte)(98)))));
            this.toolStpmenuLibrarianDetails.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.toolStpmenuLibrarianDetails.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.toolStpmenuLibrarianDetails.Name = "toolStpmenuLibrarianDetails";
            this.toolStpmenuLibrarianDetails.Size = new System.Drawing.Size(193, 24);
            this.toolStpmenuLibrarianDetails.Text = "Librarian Details";
            this.toolStpmenuLibrarianDetails.Click += new System.EventHandler(this.toolStpmenuBookDetails_Click);
            // 
            // toolStpmenuMasterSettings
            // 
            this.toolStpmenuMasterSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(78)))), ((int)(((byte)(98)))));
            this.toolStpmenuMasterSettings.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.toolStpmenuMasterSettings.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.toolStpmenuMasterSettings.Name = "toolStpmenuMasterSettings";
            this.toolStpmenuMasterSettings.Size = new System.Drawing.Size(193, 24);
            this.toolStpmenuMasterSettings.Text = "Master Settings";
            this.toolStpmenuMasterSettings.Click += new System.EventHandler(this.toolStpmenuMasterSettings_Click);
            // 
            // MenuReports
            // 
            this.MenuReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstrpMenuBooksDetail,
            this.toolstrpMenuMemberssDetail,
            this.toolstrpMenuPublishersDetail,
            this.toolstrpMenuSuppliersDetail,
            this.toolstrpMenuIssuedBooksDetail,
            this.toolstrpMenuIssuedReturnBooksDetail,
            this.toolstrpMenuFinePaymentDetail});
            this.MenuReports.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.MenuReports.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MenuReports.Image = global::Digital Library.Properties.Resources.progress_report;
            this.MenuReports.Margin = new System.Windows.Forms.Padding(2, 30, 0, 0);
            this.MenuReports.Name = "MenuReports";
            this.MenuReports.Size = new System.Drawing.Size(126, 28);
            this.MenuReports.Text = "  Reports";
            // 
            // toolstrpMenuBooksDetail
            // 
            this.toolstrpMenuBooksDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(78)))), ((int)(((byte)(98)))));
            this.toolstrpMenuBooksDetail.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.toolstrpMenuBooksDetail.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.toolstrpMenuBooksDetail.Name = "toolstrpMenuBooksDetail";
            this.toolstrpMenuBooksDetail.Size = new System.Drawing.Size(219, 24);
            this.toolstrpMenuBooksDetail.Text = "Books Detail";
            this.toolstrpMenuBooksDetail.Click += new System.EventHandler(this.toolstrpMenuBooksDetail_Click);
            // 
            // toolstrpMenuMemberssDetail
            // 
            this.toolstrpMenuMemberssDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(78)))), ((int)(((byte)(98)))));
            this.toolstrpMenuMemberssDetail.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.toolstrpMenuMemberssDetail.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.toolstrpMenuMemberssDetail.Name = "toolstrpMenuMemberssDetail";
            this.toolstrpMenuMemberssDetail.Size = new System.Drawing.Size(219, 24);
            this.toolstrpMenuMemberssDetail.Text = "Members Detail";
            this.toolstrpMenuMemberssDetail.Click += new System.EventHandler(this.toolstrpMenuMemberssDetail_Click);
            // 
            // toolstrpMenuPublishersDetail
            // 
            this.toolstrpMenuPublishersDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(78)))), ((int)(((byte)(98)))));
            this.toolstrpMenuPublishersDetail.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.toolstrpMenuPublishersDetail.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.toolstrpMenuPublishersDetail.Name = "toolstrpMenuPublishersDetail";
            this.toolstrpMenuPublishersDetail.Size = new System.Drawing.Size(219, 24);
            this.toolstrpMenuPublishersDetail.Text = "Publishers Detail";
            this.toolstrpMenuPublishersDetail.Click += new System.EventHandler(this.toolstrpMenuPublishersDetail_Click);
            // 
            // toolstrpMenuSuppliersDetail
            // 
            this.toolstrpMenuSuppliersDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(78)))), ((int)(((byte)(98)))));
            this.toolstrpMenuSuppliersDetail.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.toolstrpMenuSuppliersDetail.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.toolstrpMenuSuppliersDetail.Name = "toolstrpMenuSuppliersDetail";
            this.toolstrpMenuSuppliersDetail.Size = new System.Drawing.Size(219, 24);
            this.toolstrpMenuSuppliersDetail.Text = "Suppliers Detail";
            this.toolstrpMenuSuppliersDetail.Click += new System.EventHandler(this.toolstrpMenuSuppliersDetail_Click);
            // 
            // toolstrpMenuIssuedBooksDetail
            // 
            this.toolstrpMenuIssuedBooksDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(78)))), ((int)(((byte)(98)))));
            this.toolstrpMenuIssuedBooksDetail.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.toolstrpMenuIssuedBooksDetail.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.toolstrpMenuIssuedBooksDetail.Name = "toolstrpMenuIssuedBooksDetail";
            this.toolstrpMenuIssuedBooksDetail.Size = new System.Drawing.Size(219, 24);
            this.toolstrpMenuIssuedBooksDetail.Text = "Issued Books Detail";
            this.toolstrpMenuIssuedBooksDetail.Click += new System.EventHandler(this.toolstrpMenuIssuedBooksDetail_Click);
            // 
            // toolstrpMenuIssuedReturnBooksDetail
            // 
            this.toolstrpMenuIssuedReturnBooksDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(78)))), ((int)(((byte)(98)))));
            this.toolstrpMenuIssuedReturnBooksDetail.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.toolstrpMenuIssuedReturnBooksDetail.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.toolstrpMenuIssuedReturnBooksDetail.Name = "toolstrpMenuIssuedReturnBooksDetail";
            this.toolstrpMenuIssuedReturnBooksDetail.Size = new System.Drawing.Size(219, 24);
            this.toolstrpMenuIssuedReturnBooksDetail.Text = "Return Books Detail";
            this.toolstrpMenuIssuedReturnBooksDetail.Click += new System.EventHandler(this.toolstrpMenuIssuedReturnBooksDetail_Click);
            // 
            // toolstrpMenuFinePaymentDetail
            // 
            this.toolstrpMenuFinePaymentDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(78)))), ((int)(((byte)(98)))));
            this.toolstrpMenuFinePaymentDetail.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.toolstrpMenuFinePaymentDetail.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.toolstrpMenuFinePaymentDetail.Name = "toolstrpMenuFinePaymentDetail";
            this.toolstrpMenuFinePaymentDetail.Size = new System.Drawing.Size(219, 24);
            this.toolstrpMenuFinePaymentDetail.Text = "Fine Payments";
            this.toolstrpMenuFinePaymentDetail.Click += new System.EventHandler(this.toolstrpMenuFinePaymentDetail_Click);
            // 
            // MenuPeriodicals
            // 
            this.MenuPeriodicals.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstrpMenuAddJournalMagazines});
            this.MenuPeriodicals.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.MenuPeriodicals.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MenuPeriodicals.Image = global::Digital Library.Properties.Resources.open_book;
            this.MenuPeriodicals.Margin = new System.Windows.Forms.Padding(5, 30, 0, 0);
            this.MenuPeriodicals.Name = "MenuPeriodicals";
            this.MenuPeriodicals.Size = new System.Drawing.Size(157, 28);
            this.MenuPeriodicals.Text = "  Periodicals";
            // 
            // toolstrpMenuAddJournalMagazines
            // 
            this.toolstrpMenuAddJournalMagazines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(78)))), ((int)(((byte)(98)))));
            this.toolstrpMenuAddJournalMagazines.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.toolstrpMenuAddJournalMagazines.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.toolstrpMenuAddJournalMagazines.Name = "toolstrpMenuAddJournalMagazines";
            this.toolstrpMenuAddJournalMagazines.Size = new System.Drawing.Size(283, 24);
            this.toolstrpMenuAddJournalMagazines.Text = "Add Journal and Magazines";
            this.toolstrpMenuAddJournalMagazines.Click += new System.EventHandler(this.toolstrpMenuAddJournalMagazines_Click);
            // 
            // FrmLibDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1100, 692);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLibDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLibDashboard";
            this.Load += new System.EventHandler(this.FrmLibDashboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.menustripMain.ResumeLayout(false);
            this.menustripMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menustripMain;
        private System.Windows.Forms.ToolStripMenuItem MenuDashboard;
        private System.Windows.Forms.ToolStripMenuItem MenuMembers;
        private System.Windows.Forms.ToolStripMenuItem toolstrpMemberStudent;
        private System.Windows.Forms.ToolStripMenuItem MenuCirculation;
        private System.Windows.Forms.ToolStripMenuItem MenuMasterEntry;
        private System.Windows.Forms.ToolStripMenuItem toolstrpMenuCategory;
        private System.Windows.Forms.ToolStripMenuItem toolstrpMenuSubject;
        private System.Windows.Forms.ToolStripMenuItem toolstrpMemberStaff;
        private System.Windows.Forms.ToolStripMenuItem toolstrpmenuIssueBook;
        private System.Windows.Forms.ToolStripMenuItem MenuBooksReturn;
        private System.Windows.Forms.ToolStripMenuItem toolstrpmenuReturnBooks;
        private System.Windows.Forms.ToolStripMenuItem MenuSystemSettings;
        private System.Windows.Forms.ToolStripMenuItem toolStpmenuOperators;
        private System.Windows.Forms.ToolStripMenuItem toolstrpMenuBooks;
        private System.Windows.Forms.ToolStripMenuItem toolStpmenuLibrarianDetails;
        private System.Windows.Forms.ToolStripMenuItem MenuReports;
        private System.Windows.Forms.ToolStripMenuItem toolstrpMenuBooksDetail;
        private System.Windows.Forms.ToolStripMenuItem toolstrpMenuMemberssDetail;
        private System.Windows.Forms.ToolStripMenuItem toolstrpMenuPublishers;
        private System.Windows.Forms.ToolStripMenuItem toolstrpMenuSuppliers;
        private System.Windows.Forms.ToolStripMenuItem toolstrpMenuPublishersDetail;
        private System.Windows.Forms.ToolStripMenuItem toolstrpMenuSuppliersDetail;
        private System.Windows.Forms.ToolStripMenuItem toolstrpMenuIssuedBooksDetail;
        private System.Windows.Forms.ToolStripMenuItem toolstrpMenuIssuedReturnBooksDetail;
        private System.Windows.Forms.ToolStripMenuItem toolstrpMenuMembers;
        private System.Windows.Forms.ToolStripMenuItem MenuPeriodicals;
        private System.Windows.Forms.ToolStripMenuItem toolstrpMenuAddJournalMagazines;
        private System.Windows.Forms.ToolStripMenuItem toolstrpmenuReturnBook;
        private System.Windows.Forms.ToolStripMenuItem toolstrpMenuFinePaymentDetail;
        private System.Windows.Forms.ToolStripMenuItem toolStpmenuMasterSettings;
    }
}