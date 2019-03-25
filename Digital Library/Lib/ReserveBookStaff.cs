using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Digital Library.Lib
{
    class ReserveBookStaff:Lib.IssueBookMember
    {
        SqlCommand cmd;
        #region Variables
        string _staffid;
        #endregion

        #region Properties
        public string StaffId
        {
            get { return _staffid; }
            set { _staffid = value; }
        }
        #endregion 
        
        #region Methods
        /// <summary>
        /// Method to reserve a book for the staff member
        /// </summary>
        /// <returns></returns>
        public bool ReserveBook()
        {
            var sql = "INSERT INTO Book_IssueStaff(BKISStff_BookHolder,BKISStff_Author,BKISStff_BookName,BKISStff_Bk_Bookid," +
            "BKISStff_IssueDate,BKISStff_DueDate,BKISStff_MemStff_fk_Holderid,BkISStff_Lib_fk_Libid,"+
            "BKISStff_StaffId,BKISStff_Status)VALUES(@BKISStff_BookHolder,@BKISStff_Author,@BKISStff_BookName,@BKISStff_Bk_Bookid," +
            "try_convert(DATETIME,@BKISStff_IssueDate),try_convert(DATETIME,@BKISStff_DueDate),@BKISStff_MemStff_fk_Holderid, 'L-1234',@BKISStff_StaffId,1)";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@BKISStff_MemStff_fk_Holderid", MemberId);
            cmd.Parameters.AddWithValue("@BKISStff_BookHolder", FirstName);
            cmd.Parameters.AddWithValue("@BKISStff_Bk_Bookid", BookId);
            cmd.Parameters.AddWithValue("@BKISStff_BookName", BookName);
            cmd.Parameters.AddWithValue("@BKISStff_StaffId", _staffid);
            cmd.Parameters.AddWithValue("@BKISStff_Author", Author);
            cmd.Parameters.AddWithValue("@BKISStff_IssueDate", IssueDate);
            cmd.Parameters.AddWithValue("@BKISStff_DueDate", DueDate);
            var rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            if (rows > 0)
            {
                UpdateBookAvailability(Availableamount-1,BookId);
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// Method to update a desired record
        /// </summary>
        /// <returns></returns>
        public bool Update()
        {
            var BookIdMain = GetBookId(IssueIdLatest);
            var sql = "UPDATE Book_IssueStaff SET BKISStff_Bk_Bookid=@BKISStff_Bk_Bookid, BKISStff_BookName=@BKISStff_BookName,"+
            "BKISStff_MemStff_fk_Holderid = @BKISStff_MemStff_fk_Holderid, BKISStff_BookHolder = @BKISStff_BookHolder,"+
            "BKISStff_StaffId = @BKISStff_StaffId,BKISStff_Author = @BKISStff_Author,BKISStff_IssueDate = try_convert(datetime, @BKISStff_IssueDate),"+
            "BKISStff_DueDate = try_convert(datetime, @BKISStff_DueDate) WHERE BKISStff_id_MainId = @BKISStff_id_MainId";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@BKISStff_Bk_Bookid", BookId);
            cmd.Parameters.AddWithValue("@BKISStff_BookName", BookName);
            cmd.Parameters.AddWithValue("@BKISStff_Author", Author);
            cmd.Parameters.AddWithValue("@BKISStff_MemStff_fk_Holderid", MemberId);
            cmd.Parameters.AddWithValue("@BKISStff_BookHolder", FirstName);
            cmd.Parameters.AddWithValue("@BKISStff_StaffId", StaffId);
            cmd.Parameters.AddWithValue("@BKISStff_IssueDate", IssueDate);
            cmd.Parameters.AddWithValue("@BKISStff_DueDate", DueDate);
            cmd.Parameters.AddWithValue("@BKISStff_id_MainId", IssueIdLatest);
            var rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            if (rows > 0)
            {
                UpdateBookAvailability(GetAvailableAmount(BookIdMain) + 1, BookIdMain);
                UpdateBookAvailability(GetAvailableAmount(BookId) - 1, BookId);
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// Method to delete a specific record
        /// </summary>
        /// <returns></returns>
        public bool Delete()
        {
            var BookIdMain = GetBookId(IssueIdLatest);
            var sql = "DELETE FROM Book_IssueStaff WHERE BKISStff_id_MainId=@BKISStff_id_MainId";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@BKISStff_id_MainId", IssueIdLatest);
            var rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            if (rows > 0)
            {
                UpdateBookAvailability(GetAvailableAmount(BookIdMain) + 1, BookIdMain);
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// Gets the main id of issuence, just to display for the user
        /// </summary>
        /// <returns></returns>
        public string GetReserveMainId()
        {
            var sql = "SELECT 'ISTFID' + RIGHT('00000' + CAST(IDENT_CURRENT('Book_IssueStaff')+1 AS VARCHAR(8)), 8)";
            cmd = new SqlCommand(sql, GlobalConnection());
            var MainId = cmd.ExecuteScalar().ToString();
            return MainId;
        }
        private string GetBookId(string IssueId)
        {
            var sql = "SELECT BKISStff_Bk_Bookid FROM Book_IssueStaff WHERE BKISStff_id_MainId=@BKISStff_id_MainId";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@BKISStff_id_MainId", IssueId);
            var BookId = cmd.ExecuteScalar().ToString();
            return BookId;
        }
        /// <summary>
        /// Filters the membership of the staff, returns true
        /// if the membership is not expired and returns false if the membership is expired
        /// </summary>
        /// <returns></returns>
        public bool FilterMemberStatus()
        {
            var sql = "select COUNT(MemStff_MainId) from MemberStaff where MemStff_MainId=@MemStff_MainId AND MemStff_Status=1";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@MemStff_MainId", MemberId);
            var rows = int.Parse(cmd.ExecuteScalar().ToString());
            if (rows > 0)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Method to filter the book reservaton
        /// </summary>
        /// <returns></returns>
        public bool FilterReservation()
        {
            var sql = "SELECT COUNT(BKISStff_id) FROM Book_IssueStaff WHERE BKISStff_MemStff_fk_Holderid=@BKISStff_MemStff_fk_Holderid";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@BKISStff_MemStff_fk_Holderid", MemberId);
            var rows = int.Parse(cmd.ExecuteScalar().ToString());
            if (rows > 5)
                return true;
            else
                return false;

        }
        /// <summary>
        /// Method to get the complete table
        /// </summary>
        /// <returns></returns>
        public DataTable GetData()
        {
            var sql = "SELECT * FROM Book_IssueStaff";
            return GetTable(sql);
        }
        /// <summary>
        /// private method to get the searched item
        /// </summary>
        /// <param name="Searchby"></param>
        /// <param name="SearchText"></param>
        /// <returns></returns>
        private DataTable Search(string Searchby, string SearchText)
        {
            var sql = "SELECT * FROM Book_IssueStaff where "+Searchby+ " like '%' + replace(@SearchText, '%', '[%]') + '%'";
            return GetTable(sql, "@SearchText", SearchText);
        }
        /// <summary>
        /// Method to search a record by a desired selection
        /// </summary>
        /// <param name="ListType"></param>
        /// <param name="SearchText"></param>
        /// <returns></returns>
        public DataTable SearchList(string ListType,string SearchText)
        {
            DataTable dt = new DataTable();
            switch(ListType)
            {
                case "Book Id":
                    dt = Search("BKISStff_Bk_Bookid", SearchText);
                    break;
                case "Book Title":
                    dt = Search("BKISStff_BookName", SearchText);
                    break;
                case "Book Author":
                    dt = Search("BKISStff_Author", SearchText);
                    break;
                case "Book Holder":
                    dt = Search("BKISStff_BookHolder", SearchText);
                    break;
                case "Staff Id":
                    dt = Search("BKISStff_StaffId", SearchText);
                    break;
                case "Issue Date":
                    dt = Search("BKISStff_IssueDate", SearchText);
                    break;
                case "Due Date":
                    dt = Search("BKISStff_DueDate", SearchText);
                    break;
            }
            return dt;
        }
        /// <summary>
        /// Method tot update the book status as reserved
        /// </summary>
        /// <returns></returns>
        public bool UpdateReservedBookStatus()
        {
            var sql = "UPDATE Book_IssueStaff SET BKISStff_Status=0 WHERE BKISStff_id_MainId=@BKISStff_id_MainId";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@BKISStff_id_MainId", IssueIdLatest);
            var rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            cmd.Dispose();
            if (rows > 0)
                return true;
            else
                return false;

        }

        #endregion
    }
}
