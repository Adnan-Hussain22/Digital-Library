using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Digital Library.Splash_Screen;
using Digital Library.Login;

namespace Digital Library
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmUserReg());
            //Application.Run(new FrmUserOperations());
            // Application.Run(new FrmBookEntry());
            //Application.Run(new FrmBookIssueStudent());
            //Application.Run(new FrmBookDetails());
            //Application.Run(new FrmUserDetails());
            //Application.Run(new FrmBookOperations());
            //Application.Run(new Login_Win.FrmLogin());
            //Application.Run(new FrmBook1Entry());
            //Application.Run(new FrmCategory());
            //Application.Run(new FrmAddMember());
            //Application.Run(new FrmBook1Details());
            //Application.Run(new FrmLibDashboard());

            Application.Run(new SplashScreen());
            Application.Run(new Main_Login());
            //Application.Run(new Dashboard());

            // Application.Run(new AddBooks());
            //Application.Run(new Dummy1());
            // Application.Run(new Dummy2());
            //Application.Run(new Dummy_Tree_View());
            //Application.Run(new DUMMY.Supplier());
            //Application.Run(new DUMMY.Publisher());
            //Application.Run(new Dummy_1());
        }
    }
}
