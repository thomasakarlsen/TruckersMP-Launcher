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
            Application.Run(new MyContext());
        }
    }
    public class MyContext : ApplicationContext
    {
        public MyContext()
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
                checkForUpdates();
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

        private void checkForUpdates()
        {
            JObject latestver = new JObject() ;
            using (WebClient client = new WebClient())
            {
                try
                {
                    latestver = JObject.Parse(client.DownloadString("http://api.thomasakarlsen.com/truckersmplauncher/version/latest"));
                }
                catch (WebException)
                {
                    Console.WriteLine("Unable to connect to launcher API. Cannot check for new version");
                    Main main = new Main();
                    main.Show();
                    return;
                }
            }
            
            Console.WriteLine(latestver);
            Console.WriteLine(Properties.Settings.Default.LauncherVersion);
            string gotVer = (string)latestver["Version"];
            string localVer = Properties.Settings.Default.LauncherVersion;

            if (string.Compare(gotVer, localVer, true) > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Current version is: " + Properties.Settings.Default.LauncherVersion + "\nLatest version is: " + (string)latestver["Version"] + "\n\nThere is an update available!\nDo you want to update now?", "TruckersMP Launcher", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Updater updater = new Updater();
                    updater.Show();
                    updater.Update((string)latestver["Location"]);
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

    }
}
