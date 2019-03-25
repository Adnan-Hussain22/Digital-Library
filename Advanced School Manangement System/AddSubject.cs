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
    public partial class AddSubject : UserControl
    {
        public AddSubject()
        {
            InitializeComponent();
            ProfessionalGrid();
        }
        Lib.Book_Entry be = new Lib.Book_Entry();
        DataTable dt;
        int RowIndex;
        public event EventHandler CloseConnection;
        /// <summary>
        /// Signal to the subscriber to close the control
        /// </summary>
        /// <param name="e"></param>
        private void CloseSubjectControl(EventArgs e)
        {
            EventHandler eh = CloseConnection;
            if (eh != null)
            {
                eh(this, e);
            }
        }
        private void AddSubject_Load(object sender, EventArgs e)
        {
            BindData();
            ClearAll();
        }
        private void ProfessionalGrid()
        {
            //dgvBookDetails.BorderStyle = BorderStyle.None;
            dgv_SubjectDetails.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgv_SubjectDetails.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(221, 232, 241);
            dgv_SubjectDetails.DefaultCellStyle.SelectionBackColor = Color.FromArgb(212, 212, 212);
            dgv_SubjectDetails.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        private void ClearAll()
        {
            textboxSubjectName.Text = "";
            BttnAdd.Enabled = true;
            BttnDelete.Enabled = false;
            BttnUpdate.Enabled = false;
            lblSubjectIsAvilable.Visible = false;
            lbleSubjectNotAvilable.Visible = false;
        }
        private void BindData()
        {
            dt = new DataTable();
            dt = be.GetSubjects();
            dgv_SubjectDetails.Rows.Clear();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    dgv_SubjectDetails.Rows.Add();
                    dgv_SubjectDetails.Rows[dgv_SubjectDetails.Rows.Count - 1].Cells["ColumnId"].Value = dr["Sub_Id"];
                    dgv_SubjectDetails.Rows[dgv_SubjectDetails.Rows.Count - 1].Cells["ColumnSubject"].Value = dr["Sub_BookSubject"];

                }
                lblTotalSubjects.Text = string.Format("Total Subjects : {0}", dgv_SubjectDetails.Rows.Count);
                dgv_SubjectDetails.Rows[0].Selected = false;
            }
        }
        private void BindSearchData()
        {
            dt = new DataTable();
            dt = be.SearchSubject();
            dgv_SubjectDetails.Rows.Clear();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    dgv_SubjectDetails.Rows.Add();
                    dgv_SubjectDetails.Rows[dgv_SubjectDetails.Rows.Count - 1].Cells["ColumnId"].Value = dr["Sub_Id"];
                    dgv_SubjectDetails.Rows[dgv_SubjectDetails.Rows.Count - 1].Cells["ColumnSubject"].Value = dr["Sub_BookSubject"];

                }
                lblTotalSubjects.Text = string.Format("Total Subjects : {0}", dgv_SubjectDetails.Rows.Count);
            }
        }
        private void BttnAdd_Click(object sender, EventArgs e)
        {
            be.Subject = textboxSubjectName.Text;
            if(!be.SubjectValidation())
            {
                MessageBox.Show("Please give Subject", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textboxSubjectName.Focus();
                return;
            }
            else
            {
                Global.check = be.AddSubject();
                if (Global.check)
                {
                    MessageBox.Show("Subject added successfully", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAll();
                    BindData();
                }
                else
                {
                    MessageBox.Show("Failed to add a subject something may be wrong\nplease contact your administrator", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }
        private void BttnUpdate_Click(object sender, EventArgs e)
        {
            be.Subject = textboxSubjectName.Text;
            DialogResult dr;
            if (!be.SubjectValidation())
            {
                MessageBox.Show("Please give Subject", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textboxSubjectName.Focus();
                return;
            }
            else
            {
                dr=MessageBox.Show("Are you sure you want to update", Global.CaptionLib, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes)
                {
                    Global.check = be.UpdateSubject();
                    if (Global.check)
                    {
                        MessageBox.Show("Subject added successfully", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearAll();
                        BindData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update a subject something may be wrong\nplease contact your administrator", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else
                    return;
            }
        }
        private void BttnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            if (be.SubjectId==0)
            {
                MessageBox.Show("Please select the desired record", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textboxSubjectName.Focus();
                return;
            }
            else
            {
                dr = MessageBox.Show("Are you sure you want to delete the record permenently ?", Global.CaptionLib, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes)
                {
                    Global.check = be.DeleteSubject();
                    if (Global.check)
                    {
                        MessageBox.Show("Subject deleted successfully", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearAll();
                        BindData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete a subject something may be wrong\nplease contact your administrator", Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else
                    return;
            }
        }
        private void BttnNew_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void BttnBack_Click(object sender, EventArgs e)
        {
            CloseSubjectControl(null);
        }

        private void dgv_SubjectDetails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex > 2)
                return;
            else
            {
                be.SubjectId = int.Parse(dgv_SubjectDetails.Rows[e.RowIndex].Cells[0].Value.ToString());
                textboxSubjectName.Text = dgv_SubjectDetails.Rows[e.RowIndex].Cells[1].Value.ToString();
                BttnUpdate.Enabled = true;
                BttnDelete.Enabled = true;
                BttnAdd.Enabled = false;
            }
        }

        private void ButtnAvailability_Click(object sender, EventArgs e)
        {
            if (textboxSubjectName.Text != "")
            {
                be.BookCategory = textboxSubjectName.Text;
                if (!be.SubjectAvailability())
                {
                    lbleSubjectNotAvilable.Visible = true;
                    lblSubjectIsAvilable.Visible = false;
                }
                else
                {
                     lbleSubjectNotAvilable.Visible = false;
                    lblSubjectIsAvilable.Visible = true;
                }
            }
        }

        private void dgv_SubjectDetails_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            RowIndex = e.RowIndex;
        }

        private void dgv_SubjectDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control==true && e.KeyCode==Keys.S)
            {
                if (RowIndex == -1)
                    return;
                else
                {
                    be.SubjectId = int.Parse(dgv_SubjectDetails.Rows[RowIndex].Cells[0].Value.ToString());
                    textboxSubjectName.Text = dgv_SubjectDetails.Rows[RowIndex].Cells[1].Value.ToString();
                    BttnUpdate.Enabled = true;
                    BttnDelete.Enabled = true;
                    BttnAdd.Enabled = false;
                    textboxSubjectName.Focus();
                }
            }
        }

        private void textboxSubjectName_TextChanged(object sender, EventArgs e)
        {
            if(textboxSubjectName.Text=="")
            {
                BindData();
            }
            else
            {
                be.Subject=textboxSubjectName.Text;
                BindSearchData();
            }
        }

        private void textboxSubjectName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control==true && e.KeyCode==Keys.A)
            {
                if(BttnAdd.Enabled == true)
                {
                    BttnAdd_Click(sender, e);
                }
            }
            else if(e.Control == true && e.KeyCode == Keys.U)
            {
                if(BttnUpdate.Enabled==true)
                {
                    BttnUpdate_Click(sender, e);
                }
            }
            else if (e.Control == true && e.KeyCode == Keys.D)
            {
                if (BttnDelete.Enabled == true)
                {
                    BttnDelete_Click(sender, e);
                }
            }
            else if (e.Control == true && e.KeyCode == Keys.N)
            {
                BttnNew_Click(sender, e);
            }
        }
    }
}
