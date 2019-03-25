using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital Library
{
    public partial class AddBooks : UserControl
    {
        public AddBooks()
        {
            InitializeComponent();
        }
        #region [ Objects and Variables ]
        Lib.Book_Entry BE = new Lib.Book_Entry();
        Form f = new Form();
        Reuseables.Add_Specific AddSpecific;
        Reuseables.Select_Multiple SelectMultiple;
        Lib.QR_Generator qr = new Lib.QR_Generator();
        bool copiesIsNumber = false, isbnIsNumber = false, yearIsNumber = false, priceIsnumber = false;
        Image picbox;
        //OpenFileDialog filedilog = new OpenFileDialog();
        DataTable dt;
        private string imagepath = "", backgrounimagepath;
        #endregion
        //////////////////////

        #region [ METHODS ]

        private void ClearAll()
        {
            textbox_mainid.Text = BE.GetBookId();
            textbox_noofcopies.Text = "";
            textbox_title.Text = "";
            CmbCategory.SelectedIndex = 0;
            //CmbClass.SelectedItem = null;
            CmbSubject.SelectedIndex = 0;
            CmbPublisher.SelectedIndex = 0;
            CmbSupplier.SelectedIndex = 0;
            textbox_author.Text = "";
            textbox_edition.Text = "";
            textbox_details.Text = "";
            textbox_ISBN.Text = "";
            textbox_publishyear.Text = "";
            textbox_price.Text = "";
            picBox_Image.Image = null;
            picBox_Image.BackgroundImage = picbox;
        }

        private void GetAllData()
        {
            BE.BookIdMain = textbox_mainid.Text;
            BE.Title = textbox_title.Text.Trim();
            //BE.Author = textbox_author.Text;
            if (textbox_noofcopies.Text.Trim() != "")
            {
                if (Global.IsAllNumbers(textbox_noofcopies.Text.Trim()))
                {
                    BE.NoOfCopies = int.Parse(textbox_noofcopies.Text.Trim());
                    copiesIsNumber = true;
                }
                else
                {
                    copiesIsNumber = false;
                    return;
                }

            }
            BE.Edition = textbox_edition.Text.Trim();
            //getting the seleted items from combo to hidden feilds
            if (CmbSubject.SelectedIndex > 1)
            {
                hiddenfeild_subject.SelectedIndex = (CmbSubject.SelectedIndex) - 2;
                BE.SubjectId = int.Parse(hiddenfeild_subject.SelectedItem.ToString());
            }
            if (CmbCategory.SelectedIndex > 1)
            {
                hiddenfeild_category.SelectedIndex = (CmbCategory.SelectedIndex) - 2;
                BE.CategoryId = int.Parse(hiddenfeild_category.SelectedItem.ToString());
            }
            if (CmbPublisher.SelectedIndex > 0)
            {
                hiddenfeild_publisher.SelectedIndex = (CmbPublisher.SelectedIndex) - 1;
                BE.Publisher = hiddenfeild_publisher.SelectedItem.ToString();
            }
            if (CmbSupplier.SelectedIndex > 0)
            {
                hiddenfeild_supplier.SelectedIndex = (CmbSupplier.SelectedIndex) - 1;
                BE.Supplier = hiddenfeild_supplier.SelectedItem.ToString();
            }
            //if(cmb_shelf.SelectedIndex > 0)
            //{
            //    BE.ShelfMainId = cmb_shelf.SelectedItem.ToString();
            //}
            if (cmb_editor.SelectedIndex > 2)
            {
                BE.EditorId = null;
                hiddenfeild_editor.SelectedIndex = cmb_editor.SelectedIndex - 3;
                BE.EditorId = new int[1];
                BE.EditorId[0] = Convert.ToInt32(hiddenfeild_editor.SelectedItem);
            }
            if (textbox_ISBN.Text != "")
            {
                if (Global.IsAllNumbers(textbox_ISBN.Text))
                {
                    BE.ISBN = long.Parse(textbox_ISBN.Text);
                    isbnIsNumber = true;
                }
                else
                {
                    isbnIsNumber = false;
                    return;
                }

            }
            if (textbox_publishyear.Text.Trim() != "")
            {
                if (Global.IsAllNumbers(textbox_publishyear.Text.Trim()))
                {
                    BE.YearofPublish = int.Parse(textbox_publishyear.Text.Trim());
                    yearIsNumber = true;
                }
                else
                {
                    yearIsNumber = false;
                    return;
                }

            }
            if (textbox_price.Text.Trim() != "")
            {
                if (Global.IsAllNumbers(textbox_price.Text.Trim()))
                {
                    BE.Price = int.Parse(textbox_price.Text.Trim());
                    priceIsnumber = true;
                }
                else
                {
                    priceIsnumber = false;
                    return;
                }

            }
            if (imagepath != "")
            {
                BE.GetImageInBytes = Global.ConvertIntoBytes(imagepath);

            }
            BE.Details = textbox_details.Text;
        }
        private void LoadCategory()
        {
            dt = new DataTable();
            dt = BE.LoadCategory();
            CmbCategory.Items.Clear();
            CmbCategory.Items.Add("Select an appropriate category");
            CmbCategory.Items.Add("Add specific category");
            foreach (DataRow dr in dt.Rows)
            {
                CmbCategory.Items.Add(dr["Cat_BookCategory"]);
                hiddenfeild_category.Items.Add(dr["Cat_Id"]);
            }
        }

        //Since class concept is now Obsolete

        //private void LoadClass()
        //{

        //    dt = new DataTable();
        //    dt = BE.GetClasses();
        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        CmbClass.Items.Add(dr["Class_Name"]);
        //    }
        //}

        private void LoadEditors()
        {
            dt = new DataTable();
            dt = BE.GetEditors();
            cmb_editor.Items.Clear();
            cmb_editor.Items.Add("Select editors");
            cmb_editor.Items.Add("Add new editors");
            cmb_editor.Items.Add("Select multiple");
            foreach (DataRow dr in dt.Rows)
            {
                hiddenfeild_editor.Items.Add(dr["Id"]);
                cmb_editor.Items.Add(dr["Name"]);
            }
        }

        private void LoadSubject()
        {
            dt = new DataTable();
            dt = BE.GetSubjects();
            CmbSubject.Items.Clear();
            CmbSubject.Items.Add("Select an appropriate subject");
            CmbSubject.Items.Add("Add specific subject");
            foreach (DataRow dr in dt.Rows)
            {
                CmbSubject.Items.Add(dr["Sub_BookSubject"]);
                hiddenfeild_subject.Items.Add(dr["Sub_Id"]);
            }
        }

        private void LoadSupplier()
        {
            var sup = new Lib.Supplier();
            dt = new DataTable();
            dt = sup.getSuppliers();
            CmbSupplier.Items.Clear();
            CmbSupplier.Items.Add("Select an appropriate supplier");
            foreach (DataRow dr in dt.Rows)
            {
                CmbSupplier.Items.Add(dr["Supp_FirstName"]);
                hiddenfeild_supplier.Items.Add(dr["Supp_MainId"]);
            }
        }

        private void LoadPublisher()
        {
            var pub = new Lib.Publisher();
            dt = new DataTable();
            dt = pub.getPublishers();
            CmbPublisher.Items.Clear();
            CmbPublisher.Items.Add("Select an appropriate publisher");
            foreach (DataRow dr in dt.Rows)
            {
                CmbPublisher.Items.Add(dr["Pub_PublisherName"]);
                hiddenfeild_publisher.Items.Add(dr["Pub_MainId"]);
            }
        }
        private void filter()
        {
            if (textbox_title.Text.Trim() == "")
            {
                MessageBox.Show("Please give Book title ", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textbox_title.Focus();
                return;
            }
            else if (CmbSubject.SelectedIndex <= 1)
            {
                MessageBox.Show("Please select the subject ", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CmbSubject.Focus();
                return;
            }
            else if (CmbCategory.SelectedIndex <= 1)
            {
                MessageBox.Show("Please select the category ", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CmbCategory.Focus();
                return;
            }
            //else if (cmb_shelf.SelectedIndex <= 1)
            //{
            //    MessageBox.Show("Please select the shelf or add new one", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    cmb_shelf.Focus();
            //    return;
            //}
            else if (textbox_noofcopies.Text.Trim() == "")
            {
                MessageBox.Show("Please give no of copies of the book", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textbox_noofcopies.Focus();
                return;
            }
            else if (!copiesIsNumber)
            {
                MessageBox.Show("No of copies should be a number greater than zero", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textbox_noofcopies.Focus();
            }
            else if (cmb_editor.SelectedIndex < 2 && BE.EditorId != null)
            {
                MessageBox.Show("Please select the editor", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmb_editor.Focus();
                return;
            }
            //else if (textbox_author.Text == "")
            //{
            //    MessageBox.Show("Please give author name ", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    textbox_author.Focus();
            //    return;
            //}
            else if (CmbSupplier.SelectedIndex <= 0)
            {
                MessageBox.Show("Please give supplier of the book", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CmbSupplier.Focus();
                return;
            }
            else if (textbox_edition.Text.Trim() == "")
            {
                MessageBox.Show("Please give book edition ", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textbox_edition.Focus();
                return;
            }
            else if (CmbPublisher.SelectedIndex <= 0)
            {
                MessageBox.Show("Please publisher book edition ", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CmbPublisher.Focus();
                return;
            }
            else if (textbox_ISBN.Text.Trim() == "")
            {
                MessageBox.Show("Please publisher book edition ", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textbox_ISBN.Focus();
                return;
            }
            else if (!isbnIsNumber || BE.ISBN == 0)
            {
                MessageBox.Show("ISBN should be a number greater than zero", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textbox_ISBN.Focus();
            }
        }

        private void ShowAddSpecificControl(Control control)
        {
            TableLayoutPanel table = new TableLayoutPanel();
            table.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            table.Size = control.Size;
            table.Height += 9;
            table.Width += 9;
            table.Controls.Add(control);
            f.FormBorderStyle = FormBorderStyle.None;
            f.StartPosition = FormStartPosition.CenterParent;
            f.Size = table.Size;
            f.Controls.Add(table);
            control.Dock = DockStyle.Fill;
            table.BringToFront();
            f.BringToFront();
            f.ShowDialog();
        }

        //private void ShowAddShelfControl()
        //{
        //    f.FormBorderStyle = FormBorderStyle.None;
        //    f.StartPosition = FormStartPosition.CenterParent;
        //    f.Controls.Add(Shelf);
        //    f.Size = Shelf.Size;
        //    Shelf.Dock = DockStyle.Fill;
        //    Shelf.BringToFront();
        //    f.BringToFront();
        //    f.ShowDialog();
        //}

        #endregion

        #region [ SOME EVENTS AND DELEGATES ]

        public event EventHandler CloseConnection;
        public void CloseBookControl(EventArgs e)
        {
            EventHandler eh = CloseConnection;
            if (eh != null)
            {
                eh(this, e);
            }
        }

        //private void LoadShelf()
        //{
        //    dt = new DataTable();
        //    dt = BE.GetAvailableShelf();
        //    cmb_shelf.Items.Clear();
        //    cmb_shelf.Items.Add("Select a shelf");
        //    cmb_shelf.Items.Add("Add specific");
        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        cmb_shelf.Items.Add(dr["SHELF"]);
        //    }
        //}

        private void AddNewBook_Load(object sender, EventArgs e)
        {
            textbox_title.Focus();
            //LoadShelf();
            LoadEditors();
            LoadCategory();
            LoadSubject();
            LoadSupplier();
            LoadPublisher();
            picbox = picBox_Image.BackgroundImage;
            textbox_mainid.Text = BE.GetBookId();
            //textbox_shelfid.Text = BE.GetShelfId();
            CmbCategory.SelectedIndex = 0;
            CmbSubject.SelectedIndex = 0;
            CmbSupplier.SelectedIndex = 0;
            CmbPublisher.SelectedIndex = 0;
            cmb_editor.SelectedIndex = 0;
            cmb_shelf.SelectedIndex = 0;
        }

        private void ButtonNew_Click(object Sender, EventArgs e)
        {
            ClearAll();
        }

        private void BttnBack_Click(object sender, EventArgs e)
        {
            CloseBookControl(null);
        }

        #region KeyDown Events
        private void TextboxNoOfCopies_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                textbox_title.Focus();
            }
            else if (e.Alt == true && e.KeyCode == Keys.Left)
            {
                BttnBack_Click(sender, e);
            }
        }

        private void TextboxBookName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                CmbCategory.Focus();
            }
            else if (e.Alt == true && e.KeyCode == Keys.Left)
            {
                BttnBack_Click(sender, e);
            }
        }

        private void CmbCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                CmbSubject.Focus();
            }
            else if (e.Alt == true && e.KeyCode == Keys.Left)
            {
                BttnBack_Click(sender, e);
            }
        }

        private void CmbSubject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                //CmbClass.Focus();
            }
            else if (e.Alt == true && e.KeyCode == Keys.Left)
            {
                BttnBack_Click(sender, e);
            }
        }

        private void CmbAddBk_Class_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                textbox_author.Focus();
            }
            else if (e.Alt == true && e.KeyCode == Keys.Left)
            {
                BttnBack_Click(sender, e);
            }
        }

        private void CmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbSubject.SelectedIndex == 1)
            {
                AddSpecific = new Reuseables.Add_Specific("Subject");
                AddSpecific.CloseConnection += new EventHandler(CloseAddSpecificControl);
                ShowAddSpecificControl(AddSpecific);
                LoadSubject();
            }
        }

        private void CmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbCategory.SelectedIndex == 1)
            {
                AddSpecific = new Reuseables.Add_Specific("Category");
                AddSpecific.CloseConnection += new EventHandler(CloseAddSpecificControl);
                ShowAddSpecificControl(AddSpecific);
                LoadCategory();
            }
        }

        private void cmb_shelf_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmb_shelf.SelectedIndex == 1)
            //{
            //    Shelf = new Reuseables.Shelf();
            //    Shelf.CloseConnection += new EventHandler(CloseAddSpecificControl);
            //ShowAddShelfControl();
            //    LoadShelf();
            //}
        }

        private void CloseAddSpecificControl(object sender, EventArgs e)
        {
            Control child = sender as Control;
            if (child != null)
            {
                f.Controls.Remove(child);
                f.Close();
            }
        }

        private void TextboxAuthor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                textbox_edition.Focus();
            }
            else if (e.Alt == true && e.KeyCode == Keys.Left)
            {
                BttnBack_Click(sender, e);
            }
            else if (e.Control == true && e.KeyCode == Keys.A)
            {
                if (btn_uplaodimage.Enabled == true)
                {
                    BttnAdd_Click(sender, e);
                }
            }
        }

        private void cmb_editor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_editor.SelectedIndex == 1)
            {
                AddSpecific = new Reuseables.Add_Specific("Editor");
                AddSpecific.CloseConnection += new EventHandler(CloseAddSpecificControl);
                ShowAddSpecificControl(AddSpecific);
                LoadEditors();
            }
            else if (cmb_editor.SelectedIndex == 2)
            {
                SelectMultiple = new Reuseables.Select_Multiple();
                SelectMultiple.DataAvailable += new EventHandler(EditorsDataAvailable);
                SelectMultiple.CloseConnection += new EventHandler(CloseAddSpecificControl);
                ShowAddSpecificControl(SelectMultiple);
            }
        }

        private void EditorsDataAvailable(object sender, EventArgs e)
        {
            BE.EditorId = SelectMultiple.SelectedItems;
        }

        private void btn_uplaodimage_Click(object sender, EventArgs e)
        {
            string filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|svg files(*.svg)|*.svg|jpeg files(*.jpeg)|*.jpeg";
            imagepath = Global.GetFilePath(filter);
            if (imagepath != "")
            {
                picBox_Image.BackgroundImage = null;
                picBox_Image.ImageLocation = imagepath;
            }
        }

        private void TextboxEdition_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                textbox_details.Focus();
            }
            else if (e.Alt == true && e.KeyCode == Keys.Left)
            {
                BttnBack_Click(sender, e);
            }
        }
        #endregion

        private void TextboxDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.A)
            {
                BttnAdd_Click(sender, e);
            }
            else if (e.Alt == true && e.KeyCode == Keys.Left)
            {
                BttnBack_Click(sender, e);
            }
        }

        private void BttnAdd_Click(object sender, EventArgs e)
        {
            GetAllData();
            if (!BE.Filter(""))
            {
                filter();
            }
            else
            {
                Global.check = BE.AddBook();
                if (Global.check)
                {
                    MessageBox.Show("Book " + textbox_mainid.Text + " added successfully", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult dr = MessageBox.Show("Do you want to print it qr code now ?", Global.CaptionLib, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        qr.EncodeIntoQRCode(textbox_mainid.Text, false);
                        qr.PrintQrCode();
                    }
                    else
                    {
                        qr.EncodeIntoQRCode(textbox_mainid.Text, true);
                        qr.SaveQrCode();
                    }
                    ClearAll();
                    textbox_title.Focus();
                    return;
                }
                else
                    MessageBox.Show("Failed!!", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
    #endregion


}
