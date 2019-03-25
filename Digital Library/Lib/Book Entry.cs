using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Drawing;

namespace Digital Library.Lib
{
    class Book_Entry : Lib.Editor
    {
        SqlCommand cmd;
        string _imagelocation = "";
        int _booknoofbooks;
        #region Book
        #region Variables
        string _booktitle = "", _bookauthor = "", _bookjointauthor = "", _bookdepartment = "", _bookidmain = "",
       _bookedition = "", _supplier = "", _bookpublisher = "", _bookdetails = "", _librarianid = "", _bookstatus = "";
        int _noofcopies = 0, _bookpublishyear = 0;
        float _bookprice = 0;
        private byte[] _getimageinbytes = null;
        #endregion
        #region Properties
        public string BookIdMain
        {
            get { return _bookidmain; }
            set { _bookidmain = value; }
        }
        public string Title
        {
            get
            {
                return _booktitle;
            }
            set
            {
                _booktitle = value;
            }
        }
        public string Author
        {
            get { return _bookauthor; }
            set { _bookauthor = value; }
        }
        public string JointAuthor
        {
            get
            {
                return _bookjointauthor;
            }
            set
            {
                _bookjointauthor = value;
            }
        }
        public string Edition
        {
            get
            {
                return _bookedition;
            }
            set
            {
                _bookedition = value;
            }
        }
        public string Publisher
        {
            get { return _bookpublisher; }
            set { _bookpublisher = value; }
        }
        public int YearofPublish
        {
            get
            {
                return _bookpublishyear;
            }
            set
            {
                _bookpublishyear = value;
            }
        }
        public float Price
        {
            get
            {
                return _bookprice;
            }
            set
            {
                _bookprice = value;
            }
        }
        public string Details
        {
            get
            {
                return _bookdetails;
            }
            set
            {
                _bookdetails = value;
            }
        }
        public string Status
        {
            get
            {
                return _bookstatus;
            }
            set
            {
                _bookstatus = value;
            }
        }
        public int NoOfCopies
        {
            get { return _noofcopies; }
            set { _noofcopies = value; }
        }
        public long ISBN
        {
            get { return _isbn; }
            set { _isbn = value; }
        }

        public string Supplier
        {
            get { return _supplier; }
            set { _supplier = value; }
        }
        public int DecrementNoOfCopies
        {
            get { return _noofcopies; }
            set { _noofcopies = value - 1; }
        }

        public byte[] GetImageInBytes
        {
            get { return _getimageinbytes; }
            set { _getimageinbytes = value; }
        }

        #endregion
        #region Methods
        public bool AddBook()
        {
            if (!FilterBook())
            {
                var sql = "INSERT INTO Book(Bk_MainId,Bk_Booktitle,Bk_Subject,Bk_Category,Bk_Edition,Bk_Publisher,Bk_Price, " +
                "Bk_Availability,Bk_Supplier,Bk_Details,Bk_Status,Bk_ISBN,Bk_PublicationYear,Bk_Lib_fk_id,Bk_BookPic) " +
                "VALUES(@Bk_MainId, @Bk_Booktitle, @Bk_Subject, @Bk_Category, @Bk_Edition, @Bk_Publisher, @Bk_Price, @Bk_Availability, @Bk_Supplier " +
                ", @Bk_Details, @Bk_Status, @Bk_ISBN, @Bk_PublicationYear, @Bk_Lib_fk_id,@Bk_BookPic)";
                cmd = new SqlCommand(sql, GlobalConnection());
                cmd.Parameters.AddWithValue("@Bk_MainId", _bookidmain);
                cmd.Parameters.AddWithValue("@Bk_Booktitle", _booktitle);
                //cmd.Parameters.AddWithValue("@Bk_Author", _bookauthor);
                cmd.Parameters.AddWithValue("@Bk_Subject", _subjectid);
                cmd.Parameters.AddWithValue("@Bk_Category", _categoryId);
                cmd.Parameters.AddWithValue("@Bk_Edition", _bookedition);
                cmd.Parameters.AddWithValue("@Bk_Publisher", Publisher);
                cmd.Parameters.AddWithValue("@Bk_Price", _bookprice);
                cmd.Parameters.AddWithValue("@Bk_Availability", _noofcopies);
                cmd.Parameters.AddWithValue("@Bk_Supplier", _supplier);
                cmd.Parameters.AddWithValue("@Bk_Details", _bookdetails);
                cmd.Parameters.AddWithValue("@Bk_Status", 1);
                cmd.Parameters.AddWithValue("@Bk_ISBN", _isbn);
                cmd.Parameters.AddWithValue("@Bk_PublicationYear", YearofPublish);
                cmd.Parameters.AddWithValue("@Bk_BookPic", (GetImageInBytes == null) ? (object)DBNull.Value : GetImageInBytes).SqlDbType = SqlDbType.Image;
                //cmd.Parameters.AddWithValue("@Bk_Shlf_FK_Shelf", ShelfMainId);
                cmd.Parameters.AddWithValue("@Bk_Lib_fk_id", "LIB1109181");//Global.LibrarianId
                var rows = int.Parse(cmd.ExecuteNonQuery().ToString());
                cmd.Dispose();
                if (rows > 0)
                {
                    //UpdateShelfStatus(ShelfMainId, GetShelfCapacity(ShelfMainId));
                    AddBkEditor();
                    return true;
                }
                else
                    return false;
            }
            else
            {
                var amount = GetAvailabilityAmount();
                _noofcopies = amount + _noofcopies;
                _bookidmain = FilterMainId();
                var sql = "UPDATE Book SET Bk_Availability=@Bk_Availability WHERE Bk_MainId=@Bk_MainId";
                cmd = new SqlCommand(sql, GlobalConnection());
                cmd.Parameters.AddWithValue("@Bk_Availability", _noofcopies);
                cmd.Parameters.AddWithValue("@Bk_MainId", _bookidmain);
                var rows = int.Parse(cmd.ExecuteNonQuery().ToString());
                cmd.Dispose();
                if (rows > 0)
                    return true;
                else
                    return false;
            }
        }

        public bool AddBkEditor()
        {
            var sql = "INSERT INTO BkEditor(BKED_ED_FK_EDId,BKED_BK_FK_BKId) " +
            "VALUES(@BKED_ED_FK_EDId, @BKED_BK_FK_BKId)";
            var rows = 0;
            for (var i = 0; i < EditorId.Length; i++)
            {
                cmd = new SqlCommand(sql, GlobalConnection());
                cmd.Parameters.AddWithValue("@BKED_ED_FK_EDId", EditorId[i]);
                cmd.Parameters.AddWithValue("@BKED_BK_FK_BKId", BookIdMain);
                rows = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            if (rows > 0)
                return true;
            else
                return false;

        }
        public bool UpdateBook()
        {
            string sql =
            "UPDATE Book SET Bk_Booktitle = CASE WHEN @TITLE <> '' THEN @TITLE ELSE Bk_Booktitle END " +
            //", Bk_Author   = CASE WHEN @AUTHOR <> '' THEN @AUTHOR ELSE Bk_Author END "+
            ",  Bk_Subject = CASE WHEN @SUBJECT <> 0 THEN @SUBJECT ELSE Bk_Subject END " +
            ",  Bk_Category = CASE WHEN @CATEGORY <> 0 THEN @CATEGORY ELSE Bk_Category END " +
            ",  Bk_Edition = CASE WHEN @EDITION <> '' THEN @EDITION ELSE Bk_Edition END " +
            ",  Bk_Publisher = CASE WHEN @PUBLISHER <> '' THEN @PUBLISHER ELSE Bk_Publisher END " +
            ",  Bk_Price = CASE WHEN @PRICE <> 0 THEN @PRICE ELSE Bk_Price END " +
            ",  Bk_Availability = CASE WHEN @AVAIALABILIT <> 0 THEN @AVAIALABILIT ELSE Bk_Availability END " +
            ",  Bk_Supplier = CASE WHEN @SUPLIER <> '' THEN @SUPLIER ELSE Bk_Supplier END " +
            ",  Bk_Details = CASE WHEN @DETAILS <> '' THEN @DETAILS ELSE Bk_Details END " +
            ",  Bk_ISBN = CASE WHEN @ISBN <> 0 THEN @ISBN ELSE Bk_ISBN END " +
            ",  Bk_PublicationYear = CASE WHEN @PUBLISHYEAR <> 0 THEN @PUBLISHYEAR ELSE Bk_PublicationYear END " +
            ",  Bk_Lib_fk_id = CASE WHEN @LIBRARIANID <> '' THEN @LIBRARIANID ELSE Bk_Lib_fk_id END " +
            ",  Bk_BookPic = @Image " +
            "WHERE Bk_MainId = @MainId";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@TITLE", _booktitle);
            //cmd.Parameters.AddWithValue("@AUTHOR", _bookauthor);
            cmd.Parameters.AddWithValue("@SUBJECT", _subjectid);
            cmd.Parameters.AddWithValue("@CATEGORY", _categoryId);
            cmd.Parameters.AddWithValue("@EDITION", _bookedition);
            cmd.Parameters.AddWithValue("@SUPLIER", _supplier);
            cmd.Parameters.AddWithValue("@PUBLISHER", _bookpublisher);
            cmd.Parameters.AddWithValue("@PRICE", _bookprice);
            cmd.Parameters.AddWithValue("@DETAILS", _bookdetails);
            cmd.Parameters.AddWithValue("@AVAIALABILIT", _noofcopies);
            cmd.Parameters.AddWithValue("@ISBN", _isbn);
            cmd.Parameters.AddWithValue("@PUBLISHYEAR", _bookpublishyear);
            cmd.Parameters.AddWithValue("@MainId", _bookidmain);
            cmd.Parameters.AddWithValue("@Image", (GetImageInBytes == null) ? (object)DBNull.Value : GetImageInBytes).SqlDbType = SqlDbType.Image;
            cmd.Parameters.AddWithValue("@LIBRARIANID", Global.LibrarianId);
            var rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            cmd.Dispose();
            if (rows > 0)
                return true;
            else
                return false;
            //return ExecuteFullQuery(sql);
        }
        public int GetAvailabilityAmount()
        {
            var _bookidmain = FilterMainId();
            var sql = "SELECT Bk_Availability FROM Book WHERE Bk_MainId=@Bk_MainId";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@Bk_MainId", _bookidmain);
            var amount = cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            return int.Parse(amount);
        }
        public bool DeleteBook()
        {
            var sql = "DELETE FROM Book WHERE Bk_MainId=@Bk_MainId";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@Bk_MainId", _bookidmain);
            var rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            cmd.Dispose();
            if (rows > 0)
                return true;
            else
                return false;
        }
        public int CountBooks()
        {
            var sql = "SELECT COUNT(*) FROM Book";
            cmd = new SqlCommand(sql, GlobalConnection());
            var count = int.Parse(cmd.ExecuteScalar().ToString());
            cmd.Dispose();
            return count;
        }
        public bool FilterStdIssuence()
        {
            var sql = "SELECT COUNT(BKISS_id) FROM BookIssuence WHERE BKISS_Bk_Bookid=@BKISS_Bk_Bookid" +
            " and BKISS_Status=1";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@BKISS_Bk_Bookid", _bookidmain);
            var rows = int.Parse(cmd.ExecuteScalar().ToString());
            cmd.Dispose();
            if (rows > 0)
                return true;
            else
                return false;
        }
        public bool FilterStaffIssuence()
        {
            var sql = "SELECT COUNT(BKISStff_id) FROM Book_IssueStaff WHERE BKISStff_Bk_Bookid=@BKISStff_Bk_Bookid " +
            "AND BKISStff_Status=1";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@BKISStff_Bk_Bookid", _bookidmain);
            //var rows = int.Parse(cmd.ExecuteScalar().ToString());
            var rows = 0;
            cmd.Dispose();
            if (rows > 0)
                return true;
            else
                return false;
        }
        public bool FilterNoOfCopies()
        {
            var amount = GetAvailabilityAmount();
            if (amount > 0)
                return true;
            else
                return false;
        }
        private string FilterMainId()
        {
            var sql1 = "SELECT Bk_MainId FROM Book WHERE Bk_Booktitle=@Bk_Booktitle and Bk_BookCLass=@Bk_BookCLass and Bk_Category=@Bk_Category and Bk_Subject=@Bk_Subject and Bk_Author=@Bk_Author and Bk_Edition=@Bk_Edition";
            cmd = new SqlCommand(sql1, GlobalConnection());
            cmd.Parameters.AddWithValue("@Bk_Booktitle", Title);
            cmd.Parameters.AddWithValue("@Bk_BookCLass", ClassName);
            cmd.Parameters.AddWithValue("@Bk_Category", BookCategory);
            cmd.Parameters.AddWithValue("@Bk_Subject", Subject);
            cmd.Parameters.AddWithValue("@Bk_Author", Author);
            cmd.Parameters.AddWithValue("@Bk_Edition", Edition);
            var s = cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            cmd.Dispose();
            cmd.Cancel();
            return s;
        }
        private bool FilterBook()
        {
            var sql1 = "SELECT COUNT(Bk_BooKid) FROM Book WHERE Bk_ISBN = @Bk_ISBN";
            cmd = new SqlCommand(sql1, GlobalConnection());
            cmd.Parameters.AddWithValue("@Bk_ISBN", ISBN);
            //cmd.Parameters.AddWithValue("@Bk_BookCLass", ClassName);
            //cmd.Parameters.AddWithValue("@Bk_Category", BookCategory);
            //cmd.Parameters.AddWithValue("@Bk_Subject", Subject);
            //cmd.Parameters.AddWithValue("@Bk_Author", Author);
            //cmd.Parameters.AddWithValue("@Bk_Edition", Edition);
            var rows = int.Parse(cmd.ExecuteScalar().ToString());
            cmd.Dispose();
            if (rows > 0)
            {
                return true;
            }
            else
                return false;
        }
        public DataTable GetBooks()
        {
            return GetTable("SELECT * FROM Book");
        }

        public DataTable FilterBookList(string ListType, string SearchText)
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
                case "Author":
                    dt = Search("Book", "Bk_Author", SearchText, false);
                    break;
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
        public bool FilterData()
        {
            var sql = "SELECT COUNT(Bk_Booktitle) FROM BOOK WHERE Bk_Booktitle LIKE '%" + _booktitle + "%'";
            return ExecuteScalerQuery(sql);
        }
        public bool Filter()
        {
            string sql = "select count(Bk_BooKid) from Book where Bk_BooKid='" + BookIdMain + "'";
            return ExecuteScalerQuery(sql);
        }
        /// <summary>
        /// To check all the feilds are not null
        /// </summary>
        /// <param name="Null"></param>
        /// <returns></returns>
        public bool Filter(string Null)
        {
            if (_bookedition != Null && _booktitle != Null && _noofcopies != 0 && CategoryId != 0 && SubjectId != 0 && _bookpublisher != Null
                && _isbn != 0 && YearofPublish != 0 && _supplier != Null && EditorId != null)
                return true;
            else
                return false;
        }
        public string GetBookId()
        {
            string sql = "DECLARE @TODAY DATETIME,@YEAR INT ,@MONTH VARCHAR(2),@DAY VARCHAR(2),@IDENT INT,@COUNT INT; " +
            "SELECT @TODAY = GETDATE(); " +
            "SELECT @IDENT = IDENT_CURRENT('Book')+1 " +
            "SET @MONTH =  CASE WHEN MONTH(@TODAY) < 10 THEN CONCAT('0',MONTH(@TODAY)) " +
            "ELSE CAST(MONTH(@TODAY) AS VARCHAR(2)) END; " +
            "SET @DAY = CASE WHEN DAY(@TODAY) < 10 THEN CONCAT('0',DAY(@TODAY)) " +
            "ELSE CAST(DAY(@TODAY) AS VARCHAR(2)) END; " +
            "SET @YEAR = YEAR(@TODAY); " +
            "SELECT 'BK' + RIGHT(CAST(@DAY AS VARCHAR(2))+CAST(@MONTH AS VARCHAR(2))+ " +
            "CAST((CAST((@YEAR)%100 AS VARCHAR(2))) AS VARCHAR(2))+ " +
            "CAST(@IDENT AS VARCHAR(255)),15);";
            SqlCommand cmd = new SqlCommand(sql, GlobalConnection());
            var id = cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            return id;
        }

        public string GetBookId(string query)
        {
            SqlCommand cmd = new SqlCommand(query, GlobalConnection());
            var sql = cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            return sql;
        }
        public void UpdateStatus(int Status)
        {
            var Mainid = GetFilterAvailability();
            var sql = "Update Book Set Bk_Status=@Bk_Status WHERE Bk_MainId=@Bk_MainId";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@Bk_Status", Status);
            cmd.Parameters.AddWithValue("@Bk_MainId", Mainid);
            cmd.ExecuteNonQuery().ToString();
            cmd.Dispose();
        }
        public bool FilterBookAvailability()
        {
            var sql = "SELECT COUNT(Bk_BooKid) FROM Book WHERE Bk_Availability=0 AND Bk_Status=1";
            return ExecuteScalerQuery(sql);
        }
        public string GetFilterAvailability()
        {
            var sql = "SELECT Bk_MainId FROM Book WHERE Bk_Availability=0 AND Bk_Status=1";
            cmd = new SqlCommand(sql, GlobalConnection());
            return cmd.ExecuteScalar().ToString();
        }
        public bool TruncteBook()
        {
            var sql = "truncate table Book";
            cmd = new SqlCommand(sql, GlobalConnection());
            var rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            cmd.Dispose();
            if (rows > 0)
                return true;
            else
                return false;
        }
        public DataTable SearchDetails(string ListType, string Text)
        {
            DataTable dt = new DataTable();
            switch (ListType)
            {
                case "All":
                    dt = GetTable("select * from Book");
                    break;
                case "book name":
                    dt = GetTable("select * from Book where Bk_Booktitle like '[" + Text + "]%_'");
                    break;
                case "category":
                    dt = GetTable("select * from Book where Bk_fk_Cat_Category like '[" + Text + "]%_'");
                    break;
            }
            return dt;
        }
        private bool BindData(string query)
        {
            DataTable dt = new DataTable();
            dt = GetTable(query);
            if (dt.Rows.Count > 0)
            {
                BookIdMain = dt.Rows[0]["Bk_BooKid"].ToString();
                _booktitle = dt.Rows[0]["Bk_Booktitle"].ToString();
                //_bookauthor = dt.Rows[0]["Bk_Author"].ToString();
                _bookjointauthor = dt.Rows[0]["Bk_Jointauthor"].ToString();
                _booksubject = dt.Rows[0]["Bk_Subject"].ToString();
                _bookdepartment = dt.Rows[0]["Bk_Departement"].ToString();
                _bookedition = dt.Rows[0]["Bk_Edition"].ToString();
                //_bookpublisher = dt.Rows[0]["Bk_Publisher"].ToString();
                _bookpublishyear = int.Parse(dt.Rows[0]["Bk_Publishyeare"].ToString());
                //_bookprice = dt.Rows[0]["Bk_Price"].ToString();

                return true;
            }
            else
                return false;
        }
        public DataTable GetPaginatedBookData(int OffSet, int Total)
        {
            int offset = OffSet;
            DataTable dt = new DataTable();
            var sql = "SELECT * FROM Book ORDER BY Bk_BooKid OFFSET @OffSet ROW FETCH NEXT @Total ROW ONLY";
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

        public DataTable GetPaginatedAvailableBookData(int OffSet, int Total)
        {
            int offset = OffSet;
            DataTable dt = new DataTable();
            var sql = "SELECT * FROM Book WHERE Bk_Status = 1 ORDER BY Bk_BooKid OFFSET @OffSet ROW FETCH NEXT @Total ROW ONLY";
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

        #endregion
        #endregion
        #region Class
        #region Variables
        string _classid, _classname;
        #endregion
        #region Properties
        public string ClassId
        {
            get { return _classid; }
            set { _classid = value; }
        }
        public string ClassName
        {
            get { return _classname; }
            set { _classname = value; }
        }


        #endregion
        #region Methods
        public bool AddClass()
        {
            string sql = "insert into Class(Class_Name) values(@Class_Name)";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@Class_Name", ClassName);
            int rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            cmd.Dispose();
            if (rows > 0)
                return true;
            else
                return false;
        }
        public bool UpdateClass()
        {
            string sql = "update class set Class_Name=@Class_Name where Class_Id=@Class_Id";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@Class_Name", ClassName);
            cmd.Parameters.AddWithValue("@Class_Id", ClassId);
            int rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            cmd.Dispose();
            if (rows > 0)
                return true;
            else
                return false;
        }
        public bool DeleteClass()
        {
            string sql = "delete from class where Class_Id=@Class_Id";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@Class_Id", ClassId);
            int rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            cmd.Dispose();
            if (rows > 0)
                return true;
            else
                return false;
        }
        public bool TruncateClass()
        {
            string sql = "truncate table Class";
            cmd = new SqlCommand(sql, GlobalConnection());
            int rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            cmd.Dispose();
            if (rows > 0)
                return true;
            else
                return false;
        }
        public bool ValidationClass()
        {
            if (ClassName != "")
                return true;
            else
                return false;
        }
        public DataTable GetClasses()
        {
            var sql = "SELECT CONCAT(Bk_BookCLass,'  ','[ ',CAST(COUNT(Bk_BookCLass) AS varchar),' ]') AS Class_Name FROM Book GROUP BY Bk_BookCLass";
            return GetTable(sql);
        }
        public bool FilterClasses()
        {
            var sql = "select count (Class_Name) from Class where Class_Name=@ClassName";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@ClassName", ClassName);
            var rows = int.Parse(cmd.ExecuteScalar().ToString());
            cmd.Dispose();
            if (rows > 0)
                return true;
            else
                return false;
        }
        public DataTable SearchClasses()
        {
            var sql = "SELECT Class_Id,Class_Name FROM Class WHERE Class_Name like '%" + _classname + "%'";
            return GetTable(sql);
        }
        public DataTable GetClassesWiseBook()
        {
            var sql = "select Bk_BookCLass as Class, COUNT(Bk_Booktitle) as [Total Books] from Book where Bk_BookCLass like'%" + ClassName + "%' group by Bk_BookCLass order by Bk_BookCLass asc";
            return GetTable(sql);
        }
        #endregion
        #endregion
        #region Category
        #region Variables
        string _bookcategory;
        int _categoryId;
        #endregion
        #region Properties 
        public string BookCategory
        {
            get
            {
                return _bookcategory;
            }
            set
            {
                _bookcategory = value;
            }
        }
        public int CategoryId
        {
            get
            {
                return _categoryId;
            }
            set
            {
                _categoryId = value;
            }
        }
        #endregion
        #region Methods
        public bool AddCategory()
        {
            string sql = "insert into Category values('" + _bookcategory + "')";
            return ExecuteFullQuery(sql);
        }
        public DataTable LoadBookCategory()
        {
            string sql = "SELECT CONCAT(Bk_Category,'  ','[ ',CAST(COUNT(Bk_Category) AS varchar),' ]') AS Cat_BookCategory FROM Book GROUP BY Bk_Category";
            return GetTable(sql);
        }

        public DataTable LoadCategory()
        {
            string sql = "SELECT * FROM Category";
            return GetTable(sql);
        }

        public DataTable CategorizeWiseBook()
        {
            string sql = "select Bk_fk_Cat_Category as Category, count(Bk_Booktitle) as [Total Books] from Book group by Bk_fk_Cat_Category";
            return GetTable(sql);
        }
        public DataTable GetCategorizeWiseBook()
        {
            var sql = "select Bk_Category as Category, COUNT(Bk_Booktitle) as [Total Books] from Book where Bk_Category like '%" + BookCategory + "%'  group by Bk_Category order by Bk_Category asc";
            return GetTable(sql);
        }
        public DataTable SearchCategories()
        {
            var sql = "SELECT Cat_Id,Cat_BookCategory FROM Category WHERE Cat_BookCategory LIKE '%" + _bookcategory + "%' ";
            return GetTable(sql);
        }
        public bool AvailabilityCategory()
        {
            string sql = "select count(Cat_BookCategory) from Category where Cat_BookCategory='" + _bookcategory + "'";
            return ExecuteScalerQuery(sql);
        }

        public int GetCategoryId()
        {
            int Id = 0;
            try
            {
                string sql = "SELECT Cat_Id FROM Category WHERE Cat_BookCategory = @Cat_BookCategory";
                cmd = new SqlCommand(sql, GlobalConnection());
                cmd.Parameters.AddWithValue("@Cat_BookCategory", BookCategory);
                Id = int.Parse(cmd.ExecuteNonQuery().ToString());
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Global.CaptionLib, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            return Id;
        }
        public bool UpdateCategory()
        {
            var sql = "UPDATE Category SET Cat_BookCategory=@Cat_BookCategory WHERE Cat_Id=@Cat_Id";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@Cat_Id", CategoryId);
            cmd.Parameters.AddWithValue("@Cat_BookCategory", BookCategory);
            var rows = Convert.ToInt32(cmd.ExecuteNonQuery().ToString());
            cmd.Dispose();
            if (rows > 0)
                return true;
            else
                return false;
        }
        public bool DeleteCategory()
        {
            var sql = "DELETE FROM Category WHERE Cat_Id=@Cat_Id";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@Cat_Id", CategoryId);
            int rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            cmd.Dispose();
            if (rows > 0)
                return true;
            else
                return false;
        }
        #endregion
        #endregion
        #region Subject
        #region Variables
        string _booksubject = "";
        private int _subjectid = 0;
        private long _isbn;
        #endregion
        #region Properties
        public int SubjectId
        {
            get
            {
                return _subjectid;
            }
            set
            {
                _subjectid = value;
            }
        }
        public string Subject
        {
            get
            {
                return _booksubject;
            }
            set
            {
                if (value != "")
                    _booksubject = value;
            }
        }
        #endregion
        #region Methods
        public bool AddSubject()
        {
            var sql = "INSERT INTO Subject(Sub_BookSubject) VALUES(@SubjectName)";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@SubjectName", Subject);
            var rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            cmd.Dispose();
            if (rows > 0)
                return true;
            else
                return false;
        }
        public bool UpdateSubject()
        {
            var sql = "Update Subject set Sub_BookSubject=@SubjectName WHERE Sub_Id=@SubjectId";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@SubjectName", Subject);
            cmd.Parameters.AddWithValue("@SubjectId", SubjectId);
            var rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            cmd.Dispose();
            if (rows > 0)
                return true;
            else
                return false;
        }
        public bool DeleteSubject()
        {
            var sql = "DELETE FROM Subject WHERE Sub_Id=@SubjectId ";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@SubjectId", SubjectId);
            var rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            cmd.Dispose();
            if (rows > 0)
                return true;
            else
                return false;
        }
        public DataTable SearchSubject()
        {
            var sql = "SELECT * FROM Subject WHERE Sub_BookSubject LIKE '%" + Subject + "%'";
            return GetTable(sql);
        }

        public DataTable LoadBookSubjects()
        {
            var sql = "SELECT CONCAT(Bk_Subject,'  ','[ ',CAST(COUNT(BK_Subject) AS varchar),' ]') AS Sub_BookSubject FROM Book GROUP BY Bk_Subject";
            return GetTable(sql);
        }

        public DataTable GetSubjects()
        {
            var sql = "SELECT * FROM Subject";
            return GetTable(sql);
        }
        public int GetSubjectyId()
        {
            int Id = 0;
            try
            {
                string sql = "SELECT Sub_Id FROM Subject WHERE Sub_BookSubject = @Sub_BookSubject";
                cmd = new SqlCommand(sql, GlobalConnection());
                cmd.Parameters.AddWithValue("@Sub_BookSubject", Subject);
                Id = int.Parse(cmd.ExecuteNonQuery().ToString());
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Global.CaptionLib, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            return Id;
        }

        public bool SubjectValidation()
        {
            if (Subject != "")
                return true;
            else
                return false;
        }
        public bool SubjectAvailability()
        {
            string sql = "select count(Sub_BookSubject) from Subject where Sub_BookSubject='" + _bookcategory + "'";
            return ExecuteScalerQuery(sql);
        }
        #endregion
        #endregion

        public string Department
        {
            get
            {
                return _bookdepartment;
            }
            set
            {
                if (value != "")
                    _bookdepartment = value;
            }
        }
        public string LibrarianId
        {
            get
            {
                return _librarianid;
            }
            set
            {
                if (value != "")
                    _librarianid = value;
            }
        }




        public static string GetImageLoction
        {
            get;
            set;
        }

        #region Class



        public DataTable GetClassification()
        {
            var sql = "select Bk_Category as Category, Bk_BookCLass as Class from Book ";
            return GetTable(sql);
        }


        #endregion
        //private byte[] ImageLength()
        //{
        //    FileStream fs = new FileStream(GetImageLoction, FileMode.Open, FileAccess.Read);
        //    BinaryReader br = new BinaryReader(fs);
        //    img = br.ReadBytes((int)fs.Length);
        //    return img;
        //} 
    }
}
