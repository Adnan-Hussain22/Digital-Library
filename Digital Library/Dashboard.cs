using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Digital Library.Customization;
using System.Data.SqlClient;
using Digital Library.Lib;

namespace Digital Library
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            AllLabels();
        }

        #region [Events Data]

        public void GetActionData(object sender, ActionDataEventArgs e)
        {
            picbxTopRight_Avatar.Image = e.Picture;
            lblTopRight_AvatarName.Text = e.LibName;
            lblTopRight_MemberID.Text = e.LibID;
            lblTopRight_MemberType.Text = e.LibType;
        }
        #endregion

        #region All Objects
        SqlCommand cmd;
        AddCategory _addCategory = new AddCategory();
        AddMember _addMember = new AddMember();
        AddBooks _addBooks = new AddBooks();
        AddSubject _addSubject = new AddSubject();
        ManageLibrarians _manageLibrarians = new ManageLibrarians();
        Details.Book_Details _bookDetails = new Details.Book_Details();
        Details.Member_Details _memberDetails = new Details.Member_Details();
        Details.Librarian_Details _librarianDetails = new Details.Librarian_Details();
        Publisher _publisher = new Publisher();
        Supplier _supplier = new Supplier();
        Details.Publishers_Detail _publishersDetail = new Details.Publishers_Detail();
        Details.Suppliers_Detail _suppliersDetail = new Details.Suppliers_Detail();
        Book_Issuance _bookIssuance = new Book_Issuance();
        Details.Issued_Books_Detail _issuedBooksDetail = new Details.Issued_Books_Detail();
        ReturnBooks _returnBooks = new ReturnBooks();
        Details.Return_Books_Detail _returnBooksDetail = new Details.Return_Books_Detail();
        JournalMagazine _journalMagazine = new JournalMagazine();
        Details.Fine_Payments _finePayments = new Details.Fine_Payments();
        Settings.Master_Settings _masterSettings = new Settings.Master_Settings();
        #endregion
       
        #region [Close Controls]

        private void CloseAllControls()
        {            
            pnlRight_ShowControls.Visible = true;
            pnlRight_Page1_Dashboard.Visible = false;            
            pnlRight_ShowControls.Controls.Clear();
        }

        #endregion

        #region [Labels Initializers]

        private Label[] _masterEntryLabels = new Label[6];
        private Label[] _bookCirculationLabels = new Label[2];
        private Label[] _reporsLabels = new Label[7];
        private Label[] _settingsLabels = new Label[3];

        private void AllLabels()
        {
            _masterEntryLabels[0] = lblSliderMembers_MasterEntry;
            _masterEntryLabels[1] = lblSliderBooks_MasterEntry;
            _masterEntryLabels[2] = lblSliderSuppliers_MasterEntry;
            _masterEntryLabels[3] = lblSliderPublishers_MasterEntry;
            _masterEntryLabels[4] = lblSliderSubject_MasterEntry;
            _masterEntryLabels[5] = lblSliderCategory_MasterEntry;


            _bookCirculationLabels[0] = lblSliderIssueBook_BookCirculation;
            _bookCirculationLabels[1] = lblSliderReturnBook_BookCirculation;

            _reporsLabels[0] = lblSliderFinePayments_Reports;
            _reporsLabels[1] = lblSliderMembers_Reports;
            _reporsLabels[2] = lblSliderBooks_Reports;
            _reporsLabels[3] = lblSliderPublishers_Reports;
            _reporsLabels[4] = lblSliderSuppliers_Reports;
            _reporsLabels[5] = lblSliderReturnedBooks_Reports;
            _reporsLabels[6] = lblSliderIssuedBooks_Reports;

            _settingsLabels[0] = lblSliderAddLibrarian_GlobalSettings;
            _settingsLabels[1] = lblSliderLibrarian_GlobalSettings;
            _settingsLabels[2] = lblSliderSettings_GlobalSettings;

        }

        #endregion

       

        private void pnlLeft_Main_Paint(object sender, PaintEventArgs e)
        {
            OnPaint_LeftPanel(e);
        }

        private void pnlLeft_Dashboard_Paint(object sender, PaintEventArgs e)
        {
            OnPaint(e);
        }

        protected void OnPaint_LeftPanel(PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle,
                Color.Black, 0, ButtonBorderStyle.None,
                Color.Black, 0, ButtonBorderStyle.None,
                Color.FromArgb(180, 180, 180), 2, ButtonBorderStyle.Solid,
                Color.FromArgb(202, 202, 202), 1, ButtonBorderStyle.None);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle,
                Color.Black, 0, ButtonBorderStyle.None,
                Color.FromArgb(202, 202, 202), 1, ButtonBorderStyle.None,
                Color.FromArgb(173, 173, 173), 1, ButtonBorderStyle.None,
                Color.FromArgb(202, 202, 202), 1, ButtonBorderStyle.Solid);
        }

        private void pnlLeft_MasterEntry_Paint(object sender, PaintEventArgs e)
        {
            OnPaint(e);
        }

        private void pnlLeft_BookCirculation_Paint(object sender, PaintEventArgs e)
        {
            OnPaint(e);
        }

        private void pnlLeft_Reports_Paint(object sender, PaintEventArgs e)
        {
            OnPaint(e);
        }

        private void pnlLeft_GlobalSettings_Paint(object sender, PaintEventArgs e)
        {
            OnPaint(e);
        }


        // Methods to recognize each button

        private void DashboardButton_Hover(object sender, EventArgs e)
        {
            if (lblNameLeft_Dashboard.ForeColor == Color.Black)
            {
                return;
            }
            else
            {
                if (pnlLeft_Dashboard.BackColor == Color.WhiteSmoke)
                {
                    pnlLeft_Dashboard.BackColor = Color.White;
                }
                else if (pnlLeft_Dashboard.BackColor == Color.White)
                {
                    pnlLeft_Dashboard.BackColor = Color.WhiteSmoke;
                }
            }

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            FormAnimation.AnimateWindow(this.Handle, 200, FormAnimation.HOR_Positive);  
            pnlLeft_Dashboard.BackColor = Color.White;
            picbxLeft_Dashboard.Load(@"..\..\Resources\Dashboard\After Click\Dashboard_Black.png");
            lblNameLeft_Dashboard.ForeColor = Color.Black;
            _flagClick = 1;
            pnlRight_Page1_Dashboard.Visible = true;
            pnlRight_ShowControls.Visible = false;
            this.Refresh();
            Global.LibrarianId = "LIB0607181";
            Global.LibrarianType = "Admin";
        }

        private void ResetClick(int Id)
        {
            switch (Id)
            {
                case 1:
                {
                    pnlLeft_Dashboard.BackColor = Color.WhiteSmoke;
                    picbxLeft_Dashboard.Load(@"..\..\Resources\Dashboard\Before Click\Dashboard_Grey.png");
                    lblNameLeft_Dashboard.ForeColor = Color.FromArgb(110, 110, 110);
                    break;
                }
                case 2:
                {
                    pnlLeft_MasterEntry.BackColor = Color.WhiteSmoke;
                    picbxLeft_MasterEntry.Load(@"..\..\Resources\Dashboard\Before Click\Master Entry_Grey.png");
                    lblLeft_MasterEntry.ForeColor = Color.FromArgb(110, 110, 110);
                    break;
                }
                case 3:
                {
                    pnlLeft_BookCirculation.BackColor = Color.WhiteSmoke;
                    picbxLeft_Book.Load(@"..\..\Resources\Dashboard\Before Click\Books_Grey.png");
                    lblLeft_Books.ForeColor = Color.FromArgb(110, 110, 110);
                    break;
                }
                case 4:
                {
                    pnlLeft_Reports.BackColor = Color.WhiteSmoke;
                    picbxLeft_Reports.Load(@"..\..\Resources\Dashboard\Before Click\Reports_Grey.png");
                    lblLeft_Reports.ForeColor = Color.FromArgb(110, 110, 110);
                    break;
                }
                case 5:
                {
                    pnlLeft_GlobalSettings.BackColor = Color.WhiteSmoke;
                    picbxLeft_Settings.Load(@"..\..\Resources\Dashboard\Before Click\Settings_Grey.png");
                    lblLeft_Settings.ForeColor = Color.FromArgb(110, 110, 110);
                    break;
                }
            }
        }

        private int _flagClick;
        private int _flagSlider;

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            MultipleSlider_Reverse(_flagSlider);
            if (lblNameLeft_Dashboard.ForeColor == Color.Black)
            {
                return;
            }
            else
            {
                ResetClick(_flagClick);
                pnlLeft_Dashboard.BackColor = Color.White;
                picbxLeft_Dashboard.Load(@"..\..\Resources\Dashboard\After Click\Dashboard_Black.png");
                lblNameLeft_Dashboard.ForeColor = Color.Black;
                _flagClick = 1;
            }

            pnlRight_Page1_Dashboard.Visible = true;
            pnlRight_ShowControls.Visible = false;
        }



        private void Slider_MasterEntry()
        {
            //pnlSlider_MasterEntry.Visible = true;            

            if (pnlLeft_Main_2.RowStyles[2].Height >= 200)
            {
                ReverseSliderMasterEntry.Enabled = true;
            }
            else
            {
                pnlSlider_MasterEntry.Size = new Size(134, 200);
                SliderMasterEntry.Enabled = true;
            }
        }

        private void MasterEntryButton_Click(object sender, EventArgs e)
        {
            MultipleSlider_Reverse(_flagSlider);
            Labels_MasterEntryCheck();
            if (lblLeft_MasterEntry.ForeColor == Color.Black)
            {
                Slider_MasterEntry();
                return;
            }
            else
            {
                ResetClick(_flagClick);
                pnlLeft_MasterEntry.BackColor = Color.White;
                picbxLeft_MasterEntry.Load(@"..\..\Resources\Dashboard\After Click\Master Entry_Black.png");
                lblLeft_MasterEntry.ForeColor = Color.Black;
                _flagClick = 2;
                Slider_MasterEntry();
            }
        }

        private void Slider_BookCirculation()
        {
            if (pnlLeft_Main_2.RowStyles[4].Height >= 88)
            {
                ReverseSliderBookCirculation.Enabled = true;
            }
            else
            {                
                pnlSlider_BookCirculation.Size = new Size(132, 88);
                SliderBookCirculation.Enabled = true;
            }
        }

        private void BookCirculationButton_Click(object sender, EventArgs e)
        {
            MultipleSlider_Reverse(_flagSlider);
            Labels_BookCirculationCheck();
            if (lblLeft_Books.ForeColor == Color.Black)
            {
                Slider_BookCirculation();
                return;
            }
            else
            {
                ResetClick(_flagClick);
                pnlLeft_BookCirculation.BackColor = Color.White;
                picbxLeft_Book.Load(@"..\..\Resources\Dashboard\After Click\Books_Black_3.png");
                lblLeft_Books.ForeColor = Color.Black;
                _flagClick = 3;
                Slider_BookCirculation();
            }
        }

        private void Slider_Reports()
        {
            if (pnlLeft_Main_2.RowStyles[6].Height >= 238)
            {
                ReverseSliderReports.Enabled = true;
            }
            else
            {
                pnlSlider_Reports.Size = new Size(132, 238);
                SliderReports.Enabled = true;
            }

        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            MultipleSlider_Reverse(_flagSlider);
            Labels_ReportsCheck();
            if (lblLeft_Reports.ForeColor == Color.Black)
            {
                Slider_Reports();
                return;
            }
            else
            {
                ResetClick(_flagClick);
                pnlLeft_Reports.BackColor = Color.White;
                picbxLeft_Reports.Load(@"..\..\Resources\Dashboard\After Click\Reports_Black.png");
                lblLeft_Reports.ForeColor = Color.Black;
                _flagClick = 4;
                Slider_Reports();
            }
        }

        private void Slider_Settings()
        {
            if (pnlSlider_GlobalSettings.Height >= 118)
            {
                ReverseSliderSettings.Enabled = true;
            }
            else
            {
                pnlSlider_GlobalSettings.Visible = true;
                //pnlSlider_GlobalSettings.Size = new Size(132, 118);
                pnlLeft_Main_2.RowStyles[8].Height = 118;
                SliderSettings.Enabled = true;
            }
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            MultipleSlider_Reverse(_flagSlider);
            Labels_SettingsCheck();
            if (lblLeft_Settings.ForeColor == Color.Black)
            {
                Slider_Settings();
                return;
            }
            else
            {
                ResetClick(_flagClick);
                pnlLeft_GlobalSettings.BackColor = Color.White;
                picbxLeft_Settings.Load(@"..\..\Resources\Dashboard\After Click\Settings_Black.png");
                lblLeft_Settings.ForeColor = Color.Black;
                _flagClick = 5;
                Slider_Settings();
            }
        }


        private void MasterEntryButton_HoverLeave(object sender, EventArgs e)
        {
            if (lblLeft_MasterEntry.ForeColor == Color.Black)
            {
                return;
            }

            if (pnlLeft_MasterEntry.BackColor == Color.WhiteSmoke)
            {
                pnlLeft_MasterEntry.BackColor = Color.White;
            }
            else if (pnlLeft_MasterEntry.BackColor == Color.White)
            {
                pnlLeft_MasterEntry.BackColor = Color.WhiteSmoke;
            }
        }

        private void BookCirculationButton_HoverLeave(object sender, EventArgs e)
        {
            if (lblLeft_Books.ForeColor == Color.Black)
            {
                return;
            }

            if (pnlLeft_BookCirculation.BackColor == Color.WhiteSmoke)
            {
                pnlLeft_BookCirculation.BackColor = Color.White;
            }
            else if (pnlLeft_BookCirculation.BackColor == Color.White)
            {
                pnlLeft_BookCirculation.BackColor = Color.WhiteSmoke;
            }
        }

        private void ReportsButton_HoverLeave(object sender, EventArgs e)
        {
            if (lblLeft_Reports.ForeColor == Color.Black)
            {
                return;
            }

            if (pnlLeft_Reports.BackColor == Color.WhiteSmoke)
            {
                pnlLeft_Reports.BackColor = Color.White;
            }
            else if (pnlLeft_Reports.BackColor == Color.White)
            {
                pnlLeft_Reports.BackColor = Color.WhiteSmoke;
            }
        }

        private void SettingsButton_HoverLeave(object sender, EventArgs e)
        {
            if (lblLeft_Settings.ForeColor == Color.Black)
            {
                return;
            }

            if (pnlLeft_GlobalSettings.BackColor == Color.WhiteSmoke)
            {
                pnlLeft_GlobalSettings.BackColor = Color.White;
            }
            else if (pnlLeft_GlobalSettings.BackColor == Color.White)
            {
                pnlLeft_GlobalSettings.BackColor = Color.WhiteSmoke;
            }
        }

        private void SliderMasterEntry_Tick(object sender, EventArgs e)
        {

            if (pnlLeft_Main_2.RowStyles[2].Height >= 200)
            {
                SliderMasterEntry.Enabled = false;
                pnlSlider_MasterEntry.Visible = true;
                _flagSlider = 1;
            }
            else
            {
                pnlLeft_Main_2.RowStyles[2].Height += 20;
            }

        }

        private void pnlSlider_MasterEntry_Paint(object sender, PaintEventArgs e)
        {
            OnPaint(e);
        }

        private void pnlLeft_Main_2_Paint(object sender, PaintEventArgs e)
        {
            OnPaint_LeftPanel(e);
        }

        private void ReverseSliderMasterEntry_Tick(object sender, EventArgs e)
        {
            if (pnlLeft_Main_2.RowStyles[2].Height <= 0)
            {
                ReverseSliderMasterEntry.Enabled = false;
                pnlSlider_MasterEntry.Visible = false;
                pnlSlider_MasterEntry.Size = new Size(132, 1);
            }
            else
            {
                pnlLeft_Main_2.RowStyles[2].Height -= 20;
            }
        }


        private void pnlSlider_MasterEntry_Resize_1(object sender, EventArgs e)
        {
            // Refresh();
        }

        private void SliderBookCirculation_Tick(object sender, EventArgs e)
        {
            if (pnlLeft_Main_2.RowStyles[4].Height >= 88)
            {
                SliderBookCirculation.Enabled = false;
                pnlSlider_BookCirculation.Visible = true;
                _flagSlider = 2;
            }
            else
            {
                pnlLeft_Main_2.RowStyles[4].Height += 10;
            }
        }

        private void ReverseSliderBookCirculation_Tick(object sender, EventArgs e)
        {
            if (pnlLeft_Main_2.RowStyles[4].Height <= 0)
            {
                ReverseSliderBookCirculation.Enabled = false;
                pnlSlider_BookCirculation.Visible = false;
                pnlSlider_BookCirculation.Size = new Size(132, 1);

            }
            else
            {
                pnlLeft_Main_2.RowStyles[4].Height -= 10;
            }
        }

        private void SliderReports_Tick(object sender, EventArgs e)
        {
            if (pnlLeft_Main_2.RowStyles[6].Height >= 238)
            {
                SliderReports.Enabled = false;
                pnlSlider_Reports.Visible = true;
                _flagSlider = 3;
            }
            else
            {
                pnlLeft_Main_2.RowStyles[6].Height += 20;
            }
        }

        private void ReverseSliderReports_Tick(object sender, EventArgs e)
        {
            if (pnlLeft_Main_2.RowStyles[6].Height <= 0)
            {
                ReverseSliderReports.Enabled = false;
                pnlSlider_Reports.Visible = false;
                pnlSlider_Reports.Size = new Size(132, 238);
            }
            else
            {
                pnlLeft_Main_2.RowStyles[6].Height -= 20;
            }
        }

        private void SliderSettings_Tick(object sender, EventArgs e)
        {
            if (pnlSlider_GlobalSettings.Height >= 118)
            {
                SliderSettings.Enabled = false;
                //pnlSlider_GlobalSettings.Visible = true;
                _flagSlider = 4;
            }
            else
            {
                //pnlLeft_Main_2.RowStyles[8].Height += 1;
                pnlSlider_GlobalSettings.Height += 10;
            }
        }

        private void ReverseSliderSettings_Tick(object sender, EventArgs e)
        {
            if (pnlSlider_GlobalSettings.Height <= 0)
            {
                ReverseSliderSettings.Enabled = false;
                pnlSlider_GlobalSettings.Visible = false;
                pnlSlider_GlobalSettings.Size = new Size(130, 1);
            }
            else
            {
                //pnlLeft_Main_2.RowStyles[8].Height -= 10;
                pnlSlider_GlobalSettings.Height -= 10;
            }
        }

        private void MultipleSlider_Reverse(int flagSlider)
        {

            switch (flagSlider)
            {
                case 1:
                {
                    ReverseSliderMasterEntry.Enabled = true;
                    _flagSlider = 0;
                    break;
                }
                case 2:
                {
                    ReverseSliderBookCirculation.Enabled = true;
                    _flagSlider = 0;
                    break;
                }
                case 3:
                {
                    ReverseSliderReports.Enabled = true;
                    _flagSlider = 0;
                    break;
                }
                case 4:
                {
                    ReverseSliderSettings.Enabled = true;
                    _flagSlider = 0;
                    break;
                }
            }
        }

        #region [MasterEntry Panel Slider]

        private void ProgressBar_MasterEntry(int value)
        {
            switch (value)
            {
                case 1:
                {
                    pgrbarSlider_MasterEntry.PerformStep();
                    pgrbarSlider_MasterEntry.Value = 16;
                    break;
                }
                case 2:
                {
                    pgrbarSlider_MasterEntry.PerformStep();
                    pgrbarSlider_MasterEntry.Value = 32;
                    break;
                }
                case 3:
                {
                    pgrbarSlider_MasterEntry.PerformStep();
                    pgrbarSlider_MasterEntry.Value = 48;
                    break;
                }
                case 4:
                {
                    pgrbarSlider_MasterEntry.PerformStep();
                    pgrbarSlider_MasterEntry.Value = 64;
                    break;
                }
                case 5:
                {
                    pgrbarSlider_MasterEntry.PerformStep();
                    pgrbarSlider_MasterEntry.Value = 80;
                    break;
                }
                case 6:
                {
                    pgrbarSlider_MasterEntry.PerformStep();
                    pgrbarSlider_MasterEntry.Value = 96;
                    break;
                }
            }
        }

        #endregion


        private void pnlLeft_Main_2_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            //ControlPaint.DrawBorder(e.Graphics, this.pnlLeft_Main_2.ClientRectangle, Color.FromArgb(202, 202, 202), ButtonBorderStyle.Solid);
        }

        private void tblpnlTopRight_Avatar_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            //e.Graphics.DrawLine(Pens.AliceBlue, e.CellBounds.Location, new Point(e.CellBounds.Right, e.CellBounds.Left));
            //if (e.Column == tblpnlTopRight_Avatar.Controls.Count -1)
            //{
            //    e.Graphics.DrawLine(Pens.LightGray, e.CellBounds.Location, new Point(e.CellBounds.Left, e.CellBounds.Bottom));
            //}
            //if (e.Column == 0)
            //    e.Graphics.DrawLine(
            //        new Pen(Color.FromArgb(62, 62, 62), 3),
            //        new Point(e.CellBounds.Left, e.CellBounds.Bottom),   
            //        new Point(e.CellBounds.Left, e.CellBounds.Top) 
            //    );

        }




        private void Labels_MasterEntryCheck()
        {
            for (int i = 0; i < _masterEntryLabels.Length; i++)
            {
                if (_masterEntryLabels[i].ForeColor == Color.FromArgb(49, 49, 49))
                {
                    _masterEntryLabels[i].ForeColor = Color.FromArgb(110, 110, 110);
                    _masterEntryLabels[i].Font = new Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
                }
            }
        }

        private void Labels_BookCirculationCheck()
        {
            for (int i = 0; i < _bookCirculationLabels.Length; i++)
            {
                if (_bookCirculationLabels[i].ForeColor == Color.FromArgb(49, 49, 49))
                {
                    _bookCirculationLabels[i].ForeColor = Color.FromArgb(110, 110, 110);
                    _bookCirculationLabels[i].Font = new Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
                }
            }
        }

        private void Labels_ReportsCheck()
        {
            for (int i = 0; i < _reporsLabels.Length; i++)
            {
                if (_reporsLabels[i].ForeColor == Color.FromArgb(49, 49, 49))
                {
                    _reporsLabels[i].ForeColor = Color.FromArgb(110, 110, 110);
                    _reporsLabels[i].Font = new Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
                }
            }
        }

        private void Labels_SettingsCheck()
        {
            for (int i = 0; i < _settingsLabels.Length; i++)
            {
                if (_settingsLabels[i].ForeColor == Color.FromArgb(49, 49, 49))
                {
                    _settingsLabels[i].ForeColor = Color.FromArgb(110, 110, 110);
                    _settingsLabels[i].Font = new Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
                }
            }
        }

    private void lblSliderMembers_MasterEntry_Click(object sender, EventArgs e)
        {
            Labels_MasterEntryCheck();
            //ProgressBar_MasterEntry(2);
            lblSliderMembers_MasterEntry.ForeColor = Color.FromArgb(49, 49, 49);
            lblSliderMembers_MasterEntry.Font = new Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);

            // Control Should Shown on Right Side

            CloseAllControls();
            _addMember.Visible = true;
            //Std.CloseConnection += new EventHandler(CloseTheControl);
            _addMember.Dock = DockStyle.Fill;
            this.pnlRight_ShowControls.Controls.Add(_addMember);


        }

        private void lblSliderBooks_MasterEntry_Click(object sender, EventArgs e)
        {
            Labels_MasterEntryCheck();
            //ProgressBar_MasterEntry(3);
            lblSliderBooks_MasterEntry.ForeColor = Color.FromArgb(49, 49, 49);
            lblSliderBooks_MasterEntry.Font = new Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);

            // Control Should Shown on Right Side

            CloseAllControls();
            _addBooks.Dock = DockStyle.Fill;
            //BK.CloseConnection += new EventHandler(CloseTheControl);
            this.pnlRight_ShowControls.Controls.Add(_addBooks);
        }

        private void lblSliderSuppliers_MasterEntry_Click(object sender, EventArgs e)
        {
            Labels_MasterEntryCheck();
            lblSliderSuppliers_MasterEntry.ForeColor = Color.FromArgb(49, 49, 49);
            lblSliderSuppliers_MasterEntry.Font = new Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);

            // Control Should Shown on Right Side

            CloseAllControls();
            _supplier.Dock = DockStyle.Fill;
            //BK.CloseConnection += new EventHandler(CloseTheControl);
            this.pnlRight_ShowControls.Controls.Add(_supplier);
        }

        private void lblSliderPublishers_MasterEntry_Click(object sender, EventArgs e)
        {
            Labels_MasterEntryCheck();
            lblSliderPublishers_MasterEntry.ForeColor = Color.FromArgb(49, 49, 49);
            lblSliderPublishers_MasterEntry.Font = new Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);

            // Control Should Shown on Right Side

            CloseAllControls();
            _publisher.Dock = DockStyle.Fill;
            //BK.CloseConnection += new EventHandler(CloseTheControl);
            this.pnlRight_ShowControls.Controls.Add(_publisher);            
        }

        private void lblSliderSubject_MasterEntry_Click(object sender, EventArgs e)
        {
            Labels_MasterEntryCheck();
            lblSliderSubject_MasterEntry.ForeColor = Color.FromArgb(49, 49, 49);
            lblSliderSubject_MasterEntry.Font = new Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);

            // Control Should Shown on Right Side

            CloseAllControls();
            _addSubject.Dock = DockStyle.Fill;
            //BK.CloseConnection += new EventHandler(CloseTheControl);
            this.pnlRight_ShowControls.Controls.Add(_addSubject);   
        }

        private void lblSliderCategory_MasterEntry_Click(object sender, EventArgs e)
        {
            Labels_MasterEntryCheck();
            lblSliderCategory_MasterEntry.ForeColor = Color.FromArgb(49, 49, 49);
            lblSliderCategory_MasterEntry.Font = new Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);

            // Control Should Shown on Right Side

            CloseAllControls();
            _addCategory.Dock = DockStyle.Fill;
            //BK.CloseConnection += new EventHandler(CloseTheControl);
            this.pnlRight_ShowControls.Controls.Add(_addCategory);  
        }

        private void lblSliderReturnBook_BookCirculation_Click(object sender, EventArgs e)
        {
            Labels_BookCirculationCheck();
            lblSliderReturnBook_BookCirculation.ForeColor = Color.FromArgb(49, 49, 49);
            lblSliderReturnBook_BookCirculation.Font = new Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);


            // Control Should Shown on Right Side

            CloseAllControls();
            _returnBooks.Dock = DockStyle.Fill;
            //BK.CloseConnection += new EventHandler(CloseTheControl);
            this.pnlRight_ShowControls.Controls.Add(_returnBooks);  
        }

        private void lblSliderIssueBook_BookCirculation_Click(object sender, EventArgs e)
        {
            
            Labels_BookCirculationCheck();
            lblSliderIssueBook_BookCirculation.ForeColor = Color.FromArgb(49, 49, 49);
            lblSliderIssueBook_BookCirculation.Font = new Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);

            // Control Should Shown on Right Side

            CloseAllControls();
            _bookIssuance.Dock = DockStyle.Fill;
            //BK.CloseConnection += new EventHandler(CloseTheControl);
            this.pnlRight_ShowControls.Controls.Add(_bookIssuance);  
        }

        private void lblSliderFinePayments_Reports_Click(object sender, EventArgs e)
        {
            Labels_ReportsCheck();
            lblSliderFinePayments_Reports.ForeColor = Color.FromArgb(49, 49, 49);
            lblSliderFinePayments_Reports.Font = new Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);

            // Control Should Shown on Right Side

            CloseAllControls();
            _finePayments.Dock = DockStyle.Fill;
            //BK.CloseConnection += new EventHandler(CloseTheControl);
            this.pnlRight_ShowControls.Controls.Add(_finePayments);  

        }

        private void lblSliderMembers_Reports_Click(object sender, EventArgs e)
        {
            Labels_ReportsCheck();
            lblSliderMembers_Reports.ForeColor = Color.FromArgb(49, 49, 49);
            lblSliderMembers_Reports.Font = new Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);

            // Control Should Shown on Right Side

            CloseAllControls();
            _memberDetails.Dock = DockStyle.Fill;
            //BK.CloseConnection += new EventHandler(CloseTheControl);
            this.pnlRight_ShowControls.Controls.Add(_memberDetails);  
        }

        private void lblSliderBooks_Reports_Click(object sender, EventArgs e)
        {
            Labels_ReportsCheck();
            lblSliderBooks_Reports.ForeColor = Color.FromArgb(49, 49, 49);
            lblSliderBooks_Reports.Font = new Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);

            // Control Should Shown on Right Side

            CloseAllControls();
            _bookDetails.Dock = DockStyle.Fill;
            //BK.CloseConnection += new EventHandler(CloseTheControl);
            this.pnlRight_ShowControls.Controls.Add(_bookDetails); 
        }

        private void lblSliderSuppliers_Reports_Click(object sender, EventArgs e)
        {
            Labels_ReportsCheck();

            lblSliderSuppliers_Reports.ForeColor = Color.FromArgb(49, 49, 49);
            lblSliderSuppliers_Reports.Font = new Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);

            // Control Should Shown on Right Side

            CloseAllControls();
            _suppliersDetail.Dock = DockStyle.Fill;
            //BK.CloseConnection += new EventHandler(CloseTheControl);
            this.pnlRight_ShowControls.Controls.Add(_suppliersDetail); 
        }

        private void lblSliderPublishers_Reports_Click(object sender, EventArgs e)
        {
            Labels_ReportsCheck();            
            lblSliderPublishers_Reports.ForeColor = Color.FromArgb(49, 49, 49);
            lblSliderPublishers_Reports.Font = new Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);

            // Control Should Shown on Right Side

            CloseAllControls();
            _publishersDetail.Dock = DockStyle.Fill;
            //BK.CloseConnection += new EventHandler(CloseTheControl);
            this.pnlRight_ShowControls.Controls.Add(_publishersDetail); 
        }

        private void lblSliderReturnedBooks_Reports_Click(object sender, EventArgs e)
        {
            Labels_ReportsCheck();
            lblSliderReturnedBooks_Reports.ForeColor = Color.FromArgb(49, 49, 49);
            lblSliderReturnedBooks_Reports.Font = new Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);

            // Control Should Shown on Right Side

            CloseAllControls();
            _returnBooksDetail.Dock = DockStyle.Fill;
            //BK.CloseConnection += new EventHandler(CloseTheControl);
            this.pnlRight_ShowControls.Controls.Add(_returnBooksDetail); 
        }

        private void lblSliderIssuedBooks_Reports_Click(object sender, EventArgs e)
        {
            Labels_ReportsCheck();
            lblSliderIssuedBooks_Reports.ForeColor = Color.FromArgb(49, 49, 49);
            lblSliderIssuedBooks_Reports.Font = new Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);

            // Control Should Shown on Right Side

            CloseAllControls();
            _issuedBooksDetail.Dock = DockStyle.Fill;
            //BK.CloseConnection += new EventHandler(CloseTheControl);
            this.pnlRight_ShowControls.Controls.Add(_issuedBooksDetail); 
        }

        private void lblSliderSettings_GlobalSettings_Click(object sender, EventArgs e)
        {
            Labels_SettingsCheck();
            lblSliderSettings_GlobalSettings.ForeColor = Color.FromArgb(49, 49, 49);
            lblSliderSettings_GlobalSettings.Font = new Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);

            // Control Should Shown on Right Side

            CloseAllControls();
            _masterSettings.Dock = DockStyle.Fill;
            //BK.CloseConnection += new EventHandler(CloseTheControl);
            this.pnlRight_ShowControls.Controls.Add(_masterSettings); 
        }

        private void lblSliderLibrarian_GlobalSettings_Click(object sender, EventArgs e)
        {
            Labels_SettingsCheck();
            lblSliderLibrarian_GlobalSettings.ForeColor = Color.FromArgb(49, 49, 49);
            lblSliderLibrarian_GlobalSettings.Font = new Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);

            // Control Should Shown on Right Side

            CloseAllControls();
            _librarianDetails.Dock = DockStyle.Fill;
            //BK.CloseConnection += new EventHandler(CloseTheControl);
            this.pnlRight_ShowControls.Controls.Add(_librarianDetails);                 
        }

        private void lblSliderAddLibrarian_GlobalSettings_Click(object sender, EventArgs e)
        {
            Labels_SettingsCheck();
            lblSliderAddLibrarian_GlobalSettings.ForeColor = Color.FromArgb(49, 49, 49);
            lblSliderAddLibrarian_GlobalSettings.Font = new Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);

            // Control Should Shown on Right Side

            CloseAllControls();
            _manageLibrarians.Dock = DockStyle.Fill;
            //BK.CloseConnection += new EventHandler(CloseTheControl);
            this.pnlRight_ShowControls.Controls.Add(_manageLibrarians); 
        }

        private void picbxTopRight_Arrow_Click(object sender, EventArgs e)
        {
            ctxmnuLogout.Show(picbxLogo_Top, picbxLogo_Top.PointToClient(Cursor.Position));
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            // Control Should Shown on Right Side

            CloseAllControls();
            _masterSettings.Dock = DockStyle.Fill;
            //BK.CloseConnection += new EventHandler(CloseTheControl);
            this.pnlRight_ShowControls.Controls.Add(_masterSettings);
        }

        private void pnlMiscellaneous_TotalFine_Load(object sender, EventArgs e)
        {
            var sql = "SELECT CONCAT('Rs',' ',SUM(Fn_PaidAmount)) FROM FINES";
            cmd = new SqlCommand(sql, Lib.Database_Connection.GlobalConnection());
            var ans = cmd.ExecuteScalar().ToString();
            pnlMiscellaneous_TotalFine.NumberLabel = ans;
        }

        private void pnlMiscellaneous_Publishers_Load(object sender, EventArgs e)
        {
            var sql = "SELECT COUNT(1) FROM PUBLISHER";
            cmd = new SqlCommand(sql, Lib.Database_Connection.GlobalConnection());
            var ans = cmd.ExecuteScalar().ToString();
            pnlMiscellaneous_Publishers.NumberLabel = ans;
        }

        private void pnlMiscellaneous_Category_Load(object sender, EventArgs e)
        {
            var sql = "SELECT COUNT(1) FROM CATEGORY";
            cmd = new SqlCommand(sql, Lib.Database_Connection.GlobalConnection());
            var ans = cmd.ExecuteScalar().ToString();
            pnlMiscellaneous_Category.NumberLabel = ans;
        }

        private void pnlKeyInfo_Members_Load(object sender, EventArgs e)
        {
            var sql = "SELECT COUNT(1) FROM MEMBER WHERE Memb_Status = 1";
            cmd = new SqlCommand(sql, Lib.Database_Connection.GlobalConnection());
            var ans = cmd.ExecuteScalar().ToString();
            pnlKeyInfo_Members.NumberLabel = ans;
        }

        private void pnlBookCiculation_AllIssued_Load(object sender, EventArgs e)
        {
            var sql = "SELECT * FROM BookIssuence WHERE BKISS_Status = 0";
            cmd = new SqlCommand(sql, Lib.Database_Connection.GlobalConnection());
            var ans = cmd.ExecuteScalar().ToString();
            pnlBookCiculation_AllIssued.NumberLabel = ans;
        }

        private void pnlKeyInfo_AllBooks_Load(object sender, EventArgs e)
        {
            var sql = "SELECT COUNT(1) FROM BOOK";
            cmd = new SqlCommand(sql, Lib.Database_Connection.GlobalConnection());
            var ans = cmd.ExecuteScalar().ToString();
            pnlKeyInfo_AllBooks.NumberLabel = ans;
        }


        private void pnlBookCiculation_Returned_Load(object sender, EventArgs e)
        {
            var sql = "SELECT COUNT(1) FROM ReturnIssueBooks";
            cmd = new SqlCommand(sql, Lib.Database_Connection.GlobalConnection());
            var ans = cmd.ExecuteScalar().ToString();
            pnlBookCiculation_Returned.NumberLabel = ans;
        }

        private void pnlKeyInfo_Available_Load(object sender, EventArgs e)
        {
            var sql = "SELECT COUNT(1) FROM BOOK WHERE Bk_Status = 1";
            cmd = new SqlCommand(sql, Lib.Database_Connection.GlobalConnection());
            var ans = cmd.ExecuteScalar().ToString();
            pnlKeyInfo_Available.NumberLabel = ans;
        }

        private void pnlBookCiculation_BooksDue_Load(object sender, EventArgs e)
        {
            var sql = "SELECT COUNT(1) FROM BOOKISSUENCE WHERE BKISS_Status = 1";
            cmd = new SqlCommand(sql, Lib.Database_Connection.GlobalConnection());
            var ans = cmd.ExecuteScalar().ToString();
            pnlBookCiculation_BooksDue.NumberLabel = ans;
        }

        private void pnlMiscellaneous_Suppliers_Load(object sender, EventArgs e)
        {
            var sql = "SELECT COUNT(1) FROM SUPPLIER";
            cmd = new SqlCommand(sql, Lib.Database_Connection.GlobalConnection());
            var ans = cmd.ExecuteScalar().ToString();
            pnlMiscellaneous_Suppliers.NumberLabel = ans;
        }
    }
}
