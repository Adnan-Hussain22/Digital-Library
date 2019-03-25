using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advanced_School_Manangement_System.Reuseables
{
    public partial class Librarian : UserControl
    {
        public Librarian(Details.Librarian_Details child)
        {
            InitializeComponent();
            this.child = child;
        }

        #region [ OBJECTS AND VARIABLES ]
        Details.Librarian_Details child;
        Lib.User_Info librarian = new Lib.User_Info();
        DataTable dt;
        private string imagepath="";
        #endregion

        #region [ PROPERTIES ]

        #endregion

        #region [ METHODS ]

        private void FillFeilds()
        {
            textbox_mainid.Text = child.Id;
            textbox_firstname.Text = child.FirstName;
            textbox_lastname.Text = child.LastName;
            textbox_contactno.Text = child.Contact;
            textbox_password.Text = child.Password;
            textbox_email.Text = child.Email;
            textbox_address.Text = child.Address;
            if (child.Gender != "")
            {
                if (child.Gender.Trim() == "Male")
                    radiobttnMale.Checked = true;
                else if (child.Gender == "Female")
                    radiobttnFemale.Checked = true;
                else
                    radioBttnOther.Checked = true;

            }
            if (child.ImageBytes != null)
            {
                picbox_image.BackgroundImage = null;
                picbox_image.Image = Global.ConvertIntoImage(child.ImageBytes);
            }
        }
        private void GetAllText()
        {
            librarian.MainId = textbox_mainid.Text;
            librarian.FirstName = textbox_firstname.Text;
            librarian.LastName = textbox_lastname.Text;
            librarian.Password = textbox_password.Text;
            librarian.Email = textbox_email.Text;
            librarian.ContactNo = textbox_contactno.Text;
            librarian.Address = textbox_address.Text;
            if (radiobttnMale.Checked == true)
                librarian.Gender = "Male";
            else if (radiobttnFemale.Checked == true)
                librarian.Gender = "Female";
            else if (radioBttnOther.Checked == true)
                librarian.Gender = "Other";

            if (imagepath != "") 
            {
                librarian.GetImageInBytes = Global.ConvertIntoBytes(imagepath);

            }
            else if (child.ImageBytes != null)
            {
                librarian.GetImageInBytes = child.ImageBytes;
            }
        }
        #endregion

        #region [ EVENTS AND DELEGATES ]

        public event EventHandler CloseConnection;
        public void CloseLibrarianControl(EventArgs e)
        {
            EventHandler eh = CloseConnection;
            if (eh != null)
            {
                eh(this, e);
            }
        }

        private void Librarian_Load(object sender, EventArgs e)
        {
            FillFeilds();
        }

        private void ButtnEdit_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Are you sure you want to update this record ?", Global.CaptionLib, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                GetAllText();
                librarian.MainId = textbox_mainid.Text;
                Global.check = librarian.UpdateUser();
                if (Global.check)
                {
                    MessageBox.Show("Record updated successfully", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CloseLibrarianControl(null);
                    return;
                }
                else
                {
                    MessageBox.Show("Failed to update the operator something may be wrong\nplease contact your administrator", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseLibrarianControl(null);
        }

        #endregion

        private void btn_upload_Click(object sender, EventArgs e)
        {
            string filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|svg files(*.svg)|*.svg|jpeg files(*.jpeg)|*.jpeg";
            imagepath = Global.GetFilePath(filter);
            if (imagepath != "")
            {
                picbox_image.BackgroundImage = null;
                picbox_image.ImageLocation = imagepath;
            }
        }
    }
}
