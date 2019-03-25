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
    public partial class Book_Issuance : UserControl
    {
        Details.Issued_Books_Detail child;
        public Book_Issuance()
        {
            InitializeComponent();
        }
        public Book_Issuance(Details.Issued_Books_Detail child)
        {
            InitializeComponent();
            this.child = child;
        }
        #region [ OBJECTS AND VARIABLES ]
        Lib.IssueBooks IssueBk = new Lib.IssueBooks();
        Lib.QR_Generator qr = new Lib.QR_Generator();
        private int availableamount = 0;
        DataTable dt;
        Form f;
        Details.Book_Details BkDetails;
        Details.Member_Details MembDetails;
        Details.Issued_Books_Detail IssuanceDetails;
        bool isIssuanceAuto = Properties.Settings.Default.switchIssue;
        int issueAmount = Properties.Settings.Default.IssueAmount;
        #endregion

        #region [ METHODS ]

        private void InitializeDate()
        {
            date_duedate.Format = DateTimePickerFormat.Custom;
            date_duedate.CustomFormat = "MM/dd/yyyyy";
            date_duedate.MinDate = DateTime.Parse(textbox_issuedate.Text).AddDays(1);
        }

        private void ShowDates()
        {
            textbox_issuedate.Text = Global.GetNetworkTime().ToString();
            if (isIssuanceAuto)
            {
                date_duedate.Visible = false;
                textbox_duedate.Visible = true;
                textbox_duedatecontainer.Visible = true;
                switch (Properties.Settings.Default.IssueOption)
                {
                    case "Days":
                        {
                            textbox_duedate.Text = (DateTime.Parse(textbox_issuedate.Text).AddDays(Properties.Settings.Default.IssueOptionCount)).ToString();
                            break;
                        }
                    case "Weeks":
                        {
                            textbox_duedate.Text = (DateTime.Parse(textbox_issuedate.Text).AddDays(Properties.Settings.Default.IssueOptionCount * 7)).ToString();
                            break;
                        }
                    case "Months":
                        {
                            textbox_duedate.Text = (DateTime.Parse(textbox_issuedate.Text).AddMonths(Properties.Settings.Default.IssueOptionCount)).ToString();
                            break;
                        }
                    case "Years":
                        {
                            textbox_duedate.Text = (DateTime.Parse(textbox_issuedate.Text).AddYears(Properties.Settings.Default.IssueOptionCount)).ToString();
                            break;
                        }
                }

                //if (Properties.Settings.Default.IssueOption == "5 days")
                //{
                //    textbox_duedate.Text = DateTime.Parse(textbox_issuedate.Text).AddDays(5).ToString();
                //}
                //else if (Properties.Settings.Default.IssueOption == "1 week")
                //{
                //    textbox_duedate.Text = DateTime.Parse(textbox_issuedate.Text).AddDays(7).ToString();
                //}
                //else if (Properties.Settings.Default.IssueOption == "1 month")
                //{
                //    textbox_duedate.Text = DateTime.Parse(textbox_issuedate.Text).AddMonths(1).ToString();
                //}
                //else if (Properties.Settings.Default.IssueOption == "6 months")
                //{
                //    textbox_duedate.Text = DateTime.Parse(textbox_issuedate.Text).AddMonths(6).ToString();
                //}
            }
            else
            {
                date_duedate.Visible = true;
                textbox_duedate.Visible = false;
                textbox_duedatecontainer.Visible = false;
            }
        }

        private void ClearAll()
        {
            TextBoxBookId.Text = "";
            TextBoxBookName.Text = "";
            TextBoxMemberId.Text = "";
            TextBoxFirstName.Text = "";
            TextBoxLastName.Text = "";
            TextBoxCNIC.Text = "";
            GetMainId();
            //TextBoxFine.Text = "";
            TextboxAuthor.Text = "";
        }
        private void GetMainId()
        {
            TextBoxIssueId.Text = IssueBk.GetMainId();
        }

        private bool ValidateStudent()
        {
            if (TextBoxMemberId.Text != "" && TextBoxFirstName.Text != "" && TextBoxCNIC.Text != "")
                return true;
            else
                return false;
        }
        private bool ValidateBook()
        {
            if (TextBoxBookId.Text != "" && TextBoxBookName.Text != "" /*&& TextboxAuthor.Text != ""*/)
                return true;
            else
                return false;
        }
        private bool ValidateDate()
        {
            if (textbox_issuedate.Text == date_duedate.Text)
            {
                date_duedate.Focus();
                return false;
            }
            else
                return true;
        }
        private void GetAllText()
        {
            IssueBk.BookId = TextBoxBookId.Text;
            IssueBk.MemberId = TextBoxMemberId.Text;
            IssueBk.MainId = TextBoxIssueId.Text;
            IssueBk.IssueDate = textbox_issuedate.Text;
            IssueBk.DueDate = date_duedate.Text;
            IssueBk.IssueIdLatest = TextBoxIssueId.Text;
            //IBSTD.Fine = int.Parse(TextBoxFine.Text);

        }
        private bool Validation()
        {
            if (!ValidateBook())
            {
                MessageBox.Show("Please select the book you want to issue", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                BookList();
                return false;
            }
            else if (!ValidateStudent())
            {
                MessageBox.Show("Please select the member you want to issue a book", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                StudentList();
                return false;
            }
            else
                return true;

        }

        private void BookList()
        {
            BkDetails = new Details.Book_Details(this);
            BkDetails.DataAvailable += new EventHandler(BookListDataAvailable);
            BkDetails.CloseConnection += new EventHandler(CloseTheControl);
            ShowResourcesControls(BkDetails);
        }

        private void StudentList()
        {
            MembDetails = new Details.Member_Details(this);
            MembDetails.DataAvailable += new EventHandler(MemberDataAvailable);
            MembDetails.CloseConnection += new EventHandler(CloseTheControl);
            ShowResourcesControls(MembDetails);
        }

        private void FillFeilds()
        {
            TextBoxBookId.Text = child.BookId;
            TextBoxMemberId.Text = child.MemberId;
            TextBoxIssueId.Text = child.IssueId;
        }

        private void IssuanceList()
        {
            IssuanceDetails = new Details.Issued_Books_Detail();
            //MembDetails.DataAvailable += new EventHandler(MemberDataAvailable);
            IssuanceDetails.CloseConnection += new EventHandler(CloseTheControl);
            ShowResourcesControls(IssuanceDetails);
        }

        private void EnableOperations()
        {
            btn_edit.Enabled = true;
            btn_delete.Enabled = true;
            btn_issue.Enabled = false;
        }
        private void DisableOperations()
        {
            btn_edit.Enabled = false;
            btn_delete.Enabled = false;
            btn_issue.Enabled = true;
        }

        private void ShowResourcesControls(Control child)
        {
            f = new Form();
            switch (child.Name)
            {
                case "Book_Details":
                    {
                        BkDetails = (Details.Book_Details)child;
                        TableLayoutPanel tablemain = new TableLayoutPanel();
                        tablemain.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
                        tablemain.Dock = DockStyle.Fill;
                        tablemain.Size = BkDetails.Size;
                        tablemain.Width += 10;
                        tablemain.Height += 12;
                        BkDetails.Dock = DockStyle.Fill;
                        BkDetails.BringToFront();
                        tablemain.Controls.Add(BkDetails);
                        f.StartPosition = FormStartPosition.CenterParent;
                        f.FormBorderStyle = FormBorderStyle.None;
                        f.Size = tablemain.Size;
                        f.BringToFront();
                        f.Controls.Add(tablemain);
                        f.BringToFront();
                        f.ShowDialog();
                        break;
                    }
                case "Member_Details":
                    {
                        MembDetails = (Details.Member_Details)child;
                        TableLayoutPanel tablemain = new TableLayoutPanel();
                        tablemain.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
                        tablemain.Dock = DockStyle.Fill;
                        tablemain.Size = MembDetails.Size;
                        tablemain.Width += 10;
                        tablemain.Height += 12;
                        MembDetails.Dock = DockStyle.Fill;
                        MembDetails.BringToFront();
                        tablemain.Controls.Add(MembDetails);
                        f.StartPosition = FormStartPosition.CenterParent;
                        f.FormBorderStyle = FormBorderStyle.None;
                        f.Size = tablemain.Size;
                        f.BringToFront();
                        f.Controls.Add(tablemain);
                        f.BringToFront();
                        f.ShowDialog();
                        break;
                    }
                    //case "Issued_Books_Detail":
                    //    {
                    //        IssuanceDetails = (Details.Issued_Books_Detail)child;
                    //        TableLayoutPanel tablemain = new TableLayoutPanel();
                    //        tablemain.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
                    //        tablemain.Size = IssuanceDetails.Size;
                    //        tablemain.Height += 12;
                    //        tablemain.Width += 9;
                    //        tablemain.Dock = DockStyle.Fill;
                    //        IssuanceDetails.Dock = DockStyle.Fill;
                    //        IssuanceDetails.BringToFront();
                    //        tablemain.Controls.Add(IssuanceDetails);
                    //        f.StartPosition = FormStartPosition.CenterParent;
                    //        f.FormBorderStyle = FormBorderStyle.None;
                    //        f.Size = tablemain.Size;
                    //        f.BringToFront();
                    //        f.Controls.Add(tablemain);
                    //        f.BringToFront();
                    //        f.ShowDialog();
                    //        break;
                    //    }
            }

        }


        #endregion

        #region [ SOME EVENTS AND DELEGATES ]

        /// <summary>
        /// Child Book Issue Data is Available
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookListDataAvailable(object sender, EventArgs e)
        {
            Details.Book_Details child = sender as Details.Book_Details;
            if (child != null)
            {
                availableamount = child.NoOfCopies;
                TextBoxBookId.Text = child.Id;
                //TextBoxBookName.Text = child.Title;
                TextboxAuthor.Text = child.Author;
                //IssueBk.Availableamount = child.Availibiltity;
            }
        }

        /// <summary>
        /// Child Student Data is Available
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MemberDataAvailable(object sender, EventArgs e)
        {
            Details.Member_Details child = sender as Details.Member_Details;
            if (child != null)
            {
                TextBoxMemberId.Text = child.Id;
            }
        }

        /// <summary>
        /// used to initialize an event method that closes the control
        /// </summary>
        public event EventHandler CloseConnection;
        /// <summary>
        /// Gives a signal to the subscriber to close the control
        /// </summary>
        /// <param name="e"></param>
        private void CloseControl(EventArgs e)
        {
            EventHandler eh = CloseConnection;
            if (eh != null)
            {
                eh(this, e);
            }
        }

        private void CloseTheControl(object sender, EventArgs e)
        {
            Control child = sender as Control;
            if (child != null)
            {
                f.Controls.Remove(child);
                f.Close();
            }
        }

        private void Book_Issuance_Load(object sender, EventArgs e)
        {
            ShowDates();
            InitializeDate();
            GetMainId();
            if (child != null)
            {
                EnableOperations();
                FillFeilds();
            }
            else
            {
                DisableOperations();
            }
        }

        private void textboxBookId_TextChanged(object sender, EventArgs e)
        {
            IssueBk.BookId = TextBoxBookId.Text;
            if (TextBoxBookId.Text != "")
            {
                dt = new DataTable();
                dt = IssueBk.FilterBook(TextBoxBookId.Text);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        TextBoxBookName.Text = dr["Bk_Booktitle"].ToString();
                        //TextboxAuthor.Text = dr["Bk_Author"].ToString();
                    }
                }
                //IBSTD.FilterAvailabiltyAmount()
                //PanelWarningBook.Visible = true;
                //else
                //    PanelWarningBook.Visible = false;
            }
        }
        private void textboxMemberId_TextChanged(object sender, EventArgs e)
        {
            IssueBk.MemberId = TextBoxMemberId.Text;
            if (TextBoxMemberId.Text != "")
            {
                if (IssueBk.FilterMemberStatus())
                {
                    dt = new DataTable();
                    dt = IssueBk.FilterMember(TextBoxMemberId.Text);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            TextBoxFirstName.Text = dr["Memb_FirstName"].ToString();
                            TextBoxLastName.Text = dr["Memb_LastName"].ToString();
                            TextBoxCNIC.Text = dr["Memb_Cnic"].ToString();
                        }
                    }
                }
                else
                {
                    //panelwarningStd.Visible = false;
                }
            }
        }
        private void ButtnIssue_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                if ((IssueBk.FilterMemberStatus()))
                {
                    if (availableamount > 0)
                    {
                        IssueBk.MemberId = TextBoxMemberId.Text;
                        if (!IssueBk.FilterIssuence(issueAmount))
                        {
                            GetAllText();
                            Global.check = IssueBk.IssueBook();
                            if (Global.check)
                            {
                                MessageBox.Show("Book successfully issued to " + TextBoxFirstName.Text + ' ' + TextBoxLastName.Text, Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                DialogResult dr = MessageBox.Show("Do you want to print it qr code now ?", Global.CaptionLib, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (dr == DialogResult.Yes)
                                {
                                    qr.EncodeIntoQRCode(TextBoxIssueId.Text, false);
                                    qr.PrintQrCode();
                                }
                                else
                                {
                                    qr.EncodeIntoQRCode(TextBoxIssueId.Text, true);
                                    qr.SaveQrCode();
                                }
                                ClearAll();
                                //GetMainId();
                            }
                            else
                            {
                                MessageBox.Show("Failed to issue a book some this may be wrong, please try again later or contact your administrator", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("The issuance amount of the member " + (TextBoxFirstName.Text + " " + TextBoxLastName.Text).Trim() + " is exceeded of amount set by the admin please return the issued books first or contact with your administrator", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sorry the book is not available right now", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Cannot issue a book to " + (TextBoxFirstName.Text + " " + TextBoxLastName.Text).Trim() + " because membership is expired please renew your membership!", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
                return;

        }

        private void ButtnSelectBook_Click(object sender, EventArgs e)
        {
            BookList();
        }
        private void ButtnSelectMember_Click(object sender, EventArgs e)
        {
            StudentList();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            CloseControl(null);
        }

        private void ButtnEdit_CLick(object sender, EventArgs e)
        {
            CloseControl(e);
            GetAllText();
            if (TextBoxBookId.Text != "" && TextBoxMemberId.Text != "")
            {
                DialogResult dr = MessageBox.Show("Are sure you want to update this record ?", Global.CaptionLib, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes)
                {
                    if (textbox_issuedate.Text != date_duedate.Text)
                    {
                        Global.check = IssueBk.Update();
                        if (Global.check)
                        {
                            MessageBox.Show("Record " + TextBoxIssueId.Text + " has been updated successfully", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearAll();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update a record something may be wrong\n please contact your administrator", Global.CaptionLib, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Issue and due date should not be equal", Global.CaptionLib, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                        date_duedate.Focus();
                        return;
                    }
                }
                else
                    return;
            }
            else
            {
                MessageBox.Show("Please select the record", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            ClearAll();
            DisableOperations();
        }

        private void ButtnIssueDetails_Click(object sender, EventArgs e)
        {
            IssuanceList();
        }

        #endregion

    }
}
