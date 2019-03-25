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
    class ReturnIssueBook: IssueBooks
    {
        SqlCommand cmd;
        string _returndate,_returnid,_fineperday=Properties.Settings.Default.FineOption;
        int _duedays = 0;
        double _paidamount = 0;
        public string FinePerDay 
        {
            get { return _fineperday; }
        }
        public double PaidAmount
        {
            get { return _paidamount; }
            set { _paidamount = value; }
        }
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

        public int DueDays
        {
            get { return _duedays; }
            set { _duedays = value; }
        }

        #region Methods
        public DataTable GetIssuedBooks()
        {
            var sql = "SELECT B.Bk_Booktitle AS BookTile,b.Bk_MainId AS BookId, b.Bk_Author AS Author, "+
            "CONCAT(M.Memb_FirstName,' ',M.Memb_LastName) AS HolderName,M.Memb_MainId AS HolderId, "+
            "m.Memb_Cnic AS CNIC,BI.BKISS_IssueDate AS IssueDate,BI.BKISS_DueDate AS DueDate, "+
            "CONCAT(L.Lib_FirstName,' ',L.Lib_LastName) AS Librarian,L.Lib_MainId AS LibrarianId "+
            ",BI.BKISS_id_MainId AS IssueId "+
            "FROM Book B,Member M,Librarian L,BookIssuence BI "+
            "WHERE B.Bk_MainId = BI.BKISS_Bk_Bookid AND L.Lib_MainId = BI.BkISS_Lib_fk_Libid "+
            "AND M.Memb_MainId = BI.BKISS_Memb_fk_Holderid AND BI.BKISS_Status = 1";
            cmd = new SqlCommand(sql, GlobalConnection());
            return GetTable(sql);
        }
        public bool Return()
        {
            var sql = "INSERT INTO ReturnIssueBooks(RISSBk_MainId,RISSBk_fk_IBSTD_IssueId,RISSBk_DueDate,RISSBk_FinePerDay "+
            ",RISSBk_ReturnDate ,RISSBk_Lib_fk_Libid) VALUES(@RISSBk_MainId,@RISSBk_fk_IBSTD_IssueId, " +
            "try_convert(DATETIME,@RISSBk_DueDate),@RISSBk_FinePerDay,TRY_CONVERT(DATETIME,@RISSBk_ReturnDate),@RISSBk_Lib_fk_Libid)"; 
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@RISSBk_MainId", MainId);
            cmd.Parameters.AddWithValue("@RISSBk_fk_IBSTD_IssueId", IssueIdLatest);
            cmd.Parameters.AddWithValue("@RISSBk_DueDate", DueDate);
            cmd.Parameters.AddWithValue("@RISSBk_Lib_fk_Libid", "LIB1109181");//Global.LibrarianId);
            cmd.Parameters.AddWithValue("@RISSBk_ReturnDate", ReturnDate);
            cmd.Parameters.AddWithValue("@RISSBk_FinePerDay",Fine);
            var rows=int.Parse(cmd.ExecuteNonQuery().ToString());
            cmd.Dispose();
            if (rows > 0)
            {
                Availableamount = GetAvailableAmount(BookId);
                UpdateBookAvailability(Availableamount + 1,BookId);
                UpdateBookIssueStatus(0, IssueIdLatest);
                GetFinePayment();
                if (Fine > 0) 
                {
                    CalculateDueDays();
                }
                return true;
            }
            else
                return false;
        }

        public void AddFines()
        {
            var sql = "INSERT INTO Fines(Fn_FK_MembId,Fn_FineAmount,Fn_PaidAmount) "+
            "VALUES(@Fn_FK_MembId, @Fn_FineAmount, @Fn_PaidAmount)";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@Fn_FK_MembId", MemberId);
            cmd.Parameters.AddWithValue("@Fn_FineAmount", Fine);
            cmd.Parameters.AddWithValue("@Fn_PaidAmount", PaidAmount);
            var rows = Convert.ToInt32(cmd.ExecuteNonQuery().ToString());
        }

        public bool UpdateReturn()
        {
            var sql = "UPDATE ReturnIssueBooks SET RISSBk_fk_IBSTD_IssueId = @RISSBk_fk_IBSTD_IssueId, " +
            "RISSBk_DueDate = TRY_CONVERT(DATETIME, @RISSBk_DueDate) "+
            "WHERE RISSBk_MainId = @RISSBk_MainId";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@RISSBk_fk_IBSTD_IssueId", IssueIdLatest);
            cmd.Parameters.AddWithValue("@RISSBk_DueDate", DueDate);
            cmd.Parameters.AddWithValue("@RISSBk_MainId", MainId);
            var rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            cmd.Dispose();
            if (rows > 0)
            {
                var bookid = GetBookId(IssueIdOld);
                Availableamount = GetAvailableAmount(bookid);
                UpdateBookAvailability(Availableamount - 1, bookid);
                UpdateBookIssueStatus(1,IssueIdOld);
                Availableamount = GetAvailableAmount(BookId);
                UpdateBookAvailability(Availableamount + 1, BookId);
                UpdateBookIssueStatus(0, IssueIdLatest);
                GetFinePayment();
                if (Fine > 0)
                {
                    CalculateDueDays();
                }
                return true;
            }
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

        private void GetFinePayment()
        {
            var sql = "SELECT RISSBk_CalCulatedFine FROM ReturnIssueBooks WHERE RISSBk_MainId = @RISSBk_MainId";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@RISSBk_MainId", MainId);
            Fine = Convert.ToInt32(cmd.ExecuteScalar().ToString());

        }

        private void CalculateDueDays()
        {
            var sql = "SELECT DATEDIFF(DAY,RISSBk_DueDate,GETDATE()) FROM ReturnIssueBooks "+
            "WHERE RISSBk_MainId = @RISSBk_MainId";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@RISSBk_MainId", MainId);
            DueDays = Convert.ToInt32(cmd.ExecuteScalar().ToString());
        }

        public bool FilterValidation()
        {
            if (IssueIdLatest != "" || IssueDate != "" || DueDate != "")
                return true;
            else
                return false;
        }

        public DataTable GetReturnBooksDetail(int OffSet, int Total)
        {
            int offset = OffSet;
            DataTable dt = new DataTable();
            var sql = "SELECT BKIS.BKISS_Bk_Bookid AS 'Book Id',BK.Bk_Booktitle  AS 'Book Title' "+
            ",MEM.Memb_MainId AS 'Holder Id' "+
            ",CONCAT(MEM.Memb_FirstName,' ',MEM.Memb_LastName) AS 'Holder Name' "+
            ",MEM.Memb_Cnic AS 'Holder CNIC',BKIS.BKISS_id_MainId AS 'Issue Id', "+ 
            "RBK.RISSBk_MainId AS 'Return Id',RBK.RISSBk_ReturnDate AS 'Return Date', "+ 
            "RBK.RISSBk_CalCulatedFine AS 'Fine' "+
            "FROM ReturnIssueBooks RBK,BookIssuence BKIS,Member MEM,Book BK "+
            "WHERE RBK.RISSBk_fk_IBSTD_IssueId = BKIS.BKISS_id_MainId AND BKIS.BKISS_Memb_fk_Holderid = MEM.Memb_MainId "+
            "AND BK.Bk_MainId = BKIS.BKISS_Bk_Bookid ORDER BY BKIS.BKISS_id_MainId OFFSET @OffSet ROW FETCH NEXT @Total ROW ONLY";
            try
            {
                var cmd = new SqlCommand(sql, GlobalConnection());
                cmd.Parameters.AddWithValue("@OffSet", OffSet);
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

        /// <summary>
        /// private method to get the searched item
        /// </summary>
        /// <param name="Searchby"></param>
        /// <param name="SearchText"></param>
        /// <returns></returns>
        private DataTable Search(string Searchby, string SearchText)
        {
            var sql = "SELECT * FROM Book_IssueStudent where " + Searchby + " like '%' + replace(@SearchText, '%', '[%]') + '%' and BKISStd_Status=1";
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
                    //dt = Search("ReturnIssueBooks", columns, "", SearchText, false);
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

        public DataTable FilterReturnBooksList(string ListType, string SearchText)
        {
            DataTable dt = new DataTable();
            var columns = " BKIS.BKISS_Bk_Bookid AS 'Book Id',BK.Bk_Booktitle AS 'Book Title' " +
            ",MEM.Memb_MainId AS 'Holder Id' " +
            ",CONCAT(MEM.Memb_FirstName,' ',MEM.Memb_LastName) AS 'Holder Name' " +
            ",MEM.Memb_Cnic AS 'Holder CNIC',BKIS.BKISS_id_MainId AS 'Issue Id', " +
            "RBK.RISSBk_MainId AS 'Return Id',RBK.RISSBk_ReturnDate AS 'Return Date', " +
            "RBK.RISSBk_CalCulatedFine AS 'Fine' ";
            var whereclause = " WHERE RBK.RISSBk_fk_IBSTD_IssueId = BKIS.BKISS_id_MainId AND BKIS.BKISS_Memb_fk_Holderid = MEM.Memb_MainId " +
            "AND BK.Bk_MainId = BKIS.BKISS_Bk_Bookid AND ";
            switch (ListType)
            {
                case "Issuance QR Code":
                    dt = Search("ReturnIssueBooks RBK,BookIssuence BKIS,Member MEM,Book BK", columns, "BKIS.BKISS_id_MainId", whereclause, SearchText, false);
                    break;
                case "Book Title":
                    dt = Search("ReturnIssueBooks RBK,BookIssuence BKIS,Member MEM,Book BK", columns, "BK.Bk_Booktitle", whereclause, SearchText, false);
                    break;
                //case "Book Author":
                //    dt = Search("ReturnIssueBooks RBK,BookIssuence BKIS,Member MEM,Book BK", columns, "BK.Bk_Author", whereclause, SearchText, false);
                //    break;
                case "Book Holder":
                    dt = Search("ReturnIssueBooks RBK,BookIssuence BKIS,Member MEM,Book BK", columns, "CONCAT(MEM.Memb_FirstName,' ',MEM.Memb_LastName)", whereclause, SearchText, false);
                    break;
                case "Holder CNIC":
                    dt = Search("ReturnIssueBooks RBK,BookIssuence BKIS,Member MEM,Book BK", columns, "MEM.Memb_Cnic", whereclause, SearchText, false);
                    break;
                case "Return Date":
                    dt = Search("ReturnIssueBooks RBK,BookIssuence BKIS,Member MEM,Book BK", columns, "CONVERT(VARCHAR(225),RBK.RISSBk_ReturnDate,1)", whereclause, SearchText, false);
                    break;
                case "Fine":
                    dt = Search("ReturnIssueBooks RBK,BookIssuence BKIS,Member MEM,Book BK", columns, "RBK.RISSBk_CalCulatedFine", whereclause, SearchText, false);
                    break;
            }
            return dt;
        }

        public string getMainId()
        {
            var sql = "DECLARE @TODAY DATETIME,@MONTH VARCHAR(2),@DAY VARCHAR(2),@YEAR INT,@IDENT INT; "+
            "SET @TODAY = GETDATE(); "+
            "SET @MONTH =  CASE WHEN MONTH(@TODAY) < 10 THEN CONCAT('0',MONTH(@TODAY)) "+
            "ELSE CAST(MONTH(@TODAY) AS VARCHAR(2)) END; "+
            "SET @DAY = CASE WHEN DAY(@TODAY) < 10 THEN CONCAT('0',DAY(@TODAY)) "+
            "ELSE CAST(DAY(@TODAY) AS VARCHAR(2)) END; "+
            "SET @YEAR = YEAR(@TODAY); "+
            "SELECT @IDENT = IDENT_CURRENT('ReturnIssueBooks')+1 "+
            "SELECT 'RISSBK' + RIGHT(CAST(@DAY AS varchar(2))+CAST(@MONTH AS VARCHAR(2))+ "+
            "CAST((@YEAR%100) AS VARCHAR(2)) + "+
            "CAST(@IDENT AS VARCHAR(2)),15) ";
            cmd = new SqlCommand(sql, GlobalConnection());
            var id = cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            return id;
        }
        public DataTable GetIssuanceInfo(string IssuanceId)
        {
            var sql = "SELECT BKISS.BKISS_Bk_Bookid AS BOOKID,BK.Bk_Booktitle AS BOOKTITLE, "+
            "BK.Bk_BookPic AS BOOKIMAGE, BKISS.BKISS_DueDate AS DUEDATE, "+
            "CONCAT(Memb.Memb_FirstName,' ',Memb_LastName) AS MEMBERNAME, Memb.Memb_MainId AS MEMBERID, " +
            "Memb.Memb_Cnic AS MEMBERCNIC,Memb.Memb_Pic AS MEMBERIMAGE FROM BookIssuence BKISS,Book BK,Member Memb "+
            "WHERE BKISS_id_MainId = @BKISS_id_MainId AND BKISS_Status = 1 " +
            "AND BK.Bk_MainId = BKISS.BKISS_Bk_Bookid AND Memb.Memb_MainId = BKISS.BKISS_Memb_fk_Holderid"; 
            cmd = new SqlCommand(sql, GlobalConnection());
            var x = GetTable(sql, "@BKISS_id_MainId", IssuanceId);
            return x;
        }
        public bool ValidateIfTheBookIsIssued(string barcodeIssuance)
        {
            var sql = "SELECT COUNT(BKISS_id_MainId) FROM BookIssuence WHERE BKISS_id_MainId = @BKISS_id_MainId AND BKISS_Status = 1";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@BKISS_id_MainId", barcodeIssuance);
            var rows = int.Parse(cmd.ExecuteScalar().ToString());
            if (rows > 0)
            {
                return true;
            }
            else
                return false;
        }

        public int CountReturnData()
        {
            var sqL = "SELECT COUNT(1) FROM ReturnIssueBooks";
            cmd = new SqlCommand(sqL, GlobalConnection());
            var rows = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            cmd.Dispose();
            return rows;
        }
        #endregion
    }
}
