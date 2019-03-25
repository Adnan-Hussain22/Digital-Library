using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_School_Manangement_System.Lib
{
    class Shelf:Database_Connection
    {
        SqlCommand cmd;
        #region [ OBEJECTS AND VARIABLES ]
        int _capacity;
        string _id = "";
        #endregion

        #region [ PROPERTIES ]
        public int Capacity
        {
            get { return _capacity; }
            set { _capacity = value; }
        }
        public string ShelfMainId
        {
            get { return _id; }
            set { _id = value; }
        }
        #endregion

        #region [ METHODS ]
        public bool AddShelf(int amount)
        {
            var sql = "INSERT INTO Shelf (Shlf_MainId,Shlf_Capacity,Shlf_Status) " +
            "VALUES(@Shlf_MainId,@Shlf_Capacity,@Shlf_Status)";
            var rows = 0;
            for (var i = 0; i < amount; i++)
            {
                cmd = new SqlCommand(sql, GlobalConnection());
                cmd.Parameters.AddWithValue("@Shlf_Capacity", _capacity);
                cmd.Parameters.AddWithValue("@Shlf_Status", 1);
                cmd.Parameters.AddWithValue("@Shlf_MainId", GetShelfId());
                rows += Convert.ToInt32(cmd.ExecuteNonQuery());
            }
            if (rows > 0)
            {
                return true;
            }
            else
                return false;
        }

        private string GetShelfId()
        {
            string sql = "DECLARE @TODAY DATETIME,@YEAR INT,@IDENT INT,@MONTH VARCHAR(2),@DAY VARCHAR(2); "+
            "SELECT @TODAY = GETDATE(); "+
            "SELECT @IDENT = IDENT_CURRENT('Shelf')+1 "+
            "SET @MONTH =  CASE WHEN MONTH(@TODAY) < 10 THEN CONCAT('0',MONTH(@TODAY)) "+
            "ELSE CAST(MONTH(@TODAY) AS VARCHAR(2)) END; "+
            "SET @DAY = CASE WHEN DAY(@TODAY) < 10 THEN CONCAT('0',DAY(@TODAY)) "+
            "ELSE CAST(DAY(@TODAY) AS VARCHAR(2)) END; "+
            "SET @YEAR = YEAR(@TODAY); "+
            "SELECT 'Shlf' + RIGHT( @DAY + @MONTH + "+
            "CAST((CAST((@YEAR)%100 AS VARCHAR(2))) AS VARCHAR(2))+ "+
            "CAST(@IDENT AS VARCHAR(255)),17);";
            SqlCommand cmd = new SqlCommand(sql, GlobalConnection());
            var id = cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            return id;
        }

        public DataTable GetAvailableShelf()
        {
            var sql = "SELECT Shlf_MainId AS SHELF FROM Shelf WHERE Shlf_Status = 1 " +
            "ORDER BY Shlf_Id ASC";
            return GetTable(sql);
        }

        public int GetShelfCapacity(string ShelfId)
        {
            var sql = "SELECT Shlf_Capacity FROM SHELF WHERE Shlf_MainId = @ShelfMainId";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@ShelfMainId", ShelfMainId);
            return Convert.ToInt32(cmd.ExecuteScalar().ToString());
        }

        public void UpdateShelfStatus(string ShelfId, int ShelfCapacity)
        {
            var sql = "UPDATE Shelf SET Shlf_Status = CASE WHEN (SELECT COUNT(1) FROM BOOK WHERE Bk_Shlf_FK_Shelf = @ShelfId ) = @ShelfCapacity " +
            "THEN 0 ELSE Shlf_Status END WHERE Shlf_MainId = @ShelfId";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@ShelfCapacity", ShelfCapacity);
            cmd.Parameters.AddWithValue("@ShelfId", ShelfId);
            var rows = cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        #endregion
    }
}
