using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Net;
using System.Net.Sockets;
using System.Data;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Drawing;

namespace Digital Library
{
    public class Global
    {
        SqlCommand cmd;
        public static string Caption = "Digital Library";
        public static string CaptionLib = "Digital Library";
        public static bool check = false;
        public static object data = false;
        private byte[] _getimageinbytes;
        
        Reuseables.QR_Container con;
        public static string LibrarianType
        {
            get;
            set;
        }
        public static string LibrarianId
        {
            get;
            set;
        }
        public static int Autonumber(int i,int j)
        {
            return (i + j);
        }
        public static bool IsAllNumbers(string checkingstring)
        {
            //var test=checkingstring.IsNumeric();
            long n;
            return long.TryParse(checkingstring, out n);
        }
        /// <summary>
        /// Resize the Image to a desired size
        /// </summary>
        /// <param name="image"></param>
        /// <param name="Height"></param>
        /// <param name="Width"></param>
        /// <returns></returns>
        public static System.Drawing.Image ResizeImage(System.Drawing.Image image, System.Drawing.Size size)
        {
            System.Drawing.Image img = new System.Drawing.Bitmap(size.Height, size.Width);
            using (System.Drawing.Graphics GFX = System.Drawing.Graphics.FromImage((System.Drawing.Bitmap)img))
            {
                GFX.DrawImage(img, new System.Drawing.Rectangle(System.Drawing.Point.Empty, size));
            }
            return image;
        }

        /// <summary>
        /// Gets the dialog filer type and returns the path of a file
        /// </summary>
        /// <param name="dialogFilter"></param>
        /// <returns></returns>
        public static string GetFilePath(string dialogFilter)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return dialog.FileName;
            }
            else
                return "";
        }
        /// <summary>
        /// Gets the path of a file and return file in bytes form
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static byte[] ConvertIntoBytes(string path)
        {
            byte[] image = null;
            FileStream Stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(Stream);
            image = br.ReadBytes((int)Stream.Length);
            return image;
        }
        public static System.Drawing.Image ConvertIntoImage(byte[] bytes)
        {
            System.Drawing.Image img = null;
            if (bytes != null)
            {
                MemoryStream mstream = new MemoryStream(bytes);
                img = System.Drawing.Image.FromStream(mstream);
            }
            return img;
        }

        public static byte[] ImageToBytes(System.Drawing.Image Image)
        {
            MemoryStream ms = new MemoryStream();
            Image.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public static DateTime GetNetworkTime()
        {
            DateTime date = DateTime.Now;
            try
            {
                //default Windows time server
                const string ntpServer = "time.windows.com";

                // NTP message size - 16 bytes of the digest (RFC 2030)
                var ntpData = new byte[48];

                //Setting the Leap Indicator, Version Number and Mode values
                ntpData[0] = 0x1B; //LI = 0 (no warning), VN = 3 (IPv4 only), Mode = 3 (Client Mode)

                var addresses = Dns.GetHostEntry(ntpServer).AddressList;

                //The UDP port number assigned to NTP is 123
                var ipEndPoint = new IPEndPoint(addresses[0], 123);
                //NTP uses UDP

                using (var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp))
                {
                    socket.Connect(ipEndPoint);

                    //Stops code hang if NTP is blocked
                    socket.ReceiveTimeout = 3000;

                    socket.Send(ntpData);
                    socket.Receive(ntpData);
                    socket.Close();
                }

                //Offset to get to the "Transmit Timestamp" field (time at which the reply 
                //departed the server for the client, in 64-bit timestamp format."
                const byte serverReplyTime = 40;

                //Get the seconds part
                ulong intPart = BitConverter.ToUInt32(ntpData, serverReplyTime);

                //Get the seconds fraction
                ulong fractPart = BitConverter.ToUInt32(ntpData, serverReplyTime + 4);

                //Convert From big-endian to little-endian
                intPart = SwapEndianness(intPart);
                fractPart = SwapEndianness(fractPart);

                var milliseconds = (intPart * 1000) + ((fractPart * 1000) / 0x100000000L);

                //**UTC** time
                date = (new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)).AddMilliseconds((long)milliseconds);
            }
            catch (Exception ex)
            {
            }

            return date;
        }
        static uint SwapEndianness(ulong x)
        {
            return (uint)(((x & 0x000000ff) << 24) +
                           ((x & 0x0000ff00) << 8) +
                           ((x & 0x00ff0000) >> 8) +
                           ((x & 0xff000000) >> 24));
        }
        
        public static void PrintToPDF(DataGridView dgv,string Title,bool IsLandscape) 
        {
            DGVPrinterHelper.DGVPrinter printer = new DGVPrinterHelper.DGVPrinter();
            printer.Title = Title;
            printer.SubTitle = DateTime.Now.ToLocalTime().ToString();
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Far;
            printer.CellAlignment = StringAlignment.Center;
            printer.CellFormatFlags = StringFormatFlags.MeasureTrailingSpaces | StringFormatFlags.LineLimit;
            printer.RowHeight = DGVPrinterHelper.DGVPrinter.RowHeightSetting.DataHeight + 1;
            printer.Footer = "Falcon Five";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = IsLandscape;
            printer.PrintDataGridView(dgv);
        }

        //public static bool ImageIsDBNULL(object imageColumn)
        //{
        //    if (imageColumn == typeof(byte[]))
        //    {

        //    }
        //}
    }
}
