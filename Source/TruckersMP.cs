using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Security.Cryptography;

namespace truckersmplauncher
{
    public class TruckersMP
    {
        public static Int32 latestVersion() {
            JObject versiondata = new JObject();
            using (WebClient client = new WebClient())
            {
                try
                {
                    versiondata = JObject.Parse(client.DownloadString("https://api.truckersmp.com/v2/version/"));
                }
                catch (WebException)
                {
                    Console.WriteLine("Unable to connect to TruckersMP. Cannot check for TMP version");
                    return 0;
                }
            }
            return (Int32)versiondata["numeric"];
        }

        public static Int32 checkUpdate() {
            JObject versiondata = new JObject();
            using (WebClient client = new WebClient())
            {
                try
                {
                    versiondata = JObject.Parse(client.DownloadString("https://api.truckersmp.com/v2/version/"));
                }
                catch (WebException)
                {
                    Console.WriteLine("Unable to connect to TruckersMP. Cannot check for new TMP version");
                    return 0;
                }
            }

            if (System.IO.File.Exists(Launcher.TruckersMPLocation + "\\core_ets2mp.dll"))
            {
                var localchecksum = MD5(Launcher.TruckersMPLocation + "\\core_ets2mp.dll");
                var gotchecksum = (string)versiondata["ets2mp_checksum"]["dll"];

                if (String.Compare(gotchecksum, localchecksum, true) != 0)
                {

                    return (Int32)versiondata["numeric"];
                }
            }

            if (System.IO.File.Exists(Launcher.TruckersMPLocation + "\\core_atsmp.dll"))
            {
                var localchecksum = MD5(Launcher.TruckersMPLocation + "\\core_atsmp.dll");
                var gotchecksum = (string)versiondata["atsmp_checksum"]["dll"];

                if (String.Compare(gotchecksum, localchecksum, true) != 0)
                {
                    return (Int32)versiondata["numeric"];
                }
            }

            return 0;
        }

        public static void install(CProgressBar TruckersMPUpdateProgress, Label TruckersMPUpdateProgressLabel) {

            var version = latestVersion();

            TruckersMPUpdateProgress.Visible = true;
            TruckersMPUpdateProgressLabel.Visible = true;

            TruckersMPUpdateProgress.Maximum = 125;

            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TMPLauncher")) {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TMPLauncher");
            }

            using (WebClient downloadClient = new WebClient())
            {
                downloadClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(delegate (object sender, DownloadProgressChangedEventArgs e)
                {
                    TruckersMPUpdateProgress.Value = e.ProgressPercentage;
                });

                downloadClient.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler
                    (delegate (object sender, System.ComponentModel.AsyncCompletedEventArgs e)
                    {
                        if (e.Error == null && !e.Cancelled)
                        {
                            System.Threading.ThreadPool.QueueUserWorkItem(delegate
                            {
                                TruckersMPUpdateProgressLabel.Invoke((MethodInvoker)(() => TruckersMPUpdateProgressLabel.Text = "Unpacking TruckersMP..."));
                                System.IO.Compression.ZipFile.ExtractToDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TMPLauncher\\client_" + version + ".zip", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TMPLauncher\\client_" + version);
                                TruckersMPUpdateProgress.Value = 110;

                                TruckersMPUpdateProgressLabel.Invoke((MethodInvoker)(() => TruckersMPUpdateProgressLabel.Text = "Installing TruckersMP..."));

                                ProcessStartInfo startInfo = new ProcessStartInfo();
                                startInfo.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TMPLauncher\\client_" + version + "\\Install TruckersMP.exe";
                                
                                try
                                {
                                    using (Process exeProcess = Process.Start(startInfo))
                                    {
                                        exeProcess.WaitForExit();
                                    }
                                }
                                catch
                                {
                                   // Log Error
                                }
                                TruckersMPUpdateProgress.Value = 120;

                                TruckersMPUpdateProgressLabel.Invoke((MethodInvoker)(() => TruckersMPUpdateProgressLabel.Text = "Cleaning up..."));
                                try
                                {
                                    System.IO.Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TMPLauncher\\client_" + version, true);
                                    System.IO.File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TMPLauncher\\client_" + version + ".zip");
                                }
                                catch
                                {
                                    // Log error.
                                }

                                TruckersMPUpdateProgress.Value = 125;

                                TruckersMPUpdateProgress.Invoke((MethodInvoker)(() => TruckersMPUpdateProgress.Visible = false));
                                TruckersMPUpdateProgressLabel.Invoke((MethodInvoker)(() => TruckersMPUpdateProgressLabel.Text = "TruckersMP Installed!"));

                                System.Threading.Thread.Sleep(6000);
                                TruckersMPUpdateProgressLabel.Invoke((MethodInvoker)(() => TruckersMPUpdateProgressLabel.Visible = false));
                            });

                        }
                    });

                downloadClient.DownloadFileAsync(new Uri("http://download.ets2mp.com/client/client_" + version + ".zip"), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TMPLauncher\\client_" + version + ".zip");
            }
        }

        public static void update(CProgressBar TruckersMPUpdateProgress, Label TruckersMPUpdateProgressLabel, Int32 version, bool runGame = false, String game = "")
        {

            TruckersMPUpdateProgress.Visible = true;
            TruckersMPUpdateProgressLabel.Visible = true;

            TruckersMPUpdateProgress.Maximum = 125;

            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TMPLauncher"))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TMPLauncher");
            }

            using (WebClient downloadClient = new WebClient())
            {
                downloadClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(delegate (object sender, DownloadProgressChangedEventArgs e)
                {
                    TruckersMPUpdateProgress.Value = e.ProgressPercentage;
                });

                downloadClient.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler
                    (delegate (object sender, System.ComponentModel.AsyncCompletedEventArgs e)
                    {
                        if (e.Error == null && !e.Cancelled)
                        {
                            System.Threading.ThreadPool.QueueUserWorkItem(delegate
                            {
                                TruckersMPUpdateProgressLabel.Invoke((MethodInvoker)(() => TruckersMPUpdateProgressLabel.Text = "Unpacking TruckersMP..."));
                                System.IO.Compression.ZipFile.ExtractToDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TMPLauncher\\client_" + version + ".zip", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TMPLauncher\\client_" + version);
                                TruckersMPUpdateProgress.Value = 110;

                                TruckersMPUpdateProgressLabel.Invoke((MethodInvoker)(() => TruckersMPUpdateProgressLabel.Text = "Updating TruckersMP..."));

                                ProcessStartInfo startInfo = new ProcessStartInfo();
                                startInfo.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TMPLauncher\\client_" + version + "\\Install TruckersMP.exe";
                                startInfo.Arguments = "/verysilent";

                                try
                                {
                                    using (Process exeProcess = Process.Start(startInfo))
                                    {
                                        exeProcess.WaitForExit();
                                    }
                                }
                                catch
                                {
                                    // Log Error
                                }
                                TruckersMPUpdateProgress.Value = 120;

                                TruckersMPUpdateProgressLabel.Invoke((MethodInvoker)(() => TruckersMPUpdateProgressLabel.Text = "Cleaning up..."));
                                try
                                {
                                    System.IO.Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TMPLauncher\\client_" + version, true);
                                    System.IO.File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TMPLauncher\\client_" + version + ".zip");
                                }
                                catch
                                {
                                    // Log error.
                                }

                                TruckersMPUpdateProgress.Value = 125;

                                TruckersMPUpdateProgress.Invoke((MethodInvoker)(() => TruckersMPUpdateProgress.Visible = false));
                                TruckersMPUpdateProgressLabel.Invoke((MethodInvoker)(() => TruckersMPUpdateProgressLabel.Text = "TruckersMP Updated!"));
                                if (runGame)
                                {
                                    if (game == "ETS2MP")
                                    {
                                        Game.runETS2MP();
                                    }
                                    else if (game == "ATSMP")
                                    {
                                        Game.runATSMP();
                                    }
                                }
                                System.Threading.Thread.Sleep(6000);
                                TruckersMPUpdateProgressLabel.Invoke((MethodInvoker)(() => TruckersMPUpdateProgressLabel.Visible = false));
                            });

                        }
                    });

                downloadClient.DownloadFileAsync(new Uri("http://download.ets2mp.com/client/client_" + version + ".zip"), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TMPLauncher\\client_" + version + ".zip");
            }
        }

        protected static string MD5(string fileName)
        {
            FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] retVal = md5.ComputeHash(file);
            file.Close();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < retVal.Length; i++)
            {
                sb.Append(retVal[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
