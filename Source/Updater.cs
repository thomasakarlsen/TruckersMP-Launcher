using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace truckersmplauncher
{
    public partial class Updater : Form
    {
        public Updater()
        {
            InitializeComponent();
        }

        public void Update(String Location)
        {
            System.Threading.ThreadPool.QueueUserWorkItem(delegate
            {
                using (WebClient downloadClient = new WebClient())
                {
                    downloadClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(delegate (object sender, DownloadProgressChangedEventArgs e)
                    {
                        Console.WriteLine("Downloaded:" + e.ProgressPercentage.ToString());
                        updater_action.Invoke((MethodInvoker)(() => updater_action.Text = "Downloading update..."));
                        updater_progress.Value = e.ProgressPercentage;
                    });

                    downloadClient.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler
                        (delegate (object sender, System.ComponentModel.AsyncCompletedEventArgs e)
                        {
                            if (e.Error == null && !e.Cancelled)
                            {
                                Console.WriteLine("Download completed!");
                                updater_action.Invoke((MethodInvoker)(() => updater_action.Text = "Patching update..."));
                                System.Threading.Thread.Sleep(1000);

                                System.IO.File.Replace(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName + ".new", System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName, System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName + ".old", true);
                                updater_action.Invoke((MethodInvoker)(() => updater_action.Text = "Patch complete! Restarting launcher"));
                                System.Threading.Thread.Sleep(1000);
                                Application.Restart();
                            }
                        });

                    downloadClient.DownloadFileAsync(new Uri(Location), System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName + ".new");
                }
            });
        }
    }
}
