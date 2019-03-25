using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital Library.Reuseables
{
    public partial class Book : UserControl
    {
    
        public Book(Details.Book_Details child)
        {
            InitializeComponent();
            this.child = child;
            //sub.EditControl+=new EventHandler(FillFeilds);
        }

        #region [ OBJECTS AND VARIABLES ]
        Lib.Book_Entry BE = new Lib.Book_Entry();
        private bool copiesIsNumber, isbnIsNumber, yearIsNumber, priceIsnumber;
        Details.Book_Details child;
        DataTable dt;
        private Image backgroudImage;
        private string imagepath="";
        #endregion

        #region [ METHODS ]

        private void FillFeilds()
        {
            textbox_mainid.Text = child.Id;
            textbox_title.Text = child.Title;
            textbox_author.Text = child.Author;
            textbox_edition.Text = child.Edition;
            textbox_details.Text = child.Details;
            hiddenfeild_category.SelectedItem = child.Category;
            CmbCategory.SelectedIndex = hiddenfeild_category.SelectedIndex + 2;
            hiddenfeild_subject.SelectedItem = child.Subject;
            CmbSubject.SelectedIndex = hiddenfeild_subject.SelectedIndex + 2;
            textbox_ISBN.Text = child.ISBN.ToString();
            hiddenfeild_publisher.SelectedItem = child.Publisher;
            CmbPublisher.SelectedIndex = hiddenfeild_publisher.SelectedIndex + 1;
            hiddenfeild_supplier.SelectedItem = child.Supplier;
            CmbSupplier.SelectedIndex = hiddenfeild_supplier.SelectedIndex + 1;
            textbox_noofcopies.Text = child.NoOfCopies.ToString();
            textbox_price.Text = child.Price.ToString();
            textbox_publishyear.Text = child.PublicationYear.ToString();
            if (child.ImageBytes != null)
            {
                picBox_Image.BackgroundImage = null;
                picBox_Image.Image = Global.ConvertIntoImage(child.ImageBytes);
            }
        }

        private void LoadCategory()
        {
            dt = new DataTable();
            dt = BE.LoadCategory();
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

        private void LoadSubject()
        {
            dt = new DataTable();
            dt = BE.GetSubjects();
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
            foreach (DataRow dr in dt.Rows)
            {
                CmbPublisher.Items.Add(dr["Pub_PublisherName"]);
                hiddenfeild_publisher.Items.Add(dr["Pub_MainId"]);
            }
        }

        private void ClearAll()
        {
            textbox_mainid.Text = BE.GetBookId();
            textbox_noofcopies.Text = "";
            textbox_title.Text = "";
            CmbCategory.SelectedItem = null;
            //CmbClass.SelectedItem = null;
            CmbSubject.SelectedItem = null;
            textbox_author.Text = "";
            textbox_edition.Text = "";
            textbox_details.Text = "";
            textbox_ISBN.Text = "";
            textbox_publishyear.Text = "";
            textbox_price.Text = "";
        }
        private void GetText()
        {
            BE.BookIdMain = textbox_mainid.Text;
            BE.Title = textbox_title.Text;
            if (textbox_noofcopies.Text != "")
            {
                if (Global.IsAllNumbers(textbox_noofcopies.Text))
                {
                    BE.NoOfCopies = int.Parse(textbox_noofcopies.Text);
                    copiesIsNumber = true;
                }
                else
                {
                    copiesIsNumber = false;
                    return;
                }

            }
            BE.Author = textbox_author.Text;
            BE.Edition = textbox_edition.Text;
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
            if (textbox_publishyear.Text != "")
            {
                if (Global.IsAllNumbers(textbox_publishyear.Text))
                {
                    BE.YearofPublish = int.Parse(textbox_publishyear.Text);
                    yearIsNumber = true;
                }
                else
                {
                    yearIsNumber = false;
                    return;
                }

            }
            if (textbox_price.Text != "")
            {
                if (Global.IsAllNumbers(textbox_price.Text))
                {
                    BE.Price = int.Parse(textbox_price.Text);
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
            else if (child.ImageBytes != null)
            {
                BE.GetImageInBytes = child.ImageBytes;
            }
            BE.Details = textbox_details.Text;
        }

        #endregion

        #region [ SOME EVENT AND DELEGATES ]
        /// <summary>
        /// To initilize an event signal to close the child control
        /// </summary>
        public event EventHandler DataAvailable;
        /// <summary>
        /// Singnal to the subscriber to close the control
        /// </summary>
        /// <param name="e"></param>
        public void OnDataAvailable(EventArgs e)
        {
            EventHandler eh = DataAvailable;
            if (eh != null)
            {
                eh(this, e);
            }
        }
        public event EventHandler CloseConnection;
        public void CloseEditBookControl(EventArgs e)
        {
            EventHandler eh = CloseConnection;
            if (eh != null)
            {
                eh(this, e);
            }
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

        private void Book_Load(object sender, EventArgs e)
        {
           backgroudImage = picBox_Image.BackgroundImage;
            LoadCategory();
            LoadPublisher();
            LoadSupplier();
            LoadSubject();
            FillFeilds();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseEditBookControl(null);
        }

        private void BttnEdit_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Are you sure you want to update " + textbox_mainid.Text + " ?", Global.CaptionLib, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                GetText();
                Global.check = BE.UpdateBook();
                if (Global.check)
                {
                    MessageBox.Show("Book " + textbox_title.Text + " updated successfully", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAll();
                    CloseEditBookControl(null);
                    return;
                }
                else
                {
                    MessageBox.Show("Enable to update the record something may be wrong\nPlease contact you administrator", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
                return;
        }

        #endregion


    }
}
