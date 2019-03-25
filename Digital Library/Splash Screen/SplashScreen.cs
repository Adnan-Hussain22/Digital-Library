using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Digital Library.Customization;

namespace Digital Library.Splash_Screen
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private int _time;
        private void Loading_Tick(object sender, EventArgs e)
        {

            if (_time >= 100)
            {
                Loading.Enabled = false;
                this.Close();
            }
            else
            {
                _time += 10;
            }
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            FormAnimation.AnimateWindow(this.Handle, 500, FormAnimation.BLEND);  
            Loading.Enabled = true;
        }
    }
}
