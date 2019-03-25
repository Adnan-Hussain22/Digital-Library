using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital Library.Lib
{
    class ReturnReserveBooks : ReserveBookStaff
    {
        SqlCommand cmd;
        string _returndate, _returnid;
        public string ReturnDate
        {
            get { return _returndate; }
            set { _returndate = value; }
        }
        public string ReturnId
        {
            get { return _returnid; }
            set { _returnid = value; }
        }
        #region Methods
        public DataTable GetReservedBooks()
        {
            var sql = "SELECT * FROM Book_IssueStudent WHERE RISSBk_MainId=@RISSBk_MainId";
            cmd = new SqlCommand(sql, GlobalConnection());
            return GetTable(sql, "@RISSBk_MainId", IssueIdLatest);
        }
        public bool Return()
        {
            var sql = "INSERT INTO ReturnReserveBooks(RRSBk_fk_BISSTFF_IssueId,RRSBk_fk_Bk_Bookid,RRSBk_BookTitle,RRSBk_HolderId,"
            + "RRSBk_Holder,RRSBk_IssueDate,RRSBk_DueDate,RRSBk_FinePerDay) VALUES(@RRSBk_fk_BISSTFF_IssueId, @RRSBk_fk_Bk_Bookid,"
            + "@RRSBk_BookTitle, @RRSBk_HolderId,@RRSBk_Holder, @RRSBk_IssueDate, @RRSBk_DueDate, @RRSBk_FinePerDay)";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@RRSBk_fk_BISSTFF_IssueId", IssueIdLatest);
            cmd.Parameters.AddWithValue("@RRSBk_fk_Bk_Bookid", BookId);
            cmd.Parameters.AddWithValue("@RRSBk_BookTitle", BookName);
            cmd.Parameters.AddWithValue("@RRSBk_HolderId", MemberId);
            cmd.Parameters.AddWithValue("@RRSBk_Holder", FirstName);
            cmd.Parameters.AddWithValue("@RRSBk_IssueDate", IssueDate);
            cmd.Parameters.AddWithValue("@RRSBk_DueDate", DueDate);
            cmd.Parameters.AddWithValue("@RRSBk_FinePerDay", 10);
            var rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            cmd.Dispose();
            if (rows > 0)
            {
                Availableamount = GetAvailableAmount(BookId);
                UpdateBookAvailability(Availableamount + 1,BookId);
                UpdateReservedBookStatus();
                return true;
            }
            else
                return false;
        }
        public bool UpdateReturn()
        {
            var sql = "UPDATE ReturnIssueBooks SET RISSBk_fk_Bk_Bookid=@RISSBk_fk_Bk_Bookid,RISSBk_BookTitle=@RISSBk_BookTitle,"
            + "RISSBk_HolderId = @RISSBk_HolderId,RISSBk_Holder = @RISSBk_Holder,@RISSBk_IssueDate = @RISSBk_IssueDate,"
            + "RISSBk_DueDate = @RISSBk_DueDate,RISSBk_Fine = @RISSBk_Fine"
            + "WHERE RISSBk_MainId = @RISSBk_MainId";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@RISSBk_fk_Bk_Bookid", BookId);
            cmd.Parameters.AddWithValue("@RISSBk_BookTitle", BookName);
            cmd.Parameters.AddWithValue("@RISSBk_HolderId", MemberId);
            cmd.Parameters.AddWithValue("@RISSBk_Holder", FirstName);
            cmd.Parameters.AddWithValue("@RISSBk_IssueDate", IssueDate);
            cmd.Parameters.AddWithValue("@RISSBk_DueDate", DueDate);
            cmd.Parameters.AddWithValue("@RISSBk_Fine", Fine);
            cmd.Parameters.AddWithValue("@RISSBk_MainId", _returnid);
            var rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            cmd.Dispose();
            if (rows > 0)
                return true;
            else
                return false;
        }
        public bool DeleteReturn()
        {
            var sql = "DELETE FROM ReturnIssueBooks WHERE RISSBk_MainId=@RISSBk_MainId";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@RISSBk_MainId", _returnid);
            var rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            cmd.Dispose();
            if (rows > 0)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Method to return the current main id
        /// </summary>
        /// <returns></returns>
        public string ReturnMainId()
        {
            var sql = "SELECT 'RSSBK' + RIGHT('00000' + CAST(IDENT_CURRENT('ReturnReserveBooks') AS VARCHAR(15)), 15)";
            cmd = new SqlCommand(sql, GlobalConnection());
            var MainId=cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            return MainId;
        }
        /// <summary>
        /// Methos to return the max main id
        /// </summary>
        /// <returns></returns>
        public string MaxMainId()
        {
            var sql ="SELECT MAX(RRSBk_MainId) FROM ReturnReserveBooks";
            cmd = new SqlCommand(sql, GlobalConnection());
            var MaxId = cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            return MaxId;
        }
        /// <summary>
        /// Method to update the fine
        /// </summary>
        /// <param name="MainId"></param>
        /// <returns></returns>
        /*public void UpdateFine(string MainId)
        {
             GetFine();
            var fine = 0;
            if (fine < 0)
            {
                var mainid = MainId;
                var sql = "UPDATE ReturnReserveBooks SET RRSBk_Fined=0 WHERE RRSBk_MainId=@MainId";
                cmd = new SqlCommand(sql, GlobalConnection());
                cmd.Parameters.AddWithValue("MainId", mainid);
                var rows = int.Parse(cmd.ExecuteNonQuery().ToString());
                cmd.Dispose();
            }
            else
            {
                var mainid = MainId;
                var sql = "UPDATE ReturnReserveBooks SET RRSBk_Fined=@RRSBk_Fined WHERE RRSBk_MainId=@MainId";
                cmd = new SqlCommand(sql, GlobalConnection());
                cmd.Parameters.AddWithValue("MainId", mainid);
                cmd.Parameters.AddWithValue("RRSBk_Fined", fine);
                var rows = int.Parse(cmd.ExecuteNonQuery().ToString());
                cmd.Dispose();
            }
           
        }*/
        public void GetFine()
        {
            var MainId = MaxMainId();
            var sql = "SELECT RRSBk_Fined FROM ReturnReserveBooks WHERE RRSBk_MainId=@RRSBk_MainId";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@RRSBk_MainId", MainId);
            var fine = cmd.ExecuteScalar();
            cmd.Dispose();

        }
        public bool FilterValidation()
        {
            if (IssueIdLatest != "" && BookId != "" && BookName != "" && MemberId != "" && FirstName != "" && IssueDate != "" && DueDate != "")
                return true;
            else
                return false;
        }
        /// <summary>
        /// private method to get the searched item
        /// </summary>
        /// <param name="Searchby"></param>
        /// <param name="SearchText"></param>
        /// <returns></returns>
        private DataTable Search(string Searchby, string SearchText)
        {
            var sql = "SELECT * FROM Book_IssueStaff where " + Searchby + " like '%' + replace(@SearchText, '%', '[%]') + '%'";
            return GetTable(sql, "@SearchText", SearchText);
        }
        /// <summary>
        /// Method to search a record by a desired selection
        /// </summary>
        /// <param name="ListType"></param>
        /// <param name="SearchText"></param>
        /// <returns></returns>
        public DataTable SearchNonReturningList(string ListType, string SearchText)
        {
            DataTable dt = new DataTable();
            switch (ListType)
            {
                case "Book Id":
                    dt = Search("BKISStd_Bk_Bookid", SearchText);
                    break;
                case "Book Title":
                    dt = Search("BKISStd_BookName", SearchText);
                    break;
                case "Book Author":
                    dt = Search("BKISStd_Author", SearchText);
                    break;
                case "Book Holder":
                    dt = Search("BKISStd_BookHolder", SearchText);
                    break;
                case "Staff Id":
                    dt = Search("BKISStd_GrNo", SearchText);
                    break;
                case "Issue Date":
                    dt = Search("BKISStd_IssueDate", SearchText);
                    break;
                case "Due Date":
                    dt = Search("BKISStd_DueDate", SearchText);
                    break;
            }
            return dt;
        }
        #endregion
    }
}

