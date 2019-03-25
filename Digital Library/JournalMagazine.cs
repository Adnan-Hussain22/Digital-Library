using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital Library
{
    public partial class JournalMagazine : UserControl
    {
        public JournalMagazine()
        {
            InitializeComponent();
        }

        #region [ OBEJCTS AND VARIABLES ]
        Lib.Journal_And_Magazine JAM = new Lib.Journal_And_Magazine();
        string imagepath = "";
        Image backgroundimage;
        Reuseables.Select_Multiple sm;
        Reuseables.Add_Specific AS;
        Lib.Editor ED;
        Form f = new Form();
        DataTable dt;
        bool issnIsNumber = false;
        #endregion

        #region [ PROPERTIES ]
        #endregion

        #region [ METHODS ]

        private void ClearAll()
        {
            textbox_mainid.Text = JAM.GetMainId();
            textbox_title.Text = "";
            textbox_category.Text = "";
            textbox_frequency.Text = "";
            textbox_issn.Text = "";
            textbox_publication.Text = "";
            textbox_publisher.Text = "";
            textbox_volume.Text = "";
            cmb_editedby.SelectedIndex = 0;
            cmb_laguage.SelectedIndex = 0;
            picBox_Image.Image = null;
            picBox_Image.BackgroundImage = backgroundimage;
            //JAM.Editors = null;
        }

        private void GetAllData()
        {
            JAM.Id = textbox_mainid.Text;
            JAM.Title = textbox_title.Text;
            JAM.Category = textbox_category.Text;
            JAM.Frequency = textbox_frequency.Text;
            if (Global.IsAllNumbers(textbox_issn.Text))
            {
                JAM.ISSN = Convert.ToInt64(textbox_issn.Text);
                issnIsNumber = true;
            }
            JAM.Publication = textbox_publication.Text;
            JAM.Publisher = textbox_publisher.Text;
            JAM.Volume = textbox_volume.Text;
            if (cmb_editedby.SelectedIndex > 1) 
            {
                if (cmb_editedby.SelectedIndex > 2)
                {
                    hiddenfield_editedby.SelectedIndex = cmb_editedby.SelectedIndex - 3;
                    JAM.Editors[0] = Convert.ToInt32(hiddenfield_editedby.SelectedItem.ToString());
                }
            }
            if (cmb_laguage.SelectedIndex > 1)
            {
                JAM.Language = cmb_laguage.SelectedItem.ToString();
            }

            if (imagepath != "")
            {
                JAM.ImageBytes = Global.ConvertIntoBytes(imagepath);
            }
            else
            {
                JAM.ImageBytes = Global.ImageToBytes(picBox_Image.BackgroundImage);
            }
        }

        private void Filter()
        {
            if (textbox_title.Text == "")
            {
                MessageBox.Show("Please enter title first", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textbox_title.Focus();
                return;
            }
            else if (textbox_publisher.Text == "")
            {
                MessageBox.Show("Please enter title first", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textbox_publisher.Focus();
                return;
            }
            else if (textbox_volume.Text == "")
            {
                MessageBox.Show("Please enter volume No first", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textbox_volume.Focus();
                return;

            }
            else if (textbox_publication.Text == "")
            {
                MessageBox.Show("Please enter publication description first\ne.g. 2010-17 etc", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textbox_publication.Focus();
                return;
            }
            else if (textbox_issn.Text == "" && !issnIsNumber)
            {
                MessageBox.Show("Please enter a proper ISSN No first", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textbox_issn.Focus();
                return;
            }
            else if (textbox_frequency.Text == "")
            {
                MessageBox.Show("Please enter the frequency first\ne.g. monthly, weekly, dealy, yearly etc", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textbox_frequency.Focus();
                return;
            }
            else if (cmb_editedby.SelectedIndex <= 1) 
            {
                MessageBox.Show("Please select the editor of journal / magazine", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmb_editedby.Focus();
                return;
            }
            else if (cmb_laguage.SelectedIndex <= 1)
            {
                MessageBox.Show("Please select the language of journal / magazine", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmb_laguage.Focus();
                return;
            }

        }

        private void LoadEditors()
        {
            ED = new Lib.Editor();
            dt = new DataTable();
            dt = ED.GetEditors();
            if (dt.Rows.Count > 0)
            {
                cmb_editedby.Items.Clear();
                cmb_editedby.Items.Add("Select an appropriate editor");
                cmb_editedby.Items.Add("Add specific editor");
                cmb_editedby.Items.Add("Select multiple");
                foreach (DataRow dr in dt.Rows)
                {
                    cmb_editedby.Items.Add(dr["ED_FirstName"]+" "+dr["ED_LastName"]);
                    hiddenfield_editedby.Items.Add(dr["ED_Id"]);
                }
            }
        }

        private void ShowSelectMultipleEditor()
        {
            f.FormBorderStyle = FormBorderStyle.None;
            sm = new Reuseables.Select_Multiple();
            sm.CloseConnection += new EventHandler(CloseTheControl);
            sm.DataAvailable += new EventHandler(SelectedEditorsAvailable);
            sm.Dock = DockStyle.Fill;
            sm.BringToFront();
            f.Size = sm.Size;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Controls.Add(sm);
            f.ShowDialog();
            f.BringToFront();
        }

        private void ShowAddSpecificEditor()
        {
            f.FormBorderStyle = FormBorderStyle.None;
            AS = new Reuseables.Add_Specific("Editor");
            AS.CloseConnection += new EventHandler(CloseTheControl);
            AS.Dock = DockStyle.Fill;
            AS.BringToFront();
            f.Size = AS.Size;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Controls.Add(AS);
            f.ShowDialog();
            f.BringToFront();
            LoadEditors();
        }

        #endregion

        #region [ SOME IMPORTANT EVENTS AND DELEGATES ]

        private void SelectedEditorsAvailable(object sender,EventArgs e)
        {
            JAM.Editors = sm.SelectedItems;
        }

        public event EventHandler CloseConnection;

        private void OnCloseConnection(EventArgs e)
        {
            EventHandler eh = CloseConnection;
            if (eh != null)
                eh(this, e);
        }

        private void CloseTheControl(object sender,EventArgs e)
        {
            Control child = sender as Control;
            if (child != null)
            {
                f.Controls.Remove(child);
                f.Close();
            }
        }

        private void JournalMagazine_Load(object sender, EventArgs e)
        {
            LoadEditors();
            cmb_editedby.SelectedIndex = 0;
            cmb_laguage.SelectedIndex = 0;
            backgroundimage = picBox_Image.BackgroundImage;
            textbox_mainid.Text = JAM.GetMainId();
        }

        private void btn_add_Click(object sender,EventArgs e)
        {
            GetAllData();
            if(JAM.Validate())
            {
                if (JAM.AddJournalMagazine())
                {
                    MessageBox.Show("Record added successfully", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAll();
                    return;
                }
                else
                {
                    MessageBox.Show("Enable to add a record something may be wrong please check the server or contact the administrator", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                Filter();
            }
        }
        private void cmb_editedby_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_editedby.SelectedIndex == 2)
            {
                ShowSelectMultipleEditor();
            }
            else if (cmb_editedby.SelectedIndex == 1)
            {
                ShowAddSpecificEditor();
            }
        }

        private void btn_uplaodimage_Click(object sender, EventArgs e)
        {
            string filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|svg files(*.svg)|*.svg|jpeg files(*.jpeg)|*.jpeg";
            imagepath = Global.GetFilePath(filter);
            if (imagepath != "")
            {
                picBox_Image.BackgroundImage = null;
                picBox_Image.ImageLocation = imagepath;
            }
        }

        private void cmb_laguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_laguage.SelectedIndex == 1)
            {

            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            OnCloseConnection(null);
        }

        #endregion

    }
}
