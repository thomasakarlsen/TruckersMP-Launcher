using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using Newtonsoft.Json.Linq;


namespace truckersmplauncher
{
    public partial class Main : Form
    {

        private JArray Servers = new JArray();
        
        private String game = "";
        public JArray mods = new JArray();
        Panel newspanel = new Panel();

        public Main()
        {
            InitializeComponent();

            this.Shown += new EventHandler(this.Main_Loaded);

            this.FormClosed += new FormClosedEventHandler(Main_Close);

            if (Properties.Settings.Default.StartSteam)
            {
                if (Process.GetProcessesByName("Steam").Length == 0)
                {
                    Microsoft.Win32.RegistryKey steamKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Valve\\Steam");
                    if (steamKey != null)
                    {
                        string SteamExe = (string)steamKey.GetValue("SteamExe");
                        if (SteamExe != null)
                        {
                            Process.Start(SteamExe);
                        }
                    }
                }
            }
            Main_Load();
        }

        private void Main_Load()
        {
            //Add hover events
            
            this.Mods_btn.MouseHover += new System.EventHandler(this.Updates_btn_Hover);

        }

        private void Main_Close(object sender, EventArgs e)
        {
            if (Launcher.TFMRadioPlaying)
            {
                Launcher.tfm.open_launcher.Visible = true;
            }
            else
            {
                Launcher.tfm.Close();
            }
        }

        private void Main_Loaded(object sender, System.EventArgs e)
        {
            Launcher.ETS2Installed = false;
            Launcher.ATSInstalled = false;
            Microsoft.Win32.RegistryKey readKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\TruckersMP");
            if (readKey != null)
            {
                Launcher.TruckersMPLocation = (string)readKey.GetValue("InstallDir");
                Launcher.ETS2Location = (string)readKey.GetValue("InstallLocationETS2");
                Launcher.ATSLocation = (string)readKey.GetValue("InstallLocationATS");

                if (!System.IO.Directory.Exists(Launcher.TruckersMPLocation))
                {
                    DialogResult dialogResult = MessageBox.Show("Unable to locate TruckersMP.\n\nDo you want to install it now?", "TruckersMP Launcher", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Launcher.ETS2Installed = true;
                        Launcher.ATSInstalled = true;

                        TruckersMP.install(TruckersMPUpdateProgress,TruckersMPUpdateProgressLabel);
                    }
                    else
                    {
                        Environment.Exit(1);
                    }
                }
                else
                { 

                    if (System.IO.File.Exists(Launcher.TruckersMPLocation + "\\core_ets2mp.dll"))
                    {
                        Launcher.ETS2Installed = true;
                    }

                    if (System.IO.File.Exists(Launcher.TruckersMPLocation + "\\core_atsmp.dll"))
                    {
                        Launcher.ATSInstalled = true;
                    }

                    if (!(Launcher.ETS2Installed || Launcher.ATSInstalled))
                    {
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
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Unable to locate TruckersMP.\n\nDo you want to install it now?", "TruckersMP Launcher", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    Launcher.ETS2Installed = true;
                    Launcher.ATSInstalled = true;

                    TruckersMP.install(TruckersMPUpdateProgress, TruckersMPUpdateProgressLabel);
                }
                else
                {
                    Environment.Exit(1);
                }
            }
            ServerStatus();

            if (Properties.Settings.Default.AutoUpdateTMP)
            {
                var result = TruckersMP.checkUpdate();
                if (!(result == 0)){
                    DialogResult dialogResult = MessageBox.Show("Your version of TruckersMP is outdated!\n\nDo you want to update it?", "TruckersMP Launcher", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        TruckersMP.update(TruckersMPUpdateProgress, TruckersMPUpdateProgressLabel, result);
                    }
                    
                }
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

        private void Mods_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("This feature is not implemented yet!", "TruckersMP Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
            /*serverspanel.Visible = false;
            modspanel.Visible = true;
            loadMods();*/
        }

        private void Settings_btn_Hover(object sender, System.EventArgs e)
        {
            Settings_btn.BackgroundImage = Properties.Resources.settings_hover_btn;
        }
        private void Settings_btn_HoverLeave(object sender, System.EventArgs e)
        {
            Settings_btn.BackgroundImage = Properties.Resources.settings_btn;
        }

        private void Settings_btn_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }

        private void Radio_btn_Click(object sender, EventArgs e)
        {
            if (Launcher.tfm.IsDisposed)
                Launcher.tfm = new truckersfm();
            Launcher.tfm.Show();
        }

        private void Radio_btn_Hover(object sender, System.EventArgs e)
        {
            radio_btn.BackgroundImage = Properties.Resources.radio_hover_btn;
        }

        private void Radio_btn_HoverLeave(object sender, System.EventArgs e)
        {
            radio_btn.BackgroundImage = Properties.Resources.radio_btn;
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

        private void launchGame(object sender, EventArgs e)
        {

            game = ((PictureBox)sender).Name;

            if (game.Contains("MP") && !Environment.Is64BitOperatingSystem)
            {
                MessageBox.Show("The TruckersMP Mod does not support 32-Bit operating systems.\nPlease upgrade your system to 64-Bit.", "TruckersMP Launcher - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Properties.Settings.Default.AutoUpdateTMP && game.Contains("MP"))
            {
                var result = TruckersMP.checkUpdate();
                if (!(result == 0))
                {
                    DialogResult dialogResult = MessageBox.Show("Your version of TruckersMP is outdated!\nIt is required to update TruckersMP to play!\n\nDo you want to update it?", "TruckersMP Launcher", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        TruckersMP.update(TruckersMPUpdateProgress, TruckersMPUpdateProgressLabel, result, true, game);
                        return;
                    }
                    else
                    {
                        return;
                    }

                }
            }

            if (game == "ETS2")
            {
                Game.runETS2();
            }
            else if (game == "ETS2MP")
            {
                Game.runETS2MP();
            }
            else if (game == "ATS")
            {
                Game.runATS();
            }
            else if (game == "ATSMP")
            {
                Game.runATSMP();
            }
        }

        //
        // Server Status
        //

        private void ServerStatus()
        {
            int loc = 12;
            Servers.Clear();
            serverspanel.Controls.Clear();
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
            
            /* NEW CODE; Not ready for release, prep for community ads (vtcs, etc)

            Panel adspanel1 = new Panel();
            adspanel1.BackColor = Color.FromArgb(62, 65, 71);

            adspanel1.Size = new Size(958, 94);
            adspanel1.Anchor = (AnchorStyles.Top);
            adspanel1.Location = new Point(12, loc);
            adspanel1.Left = (this.ClientSize.Width - adspanel1.Width) / 2;
            loc = loc + 109;

            serverspanel.Controls.Add(adspanel1);*/


            //
            // Generate ETS2 Section
            //
            if (Launcher.ETS2Installed)
            { 
                Panel ets2mppanel = new Panel();

                ets2mppanel.BackColor = Color.FromArgb(210, 210, 210);
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
                            addServer((bool)server["online"], (string)server["name"], (string)server["players"], (string)server["maxplayers"], (string)server["game"], (int)server["speedlimiter"], (int)server["queue"], loc);
                            loc = loc + 59;
                        }
                    }
                }
            }

            //
            // Generate ATS Section
            //
            if (Launcher.ATSInstalled)
            { 
                Panel atsmppanel = new Panel();

                atsmppanel.BackColor = Color.FromArgb(210, 210, 210);
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
                            addServer((bool)server["online"], (string)server["name"], (string)server["players"], (string)server["maxplayers"], (string)server["game"], (int)server["speedlimiter"], (int)server["queue"] ,loc);
                            loc = loc + 59;
                        }
                    }
                }
            }
        }

        private void addServer(bool online, string shortname, string players, string maxplayers, string game, int limit, int queue, int loc) {
            
            Panel serverpanel = new Panel();

            serverpanel.BackColor = Color.FromArgb(222, 222, 222);
            serverpanel.Location = new Point(12, loc);
            serverpanel.Size = new Size(976, 44); //976
            serverpanel.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
            serverpanel.Name = "serverpanel" + shortname;

            Label serverid = new Label();

            serverid.BackColor = Color.Black;
            if (online) { serverid.BackColor = Color.FromArgb(160, 197, 95); } else { serverid.BackColor = Color.FromArgb(193, 94, 94); }
            serverid.Location = new Point(0, 0);
            serverid.Size = new Size(81, 44);
            serverid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            serverid.Text = shortname;
            serverid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            serverid.Name = "serverid" + shortname;

            PictureBox playericon = new PictureBox();
            playericon.Location = new Point(95, 13);
            playericon.Size = new Size(15, 17);
            playericon.BackgroundImage = Properties.Resources.players;
            playericon.Name = "playericon" + shortname;

            Label playerslbl = new Label();
            playerslbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            playerslbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            playerslbl.Location = new System.Drawing.Point(115, 13);
            playerslbl.AutoSize = true;
            playerslbl.Text = players + " out of " + maxplayers + " players";
            playerslbl.Name = "playerslbl" + shortname;

            PictureBox queueicon = new PictureBox();
            queueicon.Location = new Point(playerslbl.Location.X + playerslbl.PreferredWidth + 18, 13);
            queueicon.Size = new Size(16, 17);
            queueicon.BackgroundImage = Properties.Resources.queue;
            queueicon.Name = "queueicon" + shortname;

            Label queuelbl = new Label();
            queuelbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            queuelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            queuelbl.Location = new System.Drawing.Point(queueicon.Location.X + queueicon.Width + 6, 12);
            queuelbl.AutoSize = true;
            queuelbl.Text = queue + " players in queue";
            if (queue == 1)
                queuelbl.Text = queue + " player in queue";
            queuelbl.Name = "queuelbl" + shortname;

            PictureBox gameicon = new PictureBox();
            gameicon.Location = new Point(queuelbl.Location.X + queuelbl.PreferredWidth + 18, 13);
            gameicon.Size = new Size(16, 17);
            gameicon.BackgroundImage = Properties.Resources.game;
            gameicon.Name = "gameicon" + shortname;

            Label gamelbl = new Label();
            gamelbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            gamelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            gamelbl.Location = new System.Drawing.Point(gameicon.Location.X + gameicon.Width + 6, 12);
            gamelbl.AutoSize = true;
            gamelbl.Text = game;
            gamelbl.Name = "gamelbl" + shortname;

            Label limitlbl = new Label();

            if (limit != 0)
            {
                PictureBox limiticon = new PictureBox();
                limiticon.Location = new Point(gamelbl.Location.X + gamelbl.PreferredWidth + 18, 13);
                limiticon.Size = new Size(16, 17);
                limiticon.BackgroundImage = Properties.Resources.limit;
                limiticon.Name = "limiticon" + shortname;

                limitlbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
                limitlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
                limitlbl.Location = new System.Drawing.Point(limiticon.Location.X + limiticon.Width + 6, 12);
                limitlbl.AutoSize = true;
                limitlbl.Text = "Speed limiter";
                limitlbl.Name = "limitlbl" + shortname;

                serverpanel.Controls.Add(limiticon);
                serverpanel.Controls.Add(limitlbl);
            }
            else if(!shortname.Contains("Event"))
            {
                PictureBox carsicon = new PictureBox();
                carsicon.Location = new Point(gamelbl.Location.X + gamelbl.PreferredWidth + 18, 13);
                carsicon.Size = new Size(16, 17);
                carsicon.BackgroundImage = Properties.Resources.car;
                carsicon.Name = "carsicon" + shortname;

                Label carslbl = new Label();
                carslbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
                carslbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
                carslbl.Location = new System.Drawing.Point(carsicon.Location.X + carsicon.Width + 6, 12);
                carslbl.AutoSize = true;
                carslbl.Text = "Cars enabled";
                carslbl.Name = "carslbl" + shortname;

                serverpanel.Controls.Add(carsicon);
                serverpanel.Controls.Add(carslbl);
            }

            PictureBox playbutton = new PictureBox();
            playbutton.Location = new Point(864, 0);
            playbutton.Size = new Size(112, 44);
            playbutton.BackgroundImage = Properties.Resources.server_connect_btn;
            playbutton.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            playbutton.Name = "playbutton" + shortname;


            serverspanel.Controls.Add(serverpanel);
            serverpanel.Controls.Add(serverid);
            serverpanel.Controls.Add(playericon);
            serverpanel.Controls.Add(playerslbl);
            serverpanel.Controls.Add(queueicon);
            serverpanel.Controls.Add(queuelbl);
            serverpanel.Controls.Add(gameicon);
            serverpanel.Controls.Add(gamelbl);
            //serverpanel.Controls.Add(playbutton);
        }

        private void toggleCheckbox(object sender, EventArgs e)
        {
            var gname = ((PictureBox)sender).Name.Split('_');
            var name = gname[0];
            var state = gname[1];

            if (state.Equals("checked"))
            {
                ((PictureBox)sender).BackgroundImage = Properties.Resources.checkbox_unchecked;
                ((PictureBox)sender).Name = name + "_unchecked";
            }
            else if (state.Equals("unchecked"))
            {
                ((PictureBox)sender).BackgroundImage = Properties.Resources.checkbox_checked;
                ((PictureBox)sender).Name = name + "_checked";
            }

        }

        private void loadMods()
        {
            int loc = 15;
            mods.Clear();
            modspanel.Controls.Clear();
            JObject results = new JObject();
            using (WebClient client = new WebClient())
            {
                try
                {
                    results = JObject.Parse(client.DownloadString("http://api.thomasakarlsen.com/truckersmplauncher/mods/list"));
                }
                catch (WebException)
                {
                    Console.WriteLine("Unable to connect to Launcher API. Cannot reach servers.");
                    Label errormsg = new Label();
                    errormsg.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
                    errormsg.ForeColor = Color.FromArgb(193, 94, 94);
                    errormsg.Location = new System.Drawing.Point(12, loc - 5);
                    errormsg.Size = new Size(976, 10);
                    errormsg.Text = "Unable to connect to Launcher API";
                    errormsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    errormsg.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left);
                    modspanel.Controls.Add(errormsg);
                    loc = loc + 20;
                }
            }
            Console.WriteLine(results);

            if (results.Count != 0)
            {
                foreach (var result in results["response"])
                {
                    mods.Add(result);
                }
            }

            //
            // Lets generate the visuals!
            // 

            //
            // Generate ETS2MP Section
            //
            if (Launcher.ETS2Installed)
            {
                Panel ets2mppanel = new Panel();

                ets2mppanel.BackColor = Color.FromArgb(210, 210, 210);
                ets2mppanel.Location = new Point(12, loc);
                ets2mppanel.Size = new Size(976, 44);
                ets2mppanel.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);

                Label ets2mptitle = new Label();
                ets2mptitle.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
                ets2mptitle.ForeColor = System.Drawing.Color.FromArgb(62, 65, 71);
                ets2mptitle.Location = new System.Drawing.Point(13, 8);
                ets2mptitle.AutoSize = true;
                ets2mptitle.Text = "Euro Truck Simulator 2 Multiplayer";

                modspanel.Controls.Add(ets2mppanel);
                ets2mppanel.Controls.Add(ets2mptitle);

                loc = loc + 59;

                //
                // Add ETS2MP Mods to list
                //
                if (mods.Count != 0)
                {
                    foreach (var mod in mods)
                    {
                        if ((string)mod["game"] == "ETS2")
                        {
                            addMod((string)mod["name"], (string)mod["description"], (string)mod["creator"], (string)mod["version"], (string)mod["website"], (string)mod["game"], (string)mod["location"], loc);
                            loc = loc + 147;
                        }
                    }
                }
            }

            //
            // Generate ATSMP Section
            //
            if (Launcher.ATSInstalled)
            {
                Panel atsmppanel = new Panel();

                atsmppanel.BackColor = Color.FromArgb(210, 210, 210);
                atsmppanel.Location = new Point(12, loc);
                atsmppanel.Size = new Size(976, 44);
                atsmppanel.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);

                Label atsmptitle = new Label();
                atsmptitle.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
                atsmptitle.ForeColor = System.Drawing.Color.FromArgb(62, 65, 71);
                atsmptitle.Location = new System.Drawing.Point(13, 8);
                atsmptitle.AutoSize = true;
                atsmptitle.Text = "American Truck Simulator Multiplayer";

                modspanel.Controls.Add(atsmppanel);
                atsmppanel.Controls.Add(atsmptitle);

                loc = loc + 59;

                //
                // Add ATSMP Mods to list
                //
                if (mods.Count != 0)
                {
                    foreach (var mod in mods)
                    {
                        if ((string)mod["game"] == "ATS")
                        {
                            addMod((string)mod["name"], (string)mod["description"], (string)mod["creator"], (string)mod["version"], (string)mod["website"], (string)mod["game"], (string)mod["location"], loc);
                            loc = loc + 147;
                        }
                    }
                }
            }
        }

        private void addMod(string name, string description, string creator, string version, string website, string game, string location, int loc)
        {

            Panel modpanel = new Panel();

            modpanel.BackColor = Color.FromArgb(222, 222, 222);
            modpanel.Location = new Point(12, loc);
            modpanel.Size = new Size(976, 44);
            modpanel.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);

            Label namelabel = new Label();
            namelabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            namelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            namelabel.Location = new System.Drawing.Point(12, 12);
            namelabel.AutoSize = true;
            namelabel.Text = name;

            PictureBox creatoricon = new PictureBox();
            creatoricon.Location = new Point(namelabel.Location.X + namelabel.PreferredWidth + 18, 13);
            creatoricon.Size = new Size(15, 17);
            creatoricon.BackgroundImage = Properties.Resources.players;

            Label creatorlabel = new Label();
            creatorlabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            creatorlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            creatorlabel.Location = new System.Drawing.Point(creatoricon.Location.X + creatoricon.Width + 6, 12);
            creatorlabel.AutoSize = true;
            creatorlabel.Text = creator;

            PictureBox versionicon = new PictureBox();
            versionicon.Location = new Point(creatorlabel.Location.X + creatorlabel.PreferredWidth + 18, 13);
            versionicon.Size = new Size(15, 17);
            versionicon.BackgroundImage = Properties.Resources.version;

            Label versionlabel = new Label();
            versionlabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            versionlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            versionlabel.Location = new System.Drawing.Point(versionicon.Location.X + versionicon.Width + 6, 12);
            versionlabel.AutoSize = true;
            versionlabel.Text = version;

            PictureBox gameicon = new PictureBox();
            gameicon.Location = new Point(versionlabel.Location.X + versionlabel.PreferredWidth + 18, 13);
            gameicon.Size = new Size(16, 17);
            gameicon.BackgroundImage = Properties.Resources.game;

            Label gamelbl = new Label();
            gamelbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            gamelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            gamelbl.Location = new System.Drawing.Point(gameicon.Location.X + gameicon.Width + 6, 12);
            gamelbl.AutoSize = true;
            gamelbl.Text = game;

            PictureBox installcheckbox = new PictureBox();
            installcheckbox.Location = new Point(944, 13);
            installcheckbox.Size = new Size(19, 20);
            installcheckbox.Name = name + "_unchecked";
            installcheckbox.BackgroundImage = Properties.Resources.checkbox_unchecked;
            installcheckbox.Click += new System.EventHandler(this.toggleCheckbox);
            installcheckbox.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            //Description

            Panel descriptionpanel = new Panel();
            descriptionpanel.BackColor = Color.FromArgb(216, 216, 216);
            descriptionpanel.Location = new Point(12, (loc + 44));
            descriptionpanel.Size = new Size(976, 88);
            descriptionpanel.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);

            Label descriptionlabel = new Label();
            descriptionlabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            descriptionlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            descriptionlabel.Location = new System.Drawing.Point(6, 6);
            descriptionlabel.AutoSize = false;
            descriptionlabel.Size = new Size(960, 70);
            descriptionlabel.Text = description;

            modspanel.Controls.Add(modpanel);
            modpanel.Controls.Add(namelabel);
            modpanel.Controls.Add(creatoricon);
            modpanel.Controls.Add(creatorlabel);
            modpanel.Controls.Add(versionicon);
            modpanel.Controls.Add(versionlabel);
            modpanel.Controls.Add(gameicon);
            modpanel.Controls.Add(gamelbl);
            modpanel.Controls.Add(installcheckbox);

            modspanel.Controls.Add(descriptionpanel);
            descriptionpanel.Controls.Add(descriptionlabel);
        }
    }
}
