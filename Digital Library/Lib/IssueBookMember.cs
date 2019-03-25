using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital Library.Lib
{
    class IssueBookMember:Lib.MemberInfo
    {
        SqlCommand cmd;
        string _issueidlates, _issueidold, _issuedate,_duedate,_bookid,_bookname,_bookauthor;
        int _availableamount;
        double _fine = 0;
        public string IssueIdLatest
        {
            get { return _issueidlates; }
            set { _issueidlates = value; }
        }
        public string IssueIdOld
        {
            get { return _issueidold; }
            set { _issueidold = value; }
        }
        public string IssueDate
        {
            get { return _issuedate; }
            set { _issuedate = value; }
        }
        public string DueDate
        {
            get { return _duedate; }
            set { _duedate = value; }
        }
        public double Fine
        {
            get { return _fine; }
            set { _fine = value; }
        }
        public string BookId
        {
            get { return _bookid; }
            set { _bookid = value; }
        }
        public string BookName
        {
            get { return _bookname; }
            set { _bookname = value; }
        }
        public string Author
        {
            get { return _bookauthor; }
            set { _bookauthor = value; }
        }

        public int Availableamount
        {
            get { return _availableamount; }
            set
            {
                _availableamount = value;
            }
        }
        public string SearchItem
        {
            get;
            set;
        }

        protected int UpdateBookAvailability(int Availability,string BookIdMain)
        {
            var sql = "UPDATE Book SET Bk_Availability=@Bk_Availability where Bk_MainId=@Bk_MainId";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@Bk_MainId", BookIdMain);
            cmd.Parameters.AddWithValue("@Bk_Availability", Availability);
            var rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            cmd.Dispose();
            return rows;
        }
        //FilterAvailabiltyAmount
        //GetAvailableAmount
        public int GetAvailableAmount(string BookIdMain)
        {
            var sql = "SELECT Bk_Availability FROM Book WHERE Bk_MainId=@Bk_MainId ";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@Bk_MainId", BookIdMain);
            var rows = int.Parse(cmd.ExecuteScalar().ToString());
            cmd.Dispose();
            return rows;
        }
        public bool FilterAvailabiltyAmount()
        {
            var sql = "SELECT Bk_Availability FROM Book WHERE Bk_MainId=@Bk_MainId ";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@Bk_MainId", BookId);
            var rows = int.Parse(cmd.ExecuteScalar().ToString());
            cmd.Dispose();
            if (rows > 0)
                return true;
            else
                return false;
        }
        public string GetBookId(string IssueId)
        {
            var sql = "SELECT BKISS_Bk_Bookid FROM BookIssuence WHERE BKISS_id_MainId = @BKISS_id_MainId";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@BKISS_id_MainId", IssueId);
            var id = cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            return id;
        }
    }
}
