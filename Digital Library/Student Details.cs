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
    public partial class Dummy2 : Form
    {
        public Dummy2()
        {
            InitializeComponent();
            ProfessionalGrid();
        }
        #region Objects and Variables
        DataTable dt;
        Lib.Student Std = new Lib.Student();
        string _memberid, _memberfirstname, _memberlastname, _memberemail, _membercontact, _membercnic, _memberjoindate, _memberexpiredate;
        int RowIndex, ColumnIndex;
        private void ProfessionalGrid()
        {
            //dgvBookDetails.BorderStyle = BorderStyle.None;
            dgvStdDetails.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvStdDetails.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(221, 232, 241);
            dgvStdDetails.DefaultCellStyle.SelectionBackColor = Color.FromArgb(212, 212, 212);
            dgvStdDetails.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        #endregion
        #region Properties
        public string MemberId
        {
            get { return _memberid; }
            set { _memberid = value; }
        }
        public string MemberFirstName
        {
            get { return _memberfirstname; }
            set { _memberfirstname = value; }
        }
        public string MemberLastName
        {
            get { return _memberlastname; }
            set { _memberlastname = value; }
        }

        public string CNIC
        {
            get { return _membercnic; }
            set { _membercnic = value; }
        }
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
        #endregion
        /// <summary>
        /// Initializes a signal from the subscriber that control has been subscribed
        /// </summary>
        public event EventHandler DataAvailable;

        /// <summary>
        /// Signal to the subscriber that new data is available
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnDataAvailable(EventArgs e)
        {
            EventHandler eh = DataAvailable;
            if (eh != null)
            {
                eh(this, e);
            }
        }
        //private void BindData(OffSet, NextRecords)
        //{
        //    dt = new DataTable();
        //    dt = Std.GetMembers(OffSet, NextRecords);
        //    dgvStdDetails.Rows.Clear();
        //    if (dt.Rows.Count > 0)
        //    {
        //        foreach (DataRow dr in dt.Rows)
        //        {

        //            if (dr["Memb_Status"].ToString() == "True") 
        //            {
        //                dgvStdDetails.Rows.Add();
        //                dgvStdDetails.Rows[dgvStdDetails.Rows.Count - 1].Cells["ColumnId"].Value = dr["Memb_MainId"];
        //                dgvStdDetails.Rows[dgvStdDetails.Rows.Count - 1].Cells["ColumnFirstName"].Value = dr["Memb_FirstName"];
        //                dgvStdDetails.Rows[dgvStdDetails.Rows.Count - 1].Cells["ColumnlastName"].Value = dr["Memb_LastName"];
        //                dgvStdDetails.Rows[dgvStdDetails.Rows.Count - 1].Cells["ColumnContact"].Value = dr["Memb_ContactNo"];
        //                dgvStdDetails.Rows[dgvStdDetails.Rows.Count - 1].Cells["ColumnEmail"].Value = dr["Memb_Email"];
        //                dgvStdDetails.Rows[dgvStdDetails.Rows.Count - 1].Cells["ColumnDateofJoin"].Value = dr["Memb_JoinDate"];
        //                dgvStdDetails.Rows[dgvStdDetails.Rows.Count - 1].Cells["ColumnDateofExpire"].Value = dr["Memb_ExpireDate"];
        //                dgvStdDetails.Rows[dgvStdDetails.Rows.Count - 1].Cells["ColumnCNIC"].Value = dr["Memb_Cnic"];
        //            }
        //        }
        //        if (dgvStdDetails.Rows.Count > 0)
        //        {
        //            dgvStdDetails.Rows[0].Selected = false;
        //        }
        //        else
        //        {
        //            MessageBox.Show("No records found!", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //            lblTotalStudentMembers.Text = "Total Members : 0";
        //        }
        //        lblTotalStudentMembers.Text = string.Format("Total Members : {0}", dgvStdDetails.Rows.Count);
        //    }
        //    else
        //    {
        //        MessageBox.Show("No records found!", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        lblTotalStudentMembers.Text = "Total Members : 0";
        //        return;
        //    }
        //}
        private void BindSearchData()
        {
            dt = new DataTable();
            dt = Std.FilterSearchData(cmbFilterStudent.Text, TextBoxSearch.Text.Trim());
            dgvStdDetails.Rows.Clear();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    dgvStdDetails.Rows.Add();
                    dgvStdDetails.Rows[dgvStdDetails.Rows.Count - 1].Cells["ColumnId"].Value = dr["Memb_MainId"];
                    dgvStdDetails.Rows[dgvStdDetails.Rows.Count - 1].Cells["ColumnFirstName"].Value = dr["Memb_FirstName"];
                    dgvStdDetails.Rows[dgvStdDetails.Rows.Count - 1].Cells["ColumnlastName"].Value = dr["Memb_LastName"];
                    dgvStdDetails.Rows[dgvStdDetails.Rows.Count - 1].Cells["ColumnContact"].Value = dr["Memb_ContactNo"];
                    dgvStdDetails.Rows[dgvStdDetails.Rows.Count - 1].Cells["ColumnEmail"].Value = dr["Memb_Email"];
                    dgvStdDetails.Rows[dgvStdDetails.Rows.Count - 1].Cells["ColumnDateofJoin"].Value = dr["Memb_JoinDate"];
                    dgvStdDetails.Rows[dgvStdDetails.Rows.Count - 1].Cells["ColumnDateofExpire"].Value = dr["Memb_ExpireDate"];
                    dgvStdDetails.Rows[dgvStdDetails.Rows.Count - 1].Cells["ColumnCNIC"].Value = dr["Memb_Cnic"];
                }
            }
            lblTotalStudentMembers.Text = string.Format("Total Members : {0}", dgvStdDetails.Rows.Count);

        }
        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxSearch.Text == "")
            {
                //BindData();
            }
            else
            {
                BindSearchData();
            }
        }
        private void dgvBookDetails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex > 7)
                return;
            else
            {
                _memberid = dgvStdDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
                _memberfirstname = dgvStdDetails.Rows[e.RowIndex].Cells[1].Value.ToString();
                _memberlastname = dgvStdDetails.Rows[e.RowIndex].Cells[2].Value.ToString();
                _membercnic = dgvStdDetails.Rows[e.RowIndex].Cells[3].Value.ToString();
                _membercontact = dgvStdDetails.Rows[e.RowIndex].Cells[4].Value.ToString();
                _memberemail = dgvStdDetails.Rows[e.RowIndex].Cells[5].Value.ToString();
                _memberjoindate = dgvStdDetails.Rows[e.RowIndex].Cells[6].Value.ToString();
                _memberexpiredate = dgvStdDetails.Rows[e.RowIndex].Cells[7].Value.ToString();

                OnDataAvailable(null);
                Close();

            }
        }

        private void Dummy2_Load(object sender, EventArgs e)
        {
            //BindData();
            cmbFilterStudent.SelectedIndex = 0;
        }
    }
}
