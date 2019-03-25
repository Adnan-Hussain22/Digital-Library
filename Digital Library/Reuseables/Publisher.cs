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
    public partial class Publisher : UserControl
    {
        Details.Publishers_Detail child;
        public Publisher(Details.Publishers_Detail child)
        {
            InitializeComponent();
            this.child = child;
        }

        #region [ OBJECTS AND VARIABLES ]
        Lib.Publisher pub = new Lib.Publisher();
        string imagepath = "";
        #endregion

        #region [ METHODS ]

        public void GetText()
        {
            pub.Id = textbox_publisherid.Text;
            pub.Name = textbox_publishername.Text;
            pub.Contact = textbox_contactno.Text;
            pub.Address = textbox_address.Text;
            if (imagepath != "")
            {
                pub.ImageBytes = Global.ConvertIntoBytes(imagepath);
            }
            else if (child.ImageBytes != null)
            {
                pub.ImageBytes = child.ImageBytes;
            }
        }

        public void FillFeilds()
        {
            textbox_publisherid.Text = child.Id;
            textbox_publishername.Text = child.PubName;
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
        public void CloseEditpublisherControl(EventArgs e)
        {
            EventHandler eh = CloseConnection;
            if (eh != null)
            {
                eh(this, e);
            }
        }

        private void BttnEdit_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Are you sure you want to update " + textbox_publisherid.Text + " ?", Global.CaptionLib, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                GetText();
                Global.check = pub.Update();
                if (Global.check)
                {
                    MessageBox.Show("Book " + textbox_publisherid.Text + " updated successfully", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CloseEditpublisherControl(null);
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

        private void Publisher_Load(object sender, EventArgs e)
        {
            FillFeilds();
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
            CloseEditpublisherControl(null);
        }

        #endregion

    }
}
