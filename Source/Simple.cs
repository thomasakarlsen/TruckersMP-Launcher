using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace truckersmplauncher
{
    public partial class Simple : Form
    {
        public Simple()
        {
            InitializeComponent();
            TruckersMPUpdateProgressLabel.Parent = background;
                try
                {
                    var request = WebRequest.Create("https://content.thomasakarlsen.com/truckersmplauncher/background.png");

                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        background.BackgroundImage = Bitmap.FromStream(stream);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Unable to connect to launcher API. Cannot aquire current background.");
                }

            
            Launcher.initialize(TruckersMPUpdateProgress, TruckersMPUpdateProgressLabel);
        }

        private void Button_Hover(object sender, System.EventArgs e)
        {
            var button = ((PictureBox)sender);
            if (button.Name.Equals("play_ets2mp_btn"))
                button.BackgroundImage = Properties.Resources.play_ets2mp_hover;
            else if (button.Name.Equals("play_ets2_btn"))
                button.BackgroundImage = Properties.Resources.play_ets2_hover;
            else if (button.Name.Equals("play_atsmp_btn"))
                button.BackgroundImage = Properties.Resources.play_atsmp_hover;
            else if (button.Name.Equals("play_ats_btn"))
                button.BackgroundImage = Properties.Resources.play_ats_hover;
            else if (button.Name.Equals("Settings_btn"))
                button.BackgroundImage = Properties.Resources.settings_hover_btn;
            else if (button.Name.Equals("About_btn"))
                button.BackgroundImage = Properties.Resources.about_btn_hover;
        }

        private void Button_HoverLeave(object sender, System.EventArgs e)
        {
            var button = ((PictureBox)sender);
            if (button.Name.Equals("play_ets2mp_btn"))
                button.BackgroundImage = Properties.Resources.play_ets2mp;
            else if (button.Name.Equals("play_ets2_btn"))
                button.BackgroundImage = Properties.Resources.play_ets2;
            else if (button.Name.Equals("play_atsmp_btn"))
                button.BackgroundImage = Properties.Resources.play_atsmp;
            else if (button.Name.Equals("play_ats_btn"))
                button.BackgroundImage = Properties.Resources.play_ats;
            else if (button.Name.Equals("Settings_btn"))
                button.BackgroundImage = Properties.Resources.settings_btn;
            else if (button.Name.Equals("About_btn"))
                button.BackgroundImage = Properties.Resources.about_btn;
        }

        private void launchGame(object sender, EventArgs e)
        {
            if (Launcher.working)
                return;

            var game = ((PictureBox)sender).Name;

            if (game.Contains("mp") && !Environment.Is64BitOperatingSystem)
            {
                MessageBox.Show("The TruckersMP Mod does not support 32-Bit operating systems.\nPlease upgrade your system to 64-Bit.", "TruckersMP Launcher - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (game.Contains("mp"))
            {
                System.Threading.ThreadPool.QueueUserWorkItem(delegate
                {
                    TruckersMP.integrityCheck(TruckersMPUpdateProgress, TruckersMPUpdateProgressLabel, true, game);
                });
                return;
            }

            if (game.Equals("play_ets2_btn"))
                Game.runETS2();
            else if (game.Equals("play_ats_btn"))
                Game.runATS();
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

        private void background_Click(object sender, EventArgs e)
        {

        }
    }
}
