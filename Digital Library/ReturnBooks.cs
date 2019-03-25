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
    public partial class ReturnBooks : UserControl
    {
        public ReturnBooks()
        {
            InitializeComponent();
        }
        public ReturnBooks(Details.Return_Books_Detail child)
        {
            InitializeComponent();
            this.child = child;
        }

        #region [ OBJECTS AND VARIABLES ]
        Lib.ReturnIssueBook RIB = new Lib.ReturnIssueBook();
        DataTable dt;
        bool IsBookIsIssued = false;
        Image backgroundimage;
        Reuseables.QR_Scanner qrscanner = new Reuseables.QR_Scanner();
        Reuseables.fines payFine;
        Form f;
        Details.Return_Books_Detail child;
        string MainId = "";
        #endregion

        #region [ METHODS ]

        private void GetData()
        {
            RIB.IssueIdLatest = textbox_barcodeissuance.Text;
            IsBookIsIssued = RIB.ValidateIfTheBookIsIssued(textbox_barcodeissuance.Text);
            if (textbox_bookbarcode.Text == "")
            {
                GetIssuanceInfo();

            }
            RIB.BookId = textbox_bookbarcode.Text;
            RIB.MemberId = hiddentfeild_member_id.Text;
            RIB.ReturnDate = Global.GetNetworkTime().ToString();
            if (Properties.Settings.Default.switchFine)
            {
                var fineAmount = Properties.Settings.Default.FineAmount;
                var fineOptionCount = Properties.Settings.Default.FineOptionCount;
                switch (Properties.Settings.Default.FineOption)
                {
                    case "Days":
                        {
                            RIB.Fine = fineAmount / fineOptionCount;
                            break;
                        }
                    case "Weeks":
                        {
                            RIB.Fine = fineAmount / (7 * fineOptionCount);
                            break;
                        }
                    case "Months":
                        {

                            RIB.Fine = fineAmount / (30 * fineOptionCount);
                            break;
                        }
                    case "Years":
                        {

                            RIB.Fine = fineAmount / (360 * fineOptionCount);
                            break;
                        }
                }
            }
            else
                RIB.Fine = 0;
        }

        private void ClearData()
        {
            RIB.MainId = RIB.getMainId();
            textbox_barcodeissuance.Text = "";
            checkbox_bookinfo.Checked = false;
            checkbox_scanviacamera.Checked = false;
        }

        private bool IsTheBookIsIssued(string barcodeIssuance)
        {
            return RIB.ValidateIfTheBookIsIssued(barcodeIssuance);
        }

        private void GetIssuanceInfo()
        {
            dt = new DataTable();
            RIB.IssueIdLatest = textbox_barcodeissuance.Text;
            dt = RIB.GetIssuanceInfo(textbox_barcodeissuance.Text);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    textbox_bookbarcode.Text = dr["BOOKID"].ToString();
                    textbox_booktitle.Text = dr["BOOKTITLE"].ToString();
                    //textbox_bookauthor.Text = dr["BOOKAUHTOR"].ToString();
                    RIB.DueDate = dr["DUEDATE"].ToString();//MEMBERID
                    hiddentfeild_member_id.Text = dr["MEMBERID"].ToString();
                    textbox_bookholder.Text = dr["MEMBERNAME"].ToString();
                    textbox_holdercnic.Text = dr["MEMBERCNIC"].ToString();
                    if (!DBNull.Value.Equals(dr["BOOKIMAGE"]))
                    {
                        picbox_bookimage.Image = null;
                        picbox_bookimage.BackgroundImage = null;
                        var bytes = ((byte[])dr["BOOKIMAGE"]);
                        picbox_bookimage.Image = Global.ConvertIntoImage(bytes);
                    }
                    if (!DBNull.Value.Equals(dr["MEMBERIMAGE"]))
                    {
                        picbox_memberimage.Image = null;
                        picbox_memberimage.BackgroundImage = null;
                        var bytes = ((byte[])dr["MEMBERIMAGE"]);
                        picbox_memberimage.Image = Global.ConvertIntoImage(bytes);
                    }
                }
            }
            var qr = new Lib.QR_Generator();
            picbox_barcode.Image = qr.EncodeIntoQRCode(textbox_barcodeissuance.Text, false);
        }

        private void ShowResources(Control child)
        {
            f = new Form();
            switch (child.Name)
            {
                case "QR_Scanner":
                    {
                        qrscanner = (Reuseables.QR_Scanner)child;
                        TableLayoutPanel tablemain = new TableLayoutPanel();
                        tablemain.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
                        tablemain.Size = qrscanner.Size;
                        tablemain.Height += 9;
                        tablemain.Width += 9;
                        tablemain.Dock = DockStyle.Fill;
                        qrscanner.Dock = DockStyle.Fill;
                        qrscanner.BringToFront();
                        tablemain.Controls.Add(qrscanner);
                        f.StartPosition = FormStartPosition.CenterParent;
                        f.FormBorderStyle = FormBorderStyle.None;
                        f.Size = tablemain.Size;
                        f.BringToFront();
                        f.Controls.Add(tablemain);
                        f.BringToFront();
                        f.ShowDialog();
                        break;
                    }
            }
        }

        private void ShowPayFine()
        {
            payFine = new Reuseables.fines();
            TableLayoutPanel tablemain = new TableLayoutPanel();
            tablemain.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            tablemain.Size = payFine.Size;
            tablemain.Height += 9;
            tablemain.Width += 9;
            tablemain.Dock = DockStyle.Fill;
            payFine.Dock = DockStyle.Fill;
            payFine.BringToFront();
            payFine.DataAvailable += new EventHandler(FineDataAvailable);
            payFine.CloseConnection += new EventHandler(CloseTheControl);
            tablemain.Controls.Add(payFine);
            f = new Form();
            f.StartPosition = FormStartPosition.CenterParent;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Size = tablemain.Size;
            f.BringToFront();
            f.Controls.Add(tablemain);
            f.BringToFront();
            f.ShowDialog();
        }

        #endregion

        #region [ SOME EVENTS AND DELEGATES ]

        public event EventHandler CloseConnection;
        private void CloseReturnBookControl(EventArgs e)
        {
            EventHandler eh = CloseConnection;
            if (eh != null)
            {
                eh(this, e);
            }
        }

        private void ReturnBooks_Load(object sender, EventArgs e)
        {
            textbox_barcodeissuance.Focus();
            backgroundimage = picbox_barcode.BackgroundImage;
            if (child != null)
            {
                if (child.Name == "Return_Books_Detail")
                {
                    textbox_barcodeissuance.Text = child.IssueId;
                    RIB.IssueIdOld = child.IssueId;
                    MainId = child.ReturnIdOld;
                    btn_return.Text = "Edit";
                }
            }
            else
            {
                RIB.MainId = RIB.getMainId();
            }
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            if (textbox_barcodeissuance.Text != "")
            {
                GetData();
                if (IsBookIsIssued)
                {
                    if (child == null)
                    {
                        DialogResult dr = MessageBox.Show("Are you sure you want to return the book " + textbox_booktitle.Text + " ?", "Confirmation - " + Global.CaptionLib, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (dr == DialogResult.Yes)
                        {
                            Global.check = RIB.Return();
                            if (Global.check)
                            {
                                var fine = RIB.Fine;
                                if (fine > 0)
                                {
                                    var duedays = RIB.DueDays;
                                    var day = "day";
                                    if (duedays > 1)
                                        day = "days";
                                    else
                                        day = "day";
                                    dr = MessageBox.Show("Book " + textbox_booktitle.Text + " returned successfully since the book is returned after " + duedays + " " + day + " of the due date therefore the fine is " + fine + " RS do you want to pay it right now ?", Global.CaptionLib, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (dr == DialogResult.Yes)
                                    {
                                        ShowPayFine();
                                    }
                                    else
                                    {
                                        RIB.AddFines();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Book " + textbox_booktitle.Text + " returned successfully ", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                ClearData();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Failed to return a book something may be wrong\nplease contact your administrator", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                            return;
                    }
                    else
                    {
                        //edit record
                        DialogResult dr = MessageBox.Show("Are you sure you want to edit the record ?", "Confirmation - " + Global.CaptionLib, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (dr == DialogResult.Yes)
                        {
                            RIB.MainId = MainId;
                            if (RIB.UpdateReturn())
                            {

                                var fine = RIB.Fine;
                                if (fine > 0)
                                {
                                    var duedays = RIB.DueDays;
                                    var day = "day";
                                    if (duedays > 1)
                                        day = "day";
                                    else
                                        day = "days";
                                    MessageBox.Show("Book " + textbox_booktitle.Text + " returned successfully since the book is returned after " + duedays + " " + day + " of the due date therefore the fine is " + fine + " RS ", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                CloseReturnBookControl(null);

                            }
                            else
                            {
                                MessageBox.Show("Failed to edit the record something may be wrong\nplease contact your administrator", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Sorry the book is not issued", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please enter a barcode or scan a barcode via camera to return it to the library", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void checkbox_bookinfo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_bookinfo.Checked == true)
            {
                checkbox_scanviacamera.Enabled = false;
                if (textbox_barcodeissuance.Text.Trim() != "")
                {
                    IsBookIsIssued = RIB.ValidateIfTheBookIsIssued(textbox_barcodeissuance.Text.Trim());
                    if (IsBookIsIssued)
                    {
                        GetIssuanceInfo();
                        panel_bookinfo.Visible = true;
                    }
                    else
                    {
                        panel_bookinfo.Visible = false;
                        checkbox_bookinfo.CheckState = CheckState.Unchecked;
                        checkbox_scanviacamera.Enabled = true;
                        MessageBox.Show("Sorry no records found regarding this particular barcode or Id\nIf you are having problem in the system please call your adminstrator", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a barcode or scan via a camera", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    panel_bookinfo.Visible = false;
                    checkbox_bookinfo.CheckState = CheckState.Unchecked;
                }
            }
            else
            {
                checkbox_scanviacamera.Enabled = true;
                panel_bookinfo.Visible = false;
            }

        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            CloseReturnBookControl(null);
        }

        private void checkbox_scanviacamera_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_scanviacamera.Checked == true)
            {
                qrscanner.CloseConnection += new EventHandler(CloseTheControl);
                qrscanner.DataAvailable += new EventHandler(ChildDataAvailable);
                ShowResources(qrscanner);
            }
        }

        private void ChildDataAvailable(object sender, EventArgs e)
        {
            var child = sender as Reuseables.QR_Scanner;
            if (child != null)
            {
                textbox_barcodeissuance.Text = child.TextDecoded;
            }
        }

        private void CloseTheControl(object sender, EventArgs e)
        {
            var child = sender as Control;
            if (child != null)
            {
                f.Close();
            }
        }

        private void FineDataAvailable(object sender, EventArgs e)
        {
            var child = sender as Reuseables.fines;
            if (child != null)
            {
                if (!child.IsPaid)
                {
                    RIB.AddFines();
                }
                else
                {
                    if (child.Paid == 0)
                    {
                        child.Fine = RIB.Fine;
                        child.MemberId = RIB.MemberId;
                    }
                    else
                    {
                        RIB.Fine = child.Fine;
                        RIB.PaidAmount = child.Paid;
                        RIB.AddFines();
                    }
                }
            }
        }

        private void textbox_barcodeissuance_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkbox_bookinfo.CheckState = CheckState.Checked;
            }
        }
        #endregion

    }
}
