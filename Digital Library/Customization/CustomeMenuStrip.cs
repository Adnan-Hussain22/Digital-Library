using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Digital Library.Customization
{
    class CustomeMenuStrip : ProfessionalColorTable
    {
        public override Color MenuItemSelected
        {
            get { return Color.FromArgb(41, 49, 63); }
        }

        public override Color MenuBorder  //added for changing the menu border
        {
            get { return Color.FromArgb(67, 78, 98); }
        }
        public override Color ToolStripDropDownBackground
        {
            get { return Color.FromArgb(67, 78, 98); }
        }
        public override Color MenuItemBorder
        {
            get { return Color.FromArgb(67, 78, 98); }
        }

        /* public override Color MenuItemSelectedGradientBegin
         {
             get { return Color.FromArgb(67, 78, 98); }
         }

         public override Color MenuItemSelectedGradientEnd
         {
             get { return Color.FromArgb(67, 78, 98); }
         }*/

        public override Color MenuItemPressedGradientBegin
        {
            get { return Color.FromArgb(109, 157, 196); }
        }

        public override Color MenuItemPressedGradientEnd
        {
            get { return Color.FromArgb(106, 155, 195); }
        }
    }
}
