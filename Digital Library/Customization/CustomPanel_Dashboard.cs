using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advanced_School_Manangement_System
{
    public partial class CustomPanelDashboard : UserControl
    {

        public CustomPanelDashboard()
        {
            InitializeComponent();
        }

        public Image LeftImage
        {
            get { return LeftPicture.Image; }
            set { LeftPicture.Image = value; }
        }

        public Color LeftBackColor
        {
            get { return pnlLeftBackColor.BackColor; }
            set { pnlLeftBackColor.BackColor = value; }
        }

        public string NumberLabel
        {
            get { return Data.Text; }
            set { Data.Text = value; }
        }

        public string NameLabel
        {
            get { return Names.Text; }
            set { Names.Text = value; }
        }

        public Color RightBackColor
        {
            get { return pnlRightBackColor.BackColor; }
            set { pnlRightBackColor.BackColor = value; }
        }

        private void Slider_Tick(object sender, EventArgs e)
        {
            if (pnlSlider.Width >= this.Width)
            {
                Slider.Enabled = false;

            }
            else
            {
                pnlSlider.Width += 10;
            }
        }

        private void LeftPicture_MouseEnter(object sender, EventArgs e)
        {
            if (pnlSlider.Width <= 0)
            {
                Slider.Enabled = true;
                pnlSlider.Width = 0;
                PositionCheck.Enabled = true;
            }
            
        }

        public int TimerSeconds
        {
            get { return Slider.Interval; }
            set { Slider.Interval = value; }
        }

        public Color SliderColor
        {
            get { return pnlSlider.BackColor; }
            set { pnlSlider.BackColor = value; }
        }

        private void pnlLeftBackColor_MouseLeave(object sender, EventArgs e)
        {
              //ReverseSlider.Enabled = true;            
        }

        public int ReverseTimerSeconds
        {
            get { return ReverseSlider.Interval; }
            set { ReverseSlider.Interval = value; }
        }

        public Font NameFont
        {
            get { return Names.Font; }
            set { Names.Font = value; }
        }

        public Font NumberFont
        {
            get { return Data.Font; }
            set { Data.Font = value; }
        }

        private void ReverseSlider_Tick(object sender, EventArgs e)
        {
            if (Slider.Enabled == true) {return;}
            if (pnlSlider.Width <= 0)
            {
                ReverseSlider.Enabled = false;
            }
            else
            {
                pnlSlider.Width -= 10;
            }
        }

        private void Data_MouseLeave(object sender, EventArgs e)
        {
            //pnlRightBackColor.MouseLeave -= pnlLeftBackColor_MouseLeave;
            //if (pnlSlider.Width > 0)
            //{
            //    pnlSlider.Width = 252;
            //}
            //else
            //{
            //    //ReverseSlider.Enabled = true;
            //}
        }

        private void PositionCheck_Tick(object sender, EventArgs e)
        {
            if (!pnlRightBackColor.Bounds.Contains(this.PointToClient(Cursor.Position)))
            {
                ReverseSlider.Enabled = true;
            }
            else
            {
                return;
            }
        }

      
    }
}
