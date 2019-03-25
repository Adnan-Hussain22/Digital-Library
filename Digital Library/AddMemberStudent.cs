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
    public partial class AddMember : UserControl
    {
        public AddMember()
        {
            InitializeComponent();
        }
        #region [OBJECTS AND VARIABLES ]
        Lib.Student Std = new Lib.Student();
        Lib.QR_Generator qr = new Lib.QR_Generator();
        string imagepath = "";
        Image backgroundImage;
        bool isMembershipAuto = Properties.Settings.Default.switchMembership;
        #endregion

        #region [ METHODS ]
        private void InitializeDate()
        {
            date_expiredate.Format = DateTimePickerFormat.Custom;
            date_expiredate.CustomFormat = "MM/dd/yyyyy";
            date_expiredate.MinDate = DateTime.Parse(textbox_joindate.Text).AddDays(1);
        }

        /// <summary>
        /// method to show the dates by manual method or by auto method,
        /// the method is decided on the basis of settings
        /// </summary>
        private void ShowDates()
        {
            textbox_joindate.Text = (Global.GetNetworkTime()).ToString();
            if (isMembershipAuto)
            {
                textbox_expiredate.Visible = true;
                textbox_expiredatecontainer.Visible = true;
                date_expiredate.Visible = false;
                var joindate = DateTime.Parse(textbox_joindate.Text);
                var x = Properties.Settings.Default.MembershipOption;
                switch (x)
                {
                    case "Days":
                        {
                            textbox_expiredate.Text = (joindate.AddDays(Properties.Settings.Default.IssueOptionCount)).ToString();
                            break;
                        }
                    case "Weeks":
                        {
                            textbox_expiredate.Text = (joindate.AddDays(Properties.Settings.Default.IssueOptionCount * 7)).ToString();
                            break;
                        }
                    case "Months":
                        {
                            textbox_expiredate.Text = (joindate.AddMonths(Properties.Settings.Default.IssueOptionCount)).ToString();
                            break;
                        }
                    case "Years":
                        {
                            textbox_expiredate.Text = (joindate.AddYears(Properties.Settings.Default.IssueOptionCount)).ToString();
                            break;
                        }
                }
                //if(Properties.Settings.Default.MembershipOption == "1 year")
                //{
                //    textbox_expiredate.Text = joindate.AddDays(360).ToString();
                //}
                //else if(Properties.Settings.Default.MembershipOption == "1 week")
                //{
                //    textbox_expiredate.Text = joindate.AddDays(7).ToString();
                //}
                //else if(Properties.Settings.Default.MembershipOption == "1 month")
                //{
                //    textbox_expiredate.Text = joindate.AddDays(30).ToString();
                //}
            }
            else
            {
                textbox_expiredate.Visible = false;
                textbox_expiredatecontainer.Visible = false;
                date_expiredate.Visible = true;
            }
        }

        private void GetData()
        {
            Std.MemberId = textbox_mainid.Text;
            Std.FirstName = textbox_firstname.Text;
            Std.LastName = textbox_lastname.Text;
            Std.MemberContact = textbox_contactno.Text;
            Std.MemberEmail = textbox_email.Text;
            Std.CNIC = textbox_Cnic.Text;
            Std.DateOfJoin = textbox_joindate.Text;
            if (isMembershipAuto)
            {
                Std.DateOfExpire = textbox_expiredate.Text;
            }
            else
            {
                Std.DateOfExpire = date_expiredate.Text;
            }
            if (imagepath != "")
            {
                Std.ImageBytes = Global.ConvertIntoBytes(imagepath);
            }
        }
        private void Validation()
        {
            if (string.IsNullOrEmpty(textbox_firstname.Text.Trim()))
            {
                MessageBox.Show("Please enter first name of the member", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textbox_firstname.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(textbox_lastname.Text.Trim()))
            {
                MessageBox.Show("Please enter last name of the member ", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textbox_lastname.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(textbox_contactno.Text.Trim()))
            {
                MessageBox.Show("Please enter contact no of the member", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textbox_contactno.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(textbox_email.Text.Trim()))
            {
                MessageBox.Show("Please enter email of the member", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textbox_email.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(textbox_Cnic.Text.Trim()))
            {
                MessageBox.Show("Please enter CNIN no of the member", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textbox_Cnic.Focus();
                return;
            }
        }
        private void ClearAll()
        {
            textbox_mainid.Text = Std.GetMainId();
            textbox_lastname.Text = "";
            textbox_firstname.Text = "";
            textbox_contactno.Text = "";
            textbox_email.Text = "";
            textbox_Cnic.Text = "";
            picbox_image.Image = null;
            picbox_image.BackgroundImage = backgroundImage;
        }
        private bool ValidateDate()
        {
            if (textbox_joindate.Text == date_expiredate.Text)
                return false;
            else
                return true;
        }

        #endregion

        #region [ EVENTS AND DELEGATES ]
        private void AddMember_Load(object sender, EventArgs e)
        {
            textbox_mainid.Text = Std.GetMainId();
            backgroundImage = picbox_image.BackgroundImage;
            ShowDates();
            InitializeDate();
        }
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

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            CloseControl(null);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            GetData();
            if (!Std.Filter())
            {
                Validation();
            }
            else
            {
                Global.check = Std.AddMember();
                if (Global.check)
                {
                    MessageBox.Show("Member added successfully", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    return;
                }
            }
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
