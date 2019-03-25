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
    class Publisher:Database_Connection
    {
        string _id, _name, _address, _contact;
        SqlCommand cmd;
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
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
        public bool AddPublisher()
        {
            string sql = "INSERT INTO Publisher VALUES(@MAINID,@NAME,@CONTACT,@ADDRESS,@IMAGE)";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@MAINID", _id);
            cmd.Parameters.AddWithValue("@NAME", _name);
            cmd.Parameters.AddWithValue("@ADDRESS", _address);
            cmd.Parameters.AddWithValue("@CONTACT", _contact);
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
            "UPDATE Publisher SET Pub_PublisherName = CASE WHEN @NAME <> '' THEN @NAME ELSE Pub_PublisherName END "+
            ",  Pub_Address = CASE WHEN @ADDRESS <> '' THEN @ADDRESS ELSE Pub_Address END "+
            ",  Pub_Phoneno = CASE WHEN @PHONENO <> '' THEN @PHONENO ELSE Pub_Phoneno END "+
            ",  Pub_Image = @IMAGE " +
            "WHERE Pub_MainId = @Pub_MainId";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@NAME", _name);
            cmd.Parameters.AddWithValue("@ADDRESS", _address);
            cmd.Parameters.AddWithValue("@PHONENO", _contact);
            cmd.Parameters.AddWithValue("@Pub_MainId", _id);
            cmd.Parameters.AddWithValue("@IMAGE", (ImageBytes == null) ? (object)DBNull.Value : ImageBytes).SqlDbType = SqlDbType.Image;
            int rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            cmd.Dispose();
            if (rows > 0)
                return true;
            else
                return false;
        }

        public bool Delete()
        {
            string sql = "DELETE FROM Publisher WHERE Pub_MainId = @PUBID";
            cmd.Parameters.AddWithValue("@PUBID", _id);
            int rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            cmd.Dispose();
            if (rows > 0)
                return true;
            else
                return false;
        }

        public bool Validate()
        {
            if (_name != "" &&  _address != "" && _contact != "")
                return true;
            else
                return false;
        }

        public string getAutoIncrementId()
        {
            var sql = "DECLARE @TODAY DATETIME,@YEAR INT,@MONTH VARCHAR(2),@DAY VARCHAR(2), @IDENT INT,@COUNT INT; "+
            "SELECT @TODAY = GETDATE(); "+
            "SELECT @IDENT = IDENT_CURRENT('Publisher')+1; "+
            "SET @MONTH =  CASE WHEN MONTH(@TODAY) < 10 THEN CONCAT('0',MONTH(@TODAY)) "+
            "ELSE CAST(MONTH(@TODAY) AS VARCHAR(2)) END; "+
            "SET @DAY = CASE WHEN DAY(@TODAY) < 10 THEN CONCAT('0',DAY(@TODAY)) "+
            "ELSE CAST(DAY(@TODAY) AS VARCHAR(2)) END; "+
            "SET @YEAR = YEAR(@TODAY); "+
            "SELECT 'PUB' + RIGHT(CAST(@DAY AS VARCHAR(2))+CAST(@MONTH AS VARCHAR(2))+ "+
            "CAST((CAST((@YEAR)%100 AS VARCHAR(2))) AS VARCHAR(2))+ "+
            "CAST(@IDENT AS VARCHAR(255)),15);"; 
            return getId(sql);
        }

        public DataTable getPublishers()
        {
            var sql = "SELECT * FROM Publisher";
            return GetTable(sql);
        }

          //getPublishers
        public DataTable getPaginatedPublishers(int OffSet, int Total)
        {
            int offset = OffSet;
            DataTable dt = new DataTable();
            var sql = "SELECT * FROM Publisher ORDER BY Pub_Id OFFSET @OffSet ROW FETCH NEXT @Total ROW ONLY";
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



        public int CountPublishers()
        {
            var sql = "SELECT COUNT(1) FROM Publisher";
            cmd = new SqlCommand(sql, GlobalConnection());
            var rows = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            cmd.Dispose();
            return rows;
        }

        public DataTable FilterPublisherList(string ListType, string SearchText)
        {
            DataTable dt = new DataTable();
            switch (ListType)
            {
                case "ID":
                    dt = Search("Publisher", "Pub_MainId", SearchText, false);
                    break;
                case "Name":
                    dt = Search("Publisher", "Pub_PublisherName", SearchText, false);
                    break;
                case "Contact No":
                    dt = Search("Publisher", "Pub_Phoneno", SearchText, false);
                    break;
                case "Address":
                    dt = Search("Publisher", "Pub_Address", SearchText, false);
                    break;
            }
            return dt;
        }
    }
}
