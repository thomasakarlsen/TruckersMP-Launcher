using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Reflection;

namespace truckersmplauncher
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
            Application.Run(new TruckersMPLauncher());
        }
    }
    public class TruckersMPLauncher : ApplicationContext
    {
        public TruckersMPLauncher()
        {
            Application.Idle += new EventHandler(Application_Idle);
            AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
            {
                string resourceName = new AssemblyName(args.Name).Name + ".dll";
                string resource = Array.Find(this.GetType().Assembly.GetManifestResourceNames(), element => element.EndsWith(resourceName));

                using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource))
                {
                    Byte[] assemblyData = new Byte[stream.Length];
                    stream.Read(assemblyData, 0, assemblyData.Length);
                    return Assembly.Load(assemblyData);
                }
            };

            //Check if file from update exsist
            if (System.IO.File.Exists(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName + ".old"))
            {
                System.IO.File.Delete(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName + ".old");
            }

            if (System.IO.File.Exists(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName + ".new"))
            {
                System.IO.File.Delete(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName + ".new");
            }

            //Autoupdate if enabled
            if (Properties.Settings.Default.AutoUpdateLauncher == true)
            {
                string latest = Launcher.latestVersion();
                string local = Properties.Settings.Default.LauncherVersion;

                if (latest == "0")
                {
                    Main main = new Main();
                    main.Show();
                    return;
                }

                if (string.Compare(latest, local, true) > 0)
                {
                    Launcher.update();
                }
                else
                {
                    Main main = new Main();
                    main.Show();
                }
            }
            else
            {
                Main main = new Main();
                main.Show();
            }
            
            
        }

        void Application_Idle(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 0)
                Application.Exit();
        }
    }
}
