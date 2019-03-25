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
    public partial class Publisher : UserControl
    {
        public Publisher()
        {
            InitializeComponent();
        }

        #region [ Objects and Variables ]
        Lib.Publisher pub = new Lib.Publisher();
        Image backgroundImage;
        private string imagepath="";
        #endregion

        #region [ METHODS ]

        public void clear()
        {
            textbox_publisherid.Text = pub.getAutoIncrementId(); ;
            textbox_publishername.Text = "";
            textbox_phoneno.Text = "";
            textbox_address.Text = "";
            picBox_Image.Image = null;
            picBox_Image.BackgroundImage = backgroundImage;

        }
        public void filter()
        {
            if (textbox_publishername.Text == "")
            {
                MessageBox.Show("Please enter the first name of the publisher", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textbox_publishername.Focus();
                return;
            }
            else if (textbox_phoneno.Text == "")
            {
                MessageBox.Show("Please enter the phone no of the publisher", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textbox_address.Focus();
                return;
            }
            else if (textbox_address.Text == "")
            {
                MessageBox.Show("Please enter the address of the publisher", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textbox_address.Focus();
                return;
            }
        }
        public void GetData()
        {
            pub.Id = textbox_publisherid.Text;
            pub.Name = textbox_publishername.Text;
            pub.Address = textbox_address.Text;
            pub.Contact = textbox_phoneno.Text;
            if (imagepath != "")
            {
                pub.ImageBytes = Global.ConvertIntoBytes(imagepath);

            }
        }

        #endregion

        #region [ SOME EVENTS AND DELEGATES ]

        public event EventHandler CloseConnection;
        /// <summary>
        /// Signal to the subscriber to close the connection
        /// </summary>
        /// <param name="e"></param>
        private void ClosePublisherControl(EventArgs e)
        {
            EventHandler eh = CloseConnection;
            if (eh != null)
            {
                eh(this, e);
            }
        }

        private void Publisher_Load(object sender, EventArgs e)
        {
            backgroundImage = picBox_Image.BackgroundImage;
            textbox_publisherid.Text = pub.getAutoIncrementId();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            ClosePublisherControl(null);
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

        public void btn_add_Click(object sender, EventArgs e)
        {
            GetData();
            if (pub.Validate())
            {
                if (pub.AddPublisher())
                {
                    MessageBox.Show("publisher added succussfully", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    textbox_publishername.Focus();
                }
                else
                {
                    MessageBox.Show("Enable to add a publisher something may be wrong with the server\nplease call the your administrator", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                filter();
            }
        }

        #endregion
        
    }
}
