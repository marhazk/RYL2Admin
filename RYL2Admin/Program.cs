using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RYL2Admin
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static Main Gamed;
        public static Msg msg;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Gamed = new Main();
            msg = new Msg();
            Application.Run(Gamed);
        }
    }
}
