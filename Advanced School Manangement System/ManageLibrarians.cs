using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Advanced_School_Manangement_System
{
    public partial class ManageLibrarians : UserControl
    {
        public ManageLibrarians()
        {
            InitializeComponent();
        }

        #region [ OBJECTS AND VARIABLES ]
        Lib.User_Info User = new Lib.User_Info();
        private string imagepath = "";
        private Image backgoundimage;
        #endregion

        #region [ PROPERTIES ]

        #endregion

        #region [ METHODS ]

        private void GetData()
        {
            User.MainId = textbox_mainid.Text;
            User.FirstName = textbox_firstname.Text;
            User.LastName = textbox_lastname.Text;
            User.Password = textbox_password.Text;
            User.Email = textbox_email.Text;
            User.ContactNo = textbox_contactno.Text;
            User.Address = textbox_address.Text;
            if (radiobttnMale.Checked == true)
                User.Gender = "Male";
            else if (radiobttnFemale.Checked == true)
                User.Gender = "Female";
            else if (radioBttnOther.Checked == true)
                User.Gender = "Other";
            if (radiobtn_librarian.Checked == true)
                User.UserType = "Librarian";
            else
                User.UserType = "admin";
            if (imagepath != "")
            {
                User.GetImageInBytes = Global.ConvertIntoBytes(imagepath);

            }
        }
        private void Validation()
        {
            if (textbox_firstname.Text == "")
            {
                MessageBox.Show("Please enter first name", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textbox_firstname.Focus();
                return;
            }
            if (textbox_lastname.Text == "")
            {
                MessageBox.Show("Please enter last name", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textbox_firstname.Focus();
                return;
            }
            else if (textbox_password.Text == "")
            {
                MessageBox.Show("Please enter password", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textbox_password.Focus();
                return;
            }
            else if (textbox_email.Text == "")
            {
                MessageBox.Show("Please enter email", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textbox_email.Focus();
                return;
            }
            else if (textbox_contactno.Text == "")
            {
                MessageBox.Show("Please enter contact no", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textbox_contactno.Focus();
                return;
            }
            else if (textbox_address.Text == "")
            {
                MessageBox.Show("Please enter addrees", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textbox_address.Focus();
                return;
            }
        }
        private void ClearAll()
        {
            textbox_mainid.Text = User.GetMainId();
            textbox_password.Text = "";
            textbox_firstname.Text = "";
            textbox_lastname.Text = "";
            textbox_email.Text = "";
            textbox_contactno.Text = "";
            textbox_address.Text = "";
            picbox_image.Image = null;
            picbox_image.BackgroundImage = backgoundimage;
        }

        #endregion

        #region [ EVENTS AND DELEGATES ]

        private void btn_add_Click(object sender, EventArgs e)
        {
            GetData();
            if (!User.Validation())
            {
                Validation();
            }
            else
            {
                Global.check = User.AddLibrarian();
                if (Global.check)
                {
                    MessageBox.Show(textbox_firstname.Text + " " + textbox_lastname.Text + " you are successfully create as a librarian of library your id is " + textbox_mainid.Text + " please remember it", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAll();
                    return;
                }
                else
                {
                    MessageBox.Show("Failed to create operation something may be wrong\nplease contact your administrator", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

        }

        private void ManageLibrarian_Load(object sender, EventArgs e)
        {
            radiobttnMale.Checked = true;
            radiobtn_librarian.Checked = true;
            textbox_mainid.Text = User.GetMainId();
            backgoundimage = picbox_image.BackgroundImage;
            textbox_firstname.Focus();
        }

        public event EventHandler CloseConnection;
        /// <summary>
        /// Signal to the subscriber to close the connection
        /// </summary>
        /// <param name="e"></param>
        private void CloseManageOperators(EventArgs e)
        {
            EventHandler eh = CloseConnection;
            if (eh != null)
            {
                eh(this, e);
            }
        }

        private void ButtnNew_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            CloseManageOperators(null);
        }

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

        #endregion

        #region Operator Details


        private void TextboxOperatorName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                textbox_password.Focus();
            }
        }

        private void TextboxOperatorPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textbox_email.Focus();
            }
        }

        private void TextboxEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textbox_contactno.Focus();
            }
        }

        private void TextboxContactNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //cmbUserType.Focus();
            }
        }

        private void radiobttnMale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                radiobttnFemale.Focus();
            }
        }

        private void radiobttnFemale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                radiobttnMale.Focus();
            }
          else if (e.KeyCode == Keys.Right)
            {
                radioBttnOther.Focus();
            }
        }
        #endregion
    }
}
