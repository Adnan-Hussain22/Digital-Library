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
    public partial class Member_Details : UserControl
    {
        public Member_Details()
        {
            InitializeComponent();
        }

        public Member_Details(object sender)
        {
            InitializeComponent();
            this.sender = sender;
        }

        #region [ OBJECTS AND VARIABLES ]
        Lib.Student Std = new Lib.Student();
        Form f = new Form();
        DataTable dt;
        string mainid, status = "";
        object sender;
        int OffSet = 0, Counter = 1, TotalPages, TotalPagesSearch, recordsPerPage = 10, TotalRecords;
        #endregion

        #region [ METHODS ]
        private void ProfessionalGrid()
        {
            //dgvStdDetails.BorderStyle = BorderStyle.None;
            dgvMembDetails.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvMembDetails.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(221, 232, 241);
            dgvMembDetails.DefaultCellStyle.SelectionBackColor = Color.FromArgb(212, 212, 212);
            dgvMembDetails.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void BindData(int OffSet, int NextRecords,string Status)
        {
            dt = new DataTable();
            if (sender != null) 
            {
                dt = Std.GetMembers(OffSet, NextRecords, "Available");
            }
            else
            {
                dt = Std.GetMembers(OffSet, NextRecords, Status);
            }
            dgvMembDetails.Rows.Clear();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    dgvMembDetails.Rows.Add();
                    dgvMembDetails.Rows[dgvMembDetails.Rows.Count - 1].Cells["ColumnId"].Value = dr["Memb_MainId"];
                    dgvMembDetails.Rows[dgvMembDetails.Rows.Count - 1].Cells["ColumnFirstName"].Value = dr["Memb_FirstName"];
                    dgvMembDetails.Rows[dgvMembDetails.Rows.Count - 1].Cells["ColumnlastName"].Value = dr["Memb_LastName"];
                    dgvMembDetails.Rows[dgvMembDetails.Rows.Count - 1].Cells["ColumnContact"].Value = dr["Memb_ContactNo"];
                    dgvMembDetails.Rows[dgvMembDetails.Rows.Count - 1].Cells["ColumnEmail"].Value = dr["Memb_Email"];
                    dgvMembDetails.Rows[dgvMembDetails.Rows.Count - 1].Cells["ColumnDateofJoin"].Value = dr["Memb_JoinDate"];
                    dgvMembDetails.Rows[dgvMembDetails.Rows.Count - 1].Cells["ColumnDateofExpire"].Value = dr["Memb_ExpireDate"];
                    dgvMembDetails.Rows[dgvMembDetails.Rows.Count - 1].Cells["ColumnCNIC"].Value = dr["Memb_Cnic"];
                    dgvMembDetails.Rows[dgvMembDetails.Rows.Count - 1].Cells["ColumnImage"].Value = dr["Memb_Pic"];
                    //dgvMembDetails.Rows[dgvMembDetails.Rows.Count - 1].Cells["ColumnStatus"].Value = dr["Memb_Status"];
                    if (Convert.ToBoolean(dr["Memb_Status"].ToString()) == true)
                        dgvMembDetails.Rows[dgvMembDetails.Rows.Count - 1].Cells["ColumnStatus"].Value = "Available";
                    else
                        dgvMembDetails.Rows[dgvMembDetails.Rows.Count - 1].Cells["ColumnStatus"].Value = "Expired";
                }
                dgvMembDetails.Rows[0].Selected = false;
                //lblTotalMembers.Text = string.Format("Total Members : {0}", dgvMembDetails.Rows.Count);
            }
            else
            {
                //MessageBox.Show("No records found!", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //lblTotalMembers.Text = "Total Members : 0";
                return;
            }
        }

        private void BindSearchData()
        {
            dt = new DataTable();
            dt = Std.FilterSearchData(cmbFilterStudent.Text, TextBoxSearch.Text.Trim());
            dgvMembDetails.Rows.Clear();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    dgvMembDetails.Rows.Add();
                    dgvMembDetails.Rows[dgvMembDetails.Rows.Count - 1].Cells["ColumnId"].Value = dr["Memb_MainId"];
                    dgvMembDetails.Rows[dgvMembDetails.Rows.Count - 1].Cells["ColumnFirstName"].Value = dr["Memb_FirstName"];
                    dgvMembDetails.Rows[dgvMembDetails.Rows.Count - 1].Cells["ColumnlastName"].Value = dr["Memb_LastName"];
                    dgvMembDetails.Rows[dgvMembDetails.Rows.Count - 1].Cells["ColumnContact"].Value = dr["Memb_ContactNo"];
                    dgvMembDetails.Rows[dgvMembDetails.Rows.Count - 1].Cells["ColumnEmail"].Value = dr["Memb_Email"];
                    dgvMembDetails.Rows[dgvMembDetails.Rows.Count - 1].Cells["ColumnDateofJoin"].Value = dr["Memb_JoinDate"];
                    dgvMembDetails.Rows[dgvMembDetails.Rows.Count - 1].Cells["ColumnDateofExpire"].Value = dr["Memb_ExpireDate"];
                    dgvMembDetails.Rows[dgvMembDetails.Rows.Count - 1].Cells["ColumnCNIC"].Value = dr["Memb_Cnic"];
                    dgvMembDetails.Rows[dgvMembDetails.Rows.Count - 1].Cells["ColumnImage"].Value = dr["Memb_Pic"];
                    //dataGrid.Columns[2].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm:ss tt";
                }
            }
            //lblTotalMembers.Text = string.Format("Total Members : {0}", dgvMembDetails.Rows.Count);

        }

        private void EnablePagination()
        {
            panel_membershipStatus.Enabled = true;
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
            panel_membershipStatus.Enabled = false;
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
            Id = dgvMembDetails.Rows[rowindex].Cells[0].Value.ToString();
            if(! DBNull.Value.Equals(dgvMembDetails.Rows[rowindex].Cells[1].Value))
            {
                ImageBytes = ((byte[])dgvMembDetails.Rows[rowindex].Cells[1].Value);
            }
            FirstName = dgvMembDetails.Rows[rowindex].Cells[2].Value.ToString();
            LastName = dgvMembDetails.Rows[rowindex].Cells[3].Value.ToString();
            CNIC = dgvMembDetails.Rows[rowindex].Cells[4].Value.ToString();
            Contact = dgvMembDetails.Rows[rowindex].Cells[5].Value.ToString();
            Email = dgvMembDetails.Rows[rowindex].Cells[6].Value.ToString();
        }

        private bool RenewMembership()
        {
            var dateToday = Global.GetNetworkTime();
            var membershipOption = Properties.Settings.Default.MembershipOption;
            string expireDate = "";
            if (membershipOption == "1 week")
            {
                expireDate = dateToday.AddDays(7).ToString();
            }
            else if (membershipOption == "1 month")
            {
                expireDate = dateToday.AddMonths(1).ToString();
            }
            else if (membershipOption == "1 year")
            {
                expireDate = dateToday.AddYears(1).ToString();
            }
            Std.DateOfExpire = expireDate;
            if (Std.RenewMembership())
            {
                return true;
            }
            else return false;
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
                BindData(OffSet, recordsPerPage, status);
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
                BindData(OffSet, recordsPerPage, status);
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
        public string CNIC
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

        #region [ SOME EVENTS AND DELEGATES ]
        public event EventHandler CloseConnection;
        /// <summary>
        /// Signal to the subscriber to close the control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseControl(EventArgs e)
        {
            EventHandler eh = CloseConnection;
            if (eh != null)
            {
                eh(this, e);
            }
        }

        public event EventHandler DataAvailable;
        /// <summary>
        /// Signal to the subscriber to close the control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnDataAvailable(EventArgs e)
        {
            EventHandler eh = DataAvailable;
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
            BindData(OffSet, recordsPerPage, status);
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
            BindData(OffSet, recordsPerPage, status);
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
            BindData(OffSet, recordsPerPage, status);
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
                if (cmbFilterStudent.SelectedIndex <= 0)
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
                BindData(OffSet, recordsPerPage, status);
            }
        }

        private void HideExtraColumns()
        {
            ColumnImage.Visible = false;
            ColumnRenew.Visible = false;
            ColumnEdit.Visible = false;
            ColumnDelete.Visible = false;
        }
        private void ShowExtraColumns()
        {
            ColumnImage.Visible = true;
            ColumnRenew.Visible = true;
            ColumnEdit.Visible = true;
            ColumnDelete.Visible = true;
        }

        private void btn_printToPdf_Click(object sender, EventArgs e)
        {
            HideExtraColumns();
            Global.PrintToPDF(dgvMembDetails, "Members Report", true);
            ShowExtraColumns();
        }

        private void radio_membershipAvailable_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_membershipAvailable.Checked == true)
            {
                TotalRecords = Std.CountMember(1);
                status = "Available";
                if (radioBtn10.Checked == true)
                    radioBtn10_CheckedChanged(sender, null);
                else
                    radioBtn10.Checked = true;
            }
        }

        private void radio_membershipAll_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_membershipAll.Checked == true)
            {
                TotalRecords = Std.CountMember(2);
                status = "All";
                if (radioBtn10.Checked == true)
                    radioBtn10_CheckedChanged(sender, null);
                else
                    radioBtn10.Checked = true;
            }
        }

        private void radio_membershipExpired_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_membershipExpired.Checked == true)
            {
                TotalRecords = Std.CountMember(0);
                status = "Expired";
                if (radioBtn10.Checked == true)
                    radioBtn10_CheckedChanged(sender, null);
                else
                    radioBtn10.Checked = true;
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            CloseControl(null);
        }

        private void Member_Details_Load(object sender, EventArgs e)
        {
            dgvMembDetails.Columns[1].DefaultCellStyle.NullValue = Properties.Resources.default_man;
            dgvMembDetails.Columns[8].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm:ss tt";
            dgvMembDetails.Columns[9].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm:ss tt";
            //GetTotaPages(Std.CountStudent());
            //FilterNextPage();
            //FilterBackPage();
            ProfessionalGrid();
            lblTotalMembers.Text = string.Format("Total Members : {0}", TotalRecords);
            radio_membershipAll.Checked = true;
            //BindData(OffSet, recordsPerPage);
            //FilterTotalPagination(OffSet + 1, OffSet + 10, TotalRecords);
            if (this.sender != null)
            {
                panel_membershipStatus.Visible = false;
                btn_printToPDF.Visible = false;
                ColumnRenew.Visible = false;
                ColumnDelete.Visible = false;
                ColumnEdit.Text = "Select";
                ColumnEdit.HeaderText = "Select";
                ColumnEdit.ToolTipText = "Select the record";
            }
        }

        private void dgvMembDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 10)
            {
                switch (e.ColumnIndex)
                {
                    case 10:
                        {
                            if (dgvMembDetails.Rows[e.RowIndex].Cells["ColumnStatus"].Value.ToString() == "Expired")   
                            {
                                Std.MemberId = dgvMembDetails.Rows[e.RowIndex].Cells["ColumnId"].Value.ToString();
                                var memberName = dgvMembDetails.Rows[e.RowIndex].Cells["ColumnFirstName"].Value.ToString() + " " + dgvMembDetails.Rows[e.RowIndex].Cells["ColumnlastName"].Value.ToString();
                                DialogResult dr = MessageBox.Show("Do you want to renew the membership of " + memberName, Global.CaptionLib, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (dr == DialogResult.Yes)
                                {

                                    if (RenewMembership())
                                    {
                                        MessageBox.Show("Membership of " + memberName + " Renewed successfully", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        BindData(OffSet, recordsPerPage, status);
                                        return;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Failed to renew membership something may be wrong, try again later or contact your administrator", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                            }
                            break;
                        }

                    case 11:
                        {
                            if (this.sender != null)
                            {
                                sendData(e.RowIndex);
                                OnDataAvailable(null);
                                CloseControl(null);
                            }
                            else
                            {
                                sendData(e.RowIndex);
                                var c = new Reuseables.Member(this);
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
                                BindData(OffSet, recordsPerPage, status);
                            }
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
            DialogResult dr;
            dr = MessageBox.Show("Are you sure you want to delete " + FirstName + " " + LastName + " permenently ?\nDeleting the book record may affect other data", Global.CaptionLib, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                Std.MemberId = Id;
                Global.check = Std.DeleteStudent();
                if (Global.check)
                {
                    BindData(OffSet, recordsPerPage, status);
                    return;
                }
                else
                {
                    MessageBox.Show("Failed to delete record" + mainid + "something may be wrong\nplease contact your administrator", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
                return;
        }
        #endregion

    }
}
