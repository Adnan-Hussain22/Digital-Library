using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital Library.Lib
{
    public class ActionDataEventArgs
    {
        public Image Picture
        {
            get;
            set;

        }

        public string LibType
        {
            get;
            set;
        }


        public string LibID
        {
            get;
            set;
        }


        public string LibName
        {
            get;
            set;
        }


    }
}
