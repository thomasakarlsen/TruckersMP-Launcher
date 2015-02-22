using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ets2mplauncher
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
            Application.Run(new MyContext());
        }
    }
    public class MyContext : ApplicationContext
    {
        public MyContext()
        {
            Application.Idle += new EventHandler(Application_Idle);
            launcher launcher = new launcher();
            launcher.Launch();
        }

        void Application_Idle(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 0)
                Application.Exit();
        }

    }
}
