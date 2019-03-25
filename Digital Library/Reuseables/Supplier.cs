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
    public partial class Supplier : UserControl
    {
        Details.Suppliers_Detail child;
        public Supplier(Details.Suppliers_Detail child)
        {
            InitializeComponent();
            this.child = child;
        }
        #region [ Objects and Variables ]
        Lib.Supplier sup = new Lib.Supplier();
        string imagepath = "";
        #endregion

        #region [ METHODS ]

        public void getText()
        {
            sup.Id = textbox_supplierid.Text;
            sup.FirstName = textbox_firstname.Text;
            sup.LastName = textbox_lastname.Text;
            sup.Address = textbox_address.Text;
            sup.Contact = textbox_contactno.Text;
            if (imagepath != "")
            {
                sup.ImageBytes = Global.ConvertIntoBytes(imagepath);
            }
            else if (child.ImageBytes != null)
            {
                sup.ImageBytes = child.ImageBytes;
            }

        }

        public void FillFeilds()
        {
            textbox_supplierid.Text = child.Id;
            textbox_firstname.Text = child.FirstName;
            textbox_lastname.Text = child.LastName;
            textbox_contactno.Text = child.Contact;
            textbox_address.Text = child.Address;
            if (child.ImageBytes != null)
            {
                picBox_Image.BackgroundImage = null;
                picBox_Image.Image = Global.ConvertIntoImage(child.ImageBytes);
            }
        }

        #endregion

        #region [ SOME EVENTS AND DELEGATES ]

        public event EventHandler CloseConnection;
        /// <summary>
        /// Signal to the subscriber to close the connection
        /// </summary>
        /// <param name="e"></param>
        private void CloseSupplierEditControl(EventArgs e)
        {
            EventHandler eh = CloseConnection;
            if (eh != null)
            {
                eh(this, e);
            }
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            FillFeilds();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to update the record ?", Global.CaptionLib, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                getText();
                if (sup.Update())
                {
                    MessageBox.Show("Record updated succussfully", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CloseSupplierEditControl(null);
                }
                else
                {
                    MessageBox.Show("Enable to update a record something may be wrong with the server\nplease call the your administrator", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            return;
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

        private void btn_close_Click(object sender, EventArgs e)
        {
            CloseSupplierEditControl(null);
        }

        #endregion
    }
}
