
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
    public partial class Publishers_Detail : UserControl
    {
        public Publishers_Detail()
        {
            InitializeComponent();
        }

        #region [ OBJECTS AND VARIABLES ]
        Lib.Publisher pub = new Lib.Publisher();
        Form f = new Form();
        int OffSet = 0, Counter = 1, TotalPages, TotalPagesSearch, recordsPerPage = 10, TotalRecords;
        #endregion

        #region [ Properties ]
        public string Id
        {
            get;
            set;
        }
        public string PubName
        {
            get;
            set;
        }
        public string Contact
        {
            get;
            set;
        }
        public string Address
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
            dgvPublishersDetail.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvPublishersDetail.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(221, 232, 241);
            dgvPublishersDetail.DefaultCellStyle.SelectionBackColor = Color.FromArgb(212, 212, 212);
            dgvPublishersDetail.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void BindData(int OffSet, int NextRecords)
        {
            dgvPublishersDetail.Rows.Clear();
            DataTable dt = new DataTable();
            dt = pub.getPaginatedPublishers(OffSet, NextRecords);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    dgvPublishersDetail.Rows.Add();
                    dgvPublishersDetail.Rows[dgvPublishersDetail.Rows.Count - 1].Cells["ColumnId"].Value = dr["Pub_MainId"];
                    dgvPublishersDetail.Rows[dgvPublishersDetail.Rows.Count - 1].Cells["ColumnName"].Value = dr["Pub_PublisherName"];
                    dgvPublishersDetail.Rows[dgvPublishersDetail.Rows.Count - 1].Cells["ColumnContact"].Value = dr["Pub_Phoneno"];
                    dgvPublishersDetail.Rows[dgvPublishersDetail.Rows.Count - 1].Cells["ColumnAddress"].Value = dr["Pub_Address"];
                    dgvPublishersDetail.Rows[dgvPublishersDetail.Rows.Count - 1].Cells["ColumnImage"].Value = dr["Pub_Image"];

                }
                //lblTotalPublishers.Text = string.Format("Total Publishers : {0}", dgvPublishersDetail.Rows.Count);
                dgvPublishersDetail.Rows[0].Selected = false;
                //FilterTotalPagination(OffSet + 1, TotalPaginations, TotalRecords);
            }
            else
            {
                MessageBox.Show("No records found!", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //lblTotalPublishers.Text = "Total Publishers : 0";
                return;
            }
        }
        private void BindSearchData()
        {
            DataTable dt = new DataTable();
            dgvPublishersDetail.Rows.Clear();
            dt = pub.FilterPublisherList(cmbFilterPublisherList.SelectedItem.ToString(), TextBoxSearch.Text.Trim());
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    dgvPublishersDetail.Rows.Add();
                    dgvPublishersDetail.Rows[dgvPublishersDetail.Rows.Count - 1].Cells["ColumnId"].Value = dr["Pub_MainId"];
                    dgvPublishersDetail.Rows[dgvPublishersDetail.Rows.Count - 1].Cells["ColumnName"].Value = dr["Pub_PublisherName"];
                    dgvPublishersDetail.Rows[dgvPublishersDetail.Rows.Count - 1].Cells["ColumnContact"].Value = dr["Pub_Phoneno"];
                    dgvPublishersDetail.Rows[dgvPublishersDetail.Rows.Count - 1].Cells["ColumnAddress"].Value = dr["Pub_Address"];
                    dgvPublishersDetail.Rows[dgvPublishersDetail.Rows.Count - 1].Cells["ColumnImage"].Value = dr["Pub_Image"];
                }
                dgvPublishersDetail.Rows[0].Selected = false;
              //  lblTotalPublishers.Text = string.Format("Total Publishers : {0}", dgvPublishersDetail.Rows.Count);
            }
            else
            {
                //MessageBox.Show("No records found!", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //lblTotalPublishers.Text = "Total Publishers : 0";
                return;
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

        public void sendData(int rowindex)
        {
            Id = dgvPublishersDetail.Rows[rowindex].Cells[0].Value.ToString();
            if (!DBNull.Value.Equals(dgvPublishersDetail.Rows[rowindex].Cells[1].Value))
            {
                ImageBytes = ((byte[])dgvPublishersDetail.Rows[rowindex].Cells[1].Value);
            }
            PubName = dgvPublishersDetail.Rows[rowindex].Cells[2].Value.ToString();
            Contact = dgvPublishersDetail.Rows[rowindex].Cells[3].Value.ToString();
            Address = dgvPublishersDetail.Rows[rowindex].Cells[4].Value.ToString();
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

        #endregion

        #region [ SOME EVENTS AND DELEGATE ]

        /// <summary>
        /// To initilize an event signal to close the child control
        /// </summary>
        public event EventHandler CloseConnection;
        /// <summary>
        /// Singnal to the subscriber to close the control
        /// </summary>
        /// <param name="e"></param>
        public void ClosePublisherDetailsControl(EventArgs e)
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

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxSearch.Text != "")
            {
                if (cmbFilterPublisherList.SelectedIndex <= 0)
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
            Global.PrintToPDF(dgvPublishersDetail, "Publishers Report", true);
            ShowExtraColumns();
        }

        private void Publishers_Detail_Load(object sender, EventArgs e)
        {
            var total = pub.CountPublishers();
            GetTotaPages(total);
            FilterNextPage();
            FilterBackPage();
            ProfessionalGrid();
            TotalRecords = total;
            lblTotalPublishers.Text = string.Format("Total Publishers : {0}", TotalRecords);
            BindData(OffSet, recordsPerPage);
            radioBtn10.Checked = true;
            FilterTotalPagination(OffSet + 1, OffSet + 10, TotalRecords);
            ColumnImage.DefaultCellStyle.NullValue = Properties.Resources.default_logo;
        }

        private void dgvPublishersDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 5)
            {
                switch (e.ColumnIndex)
                {
                    case 5:
                        {
                            //MessageBox.Show("Edit record"); 
                            sendData(e.RowIndex);
                            var c = new Reuseables.Publisher(this);
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
                            break;
                        }
                    case 6:
                        {
                            sendData(e.RowIndex);
                            LinkDelete_Click();
                            break;
                        }
                }
            }
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

        private void btn_back_Click(object sender, EventArgs e)
        {
            ClosePublisherDetailsControl(null);
        }

        #endregion

    }
}
