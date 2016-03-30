using System;
using System.IO;
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
using System.Security.Cryptography;

namespace truckersmplauncher
{
    public partial class Main : Form
    {

        private JArray Servers = new JArray();
        public String TruckersMPLocation = "";
        public String ETS2Location = "";
        public String ATSLocation = "";
        public Boolean ETS2Installed = false;
        public Boolean ATSInstalled = false;
        private Boolean runGame = false;
        private String game = "";

        public Main()
        {
            InitializeComponent();

            this.Shown += new EventHandler(this.Main_Loaded);

            Microsoft.Win32.RegistryKey readKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\TruckersMP");
            if (readKey != null)
            {
                TruckersMPLocation = (string)readKey.GetValue("InstallDir");
                ETS2Location = (string)readKey.GetValue("InstallLocationETS2");
                ATSLocation = (string)readKey.GetValue("InstallLocationATS");

                if (!System.IO.Directory.Exists(TruckersMPLocation)) {
                    DialogResult dialogResult = MessageBox.Show("Unable to locate TruckersMP.\n\nDo you want to install it now?", "TruckersMP Launcher", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start("http://truckersmp.com/en_US/download");
                        Environment.Exit(1);
                    }
                    else
                    {
                       Environment.Exit(1);
                    }
                }

                if (System.IO.File.Exists(TruckersMPLocation + "\\core_ets2mp.dll"))
                {
                    ETS2Installed = true;
                }

                if (System.IO.File.Exists(TruckersMPLocation + "\\core_atsmp.dll"))
                {
                    ATSInstalled = true;
                }

                if(!(ETS2Installed || ATSInstalled)){
                    DialogResult dialogResult = MessageBox.Show("There seems to be a problem with your TruckersMP install.\n\nPlease reinstall TruckersMP. ", "TruckersMP Launcher", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start("http://truckersmp.com/en_US/download");
                        Environment.Exit(1);
                    }
                    else
                    {
                       Environment.Exit(1);
                    }
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Unable to locate TruckersMP.\n\nDo you want to install it now?", "TruckersMP Launcher", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("http://truckersmp.com/en_US/download");
                    Environment.Exit(1);
                }
                else
                {
                    Environment.Exit(1);
                }
            }
            Main_Load();
        }

        private void Main_Load()
        {
            
            //Add hover events
            this.Settings_btn.MouseHover += new System.EventHandler(this.Settings_btn_Hover);
            this.Mods_btn.MouseHover += new System.EventHandler(this.Updates_btn_Hover);

            ServerStatus();
        }

        private void Main_Loaded(object sender, System.EventArgs e)
        {
            if (Properties.Settings.Default.AutoUpdateTMP)
            {
                var result = checkTMPUpdate(); if (!(result == 0)){updateTMP(result);}
            }    
        }

        //
        // Buttons
        //

        private void Button_Hover(object sender, System.EventArgs e)
        {
            var button = ((PictureBox)sender);
            if (button.Name.Contains("MP"))
            {
                button.BackgroundImage = Properties.Resources.play_mp_btn_hover;
            }
            else
            {
                button.BackgroundImage = Properties.Resources.play_sp_btn_hover;
            }
        }

        private void Button_HoverLeave(object sender, System.EventArgs e)
        {
            var button = ((PictureBox)sender);
            if (button.Name.Contains("MP"))
            {
                button.BackgroundImage = Properties.Resources.play_mp_btn;
            }
            else
            {
                button.BackgroundImage = Properties.Resources.play_sp_btn;
            }
        }

        private void Updates_btn_Hover(object sender, System.EventArgs e)
        {

        }

        private void Updates_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("This feature is not implemented yet!", "TruckersMP Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Mods mods = new Mods(this);
            //mods.ShowDialog();
        }

        private void Settings_btn_Hover(object sender, System.EventArgs e)
        {

        }

        private void Mods_btn_Click(object sender, EventArgs e)
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
            System.Diagnostics.Process.Start("http://truckersmp.com");
        }

        private void Banner_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://forum.scssoft.com/viewtopic.php?f=41&t=171000");
        }
        
        private void design_creator_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://forum.truckersmp.com/index.php?/user/50-gama/");
        }


        //
        // Functions
        //

        protected string GetMD5HashFromFile(string fileName)
        {
            FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] retVal = md5.ComputeHash(file);
            file.Close();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < retVal.Length; i++)
            {
                sb.Append(retVal[i].ToString("x2"));
            }
            return sb.ToString();
        }


        private Int32 checkTMPUpdate()
        {
            JObject versiondata = new JObject();
            using (WebClient client = new WebClient())
            {
                try
                {
                    versiondata = JObject.Parse(client.DownloadString("https://api.truckersmp.com/v2/version/"));
                }
                catch (WebException)
                {
                    Console.WriteLine("Unable to connect to TruckersMP. Cannot check for new TMP version");
                    return 0;
                }
            }

            if (System.IO.File.Exists(TruckersMPLocation + "\\core_ets2mp.dll"))
            {
                var localchecksum = GetMD5HashFromFile(TruckersMPLocation + "\\core_ets2mp.dll");
                var gotchecksum = (string)versiondata["ets2mp_checksum"]["dll"];

                if (String.Compare(gotchecksum, localchecksum, true) != 0)
                {

                    return (Int32)versiondata["numeric"];
                }
            }

            if (System.IO.File.Exists(TruckersMPLocation + "\\core_atsmp.dll"))
            {
                var localchecksum = GetMD5HashFromFile(TruckersMPLocation + "\\core_atsmp.dll");
                var gotchecksum = (string)versiondata["atsmp_checksum"]["dll"];

                if (String.Compare(gotchecksum, localchecksum, true) != 0)
                {
                    return (Int32)versiondata["numeric"];
                }
            }

            return 0;
        }

        private void updateTMP(Int32 version)
        {
            JObject releasedata = new JObject();
            using (WebClient client = new WebClient())
            {
                try
                {
                    releasedata = JObject.Parse(client.DownloadString("http://api.thomasakarlsen.com/truckersmplauncher/releases/latest"));
                    Console.WriteLine(releasedata);
                }
                catch (WebException)
                {
                    Console.WriteLine("Unable to connect to Launcher API. Cannot check for available releases");
                    return;
                }
            }

            Int32 gotVer = (Int32)releasedata["Version"];


            if (gotVer < version)
            {
                DialogResult dialogNoAuto = MessageBox.Show("Your version of TruckersMP is outdated.\nAutomatic update is not yet available for this release.\n\nDo you want to install manually?", "TruckersMP Launcher", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogNoAuto == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("http://truckersmp.com/en_US/download");
                    return;
                }
                else
                {
                    return;
                }
            }

            DialogResult dialogResult = MessageBox.Show("Your version of TruckersMP is outdated.\nDo you want to update?", "TruckersMP Launcher", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                TruckersMPUpdateProgress.Visible = true;
                TruckersMPUpdateProgressLabel.Visible = true;

                using (WebClient downloadClient = new WebClient())
                {
                    downloadClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(delegate(object sender, DownloadProgressChangedEventArgs e)
                    {
                        TruckersMPUpdateProgress.Value = e.ProgressPercentage;
                    });

                    downloadClient.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler
                        (delegate(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
                        {
                            if (e.Error == null && !e.Cancelled)
                            {
                                TruckersMPUpdateProgressLabel.Text = "Updating TruckersMP...";
                                System.Threading.ThreadPool.QueueUserWorkItem(delegate
                                {
                                    ProcessStartInfo startInfo = new ProcessStartInfo();
                                    startInfo.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Update TruckersMP.exe";
                                    startInfo.Arguments = "/verysilent";
                                    try
                                    {
                                        using (Process exeProcess = Process.Start(startInfo))
                                        {
                                            exeProcess.WaitForExit();
                                        }
                                    }
                                    catch
                                    {
                                        // Log error.
                                    }
                                    TruckersMPUpdateProgress.Invoke((MethodInvoker)(() => TruckersMPUpdateProgress.Visible = false));
                                    TruckersMPUpdateProgressLabel.Invoke((MethodInvoker)(() => TruckersMPUpdateProgressLabel.Text = "TruckersMP Updated!"));
                                    if (runGame)
                                    {
                                        var senderObject = new PictureBox();
                                        senderObject.Name = game;
                                        launchGame(senderObject, new EventArgs());
                                    }
                                    System.Threading.Thread.Sleep(6000);
                                    TruckersMPUpdateProgressLabel.Invoke((MethodInvoker)(() => TruckersMPUpdateProgressLabel.Visible = false));
                                });
                                
                            }
                        });

                    downloadClient.DownloadFileAsync(new Uri((String)releasedata["Location"]), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Update TruckersMP.exe");
                }
            }
        }

        private void launchGame(object sender, EventArgs e)
        {
            runGame = false;

            game = ((PictureBox)sender).Name;

            if (game.Contains("MP") && !Environment.Is64BitOperatingSystem)
            {
                MessageBox.Show("The TruckersMP Mod does not support 32-Bit operating systems.\nPlease upgrade your system to 64-Bit.", "TruckersMP Launcher - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Properties.Settings.Default.AutoUpdateTMP && game.Contains("MP"))
            {
                var result = checkTMPUpdate();
                if (!(result == 0))
                {
                    runGame = true;
                    updateTMP(result);
                    return;
                } 
            }

            if (game == "ETS2")
            {
                if (Process.GetProcessesByName("eurotrucks2").Length == 0)
                {
                    var binPath = "\\bin\\win_x86";

                    if (Environment.Is64BitOperatingSystem) {
                        binPath = "\\bin\\win_x64";
                    }

                    if (Properties.Settings.Default.ETS2NoIntro)
                    {
                        Process.Start(ETS2Location + binPath + "\\eurotrucks2.exe ", "-nointro " + Properties.Settings.Default.ETS2LaunchArguments);
                    }
                    else
                    {
                        Process.Start(ETS2Location + binPath + "\\eurotrucks2.exe ", Properties.Settings.Default.ETS2LaunchArguments);
                    }
                }
                else
                {
                    MessageBox.Show("Euro Truck Simulator 2 is already running!", "TruckersMP Launcher - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (game == "ETS2MP")
            {
                if (Process.GetProcessesByName("eurotrucks2").Length == 0)
                {
                    if (Properties.Settings.Default.ETS2NoIntro)
                    {
                        Process.Start(TruckersMPLocation + "\\launcher_ets2mp.exe ", "-nointro " + Properties.Settings.Default.ETS2LaunchArguments);
                    }
                    else
                    {
                        Process.Start(TruckersMPLocation + "\\launcher_ets2mp.exe ", Properties.Settings.Default.ETS2LaunchArguments);
                    }
                }
                else
                {
                    MessageBox.Show("Euro Truck Simulator 2 (Multiplayer) is already running!", "TruckersMP Launcher - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (game == "ATS")
            {
                if (Process.GetProcessesByName("amtrucks").Length == 0)
                {
                    var binPath = "\\bin\\win_x86";

                    if (Environment.Is64BitOperatingSystem)
                    {
                        binPath = "\\bin\\win_x64";
                    }

                    if (Properties.Settings.Default.ATSNoIntro)
                    {
                        Process.Start(ATSLocation + binPath + "\\amtrucks.exe ", "-nointro " + Properties.Settings.Default.ATSLaunchArguments);
                    }
                    else
                    {
                        Process.Start(ATSLocation + binPath + "\\amtrucks.exe ", Properties.Settings.Default.ATSLaunchArguments);
                    }
                }
                else
                {
                    MessageBox.Show("American Truck Simulator is already running!", "TruckersMP Launcher - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (game == "ATSMP")
            {
                if (Process.GetProcessesByName("amtrucks").Length == 0)
                {
                    if (Properties.Settings.Default.ATSNoIntro)
                    {
                        Process.Start(TruckersMPLocation + "\\launcher_atsmp.exe ", "-nointro " + Properties.Settings.Default.ATSLaunchArguments);
                    }
                    else
                    {
                        Process.Start(TruckersMPLocation + "\\launcher_atsmp.exe ", Properties.Settings.Default.ATSLaunchArguments);
                    }
                }
                else
                {
                    MessageBox.Show("American Truck Simulator (Multiplayer) is already running!", "TruckersMP Launcher - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        //
        // Server Status
        //

        private void ServerStatus()
        {
            int loc = 15;
            Servers.Clear();
            JObject results = new JObject();
            using (WebClient client = new WebClient())
            {
                try
                {
                    results = JObject.Parse(client.DownloadString("https://api.truckersmp.com/v2/servers/"));
                }
                catch (WebException)
                {
                    Console.WriteLine("Unable to connect to TruckersMP API. Cannot reach servers.");
                    Label errormsg = new Label();
                    errormsg.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
                    errormsg.ForeColor = Color.FromArgb(193, 94, 94);
                    errormsg.Location = new System.Drawing.Point(12, loc - 5);
                    errormsg.Size = new Size(976, 10);
                    errormsg.Text = "Unable to connect to TruckersMP API";
                    errormsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    errormsg.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left);
                    serverspanel.Controls.Add(errormsg);
                    loc = loc + 20;
                }
            }

            if (results.Count != 0) {
                foreach (var result in results["response"])
                {
                    Servers.Add(result);
                }
            }

            //
            // Lets generate the visuals!
            // 

            serverspanel.Controls.Clear(); //Clear the panel, in case of refresh

            //
            // Generate ETS2 Section
            //
            if (ETS2Installed)
            { 
                Panel ets2mppanel = new Panel();

                ets2mppanel.BackColor = Color.FromArgb(200, 200, 200);
                ets2mppanel.Location = new Point(12, loc);
                ets2mppanel.Size = new Size(976, 44);
                ets2mppanel.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);

                Label ets2mptitle = new Label();
                ets2mptitle.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
                ets2mptitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
                ets2mptitle.Location = new System.Drawing.Point(13, 8);
                ets2mptitle.AutoSize = true;
                ets2mptitle.Text = "Euro Truck Simulator 2 (Multiplayer)";

                PictureBox ets2spplay = new PictureBox();
                ets2spplay.Location = new Point(745, 6);
                ets2spplay.Size = new Size(102, 31);
                ets2spplay.BackgroundImage = Properties.Resources.play_sp_btn;
                ets2spplay.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
                ets2spplay.Name = "ETS2";
                ets2spplay.Cursor = System.Windows.Forms.Cursors.Hand;
                ets2spplay.Click += new System.EventHandler(this.launchGame);
                ets2spplay.MouseHover += new System.EventHandler(this.Button_Hover);
                ets2spplay.MouseLeave += new System.EventHandler(this.Button_HoverLeave);

                PictureBox ets2mpplay = new PictureBox();
                ets2mpplay.Location = new Point(853, 6);
                ets2mpplay.Size = new Size(110, 31);
                ets2mpplay.BackgroundImage = Properties.Resources.play_mp_btn;
                ets2mpplay.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
                ets2mpplay.Name = "ETS2MP";
                ets2mpplay.Cursor = System.Windows.Forms.Cursors.Hand;
                ets2mpplay.Click += new System.EventHandler(this.launchGame);
                ets2mpplay.MouseHover += new System.EventHandler(this.Button_Hover);
                ets2mpplay.MouseLeave += new System.EventHandler(this.Button_HoverLeave);

                serverspanel.Controls.Add(ets2mppanel);
                ets2mppanel.Controls.Add(ets2mptitle);
                ets2mppanel.Controls.Add(ets2spplay);
                ets2mppanel.Controls.Add(ets2mpplay);

                loc = loc + 59;

                //
                // Add ETS2MP servers to list
                //
                if (Servers.Count != 0)
                {
                    foreach (var server in Servers)
                    {
                        if ((string)server["game"] == "ETS2")
                        {
                            addServer((bool)server["online"], (string)server["name"], (string)server["players"], (string)server["maxplayers"], (string)server["game"], (int)server["speedlimiter"], loc);
                            loc = loc + 59;
                        }
                    }
                }
            }

            //
            // Generate ATS Section
            //
            if (ATSInstalled)
            { 
                Panel atsmppanel = new Panel();

                atsmppanel.BackColor = Color.FromArgb(200, 200, 200);
                atsmppanel.Location = new Point(12, loc);
                atsmppanel.Size = new Size(976, 44);
                atsmppanel.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);

                Label atsmptitle = new Label();
                atsmptitle.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
                atsmptitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
                atsmptitle.Location = new System.Drawing.Point(13, 8);
                atsmptitle.AutoSize = true;
                atsmptitle.Text = "American Truck Simulator (Multiplayer)";

                PictureBox atsspplay = new PictureBox();
                atsspplay.Location = new Point(745, 6);
                atsspplay.Size = new Size(102, 31);
                atsspplay.BackgroundImage = Properties.Resources.play_sp_btn;
                atsspplay.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
                atsspplay.Name = "ATS";
                atsspplay.Cursor = System.Windows.Forms.Cursors.Hand;
                atsspplay.Click += new System.EventHandler(this.launchGame);
                atsspplay.MouseHover += new System.EventHandler(this.Button_Hover);
                atsspplay.MouseLeave += new System.EventHandler(this.Button_HoverLeave);

                PictureBox atsmpplay = new PictureBox();
                atsmpplay.Location = new Point(853, 6);
                atsmpplay.Size = new Size(110, 31);
                atsmpplay.BackgroundImage = Properties.Resources.play_mp_btn;
                atsmpplay.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
                atsmpplay.Name = "ATSMP";
                atsmpplay.Cursor = System.Windows.Forms.Cursors.Hand;
                atsmpplay.Click += new System.EventHandler(this.launchGame);
                atsmpplay.MouseHover += new System.EventHandler(this.Button_Hover);
                atsmpplay.MouseLeave += new System.EventHandler(this.Button_HoverLeave);

                serverspanel.Controls.Add(atsmppanel);
                atsmppanel.Controls.Add(atsmptitle);
                atsmppanel.Controls.Add(atsspplay);
                atsmppanel.Controls.Add(atsmpplay);

                loc = loc + 59;

                //
                // Add ATSMP servers to list
                //
                if (Servers.Count != 0)
                {
                    foreach (var server in Servers)
                    {
                        if ((string)server["game"] == "ATS")
                        {
                            addServer((bool)server["online"], (string)server["name"], (string)server["players"], (string)server["maxplayers"], (string)server["game"], (int)server["speedlimiter"], loc);
                            loc = loc + 59;
                        }
                    }
                }
            }
        }

        private void addServer(bool online, string shortname, string players, string maxplayers, string game, int limit, int loc) {
            
            Panel serverpanel = new Panel();

            serverpanel.BackColor = Color.FromArgb(222, 222, 222);
            serverpanel.Location = new Point(12, loc);
            serverpanel.Size = new Size(976, 44);
            serverpanel.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);

            Label serverid = new Label();

            serverid.BackColor = Color.Black;
            if (online) { serverid.BackColor = Color.FromArgb(160, 197, 95); } else { serverid.BackColor = Color.FromArgb(193, 94, 94); }
            serverid.Location = new Point(0, 0);
            serverid.Size = new Size(81, 44);
            serverid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            serverid.Text = shortname;
            serverid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            PictureBox playericon = new PictureBox();
            playericon.Location = new Point(95, 13);
            playericon.Size = new Size(15, 17);
            playericon.BackgroundImage = Properties.Resources.players;

            Label playerslbl = new Label();
            playerslbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            playerslbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            playerslbl.Location = new System.Drawing.Point(115, 13);
            playerslbl.AutoSize = true;
            playerslbl.Text = players + " out of " + maxplayers + " players";

            PictureBox gameicon = new PictureBox();
            gameicon.Location = new Point(306, 13);
            gameicon.Size = new Size(16, 17);
            gameicon.BackgroundImage = Properties.Resources.game;

            Label gamelbl = new Label();
            gamelbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            gamelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            gamelbl.Location = new System.Drawing.Point(329, 12);
            gamelbl.AutoSize = true;
            gamelbl.Text = game;

            if (limit != 0)
            {
                PictureBox limiticon = new PictureBox();
                limiticon.Location = new Point(392, 13);
                limiticon.Size = new Size(16, 17);
                limiticon.BackgroundImage = Properties.Resources.limit;

                Label limitlbl = new Label();
                limitlbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
                limitlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
                limitlbl.Location = new System.Drawing.Point(412, 12);
                limitlbl.AutoSize = true;
                limitlbl.Text = "Speed limiter";

                serverpanel.Controls.Add(limiticon);
                serverpanel.Controls.Add(limitlbl);
            }

            PictureBox playbutton = new PictureBox();
            playbutton.Location = new Point(864, 0);
            playbutton.Size = new Size(112, 44);
            playbutton.BackgroundImage = Properties.Resources.server_connect_btn;
            playbutton.Anchor = (AnchorStyles.Top | AnchorStyles.Right);


            serverspanel.Controls.Add(serverpanel);
            serverpanel.Controls.Add(serverid);
            serverpanel.Controls.Add(playericon);
            serverpanel.Controls.Add(playerslbl);
            serverpanel.Controls.Add(gameicon);
            serverpanel.Controls.Add(gamelbl);
            //serverpanel.Controls.Add(playbutton);
        }
    }
}
