using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital Library
{
    public partial class Dummy3 : Form
    {
        public Dummy3()
        {
            InitializeComponent();
            ProfessionalGrid();
        }
        Lib.Staff Stff = new Lib.Staff();
        DataTable dt;
        int RowIndex = 0, ColumnIndex = 0;
        string _memberid, _membername, _memberemail, _membercontact, _memberstaffid, _memberjoindate, _memberexpiredate;
        public string MemberId
        {
            get { return _memberid; }
            set { _memberid = value; }
        }
        public string MemberName
        {
            get { return _membername; }
            set { _membername = value; }
        }
        public string MemberContat
        {
            get { return _membercontact; }
            set { _membercontact = value; }
        }
        public string MemberEmail
        {
            get { return _memberemail; }
            set { _memberemail = value; }
        }
        public string MemberJoinDate
        {
            get { return _memberjoindate; }
            set { _memberjoindate = value; }
        }
        public string MemberExpireDate
        {
            get { return _memberexpiredate; }
            set { _memberexpiredate = value; }
        }
        public string StaffId
        {
            get { return _memberstaffid; }
            set { _memberstaffid = value; }
        }
        private void Dummy3_Load(object sender, EventArgs e)
        {
            BindData();
            cmbFilterStaff.SelectedIndex = 0;
        }
        private void ProfessionalGrid()
        {
            //dgvBookDetails.BorderStyle = BorderStyle.None;
            dgvStaffDetails.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvStaffDetails.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(221, 232, 241);
            dgvStaffDetails.DefaultCellStyle.SelectionBackColor = Color.FromArgb(212, 212, 212);
            dgvStaffDetails.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void dgvStaffDetails_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            RowIndex = e.RowIndex;
            ColumnIndex = e.ColumnIndex;
        }

        private void BindData()
        {
            dt = new DataTable();
            dt = Stff.GetStaff();
            dgvStaffDetails.Rows.Clear();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    dgvStaffDetails.Rows.Add();
                    dgvStaffDetails.Rows[dgvStaffDetails.Rows.Count - 1].Cells["ColumnId"].Value = dr["MemStff_MainId"];
                    dgvStaffDetails.Rows[dgvStaffDetails.Rows.Count - 1].Cells["ColumnName"].Value = dr["MemStff_Name"];
                    dgvStaffDetails.Rows[dgvStaffDetails.Rows.Count - 1].Cells["ColumnContact"].Value = dr["MemStff_ContactNo"];
                    dgvStaffDetails.Rows[dgvStaffDetails.Rows.Count - 1].Cells["ColumnEmail"].Value = dr["MemStff_Email"];
                    dgvStaffDetails.Rows[dgvStaffDetails.Rows.Count - 1].Cells["ColumnDateofJoin"].Value = dr["MemStff_JoinDate"];
                    dgvStaffDetails.Rows[dgvStaffDetails.Rows.Count - 1].Cells["ColumnDateofExpire"].Value = dr["MemStff_ExpireDate"];
                    dgvStaffDetails.Rows[dgvStaffDetails.Rows.Count - 1].Cells["ColumnStaffId"].Value = dr["MemStff_Staffid"];
                }
                dgvStaffDetails.Rows[0].Selected = false;
                lblTotalStaffMembers.Text = string.Format("Total Members : {0}", dgvStaffDetails.Rows.Count);
            }
            else
            {
                MessageBox.Show("No records found!", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblTotalStaffMembers.Text = "Total Members : 0";
                return;
            }
        }
        private void BindSearchData()
        {
            dt = new DataTable();
            dt = Stff.FilterSearchData(cmbFilterStaff.Text, TextBoxSearch.Text.Trim());
            dgvStaffDetails.Rows.Clear();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    dgvStaffDetails.Rows.Add();
                    dgvStaffDetails.Rows[dgvStaffDetails.Rows.Count - 1].Cells["ColumnId"].Value = dr["MemStff_MainId"];
                    dgvStaffDetails.Rows[dgvStaffDetails.Rows.Count - 1].Cells["ColumnName"].Value = dr["MemStff_Name"];
                    dgvStaffDetails.Rows[dgvStaffDetails.Rows.Count - 1].Cells["ColumnContact"].Value = dr["MemStff_ContactNo"];
                    dgvStaffDetails.Rows[dgvStaffDetails.Rows.Count - 1].Cells["ColumnEmail"].Value = dr["MemStff_Email"];
                    dgvStaffDetails.Rows[dgvStaffDetails.Rows.Count - 1].Cells["ColumnDateofJoin"].Value = dr["MemStff_JoinDate"];
                    dgvStaffDetails.Rows[dgvStaffDetails.Rows.Count - 1].Cells["ColumnDateofExpire"].Value = dr["MemStff_ExpireDate"];
                    dgvStaffDetails.Rows[dgvStaffDetails.Rows.Count - 1].Cells["ColumnStaffId"].Value = dr["MemStff_Staffid"];
                }
            }
            lblTotalStaffMembers.Text = string.Format("Total Members : {0}", dgvStaffDetails.Rows.Count);

        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxSearch.Text == "")
            {
                BindData();
            }
            else
            {
                BindSearchData();
            }
        }
        public event EventHandler DataAvailable;
        /// <summary>
        /// Signal to the subscriber that new data is available
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnDataAvaialble(EventArgs e)
        {
            EventHandler eh = DataAvailable;
            if (eh != null)
            {
                eh(this, e);
            }
        }
        private void dgvStaffDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.S)
            {
                if (RowIndex == -1 || ColumnIndex > 7)
                    return;
                else
                {
                    _memberid = dgvStaffDetails.Rows[RowIndex].Cells[0].Value.ToString();
                    _membername = dgvStaffDetails.Rows[RowIndex].Cells[1].Value.ToString();
                    _membercontact = dgvStaffDetails.Rows[RowIndex].Cells[2].Value.ToString();
                    _memberemail = dgvStaffDetails.Rows[RowIndex].Cells[3].Value.ToString();
                    _memberjoindate = dgvStaffDetails.Rows[RowIndex].Cells[4].Value.ToString();
                    _memberexpiredate = dgvStaffDetails.Rows[RowIndex].Cells[5].Value.ToString();
                    _memberstaffid = dgvStaffDetails.Rows[RowIndex].Cells[6].Value.ToString();
                    OnDataAvaialble(null);
                    Close();
                }
            }
        }

        private void dgvStaffDetails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (RowIndex == -1 || ColumnIndex > 7)
                return;
            else
            {
                _memberid = dgvStaffDetails.Rows[RowIndex].Cells[0].Value.ToString();
                _membername = dgvStaffDetails.Rows[RowIndex].Cells[1].Value.ToString();
                _memberstaffid = dgvStaffDetails.Rows[RowIndex].Cells[2].Value.ToString();
                _membercontact = dgvStaffDetails.Rows[RowIndex].Cells[3].Value.ToString();
                _memberemail = dgvStaffDetails.Rows[RowIndex].Cells[4].Value.ToString();
                _memberjoindate = dgvStaffDetails.Rows[RowIndex].Cells[5].Value.ToString();
                _memberexpiredate = dgvStaffDetails.Rows[RowIndex].Cells[6].Value.ToString();
                OnDataAvaialble(null);
                Close();
            }
        }
    }
}
