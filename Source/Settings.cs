using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ets2mplauncher.Kharenis;

namespace ets2mplauncher
{
    public partial class Settings : Form
    {

        private ConfigFile configFile;
        public Settings()
        {
            InitializeComponent();

            //Directories
            ets2mp_dir_txt.Text = Properties.Settings.Default.mploc;
            steam_dir_txt.Text = Properties.Settings.Default.steamloc;
            profile_dir_txt.Text = Properties.Settings.Default.profileloc;

            //Steam
            steam_launch_chkbox.Checked = Properties.Settings.Default.steamlaunch;
            SteamLaunchInt_num.Value = Properties.Settings.Default.steamdelay;

            //Launcher
            LauncherClose_chkbox.Checked = Properties.Settings.Default.launchclose;

            //ETS2
            ets2sin_chkbox.Checked = Properties.Settings.Default.ets2sin;

            //Set root folder for browser
            Browse_Dialog.RootFolder = Environment.SpecialFolder.MyComputer;

            //Load profile config file
            configFile = new ConfigFile(Properties.Settings.Default.profileloc);
            configFile.LoadFile();
            ets2re_chkbox.Checked = configFile.GetBoolSettingByName("g_force_economy_reset");
            ets2ef_chkbox.Checked = configFile.GetBoolSettingByName("g_police");

            
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

        private void UpdateCheck_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have accquired 1337 status. Yeez. Pressing a disabled button. That is real skillz, M8.", "ETS2MP - Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Done_btn_Click(object sender, EventArgs e)
        {
            //Directories
            Properties.Settings.Default.mploc = ets2mp_dir_txt.Text;
            Properties.Settings.Default.steamloc = steam_dir_txt.Text;
            Properties.Settings.Default.profileloc = profile_dir_txt.Text;

            //Steam
            Properties.Settings.Default.steamlaunch = steam_launch_chkbox.Checked;
            Properties.Settings.Default.steamdelay = SteamLaunchInt_num.Value;

            //Launcher
            Properties.Settings.Default.launchclose = LauncherClose_chkbox.Checked;

            //ETS2
            Properties.Settings.Default.ets2sin = ets2sin_chkbox.Checked;

            Properties.Settings.Default.Save();

            configFile.SaveFile();
            this.Close();
        }

        private void ets2sin_chkbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void profile_brw_btn_Click(object sender, EventArgs e)
        {
            Browse_Dialog.RootFolder = Environment.SpecialFolder.MyDocuments;
            if (Browse_Dialog.ShowDialog() == DialogResult.OK)
            {
                profile_dir_txt.Text = Browse_Dialog.SelectedPath;
                if (!configFile.IsLoaded)
                    configFile.LoadFile();
            }
            Browse_Dialog.RootFolder = Environment.SpecialFolder.MyComputer;
        }

        private void ets2re_chkbox_CheckedChanged(object sender, EventArgs e)
        {
            configFile.SetSettingByName("g_force_economy_reset", ets2re_chkbox.Checked);
        }

        private void ets2ef_chkbox_CheckedChanged(object sender, EventArgs e)
        {
            configFile.SetSettingByName("g_police", ets2ef_chkbox.Checked);
        }

    }
}
