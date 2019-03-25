using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital Library
{
    public partial class FrmLibDashboard : Form
    {
        public FrmLibDashboard()
        {
            InitializeComponent();
        }
        #region All Objects 
        AddCategory AC = new AddCategory();
        AddMember Std = new AddMember();
        AddBooks BK = new AddBooks();
        AddSubject sub = new AddSubject();
        ManageLibrarians Users = new ManageLibrarians();
        Details.Book_Details BkDetail = new Details.Book_Details();
        Details.Member_Details MembDetails = new Details.Member_Details();
        Details.Librarian_Details LibDetails = new Details.Librarian_Details();
        Publisher pub = new Publisher();
        Supplier sup = new Supplier();
        Details.Publishers_Detail pubDetails = new Details.Publishers_Detail();
        Details.Suppliers_Detail supDetails = new Details.Suppliers_Detail();
        Book_Issuance BkIssue = new Book_Issuance();
        Details.Issued_Books_Detail IssuedBkDetails = new Details.Issued_Books_Detail();
        ReturnBooks ReturnBk = new ReturnBooks();
        Details.Return_Books_Detail ReturnBKDetails = new Details.Return_Books_Detail();
        JournalMagazine JAM = new JournalMagazine();
        Details.Fine_Payments FnPaymentDetails = new Details.Fine_Payments();
        Settings.Master_Settings masterSettings = new Settings.Master_Settings();
        #endregion

        #region Dynamic Methods
        //private void UpdateBookStatus()
        //{
        //    Lib.Book_Entry Be = new Lib.Book_Entry();
        //    while(Be.FilterBookAvailability())
        //    {
        //        Be.UpdateStatus(0);
        //    }
        //}
        //private void UpdateStatusStudent()
        //{
        //    Lib.Student std = new Lib.Student();
        //    while (std.FilterExpire())
        //    {
        //        std.UpdateStatus();
        //    }
        //}
        #endregion

        #region [ SOME EVENTS AND DELEGATES ]
        /// <summary>
        /// Event method to close the Controls on the signal of publishers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseTheControl(object sender, EventArgs e)
        {
            Control child = sender as Control;
            if (child != null)
            {
                Controls.Remove(child);
               
            }
        }
        private void AddControl(object sender,EventArgs e)
        {
            Control child = sender as Control;
            if(!Controls.Contains(child))
            {
                if (child != null)
                {
                    child.Dock = DockStyle.Left;
                    Controls.Add(child);
                    child.BringToFront();
                }
            }
        }
        private void EditControl(object sender, EventArgs e)
        {
            //Form f = new Form();
            //f.FormBorderStyle = FormBorderStyle.None;
            //Control child = sender as Control;
            //if (child != null)
            //{
            //    f.Size = child.Size;
            //    child.Dock = DockStyle.Fill;
            //    child.BringToFront();
            //    f.Controls.Add(child);
            //}
            //panel_main.Controls.Add(f);
            //f.StartPosition = FormStartPosition.CenterParent;
            //f.BringToFront();
            //f.ShowDialog();

        }
        #endregion
        private void FrmLibDashboard_Load(object sender, EventArgs e)
        {
            menustripMain.Renderer= new ToolStripProfessionalRenderer(new Customization.CustomeMenuStrip());
            //UpdateBookStatus();
            // UpdateStatusStudent();
            Global.LibrarianId = "LIB0607181";
            Global.LibrarianType = "Admin";
            if (Global.LibrarianType.ToLower() == "admin")
            {
                ShowAdminContent();
            }
            else
            {
                ShowLibrarianContent();
            }
        }

        private void ShowLibrarianContent()
        {
            MenuSystemSettings.Visible = false;
        }

        private void ShowAdminContent()
        {
            MenuSystemSettings.Visible = true;
        }

        private void MenuDashboard_Click(object sender, EventArgs e)
        {
            CloseAll();
        }
        
        private void CloseAll()
        {
            Controls.Remove(AC);
            Controls.Remove(BK);
            Controls.Remove(Std);
            Controls.Remove(sub);
            Controls.Remove(Users);
            Controls.Remove(BkDetail);
            Controls.Remove(MembDetails);
            Controls.Remove(LibDetails);
            Controls.Remove(pub);
            Controls.Remove(sup);
            Controls.Remove(pubDetails);
            Controls.Remove(supDetails);
            Controls.Remove(BkIssue);
            Controls.Remove(IssuedBkDetails);
            Controls.Remove(ReturnBk);
            Controls.Remove(ReturnBKDetails);
            Controls.Remove(JAM);
            Controls.Remove(FnPaymentDetails);
            Controls.Remove(masterSettings);
        }

        private void toolstrpMenuClass_Click(object sender, EventArgs e)
        {
            //CloseAll();
            //showDialog();
            //cl.Visible = true;
            //cl.CloseConnection += new EventHandler(CloseTheControl);
            //cl.Dock = DockStyle.Left;
            //this.Controls.Add(cl);
            //cl.BringToFront();
        }

        private void toolstrpMenuCategory_Click(object sender, EventArgs e)
        {
            CloseAll();
            AC.Visible = true;
            AC.CloseConnection += new EventHandler(CloseTheControl);
            AC.Dock = DockStyle.Left;
            this.Controls.Add(AC);
            AC.BringToFront();
        }

        private void toolstrpMenuSubject_Click(object sender, EventArgs e)
        {
            CloseAll();
            sub.Visible = true;
            sub.CloseConnection += new EventHandler(CloseTheControl);
            sub.Dock = DockStyle.Left;
            this.Controls.Add(sub);
            sub.BringToFront();
        }

        private void toolstrpmenuIssueBooks_Click(object sender, EventArgs e)
        {
            CloseAll();
            BkIssue.CloseConnection += new EventHandler(CloseTheControl);
            BkIssue.Dock = DockStyle.Left;
            this.Controls.Add(BkIssue);
            BkIssue.BringToFront();
        }

        /// <summary>
        /// closes the StaffReserveBook Control on a signal of back button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseReverveBookControl(object sender,EventArgs e)
        {
            //ManageBookReservation child = BKReserve;
            //child = sender as ManageBookReservation;
            //if(child!=null)
            //{
            //    Controls.Remove(BKReserve);
            //    BKReserve.Visible = false;
            //}
            //if(Controls.Contains(BKReserve))
            //{
            //    var check = false;
            //}
        }
        private void toolstrpmenuReserveBookStaff_Click(object sender, EventArgs e)
        {
            //BKReserve.CloseControlConnection += new EventHandler(CloseTheControl);
            //CloseAll();
            //if (BKReserve.Contains(BKReserve))
            //{
            //    Visible = true;
            //}
            //else
            //{
            //    BKReserve.Visible = true;
            //    BKReserve.Dock = DockStyle.Left;
            //    Controls.Add(BKReserve);
            //    BKReserve.BringToFront();
            //}
        }
        private void toolstrpmenuReturnBooks_Click(object sender, EventArgs e)
        {
            CloseAll();
            ReturnBk.Dock = DockStyle.Left;
            ReturnBk.CloseConnection += new EventHandler(CloseTheControl);
            Controls.Add(ReturnBk);
            ReturnBk.BringToFront();
        }

        private void toolStpmenuOperators_Click(object sender, EventArgs e)
        {
            CloseAll();
            Users.Dock = DockStyle.Left;
            Users.CloseConnection += new EventHandler(CloseTheControl);
            Controls.Add(Users);
            Users.BringToFront();
        }

        private void toolstrpMenuBooks_Click(object sender, EventArgs e)
        {
            CloseAll();
            BK.Dock = DockStyle.Left;
            BK.CloseConnection += new EventHandler(CloseTheControl);
            Controls.Add(BK);
            BK.BringToFront();
        }

        private void toolstrpMenuBooksDetail_Click(object sender, EventArgs e)
        {
            CloseAll();
            BkDetail.Dock = DockStyle.Left;
            BkDetail.CloseConnection += new EventHandler(CloseTheControl);
            Controls.Add(BkDetail);
            BkDetail.BringToFront();
        }

        private void toolstrpMenuMemberssDetail_Click(object sender, EventArgs e)
        {
            CloseAll();
            MembDetails.Dock = DockStyle.Left;
            MembDetails.CloseConnection += new EventHandler(CloseTheControl);
            Controls.Add(MembDetails);
            MembDetails.BringToFront();
        }

        private void toolStpmenuBookDetails_Click(object sender, EventArgs e)
        {
            CloseAll();
            LibDetails.Dock = DockStyle.Left;
            LibDetails.CloseConnection += new EventHandler(CloseTheControl);
            Controls.Add(LibDetails);
            LibDetails.BringToFront();
        }

        private void toolstrpMenuPublishers_Click(object sender, EventArgs e)
        {
            CloseAll();
            pub.Dock = DockStyle.Left;
            pub.CloseConnection += new EventHandler(CloseTheControl);
            Controls.Add(pub);
            pub.BringToFront();
        }

        private void toolstrpMenuSuppliers_Click(object sender, EventArgs e)
        {
            CloseAll();
            sup.Dock = DockStyle.Left;
            sup.CloseConnection += new EventHandler(CloseTheControl);
            Controls.Add(sup);
            sup.BringToFront();
        }

        private void toolstrpMenuPublishersDetail_Click(object sender, EventArgs e)
        {
            CloseAll();
            pubDetails.Dock = DockStyle.Left;
            pubDetails.CloseConnection += new EventHandler(CloseTheControl);
            Controls.Add(pubDetails);
            pubDetails.BringToFront();
        }

        private void toolstrpMenuSuppliersDetail_Click(object sender, EventArgs e)
        {
            CloseAll();
            supDetails.Dock = DockStyle.Left;
            supDetails.CloseConnection += new EventHandler(CloseTheControl);
            Controls.Add(supDetails);
            supDetails.BringToFront();
        }

        private void toolstrpMenuIssuedBooksDetail_Click(object sender, EventArgs e)
        {
            CloseAll();
            IssuedBkDetails.Dock = DockStyle.Left;
            IssuedBkDetails.CloseConnection += new EventHandler(CloseTheControl);
            Controls.Add(IssuedBkDetails);
            IssuedBkDetails.BringToFront();
        }

        private void toolstrpMenuIssuedReturnBooksDetail_Click(object sender, EventArgs e)
        {
            CloseAll();
            ReturnBKDetails.Dock = DockStyle.Left;
            ReturnBKDetails.CloseConnection += new EventHandler(CloseTheControl);
            Controls.Add(ReturnBKDetails);
            ReturnBKDetails.BringToFront();
        }

        private void toolstrpMenuMembers_Click(object sender, EventArgs e)
        {
            CloseAll();
            Std.Visible = true;
            Std.CloseConnection += new EventHandler(CloseTheControl);
            Std.Dock = DockStyle.Left;
            this.Controls.Add(Std);
            Std.BringToFront();
        }

        private void toolstrpMenuAddJournalMagazines_Click(object sender, EventArgs e)
        {
            CloseAll();
            JAM.CloseConnection += new EventHandler(CloseTheControl);
            JAM.Dock = DockStyle.Left;
            Controls.Add(JAM);
            JAM.BringToFront();
        }

        private void toolstrpMenuFinePaymentDetail_Click(object sender, EventArgs e)
        {
            CloseAll();
            FnPaymentDetails.CloseConnection += new EventHandler(CloseTheControl);
            FnPaymentDetails.Dock = DockStyle.Left;
            Controls.Add(FnPaymentDetails);
            FnPaymentDetails.BringToFront();
        }

        private void toolStpmenuMasterSettings_Click(object sender, EventArgs e)
        {
            CloseAll();
            masterSettings.CloseConnection += new EventHandler(CloseTheControl);
            masterSettings.Dock = DockStyle.Left;
            Controls.Add(masterSettings);
            masterSettings.BringToFront();
        }

        private void toolstrpMemberStudent_Click(object sender, EventArgs e)
        {

        }
    }
}
