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
using System.Configuration;
using System.Net.Configuration;
using Newtonsoft.Json.Linq;
using System.Reflection;

namespace ets2mplauncher
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Main_Load();
        }

        private void Main_Load()
        {
            

            //Add hover events
            this.Play_btn.MouseHover += new System.EventHandler(this.Play_btn_Hover);
            this.Settings_btn.MouseHover += new System.EventHandler(this.Settings_btn_Hover);
            this.Updates_btn.MouseHover += new System.EventHandler(this.Updates_btn_Hover);
            this.server_connect_btn_1.MouseHover += new System.EventHandler(this.server_connect_btn_1_Hover);
            this.server_connect_btn_2.MouseHover += new System.EventHandler(this.server_connect_btn_2_Hover);
            this.server_connect_btn_3.MouseHover += new System.EventHandler(this.server_connect_btn_3_Hover);
            this.server_connect_btn_4.MouseHover += new System.EventHandler(this.server_connect_btn_4_Hover);
            this.server_connect_btn_5.MouseHover += new System.EventHandler(this.server_connect_btn_5_Hover);

            if (Properties.Settings.Default.mploc == "")
            {
                FirstTime frm = new FirstTime();
                frm.ShowDialog();
            }
            ServerStatus();
            
        }

        //
        // Buttons
        //

        private void Play_btn_Hover(object sender, System.EventArgs e)
        {

        }

        private void Play_btn_Click(object sender, EventArgs e)
        {
            Play_btn.Enabled = false;
            ets2mpLaunch();
           
        }

        private void Updates_btn_Hover(object sender, System.EventArgs e)
        {

        }

        private void Updates_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature has not been implemented", "ETS2MP - Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Settings_btn_Hover(object sender, System.EventArgs e)
        {

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

        private void ets2mp_site_link_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://ets2mp.com");
        }

        private void Banner_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://forum.scssoft.com/viewtopic.php?f=41&t=171000");
        }
        
        private void design_creator_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://forum.ets2mp.com/index.php?/user/50-gama/");
        }

        //Server 1

        private void server_connect_btn_1_Hover(object sender, System.EventArgs e)
        {

        }

        private void server_connect_btn_1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature has not been implemented", "ETS2MP - Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Server 2

        private void server_connect_btn_2_Hover(object sender, System.EventArgs e)
        {

        }

        private void server_connect_btn_2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature has not been implemented", "ETS2MP - Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Server 3

        private void server_connect_btn_3_Hover(object sender, System.EventArgs e)
        {

        }

        private void server_connect_btn_3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature has not been implemented", "ETS2MP - Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Server 4

        private void server_connect_btn_4_Hover(object sender, System.EventArgs e)
        {

        }

        private void server_connect_btn_4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature has not been implemented", "ETS2MP - Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Server 5

        private void server_connect_btn_5_Hover(object sender, System.EventArgs e)
        {

        }

        private void server_connect_btn_5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature has not been implemented", "ETS2MP - Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //
        // Functions
        //

       

        private void ets2mpLaunch()
        {
            String ets2mp_path = Properties.Settings.Default.mploc;
            var runningProcessByName = Process.GetProcessesByName("eurotrucks2");
            if (runningProcessByName.Length == 0)
            {
                if (Properties.Settings.Default.ets2sin)
                {
                    Process.Start(ets2mp_path + "\\launcher.exe ","-nointro");
                }
                else
                {
                    Process.Start(ets2mp_path + "\\launcher.exe");
                }
            }
            else
            {
                MessageBox.Show("Euro Truck Simulator 2 (Multiplayer) is already running!", "ETS2MP Launcher - Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Play_btn.Image = Properties.Resources.play_btn;
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
                Play_btn.Image = Properties.Resources.play_btn;
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
                if (online)
                {
                    server_status_1.BackColor = Color.FromArgb(160,197,95);
                }
                else
                {
                    server_status_1.BackColor = Color.FromArgb(193, 94, 94);
                }
                server_players_1.Text = "PLAYERS " + Players + " out of " + Maxplayers;

            }
            else if (ID == "4")
            {
                if (online)
                {
                    server_status_2.BackColor = Color.FromArgb(160, 197, 95);
                }
                else
                {
                    server_status_2.BackColor = Color.FromArgb(193, 94, 94);
                }
                server_players_2.Text = "PLAYERS " + Players + " out of " + Maxplayers;
            }
            else if (ID == "3")
            {
                if (online)
                {
                    server_status_3.BackColor = Color.FromArgb(160, 197, 95);
                }
                else
                {
                    server_status_3.BackColor = Color.FromArgb(193, 94, 94);
                }
                server_players_3.Text = "PLAYERS " + Players + " out of " + Maxplayers;
            }
            else if (ID == "6")
            {
                if (online)
                {
                    server_status_4.BackColor = Color.FromArgb(160, 197, 95);
                }
                else
                {
                    server_status_4.BackColor = Color.FromArgb(193, 94, 94);
                }
                server_players_4.Text = "PLAYERS " + Players + " out of " + Maxplayers;
            }
            else if (ID == "7")
            {
                if (online)
                {
                    server_status_5.BackColor = Color.FromArgb(160, 197, 95);
                }
                else
                {
                    server_status_5.BackColor = Color.FromArgb(193, 94, 94);
                }
                server_players_5.Text = "PLAYERS " + Players + " out of " + Maxplayers;
            }

        }

    }
}
