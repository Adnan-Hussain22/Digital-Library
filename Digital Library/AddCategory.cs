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
    public partial class AddCategory : UserControl
    {
        public AddCategory()
        {
            InitializeComponent();
            ProfessionalGrid();
        }
        Lib.Book_Entry BE = new Lib.Book_Entry();
        private int GetId;
        DataTable dt;
        int RowIndex;
        private void ProfessionalGrid()
        {
            //dgvBookDetails.BorderStyle = BorderStyle.None;
            dgv_CategoryDetails.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgv_CategoryDetails.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(221, 232, 241);
            dgv_CategoryDetails.DefaultCellStyle.SelectionBackColor = Color.FromArgb(212, 212, 212);
            dgv_CategoryDetails.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        public event EventHandler CloseConnection;
        /// <summary>
        /// Signal to the subscriber to close the Control
        /// </summary>
        /// <param name="e"></param>
        private void CloseCategoryControl(EventArgs e)
        {
            EventHandler eh = CloseConnection;
            if (eh != null)
            {
                eh(this, e);
            }
        }
        private void ButtonAdd_Click(object sender, EventArgs e) 
        {
            if(filter())
            {
                if (!BE.AvailabilityCategory())
                {
                    BE.BookCategory = TextboxAC_Category.Text;
                    Global.check = BE.AddCategory();
                    if (Global.check)
                    {
                        MessageBox.Show("Category " + TextboxAC_Category.Text + " added successfully", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearAll();
                        dgv_CategoryDetails.Rows.Clear();
                        BindCategory();
                    }
                    else
                        MessageBox.Show("Failed to add category " + TextboxAC_Category.Text, Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Cannot add a duplicate category\nPlease check for availability first", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TextboxAC_Category.Focus();
                }
            }
        }
        private bool filter()
        {
            if (TextboxAC_Category.Text !="")
                return true;
            else
            {
                MessageBox.Show("Please give category name first",Global.CaptionLib,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                TextboxAC_Category.Focus();
                return false;
            }
        }
        private void LabelsInvisible()
        {
            lblCategoryIsAvilable.Visible = false;
            lbleCategoryNotAvilable.Visible = false;
        }
        private void ButtonAC_Back_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void ButtonUpdate_Click(object sender,EventArgs e)
        {
            BE.CategoryId = GetId;
            BE.BookCategory = TextboxAC_Category.Text;
            DialogResult dr;
            if(TextboxAC_Category.Text=="")
            {
                MessageBox.Show("Please select the record", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TextboxAC_Category.Focus();
                return;
            }
            else
            {
                dr=MessageBox.Show("Are you sure you want to update record ?", Global.CaptionLib, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes)
                {
                    Global.check = BE.UpdateCategory();
                    if (Global.check)
                    {
                        MessageBox.Show("Successfully updated", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearAll();
                        dgv_CategoryDetails.Rows.Clear();
                        BindCategory();
                    }
                    else
                    {
                        MessageBox.Show("Enable to add a category\nPlease contact your administrator", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dgv_CategoryDetails.Rows.Clear();
                        BindCategory();
                        return;
                    }
                }
                else
                    return;
            }
        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            BE.CategoryId = GetId;
            BE.BookCategory = TextboxAC_Category.Text;
            DialogResult dr;
            if (TextboxAC_Category.Text == "")
            {
                MessageBox.Show("Please select category ", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TextboxAC_Category.Focus();
                return;
            }
            else
            {
                dr = MessageBox.Show("Are you sure you want to delete record parmenently ?", Global.CaptionLib, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes)
                {
                    Global.check = BE.DeleteCategory();
                    if (Global.check)
                    {
                        MessageBox.Show("Successfully deleted", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearAll();
                        dgv_CategoryDetails.Rows.Clear();
                        BindCategory();
                    }
                    else
                    {
                        MessageBox.Show("Enable to delete a category\nPlease contact your administrator", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dgv_CategoryDetails.Rows.Clear();
                        BindCategory();
                        return;
                    }
                }
                else
                    return;
            }
        }
        private void ButtonNew_Click(object sender, EventArgs e)
        {
            ButtonUpdate.Enabled = false;
            ButtonDelete.Enabled = false;
            ButtonAdd.Enabled = true;
            TextboxAC_Category.Text = "";
        }
        private void label13_Click(object sender, EventArgs e)
        {

        }
        private void BindCategory()
        {
            dt = new DataTable();
            dt = BE.LoadCategory();
            dgv_CategoryDetails.Rows.Clear();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    dgv_CategoryDetails.Rows.Add();
                    dgv_CategoryDetails.Rows[dgv_CategoryDetails.Rows.Count - 1].Cells["ColumnId"].Value = dr["Cat_Id"];
                    dgv_CategoryDetails.Rows[dgv_CategoryDetails.Rows.Count - 1].Cells["ColumnCategory"].Value = dr["Cat_BookCategory"];
                }
                dgv_CategoryDetails.Rows[0].Selected = false;
            }
            else
            {
                MessageBox.Show("No Record found!", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            lblTotalCategories.Text = string.Format("Total Categories : {0}", dgv_CategoryDetails.Rows.Count);
        }
        private void ClearAll()
        {
            TextboxAC_Category.Text = "";
        }
        private void AddCategory_Load(object sender, EventArgs e)
        {
            ButtonUpdate.Enabled = false;
            ButtonDelete.Enabled = false;
            BindCategory();
        }

        private void dgv_CategoryDetails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
                return;
            else
            {
                GetId = Convert.ToInt32(dgv_CategoryDetails.Rows[RowIndex].Cells[0].Value.ToString());
                TextboxAC_Category.Text = dgv_CategoryDetails.Rows[RowIndex].Cells[1].Value.ToString();
                ButtonAdd.Enabled = false;
                ButtonDelete.Enabled = true;
                ButtonUpdate.Enabled = true;
                TextboxAC_Category.Focus();
            }
        }

        private void TextboxAC_Category_TextChanged(object sender, EventArgs e)
        {
            if (TextboxAC_Category.Text == "")
            {
                BindCategory();
                LabelsInvisible();
            }
            else
            {
                BE.BookCategory = TextboxAC_Category.Text;
                SearchCategory();
            }
        }

        private void SearchCategory()
        {
            dt = new DataTable();
            if(TextboxAC_Category.Text!="")
            {
                dt=BE.SearchCategories();
                if(dt.Rows.Count>0)
                {
                    dgv_CategoryDetails.Rows.Clear();
                    foreach (DataRow dr in dt.Rows)
                    {
                        dgv_CategoryDetails.Rows.Add();
                        dgv_CategoryDetails.Rows[dgv_CategoryDetails.Rows.Count - 1].Cells["ColumnId"].Value = dr["Cat_Id"];
                        dgv_CategoryDetails.Rows[dgv_CategoryDetails.Rows.Count - 1].Cells["ColumnCategory"].Value = dr["Cat_BookCategory"];

                    }
                    LabelsInvisible();
                    lblCategoryIsAvilable.Visible = true;
                }
                else
                {
                    LabelsInvisible();
                    lbleCategoryNotAvilable.Visible = true;
                }
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            CloseCategoryControl(null);
        }

        private void TextboxAC_Category_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control == true && e.KeyCode == Keys.A)
            {
                if (ButtonAdd.Enabled == true)
                {
                    ButtonAdd_Click(sender, e);
                }
            }
            else if (e.Control == true && e.KeyCode == Keys.U)
            {
                if (ButtonUpdate.Enabled == true) 
                {
                    ButtonUpdate_Click(sender, e);
                }
            }
            else if (e.Control == true && e.KeyCode == Keys.D)
            {
                if(ButtonDelete.Enabled==true)
                {
                    ButtonDelete_Click(sender, e);
                }
            }
            else if (e.Control == true && e.KeyCode == Keys.N)
            {
                ButtonNew_Click(sender, e);
            }
        }

        private void AddCategory_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void dgv_CategoryDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.S)
            {
                if (RowIndex == -1)
                    return;
                else
                {
                    GetId = Convert.ToInt32(dgv_CategoryDetails.Rows[RowIndex].Cells[0].Value.ToString());
                    TextboxAC_Category.Text = dgv_CategoryDetails.Rows[RowIndex].Cells[1].Value.ToString();
                    ButtonAdd.Enabled = false;
                    ButtonDelete.Enabled = true;
                    ButtonUpdate.Enabled = true;
                    TextboxAC_Category.Focus();
                }
            }

        }

        private void dgv_CategoryDetails_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            RowIndex = e.RowIndex;
        }
    }
}
