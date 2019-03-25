using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Digital Library.Details
{
    public partial class Fine_Payments : UserControl
    {
        public Fine_Payments()
        {
            InitializeComponent();
        }

        #region [ OBJECTS AND VARIABLES ]
        Lib.Fine_Payment Fn;
        int OffSet = 0, Counter = 1, TotalPages, TotalPagesSearch, recordsPerPage = 10, TotalRecords,status=0;
        string DateRange = "";
        #endregion

        #region [ PROPERTIES ]
        #endregion

        #region [ METHODS ]

        private void ProfessionalGrid()
        {
            //dgvStdDetails.BorderStyle = BorderStyle.None;
            dgvFinePaymentDetails.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvFinePaymentDetails.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(221, 232, 241);
            dgvFinePaymentDetails.DefaultCellStyle.SelectionBackColor = Color.FromArgb(212, 212, 212);
            dgvFinePaymentDetails.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        public static DateTime GetNetworkTime()
        {
            //default Windows time server
            const string ntpServer = "time.windows.com";

            // NTP message size - 16 bytes of the digest (RFC 2030)
            var ntpData = new byte[48];

            //Setting the Leap Indicator, Version Number and Mode values
            ntpData[0] = 0x1B; //LI = 0 (no warning), VN = 3 (IPv4 only), Mode = 3 (Client Mode)

            var addresses = Dns.GetHostEntry(ntpServer).AddressList;

            //The UDP port number assigned to NTP is 123
            var ipEndPoint = new IPEndPoint(addresses[0], 123);
            //NTP uses UDP

            using (var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp))
            {
                socket.Connect(ipEndPoint);

                //Stops code hang if NTP is blocked
                socket.ReceiveTimeout = 3000;

                socket.Send(ntpData);
                socket.Receive(ntpData);
                socket.Close();
            }

            //Offset to get to the "Transmit Timestamp" field (time at which the reply 
            //departed the server for the client, in 64-bit timestamp format."
            const byte serverReplyTime = 40;

            //Get the seconds part
            ulong intPart = BitConverter.ToUInt32(ntpData, serverReplyTime);

            //Get the seconds fraction
            ulong fractPart = BitConverter.ToUInt32(ntpData, serverReplyTime + 4);

            //Convert From big-endian to little-endian
            intPart = SwapEndianness(intPart);
            fractPart = SwapEndianness(fractPart);

            var milliseconds = (intPart * 1000) + ((fractPart * 1000) / 0x100000000L);

            //**UTC** time
            var networkDateTime = (new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)).AddMilliseconds((long)milliseconds);

            return networkDateTime.ToLocalTime();
        }
        static uint SwapEndianness(ulong x)
        {
            return (uint)(((x & 0x000000ff) << 24) +
                           ((x & 0x0000ff00) << 8) +
                           ((x & 0x00ff0000) >> 8) +
                           ((x & 0xff000000) >> 24));
        }

        private void BindData(int OffSet, int NextRecords,int status,string DateRange)
        {
            dgvFinePaymentDetails.Rows.Clear();
            DataTable dt = new DataTable();
            dt = Fn.FetchFines(OffSet, NextRecords, status, DateRange);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    dgvFinePaymentDetails.Rows.Add();
                    dgvFinePaymentDetails.Rows[dgvFinePaymentDetails.Rows.Count - 1].Cells["ColumnId"].Value = dr["Main Id"];
                    dgvFinePaymentDetails.Rows[dgvFinePaymentDetails.Rows.Count - 1].Cells["ColumnMember"].Value = dr["Member Name"];
                    dgvFinePaymentDetails.Rows[dgvFinePaymentDetails.Rows.Count - 1].Cells["ColumnFineDate"].Value = dr["Fine Date"];
                    dgvFinePaymentDetails.Rows[dgvFinePaymentDetails.Rows.Count - 1].Cells["ColumnPaidAmount"].Value = dr["Paid Amount"];
                    dgvFinePaymentDetails.Rows[dgvFinePaymentDetails.Rows.Count - 1].Cells["ColumnDueAmount"].Value = dr["Due Amount"];
                    if (Convert.ToBoolean(dr["Status"].ToString()) == false) 
                        dgvFinePaymentDetails.Rows[dgvFinePaymentDetails.Rows.Count - 1].Cells["ColumnStatus"].Value = "Pending";
                    else
                        dgvFinePaymentDetails.Rows[dgvFinePaymentDetails.Rows.Count - 1].Cells["ColumnStatus"].Value = "Paid";

                }
                dgvFinePaymentDetails.Rows[0].Selected = false;
                lbl_totalrecords.Text = string.Format("Total Records : {0}", dgvFinePaymentDetails.Rows.Count);
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
            dgvFinePaymentDetails.Rows.Clear();
            //dt = BE.FilterBookList(cmbFilterMemberList.Text, TextBoxSearch.Text.Trim());
            TotalPagesSearch = dt.Rows.Count;
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    dgvFinePaymentDetails.Rows.Add();
                    dgvFinePaymentDetails.Rows.Add();
                    dgvFinePaymentDetails.Rows[dgvFinePaymentDetails.Rows.Count - 1].Cells["ColumnId"].Value = dr["Main Id"];
                    dgvFinePaymentDetails.Rows[dgvFinePaymentDetails.Rows.Count - 1].Cells["ColumnFineDate"].Value = dr["Fine Date"];
                    dgvFinePaymentDetails.Rows[dgvFinePaymentDetails.Rows.Count - 1].Cells["ColumnMember"].Value = dr["Member Name"];
                    dgvFinePaymentDetails.Rows[dgvFinePaymentDetails.Rows.Count - 1].Cells["ColumnPaidAmount"].Value = dr["Paid Amount"];
                    dgvFinePaymentDetails.Rows[dgvFinePaymentDetails.Rows.Count - 1].Cells["ColumnDueAmount"].Value = dr["Due Amount"];
                    if (Convert.ToInt32(dr["Status"].ToString()) > 0)
                        dgvFinePaymentDetails.Rows[dgvFinePaymentDetails.Rows.Count - 1].Cells["ColumnStatus"].Value = "Pending";
                    else
                        dgvFinePaymentDetails.Rows[dgvFinePaymentDetails.Rows.Count - 1].Cells["ColumnStatus"].Value = "Paid";
                }
                dgvFinePaymentDetails.Rows[0].Selected = false;
                btn_printToPDF.Enabled = true;
                //   FilterTotalPagination(OffSet + 1, TotalPaginations, TotalRecords);
            }
            else
                btn_printToPDF.Enabled = false;
        }

        #region [ PAGINATION ]

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
                BindData(OffSet, recordsPerPage, status, DateRange);
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
                BindData(OffSet, recordsPerPage, status, DateRange);
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
        /// Signal to the subscriber to close the control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCloseConnection(EventArgs e)
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

        private void Fine_Payments_Load(object sender, EventArgs e)
        {
            Fn = new Lib.Fine_Payment();
            date_from.Value = Global.GetNetworkTime();
            date_to.Value = Global.GetNetworkTime();
            dgvFinePaymentDetails.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm:ss tt";
            lbl_totalrecords.Text = string.Format("Total Records : {0}", 0);
            radiobtn_pending.Checked = true;
            ProfessionalGrid();
            //status = 0;
            //GetTotaPages(TotalRecords);
            //FilterNextPage();
            //FilterBackPage();
            //FilterTotalPagination(OffSet + 1, OffSet + 10, TotalRecords);
        }

        private void radiobtn_pending_CheckedChanged(object sender, EventArgs e)
        {
            status = 0;
            link_7days_LinkClicked(sender, null);
        }

        private void radiobtn_nonpending_CheckedChanged(object sender, EventArgs e)
        {
            status = 1;
            link_7days_LinkClicked(sender, null);
        }

        private void link_7days_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            DateRange =
            " AND TRY_CONVERT(DATE,Fn_FineDate) " +
            "BETWEEN DATEADD(DAY,-7,TRY_CONVERT(DATE,GETDATE())) " +
            "AND TRY_CONVERT(DATE, GETDATE())";
            TotalRecords = Convert.ToInt32(Fn.CountFines(status, DateRange));
            if (radioBtn10.Checked == true) 
                radioBtn10_CheckedChanged(sender, null);
            else
                radioBtn10.Checked = true;
        }

        private void link_30days_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DateRange =
            " AND TRY_CONVERT(DATE,Fn_FineDate) " +
            "BETWEEN DATEADD(MONTH,-1,TRY_CONVERT(DATE,GETDATE())) " +
            "AND TRY_CONVERT(DATE, GETDATE())";
            if (radioBtn10.Checked == true)
                radioBtn10_CheckedChanged(sender, null);
            else
                radioBtn10.Checked = true;
        }

        private void link_6months_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DateRange =
            " AND TRY_CONVERT(DATE,Fn_FineDate) " +
            "BETWEEN DATEADD(MONTH,-6,TRY_CONVERT(DATE,GETDATE())) " +
            "AND TRY_CONVERT(DATE, GETDATE())";
            if (radioBtn10.Checked == true)
                radioBtn10_CheckedChanged(sender, null);
            else
                radioBtn10.Checked = true;
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            if (date_from.Value > date_to.Value)
            {
                MessageBox.Show("Please select a proper date range", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                DateRange = string.Format(" AND TRY_CONVERT(DATE,Fn_FineDate) " +
                "BETWEEN TRY_CONVERT(DATE,'{0}') " +
                "AND TRY_CONVERT(DATE, '{1}')", date_from.Value.Date, date_to.Value.Date);
                TotalRecords = Convert.ToInt32(Fn.CountFines(status, DateRange));
                if (radioBtn10.Checked == true)
                    radioBtn10_CheckedChanged(sender, null);
                else
                    radioBtn10.Checked = true;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            OnCloseConnection(null);
        }

        private void btn_printToPDF_Click(object sender, EventArgs e)
        {
            Global.PrintToPDF(dgvFinePaymentDetails, "Fines Report", true);
        }

        private void link_all_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DateRange = "";
            if (radioBtn10.Checked == true)
                radioBtn10_CheckedChanged(sender, null);
            else
                radioBtn10.Checked = true;
        }

        #region [ PAGINATION ]

        private void btnNext_Click(object sender, EventArgs e)
        {
            NextPage();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackPage();
        }

        private void radioBtn10_CheckedChanged(object sender, EventArgs e)
        {
            OffSet = 0;
            Counter = 1;
            recordsPerPage = 10;
            GetTotaPages(TotalRecords);
            BindData(OffSet, recordsPerPage, status, DateRange);
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
            BindData(OffSet, recordsPerPage, status, DateRange);
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
            BindData(OffSet, recordsPerPage, status, DateRange);
            FilterNextPage();
            FilterBackPage();
            FilterTotalPagination(OffSet + 1, OffSet + recordsPerPage, TotalRecords);
        }

        #endregion

        #endregion
    }
}
