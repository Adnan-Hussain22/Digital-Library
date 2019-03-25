using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advanced_School_Manangement_System.Reuseables
{
    public partial class QR_Container : UserControl
    {
        public QR_Container(Image image,string text)
        {
            InitializeComponent();
            this.picbox_qrcode.Image = image;
            lbl_qrcode.Text = text;
        }
    }
}
