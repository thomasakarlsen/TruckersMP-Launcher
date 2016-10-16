using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace truckersmplauncher
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            versionLabel.Text = "Launcher version: ALPHA " + Properties.Settings.Default.LauncherVersion;
        }

        private void devLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://forum.truckersmp.com/index.php?/profile/20457-theunknownno/");
        }

        private void legalLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/TheUnknownNO/TruckersMP-Launcher/blob/master/LICENSE");
        }

        private void githubLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/TheUnknownNO/TruckersMP-Launcher");
        }
    }
}
