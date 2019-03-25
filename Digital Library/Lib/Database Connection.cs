using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Advanced_School_Manangement_System.Lib
{
    public class Database_Connection
    {
        SqlCommand cmd;
        public static SqlConnection GlobalConnection()
        {
            string Constrng = ConfigurationManager.ConnectionStrings["constrng"].ConnectionString;
            SqlConnection con = new SqlConnection(Constrng);
            if(con.State==System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            return con;
        }
        public bool ExecuteFullQuery(string query)
        {
            cmd = new SqlCommand(query,GlobalConnection());
            int rows=int.Parse(cmd.ExecuteNonQuery().ToString());
            cmd.Dispose();
            if (rows > 0)
                return true;
            else
                return false;
        }
        public bool ExecuteFullQuery(string query,string imageparameter,byte[] imagelength)
        {
            cmd = new SqlCommand(query, GlobalConnection());
            cmd.Parameters.Add(new SqlParameter(imageparameter, imagelength));
            int rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            cmd.Dispose();
            if (rows > 0)
                return true;
            else
                return false;
        }
        public bool ExecuteScalerQuery(string query)
        {
            cmd = new SqlCommand(query,GlobalConnection());
            var rows = int.Parse(cmd.ExecuteScalar().ToString());
            cmd.Dispose();
            if (rows > 0)
                return true;
            else
                return false;
        }
        public DataTable GetTable(string query) 
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter adpt = new SqlDataAdapter(query, GlobalConnection());
                adpt.Fill(dt);
                adpt.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,Global.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }
        public DataTable GetTable(string query,string parametername, object parameterobject)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(query,GlobalConnection());
                cmd.Parameters.AddWithValue(parametername, parameterobject);
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(dt);
                adpt.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Global.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }
        public DataTable Search(string TableName, string Column, string SearchText,bool IsDate)
        {
            var sql = "";
            if (IsDate)
            {
                sql = "SELECT * FROM " + TableName + " WHERE CONVERT(VARCHAR(225),"
                + Column + ",103) LIKE '%" + SearchText + "%'";
            }
            else//sql = "SELECT * FROM " + TableName + " WHERE " + Column + " LIKE '%" + SearchText + "%'";
                sql = string.Format("SELECT * FROM {0} WHERE {1} LIKE '%" + SearchText + "%'", TableName, Column);
            return GetTable(sql);
        }

        public DataTable Search(string TableName,string Columns,string SearchBy,string WhereClause, string SearchText, bool IsDate)
        {
            var sql = "";
            if (IsDate)
            {
                //SELECT * FROM Member WHERE CONVERT(VARCHAR(225),Memb_JoinDate,103) LIKE '%20/06/2018%'
                //sql = "SELECT * FROM " + TableName + " WHERE CONVERT(VARCHAR(225),"
                //+ Columns + ",103) LIKE '%" + SearchText + "%'";
            }
            else
                sql = "SELECT " + Columns + " FROM " + TableName + WhereClause + SearchBy + " LIKE '%" + SearchText + "%'";
            return GetTable(sql);
        }

        public DataTable Search(string TableName, string Column, string SearchText,int OffSet,int NextTotal,string OrderBy)
        {//SELECT * FROM Book WHERE Bk_MainId LIKE '%BKID000001%' ORDER BY Bk_BooKid OFFSET 0 ROW FETCH NEXT 3 ROW ONLY 
            var sql = "SELECT * FROM " + TableName + " WHERE " + Column + " LIKE '%" + SearchText + "%'" +
            "ORDER BY " +OrderBy+  " OFFSET "+OffSet+" ROW FETCH NEXT "+NextTotal+" ROW ONLY";
            return GetTable(sql);
        }

        public string getId(string sql)
        {
            cmd = new SqlCommand(sql,GlobalConnection());
            var Id = cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            return Id;
        }
        /*public string GetCurrentDate()
        {
            var sql = "SELECT CAST(GETDATE() AS DATE)";
            cmd = new SqlCommand(sql, GlobalConnection());
            return cmd.ExecuteScalar().ToString();
        }*/
    }

}
