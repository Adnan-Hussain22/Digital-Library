using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital Library.Lib
{
    class Editor : Database_Connection
    {
        #region [ OBJECTS AND VARIABLES ]
        string _fisrtname = "", _lastname = "";
        SqlCommand cmd;
        #endregion
        public string FirstName
        {
            get { return _fisrtname; }
            set { _fisrtname = value; }
        }

        public string LastName
        {
            get { return _lastname; }
            set { _lastname = value; }
        }
        public int[] EditorId
        {
            get;
            set;
        }

        public bool AddEditor()
        {
            var sql = "INSERT INTO Editor(ED_FirstName,ED_LastName) " +
            "VALUES(@ED_FirstName, @ED_LastName)";
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@ED_FirstName", _fisrtname);
            cmd.Parameters.AddWithValue("@ED_LastName", _lastname);
            var rows = Convert.ToInt32(cmd.ExecuteNonQuery().ToString());
            if (rows > 0)
                return true;
            else
                return false;
        }

        public DataTable GetEditors()
        {
            var sql = "SELECT ED_Id AS Id,CONCAT(ED_FirstName,' ',ED_LastName) AS Name FROM Editor";
            return GetTable(sql);
        }
    }
}
