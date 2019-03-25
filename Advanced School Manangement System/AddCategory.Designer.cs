namespace Advanced_School_Manangement_System
{
    partial class AddCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCategory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ButtonBack = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbleCategoryNotAvilable = new System.Windows.Forms.Label();
            this.lblCategoryIsAvilable = new System.Windows.Forms.Label();
            this.lblinstruction = new System.Windows.Forms.Label();
            this.TextboxAC_Category = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Textboxcontainer = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ButtonUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ButtonDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ButtonNew = new Bunifu.Framework.UI.BunifuFlatButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.dgv_CategoryDetails = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalCategories = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CategoryDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 17);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 605);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(846, 17);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.ButtonBack);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(846, 50);
            this.panel3.TabIndex = 2;
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
            this.ButtonBack.Location = new System.Drawing.Point(5, 3);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Normalcolor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonBack.OnHovercolor = System.Drawing.SystemColors.Control;
            this.ButtonBack.OnHoverTextColor = System.Drawing.Color.White;
            this.ButtonBack.selected = false;
            this.ButtonBack.Size = new System.Drawing.Size(49, 38);
            this.ButtonBack.TabIndex = 16;
            this.ButtonBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonBack.Textcolor = System.Drawing.Color.White;
            this.ButtonBack.TextFont = new System.Drawing.Font("Century Gothic", 9.5F);
            this.ButtonBack.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.5F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(53, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Categories";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.lbleCategoryNotAvilable);
            this.panel4.Controls.Add(this.lblCategoryIsAvilable);
            this.panel4.Controls.Add(this.lblinstruction);
            this.panel4.Controls.Add(this.TextboxAC_Category);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.Textboxcontainer);
            this.panel4.Location = new System.Drawing.Point(0, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(846, 64);
            this.panel4.TabIndex = 5;
            // 
            // lbleCategoryNotAvilable
            // 
            this.lbleCategoryNotAvilable.AutoSize = true;
            this.lbleCategoryNotAvilable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lbleCategoryNotAvilable.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbleCategoryNotAvilable.Location = new System.Drawing.Point(330, 42);
            this.lbleCategoryNotAvilable.Name = "lbleCategoryNotAvilable";
            this.lbleCategoryNotAvilable.Size = new System.Drawing.Size(79, 15);
            this.lbleCategoryNotAvilable.TabIndex = 22;
            this.lbleCategoryNotAvilable.Text = "Not Available";
            this.lbleCategoryNotAvilable.Visible = false;
            // 
            // lblCategoryIsAvilable
            // 
            this.lblCategoryIsAvilable.AutoSize = true;
            this.lblCategoryIsAvilable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblCategoryIsAvilable.ForeColor = System.Drawing.Color.Red;
            this.lblCategoryIsAvilable.Location = new System.Drawing.Point(299, 42);
            this.lblCategoryIsAvilable.Name = "lblCategoryIsAvilable";
            this.lblCategoryIsAvilable.Size = new System.Drawing.Size(161, 15);
            this.lblCategoryIsAvilable.TabIndex = 21;
            this.lblCategoryIsAvilable.Text = "Category is already available";
            this.lblCategoryIsAvilable.Visible = false;
            // 
            // lblinstruction
            // 
            this.lblinstruction.AutoSize = true;
            this.lblinstruction.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Italic);
            this.lblinstruction.Location = new System.Drawing.Point(6, 42);
            this.lblinstruction.Name = "lblinstruction";
            this.lblinstruction.Size = new System.Drawing.Size(256, 15);
            this.lblinstruction.TabIndex = 20;
            this.lblinstruction.Text = "Add categories or double click on the record to edit";
            // 
            // TextboxAC_Category
            // 
            this.TextboxAC_Category.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TextboxAC_Category.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TextboxAC_Category.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextboxAC_Category.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextboxAC_Category.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextboxAC_Category.Location = new System.Drawing.Point(178, 11);
            this.TextboxAC_Category.Name = "TextboxAC_Category";
            this.TextboxAC_Category.Size = new System.Drawing.Size(340, 22);
            this.TextboxAC_Category.TabIndex = 18;
            this.TextboxAC_Category.WaterMark = "Name of category";
            this.TextboxAC_Category.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.TextboxAC_Category.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 9.5F);
            this.TextboxAC_Category.WaterMarkForeColor = System.Drawing.Color.LightGray;
            this.TextboxAC_Category.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextboxAC_Category_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Category Name";
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
            this.Textboxcontainer.Location = new System.Drawing.Point(175, 6);
            this.Textboxcontainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Textboxcontainer.Name = "Textboxcontainer";
            this.Textboxcontainer.Size = new System.Drawing.Size(346, 31);
            this.Textboxcontainer.TabIndex = 4;
            this.Textboxcontainer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.Controls.Add(this.lblTotalCategories);
            this.panel5.Controls.Add(this.flowLayoutPanel3);
            this.panel5.Controls.Add(this.flowLayoutPanel2);
            this.panel5.Controls.Add(this.ButtonDelete);
            this.panel5.Controls.Add(this.ButtonNew);
            this.panel5.Controls.Add(this.ButtonUpdate);
            this.panel5.Controls.Add(this.ButtonAdd);
            this.panel5.Controls.Add(this.flowLayoutPanel1);
            this.panel5.Location = new System.Drawing.Point(0, 140);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(846, 52);
            this.panel5.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(90, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1, 48);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ButtonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ButtonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonAdd.BorderRadius = 7;
            this.ButtonAdd.ButtonText = "Add";
            this.ButtonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAdd.DisabledColor = System.Drawing.Color.Gray;
            this.ButtonAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtonAdd.Iconimage = null;
            this.ButtonAdd.Iconimage_right = null;
            this.ButtonAdd.Iconimage_right_Selected = null;
            this.ButtonAdd.Iconimage_Selected = null;
            this.ButtonAdd.IconMarginLeft = 0;
            this.ButtonAdd.IconMarginRight = 0;
            this.ButtonAdd.IconRightVisible = true;
            this.ButtonAdd.IconRightZoom = 0D;
            this.ButtonAdd.IconVisible = true;
            this.ButtonAdd.IconZoom = 90D;
            this.ButtonAdd.IsTab = false;
            this.ButtonAdd.Location = new System.Drawing.Point(9, 7);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ButtonAdd.OnHovercolor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonAdd.OnHoverTextColor = System.Drawing.Color.Black;
            this.ButtonAdd.selected = false;
            this.ButtonAdd.Size = new System.Drawing.Size(76, 38);
            this.ButtonAdd.TabIndex = 9;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonAdd.Textcolor = System.Drawing.Color.White;
            this.ButtonAdd.TextFont = new System.Drawing.Font("Century Gothic", 9.5F);
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ButtonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ButtonUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonUpdate.BorderRadius = 7;
            this.ButtonUpdate.ButtonText = "Update";
            this.ButtonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.ButtonUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtonUpdate.Iconimage = null;
            this.ButtonUpdate.Iconimage_right = null;
            this.ButtonUpdate.Iconimage_right_Selected = null;
            this.ButtonUpdate.Iconimage_Selected = null;
            this.ButtonUpdate.IconMarginLeft = 0;
            this.ButtonUpdate.IconMarginRight = 0;
            this.ButtonUpdate.IconRightVisible = true;
            this.ButtonUpdate.IconRightZoom = 0D;
            this.ButtonUpdate.IconVisible = true;
            this.ButtonUpdate.IconZoom = 90D;
            this.ButtonUpdate.IsTab = false;
            this.ButtonUpdate.Location = new System.Drawing.Point(98, 7);
            this.ButtonUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ButtonUpdate.OnHovercolor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonUpdate.OnHoverTextColor = System.Drawing.Color.Black;
            this.ButtonUpdate.selected = false;
            this.ButtonUpdate.Size = new System.Drawing.Size(76, 38);
            this.ButtonUpdate.TabIndex = 10;
            this.ButtonUpdate.Text = "Update";
            this.ButtonUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonUpdate.Textcolor = System.Drawing.Color.White;
            this.ButtonUpdate.TextFont = new System.Drawing.Font("Century Gothic", 9.5F);
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ButtonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ButtonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonDelete.BorderRadius = 7;
            this.ButtonDelete.ButtonText = "Delete";
            this.ButtonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDelete.DisabledColor = System.Drawing.Color.Gray;
            this.ButtonDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtonDelete.Iconimage = null;
            this.ButtonDelete.Iconimage_right = null;
            this.ButtonDelete.Iconimage_right_Selected = null;
            this.ButtonDelete.Iconimage_Selected = null;
            this.ButtonDelete.IconMarginLeft = 0;
            this.ButtonDelete.IconMarginRight = 0;
            this.ButtonDelete.IconRightVisible = true;
            this.ButtonDelete.IconRightZoom = 0D;
            this.ButtonDelete.IconVisible = true;
            this.ButtonDelete.IconZoom = 90D;
            this.ButtonDelete.IsTab = false;
            this.ButtonDelete.Location = new System.Drawing.Point(188, 7);
            this.ButtonDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ButtonDelete.OnHovercolor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonDelete.OnHoverTextColor = System.Drawing.Color.Black;
            this.ButtonDelete.selected = false;
            this.ButtonDelete.Size = new System.Drawing.Size(74, 38);
            this.ButtonDelete.TabIndex = 12;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonDelete.Textcolor = System.Drawing.Color.White;
            this.ButtonDelete.TextFont = new System.Drawing.Font("Century Gothic", 9.5F);
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonNew
            // 
            this.ButtonNew.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ButtonNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ButtonNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonNew.BorderRadius = 7;
            this.ButtonNew.ButtonText = "New";
            this.ButtonNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNew.DisabledColor = System.Drawing.Color.Gray;
            this.ButtonNew.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNew.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtonNew.Iconimage = null;
            this.ButtonNew.Iconimage_right = null;
            this.ButtonNew.Iconimage_right_Selected = null;
            this.ButtonNew.Iconimage_Selected = null;
            this.ButtonNew.IconMarginLeft = 0;
            this.ButtonNew.IconMarginRight = 0;
            this.ButtonNew.IconRightVisible = true;
            this.ButtonNew.IconRightZoom = 0D;
            this.ButtonNew.IconVisible = true;
            this.ButtonNew.IconZoom = 90D;
            this.ButtonNew.IsTab = false;
            this.ButtonNew.Location = new System.Drawing.Point(276, 7);
            this.ButtonNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonNew.Name = "ButtonNew";
            this.ButtonNew.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ButtonNew.OnHovercolor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonNew.OnHoverTextColor = System.Drawing.Color.Black;
            this.ButtonNew.selected = false;
            this.ButtonNew.Size = new System.Drawing.Size(86, 38);
            this.ButtonNew.TabIndex = 11;
            this.ButtonNew.Text = "New";
            this.ButtonNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonNew.Textcolor = System.Drawing.Color.White;
            this.ButtonNew.TextFont = new System.Drawing.Font("Century Gothic", 9.5F);
            this.ButtonNew.Click += new System.EventHandler(this.ButtonNew_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(179, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1, 48);
            this.flowLayoutPanel2.TabIndex = 13;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(267, 2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1, 48);
            this.flowLayoutPanel3.TabIndex = 14;
            // 
            // dgv_CategoryDetails
            // 
            this.dgv_CategoryDetails.AllowUserToAddRows = false;
            this.dgv_CategoryDetails.AllowUserToDeleteRows = false;
            this.dgv_CategoryDetails.AllowUserToResizeColumns = false;
            this.dgv_CategoryDetails.AllowUserToResizeRows = false;
            this.dgv_CategoryDetails.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_CategoryDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_CategoryDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_CategoryDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_CategoryDetails.ColumnHeadersHeight = 30;
            this.dgv_CategoryDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnCategory});
            this.dgv_CategoryDetails.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_CategoryDetails.Location = new System.Drawing.Point(0, 194);
            this.dgv_CategoryDetails.Name = "dgv_CategoryDetails";
            this.dgv_CategoryDetails.ReadOnly = true;
            this.dgv_CategoryDetails.RowHeadersVisible = false;
            this.dgv_CategoryDetails.Size = new System.Drawing.Size(846, 407);
            this.dgv_CategoryDetails.TabIndex = 7;
            this.dgv_CategoryDetails.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CategoryDetails_CellDoubleClick);
            this.dgv_CategoryDetails.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CategoryDetails_CellEnter);
            this.dgv_CategoryDetails.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_CategoryDetails_KeyDown);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "ID";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            // 
            // ColumnCategory
            // 
            this.ColumnCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCategory.HeaderText = "Category";
            this.ColumnCategory.Name = "ColumnCategory";
            this.ColumnCategory.ReadOnly = true;
            // 
            // lblTotalCategories
            // 
            this.lblTotalCategories.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalCategories.AutoSize = true;
            this.lblTotalCategories.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTotalCategories.Location = new System.Drawing.Point(632, 16);
            this.lblTotalCategories.Name = "lblTotalCategories";
            this.lblTotalCategories.Size = new System.Drawing.Size(140, 21);
            this.lblTotalCategories.TabIndex = 22;
            this.lblTotalCategories.Text = "Total Categories : 0";
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.dgv_CategoryDetails);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddCategory";
            this.Size = new System.Drawing.Size(846, 622);
            this.Load += new System.EventHandler(this.AddCategory_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddCategory_KeyDown);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CategoryDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton ButtonBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbleCategoryNotAvilable;
        private System.Windows.Forms.Label lblCategoryIsAvilable;
        private System.Windows.Forms.Label lblinstruction;
        private ChreneLib.Controls.TextBoxes.CTextBox TextboxAC_Category;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox Textboxcontainer;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton ButtonAdd;
        private Bunifu.Framework.UI.BunifuFlatButton ButtonUpdate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Bunifu.Framework.UI.BunifuFlatButton ButtonDelete;
        private Bunifu.Framework.UI.BunifuFlatButton ButtonNew;
        private System.Windows.Forms.DataGridView dgv_CategoryDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategory;
        private System.Windows.Forms.Label lblTotalCategories;
    }
}
