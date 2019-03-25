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
    public partial class Member : UserControl
    {
        Details.Member_Details memb; 
        public Member(Details.Member_Details child)
        {
            InitializeComponent();
            memb = child;
        }
        #region [ OBJECTS AND VARIABLES ]
        Lib.Student Std = new Lib.Student();
        string imagepath = "";
        #endregion

        #region [ METHODS ]
        private void GetAllText()
        {
            Std.MemberId = textbox_mainid.Text;
            Std.FirstName = textbox_firstname.Text;
            Std.LastName = textbox_lastname.Text;
            Std.MemberContact = textbox_contactno.Text;
            Std.MemberEmail = textbox_email.Text;
            Std.CNIC = textbox_Cnic.Text;
            if (imagepath != "")
            {
                Std.ImageBytes = Global.ConvertIntoBytes(imagepath);
            }
            else if (memb.ImageBytes != null)
            {
                Std.ImageBytes = memb.ImageBytes;
            }
        }

        private void FillFeilds()
        {
            textbox_mainid.Text = memb.Id;
            textbox_firstname.Text = memb.FirstName;
            textbox_lastname.Text = memb.LastName;
            textbox_contactno.Text = memb.Contact;
            textbox_email.Text = memb.Email;
            textbox_Cnic.Text = memb.CNIC;
            if (memb.ImageBytes != null)
            {
                picbox_image.BackgroundImage = null;
                picbox_image.Image = Global.ConvertIntoImage(memb.ImageBytes);
            }
        }
        #endregion

        #region [ PROPERTIES ]


        #endregion

        #region [ SOME EVENTS AND DELEGATES ]

        public event EventHandler CloseConnection;
        /// <summary>
        /// Signal to the subscriber to close the control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseControl(EventArgs e)
        {
            EventHandler eh = CloseConnection;
            if (eh != null)
            {
                eh(this, e);
            }
        }
        private void ButtnUpdate_Click(object sender, EventArgs e)
        {
            GetAllText();
            DialogResult dr;
            dr = MessageBox.Show("Are you sure you want to update " + textbox_mainid.Text + " ?", Global.CaptionLib, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                Global.check = Std.UpdateStudent();
                if (Global.check)
                {
                    MessageBox.Show("Record " + textbox_mainid.Text + " successfully updated", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CloseControl(null);
                    return;
                }
                else
                {
                    MessageBox.Show("Failed to update record" + textbox_mainid.Text + "something may be wrong\nplease contact your administrator", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else
                return;
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            CloseControl(null);
        }

        private void Member_Load(object sender, EventArgs e)
        {
            FillFeilds();
        }

        private void btn_uplaodimage_Click(object sender, EventArgs e)
        {
            string filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|svg files(*.svg)|*.svg|jpeg files(*.jpeg)|*.jpeg";
            imagepath = Global.GetFilePath(filter);
            if (imagepath != "")
            {
                picbox_image.BackgroundImage = null;
                picbox_image.ImageLocation = imagepath;
            }
        }

        #endregion

    }
}
