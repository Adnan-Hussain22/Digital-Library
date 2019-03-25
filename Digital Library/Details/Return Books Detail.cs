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
    public partial class Return_Books_Detail : UserControl
    {
        public Return_Books_Detail()
        {
            InitializeComponent();
        }

        #region [ OBJECTS AND VARIABLES ]
        Lib.ReturnIssueBook RBK = new Lib.ReturnIssueBook();
        int OffSet = 0, Counter = 1, TotalPages, TotalPagesSearch, recordsPerPage = 10, TotalRecords, TotalPaginations;
        Form f = new Form();
        object sender;
        #endregion

        #region [ PROPERTIES ]
        public string IssueId
        {
            get;
            set;
        }
        public string ReturnIdOld
        {
            get;
            set;
        }
        #endregion

        #region [ METHODS ]

        private void ProfessionalGrid()
        {
            //dgvBookDetails.BorderStyle = BorderStyle.None;
            dgvReturnBooksDetail.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvReturnBooksDetail.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(221, 232, 241);
            dgvReturnBooksDetail.DefaultCellStyle.SelectionBackColor = Color.FromArgb(212, 212, 212);
            dgvReturnBooksDetail.DefaultCellStyle.SelectionForeColor = Color.Black;
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
            dgvReturnBooksDetail.Rows.Clear();
            DataTable dt = new DataTable();
            dt = RBK.GetReturnBooksDetail(OffSet, NextRecords);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    dgvReturnBooksDetail.Rows.Add();
                    dgvReturnBooksDetail.Rows[dgvReturnBooksDetail.Rows.Count - 1].Cells["ColumnMainId"].Value = dr["Return Id"];
                    dgvReturnBooksDetail.Rows[dgvReturnBooksDetail.Rows.Count - 1].Cells["ColumnIssueId"].Value = dr["Issue Id"];
                    dgvReturnBooksDetail.Rows[dgvReturnBooksDetail.Rows.Count - 1].Cells["ColumnHolderId"].Value = dr["Holder Id"];
                    dgvReturnBooksDetail.Rows[dgvReturnBooksDetail.Rows.Count - 1].Cells["ColumnBookId"].Value = dr["Book Id"];
                    dgvReturnBooksDetail.Rows[dgvReturnBooksDetail.Rows.Count - 1].Cells["ColumnHolderName"].Value = dr["Holder Name"];
                    dgvReturnBooksDetail.Rows[dgvReturnBooksDetail.Rows.Count - 1].Cells["ColumnHolderCNIC"].Value = dr["Holder CNIC"];
                    dgvReturnBooksDetail.Rows[dgvReturnBooksDetail.Rows.Count - 1].Cells["ColumnBookTitle"].Value = dr["Book Title"];
                    //dgvReturnBooksDetail.Rows[dgvReturnBooksDetail.Rows.Count - 1].Cells["ColumnBookAuthor"].Value = dr["Book Author"];
                    dgvReturnBooksDetail.Rows[dgvReturnBooksDetail.Rows.Count - 1].Cells["ColumnReturnDate"].Value = dr["Return Date"];
                    dgvReturnBooksDetail.Rows[dgvReturnBooksDetail.Rows.Count - 1].Cells["ColumnFine"].Value = dr["Fine"];

                }
                dgvReturnBooksDetail.Rows[0].Selected = false;
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
            dgvReturnBooksDetail.Rows.Clear();
            dt = RBK.FilterReturnBooksList(cmbFilterList.SelectedItem.ToString(), TextBoxSearch.Text.Trim());
            TotalPagesSearch = dt.Rows.Count;
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    dgvReturnBooksDetail.Rows.Add();
                    dgvReturnBooksDetail.Rows[dgvReturnBooksDetail.Rows.Count - 1].Cells["ColumnMainId"].Value = dr["Return Id"];
                    dgvReturnBooksDetail.Rows[dgvReturnBooksDetail.Rows.Count - 1].Cells["ColumnIssueId"].Value = dr["Issue Id"];
                    dgvReturnBooksDetail.Rows[dgvReturnBooksDetail.Rows.Count - 1].Cells["ColumnHolderId"].Value = dr["Holder Id"];
                    dgvReturnBooksDetail.Rows[dgvReturnBooksDetail.Rows.Count - 1].Cells["ColumnBookId"].Value = dr["Book Id"];
                    dgvReturnBooksDetail.Rows[dgvReturnBooksDetail.Rows.Count - 1].Cells["ColumnHolderName"].Value = dr["Holder Name"];
                    dgvReturnBooksDetail.Rows[dgvReturnBooksDetail.Rows.Count - 1].Cells["ColumnHolderCNIC"].Value = dr["Holder CNIC"];
                    dgvReturnBooksDetail.Rows[dgvReturnBooksDetail.Rows.Count - 1].Cells["ColumnBookTitle"].Value = dr["Book Title"];
                    //dgvReturnBooksDetail.Rows[dgvReturnBooksDetail.Rows.Count - 1].Cells["ColumnBookAuthor"].Value = dr["Book Author"];
                    dgvReturnBooksDetail.Rows[dgvReturnBooksDetail.Rows.Count - 1].Cells["ColumnReturnDate"].Value = dr["Return Date"];
                    dgvReturnBooksDetail.Rows[dgvReturnBooksDetail.Rows.Count - 1].Cells["ColumnFine"].Value = dr["Fine"];
                }
                dgvReturnBooksDetail.Rows[0].Selected = false;
                //FilterTotalPagination(OffSet + 1, TotalPaginations, TotalRecords);
            }
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
            IssueId = dgvReturnBooksDetail.Rows[rowindex].Cells[1].Value.ToString();
            ReturnIdOld = dgvReturnBooksDetail.Rows[rowindex].Cells[0].Value.ToString();

        }

        private void HideExtraColumns()
        {
            ColumnEdit.Visible = false;
            ColumnDelete.Visible = false;
        }
        private void ShowExtraColumns()
        {
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

        private void Return_Books_Detail_Load(object sender, EventArgs e)
        {
            var total = RBK.CountReturnData();
            ProfessionalGrid();
            GetTotaPages(total);
            FilterNextPage();
            FilterBackPage();
            TotalRecords = total;
            lblTotalBooks.Text = string.Format("Total Records : {0}", TotalRecords);
            BindData(OffSet, recordsPerPage);
            radioBtn10.Checked = true;
            FilterTotalPagination(OffSet + 1, OffSet + 10, TotalRecords);
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
            if (e.ColumnIndex >= 10)
            {
                switch (e.ColumnIndex)
                {
                    case 10:
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
                                var c = new ReturnBooks(this);
                                c.CloseConnection += new EventHandler(CloseTheControl);
                                TableLayoutPanel tablemain = new TableLayoutPanel();
                                tablemain.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
                                //OnEditControl(null);
                                c.Dock = DockStyle.Fill;
                                c.Height -= 50;
                                tablemain.Size = c.Size;
                                tablemain.Width += 9;
                                tablemain.Height += 9;
                                c.BringToFront();
                                f.StartPosition = FormStartPosition.CenterParent;
                                f.Size = tablemain.Size;
                                f.FormBorderStyle = FormBorderStyle.None;
                                tablemain.Controls.Add(c);
                                f.Controls.Add(tablemain);
                                f.BringToFront();
                                f.ShowDialog();
                                BindData(OffSet, recordsPerPage);
                            }
                            break;
                        }
                    case 11:
                        {
                            sendData(e.RowIndex);
                            LinkDelete_Click();
                            break;
                        }
                }
            }
        }

        private void LinkDelete_Click()
        {
            //if (BE.FilterStdIssuence())
            //{
            //    MessageBox.Show("Enable to delete the record since the book is issued\nDeleting the record may effect other records", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //else
            //{
            //    DialogResult dr;
            //    dr = MessageBox.Show("Are you sure you want to delete Book " + Title + " permenently ?\nDeleting the book record may affect other data", Global.CaptionLib, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            //    if (dr == DialogResult.Yes)
            //    {
            //        BE.BookIdMain = Id;
            //        Global.check = BE.DeleteBook();
            //        if (Global.check)
            //        {
            //            BindData(OffSet, recordsPerPage);
            //            return;
            //        }
            //        else
            //        {
            //            MessageBox.Show("Enable to delete the record something may be wrong\nPlease contact you administrator", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            return;
            //        }
            //    }
            //    else
            //        return;
            //}
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            NextPage();
        }

        private void btn_printToPDF_Click(object sender, EventArgs e)
        {
            HideExtraColumns();
            Global.PrintToPDF(dgvReturnBooksDetail, "Return Books Report", true);
            ShowExtraColumns();
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxSearch.Text != "")
            {
                if (cmbFilterList.SelectedIndex <= 0)
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

        #endregion
    }
        
}

