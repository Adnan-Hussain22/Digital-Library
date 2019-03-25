using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Advanced_School_Manangement_System;
using Advanced_School_Manangement_System.Lib;
namespace Login_Win
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        FrmLibDashboard LibDS = new FrmLibDashboard();
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonSignin_Click(object sender, EventArgs e)
        {
            Advanced_School_Manangement_System.Lib.User_Info Lib = new Advanced_School_Manangement_System.Lib.User_Info();
            Lib.MainId = TextboxUserid.text;
            Lib.Password= TextboxPassword.text;
            var check= Lib.Login();
            if (check == true)
            {
                Global.LibrarianId = TextboxUserid.text;
                this.Hide();
                LibDS.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Incorrect Library Id or Password !", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        //private void TextboxUserType_Leave(object sender, EventArgs e)
        //{
        //    if (TextboxUsertype.text == "")
        //    {
        //        TextboxUsertype.text = "User Type";
        //        lbl_type.Visible = false;
        //    }
        //}

        //private void TextboxUserType_Enter(object sender, EventArgs e)
        //{
        //    if (TextboxUsertype.text == "User Type")
        //    {
        //        TextboxUsertype.text = "";
        //        lbl_type.Visible = true;
        //    }
        //}

        private void TextboxEmail_Leave(object sender, EventArgs e)
        {
            if (TextboxUserid.text == "")
            {
                TextboxUserid.text = "Library Id";
            }
        }

        private void TextboxEmail_Enter(object sender, EventArgs e)
        {
            if (TextboxUserid.text == "Library Id")
            {
                TextboxUserid.text = "";
                lbl_userId.Visible = true;
            }
        }

        private void TextboxPassword_Enter(object sender, EventArgs e)
        {
            if (TextboxPassword.text == "Password")
            {
                TextboxPassword.text = "";
                lbl_password.Visible = true;
            }
        }

        private void TextboxPassword_Leave(object sender, EventArgs e)
        {
            if (TextboxPassword.text == "")
            {
                TextboxPassword.text = "Password";
                lbl_password.Visible = false;
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
        }
    }
}
