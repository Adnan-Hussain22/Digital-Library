using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advanced_School_Manangement_System.Details
{
    public partial class Suppliers_Detail : UserControl
    {
        public Suppliers_Detail()
        {
            InitializeComponent();
        }

        #region [ OBJECTS AND VARIABLES ]
        Lib.Supplier sup = new Lib.Supplier();
        Form f = new Form();
        int OffSet = 0, Counter = 1, TotalPages, TotalPagesSearch, recordsPerPage = 10, TotalRecords;
        #endregion

        #region [ PROPERTIES ]

        public string Id
        {
            get;
            set;
        }
        public string FirstName
        {
            get;
            set;
        }

        public string LastName
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
            dgvSuppliersDetail.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvSuppliersDetail.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(221, 232, 241);
            dgvSuppliersDetail.DefaultCellStyle.SelectionBackColor = Color.FromArgb(212, 212, 212);
            dgvSuppliersDetail.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void BindData(int OffSet, int NextRecords)
        {
            dgvSuppliersDetail.Rows.Clear();
            DataTable dt = new DataTable();
            dt = sup.getPaginatedSuppliers(OffSet, NextRecords);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    dgvSuppliersDetail.Rows.Add();
                    dgvSuppliersDetail.Rows[dgvSuppliersDetail.Rows.Count - 1].Cells["ColumnId"].Value = dr["Supp_MainId"];
                    dgvSuppliersDetail.Rows[dgvSuppliersDetail.Rows.Count - 1].Cells["ColumnFirstName"].Value = dr["Supp_FirstName"];
                    dgvSuppliersDetail.Rows[dgvSuppliersDetail.Rows.Count - 1].Cells["ColumnLastName"].Value = dr["Supp_LastName"];
                    dgvSuppliersDetail.Rows[dgvSuppliersDetail.Rows.Count - 1].Cells["ColumnContact"].Value = dr["Supp_PhoneNo"];
                    dgvSuppliersDetail.Rows[dgvSuppliersDetail.Rows.Count - 1].Cells["ColumnAddress"].Value = dr["Supp_Address"];
                    dgvSuppliersDetail.Rows[dgvSuppliersDetail.Rows.Count - 1].Cells["ColumnImage"].Value = dr["Supp_Image"];

                }
                dgvSuppliersDetail.Rows[0].Selected = false;
               // lblTotalSuppliers.Text = string.Format("Total Suppliers : {0}", dgvSuppliersDetail.Rows.Count);
            }
            else
            {
                //MessageBox.Show("No records found!", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //lblTotalSuppliers.Text = "Total Suppliers : 0";
                return;
            }
        }
        private void BindSearchData()
        {
            DataTable dt = new DataTable();
            dgvSuppliersDetail.Rows.Clear();
            dt = sup.FilterSupplierList(cmbFilterSupplierList.SelectedItem.ToString(), TextBoxSearch.Text.Trim());

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    dgvSuppliersDetail.Rows.Add();
                    dgvSuppliersDetail.Rows[dgvSuppliersDetail.Rows.Count - 1].Cells["ColumnId"].Value = dr["Supp_MainId"];
                    dgvSuppliersDetail.Rows[dgvSuppliersDetail.Rows.Count - 1].Cells["ColumnFirstName"].Value = dr["Supp_FirstName"];
                    dgvSuppliersDetail.Rows[dgvSuppliersDetail.Rows.Count - 1].Cells["ColumnLastName"].Value = dr["Supp_LastName"];
                    dgvSuppliersDetail.Rows[dgvSuppliersDetail.Rows.Count - 1].Cells["ColumnContact"].Value = dr["Supp_PhoneNo"];
                    dgvSuppliersDetail.Rows[dgvSuppliersDetail.Rows.Count - 1].Cells["ColumnAddress"].Value = dr["Supp_Address"];
                    dgvSuppliersDetail.Rows[dgvSuppliersDetail.Rows.Count - 1].Cells["ColumnImage"].Value = dr["Supp_Image"];
                }
                dgvSuppliersDetail.Rows[0].Selected = false;
                //lblTotalSuppliers.Text = string.Format("Total Suppliers : {0}", dgvSuppliersDetail.Rows.Count);
            }
            else
            {
                //MessageBox.Show("No records found!", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //lblTotalSuppliers.Text = "Total Suppliers : 0";
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
            Id = dgvSuppliersDetail.Rows[rowindex].Cells[0].Value.ToString();
            if (!DBNull.Value.Equals(dgvSuppliersDetail.Rows[rowindex].Cells[1].Value))
            {
                ImageBytes = ((byte[])dgvSuppliersDetail.Rows[rowindex].Cells[1].Value);
            }
            FirstName = dgvSuppliersDetail.Rows[rowindex].Cells[2].Value.ToString();
            LastName = dgvSuppliersDetail.Rows[rowindex].Cells[3].Value.ToString();
            Contact = dgvSuppliersDetail.Rows[rowindex].Cells[4].Value.ToString();
            Address = dgvSuppliersDetail.Rows[rowindex].Cells[5].Value.ToString();
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

        #region [ EVENTS AND DELEGATES ]

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
                if (cmbFilterSupplierList.SelectedIndex <= 0)
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
            Global.PrintToPDF(dgvSuppliersDetail, "Suppliers Report", true);
            ShowExtraColumns();
        }

        private void Suppliers_Detail_Load(object sender, EventArgs e)
        {
            var Total = sup.CountSuppliers();
            GetTotaPages(Total);
            FilterNextPage();
            FilterBackPage();
            ProfessionalGrid();
            TotalRecords = Total;
            lblTotalSuppliers.Text = string.Format("Total Suppliers : {0}", TotalRecords);
            BindData(OffSet, recordsPerPage);
            radioBtn10.Checked = true;
            FilterTotalPagination(OffSet + 1, OffSet + 10, TotalRecords);
            ColumnImage.DefaultCellStyle.NullValue = Properties.Resources.default_man;
        }

        private void dgvSuppliersDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 6)
            {
                switch (e.ColumnIndex)
                {
                    case 6:
                        {
                            //MessageBox.Show("Edit record"); 
                            sendData(e.RowIndex);
                            var c = new Reuseables.Supplier(this);
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
                    case 7:
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
            dr = MessageBox.Show("Are you sure you want to delete Book " + Id + " permenently ?\nDeleting the book record may affect other data", Global.CaptionLib, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                sup.Id = Id;
                Global.check = sup.Delete();
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

        private void CloseTheControl(object sender, EventArgs e)
        {
            var child = sender as Control;
            if (child != null)
            {
                f.Controls.Remove(child);
                f.Close();
            }
        }
        
        private void btn_back_Click(object sender, EventArgs e)
        {
            ClosePublisherDetailsControl(null);
        }

        #endregion
    }
}
