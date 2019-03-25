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
    class Fine_Payment:Lib.IssueBookMember
    {
        SqlCommand cmd;
        DataTable dt;
        public DataTable FetchFines(int OffSet, int Total, int Status, string DateRange)
        {
            var offset = OffSet;
            dt = new DataTable();
            var sql = "SELECT M.Memb_MainId AS 'Member Id', "+
            "CONCAT(M.Memb_FirstName, ' ', M.Memb_LastName) AS 'Member Name', "+
            "M.Memb_Cnic AS 'Member CNIC', F.Fn_FineDate AS 'Fine Date', "+
            "DATEDIFF(DAY, F.Fn_FineDate, GETDATE()) AS 'Fine Days', "+
            "F.Fn_FineAmount AS 'Fine Amount',F.Fn_PaidAmount AS 'Paid Amount', "+
            "F.Fn_FineAmount - Fn_PaidAmount AS 'Due Amount' "+
            ",F.Fn_Status AS 'Status',Fn_Id AS 'Main Id' FROM Fines F,Member M " +
            "WHERE M.Memb_MainId = F.Fn_FK_MembId AND Fn_Status = @Fn_Status"+ DateRange +" "+
            "ORDER BY Fn_FineDate OFFSET 0 ROW FETCH NEXT 10 ROW ONLY";
            try
            {
                var cmd = new SqlCommand(sql, GlobalConnection());
                cmd.Parameters.AddWithValue("@OffSet", offset);
                cmd.Parameters.AddWithValue("@Total", Total);
                cmd.Parameters.AddWithValue("@Fn_Status", Status);
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

        public string CountFines(int status,string DateRange)
        {
            var sql = "SELECT COUNT(1) FROM FINES WHERE (Fn_FineAmount - Fn_PaidAmount) > 0 AND Fn_Status = @Fn_Status " + DateRange;
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@Fn_Status", status);
            var rows = cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            return rows;
        }
    }
}
