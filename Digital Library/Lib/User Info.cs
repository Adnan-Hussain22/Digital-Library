using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital Library.Lib
{
    public class User_Info:Lib.Database_Connection
    {
        string _usertype="",_useremail="",_userpassword="",_useractive="";
        string _mainid="",_contactno="",_firstname="", _lastname = "", _status="",_gender="";
        SqlCommand cmd;
        private string _address;
        private byte[] _getimageinbytes;

        public string UserType
        {
            get { return _usertype; }
            set
            {
                if (value != "")
                    _usertype = value;
            }
        }
        public string Email
        {
            get { return _useremail; }
            set
            {
                if (value != "")
                    _useremail = value;
            }
        }
        public string Password
        {
            get { return _userpassword; }
            set
            {
                if (value != "")
                    _userpassword = value;
            }
        }
        public string UserActive
        {
            get { return _useractive; }
            set
            {
                if (value != "")
                    _useractive = value;
            }
        }
        public string MainId
        {
            get
            {
                return _mainid;
            }
            set
            { _mainid = value; }
        }
        public string ContactNo
        {
            get
            {
                return _contactno;
            }
            set
            {
                if (value != "")
                    _contactno = value;
            }
        }
        public string FirstName
        {
            get
            {
                return _firstname;
            }
            set
            {
                _firstname = value;
            }
        }
        public string LastName
        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;
            }
        }

        public string Gender
        {
            get { return _gender; }
            set
            {
                    _gender = value;
            }
        }
        public string Address
        {
            get { return _address; }
            set
            {
                _address = value;
            }
        }
        public string Status
        {
            get
            {
                return _status;
            }
            set
            {
                    _status = value;
            }
        }
        public byte[] GetImageInBytes
        {
            get { return _getimageinbytes; }
            set { _getimageinbytes = value; }
        }
        //Update , Delete, Insert//
        public bool AddLibrarian()
        {
            string sql = "insert into Librarian(Lib_MainId,Lib_Password,Lib_FirstName,Lib_LastName,Lib_Gender,Lib_ContactNo,Lib_Email,Lib_Pic,Lib_Address,Lib_Type) " +
            "values(@Lib_MainId,@Lib_Password,@Lib_FirstName,@Lib_LastName,@Lib_Gender,@Lib_ContactNo,@Lib_Email,@Lib_Pic,@Lib_Address,@Lib_Type)";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@Lib_MainId",MainId);
            cmd.Parameters.AddWithValue("@Lib_Password", Password);
            cmd.Parameters.AddWithValue("@Lib_FirstName", FirstName);
            cmd.Parameters.AddWithValue("@Lib_LastName", LastName);
            cmd.Parameters.AddWithValue("@Lib_Email", Email);
            cmd.Parameters.AddWithValue("@Lib_ContactNo", ContactNo);
            cmd.Parameters.AddWithValue("@Lib_Gender", Gender);
            cmd.Parameters.AddWithValue("@Lib_Address", Address);
            cmd.Parameters.AddWithValue("@Lib_Type", UserType);
            cmd.Parameters.AddWithValue("@Lib_Pic", (GetImageInBytes == null) ? (object)DBNull.Value : GetImageInBytes).SqlDbType = SqlDbType.Image;
            var rows=int.Parse(cmd.ExecuteNonQuery().ToString());
            cmd.Dispose();
            if (rows > 0)
            {
                return true;
            }
            else
                return false;
        }

        public bool UpdateUser()
        {
            string sql = 
            "UPDATE Librarian SET Lib_Password = CASE WHEN @PASSWORD <> '' THEN @PASSWORD ELSE Lib_Password END "+
            ",  Lib_FirstName = CASE WHEN @FIRSTNAME <> '' THEN @FIRSTNAME ELSE Lib_FirstName END "+
            ",  Lib_LastName = CASE WHEN @LASTNAME <> '' THEN @LASTNAME ELSE Lib_LastName END "+
            ",  Lib_Gender = CASE WHEN @GENDER <> '' THEN @GENDER ELSE Lib_Gender END "+
            ",  Lib_ContactNo = CASE WHEN @CONTACTNO <> '' THEN @CONTACTNO ELSE Lib_ContactNo END "+
            ",  Lib_Address = CASE WHEN @ADDRESS <> '' THEN @ADDRESS ELSE Lib_Address END "+
            ",  Lib_Email = CASE WHEN @EMAIL <> '' THEN @EMAIL ELSE Lib_Email END "+
            ", Lib_Pic = @Image "+
            "WHERE Lib_MainId = @Lib_MainId";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@PASSWORD", Password);
            cmd.Parameters.AddWithValue("@FIRSTNAME", FirstName);
            cmd.Parameters.AddWithValue("@LASTNAME", LastName);
            cmd.Parameters.AddWithValue("@GENDER", Gender);
            cmd.Parameters.AddWithValue("@CONTACTNO", ContactNo);
            cmd.Parameters.AddWithValue("@ADDRESS", Address);
            cmd.Parameters.AddWithValue("@EMAIL", Email);
            cmd.Parameters.AddWithValue("@Lib_MainId", MainId);
            cmd.Parameters.AddWithValue("@Image", GetImageInBytes);
            var rows=int.Parse(cmd.ExecuteNonQuery().ToString());
            cmd.Dispose();
            if (rows > 0)
            {
                return true;
            }
            else
                return false;
        }
        public bool DeleteUser()
        {
            try
            {
                string sql = "DELETE FROM Librarian WHERE Lib_MainId = @Lib_MainId";
                cmd = new SqlCommand(sql, GlobalConnection());
                cmd.Parameters.AddWithValue("@Lib_MainId", MainId);
                var rows = int.Parse(cmd.ExecuteNonQuery().ToString());
                cmd.Dispose();
                if (rows > 0)
                {
                    return true;
                }
                else
                    return false;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        public DataTable GetLibrarians(int OffSet, int Total)
        {
            int offset = OffSet;
            DataTable dt = new DataTable();
            var sql = "SELECT * FROM Librarian ORDER BY Lib_Id OFFSET @OffSet ROW FETCH NEXT @Total ROW ONLY";
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
        public string GetMainId()
        {
            var sql = "DECLARE @TODAY DATETIME,@YEAR INT,@MONTH VARCHAR(2),@DAY VARCHAR(2), @IDENT INT,@COUNT INT; " +
            "SELECT @TODAY = GETDATE(); "+
            "SELECT @IDENT = IDENT_CURRENT('Librarian')+1 "+
            "SET @MONTH =  CASE WHEN MONTH(@TODAY) < 10 THEN CONCAT('0',MONTH(@TODAY)) "+
            "ELSE CAST(MONTH(@TODAY) AS VARCHAR(2)) END; "+
            "SET @DAY = CASE WHEN DAY(@TODAY) < 10 THEN CONCAT('0',DAY(@TODAY)) "+
            "ELSE CAST(DAY(@TODAY) AS VARCHAR(2)) END; "+
            "SET @YEAR = YEAR(@TODAY); "+
            "SELECT 'LIB' + RIGHT(CAST(@DAY AS VARCHAR(2))+CAST(@MONTH AS VARCHAR(2))+ "+
            "CAST((CAST((@YEAR)%100 AS VARCHAR(2))) AS VARCHAR(2))+ "+
            "CAST(@IDENT AS VARCHAR(255)),15);";
            cmd = new SqlCommand(sql, GlobalConnection());
            var MainId = cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            return MainId;
        }
        public int CountLibrarains()
        {
            var sql = "SELECT COUNT(1) FROM Librarian";
            cmd = new SqlCommand(sql, GlobalConnection());
            var rows = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            return rows;
        }
        public bool Validation()
        {
            if (FirstName != "" && LastName != "" && Password != "" && Email != "" && ContactNo != "" && Address != "") 
                return true;
            else
                return false;
        }
     /* public bool ChangeUserid()
        {
            string sql = "update LoginU set Lu_Email='"+_useremail+"' where Lu_id="+_userid+"";
            return ExecuteFullQuery(sql);
        }*/
        public bool ChangePassword()
        {
            string sql = "update ULogin set UL_Password='"+_userpassword+"' where UL_Userid='"+_mainid+"' and UL_Email='"+_useremail+"'";
            return ExecuteFullQuery(sql);
        }
        public bool Login()
        {
            bool check;
            var sql = "select COUNT(1) from Librarian where Lib_MainId=@LibrarianId AND Lib_Type =@Lib_Type";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@LibrarianId", MainId);
            cmd.Parameters.AddWithValue("@Lib_Type", UserType);
            var rows = Convert.ToInt64(cmd.ExecuteScalar().ToString());
            cmd.Dispose();
            if (rows > 0)
                check = true;
            else
                check = false;

            if (check == true)
            {
                sql = "select COUNT(1) from Librarian where Lib_Password=@Password AND Lib_MainId = @LibrarianId AND Lib_Type =@Lib_Type";
                cmd = new SqlCommand(sql, GlobalConnection());
                cmd.Parameters.AddWithValue("@Password", _userpassword);
                cmd.Parameters.AddWithValue("@LibrarianId", MainId);
                cmd.Parameters.AddWithValue("@Lib_Type", UserType);
                rows = Convert.ToInt64(cmd.ExecuteScalar().ToString());
                cmd.Dispose();
                if (rows > 0)
                    check = true;
                else
                    check = false;

                if (check == true)
                {
                    sql = "SELECT Lib_Type FROM Librarian WHERE Lib_MainId = @LibrarianId";
                    cmd = new SqlCommand(sql, GlobalConnection());
                    cmd.Parameters.AddWithValue("@LibrarianId", MainId);
                    Global.LibrarianType = cmd.ExecuteScalar().ToString();
                    cmd.Dispose();
                }
            }
            return check;
       }
        public bool Available()
        {
            string sql1 = "select COUNT(UL_Userid) from ULogin where UL_Userid='" + _mainid + "'";
            bool check = ExecuteScalerQuery(sql1);
            return check;
        }
        public DataTable GetData()
        {
            string sql = "select * from ULogin";
            Lib.Database_Connection DC = new Database_Connection();
            return DC.GetTable(sql);
        }

        public DataTable FilterLibrarianList(string ListType, string SearchText)
        {
            DataTable dt = new DataTable();
            switch (ListType)
            {
                case "ID":
                    dt = Search("Librarian", "Lib_MainId", SearchText, false);
                    break;
                case "Name":
                    dt = Search("Librarian", "RTRIM(LTRIM(CONCAT(Lib_FirstName, ' ',Lib_LastName)))", SearchText, false);
                    break;
                case "Gender":
                    dt = Search("Librarian", "Lib_Gender", SearchText, false);
                    break;
                case "Contact No":
                    dt = Search("Librarian", "Lib_ContactNo", SearchText, false);
                    break;
                case "Address":
                    dt = Search("Librarian", "Lib_Address", SearchText, false);
                    break;
                case "Email":
                    dt = Search("Librarian", "Lib_Email", SearchText, false);
                    break;
            }
            return dt;
        }

        public DataTable Searchdata(string query)
        {
            Lib.Database_Connection Dc = new Database_Connection();
            return Dc.GetTable(query);
        } 
        public bool BindData(string query)
        {
            DataTable dt = new DataTable();
            dt = GetTable(query);
            if (dt.Rows.Count > 0)
            {
                _mainid = dt.Rows[0]["UL_Userid"].ToString();
                _usertype = dt.Rows[0]["UL_Usertype"].ToString();
                _userpassword = dt.Rows[0]["UL_Password"].ToString();
                _mainid = dt.Rows[0]["UL_Name"].ToString();
                _contactno = dt.Rows[0]["UL_ContactNo"].ToString();
                _useremail = dt.Rows[0]["UL_Email"].ToString();
                return true;
            }
            else
                return false;
        }
    }
}
