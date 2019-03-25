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
    public partial class Add_Specific : UserControl
    {
        public Add_Specific(string ControlName)
        {
            InitializeComponent();
            this.ControlName = ControlName;
            Y = Height;
            X = Width;
            btnLocX = btn_add.Location.X;
            btnLocY = btn_add.Location.Y;
        }

        #region [ OBJECTS AND VARIABLES ]
        string ControlName = "";
        int Y = 0, X = 0, btnLocY = 0, btnLocX = 0;
        Lib.Book_Entry Bk;
        Lib.Editor Ed;
        #endregion

        #region [ METHODS ]

        private bool AddSubject()
        {
            Bk.Subject = textbox_reuseableText1.Text;
            return Bk.AddSubject();
        }

        private bool AddCategory()
        {
            Bk.BookCategory = textbox_reuseableText1.Text;
            return Bk.AddCategory();
        }

        private bool AddEditor()
        {
            Ed.FirstName = textbox_reuseableText1.Text;
            Ed.LastName = textbox_reuseableText2.Text;
            return Ed.AddEditor();
        }

        #endregion

        #region [ SOME EVENTS AND DELEGATES ]
        
        /// <summary>
        /// Initialize the signal from the subscriber that the control has been subscribed
        /// </summary>
        public event EventHandler CloseConnection;
        
        /// <summary>
        /// Signal to the subscriber to close the control
        /// </summary>
        /// <param name="e"></param>
        private void OnCloseConnection(EventArgs e)
        {
            EventHandler eh = CloseConnection;
            if (eh != null)
            {
                eh(this, e);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (textbox_reuseableText1.Text != "")
            {
                
                switch (ControlName)
                {
                    case "Subject":
                        {
                            Bk = new Lib.Book_Entry();
                            if (AddSubject())
                            {
                                OnCloseConnection(null);
                            }
                            else
                            {
                                MessageBox.Show("Failed to add a subject something may be wrong\nPlease call your administrator",Global.CaptionLib,MessageBoxButtons.OK,MessageBoxIcon.Error);
                                OnCloseConnection(null);
                                return;
                            }
                            break;
                        }
                    case "Category":
                        {
                            Bk = new Lib.Book_Entry();
                            if (AddCategory())
                            {
                                OnCloseConnection(null);
                            }
                            else
                            {
                                MessageBox.Show("Failed to add a category something may be wrong\nPlease call your administrator", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                OnCloseConnection(null);
                            }
                            break;
                        }
                    case "Editor":
                        {
                            Ed = new Lib.Editor();
                            if (AddEditor())
                            {
                                OnCloseConnection(null);
                            }
                            else
                            {
                                MessageBox.Show("Failed to add a editor something may be wrong\nPlease call your administrator", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                OnCloseConnection(null);
                            }
                            break;
                        }
                }
            }
            else
            {
                MessageBox.Show("Plaease Enter a "+ ControlName +" in Textbox", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Add_Specific_Load(object sender, EventArgs e)
        {
            if (ControlName == "Editor")
            {
                textbox_reuseableText1.WaterMark = "Enter first name";
                textbox_reuseableText2.WaterMark = "Enter last name";
                textbox_reuseableText2.Visible = true;
            }
            else
            {
                Size = new Size(X, Y - 25);
                btn_add.Location = new Point(btnLocX, btnLocY-10);
                textbox_reuseableText1.WaterMark = "Enter "+ControlName;
                textbox_reuseableText2.Visible = false;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            OnCloseConnection(null);
        }

        #endregion

    }
}
