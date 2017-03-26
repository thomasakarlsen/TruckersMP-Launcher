using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace truckersmplauncher
{
    public partial class Settings : Form
    {
        Dictionary<string, string> ETS2Config = new Dictionary<string, string>();
        Dictionary<string, string> ATSConfig = new Dictionary<string, string>();

        public Settings()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(Done_btn_Click);

            ETS2Config = Game.getConfig("ETS2");
            ATSConfig = Game.getConfig("ATS");

            //Launcher
            LauncherClose_chkbox.Checked = Properties.Settings.Default.closeLauncher;
            closeDelay_numeric.Value = Properties.Settings.Default.closeDelay;
            AutoUpdate_chkbox.Checked = Properties.Settings.Default.AutoUpdateLauncher;
            StartSteam_chkbox.Checked = Properties.Settings.Default.StartSteam;

            if (Properties.Settings.Default.mode.Equals("advanced"))
                advancedLauncher_btn.Checked = true;
            else if (Properties.Settings.Default.mode.Equals("simple"))
                simpleLauncher_btn.Checked = true;

            //ETS2
            ets2sin_chkbox.Checked = Properties.Settings.Default.ETS2NoIntro;
            ets2_launchargs.Text = Properties.Settings.Default.ETS2LaunchArguments;
            if (ETS2Config != null)
            {
                ets2_gameoptions.Visible = true;
                ets_save_format.Text = ETS2Config["g_save_format"];
                ets2_console.Checked = Convert.ToBoolean(Convert.ToInt32(ETS2Config["g_console"]));
                ets2_online_loading.Checked = Convert.ToBoolean(Convert.ToInt32(ETS2Config["g_online_loading_screens"]));
                ets2_traffic.Checked = Convert.ToBoolean(Convert.ToInt32(ETS2Config["g_traffic"].Replace(".0", "")));
                ets2_show_fps.Checked = Convert.ToBoolean(Convert.ToInt32(ETS2Config["g_fps"]));
            }
            else {
                ets2_gameoptions.Visible = false;
            }

            //ATS
            atssin_chkbox.Checked = Properties.Settings.Default.ATSNoIntro;
            ats_launchargs.Text = Properties.Settings.Default.ATSLaunchArguments;
            if (ATSConfig != null)
            {
                ats_gameoptions.Visible = true;
                ats_save_format.Text = ATSConfig["g_save_format"];
                ats_console.Checked = Convert.ToBoolean(Convert.ToInt32(ATSConfig["g_console"]));
                ats_online_loading.Checked = Convert.ToBoolean(Convert.ToInt32(ATSConfig["g_online_loading_screens"]));
                ats_traffic.Checked = Convert.ToBoolean(Convert.ToInt32(ATSConfig["g_traffic"].Replace(".0", "")));
                ats_show_fps.Checked = Convert.ToBoolean(Convert.ToInt32(ATSConfig["g_fps"]));
            }
            else {
                ats_gameoptions.Visible = false;
            }
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
            Properties.Settings.Default.closeLauncher = LauncherClose_chkbox.Checked;
            Properties.Settings.Default.closeDelay = closeDelay_numeric.Value;
            Properties.Settings.Default.AutoUpdateLauncher = AutoUpdate_chkbox.Checked;
            Properties.Settings.Default.StartSteam = StartSteam_chkbox.Checked;

            if (advancedLauncher_btn.Checked)
                Properties.Settings.Default.mode = "advanced";
            else if (simpleLauncher_btn.Checked)
                Properties.Settings.Default.mode = "simple";

            //ETS2
            Properties.Settings.Default.ETS2NoIntro = ets2sin_chkbox.Checked;
            Properties.Settings.Default.ETS2LaunchArguments = ets2_launchargs.Text;
            if (ETS2Config != null)
            {
                ETS2Config["g_save_format"] = ets_save_format.Text;
                ETS2Config["g_console"] = (Convert.ToInt32(ets2_console.Checked)).ToString();
                ETS2Config["g_developer"] = (Convert.ToInt32(ets2_console.Checked)).ToString();
                ETS2Config["g_online_loading_screens"] = (Convert.ToInt32(ets2_online_loading.Checked)).ToString();
                ETS2Config["g_traffic"] = (Convert.ToInt32(ets2_traffic.Checked)).ToString();
                ETS2Config["g_fps"] = (Convert.ToInt32(ets2_show_fps.Checked)).ToString();
            }

            //ATS
            Properties.Settings.Default.ATSNoIntro = atssin_chkbox.Checked;
            Properties.Settings.Default.ATSLaunchArguments = ats_launchargs.Text;
            if (ATSConfig != null)
            {
                ATSConfig["g_save_format"] = ats_save_format.Text;
                ATSConfig["g_console"] = (Convert.ToInt32(ats_console.Checked)).ToString();
                ATSConfig["g_developer"] = (Convert.ToInt32(ats_console.Checked)).ToString();
                ATSConfig["g_online_loading_screens"] = (Convert.ToInt32(ats_online_loading.Checked)).ToString();
                ATSConfig["g_traffic"] = (Convert.ToInt32(ats_traffic.Checked)).ToString();
                ATSConfig["g_fps"] = (Convert.ToInt32(ats_show_fps.Checked)).ToString();
            }
            if (ETS2Config != null)
                Game.writeConfig("ETS2", ETS2Config);
            if (ATSConfig != null)
                Game.writeConfig("ATS", ATSConfig);

            Properties.Settings.Default.Save();
            this.Close();
        }

        //
        // Functions
        //

        private void checkForUpdates()
        {

            string latest = Launcher.latestVersion();
            string local = Properties.Settings.Default.LauncherVersion;

            if (latest == "0") {
                MessageBox.Show("Unable to connect to API.\n\nPlease check your internet connection and try again.", "TruckersMP Launcher", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return;
            }

            if ( !(string.Compare(latest, local, true) > 0))
            {
                MessageBox.Show("Current version is: " + local + "\nLatest version is: " + latest + "\n\nYou already have the newest version!\nThere is no need for you to update!", "TruckersMP Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                Launcher.update();
            }
        }
    }
}
