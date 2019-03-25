using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_School_Manangement_System.Lib
{
   public class MemberInfo:Lib.Database_Connection
    {
        string _firstname="", _membertype="", _membercontact="", _memberemail="", _lastname = "",
        _dateofjoin="", _expiredate="",_memberid="";
        public string MemberId
        {
            get
            {
                return _memberid;
            }
            set
            {
                    _memberid = value;
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
        public string MemberContact
        {
            get
            {
                return _membercontact;
            }
            set
            {
                    _membercontact = value;
            }
        }
        public string MemberEmail
        {
            get
            {
                return _memberemail;
            }
            set
            {
                    _memberemail = value;
            }
        }
        public string DateOfJoin
        {
            get
            {
                return _dateofjoin;
            }
            set
            {
                _dateofjoin = value;
            }
        }
        public string DateOfExpire
        {
            get
            {
                return _expiredate;
            }
            set
            {
                _expiredate = value;
            }
        }
        public byte[] ImageBytes
        {
            get;
            set;
        }
        public virtual bool Filter()
        {
            if (_memberid != "" && _firstname != "" && _membercontact != "" && _memberemail != "" && _dateofjoin != "" && _expiredate != "" && _lastname != "")  
                return true;
            else
                return false;
        }
    }
}
