using System;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

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
                        MessageBox.Show("Unable to connect to API.\n\nPlease check your internet connection and try again.", "TruckersMP Launcher", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
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
