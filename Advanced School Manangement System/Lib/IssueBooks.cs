using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advanced_School_Manangement_System.Lib
{
    class IssueBooks:Lib.IssueBookMember 
    {
        #region Objects and Variables
        string _cnic,_mainid;
        SqlCommand cmd;
        #endregion

        #region Properties
        //public string GrNo
        //{
        //    get { return _grno; }
        //    set { _grno = value; }
        //}
        public string MainId
        {
            get { return _mainid; }
            set { _mainid = value; }
        }
        #endregion

        #region Methods 
        /// <summary>
        /// Method to issue to a book to the student
        /// </summary>
        /// <returns></returns>
        public bool IssueBook()
        {
            var sql = "INSERT INTO BookIssuence(BKISS_id_MainId,BKISS_Bk_Bookid,BKISS_Memb_fk_Holderid, "+
            "BKISS_IssueDate,BKISS_DueDate,BkISS_Lib_fk_Libid,BKISS_Status) "+
            "VALUES(@BKISS_id_MainId,@BKISS_Bk_Bookid,@BKISS_Memb_fk_Holderid, "+
            "try_convert(DATETIME,@BKISS_IssueDate),try_convert(DATETIME,@BKISS_DueDate),@LibrarianId,1)";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@BKISS_id_MainId", _mainid);
            cmd.Parameters.AddWithValue("@BKISS_Bk_Bookid", BookId);
            cmd.Parameters.AddWithValue("@BKISS_Memb_fk_Holderid", MemberId);
            cmd.Parameters.AddWithValue("@BKISS_IssueDate", IssueDate);
            cmd.Parameters.AddWithValue("@BKISS_DueDate", DueDate);
            cmd.Parameters.AddWithValue("@LibrarianId", "LIB1109181");//Global.LibrarianId);
            var rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            cmd.Dispose();
            if (rows > 0)
            {
                UpdateBookAvailability(GetAvailableAmount(BookId)-1,BookId);
                UpdateBookStatus(BookId, 0);
                return true;
            }
            else
                return false;
        }

        private void UpdateBookStatus(string bookId, int Status)
        {
            var sql = "UPDATE BOOK SET Bk_Status = @Status WHERE Bk_Availability = 0 AND Bk_MainId = @BookId";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@BookId", bookId);
            cmd.Parameters.AddWithValue("@Status", Status);
            var rows = cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        /// <summary>
        /// Method to update the desired record
        /// </summary>
        /// <returns></returns>
        public bool Update()
        {
            var BookIdMain=GetBookId(IssueIdLatest);
            var sql = "UPDATE BookIssuence SET BKISS_Bk_Bookid = @BKISS_Bk_Bookid,BKISS_Memb_fk_Holderid = @BKISS_Memb_fk_Holderid " +
            "WHERE BKISS_id_MainId  = @BKISS_id_MainId";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@BKISS_Bk_Bookid", BookId);
            cmd.Parameters.AddWithValue("@BKISS_Memb_fk_Holderid", MemberId);
            cmd.Parameters.AddWithValue("@BKISS_id_MainId", IssueIdLatest);
            var rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            cmd.Dispose();
            if (rows > 0)
            {
                UpdateBookAvailability(GetAvailableAmount(BookIdMain)+1,BookIdMain);
                UpdateBookAvailability(GetAvailableAmount(BookId)-1,BookId);
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// Method to delete the desired record
        /// </summary>
        /// <returns></returns>
        public bool Delete()
        {
            var sql = "DELETE FROM BookIssuence WHERE BKISS_id_MainId=@BKISS_id_MainId";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@BKISS_id_MainId", IssueIdLatest);
            var rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            cmd.Dispose();
            if (rows > 0)
            {
                var Availableamoun = GetAvailableAmount(BookId);
                UpdateBookAvailability(Availableamoun + 1, BookId);
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// Gets the main id of issuence just to display to the user
        /// </summary>
        /// <returns></returns>
        public string GetMainId()
        {
            var sql = "DECLARE @TODAY DATETIME,@MONTH VARCHAR(2),@DAY VARCHAR(2),@YEAR INT,@IDENT INT; "+
            "SET @TODAY = GETDATE(); "+
            "SET @MONTH =  CASE WHEN MONTH(@TODAY) < 10 THEN CONCAT('0',MONTH(@TODAY)) "+ 
            "ELSE CAST(MONTH(@TODAY) AS VARCHAR(2)) END; "+
            "SET @DAY = CASE WHEN DAY(@TODAY) < 10 THEN CONCAT('0',DAY(@TODAY)) "+
            "ELSE CAST(DAY(@TODAY) AS VARCHAR(2)) END; "+
            "SET @YEAR = YEAR(@TODAY); "+
            "SELECT @IDENT = IDENT_CURRENT('BookIssuence')+1 "+
            "SELECT 'BKISS' + RIGHT(CAST(@DAY AS varchar(2))+CAST(@MONTH AS VARCHAR(2))+ "+
            "CAST((@YEAR%100) AS VARCHAR(2)) + "+
            "CAST(@IDENT AS VARCHAR(2)),15) ";  
            cmd = new SqlCommand(sql, GlobalConnection());
            return cmd.ExecuteScalar().ToString();
        }
        private string GetBookId(string IssueId)
        {
            var sql = "SELECT BKISS_Bk_Bookid FROM BookIssuence WHERE BKISS_id_MainId=@BKISS_id_MainId";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@BKISS_id_MainId", IssueId);
            var BookId = cmd.ExecuteScalar().ToString();
            return BookId;
        }
        /// <summary>
        /// Fiters the membership of the student return true
        /// if the mebership is not expired and return false if the mebership is expired
        /// </summary>
        /// <returns></returns>
        public bool FilterMemberStatus()
        {
            var sql = "select COUNT(Memb_Status) from Member where Memb_MainId=@Memb_MainId AND Memb_Status=1";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@Memb_MainId", MemberId);
            var rows = int.Parse(cmd.ExecuteScalar().ToString());
            if (rows > 0)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Filters the data of memeber as if the
        /// member have more than 5 books pending
        /// </summary>
        /// <returns></returns>
        public bool FilterIssuence(int issueAmount)
        {
            var sql = "SELECT COUNT(BKISS_id) FROM BookIssuence WHERE BKISS_Memb_fk_Holderid=@BKISS_Memb_fk_Holderid and BKISS_Status=1";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@BKISS_Memb_fk_Holderid", MemberId);
            var rows = int.Parse(cmd.ExecuteScalar().ToString());
            if (rows > issueAmount)
                return true;
            else
                return false;

        }
        /// <summary>
         /// Gets the complete Issuence Table
         /// </summary>
         /// <returns></returns>
        public DataTable GetData()
        {
            var sql = "SELECT B.Bk_Booktitle AS BookTile,b.Bk_MainId AS BookId,  b.Bk_Author AS Author, " +
            "CONCAT(M.Memb_FirstName,' ',M.Memb_LastName) AS HolderName,M.Memb_MainId AS HolderId, "+
            "m.Memb_Cnic AS CNIC,BI.BKISS_IssueDate AS IssueDate,BI.BKISS_DueDate AS DueDate, "+
            "CONCAT(L.Lib_FirstName,' ',L.Lib_LastName) AS Librarian,L.Lib_MainId AS LibrarianId "+
            ",BI.BKISS_id_MainId AS IssueId "+
            "FROM Book B,Member M,Librarian L,BookIssuence BI "+
            "WHERE B.Bk_MainId = BI.BKISS_Bk_Bookid AND L.Lib_MainId = BI.BkISS_Lib_fk_Libid "+
            "AND M.Memb_MainId = BI.BKISS_Memb_fk_Holderid"; 
            return GetTable(sql);
        }

        public DataTable GetPaginatedData(int OffSet, int Total)
        {
            int offset = OffSet;
            DataTable dt = new DataTable();
            var sql = "SELECT B.Bk_Booktitle AS BookTile,b.Bk_MainId AS BookId," +
            "CONCAT(M.Memb_FirstName,' ',M.Memb_LastName) AS HolderName,M.Memb_MainId AS HolderId, " +
            "m.Memb_Cnic AS CNIC,BI.BKISS_IssueDate AS IssueDate,BI.BKISS_DueDate AS DueDate, " +
            "CONCAT(L.Lib_FirstName,' ',L.Lib_LastName) AS Librarian,L.Lib_MainId AS LibrarianId " +
            ",BI.BKISS_id_MainId AS IssueId " +
            "FROM Book B,Member M,Librarian L,BookIssuence BI " +
            "WHERE B.Bk_MainId = BI.BKISS_Bk_Bookid AND L.Lib_MainId = BI.BkISS_Lib_fk_Libid " +
            "AND M.Memb_MainId = BI.BKISS_Memb_fk_Holderid ORDER BY Mem_id OFFSET @OffSet ROW FETCH NEXT @Total ROW ONLY";
            try
            {
                var cmd = new SqlCommand(sql, GlobalConnection());
                cmd.Parameters.AddWithValue("@OffSet", offset);
                cmd.Parameters.AddWithValue("@Total", Total);
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(dt);
                adpt.Dispose();
                offset += offset;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Global.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public DataTable FilterIssuanceList(string ListType, string SearchText)
        {
            DataTable dt = new DataTable();
            switch (ListType)
            {
                case "QR Code":
                    dt = Search("Book", "Bk_MainId", SearchText, false);
                    break;
                case "Title":
                    dt = Search("Book", "Bk_Booktitle", SearchText, false);
                    break;
                //case "Author":
                //    dt = Search("Book", "Bk_Author", SearchText, false);
                //    break;
                case "Category":
                    dt = Search("Book", "Bk_Category", SearchText, false);
                    break;
                case "Subject":
                    dt = Search("Book", "Bk_Subject", SearchText, false);
                    break;
                case "Edition":
                    dt = Search("Book", "Bk_Edition", SearchText, false);
                    break;
                case "Publisher":
                    dt = Search("Book", "Bk_Publisher", SearchText, false);
                    break;
                case "Supplier":
                    dt = Search("Book", "Bk_Supplier", SearchText, false);
                    break;
                case "ISBN":
                    dt = Search("Book", "Bk_ISBN", SearchText, false);
                    break;
            }
            return dt;
        }

        public int CountData()
        {
            var sqL = "SELECT COUNT(1) FROM BookIssuence";
            cmd = new SqlCommand(sqL, GlobalConnection());
            var rows = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            cmd.Dispose();
            return rows;
        }

        public DataTable FilterBook(string BookId)
        {
            var sql = "SELECT Bk_Booktitle FROM Book WHERE Bk_MainId = @Bk_MainId";
            return GetTable(sql, "@Bk_MainId",BookId);
        }

        public DataTable FilterMember(string MemberId)
        {
            var sql = "SELECT Memb_FirstName,Memb_LastName,Memb_Cnic FROM Member WHERE Memb_MainId = @Memb_MainId";
            return GetTable(sql, "@Memb_MainId", MemberId);
        }

        /// <summary>
        /// private method to get the searched item
        /// </summary>
        /// <param name="Searchby"></param>
        /// <param name="SearchText"></param>
        /// <returns></returns>
        private DataTable Search(string Searchby, string SearchText)
        {
            var sql = "SELECT * FROM BookIssuence where " + Searchby + " like '%' + replace(@SearchText, '%', '[%]') + '%'";
            return GetTable(sql, "@SearchText", SearchText);
        }
        /// <summary>
        /// Method to search a record by a desired selection
        /// </summary>
        /// <param name="ListType"></param>
        /// <param name="SearchText"></param>
        /// <returns></returns>
        public DataTable SearchList(string ListType, string SearchText)
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
                case "Gr-No":
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
        public bool FilterIssuenceStatus()
        {
            var sql = "SELECT BKISS_Status FROM BookIssuence WHERE BKISS_id_MainId=@BKISS_id_MainId";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@BKISS_id_MainId", IssueIdLatest);
            var status=cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            if (status =="True" || status == "true")
                return true;
            else
                return false;
        }
        public bool UpdateBookIssueStatus(int status,string IssueId)
        {
            var sql = "UPDATE BookIssuence SET BKISS_Status=@BKISS_Status WHERE BKISS_id_MainId=@BKISS_id_MainId";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@BKISS_id_MainId", IssueId);
            cmd.Parameters.AddWithValue("@BKISS_Status", status);
            var rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            cmd.Dispose();
            if (rows > 0)
                return true;
            else
                return false;

        }
        /// <summary>
        /// Gets the current Main id
        /// </summary>
        /// <returns></returns>
        private string GetCurrentIdentity()
        {
            var sql = "SELECT IDENT_CURRENT('BOOK_ISSUESTUDENT')";
            cmd = new SqlCommand(sql, GlobalConnection());
            return cmd.ExecuteScalar().ToString();
        }
        /// <summary>
        /// Reseeds the identity
        /// </summary>
        public void ReseedId()
        {
            var sql = "DBCC CHECKIDENT ('BOOK_ISSUESTUDENT', RESEED,@CurrentIdenity)";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@CurrentIdenity", GetCurrentIdentity());
            cmd.ExecuteScalar().ToString();
        }
        #endregion


    }
}
