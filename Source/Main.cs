using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Reflection;

namespace ets2mplauncher
{
    public partial class Main : Form
    {
        public Main()
        {
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
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.mploc == "" || Properties.Settings.Default.steamloc == "")
            {
                FirstTime frm = new FirstTime();
                frm.ShowDialog();
            }
            ServerStatus();
        }

        //
        // Buttons
        //

        private void Play_btn_Click(object sender, EventArgs e)
        {
            Play_btn.Image = Properties.Resources.Button_Play_Clicked;
            Play_btn.Enabled = false;
            if (Properties.Settings.Default.steamlaunch == true)
            {
                SteamLaunch();
            }
            else
            {
                ets2mpLaunch();
            }
           
        }

        private void UpdateOrMods_Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature has not been implemented", "ETS2MP - Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Settings_btn_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }

        private void About_btn_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void Banner_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://forum.scssoft.com/viewtopic.php?f=41&t=171000");
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            ServerStatus();
        }

        //
        // Functions
        //

        private void SteamLaunch()
        {
            
            String steam_path = Properties.Settings.Default.steamloc;
            var runningProcessByName = Process.GetProcessesByName("Steam");
            if (runningProcessByName.Length == 0)
            {
                Process.Start(steam_path + "\\Steam.exe");
                int Delay = Decimal.ToInt32(Properties.Settings.Default.steamdelay) * 1000;
                System.Threading.Thread.Sleep(Delay);
            }
            ets2mpLaunch();

        }

        private void ets2mpLaunch()
        {
            String ets2mp_path = Properties.Settings.Default.mploc;
            var runningProcessByName = Process.GetProcessesByName("eurotrucks2");
            if (runningProcessByName.Length == 0)
            {
                Process.Start(ets2mp_path + "\\launcher.exe");
            }
            else
            {
                MessageBox.Show("Euro Truck Simulator 2 (Multiplayer) is already running!", "ETS2MP Launcher - Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Play_btn.Image = Properties.Resources.Button_Play;
                Play_btn.Enabled = true;
                return;
            }

            if (!Properties.Settings.Default.launchclose)
            {
                System.Threading.Thread.Sleep(5000);
                Application.Exit();
            }
            else
            {
                Play_btn.Image = Properties.Resources.Button_Play;
                Play_btn.Enabled = true;
            }
            
       }

        //
        // Server Status
        //

        private void ServerStatus()
        {
            WebClient webClient = new WebClient();
            JObject results = JObject.Parse(webClient.DownloadString("http://api.ets2mp.com/servers/"));

            foreach (var result in results["response"])
            {
                string ID = (string)result["id"];
                string IP = (string)result["ip"];
                string Port = (string)result["port"];
                string Name = (string)result["name"];
                string Shortname = (string)result["shortname"];
                Boolean Online = (Boolean)result["online"];
                string Players = (string)result["players"];
                string Maxplayers = (string)result["maxplayers"];

                WriteServerStatus(ID, IP, Port, Name, Shortname, Online, Players, Maxplayers);
                Console.WriteLine("Server found! Data: (ID: {0}, IP: {1}, Port: {2}, Name: {3}, Shortname: {4}, Online: {5}, Players: {6}, Maxplayers: {7})", ID, IP, Port, Name, Shortname, Online, Players, Maxplayers);
            }
        }

        private void WriteServerStatus(String ID, String IP, String Port, String Name, String Shortname, Boolean online, String Players, String Maxplayers)
        { 
            if (ID == "1")
            {
                Server1_Name.Text = Name;
                if (online)
                {
                    Server1_Status.Text = "Status: ONLINE";
                }
                else
                {
                    Server1_Status.Text = "Status: OFFLINE";
                }
                Server1_Players.Text = "Players: " + Players + "/" + Maxplayers;

            }
            else if (ID == "4")
            {
                Server2_Name.Text = Name;
                if (online)
                {
                    Server2_Status.Text = "Status: ONLINE";
                }
                else
                {
                    Server2_Status.Text = "Status: OFFLINE";
                }
                Server2_Players.Text = "Players: " + Players + "/" + Maxplayers;
            }
            else if (ID == "3")
            {
                Server3_Name.Text = Name;
                if (online)
                {
                    Server3_Status.Text = "Status: ONLINE";
                }
                else
                {
                    Server3_Status.Text = "Status: OFFLINE";
                }
                Server3_Players.Text = "Players: " + Players + "/" + Maxplayers;
            }
        }

    }
}
