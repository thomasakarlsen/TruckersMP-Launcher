using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ets2mplauncher
{
    public partial class FirstTime : Form
    {
        public FirstTime()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(FirstTime_FormClosed);
        }

        private void FirstTime_Load(object sender, EventArgs e)
        {
            if (Environment.Is64BitOperatingSystem)
            {
                steam_dir_txt.Text = Environment.GetEnvironmentVariable("ProgramFiles(x86)") + "\\Steam";
            }
            else
            {
                steam_dir_txt.Text = Environment.GetEnvironmentVariable("ProgramFiles") + "\\Steam";
            }
        }

        //
        // Buttons
        //

        private void ets2mp_brw_btn_Click(object sender, EventArgs e)
        {
            if (Browse_Dialog.ShowDialog() == DialogResult.OK)
            {
                ets2mp_dir_txt.Text = Browse_Dialog.SelectedPath;
            }
        }

        private void steam_brw_btn_Click(object sender, EventArgs e)
        {
            if (Browse_Dialog.ShowDialog() == DialogResult.OK)
            {
                steam_dir_txt.Text = Browse_Dialog.SelectedPath;
            }
        }

        private void Done_btn_Click(object sender, EventArgs e)
        {

            if (ets2mp_dir_txt.Text == "" || steam_dir_txt.Text == "")
            {
                MessageBox.Show("It is important to set both ETS2MP & Steam directories for this launcher to work!", "ETS2MP Launcher - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Directories
            Properties.Settings.Default.mploc = ets2mp_dir_txt.Text;
            Properties.Settings.Default.steamloc = steam_dir_txt.Text;

            //Steam
            Properties.Settings.Default.steamlaunch = steam_launch_chkbox.Checked;
            Properties.Settings.Default.steamdelay = SteamLaunchInt_num.Value;

            //Launcher
            Properties.Settings.Default.launchclose = LauncherClose_chkbox.Checked;

            Properties.Settings.Default.Save();
            this.Close();
        }

        

        void FirstTime_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ets2mp_dir_txt.Text == "" || steam_dir_txt.Text == "")
            {
                Application.Exit();
            }

            //Directories
            Properties.Settings.Default.mploc = ets2mp_dir_txt.Text;
            Properties.Settings.Default.steamloc = steam_dir_txt.Text;

            //Steam
            Properties.Settings.Default.steamlaunch = steam_launch_chkbox.Checked;
            Properties.Settings.Default.steamdelay = SteamLaunchInt_num.Value;

            //Launcher
            Properties.Settings.Default.launchclose = LauncherClose_chkbox.Checked;

            Properties.Settings.Default.Save();
            this.Close();
        }

    }
}
