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

namespace truckersmplauncher
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(Done_btn_Click);

            //Launcher
            LauncherClose_chkbox.Checked = Properties.Settings.Default.KeepLauncherOpen;
            AutoUpdate_chkbox.Checked = Properties.Settings.Default.AutoUpdateLauncher;
            AutoUpdate_TMP_chkbox.Checked = Properties.Settings.Default.AutoUpdateTMP;
            StartSteam_chkbox.Checked = Properties.Settings.Default.StartSteam;

            //ETS2
            ets2sin_chkbox.Checked = Properties.Settings.Default.ETS2NoIntro;
            ets2_launchargs.Text = Properties.Settings.Default.ETS2LaunchArguments;

            //ATS
            atssin_chkbox.Checked = Properties.Settings.Default.ATSNoIntro;
            ats_launchargs.Text = Properties.Settings.Default.ATSLaunchArguments;
        }

        //
        // Buttons
        //

        private void UpdateCheck_btn_Click(object sender, EventArgs e)
        {
            checkForUpdates();
        }

        private void Done_btn_Click(object sender, EventArgs e)
        {

            //Launcher
            Properties.Settings.Default.KeepLauncherOpen = LauncherClose_chkbox.Checked;
            Properties.Settings.Default.AutoUpdateLauncher = AutoUpdate_chkbox.Checked;
            Properties.Settings.Default.AutoUpdateTMP = AutoUpdate_TMP_chkbox.Checked;
            Properties.Settings.Default.StartSteam = StartSteam_chkbox.Checked;

            //ETS2
            Properties.Settings.Default.ETS2NoIntro = ets2sin_chkbox.Checked;
            Properties.Settings.Default.ETS2LaunchArguments = ets2_launchargs.Text;

            //ATS
            Properties.Settings.Default.ATSNoIntro = atssin_chkbox.Checked;
            Properties.Settings.Default.ATSLaunchArguments = ats_launchargs.Text;

            Properties.Settings.Default.Save();
            this.Close();
        }

        //
        // Functions
        //

        private void checkForUpdates()
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
                    MessageBox.Show("Unable to connect to launcher API.\nUpdate cancelled.", "TruckersMP Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            Console.WriteLine(latestver);
            Console.WriteLine(Properties.Settings.Default.LauncherVersion);

            string gotVer = (string)latestver["Version"];
            string localVer = Properties.Settings.Default.LauncherVersion;

            if ( !(string.Compare(gotVer, localVer, true) > 0))
            {
                MessageBox.Show("Current version is: " + Properties.Settings.Default.LauncherVersion + "\nLatest version is: " + (string)latestver["Version"] + "\n\nYou already have the newest version!\nThere is no need for you to update!", "TruckersMP Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                DialogResult dialogResult = MessageBox.Show("Current version is: " + Properties.Settings.Default.LauncherVersion + "\nLatest version is: " + (string)latestver["Version"] + "\n\nThere is an update available!\nDo you want to update now?", "TruckersMP Launcher", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
