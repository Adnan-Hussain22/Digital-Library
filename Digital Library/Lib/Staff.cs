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
    class Staff:Lib.MemberInfo
    {
        string _staffid="";
        SqlCommand cmd;
        DataTable dt;
        public string StaffId
        {
            get
            {
                return _staffid;
            }
            set
            {
                if (value != "")
                    _staffid = value;
            }
        }
        public bool AddStaff()
        {
            int rows;
            try
            {
                var sql = "insert into MemberStaff(MemStff_Name,MemStff_ContactNo,MemStff_Email,MemStff_JoinDate,MemStff_ExpireDate,MemStff_Staffid,MemStff_Lib_fk_Libid,MemStff_Status)" +
                "values(@MemStff_Name, @MemStff_ContactNo, @MemStff_Email, TRY_CONVERT(DATETIME, @MemStff_JoinDate), TRY_CONVERT(DATETIME, @MemStff_ExpireDate), @MemStff_Staffid, 'L-1234',1)";
                cmd = new SqlCommand(sql, GlobalConnection());
                cmd.Parameters.AddWithValue("@MemStff_Name", FirstName);
                cmd.Parameters.AddWithValue("@MemStff_ContactNo", MemberContact);
                cmd.Parameters.AddWithValue("@MemStff_Email", MemberEmail);
                cmd.Parameters.AddWithValue("@MemStff_JoinDate", DateOfJoin);
                cmd.Parameters.AddWithValue("@MemStff_ExpireDate", DateOfExpire);
                cmd.Parameters.AddWithValue("@MemStff_Staffid", _staffid);
                rows = int.Parse(cmd.ExecuteNonQuery().ToString());
                if (rows > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool UpdateStaff()
        {
            var sql= "UPDATE MemberStaff SET MemStff_Name=@MemStff_Name,MemStff_ContactNo=@MemStff_ContactNo,MemStff_Email=@MemStff_Email,MemStff_JoinDate=TRY_CONVERT(DATETIME,@MemStff_JoinDate),MemStff_ExpireDate=TRY_CONVERT(DATETIME,@MemStff_ExpireDate),MemStff_Staffid=@MemStff_Staffid WHERE MemStff_MainId=@MemStff_MainId";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@MemStff_Name", FirstName);
            cmd.Parameters.AddWithValue("@MemStff_ContactNo", MemberContact);
            cmd.Parameters.AddWithValue("@MemStff_Email", MemberEmail);
            cmd.Parameters.AddWithValue("@MemStff_JoinDate", DateOfJoin);
            cmd.Parameters.AddWithValue("@MemStff_ExpireDate", DateOfExpire);
            cmd.Parameters.AddWithValue("@MemStff_Staffid", _staffid);
            cmd.Parameters.AddWithValue("@MemStff_MainId", MemberId);
            var rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            cmd.Dispose();
            if (rows > 0)
                return true;
            else
                return false;
        }
        public bool DeleteStaff()
        {
            var sql = "DELETE FROM MemberStaff WHERE MemStff_MainId=@MainId";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@MainId", MemberId);
            var rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            cmd.Dispose();
            if (rows > 0)
            {
                //ReseedStaff();
                return true;
            }
            else
                return false;
        }
        public DataTable GetStaff()
        {
            var sql = "SELECT * FROM MemberStaff";
            return GetTable(sql);
        }
        public DataTable FilterSearchData(string ListType, string SearchText)
        {
            dt = new DataTable();
            //switch (ListType)
            //{
            //    case "Member Id":
            //        dt = Search("MemberStaff", "MemStff_MainId", SearchText);
            //        break;
            //    case "Name":
            //        dt = Search("MemberStaff", "MemStff_Name", SearchText);
            //        break;
            //    case "Email":
            //        dt = Search("MemberStaff", "MemStff_Email", SearchText);
            //        break;
            //    case "Contact No":
            //        dt = Search("MemberStaff", "MemStff_ContactNo", SearchText);
            //        break;
            //    case "Staff Id":
            //        dt = Search("MemberStaff", "MemStff_Staffid", SearchText);
            //        break;
            //    case "Date Of Join":
            //        dt = Search("MemberStaff", "MemStff_JoinDate", SearchText);
            //        break;
            //    case "Date Of Expire":
            //        dt = Search("MemberStaff", "MemStff_ExpireDate", SearchText);
            //        break;
            //    case "Status":
            //        dt = Search("MemberStaff", "MemStff_Status", SearchText);
            //        break;
            //}
            return dt;
        }
        public string GetMainId()
        {
            var sql= "SELECT 'STFID' + RIGHT('00000' + CAST(IDENT_CURRENT('MemberStaff')+1 AS VARCHAR(15)),15)";
            cmd = new SqlCommand(sql, GlobalConnection());
            return cmd.ExecuteScalar().ToString();
            
        }
        public string GetCurrentId()
        {
            var sql = "SELECT 'STFID' + RIGHT('00000' + CAST(IDENT_CURRENT('MemberStaff') AS VARCHAR(15)),15)";
            cmd = new SqlCommand(sql, GlobalConnection());
            return cmd.ExecuteScalar().ToString();

        }
        private int CurrentIdentity()
        {
            var sql = "SELECT IDENT_CURRENT('MemberStaff')-1";
            cmd = new SqlCommand(sql, GlobalConnection());
            var rows = int.Parse(cmd.ExecuteScalar().ToString());
            return rows;
        }
        private int ReseedStaff()
        {
            var sql2 = "DBCC CHECKIDENT ('MemberStaff', RESEED,@RESEED)";
            cmd = new SqlCommand(sql2, GlobalConnection());
            cmd.Parameters.AddWithValue("@RESEED", CurrentIdentity());
            var row = int.Parse(cmd.ExecuteNonQuery().ToString());
            return row;
        }
        public bool CountStaff()
        {
            DataTable dt = new DataTable();
            var sql = "SELECT COUNT(1) FROM MemberStaff";
            return ExecuteScalerQuery(sql);
        }
        public bool UpdateStatus()
        {
            var sql = "UPDATE MemberStaff SET MemStff_Status=0 where MemStff_MainId=@MemStff_MemberId";
            SqlCommand cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@MemStff_MemberId", FilterExpireScalar());
            var rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            if (rows > 0)
                return true;
            else
                return false;
        }
        public bool FilterExpire()
        {
            var sql = "SELECT COUNT(MemStff_MainId) FROM MemberStaff WHERE MemStff_ExpireDate < (SELECT CAST(GETDATE() AS DATE)) AND MemStff_Status=1";
            return ExecuteScalerQuery(sql);
        }
        private string FilterExpireScalar()
        {
            var sql = "SELECT MemStff_MainId FROM MemberStaff WHERE MemStff_ExpireDate < (SELECT CAST(GETDATE() AS DATE)) AND MemStff_Status=1";
            cmd = new SqlCommand(sql, GlobalConnection());
            string s = cmd.ExecuteScalar().ToString();
            return s;
        }
        public string GetMainId(string query)
        {
            cmd = new SqlCommand(query, GlobalConnection());
            return cmd.ExecuteScalar().ToString();

        }
        public override bool Filter()
        {
            if (FirstName != "" && MemberContact != "" && _staffid != "" && MemberEmail != "" && DateOfJoin != "" && DateOfExpire != "") 
                return true;
            else
                return false;
        }
    }
}
