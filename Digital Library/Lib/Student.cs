using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Digital Library.Lib
{ 
   public class Student:Lib.MemberInfo
    {
        string _cnic="";
        SqlCommand cmd;
        DataTable dt;
        public string CNIC
        {
            get
            {
                return _cnic;
            }
            set
            {
                if (value != "")
                    _cnic = value;
            }
        }
        public bool AddMember()
        {
            var sql = "insert into Member(Memb_MainId,Memb_FirstName,Memb_LastName,Memb_ContactNo,Memb_Email,Memb_JoinDate,Memb_ExpireDate,Memb_Cnic,Memb_Lib_fk_id,Memb_Pic) " +
            "values(@Memb_MainId, @Memb_FirstName, @Memb_LastName, @Memb_ContactNo, @Memb_Email, TRY_CONVERT(DATETIME, @Memb_JoinDate), TRY_CONVERT(DATETIME, @Memb_ExpireDate) "+
            ", @Memb_Cnic, @Memb_Lib_fk_id ,@Memb_Pic)";
            cmd = new SqlCommand(sql,GlobalConnection());
            cmd.Parameters.AddWithValue("@Memb_MainId", MemberId);
            cmd.Parameters.AddWithValue("@Memb_FirstName", FirstName);
            cmd.Parameters.AddWithValue("@Memb_LastName", LastName);
            cmd.Parameters.AddWithValue("@Memb_ContactNo", MemberContact);
            cmd.Parameters.AddWithValue("@Memb_Email", MemberEmail);
            cmd.Parameters.AddWithValue("@Memb_JoinDate", DateOfJoin);
            cmd.Parameters.AddWithValue("@Memb_ExpireDate", DateOfExpire);
            cmd.Parameters.AddWithValue("@Memb_Cnic", _cnic);
            cmd.Parameters.AddWithValue("@Memb_Lib_fk_id", "LIB1109181");//Global.LibrarianId
            cmd.Parameters.AddWithValue("@Memb_Pic", (ImageBytes == null) ? (object)DBNull.Value : ImageBytes).SqlDbType = SqlDbType.Image;
            var rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            cmd.Dispose();
            if (rows > 0)
                return true;
            else
                return false;
        }
        public bool UpdateStudent()
        {
            var sql = 
            //"DECLARE @FirstName VARCHAR(30),@LastName VARCHAR(30), "+
            //"@ContactNo VARCHAR(30),@Email VARCHAR(30), "+
            //"@JoinDate DATETIME,@ExpireDate DATETIME, "+
            //"@Cnic VARCHAR(40),@LIBRARIANID VARCHAR(255) "+
            //"SET @FirstName= @MFirstName "+
            //"SET @LastName= @MLastName "+
            //"SET @ContactNo= @MContactNo "+
            //"SET @Email= @MEmail "+
            //"SET @JoinDate= @MJoinDate "+
            //"SET @ExpireDate= @MExpireDate "+
            //"SET @Cnic= @MCnic "+
            //"SET @LIBRARIANID = @MLIBRARIANID "+
            "UPDATE Member SET Memb_FirstName = CASE WHEN @FirstName <> '' THEN @FirstName ELSE Memb_FirstName END "+
            ", Memb_LastName   = CASE WHEN @LastName <> '' THEN @LastName ELSE Memb_LastName END "+
            ",  Memb_ContactNo = CASE WHEN @ContactNo <> '' THEN @ContactNo ELSE Memb_ContactNo END "+
            ",  Memb_Email = CASE WHEN @Email <> '' THEN @Email ELSE Memb_Email END "+
            ",  Memb_JoinDate = CASE WHEN @JoinDate <> '' THEN @JoinDate ELSE Memb_JoinDate END "+
            ",  Memb_ExpireDate = CASE WHEN @ExpireDate <> '' THEN @ExpireDate ELSE Memb_ExpireDate END "+
            ",  Memb_Cnic = CASE WHEN @Cnic <> '' THEN @Cnic ELSE Memb_Cnic END "+
            ",  Memb_Lib_fk_id = CASE WHEN @LIBRARIANID <> '' THEN @LIBRARIANID ELSE Memb_Lib_fk_id END "+
            ",  Memb_Pic = @Image " +
            "WHERE Memb_MainId = @Memb_MainId";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@ContactNo", MemberContact);
            cmd.Parameters.AddWithValue("@Email", MemberEmail);
            cmd.Parameters.AddWithValue("@JoinDate", DateOfJoin);
            cmd.Parameters.AddWithValue("@ExpireDate", DateOfExpire);
            cmd.Parameters.AddWithValue("@Cnic", CNIC);
            cmd.Parameters.AddWithValue("@LIBRARIANID", "LIB86181");
            cmd.Parameters.AddWithValue("@Memb_MainId", MemberId);
            cmd.Parameters.AddWithValue("@Image", (ImageBytes == null) ? (object)DBNull.Value : ImageBytes).SqlDbType = SqlDbType.Image;
            var rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            cmd.Dispose();
            if (rows > 0)
                return true;
            else
                return false;
        }

        public bool RenewMembership()
        {
            var sql = "UPDATE MEMBER SET Memb_ExpireDate = TRY_CONVERT(DATETIME,@Memb_ExpireDate) " +
            "WHERE Memb_MainId = @Memb_MainId";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@Memb_ExpireDate", DateOfExpire);
            cmd.Parameters.AddWithValue("@Memb_MainId", MemberId);
            var rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            cmd.Dispose();
            if (rows > 0)
                return true;
            else
                return false;
        }
        private int CurrentIdentity()
        {
            var sql = "SELECT IDENT_CURRENT('MemberStudent')-1";
            cmd = new SqlCommand(sql, GlobalConnection());
            var rows=int.Parse(cmd.ExecuteScalar().ToString());
            return rows;
        }
        private int ReseedStudent()
        {
            var sql2 = "DBCC CHECKIDENT ('MemberStudent', RESEED,@RESEED)";
            cmd = new SqlCommand(sql2, GlobalConnection());
            cmd.Parameters.AddWithValue("@RESEED", CurrentIdentity());
            var row=int.Parse(cmd.ExecuteNonQuery().ToString());
            return row;
        }
        public bool DeleteStudent()
        {
            var sql = "Delete from Member where Memb_MainId=@Memb_MainId";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@Memb_MainId", MemberId);
            var rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            cmd.Dispose();
            if (rows > 0)
            {
               // ReseedStudent();
                return true;
            }
            else
                return false;
        }
        public DataTable GetMembers(int OffSet, int Total, string Status)
        {
            int offset = OffSet;
            DataTable dt = new DataTable();
            var sql = "";
            if (Status == "Available")
                sql = string.Format("SELECT * FROM Member {0} ORDER BY Mem_id OFFSET @OffSet ROW FETCH NEXT @Total ROW ONLY", "WHERE Memb_Status = 1");
            else if (Status == "Expired")
                sql = string.Format("SELECT * FROM Member {0} ORDER BY Mem_id OFFSET @OffSet ROW FETCH NEXT @Total ROW ONLY", "WHERE Memb_Status = 0");
            else
                sql = "SELECT * FROM Member ORDER BY Mem_id OFFSET @OffSet ROW FETCH NEXT @Total ROW ONLY";
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
        //public DataTable GetAvailableMembers(int OffSet, int Total)
        //{
        //    int offset = OffSet;
        //    DataTable dt = new DataTable();
        //    var sql = "SELECT * FROM Member WHERE Memb_Status = 1 ORDER BY Mem_id OFFSET @OffSet ROW FETCH NEXT @Total ROW ONLY";
        //    try
        //    {
        //        var cmd = new SqlCommand(sql, GlobalConnection());
        //        cmd.Parameters.AddWithValue("@OffSet", offset);
        //        cmd.Parameters.AddWithValue("@Total", Total);
        //        SqlDataAdapter adpt = new SqlDataAdapter(cmd);
        //        adpt.Fill(dt);
        //        adpt.Dispose();
        //        offset += offset;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, Global.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    return dt;
        //}



        public DataTable FilterSearchData(string ListType,string SearchText)
        {
            dt = new DataTable();
            switch(ListType)
            {//RTRIM(LTRIM(CONCAT(Memb_FirstName, ' ',Memb_LastName)))
                case "QR Code":
                    dt=Search("Member", "Memb_MainId", SearchText,false);
                    break;
                case "Name":
                    dt = Search("Member", "RTRIM(LTRIM(CONCAT(Memb_FirstName, ' ',Memb_LastName)))", SearchText, false);
                    break;
                case "Contact No":
                    dt = Search("Member", "Memb_ContactNo", SearchText, false);
                    break;
                case "Email":
                    dt = Search("Member", "Memb_Email", SearchText, false);
                    break;
                case "CNIC":
                    dt = Search("Member", "Memb_Cnic", SearchText, false);
                    break;
                case "Date Of Join":
                    dt = Search("Member", "Memb_JoinDate", SearchText, true);
                    break;
                case "Date Of Expire":
                    dt = Search("Member", "Memb_ExpireDate", SearchText, true);
                    break;
            }
            return dt;
        }
        public string GetMainId()
        {
            var sql ="DECLARE @TODAY DATETIME,@YEAR INT ,@MONTH VARCHAR(2),@DAY VARCHAR(2),@IDENT INT; "+
            "SELECT @TODAY = GETDATE(); "+
            "SELECT @IDENT = IDENT_CURRENT('Member')+1; "+
            "SET @MONTH =  CASE WHEN MONTH(@TODAY) < 10 THEN CONCAT('0',MONTH(@TODAY)) "+
            "ELSE CAST(MONTH(@TODAY) AS VARCHAR(2)) END; "+
            "SET @DAY = CASE WHEN DAY(@TODAY) < 10 THEN CONCAT('0',DAY(@TODAY)) "+
            "ELSE CAST(DAY(@TODAY) AS VARCHAR(2)) END; "+
            "SET @YEAR = YEAR(@TODAY); "+
            "SELECT 'MEMB' + RIGHT(CAST(@DAY AS VARCHAR(2))+CAST(@MONTH AS VARCHAR(2))+ "+
            "CAST((CAST((@YEAR)%100 AS VARCHAR(2))) AS VARCHAR(2))+ "+
            "CAST(@IDENT AS VARCHAR(255)),15);"; 
            cmd = new SqlCommand(sql, GlobalConnection());
            return cmd.ExecuteScalar().ToString();
            
        }
        public string GetCurrentId()
        {
            var sql = "SELECT'STDID' + RIGHT('00000' + CAST(IDENT_CURRENT('MemberStudent') AS VARCHAR(15)),15)";
            cmd = new SqlCommand(sql, GlobalConnection());
            return cmd.ExecuteScalar().ToString();

        }
        public string GetMainId(string query)
        {
            cmd = new SqlCommand(query, GlobalConnection());
            return cmd.ExecuteScalar().ToString();

        }
        public int CountMember(int status)
        {
            var sql = "";
            if (status > 1)
            {
                sql = "SELECT COUNT(1) FROM Member";
                cmd = new SqlCommand(sql, GlobalConnection());
            }
            else
            {
                sql = "SELECT COUNT(1) FROM Member WHERE  Memb_Status=@Status";
                cmd = new SqlCommand(sql, GlobalConnection());
                cmd.Parameters.AddWithValue("@Status", status);
            }
            var rows = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            cmd.Dispose();
            return rows;
        }
        public int GetDateDiff()
        {
            var sql = "SELECT DATEDIFF(DAY,(SELECT CAST(GETDATE() AS DATE)),@MemStd_ExpireDate)"+
            "FROM MemberStudent where MemStd_MainId='STDID000002'";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@MemStd_ExpireDate", DateOfExpire);
            //cmd.Parameters.AddWithValue("@MemStd_MainId", MemberId);
            return int.Parse(cmd.ExecuteScalar().ToString());
            
        } 
        public bool UpdateStatus()
        {
            var sql = "UPDATE Member SET Memb_Status=0 where Memb_MainId=@Memb_MemberId";
            SqlCommand cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@Memb_MemberId", FilterExpireScalar());
            var rows=int.Parse(cmd.ExecuteNonQuery().ToString());
            if (rows > 0)
                return true;
            else
                return false;
        }
        public bool FilterExpire()
        {
            var sql = "SELECT COUNT(Memb_MainId) FROM Member WHERE Memb_ExpireDate < (SELECT CAST(@CurrenDate AS DATE)) AND Memb_Status=1";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@CurrenDate", Global.GetNetworkTime());
            var rows = Convert.ToInt64(cmd.ExecuteScalar().ToString());
            cmd.Dispose();
            if (rows > 0)
            {
                return true;
            }
            else
                return false;
        }
        private string FilterExpireScalar()
        {
            var sql = "SELECT Memb_MainId FROM Member WHERE Memb_ExpireDate < (SELECT CAST(GETDATE() AS DATE)) AND Memb_Status=1";
            cmd = new SqlCommand(sql, GlobalConnection());
            string mainid= cmd.ExecuteScalar().ToString();
            return mainid;
        } 
        public override bool Filter()
        {
            if (FirstName != "" && MemberContact != "" && MemberEmail != "" && _cnic != "" && DateOfJoin != "" && DateOfExpire != "") 
                return true;
            else
                return false;
        }
    }
}
