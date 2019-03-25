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
    public partial class Issued_Books_Detail : UserControl
    {
        public Issued_Books_Detail()
        {
            InitializeComponent();
        }

        #region [ OBJECTS AND VARIABLES ]
        DataTable dt;
        Form f = new Form();
        Lib.IssueBooks IssueBk = new Lib.IssueBooks();
        int OffSet = 0, Counter = 1, TotalPages, TotalPagesSearch, recordsPerPage = 10, TotalRecords;
        #endregion

        #region [ PROPERTIES ]

        public string IssueId
        {
            get;
            set;
        }

        public string BookId
        {
            get;
            set;
        }
        public string MemberId
        {
            get;
            set;
        }
        #endregion

        #region [ METHODS ]

        private void ProfessionalGrid()
        {
            //dgvBookDetails.BorderStyle = BorderStyle.None;
            dgv_IssueDetails.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgv_IssueDetails.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(221, 232, 241);
            dgv_IssueDetails.DefaultCellStyle.SelectionBackColor = Color.FromArgb(212, 212, 212);
            dgv_IssueDetails.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void BindData(int OffSet, int NextRecords)
        {
            dt = new DataTable();
            dt = IssueBk.GetPaginatedData(OffSet, NextRecords);
            dgv_IssueDetails.Rows.Clear();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    dgv_IssueDetails.Rows.Add();
                    dgv_IssueDetails.Rows[dgv_IssueDetails.Rows.Count - 1].Cells["ColumnIssueId"].Value = dr["IssueId"];
                    dgv_IssueDetails.Rows[dgv_IssueDetails.Rows.Count - 1].Cells["ColumnBookId"].Value = dr["BookId"];
                    dgv_IssueDetails.Rows[dgv_IssueDetails.Rows.Count - 1].Cells["ColumnBookTtile"].Value = dr["BookTile"];
                    //dgv_IssueDetails.Rows[dgv_IssueDetails.Rows.Count - 1].Cells["ColumnAuthor"].Value = dr["Author"];
                    dgv_IssueDetails.Rows[dgv_IssueDetails.Rows.Count - 1].Cells["ColumnHolderId"].Value = dr["HolderId"];
                    dgv_IssueDetails.Rows[dgv_IssueDetails.Rows.Count - 1].Cells["ColumnCNIC"].Value = dr["CNIC"];
                    dgv_IssueDetails.Rows[dgv_IssueDetails.Rows.Count - 1].Cells["ColumnHolder"].Value = dr["HolderName"];
                    dgv_IssueDetails.Rows[dgv_IssueDetails.Rows.Count - 1].Cells["ColumnIssueDate"].Value = dr["IssueDate"];
                    dgv_IssueDetails.Rows[dgv_IssueDetails.Rows.Count - 1].Cells["ColumnDueDate"].Value = dr["DueDate"];
                    dgv_IssueDetails.Rows[dgv_IssueDetails.Rows.Count - 1].Cells["ColumnLibrarian"].Value = dr["Librarian"];
                    dgv_IssueDetails.Rows[dgv_IssueDetails.Rows.Count - 1].Cells["ColumnLibrarianId"].Value = dr["LibrarianId"];
                }
                lblTotalRecords.Text = string.Format("Total Records : {0}", dgv_IssueDetails.Rows.Count);
                dgv_IssueDetails.Rows[0].Selected = false;
            }
            else
            {
                //MessageBox.Show("No records found!", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BindSearchData()
        {
            dt = new DataTable();
            //dt = IssueBk.GetPaginatedData();
            IssueBk.FilterIssuanceList(cmb_filter.SelectedItem.ToString(), textbox_search.Text.Trim());
            dgv_IssueDetails.Rows.Clear();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    dgv_IssueDetails.Rows.Add();
                    dgv_IssueDetails.Rows[dgv_IssueDetails.Rows.Count - 1].Cells["ColumnIssueId"].Value = dr["IssueId"];
                    dgv_IssueDetails.Rows[dgv_IssueDetails.Rows.Count - 1].Cells["ColumnBookId"].Value = dr["BookId"];
                    dgv_IssueDetails.Rows[dgv_IssueDetails.Rows.Count - 1].Cells["ColumnBookTtile"].Value = dr["BookTile"];
                    //dgv_IssueDetails.Rows[dgv_IssueDetails.Rows.Count - 1].Cells["ColumnAuthor"].Value = dr["Author"];
                    dgv_IssueDetails.Rows[dgv_IssueDetails.Rows.Count - 1].Cells["ColumnHolderId"].Value = dr["HolderId"];
                    dgv_IssueDetails.Rows[dgv_IssueDetails.Rows.Count - 1].Cells["ColumnCNIC"].Value = dr["CNIC"];
                    dgv_IssueDetails.Rows[dgv_IssueDetails.Rows.Count - 1].Cells["ColumnHolder"].Value = dr["HolderName"];
                    dgv_IssueDetails.Rows[dgv_IssueDetails.Rows.Count - 1].Cells["ColumnIssueDate"].Value = dr["IssueDate"];
                    dgv_IssueDetails.Rows[dgv_IssueDetails.Rows.Count - 1].Cells["ColumnDueDate"].Value = dr["DueDate"];
                    dgv_IssueDetails.Rows[dgv_IssueDetails.Rows.Count - 1].Cells["ColumnLibrarian"].Value = dr["Librarian"];
                    dgv_IssueDetails.Rows[dgv_IssueDetails.Rows.Count - 1].Cells["ColumnLibrarianId"].Value = dr["LibrarianId"];
                }
                //lblTotalRecords.Text = string.Format("Total Records : {0}", dgv_IssueDetails.Rows.Count);
                dgv_IssueDetails.Rows[0].Selected = false;
                btn_printToPDF.Enabled = true;
            }
            else
            {
                btn_printToPDF.Enabled = true;
                //MessageBox.Show("No records found!", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void sendData(int rowindex)
        {
            IssueId = dgv_IssueDetails.Rows[rowindex].Cells[0].Value.ToString();
            BookId = dgv_IssueDetails.Rows[rowindex].Cells[2].Value.ToString();
            MemberId = dgv_IssueDetails.Rows[rowindex].Cells[5].Value.ToString();
        }

        private void ShowEditControl(Book_Issuance control)
        {
            TableLayoutPanel tablemain = new TableLayoutPanel();
            tablemain.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            tablemain.Size = control.Size;
            tablemain.Height += 12;
            tablemain.Width += 9;
            tablemain.Dock = DockStyle.Fill;
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            tablemain.Controls.Add(control);
            f.StartPosition = FormStartPosition.CenterParent;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Size = tablemain.Size;
            f.BringToFront();
            f.Controls.Add(tablemain);
            f.BringToFront();
            f.ShowDialog();
        }

        #region [ PAGINATIONS ]
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

        #endregion

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

        private void btnNext_Click(object sender, EventArgs e)
        {
            NextPage();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackPage();
        }

        private void textbox_search_TextChanged(object sender, EventArgs e)
        {
            if (textbox_search.Text != "")
            {
                if (cmb_filter.SelectedIndex <= 0)
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
            Global.PrintToPDF(dgv_IssueDetails, "Issued Books Report", true);
            ShowExtraColumns();
        }

        private void Issued_Books_Detail_Load(object sender, EventArgs e)
        {
            var total = IssueBk.CountData();
            GetTotaPages(total);
            FilterNextPage();
            FilterBackPage();
            ProfessionalGrid();
            TotalRecords = total;
            lblTotalRecords.Text = string.Format("Total Records : {0}", TotalRecords);
            BindData(OffSet, recordsPerPage);
            radioBtn10.Checked = true;
            FilterTotalPagination(OffSet + 1, OffSet + 10, TotalRecords);
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            CloseControl(null);
        }

        private void CloseTheControl(object sender, EventArgs e)
        {
            var child = sender as Control;
            if (child != null)
            {
                f.Controls.Remove(child);
                f.Close();
            }

        }

        private void dgvIssuedBooksDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 11)
            {
                switch (e.ColumnIndex)
                {
                    case 11:
                        {
                            sendData(e.RowIndex);
                            var c = new Book_Issuance(this);
                            c.CloseConnection += new EventHandler(CloseTheControl);
                            //OnEditControl(null);
                            ShowEditControl(c);
                            BindData(OffSet, recordsPerPage);
                            break;
                        }
                    case 12:
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
            DialogResult dr;
            dr = MessageBox.Show("Are you sure you want to delete " + IssueId + " permenently ?\nDeleting the book record may affect other data", Global.CaptionLib, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                IssueBk.IssueIdLatest = IssueId;
                Global.check = IssueBk.Delete();
                if (Global.check)
                {
                    BindData(OffSet, recordsPerPage);
                    return;
                }
                else
                {
                    MessageBox.Show("Failed to delete record" + IssueId + "something may be wrong\nplease contact your administrator", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
                return;
        }

        #endregion

    }
}
