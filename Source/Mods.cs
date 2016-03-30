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
    public partial class Mods : Form
    {
        public JArray mods = new JArray();
        private Main main;
        public Mods(Main Rmain)
        {
            InitializeComponent();
            main = Rmain;
            loadMods();
        }

        private void toggleCheckbox(object sender, EventArgs e)
        {
            var gname = ((PictureBox)sender).Name.Split('_');
            var name = gname[0];
            var state = gname[1];

            if (state.Equals("checked")) {
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
            JObject results = new JObject();
            using (WebClient client = new WebClient())
            {
                try
                {
                    results = JObject.Parse(client.DownloadString("http://api.thomasakarlsen.com/truckersmplauncher/mods/list"));
                }
                catch (WebException e)
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

            modspanel.Controls.Clear(); //Clear the panel, in case of refresh

            //
            // Generate ETS2MP Section
            //
            if (main.ETS2Installed)
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
                            loc = loc + 59;
                        }
                    }
                }
            }

            //
            // Generate ATSMP Section
            //
            if (main.ATSInstalled)
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
                            loc = loc + 59;
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

            modspanel.Controls.Add(modpanel);
            modpanel.Controls.Add(namelabel);
            modpanel.Controls.Add(creatoricon);
            modpanel.Controls.Add(creatorlabel);
            modpanel.Controls.Add(versionicon);
            modpanel.Controls.Add(versionlabel);
            modpanel.Controls.Add(gameicon);
            modpanel.Controls.Add(gamelbl);
            modpanel.Controls.Add(installcheckbox);
        }

    }
}
