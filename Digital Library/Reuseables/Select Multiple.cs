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
    public partial class Select_Multiple : UserControl
    {
        public Select_Multiple()
        {
            InitializeComponent();
        }

        #region [ OBJECTS AND VARIABLES ]
        List<int> selectitems = new List<int>();
        DataTable dt;
        #endregion

        #region [ PROPERTIES ]

        public int[] SelectedItems
        {
            get;
            set;
        }

        #endregion

        #region [ METHODS ]


        /// <summary>
        /// gets the selected items from the list box
        /// </summary>
        private void GetSelectedItems()
        {
            selectitems.Clear();
            foreach (var item in checkedListBox1.CheckedIndices)
            {
                hiddenlist.SetItemChecked(Convert.ToInt32(item), true);
            }
            foreach (var item in hiddenlist.CheckedItems)
            {
                selectitems.Add(Convert.ToInt32(item));
            }
            SelectedItems = selectitems.ToArray();
        }

        private void LoadItems()
        {
            var ed = new Lib.Editor();
            dt = ed.GetEditors();
            if (dt.Rows.Count > 0)
            {
                checkedListBox1.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    checkedListBox1.Items.Add(dr["Name"]);
                    hiddenlist.Items.Add(dr["Id"]);
                }
            }
        }

        #endregion

        #region [ SOME IMPORTANT EVENTS AND DELEGATES ]

        public event EventHandler DataAvailable;

        private void OnDataAvialable(EventArgs e)
        {
            EventHandler eh = DataAvailable;
            if (eh != null)
            {
                eh(this, e);
            }
        }


        public event EventHandler CloseConnection;

        private void OnCloseConnection(EventArgs e)
        {
            EventHandler eh = CloseConnection;
            if (eh != null)
                eh(this, e);
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedIndices.Count > 0)
            {
                GetSelectedItems();
                OnDataAvialable(null);
                OnCloseConnection(null);
            }
            else
            {
                MessageBox.Show("Please select some records first", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            OnCloseConnection(null);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            foreach (int i in checkedListBox1.CheckedIndices)
            {
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void Select_Multiple_Load(object sender, EventArgs e)
        {
            LoadItems();
        }

        #endregion

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(checkedListBox1.GetItemCheckState(checkedListBox1.SelectedIndex) == CheckState.Unchecked)
            {
                checkedListBox1.SetItemCheckState(checkedListBox1.SelectedIndex, CheckState.Checked);
            }
            else
            {
                checkedListBox1.SetItemCheckState(checkedListBox1.SelectedIndex, CheckState.Unchecked);
            }
            
        }
    }
}
