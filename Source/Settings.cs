using System;
using System.Windows.Forms;

namespace truckersmplauncher
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(Done_btn_Click);

            //Launcher
            LauncherClose_chkbox.Checked = Properties.Settings.Default.closeLauncher;
            closeDelay_numeric.Value = Properties.Settings.Default.closeDelay;
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
            Properties.Settings.Default.closeLauncher = LauncherClose_chkbox.Checked;
            Properties.Settings.Default.closeDelay = closeDelay_numeric.Value;
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
