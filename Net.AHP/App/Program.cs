#define NO_LOGIN
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AHP_App.Form;

namespace AHP_App
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
#if (NO_LOGIN)
            Application.Run(new FrmMain());
#else
                  Application.Run(new FrmLogin());
#endif

        }
    }
}
