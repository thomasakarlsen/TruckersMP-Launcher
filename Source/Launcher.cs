using System;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace truckersmplauncher
{
    class Launcher
    {
        public static String TruckersMPLocation = "";
        public static String ETS2Location = "";
        public static String ATSLocation = "";
        public static Boolean ETS2Installed = false;
        public static Boolean ATSInstalled = false;
        public static Boolean TFMRadioPlaying = false;
        public static Boolean working = false;

        public static truckersfm tfm = new truckersfm();

        public static void initialize(CProgressBar TruckersMPUpdateProgress, Label TruckersMPUpdateProgressLabel) {

            if (Properties.Settings.Default.StartSteam)
            {
                if (Process.GetProcessesByName("Steam").Length == 0)
                {
                    Microsoft.Win32.RegistryKey steamKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Valve\\Steam");
                    if (steamKey != null)
                    {
                        string SteamExe = (string)steamKey.GetValue("SteamExe");
                        if (SteamExe != null)
                        {
                            Process.Start(SteamExe);
                        }
                    }
                }
            }

            Launcher.ETS2Installed = false;
            Launcher.ATSInstalled = false;
            Microsoft.Win32.RegistryKey readKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\TruckersMP");
            if (readKey != null)
            {
                Launcher.TruckersMPLocation = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\TruckersMP";
                Launcher.ETS2Location = (string)readKey.GetValue("InstallLocationETS2");
                Launcher.ATSLocation = (string)readKey.GetValue("InstallLocationATS");

                if (System.IO.Directory.Exists(Launcher.ETS2Location))
                {
                    Launcher.ETS2Installed = true;
                }

                if (System.IO.Directory.Exists(Launcher.ATSLocation))
                {
                    Launcher.ATSInstalled = true;
                }

                if (!System.IO.Directory.Exists(Launcher.TruckersMPLocation))
                {
                    DialogResult dialogResult = MessageBox.Show("Unable to locate TruckersMP.\n\nDo you want to install it now?\n(required)", "TruckersMP Launcher", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        System.Threading.ThreadPool.QueueUserWorkItem(delegate
                        {
                            TruckersMP.install(TruckersMPUpdateProgress, TruckersMPUpdateProgressLabel);
                        });
                    }
                    else
                    {
                        Environment.Exit(1);
                    }
                }
                else
                {
                    if (!(Launcher.ETS2Installed || Launcher.ATSInstalled))
                    {
                        DialogResult dialogResult = MessageBox.Show("There seems to be a problem with your TruckersMP install.\n\nDo you want to reinstall TruckersMP?\n(required)", "TruckersMP Launcher", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialogResult == DialogResult.Yes)
                        {
                            System.Threading.ThreadPool.QueueUserWorkItem(delegate
                            {
                                TruckersMP.install(TruckersMPUpdateProgress, TruckersMPUpdateProgressLabel, true);
                            });
                        }
                        else
                        {
                            Environment.Exit(1);
                        }
                    }
                    else
                    {
                        System.Threading.ThreadPool.QueueUserWorkItem(delegate
                        {
                            TruckersMP.integrityCheck(TruckersMPUpdateProgress, TruckersMPUpdateProgressLabel);
                        });
                    }
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("TruckersMP has not been installed!\n\nPlease run the TruckersMP installer once.\n\nWant to do it now? ", "TruckersMP Launcher", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("http://truckersmp.com/en_US/download");
                    Environment.Exit(1);
                }
                else
                {
                    Environment.Exit(1);
                }
            }
        }

        public static string latestVersion()
        {
            JObject latestver = new JObject();
            using (WebClient client = new WebClient())
            {
                try
                {
                    latestver = JObject.Parse(client.DownloadString("http://api.thomasakarlsen.com/truckersmplauncher/version/latest"));
                }
                catch (WebException)
                {
                    Console.WriteLine("Unable to connect to launcher API. Cannot check for new version");
                    return "0";
                }
            }

            return (string)latestver["Version"];
        }

        public static void update() {
            DialogResult dialogResult = MessageBox.Show("There is an update available to the launcher!\n\nDo you want to update now?", "TruckersMP Launcher", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                JObject latestver = new JObject();
                using (WebClient client = new WebClient())
                {
                    try
                    {
                        latestver = JObject.Parse(client.DownloadString("http://api.thomasakarlsen.com/truckersmplauncher/version/latest"));
                    }
                    catch (WebException)
                    {
                        Console.WriteLine("Unable to connect to launcher API. Cannot check for new version");
                        MessageBox.Show("Unable to connect to API.\n\nPlease check your internet connection and try again.", "TruckersMP Launcher", MessageBoxButtons.OK);
                        return;
                    }
                }

                Updater updater = new Updater();
                updater.Show();
                updater.Update((string)latestver["Location"]);
            }
        }
    }
}
