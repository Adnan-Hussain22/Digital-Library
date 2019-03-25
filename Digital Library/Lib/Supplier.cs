using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Advanced_School_Manangement_System.Lib
{
    class Supplier:Database_Connection
    {
        SqlCommand cmd;
        string _id, _firstName,_lastName,_address;
        private string _contact;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string Contact
        {
            get { return _contact; }
            set { _contact = value; }
        }

        public byte[] ImageBytes
        {
            get;
            set;
        }
         
        public bool AddSupplier()
        {
            string sql = "INSERT INTO Supplier VALUES(@MAINID,@FIRSTNAME,@LASTNAME,@ADDRESS,@PHONENO,@IMAGE)";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@MAINID", _id);
            cmd.Parameters.AddWithValue("@FIRSTNAME", _firstName);
            cmd.Parameters.AddWithValue("@LASTNAME", _lastName);
            cmd.Parameters.AddWithValue("@ADDRESS", _address);
            cmd.Parameters.AddWithValue("@PHONENO", _contact);
            cmd.Parameters.AddWithValue("@IMAGE", (ImageBytes == null) ? (object)DBNull.Value : ImageBytes).SqlDbType = SqlDbType.Image;
            int rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            cmd.Dispose();
            if (rows > 0)
                return true;
            else
                return false;
        }

        public bool Update()
        {
            string sql = 
            "UPDATE Supplier SET Supp_FirstName = CASE WHEN @FIRSTNAME <> '' THEN @FIRSTNAME ELSE Supp_FirstName END" +
            ", Supp_LastName = CASE WHEN @LASTNAME <> '' THEN @LASTNAME ELSE Supp_LastName END"+
            ",  Supp_Address = CASE WHEN @ADDRESS <> '' THEN @ADDRESS ELSE Supp_Address END "+
            ",  Supp_PhoneNo = CASE WHEN @PHONENO <> '' THEN @ADDRESS ELSE Supp_Address END " +
            ",  Supp_Image = @Image " +
            "WHERE Supp_MainId = @ID";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@FIRSTNAME", _firstName);
            cmd.Parameters.AddWithValue("@LASTNAME", _lastName);
            cmd.Parameters.AddWithValue("@ADDRESS", _address);
            cmd.Parameters.AddWithValue("@PHONENO", _contact);
            cmd.Parameters.AddWithValue("@ID", _id);
            cmd.Parameters.AddWithValue("@Image", (ImageBytes == null) ? (object)DBNull.Value : ImageBytes).SqlDbType = SqlDbType.Image;
            int rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            cmd.Dispose();
            if (rows > 0)
                return true;
            else
                return false;
        }

        public bool Delete()
        {
            string sql = "DELETE FROM Supplier WHERE Supp_Id =@SUPID";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@SUPID", _id);
            int rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            cmd.Dispose();
            if (rows > 0)
                return true;
            else
                return false;
        }

        public bool Validate()
        {
            if (_firstName != "" && _lastName != "" && _address != "" && _contact != "")
                return true;
            else
                return false;  
        }

        public string getAutoincrementId()
        {
            var sql = "DECLARE @TODAY DATETIME,@YEAR INT,@MONTH VARCHAR(2),@DAY VARCHAR(2),@IDENT INT; "+
            "SELECT @TODAY = GETDATE(); "+
            "SELECT @IDENT = IDENT_CURRENT('Supplier')+1 "+
            "SET @MONTH =  CASE WHEN MONTH(@TODAY) < 10 THEN CONCAT('0',MONTH(@TODAY)) "+
            "ELSE CAST(MONTH(@TODAY) AS VARCHAR(2)) END; "+
            "SET @DAY = CASE WHEN DAY(@TODAY) < 10 THEN CONCAT('0',DAY(@TODAY)) "+
            "ELSE CAST(DAY(@TODAY) AS VARCHAR(2)) END; "+
            "SET @YEAR = YEAR(@TODAY); "+
            "SELECT 'SP' + RIGHT(CAST(@DAY AS VARCHAR(2))+CAST(@MONTH AS VARCHAR(2))+ "+
            "CAST((CAST((@YEAR)%100 AS VARCHAR(2))) AS VARCHAR(2))+ "+
            "CAST(@IDENT AS VARCHAR(255)),15);";
            return getId(sql);
        }

        public DataTable getSuppliers()
        {
            var sql = "SELECT * FROM Supplier";
            return GetTable(sql);
        }

        public DataTable getPaginatedSuppliers(int OffSet, int Total)
        {
            int offset = OffSet;
            DataTable dt = new DataTable();
            var sql = "SELECT * FROM Supplier ORDER BY Supp_Id OFFSET @OffSet ROW FETCH NEXT @Total ROW ONLY";
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

        public int CountSuppliers()
        {
            var sql = "SELECT COUNT(1) FROM Supplier";
            cmd = new SqlCommand(sql, GlobalConnection());
            var rows = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            cmd.Dispose();
            return rows;
        }

        public DataTable FilterSupplierList(string ListType, string SearchText)
        {
            DataTable dt = new DataTable();
            switch (ListType)
            {
                case "ID":
                    dt = Search("Supplier", "Supp_MainId", SearchText, false);
                    break;
                case "Name":
                    dt = Search("Supplier", "RTRIM(LTRIM(CONCAT(Supp_FirstName, ' ',Supp_LastName)))", SearchText, false);
                    break;
                case "Address":
                    dt = Search("Supplier", "Supp_Address", SearchText, false);
                    break;
                case "Contact No":
                    dt = Search("Supplier", "Supp_PhoneNo", SearchText, false);
                    break;
            }
            return dt;
        }
    }
}
