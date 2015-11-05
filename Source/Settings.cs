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

namespace ets2mplauncher
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

            //Directory
            ets2mp_dir_txt.Text = Properties.Settings.Default.mploc;

            //Launcher
            LauncherClose_chkbox.Checked = Properties.Settings.Default.launchclose;
            AutoUpdate_chkbox.Checked = Properties.Settings.Default.aplauncher;

            //ETS2
            ets2sin_chkbox.Checked = Properties.Settings.Default.ets2sin;
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

        private void UpdateCheck_btn_Click(object sender, EventArgs e)
        {
            checkForUpdates();
        }

        private void Done_btn_Click(object sender, EventArgs e)
        {
            //Directory
            Properties.Settings.Default.mploc = ets2mp_dir_txt.Text;

            //Launcher
            Properties.Settings.Default.launchclose = LauncherClose_chkbox.Checked;
            Properties.Settings.Default.aplauncher = AutoUpdate_chkbox.Checked;

            //ETS2
            Properties.Settings.Default.ets2sin = ets2sin_chkbox.Checked;

            Properties.Settings.Default.Save();
            this.Close();
        }

        //
        // Functions
        //

        private void checkForUpdates()
        {
            WebClient verClient = new WebClient();
            JObject latestver = JObject.Parse(verClient.DownloadString("http://theunknownkiller.tk/ets2mplauncher/api/latest.php"));
            Console.WriteLine(latestver);
            Console.WriteLine(Properties.Settings.Default.LauncherVersion);
            if (Properties.Settings.Default.LauncherVersion.Equals((string)latestver["Version"]))
            {
                MessageBox.Show("Current version is: " + Properties.Settings.Default.LauncherVersion + "\nLatest version is: " + (string)latestver["Version"] + "\n\nYou already have the newest version!\nThere is no need for you to update!", "ETS2MP Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                DialogResult dialogResult = MessageBox.Show("Current version is: " + Properties.Settings.Default.LauncherVersion + "\nLatest version is: " + (string)latestver["Version"] + "\n\nThere is an update available!\nDo you want to update now?", "ETS2MP Launcher", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Updater updater = new Updater();
                    updater.Show();
                    updater.Update((string)latestver["Location"]);
                }
            }
        }

    }
}
