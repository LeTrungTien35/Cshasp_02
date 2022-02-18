using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _54kmt_gui
{
    static class Program
    {
        public static frmMain fMain;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            fMain = new frmMain();
            Application.Run(fMain);
        }
    }
}
