using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital Library.Reuseables
{
    public partial class fines : UserControl
    {
        public fines()
        {
            InitializeComponent();
            //OnDataAvailable(null);
            IsPaid = true;
        }
        #region [ PROPERTIES ]
        public string MemberId
        {
            get;
            set;
        }
        public double Fine
        {
            get;
            set;
        }
        public double Amount
        {
            get;
            set;
        }
        public double Paid
        {
            get;
            set;
        }
        public bool IsPaid
        {
            get;
            set;
        }
        #endregion

        private void getData()
        {
            textbox_memberid.Text= MemberId;
            //textbox_fine.Text = Fine;
            textbox_fine.Text = Fine.ToString();
        }

        private double calculateDueAmount(double paidAmount,double totalAmount)
        {
            var dueamount = 0.0;
            dueamount = totalAmount - paidAmount;
            return dueamount;
        }

        #region [EVENTS AND DELEGATES ]
        public event EventHandler DataAvailable;
        private void OnDataAvailable(EventArgs e)
        {
            var eh = DataAvailable;
            if (eh != null)
                eh(this, e);
        }
        public event EventHandler CloseConnection;
        private void OnCloseConnection(EventArgs e)
        {
            var eh = CloseConnection;
            if (eh != null)
                eh(this, e);
        }
        #endregion

        private void fines_Load(object sender, EventArgs e)
        {
            OnDataAvailable(null);
            getData();
            IsPaid = false;
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            if (Global.IsAllNumbers(textbox_paidamount.Text))
            {
                IsPaid = true;
                Paid = Convert.ToDouble(textbox_paidamount.Text);
                OnDataAvailable(null);
                OnCloseConnection(null);
            }
            else
            {
                MessageBox.Show("Please enter a valid amount", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void textbox_paidamount_TextChanged(object sender, EventArgs e)
        {
            if (Global.IsAllNumbers(textbox_paidamount.Text))
            {
                textbox_dueamount.Text = calculateDueAmount(Convert.ToDouble(textbox_paidamount.Text), Convert.ToDouble(textbox_fine.Text)).ToString();
            }
        }
    }
}
