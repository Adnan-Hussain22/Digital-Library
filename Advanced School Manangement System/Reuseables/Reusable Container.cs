using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advanced_School_Manangement_System.Reuseables
{
    public partial class Reusable_Container : Form
    {
        Control child;
        public Reusable_Container(Control child)
        {
            InitializeComponent();
            this.child = child;
        }

        private void Reusable_Container_Load(object sender, EventArgs e)
        {
            Size = child.Size;
            table_main.Controls.Add(child);
            child.BringToFront();
        }
    }
}
