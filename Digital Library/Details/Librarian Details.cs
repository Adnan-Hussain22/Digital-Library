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
    public partial class Librarian_Details : UserControl
    {
        public Librarian_Details()
        {
            InitializeComponent();
        }

        #region [ OBJECTS AND EVENTS ]
        Lib.User_Info librarian = new Lib.User_Info();
        DataTable dt;
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
        public string Email
        {
            get;
            set;
        }
        public string Address
        {
            get;
            set;
        }

        public string Gender
        {
            get;
            set;
        }
        public string Password
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
            dgvLibrarianDetail.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvLibrarianDetail.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(221, 232, 241);
            dgvLibrarianDetail.DefaultCellStyle.SelectionBackColor = Color.FromArgb(212, 212, 212);
            dgvLibrarianDetail.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void BindData(int OffSet, int NextRecords)
        {
            dt = new DataTable();
            dt = librarian.GetLibrarians(OffSet, NextRecords);
            dgvLibrarianDetail.Rows.Clear();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    dgvLibrarianDetail.Rows.Add();
                    dgvLibrarianDetail.Rows[dgvLibrarianDetail.Rows.Count - 1].Cells["ColumnMainId"].Value = dr["Lib_MainId"];
                    dgvLibrarianDetail.Rows[dgvLibrarianDetail.Rows.Count - 1].Cells["ColumnPassword"].Value = dr["Lib_Password"];
                    dgvLibrarianDetail.Rows[dgvLibrarianDetail.Rows.Count - 1].Cells["ColumnFirstName"].Value = dr["Lib_FirstName"];
                    dgvLibrarianDetail.Rows[dgvLibrarianDetail.Rows.Count - 1].Cells["ColumnLastName"].Value = dr["Lib_LastName"];
                    dgvLibrarianDetail.Rows[dgvLibrarianDetail.Rows.Count - 1].Cells["ColumnContactNo"].Value = dr["Lib_ContactNo"];
                    dgvLibrarianDetail.Rows[dgvLibrarianDetail.Rows.Count - 1].Cells["ColumnGender"].Value = dr["Lib_Gender"];
                    dgvLibrarianDetail.Rows[dgvLibrarianDetail.Rows.Count - 1].Cells["ColumnAddrees"].Value = dr["Lib_Address"];
                    dgvLibrarianDetail.Rows[dgvLibrarianDetail.Rows.Count - 1].Cells["ColumnEmail"].Value = dr["Lib_Email"];
                    dgvLibrarianDetail.Rows[dgvLibrarianDetail.Rows.Count - 1].Cells["ColumnImage"].Value = dr["Lib_Pic"];
                    // dgvOperatorsDetail.Rows[dgvOperatorsDetail.Rows.Count - 1].Cells[0].Value = dr[""];
                    //((DataGridViewComboBoxColumn)dgvOperatorsDetail.Columns["ColumnAction"]).DataSource = cmb.Items;
                }
                //lblTotalLibrarians.Text = string.Format("Total Librarians : {0}", dgvLibrarianDetail.Rows.Count);
                dgvLibrarianDetail.Rows[0].Selected = false;
            }
        }

        private void BindSearchData()
        {
            dt = new DataTable();
            dt = librarian.FilterLibrarianList(cmbFilterOperator.Text, TextBoxSearch.Text.Trim());
            dgvLibrarianDetail.Rows.Clear();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    dgvLibrarianDetail.Rows.Add();
                    dgvLibrarianDetail.Rows[dgvLibrarianDetail.Rows.Count - 1].Cells["ColumnMainId"].Value = dr["Lib_MainId"];
                    dgvLibrarianDetail.Rows[dgvLibrarianDetail.Rows.Count - 1].Cells["ColumnPassword"].Value = dr["Lib_Password"];
                    dgvLibrarianDetail.Rows[dgvLibrarianDetail.Rows.Count - 1].Cells["ColumnFirstName"].Value = dr["Lib_FirstName"];
                    dgvLibrarianDetail.Rows[dgvLibrarianDetail.Rows.Count - 1].Cells["ColumnLastName"].Value = dr["Lib_LastName"];
                    dgvLibrarianDetail.Rows[dgvLibrarianDetail.Rows.Count - 1].Cells["ColumnContactNo"].Value = dr["Lib_ContactNo"];
                    dgvLibrarianDetail.Rows[dgvLibrarianDetail.Rows.Count - 1].Cells["ColumnGender"].Value = dr["Lib_Gender"];
                    dgvLibrarianDetail.Rows[dgvLibrarianDetail.Rows.Count - 1].Cells["ColumnAddrees"].Value = dr["Lib_Address"];
                    dgvLibrarianDetail.Rows[dgvLibrarianDetail.Rows.Count - 1].Cells["ColumnEmail"].Value = dr["Lib_Email"];
                    dgvLibrarianDetail.Rows[dgvLibrarianDetail.Rows.Count - 1].Cells["ColumnImage"].Value = dr["Lib_Pic"];

                }
            }
          //lblTotalLibrarians.Text = string.Format("Total Librarians : {0}", dgvLibrarianDetail.Rows.Count);

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
            Id = dgvLibrarianDetail.Rows[rowindex].Cells[0].Value.ToString();
            if (! DBNull.Value.Equals(dgvLibrarianDetail.Rows[rowindex].Cells[1].Value))
            {
                ImageBytes = ((byte[])dgvLibrarianDetail.Rows[rowindex].Cells[1].Value);
            }
            FirstName = dgvLibrarianDetail.Rows[rowindex].Cells[3].Value.ToString().Trim();
            LastName = dgvLibrarianDetail.Rows[rowindex].Cells[4].Value.ToString().Trim();
            Password = dgvLibrarianDetail.Rows[rowindex].Cells[2].Value.ToString().Trim();
            Email = dgvLibrarianDetail.Rows[rowindex].Cells[8].Value.ToString().Trim();
            Contact = dgvLibrarianDetail.Rows[rowindex].Cells[5].Value.ToString().Trim();
            Address = dgvLibrarianDetail.Rows[rowindex].Cells[7].Value.ToString().Trim();
            Gender = dgvLibrarianDetail.Rows[rowindex].Cells[6].Value.ToString().Trim();
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

        #region [ SOME EVENTS AND DELEGATES ]
        public event EventHandler CloseConnection;
        /// <summary>
        /// Signal to the subscriber to close the connection
        /// </summary>
        /// <param name="e"></param>
        private void CloseLibrarianDetails(EventArgs e)
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
                if (cmbFilterOperator.SelectedIndex <= 0)
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
            Global.PrintToPDF(dgvLibrarianDetail, "Librarians Report", true);
            ShowExtraColumns();
        }

        private void Librarian_Details_Load(object sender, EventArgs e)
        {
            var total = librarian.CountLibrarains();
            ProfessionalGrid();
            GetTotaPages(total);
            FilterNextPage();
            FilterBackPage();
            ProfessionalGrid();
            TotalRecords = total;
            lblTotalLibrarians.Text = string.Format("Total Librarians : {0}", TotalRecords);
            BindData(OffSet, recordsPerPage);
            radioBtn10.Checked = true;
            FilterTotalPagination(OffSet + 1, OffSet + 10, TotalRecords);
            ColumnImage.DefaultCellStyle.NullValue = Properties.Resources.default_man;
        }

        private void LinkDelete_Click()
        {
            DialogResult dr;
            dr = MessageBox.Show("Are you sure you want to delete the record permanently ?\n Deleting the record may effect other records", "Warning - " + Global.CaptionLib, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                librarian.MainId = Id;
                Global.check = librarian.DeleteUser();
                if (Global.check)
                {
                    BindData(OffSet, recordsPerPage);
                    return;
                }
                else
                {
                    MessageBox.Show("Failed to delete something may be wrong\nplease contact your administrator", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void dgvLibrarianDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 9)
            {
                switch (e.ColumnIndex)
                {
                    case 9:
                        {
                            sendData(e.RowIndex);
                            var c = new Reuseables.Librarian(this);
                            c.CloseConnection += new EventHandler(CloseTheControl);
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
                    case 10:
                        {
                            sendData(e.RowIndex);
                            LinkDelete_Click();
                            break;
                        }
                }
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

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            CloseLibrarianDetails(null);
        }

        #endregion

    }
}
