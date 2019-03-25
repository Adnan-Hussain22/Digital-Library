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
    public partial class Supplier : UserControl
    {
        public Supplier()
        {
            InitializeComponent();
        }

        #region [ Objects and Variables ]
        Lib.Supplier sup = new Lib.Supplier();
        string imagepath = "";
        Image backgroundimage;
        #endregion

        #region [ METHODS ]

        public void clear()
        {
            textbox_supplierid.Text = sup.getAutoincrementId(); ;
            textbox_firstname.Text = "";
            textbox_lastname.Text = "";
            textbox_address.Text = "";
            textbox_phoneno.Text = "";
            picBox_Image.Image = null;
            picBox_Image.BackgroundImage = backgroundimage;
        }
        public void filter()
        {
            if (textbox_firstname.Text == "")
            {
                MessageBox.Show("Please first enter the first name of the supplier", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textbox_firstname.Focus();
                return;
            }
            else if (textbox_lastname.Text == "")
            {
                MessageBox.Show("Please first enter the last name of the supplier", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textbox_lastname.Focus();
                return;
            }
            else if (textbox_address.Text == "")
            {
                MessageBox.Show("Please first enter the address of the supplier", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textbox_address.Focus();
                return;
            }
        }
        public void GetData()
        {
            sup.Id = textbox_supplierid.Text;
            sup.FirstName = textbox_firstname.Text;
            sup.LastName = textbox_lastname.Text;
            sup.Address = textbox_address.Text;
            sup.Contact = textbox_phoneno.Text;
            if (imagepath != "")
            {
                sup.ImageBytes = Global.ConvertIntoBytes(imagepath);
            }
        }

        #endregion

        #region [ SOME EVENTS AND DELEGATES ]

        public event EventHandler CloseConnection;
        /// <summary>
        /// Signal to the subscriber to close the connection
        /// </summary>
        /// <param name="e"></param>
        private void CloseSupplierControl(EventArgs e)
        {
            EventHandler eh = CloseConnection;
            if (eh != null)
            {
                eh(this, e);
            }
        }

        public void btn_add_Click(object sender, EventArgs e)
        {
            GetData();
            if (sup.Validate())
            {
                if (sup.AddSupplier())
                {
                    MessageBox.Show("Supplier added succussfully", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    textbox_firstname.Focus();
                }
                else
                {
                    MessageBox.Show("Enable to add a supplier something may be wrong with the server\nplease call the your administrator", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                filter();
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

        private void Supplier_Load(object sender, EventArgs e)
        {
            backgroundimage = picBox_Image.BackgroundImage;
           textbox_supplierid.Text = sup.getAutoincrementId();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            CloseSupplierControl(null);
        }

        #endregion

    }
}
