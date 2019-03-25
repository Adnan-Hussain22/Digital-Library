using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital Library.Lib
{
    class QR_Generator
    {
        Reuseables.QR_Container con;
        Bitmap bm;
        string text;
        bool IsSaveOption;
        public Bitmap EncodeIntoQRCode(string text, bool IsSaveOption)
        {
            this.text = text;
            MessagingToolkit.QRCode.Codec.QRCodeEncoder encoder = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
            encoder.QRCodeScale = 4;
            bm = encoder.Encode(text);
            this.IsSaveOption = IsSaveOption;
            return bm;
        }

        public void PrintQrCode()
        {
            PrintBitmap();
        }

        private void PrintBitmap()
        {
            con = new Reuseables.QR_Container(bm, text);
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }

        public void SaveQrCode()
        {
            SaveBitmap();
        }

        private void SaveBitmap()
        {
            con = new Reuseables.QR_Container(this.bm, this.text);
            int Width = con.Size.Width;
            int Height = con.Size.Height;
            Bitmap bmp = new Bitmap(Width, Height);
            con.DrawToBitmap(bmp, new Rectangle(0, 0, Width, Height));
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Bitmap (.bmp)|*.bmp|JPG (.JPG)|*.JPG| PNG (.png)|*.png";
            if (sf.ShowDialog() == DialogResult.OK && sf.FileName != "")
            {
                var path = sf.FileName;
                bmp.Save(path);
            }
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            int Width = con.Size.Width;
            int Height = con.Size.Height;
            Bitmap bm = new Bitmap(Width, Height);
            con.DrawToBitmap(bm, new Rectangle(0, 0, Width, Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
        }
    }
}
