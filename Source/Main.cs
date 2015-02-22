using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace ets2mplauncher
{
    public partial class Main : Form
    {
        launcher launcher = new launcher();
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        //
        // Buttons
        //

        private void Play_btn_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.steamlaunch == true)
            {
                SteamLaunch();
            }
           
        }

        private void About_btn_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
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
                System.Threading.Thread.Sleep(10000);
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
                MessageBox.Show("Euro Truck Simulator 2 (Multiplayer) is already running!", "Launch Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
       }
    }
}
