using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital Library.Details
{
    public partial class Book_Details : UserControl
    {
        public Book_Details()
        {
            InitializeComponent();
        }

        public Book_Details(object sender)
        {
            InitializeComponent();
            this.sender = sender;
        }

        #region [ Objects and Variables ]
        int RowIndex, ColumnIndex;
        int OffSet = 0, Counter = 1, TotalPages, TotalPagesSearch, recordsPerPage = 10, TotalRecords, TotalPaginations;
        Lib.Book_Entry BE = new Lib.Book_Entry();
        Form f = new Form();
        object sender;
        #endregion

        #region [ Properties ]
        public string Id
        {
            get;
            set;
        }
        public string Title
        {
            get;
            set;
        }
        public string Author
        {
            get;
            set;
        }
        public int Category
        {
            get;
            set;
        }
        public int Subject
        {
            get;
            set;
        }
        public string Publisher
        {
            get;
            set;
        }
        public string Supplier
        {
            get;
            set;
        }
        public string Details
        {
            get;
            set;
        }
        public string Edition
        {
            get;
            set;
        }
        public int NoOfCopies
        {
            get;
            set;
        }
        public long ISBN
        {
            get;
            set;
        }
        public int PublicationYear
        {
            get;
            set;
        }
        public float Price
        {
            get;
            set;
        }
        public byte[] ImageBytes
        {
            get;
            set;
        }
        #endregion

        #region [ METHODS ]

        private void ProfessionalGrid()
        {
            //dgvBookDetails.BorderStyle = BorderStyle.None;
            dgvBookDetails.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvBookDetails.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(221, 232, 241);
            dgvBookDetails.DefaultCellStyle.SelectionBackColor = Color.FromArgb(212, 212, 212);
            dgvBookDetails.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void GetTotaPages(int TotalRecords)
        {
            if (TotalRecords >= recordsPerPage)
            {
                if (TotalRecords % recordsPerPage == 0)
                {
                    TotalPages = TotalRecords / recordsPerPage;
                }
                else
                {
                    TotalPages = (TotalRecords / recordsPerPage) + 1;
                }
            }
            else
            {
                TotalPages = 1;
            }
        }
        private void FilterNextPage()
        {
            if (Counter < TotalPages)
                btnNext.Enabled = true;
            else
                btnNext.Enabled = false;
        }

        private void BindData(int OffSet, int NextRecords)
        {
            dgvBookDetails.Rows.Clear();
            DataTable dt = new DataTable();
            if (sender != null)
            {
                dt = BE.GetPaginatedAvailableBookData(OffSet, NextRecords);
            }
            else
            {
                dt = BE.GetPaginatedBookData(OffSet, NextRecords);
            }

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    dgvBookDetails.Rows.Add();
                    dgvBookDetails.Rows[dgvBookDetails.Rows.Count - 1].Cells["ColumnId"].Value = dr["Bk_MainId"];
                    dgvBookDetails.Rows[dgvBookDetails.Rows.Count - 1].Cells["ColumnTitle"].Value = dr["Bk_Booktitle"];
                    //dgvBookDetails.Rows[dgvBookDetails.Rows.Count - 1].Cells["ColumnAuthor"].Value = dr["Bk_Author"];
                    dgvBookDetails.Rows[dgvBookDetails.Rows.Count - 1].Cells["ColumnCategory"].Value = dr["Bk_Category"];
                    dgvBookDetails.Rows[dgvBookDetails.Rows.Count - 1].Cells["ColumnSubject"].Value = dr["Bk_Subject"];
                    dgvBookDetails.Rows[dgvBookDetails.Rows.Count - 1].Cells["ColumnEdition"].Value = dr["Bk_Edition"];
                    dgvBookDetails.Rows[dgvBookDetails.Rows.Count - 1].Cells["ColumnPublisher"].Value = dr["Bk_Publisher"];
                    dgvBookDetails.Rows[dgvBookDetails.Rows.Count - 1].Cells["ColumnPrice"].Value = dr["Bk_Price"];
                    dgvBookDetails.Rows[dgvBookDetails.Rows.Count - 1].Cells["ColumnNoOfCopies"].Value = dr["Bk_Availability"];
                    dgvBookDetails.Rows[dgvBookDetails.Rows.Count - 1].Cells["ColumnSupplier"].Value = dr["Bk_Supplier"];
                    dgvBookDetails.Rows[dgvBookDetails.Rows.Count - 1].Cells["ColumnDetails"].Value = dr["Bk_Details"];
                    dgvBookDetails.Rows[dgvBookDetails.Rows.Count - 1].Cells["ColumnISBN"].Value = dr["Bk_ISBN"];
                    dgvBookDetails.Rows[dgvBookDetails.Rows.Count - 1].Cells["ColumnPubYear"].Value = dr["Bk_PublicationYear"];
                    dgvBookDetails.Rows[dgvBookDetails.Rows.Count - 1].Cells["ColumnImage"].Value = dr["Bk_BookPic"];

                }
                dgvBookDetails.Rows[0].Selected = false;
                //FilterTotalPagination(OffSet + 1, TotalPaginations, TotalRecords);
            }
            else
            {
                //MessageBox.Show("No records found!", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void BindSearchData()
        {
            DataTable dt = new DataTable();
            dgvBookDetails.Rows.Clear();
            dt = BE.FilterBookList(cmbFilterMemberList.Text, TextBoxSearch.Text.Trim());
            TotalPagesSearch = dt.Rows.Count;
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    dgvBookDetails.Rows.Add();
                    dgvBookDetails.Rows[dgvBookDetails.Rows.Count - 1].Cells["ColumnId"].Value = dr["Bk_MainId"];
                    dgvBookDetails.Rows[dgvBookDetails.Rows.Count - 1].Cells["ColumnTitle"].Value = dr["Bk_Booktitle"];
                    //dgvBookDetails.Rows[dgvBookDetails.Rows.Count - 1].Cells["ColumnAuthor"].Value = dr["Bk_Author"];
                    dgvBookDetails.Rows[dgvBookDetails.Rows.Count - 1].Cells["ColumnCategory"].Value = dr["Bk_Category"];
                    dgvBookDetails.Rows[dgvBookDetails.Rows.Count - 1].Cells["ColumnSubject"].Value = dr["Bk_Subject"];
                    dgvBookDetails.Rows[dgvBookDetails.Rows.Count - 1].Cells["ColumnEdition"].Value = dr["Bk_Edition"];
                    dgvBookDetails.Rows[dgvBookDetails.Rows.Count - 1].Cells["ColumnPublisher"].Value = dr["Bk_Publisher"];
                    dgvBookDetails.Rows[dgvBookDetails.Rows.Count - 1].Cells["ColumnPrice"].Value = dr["Bk_Price"];
                    dgvBookDetails.Rows[dgvBookDetails.Rows.Count - 1].Cells["ColumnNoOfCopies"].Value = dr["Bk_Availability"];
                    dgvBookDetails.Rows[dgvBookDetails.Rows.Count - 1].Cells["ColumnSupplier"].Value = dr["Bk_Supplier"];
                    dgvBookDetails.Rows[dgvBookDetails.Rows.Count - 1].Cells["ColumnDetails"].Value = dr["Bk_Details"];
                    dgvBookDetails.Rows[dgvBookDetails.Rows.Count - 1].Cells["ColumnISBN"].Value = dr["Bk_ISBN"];
                    dgvBookDetails.Rows[dgvBookDetails.Rows.Count - 1].Cells["ColumnPubYear"].Value = dr["Bk_PublicationYear"];
                }
                dgvBookDetails.Rows[0].Selected = false;
                //FilterTotalPagination(OffSet + 1, TotalPaginations, TotalRecords);
                btn_printToPDF.Enabled = true;
            }
            else
                btn_printToPDF.Enabled = false;
        }

        private void EnablePagination()
        {
            btnBack.Enabled = true;
            btnNext.Enabled = true;
            radioBtn10.Enabled = true;
            radioBtn20.Enabled = true;
            radioBtn50.Enabled = true;
            FilterNextPage();
            FilterBackPage();
            FilterTotalPagination(OffSet + 1, OffSet + recordsPerPage, TotalRecords);
            radioBtn10.Checked = true;
            lblPaginationTotal.Visible = true;
        }

        private void DisablePagination()
        {
            btnBack.Enabled = false;
            btnNext.Enabled = false;
            radioBtn10.Enabled = false;
            radioBtn20.Enabled = false;
            radioBtn50.Enabled = false;
            Counter = 1;
            OffSet = 0;
            lblPaginationTotal.Visible = false;
        }

        private void FilterBackPage()
        {
            if (Counter > 1)
                btnBack.Enabled = true;
            else
                btnBack.Enabled = false;
        }
        private void NextPage()
        {
            if (Counter < TotalPages)
            {
                OffSet += recordsPerPage;
                BindData(OffSet, recordsPerPage);
                Counter++;
                FilterNextPage();
                FilterBackPage();
                FilterTotalPagination(OffSet + 1, OffSet + recordsPerPage, TotalRecords);
            }
        }
        private void BackPage()
        {
            if (Counter > 1)
            {
                OffSet -= recordsPerPage;
                BindData(OffSet, recordsPerPage);
                Counter--;
                FilterBackPage();
                FilterNextPage();
                FilterTotalPagination(OffSet + 1, OffSet + recordsPerPage, TotalRecords);
            }
        }
        /// <summary>
        /// Track the record on a page with records offset, total paginated records and total records
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="total"></param>
        private void FilterTotalPagination(int start, int end, int total)
        {
            if (TotalRecords > end)
            {
                lblPaginationTotal.Text = string.Format("{0}-{1} of {2} items found", start, end, total);
            }
            else
            {
                lblPaginationTotal.Text = string.Format("{0}-{1} of {2} items found", start, total, total);
            }

        }

        public void sendData(int rowindex)
        {
            Id = dgvBookDetails.Rows[rowindex].Cells[0].Value.ToString();
            if (!DBNull.Value.Equals(dgvBookDetails.Rows[rowindex].Cells[1].Value))
            {
                ImageBytes = ((byte[])dgvBookDetails.Rows[rowindex].Cells[1].Value);
            }
            Title = dgvBookDetails.Rows[rowindex].Cells[2].Value.ToString();
            // Author = dgvBookDetails.Rows[rowindex].Cells[3].Value.ToString();
            Subject = Convert.ToInt32(dgvBookDetails.Rows[rowindex].Cells[4].Value.ToString());
            Category = Convert.ToInt32(dgvBookDetails.Rows[rowindex].Cells[5].Value.ToString());
            Publisher = dgvBookDetails.Rows[rowindex].Cells[6].Value.ToString();
            Price = float.Parse(dgvBookDetails.Rows[rowindex].Cells[7].Value.ToString());
            Supplier = dgvBookDetails.Rows[rowindex].Cells[8].Value.ToString();
            ISBN = Convert.ToInt64(dgvBookDetails.Rows[rowindex].Cells[9].Value.ToString());
            PublicationYear = int.Parse(dgvBookDetails.Rows[rowindex].Cells[10].Value.ToString());
            Edition = dgvBookDetails.Rows[rowindex].Cells[11].Value.ToString();
            NoOfCopies = int.Parse(dgvBookDetails.Rows[rowindex].Cells[12].Value.ToString());
            if ((dgvBookDetails.Rows[rowindex].Cells[13].Value.ToString()) != "")
            {
                Details = dgvBookDetails.Rows[rowindex].Cells[13].Value.ToString();
            }
        }

        private void HideExtraColumns()
        {
            ColumnImage.Visible = false;
            ColumnEdit.Visible = false;
            ColumnDelete.Visible = false;
        }
        private void ShowExtraColumns()
        {
            ColumnImage.Visible = true;
            ColumnEdit.Visible = true;
            ColumnDelete.Visible = true;
        }

        #endregion

        #region [ SOME EVENTS AND DELEGATES ]

        /// <summary>
        /// intialize an event that the control has been subscribed
        /// </summary>
        public event EventHandler DataAvailable;

        /// <summary>
        /// signal to the subscriber that new data is available
        /// </summary>
        /// <param name="e"></param>
        private void OnDataAvailable(EventArgs e)
        {
            EventHandler eh = DataAvailable;
            if (eh != null)
            {
                eh(this, e);
            }
        }

        /// <summary>
        /// To initilize an event signal to close the child control
        /// </summary>
        public event EventHandler CloseConnection;
        /// <summary>
        /// Singnal to the subscriber to close the control
        /// </summary>
        /// <param name="e"></param>
        public void CloseBookControl(EventArgs e)
        {
            EventHandler eh = CloseConnection;
            if (eh != null)
            {
                eh(this, e);
            }
        }

        private void Book_Details_Load(object sender, EventArgs e)
        {
            var total = BE.CountBooks();
            ProfessionalGrid();
            GetTotaPages(total);
            FilterNextPage();
            FilterBackPage();
            TotalRecords = total;
            lblTotalBooks.Text = string.Format("Total Books : {0}", TotalRecords);
            BindData(OffSet, recordsPerPage);
            radioBtn10.Checked = true;
            FilterTotalPagination(OffSet + 1, OffSet + 10, TotalRecords);
            ColumnImage.DefaultCellStyle.NullValue = Properties.Resources.book_default;
            if (this.sender != null)
            {
                ColumnDelete.Visible = false;
                ColumnEdit.Text = "Select";
                ColumnEdit.HeaderText = "Select";
                ColumnEdit.ToolTipText = "Select the record";
            }
        }

        private void dgvBookDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 14)
            {
                switch (e.ColumnIndex)
                {
                    case 14:
                        {
                            if (this.sender != null)
                            {
                                sendData(e.RowIndex);
                                OnDataAvailable(null);
                                CloseBookControl(null);
                            }
                            else
                            {
                                sendData(e.RowIndex);
                                var c = new Reuseables.Book(this);
                                c.CloseConnection += new EventHandler(CloseTheControl);
                                //OnEditControl(null);
                                c.Dock = DockStyle.Fill;
                                c.BringToFront();
                                f.StartPosition = FormStartPosition.CenterParent;
                                f.Size = c.Size;
                                f.FormBorderStyle = FormBorderStyle.None;
                                f.Controls.Add(c);
                                f.BringToFront();
                                f.ShowDialog();
                                BindData(OffSet, recordsPerPage);
                            }
                            break;
                        }
                    case 15:
                        {
                            sendData(e.RowIndex);
                            LinkDelete_Click();
                            break;
                        }
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            NextPage();
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxSearch.Text != "")
            {
                if (cmbFilterMemberList.SelectedIndex <= 0)
                    return;
                else
                {
                    DisablePagination();
                    BindSearchData();
                }
            }
            else
            {
                EnablePagination();
                BindData(OffSet, recordsPerPage);
            }
        }

        private void btn_printToPDF_Click(object sender, EventArgs e)
        {
            HideExtraColumns();
            Global.PrintToPDF(dgvBookDetails, "Books Report", true);
            ShowExtraColumns();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackPage();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            CloseBookControl(null);
        }

        private void radioBtn10_CheckedChanged(object sender, EventArgs e)
        {
            OffSet = 0;
            Counter = 1;
            recordsPerPage = 10;
            GetTotaPages(TotalRecords);
            BindData(OffSet, recordsPerPage);
            FilterNextPage();
            FilterBackPage();
            FilterTotalPagination(OffSet + 1, OffSet + recordsPerPage, TotalRecords);
        }

        private void radioBtn20_CheckedChanged(object sender, EventArgs e)
        {
            OffSet = 0;
            Counter = 1;
            recordsPerPage = 20;
            GetTotaPages(TotalRecords);
            BindData(OffSet, recordsPerPage);
            FilterNextPage();
            FilterBackPage();
            FilterTotalPagination(OffSet + 1, OffSet + recordsPerPage, TotalRecords);
        }

        private void radioBtn50_CheckedChanged(object sender, EventArgs e)
        {
            OffSet = 0;
            Counter = 1;
            recordsPerPage = 50;
            GetTotaPages(TotalRecords);
            BindData(OffSet, recordsPerPage);
            FilterNextPage();
            FilterBackPage();
            FilterTotalPagination(OffSet + 1, OffSet + recordsPerPage, TotalRecords);
        }


        /// <summary>
        /// event method to close the child edit book contol
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseTheControl(object sender, EventArgs e)
        {
            var child = sender as Control;
            if (child != null)
            {
                f.Controls.Remove(child);
                f.Close();
            }

        }

        private void LinkDelete_Click()
        {
            if (BE.FilterStdIssuence())
            {
                MessageBox.Show("Enable to delete the record since the book is issued\nDeleting the record may effect other records", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DialogResult dr;
                dr = MessageBox.Show("Are you sure you want to delete Book " + Title + " permenently ?\nDeleting the book record may affect other data", Global.CaptionLib, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes)
                {
                    BE.BookIdMain = Id;
                    Global.check = BE.DeleteBook();
                    if (Global.check)
                    {
                        BindData(OffSet, recordsPerPage);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Enable to delete the record something may be wrong\nPlease contact you administrator", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                    return;
            }
        }

        #endregion

        //private void TextBoxSearch_TextChange(object sender, EventArgs e)
        //{
        //    //BE.Title = TextBoxSearch.Text;
        //    if (TextBoxSearch.Text == "")
        //    {
        //        BindData(OffSet, recordsPerPage);
        //        FilterNextPage();
        //        FilterBackPage();
        //    }
        //    else
        //    {
        //        if (cmbFilterBookList.SelectedIndex == 0)
        //            return;
        //        else
        //        {
        //            BindSearchData();
        //            btnNext.Enabled = false;
        //            btnBack.Enabled = false;
        //        }
        //    }
        //}

    }
}
