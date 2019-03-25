using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital Library.Settings
{
    public partial class Master_Settings : UserControl
    {
        public Master_Settings()
        {
            InitializeComponent();
        }
        #region [ OBJECTS AND VARIABLES ]

        string membershipOption = Properties.Settings.Default.MembershipOption, fineOption = Properties.Settings.Default.FineOption,
        issueOption = Properties.Settings.Default.IssueOption;

        long shelfCapacity = Properties.Settings.Default.ShelfCapacity;

        double fineAmout = Properties.Settings.Default.FineAmount, fineOptionCount = Properties.Settings.Default.FineOptionCount,
        MembershipOptionCount = Properties.Settings.Default.FineOptionCount;

        bool btn_fine = Properties.Settings.Default.switchFine, btn_issue = Properties.Settings.Default.switchIssue,
        btn_membership = Properties.Settings.Default.switchMembership, btn_shelf = Properties.Settings.Default.switchShelf;

        int issueAmount = Properties.Settings.Default.IssueAmount, IssueOptionCount = Properties.Settings.Default.IssueOptionCount;
        #endregion

        #region [ PROPERTIES ]

        #endregion

        #region [ METHODS ]

        private bool Filter()
        {
            var isValidated = true;
            if (switch_fine.Value && cmb_fineoption.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select the fine option first", "Master Settings " + Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmb_fineoption.Focus();
                isValidated = false;
            }
            else if (switch_fine.Value && textbox_fineamount.Text == "")
            {
                MessageBox.Show("Please enter fine amount first", "Master Settings " + Global.CaptionLib, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textbox_fineamount.Focus();
                isValidated = false;
            }
            else if (switch_fine.Value && !(Global.IsAllNumbers(textbox_fineamount.Text)))
            {
                MessageBox.Show("Please enter a valid fine amount", Global.CaptionLib + " Master Settings ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textbox_fineamount.Focus();
                isValidated = false;
            }
            else if (switch_issue.Value && cmb_issueoption.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select the issue option first", Global.CaptionLib + " Master Settings ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmb_issueoption.Focus();
                isValidated = false;
            }

            else if (switch_issue.Value && textbox_issueamount.Text == "")
            {
                MessageBox.Show("Please enter the issue amount first", Global.CaptionLib + " Master Settings ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textbox_issueamount.Focus();
                isValidated = false;
            }
            else if (switch_issue.Value && !(Global.IsAllNumbers(textbox_issueamount.Text)))
            {
                MessageBox.Show("Please enter a valid issue amount", Global.CaptionLib + " Master Settings ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textbox_issueamount.Focus();
                isValidated = false;
            }
            else if (switch_membership.Value && cmb_membershipoption.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select the membership option first", Global.CaptionLib + " Master Settings ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmb_membershipoption.Focus();
                isValidated = false;
            }
            else if (switch_shelf.Value && textbox_shelfcapacity.Text == "")
            {
                MessageBox.Show("Please enter shelf capacity amount first", Global.CaptionLib + " Master Settings ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textbox_shelfcapacity.Focus();
                isValidated = false;
            }
            else if (switch_shelf.Value && !(Global.IsAllNumbers(textbox_shelfcapacity.Text)))
            {
                MessageBox.Show("Please enter a valid shelf capacity amount", Global.CaptionLib + " Master Settings ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textbox_shelfcapacity.Focus();
                isValidated = false;
            }
            return isValidated;
        }

        private void ResetSettings()
        { }

        private void CollectData()
        {
            Properties.Settings.Default["switchFine"] = switch_fine.Value;
            Properties.Settings.Default["switchIssue"] = switch_issue.Value;
            Properties.Settings.Default["switchMembership"] = switch_membership.Value;
            Properties.Settings.Default["switchShelf"] = switch_shelf.Value;

            if (switch_fine.Value)
            {
                if (textbox_fineamount.Text != "")
                {
                    if (Global.IsAllNumbers(textbox_fineamount.Text))
                    {
                        Properties.Settings.Default["FineAmount"] = Convert.ToDouble(textbox_fineamount.Text);
                    }
                }
                if (cmb_fineoption.SelectedIndex > 0)
                {
                    Properties.Settings.Default["FineOption"] = cmb_fineoption.SelectedItem.ToString();
                    Properties.Settings.Default["FineOptionCount"] = Convert.ToDouble(Fineupdown_countDays_Weeks_Months.Value);
                }
            }
            else
            {
                Properties.Settings.Default["FineAmount"] = 0;
                Properties.Settings.Default["FineOption"] = "Days";
                Properties.Settings.Default["FineOptionCount"] = 1;
            }

            if (switch_issue.Value)
            {
                if (cmb_issueoption.SelectedIndex > 0)
                {
                    Properties.Settings.Default["IssueOption"] = cmb_issueoption.SelectedItem.ToString();
                    Properties.Settings.Default["IssueOptionCount"] = Convert.ToInt32(Issueupdown_count_Days_Weeks_Months.Value);
                }
                if (textbox_issueamount.Text != "")
                {
                    if (Global.IsAllNumbers(textbox_issueamount.Text))
                    {
                        Properties.Settings.Default["IssueAmount"] = Convert.ToInt32(textbox_issueamount.Text);
                    }
                }
            }
            else
            {
                Properties.Settings.Default["IssueAmount"] = 5;
                Properties.Settings.Default["IssueOption"] = "";
                Properties.Settings.Default["IssueOptionCount"] = 1;
            }

            if (switch_membership.Value)
            {
                if (cmb_membershipoption.SelectedIndex > 0)
                {
                    Properties.Settings.Default["MembershipOption"] = cmb_membershipoption.SelectedItem.ToString();
                    Properties.Settings.Default["MembershipOptionCount"] = Convert.ToDouble(Mbrshipupdown_count_Days_Weeks_Months.Value);
                }
            }
            else
            {
                Properties.Settings.Default["MembershipOption"] = "";
                Properties.Settings.Default["MembershipOptionCount"] = Convert.ToDouble(1);
            }

            //if (switch_shelf.Value)
            //{
            //    if (textbox_shelfcapacity.Text != "")
            //    {
            //        if (Global.IsAllNumbers(textbox_shelfcapacity.Text))
            //        {
            //            Properties.Settings.Default["ShelfCapacity"] = Convert.ToInt64(textbox_shelfcapacity.Text);
            //        }
            //    }
            //}
            //else
            //{
            //    Properties.Settings.Default["ShelfCapacity"] = Convert.ToInt64(0);
            //}
        }

        #endregion

        #region [ EVENTS AND DELEGATES ]

        public event EventHandler CloseConnection;

        private void OnCloseConnection(EventArgs e)
        {
            var eh = CloseConnection;

            if (eh != null)
                eh(this, e);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            CollectData();
            if (Filter())
            {
                DialogResult dr = MessageBox.Show("Do you want to save the settings, saving the settings will affect the modules in the system ?", Global.CaptionLib + " Master Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Properties.Settings.Default.Save();
                }
                else return;
            }
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            OnCloseConnection(null);
        }

        private void cmb_membershipoption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_membershipoption.SelectedIndex > 0)
            {
                Mbrshiplbl_updown_countDays_Weeks_Months.Text = cmb_membershipoption.SelectedItem.ToString();
            }
        }

        private void cmb_issueoption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_issueoption.SelectedIndex > 0)
            {
                Issuelbl_updown_countDays_Weeks_Months.Text = cmb_issueoption.SelectedItem.ToString();
            }
        }

        private void cmb_fineoption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_fineoption.SelectedIndex > 0)
            {
                Finelbl_updown_countDays_Weeks_Months.Text = cmb_fineoption.SelectedItem.ToString();
            }
        }

        private void Master_Settings_Load(object sender, EventArgs e)
        {
            switch_fine.Value = btn_fine;
            switch_issue.Value = btn_issue;
            switch_membership.Value = btn_membership;
            switch_shelf.Value = btn_shelf;
            if (switch_fine.Value == false)
            {
                cmb_fineoption.Enabled = false;
                textbox_fineamount.Enabled = false;
                Fineupdown_countDays_Weeks_Months.Enabled = false;
                cmb_fineoption.SelectedItem = null;
                textbox_fineamount.Text = "";
                lbl_fine_onoff.Text = "Off";
            }
            else
            {
                cmb_fineoption.Enabled = true;
                textbox_fineamount.Enabled = true;
                Fineupdown_countDays_Weeks_Months.Enabled = true;
                cmb_fineoption.SelectedItem = fineOption;
                Fineupdown_countDays_Weeks_Months.Value = Convert.ToDecimal(fineOptionCount);
                textbox_fineamount.Text = fineAmout.ToString();
                lbl_fine_onoff.Text = "On";
            }

            if (switch_issue.Value == false)
            {
                cmb_issueoption.Enabled = false;
                Issueupdown_count_Days_Weeks_Months.Enabled = false;
                Issueupdown_count_Days_Weeks_Months.Value = 1;
                cmb_issueoption.SelectedItem = null;
                textbox_issueamount.Text = "";
                lbl_issue_manualorauto.Text = "Manual";
                textbox_issueamount.Enabled = false;
            }
            else
            {
                cmb_issueoption.Enabled = true;
                Issueupdown_count_Days_Weeks_Months.Enabled = true;
                cmb_issueoption.SelectedItem = issueOption;
                Issueupdown_count_Days_Weeks_Months.Value = IssueOptionCount;
                textbox_issueamount.Enabled = true;
                textbox_issueamount.Text = issueAmount.ToString();
                lbl_issue_manualorauto.Text = "Auto";
            }

            if (switch_membership.Value == false)
            {
                cmb_membershipoption.Enabled = false;
                Mbrshipupdown_count_Days_Weeks_Months.Enabled = false;
                Mbrshipupdown_count_Days_Weeks_Months.Value = 1;
                cmb_membershipoption.SelectedItem = null;
                lbl_membership_manualorauto.Text = "Manual";
            }
            else
            {
                cmb_membershipoption.Enabled = true;
                Mbrshipupdown_count_Days_Weeks_Months.Enabled = true;
                cmb_membershipoption.SelectedItem = membershipOption;
                Mbrshipupdown_count_Days_Weeks_Months.Value = Convert.ToDecimal(MembershipOptionCount);
                lbl_membership_manualorauto.Text = "Auto";
            }

            //if (switch_shelf.Value == false)
            //{
            //    textbox_shelfcapacity.Enabled = false;
            //    textbox_shelfcapacity.Text = "";
            //    lbl_self_manualordefault.Text = "Default";
            //}
            //else
            //{
            //    textbox_shelfcapacity.Enabled = true;
            //    textbox_shelfcapacity.Text = shelfCapacity.ToString();
            //    lbl_self_manualordefault.Text = "Manual";
            //}
        }

        private void switch_fine_OnValueChange(object sender, EventArgs e)
        {
            if (switch_fine.Value == true)
            {
                cmb_fineoption.Enabled = true;
                textbox_fineamount.Enabled = true;
                Fineupdown_countDays_Weeks_Months.Enabled = true;
                Fineupdown_countDays_Weeks_Months.Enabled = true;
                Fineupdown_countDays_Weeks_Months.Value = Convert.ToDecimal(fineOptionCount);
                cmb_fineoption.SelectedItem = fineOption;
                textbox_fineamount.Text = fineAmout.ToString();
                lbl_fine_onoff.Text = "On";

            }
            else
            {
                cmb_fineoption.Enabled = false;
                textbox_fineamount.Enabled = false;
                Fineupdown_countDays_Weeks_Months.Enabled = false;
                Fineupdown_countDays_Weeks_Months.Value = 1;
                cmb_fineoption.SelectedItem = null;
                textbox_fineamount.Text = "";
                lbl_fine_onoff.Text = "Off";
            }
        }

        private void switch_issue_OnValueChange(object sender, EventArgs e)
        {
            if (switch_issue.Value == true)
            {
                cmb_issueoption.Enabled = true;
                Issueupdown_count_Days_Weeks_Months.Enabled = true;
                Issueupdown_count_Days_Weeks_Months.Value = IssueOptionCount;
                cmb_issueoption.SelectedItem = issueOption;
                textbox_issueamount.Text = issueAmount.ToString();
                lbl_issue_manualorauto.Text = "Auto";
            }
            else
            {
                cmb_issueoption.Enabled = false;
                Issueupdown_count_Days_Weeks_Months.Enabled = false;
                Issueupdown_count_Days_Weeks_Months.Value = 1;
                cmb_issueoption.SelectedItem = null;
                lbl_issue_manualorauto.Text = "Manual";
                textbox_issueamount.Text = "";
            }
        }
        private void switch_membership_OnValueChange(object sender, EventArgs e)
        {
            if (switch_membership.Value == true)
            {
                cmb_membershipoption.Enabled = true;
                Mbrshipupdown_count_Days_Weeks_Months.Enabled = true;
                Mbrshipupdown_count_Days_Weeks_Months.Value = Convert.ToDecimal(MembershipOptionCount);
                cmb_membershipoption.SelectedItem = membershipOption;
                lbl_membership_manualorauto.Text = "Auto";
            }
            else
            {
                cmb_membershipoption.Enabled = false;
                Mbrshipupdown_count_Days_Weeks_Months.Enabled = false;
                Mbrshipupdown_count_Days_Weeks_Months.Value = 1;
                cmb_membershipoption.SelectedItem = null;
                lbl_membership_manualorauto.Text = "Manual";
            }
        }

        //private void switch_shelf_OnValueChange(object sender, EventArgs e)
        //{
        //    if (switch_shelf.Value == true)
        //    {
        //        textbox_shelfcapacity.Enabled = true;
        //        textbox_shelfcapacity.Text = shelfCapacity.ToString();
        //        lbl_self_manualordefault.Text = "Manual";
        //    }
        //    else
        //    {
        //        textbox_shelfcapacity.Enabled = false;
        //        textbox_shelfcapacity.Text = "";
        //        lbl_self_manualordefault.Text = "Auto";
        //    }
        //}

        #endregion

    }
}
