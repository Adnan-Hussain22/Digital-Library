using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;
using AForge.Imaging.Filters;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Windows.Forms;

namespace Digital Library.Reuseables
{
    public partial class QR_Scanner : UserControl
    {
        public QR_Scanner()
        {
            InitializeComponent();
        }

        #region [ OBJECTS AND VARIABLES ]
        string _textdecoded;
        private FilterInfoCollection CaptureDevices;
        private VideoCaptureDevice FinalFrame;
        int laserStartPos = 85;
        int laserEndPos = 230;
        bool isIncreasing = true, isDecreasing = true;
        #endregion

        #region [ PROPERTIES ]
        public string TextDecoded
        {
            get { return _textdecoded; }
        }
        #endregion

        #region [ METHODS ]

        #endregion

        #region [ SOME EVENTS AND DELEGATES ]

        /// <summary>
        /// used to initialize an event method that closes the control
        /// </summary>
        public event EventHandler CloseConnection;
        /// <summary>
        /// Gives a signal to the subscriber to close the control
        /// </summary>
        /// <param name="e"></param>
        private void CloseControl(EventArgs e)
        {
            EventHandler eh = CloseConnection;
            if (eh != null)
            {
                eh(this, e);
            }
        }

        /// <summary>
        /// used to initialize an event method that sends the data to the control
        /// </summary>
        public event EventHandler DataAvailable;
        /// <summary>
        /// Gives a signal to the subscriber that new data is available
        /// </summary>
        /// <param name="e"></param>
        private void OnDataAvailable(EventArgs e)
        {
            EventHandler eh = DataAvailable;
            if (eh != null)
            {
                eh(this, e);
            }
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs e)
        {
            try
            {
                Bitmap bitmap = (Bitmap)e.Frame.Clone();
                Mirror filter = new Mirror(false, true);
                filter.ApplyInPlace(bitmap);
                picbox_frame.Image = bitmap;
            }
            catch
            {

            }
        }

        private void QR_Scanner_Load(object sender, EventArgs e)
        {
            btn_opencamera.Enabled = true;
            btn_scancode.Enabled = false;
            laser_line.Location = new Point(12, laserStartPos);
            laser_line.Visible = false;
            CaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevices)
            {
                cmb_capturedevices.Items.Add(Device.Name);
            }
            cmb_capturedevices.SelectedIndex = 0;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (FinalFrame.IsRunning == true)
            //{
            //    FinalFrame.Stop();
            //}
        }

        private void btn_opencamera_Click(object sender, EventArgs e)
        {
            try
            {
                FinalFrame = new VideoCaptureDevice(CaptureDevices[cmb_capturedevices.SelectedIndex].MonikerString);
                FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
                FinalFrame.Start();
                btn_opencamera.Enabled = false;
                btn_scancode.Enabled = true;
            }
            catch
            {

            }
        }

        private void btn_scancode_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer_laserline.Start();
            //laser_line.Visible = true;
            btn_scancode.Enabled = false;
            _textdecoded = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BarcodeReader reader = new BarcodeReader();
            try
            {
                Result result = reader.Decode((Bitmap)picbox_frame.Image);
                string decoded = result.ToString().Trim();
                _textdecoded = decoded;
                if (_textdecoded != null)
                {
                    timer1.Stop();
                    timer_laserline.Stop();
                    btn_scancode.Enabled = true;
                    if (FinalFrame.IsRunning == true)
                    {
                        FinalFrame.Stop();
                    }
                    OnDataAvailable(null);
                    CloseControl(null);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            CloseControl(null);
            if (FinalFrame != null)
            {
                if (FinalFrame.IsRunning == true)
                {
                    FinalFrame.Stop();
                }
            }
        }

        #endregion

        private void timer_laserline_Tick(object sender, EventArgs e)
        {

        }
    }
}
