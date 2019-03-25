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
    public partial class Shelf : UserControl
    {
        public Shelf()
        {
            InitializeComponent();
        }

        #region [ OBEJCTS AND VARIABLES ]
        Lib.Shelf shelf;
        long ShelfCapacity = Properties.Settings.Default.ShelfCapacity;
        #endregion

        #region [ METHODS ]

        #endregion

        #region [ PROPERTIES ]

        #endregion

        #region [ EVENTS AND DELEGATES ]
        /// <summary>
        /// Initialize the signal from the subscriber that the control has been subscribed
        /// </summary>
        public event EventHandler CloseConnection;

        /// <summary>
        /// Signal to the subscriber to close the control
        /// </summary>
        /// <param name="e"></param>
        private void OnCloseConnection(EventArgs e)
        {
            EventHandler eh = CloseConnection;
            if (eh != null)
            {
                eh(this, e);
            }
        }
        #endregion

        private void checkbox_bulkadd_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_bulkadd.CheckState == CheckState.Checked)
            {
                textbox_shelfamount.Enabled = true;
                textbox_shelfamount.Text = "1";
            }
            else
            {
                textbox_shelfamount.Enabled = false;
                textbox_shelfamount.Text = "1";
            }
        }

        private void Shelf_Load(object sender, EventArgs e)
        {
            shelf = new Lib.Shelf();
            textbox_capacity.Text = ShelfCapacity.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            shelf.Capacity = Convert.ToInt32(textbox_capacity.Text);
            if (shelf.AddShelf(Convert.ToInt32(textbox_shelfamount.Text))) 
            {
                var shelfamount = "shelf";
                if (Convert.ToInt32(textbox_shelfamount.Text) > 0)
                    shelfamount = "shelfs";
                MessageBox.Show(textbox_shelfamount.Text + " " + shelfamount + " added successfully", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Information);
                OnCloseConnection(null);
                return;
            }
            else
            {
                MessageBox.Show("Failed to add shelfs because the connection was intrupted, something may be wrong please try again or contact you administrator", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            } 
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            OnCloseConnection(null);
        }
    }
}
