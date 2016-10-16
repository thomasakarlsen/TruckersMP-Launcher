namespace truckersmplauncher
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.link_ets2mp = new System.Windows.Forms.Label();
            this.about_launcher = new System.Windows.Forms.Label();
            this.design_creator = new System.Windows.Forms.Label();
            this.Header_Panel = new System.Windows.Forms.Panel();
            this.Mods_btn = new System.Windows.Forms.PictureBox();
            this.radio_btn = new System.Windows.Forms.PictureBox();
            this.Settings_btn = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Footer_Panel = new System.Windows.Forms.Panel();
            this.TruckersMPUpdateProgressLabel = new System.Windows.Forms.Label();
            this.TruckersMPUpdateProgress = new truckersmplauncher.CProgressBar();
            this.Footer_seperator = new System.Windows.Forms.Panel();
            this.modspanel = new System.Windows.Forms.Panel();
            this.serverspanel = new System.Windows.Forms.Panel();
            this.Header_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mods_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radio_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Settings_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.Footer_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // link_ets2mp
            // 
            this.link_ets2mp.AutoSize = true;
            this.link_ets2mp.BackColor = System.Drawing.Color.Transparent;
            this.link_ets2mp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_ets2mp.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_ets2mp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            this.link_ets2mp.Location = new System.Drawing.Point(135, 10);
            this.link_ets2mp.Name = "link_ets2mp";
            this.link_ets2mp.Size = new System.Drawing.Size(206, 18);
            this.link_ets2mp.TabIndex = 48;
            this.link_ets2mp.Text = "TRUCKERSMP OFFICIAL WEBSITE";
            this.link_ets2mp.Click += new System.EventHandler(this.ets2mp_site_link_Click);
            // 
            // about_launcher
            // 
            this.about_launcher.AutoSize = true;
            this.about_launcher.BackColor = System.Drawing.Color.Transparent;
            this.about_launcher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.about_launcher.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about_launcher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            this.about_launcher.Location = new System.Drawing.Point(9, 10);
            this.about_launcher.Name = "about_launcher";
            this.about_launcher.Size = new System.Drawing.Size(122, 18);
            this.about_launcher.TabIndex = 47;
            this.about_launcher.Text = "ABOUT LAUNCHER";
            this.about_launcher.Click += new System.EventHandler(this.About_btn_Click);
            // 
            // design_creator
            // 
            this.design_creator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.design_creator.AutoSize = true;
            this.design_creator.BackColor = System.Drawing.Color.Transparent;
            this.design_creator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.design_creator.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.design_creator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            this.design_creator.Location = new System.Drawing.Point(873, 10);
            this.design_creator.Name = "design_creator";
            this.design_creator.Size = new System.Drawing.Size(115, 18);
            this.design_creator.TabIndex = 49;
            this.design_creator.Text = "DESIGN BY GAMA";
            this.design_creator.Click += new System.EventHandler(this.design_creator_Click);
            // 
            // Header_Panel
            // 
            this.Header_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Header_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            this.Header_Panel.Controls.Add(this.Mods_btn);
            this.Header_Panel.Controls.Add(this.radio_btn);
            this.Header_Panel.Controls.Add(this.Settings_btn);
            this.Header_Panel.Controls.Add(this.Logo);
            this.Header_Panel.Location = new System.Drawing.Point(0, 0);
            this.Header_Panel.Name = "Header_Panel";
            this.Header_Panel.Size = new System.Drawing.Size(1000, 66);
            this.Header_Panel.TabIndex = 60;
            // 
            // Mods_btn
            // 
            this.Mods_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Mods_btn.BackColor = System.Drawing.Color.Transparent;
            this.Mods_btn.BackgroundImage = global::truckersmplauncher.Properties.Resources.mods__disabled_btn;
            this.Mods_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Mods_btn.Cursor = System.Windows.Forms.Cursors.No;
            this.Mods_btn.Enabled = false;
            this.Mods_btn.Location = new System.Drawing.Point(770, 18);
            this.Mods_btn.Name = "Mods_btn";
            this.Mods_btn.Size = new System.Drawing.Size(93, 31);
            this.Mods_btn.TabIndex = 28;
            this.Mods_btn.TabStop = false;
            this.Mods_btn.Click += new System.EventHandler(this.Mods_btn_Click);
            // 
            // radio_btn
            // 
            this.radio_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radio_btn.BackColor = System.Drawing.Color.Transparent;
            this.radio_btn.BackgroundImage = global::truckersmplauncher.Properties.Resources.radio_btn;
            this.radio_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radio_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radio_btn.Location = new System.Drawing.Point(668, 18);
            this.radio_btn.Name = "radio_btn";
            this.radio_btn.Size = new System.Drawing.Size(93, 31);
            this.radio_btn.TabIndex = 64;
            this.radio_btn.TabStop = false;
            this.radio_btn.Click += new System.EventHandler(this.Radio_btn_Click);
            this.radio_btn.MouseEnter += new System.EventHandler(this.Radio_btn_Hover);
            this.radio_btn.MouseLeave += new System.EventHandler(this.Radio_btn_HoverLeave);
            // 
            // Settings_btn
            // 
            this.Settings_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Settings_btn.BackColor = System.Drawing.Color.Transparent;
            this.Settings_btn.BackgroundImage = global::truckersmplauncher.Properties.Resources.settings_btn;
            this.Settings_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Settings_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Settings_btn.Location = new System.Drawing.Point(872, 18);
            this.Settings_btn.Name = "Settings_btn";
            this.Settings_btn.Size = new System.Drawing.Size(119, 31);
            this.Settings_btn.TabIndex = 27;
            this.Settings_btn.TabStop = false;
            this.Settings_btn.Click += new System.EventHandler(this.Settings_btn_Click);
            this.Settings_btn.MouseEnter += new System.EventHandler(this.Settings_btn_Hover);
            this.Settings_btn.MouseLeave += new System.EventHandler(this.Settings_btn_HoverLeave);
            // 
            // Logo
            // 
            this.Logo.BackgroundImage = global::truckersmplauncher.Properties.Resources.launcherlogo;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.Location = new System.Drawing.Point(0, -9);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(289, 84);
            this.Logo.TabIndex = 2;
            this.Logo.TabStop = false;
            // 
            // Footer_Panel
            // 
            this.Footer_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Footer_Panel.Controls.Add(this.TruckersMPUpdateProgressLabel);
            this.Footer_Panel.Controls.Add(this.TruckersMPUpdateProgress);
            this.Footer_Panel.Controls.Add(this.Footer_seperator);
            this.Footer_Panel.Controls.Add(this.about_launcher);
            this.Footer_Panel.Controls.Add(this.link_ets2mp);
            this.Footer_Panel.Controls.Add(this.design_creator);
            this.Footer_Panel.Location = new System.Drawing.Point(0, 473);
            this.Footer_Panel.Name = "Footer_Panel";
            this.Footer_Panel.Size = new System.Drawing.Size(1000, 37);
            this.Footer_Panel.TabIndex = 61;
            // 
            // TruckersMPUpdateProgressLabel
            // 
            this.TruckersMPUpdateProgressLabel.AutoSize = true;
            this.TruckersMPUpdateProgressLabel.BackColor = System.Drawing.Color.Transparent;
            this.TruckersMPUpdateProgressLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TruckersMPUpdateProgressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            this.TruckersMPUpdateProgressLabel.Location = new System.Drawing.Point(713, 12);
            this.TruckersMPUpdateProgressLabel.Name = "TruckersMPUpdateProgressLabel";
            this.TruckersMPUpdateProgressLabel.Size = new System.Drawing.Size(149, 15);
            this.TruckersMPUpdateProgressLabel.TabIndex = 52;
            this.TruckersMPUpdateProgressLabel.Text = "Downloading TruckersMP...";
            this.TruckersMPUpdateProgressLabel.Visible = false;
            // 
            // TruckersMPUpdateProgress
            // 
            this.TruckersMPUpdateProgress.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            this.TruckersMPUpdateProgress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            this.TruckersMPUpdateProgress.FillStyle = truckersmplauncher.CProgressBar.FillStyles.Solid;
            this.TruckersMPUpdateProgress.Location = new System.Drawing.Point(558, 8);
            this.TruckersMPUpdateProgress.Maximum = 100;
            this.TruckersMPUpdateProgress.Minimum = 0;
            this.TruckersMPUpdateProgress.Name = "TruckersMPUpdateProgress";
            this.TruckersMPUpdateProgress.Size = new System.Drawing.Size(150, 22);
            this.TruckersMPUpdateProgress.Step = 10;
            this.TruckersMPUpdateProgress.TabIndex = 53;
            this.TruckersMPUpdateProgress.Value = 0;
            this.TruckersMPUpdateProgress.Visible = false;
            // 
            // Footer_seperator
            // 
            this.Footer_seperator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Footer_seperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Footer_seperator.Location = new System.Drawing.Point(0, 0);
            this.Footer_seperator.Name = "Footer_seperator";
            this.Footer_seperator.Size = new System.Drawing.Size(1000, 1);
            this.Footer_seperator.TabIndex = 50;
            // 
            // modspanel
            // 
            this.modspanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modspanel.AutoScroll = true;
            this.modspanel.AutoScrollMargin = new System.Drawing.Size(0, 15);
            this.modspanel.Location = new System.Drawing.Point(0, 66);
            this.modspanel.Name = "modspanel";
            this.modspanel.Size = new System.Drawing.Size(1000, 407);
            this.modspanel.TabIndex = 63;
            this.modspanel.Visible = false;
            // 
            // serverspanel
            // 
            this.serverspanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverspanel.AutoScroll = true;
            this.serverspanel.AutoScrollMargin = new System.Drawing.Size(0, 15);
            this.serverspanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.serverspanel.Location = new System.Drawing.Point(0, 66);
            this.serverspanel.Name = "serverspanel";
            this.serverspanel.Padding = new System.Windows.Forms.Padding(12);
            this.serverspanel.Size = new System.Drawing.Size(1000, 407);
            this.serverspanel.TabIndex = 62;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1000, 510);
            this.Controls.Add(this.Header_Panel);
            this.Controls.Add(this.Footer_Panel);
            this.Controls.Add(this.serverspanel);
            this.Controls.Add(this.modspanel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1016, 549);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TruckersMP Launcher";
            this.Header_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Mods_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radio_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Settings_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.Footer_Panel.ResumeLayout(false);
            this.Footer_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label link_ets2mp;
        internal System.Windows.Forms.Label about_launcher;
        internal System.Windows.Forms.PictureBox Mods_btn;
        internal System.Windows.Forms.PictureBox Settings_btn;
        internal System.Windows.Forms.Label design_creator;
        private System.Windows.Forms.Panel Header_Panel;
        private System.Windows.Forms.Panel Footer_Panel;
        private System.Windows.Forms.Panel Footer_seperator;
        private System.Windows.Forms.Label TruckersMPUpdateProgressLabel;
        private CProgressBar TruckersMPUpdateProgress;
        private System.Windows.Forms.Panel serverspanel;
        private System.Windows.Forms.Panel modspanel;
        private System.Windows.Forms.PictureBox Logo;
        internal System.Windows.Forms.PictureBox radio_btn;
    }
}

