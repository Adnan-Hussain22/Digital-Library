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
    class Journal_And_Magazine:Editor
    {
        string _id = "", _title = "", _language = "", _publication = "", _publisher = "", _category = "",
       _volume = "", _frequency = "";
        long _issn = 0;
        SqlCommand cmd;
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Language
        {
            get { return _language; }
            set { _language = value; }
        }

        //public string Editor
        //{
        //    get { return _editor; }
        //    set { _editor = value; }
        //}

        public int[] Editors
        {
            get;
            set;
        }

        public string Publication
        {
            get { return _publication; }
            set { _publication = value; }
        }
        public string Publisher
        {
            get { return _publisher; }
            set { _publisher = value; }
        }
        public long ISSN
        {
            get { return _issn; }
            set { _issn = value; }
        }
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }
        public string Volume
        {
            get { return _volume; }
            set { _volume = value; }
        }
        public string Frequency
        {
            get { return _frequency; }
            set { _frequency = value; }
        }

        public byte[] ImageBytes
        {
            get;
            set;
        }

        public bool AddJournalMagazine()
        {
            string sql = "INSERT INTO JournalAndMagazine(JAM_MainId,JAM_Title,JAM_Language,JAM_Publication, "+
            "JAM_ISSN,JAM_Publisher,JAM_Category,JAM_Volume,JAM_Frequency,JAM_Image,JAM_Status) "+
            "VALUES(@JAM_MainId,@JAM_Title,@JAM_Language,@JAM_Publication "+
            ",@JAM_ISSN,@JAM_Publisher,@JAM_Category,@JAM_Volume,@JAM_Frequency,@JAM_Image,1)"; 
            cmd = new SqlCommand(sql, GlobalConnection());
            cmd.Parameters.AddWithValue("@JAM_MainId", _id);
            cmd.Parameters.AddWithValue("@JAM_Title", _title);
            cmd.Parameters.AddWithValue("@JAM_Language", _language);
            cmd.Parameters.AddWithValue("@JAM_Publication", _publication);
            cmd.Parameters.AddWithValue("@JAM_ISSN", _issn);
            cmd.Parameters.AddWithValue("@JAM_Publisher", _publisher);
            cmd.Parameters.AddWithValue("@JAM_Category", _category);
            cmd.Parameters.AddWithValue("@JAM_Volume", _volume);
            cmd.Parameters.AddWithValue("@JAM_Frequency", _frequency);
            cmd.Parameters.AddWithValue("@JAM_Image", (ImageBytes == null) ? (object)DBNull.Value : ImageBytes).SqlDbType = SqlDbType.Image;
            int rows = int.Parse(cmd.ExecuteNonQuery().ToString());
            cmd.Dispose();
            if (rows > 0)
            {
                AddJAMEditors();
                return true;
            }
            else
                return false;
        }

        public string GetMainId()
        {
            string sql = "DECLARE @TODAY DATETIME,@MONTH VARCHAR(2),@DAY VARCHAR(2),@YEAR INT,@IDENT INT; "+
            "SET @TODAY = GETDATE(); "+
            "SET @MONTH =  CASE WHEN MONTH(@TODAY) < 10 THEN CONCAT('0',MONTH(@TODAY)) "+
            "ELSE CAST(MONTH(@TODAY) AS VARCHAR(2)) END; "+
            "SET @DAY = CASE WHEN DAY(@TODAY) < 10 THEN CONCAT('0',DAY(@TODAY)) "+
            "ELSE CAST(DAY(@TODAY) AS VARCHAR(2)) END; "+
            "SET @YEAR = YEAR(@TODAY); "+
            "SELECT @IDENT = IDENT_CURRENT('JournalAndMagazine')+1 "+
            "SELECT 'JAM' + RIGHT(CAST(@DAY AS varchar(2))+CAST(@MONTH AS VARCHAR(2))+ "+
            "CAST((@YEAR%100) AS VARCHAR(2)) + "+
            "CAST(@IDENT AS VARCHAR(225)),15)";
            cmd = new SqlCommand(sql, GlobalConnection());
            var id = cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            return id;
        }

        private void AddJAMEditors()
        {
            var sql = "INSERT INTO JAMEditor(JAMED_ED_FK_EDId,JAMED_JAM_FK_JAMId) "+
            "VALUES(@JAMED_ED_FK_EDId, @JAMED_JAM_FK_JAMId)";
            for (var i = 0; i < Editors.Length; i++)
            {
                cmd = new SqlCommand(sql, GlobalConnection());
                cmd.Parameters.AddWithValue("@JAMED_ED_FK_EDId", Editors[i]);
                cmd.Parameters.AddWithValue("@JAMED_JAM_FK_JAMId", Id);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
        }

        public bool Validate()
        {
            if (_title != "" && _category != "" && Editors != null && _frequency != "" && _issn != 0 && _language != "" &&
            _publication != "" && _publisher != "" && _volume != "")
                return true;
            else
                return false;
        }
    }
}
