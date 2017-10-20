namespace truckersmplauncher
{
    partial class Simple
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Simple));
            this.background = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.transparentPanel = new truckersmplauncher.TransparentPanel();
            this.play_ats_btn = new System.Windows.Forms.PictureBox();
            this.play_atsmp_btn = new System.Windows.Forms.PictureBox();
            this.play_ets2_btn = new System.Windows.Forms.PictureBox();
            this.play_ets2mp_btn = new System.Windows.Forms.PictureBox();
            this.About_btn = new System.Windows.Forms.PictureBox();
            this.Settings_btn = new System.Windows.Forms.PictureBox();
            this.TruckersMPUpdateProgress = new truckersmplauncher.CProgressBar();
            this.TruckersMPUpdateProgressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.transparentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.play_ats_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play_atsmp_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play_ets2_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play_ets2mp_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.About_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Settings_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.BackgroundImage = global::truckersmplauncher.Properties.Resources.offlinebg;
            this.background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.background.Controls.Add(this.pictureBox1);
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(1000, 510);
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::truckersmplauncher.Properties.Resources.launcherlogo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 84);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // transparentPanel
            // 
            this.transparentPanel.Controls.Add(this.play_ats_btn);
            this.transparentPanel.Controls.Add(this.play_atsmp_btn);
            this.transparentPanel.Controls.Add(this.play_ets2_btn);
            this.transparentPanel.Controls.Add(this.play_ets2mp_btn);
            this.transparentPanel.Controls.Add(this.About_btn);
            this.transparentPanel.Controls.Add(this.Settings_btn);
            this.transparentPanel.Location = new System.Drawing.Point(0, 398);
            this.transparentPanel.Name = "transparentPanel";
            this.transparentPanel.Size = new System.Drawing.Size(1000, 112);
            this.transparentPanel.TabIndex = 1;
            // 
            // play_ats_btn
            // 
            this.play_ats_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.play_ats_btn.BackColor = System.Drawing.Color.Transparent;
            this.play_ats_btn.BackgroundImage = global::truckersmplauncher.Properties.Resources.play_ats;
            this.play_ats_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.play_ats_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play_ats_btn.Location = new System.Drawing.Point(168, 64);
            this.play_ats_btn.Name = "play_ats_btn";
            this.play_ats_btn.Size = new System.Drawing.Size(150, 31);
            this.play_ats_btn.TabIndex = 62;
            this.play_ats_btn.TabStop = false;
            this.play_ats_btn.Click += new System.EventHandler(this.launchGame);
            this.play_ats_btn.MouseEnter += new System.EventHandler(this.Button_Hover);
            this.play_ats_btn.MouseLeave += new System.EventHandler(this.Button_HoverLeave);
            // 
            // play_atsmp_btn
            // 
            this.play_atsmp_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.play_atsmp_btn.BackColor = System.Drawing.Color.Transparent;
            this.play_atsmp_btn.BackgroundImage = global::truckersmplauncher.Properties.Resources.play_atsmp;
            this.play_atsmp_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.play_atsmp_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play_atsmp_btn.Location = new System.Drawing.Point(168, 18);
            this.play_atsmp_btn.Name = "play_atsmp_btn";
            this.play_atsmp_btn.Size = new System.Drawing.Size(150, 31);
            this.play_atsmp_btn.TabIndex = 61;
            this.play_atsmp_btn.TabStop = false;
            this.play_atsmp_btn.Click += new System.EventHandler(this.launchGame);
            this.play_atsmp_btn.MouseEnter += new System.EventHandler(this.Button_Hover);
            this.play_atsmp_btn.MouseLeave += new System.EventHandler(this.Button_HoverLeave);
            // 
            // play_ets2_btn
            // 
            this.play_ets2_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.play_ets2_btn.BackColor = System.Drawing.Color.Transparent;
            this.play_ets2_btn.BackgroundImage = global::truckersmplauncher.Properties.Resources.play_ets2;
            this.play_ets2_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.play_ets2_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play_ets2_btn.Location = new System.Drawing.Point(12, 64);
            this.play_ets2_btn.Name = "play_ets2_btn";
            this.play_ets2_btn.Size = new System.Drawing.Size(150, 31);
            this.play_ets2_btn.TabIndex = 60;
            this.play_ets2_btn.TabStop = false;
            this.play_ets2_btn.Click += new System.EventHandler(this.launchGame);
            this.play_ets2_btn.MouseEnter += new System.EventHandler(this.Button_Hover);
            this.play_ets2_btn.MouseLeave += new System.EventHandler(this.Button_HoverLeave);
            // 
            // play_ets2mp_btn
            // 
            this.play_ets2mp_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.play_ets2mp_btn.BackColor = System.Drawing.Color.Transparent;
            this.play_ets2mp_btn.BackgroundImage = global::truckersmplauncher.Properties.Resources.play_ets2mp;
            this.play_ets2mp_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.play_ets2mp_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play_ets2mp_btn.Location = new System.Drawing.Point(12, 18);
            this.play_ets2mp_btn.Name = "play_ets2mp_btn";
            this.play_ets2mp_btn.Size = new System.Drawing.Size(150, 31);
            this.play_ets2mp_btn.TabIndex = 59;
            this.play_ets2mp_btn.TabStop = false;
            this.play_ets2mp_btn.Click += new System.EventHandler(this.launchGame);
            this.play_ets2mp_btn.MouseEnter += new System.EventHandler(this.Button_Hover);
            this.play_ets2mp_btn.MouseLeave += new System.EventHandler(this.Button_HoverLeave);
            // 
            // About_btn
            // 
            this.About_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.About_btn.BackColor = System.Drawing.Color.Transparent;
            this.About_btn.BackgroundImage = global::truckersmplauncher.Properties.Resources.about_btn;
            this.About_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.About_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.About_btn.Location = new System.Drawing.Point(869, 64);
            this.About_btn.Name = "About_btn";
            this.About_btn.Size = new System.Drawing.Size(119, 31);
            this.About_btn.TabIndex = 58;
            this.About_btn.TabStop = false;
            this.About_btn.Click += new System.EventHandler(this.About_btn_Click);
            this.About_btn.MouseEnter += new System.EventHandler(this.Button_Hover);
            this.About_btn.MouseLeave += new System.EventHandler(this.Button_HoverLeave);
            // 
            // Settings_btn
            // 
            this.Settings_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Settings_btn.BackColor = System.Drawing.Color.Transparent;
            this.Settings_btn.BackgroundImage = global::truckersmplauncher.Properties.Resources.settings_btn;
            this.Settings_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Settings_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Settings_btn.Location = new System.Drawing.Point(869, 18);
            this.Settings_btn.Name = "Settings_btn";
            this.Settings_btn.Size = new System.Drawing.Size(119, 31);
            this.Settings_btn.TabIndex = 57;
            this.Settings_btn.TabStop = false;
            this.Settings_btn.Click += new System.EventHandler(this.Settings_btn_Click);
            this.Settings_btn.MouseEnter += new System.EventHandler(this.Button_Hover);
            this.Settings_btn.MouseLeave += new System.EventHandler(this.Button_HoverLeave);
            // 
            // TruckersMPUpdateProgress
            // 
            this.TruckersMPUpdateProgress.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            this.TruckersMPUpdateProgress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            this.TruckersMPUpdateProgress.FillStyle = truckersmplauncher.CProgressBar.FillStyles.Solid;
            this.TruckersMPUpdateProgress.Location = new System.Drawing.Point(12, 370);
            this.TruckersMPUpdateProgress.Maximum = 100;
            this.TruckersMPUpdateProgress.Minimum = 0;
            this.TruckersMPUpdateProgress.Name = "TruckersMPUpdateProgress";
            this.TruckersMPUpdateProgress.Size = new System.Drawing.Size(366, 22);
            this.TruckersMPUpdateProgress.Step = 10;
            this.TruckersMPUpdateProgress.TabIndex = 55;
            this.TruckersMPUpdateProgress.Value = 65;
            this.TruckersMPUpdateProgress.Visible = false;
            // 
            // TruckersMPUpdateProgressLabel
            // 
            this.TruckersMPUpdateProgressLabel.AutoSize = true;
            this.TruckersMPUpdateProgressLabel.BackColor = System.Drawing.Color.Transparent;
            this.TruckersMPUpdateProgressLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.TruckersMPUpdateProgressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.TruckersMPUpdateProgressLabel.Location = new System.Drawing.Point(12, 348);
            this.TruckersMPUpdateProgressLabel.Name = "TruckersMPUpdateProgressLabel";
            this.TruckersMPUpdateProgressLabel.Size = new System.Drawing.Size(182, 19);
            this.TruckersMPUpdateProgressLabel.TabIndex = 57;
            this.TruckersMPUpdateProgressLabel.Text = "Downloading TruckersMP...";
            this.TruckersMPUpdateProgressLabel.Visible = false;
            // 
            // Simple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1000, 510);
            this.Controls.Add(this.TruckersMPUpdateProgressLabel);
            this.Controls.Add(this.transparentPanel);
            this.Controls.Add(this.TruckersMPUpdateProgress);
            this.Controls.Add(this.background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1016, 549);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1016, 549);
            this.Name = "Simple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TruckersMP Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.background.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.transparentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.play_ats_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play_atsmp_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play_ets2_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play_ets2mp_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.About_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Settings_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        private TransparentPanel transparentPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CProgressBar TruckersMPUpdateProgress;
        internal System.Windows.Forms.PictureBox Settings_btn;
        internal System.Windows.Forms.PictureBox About_btn;
        internal System.Windows.Forms.PictureBox play_ets2_btn;
        internal System.Windows.Forms.PictureBox play_ets2mp_btn;
        internal System.Windows.Forms.PictureBox play_ats_btn;
        internal System.Windows.Forms.PictureBox play_atsmp_btn;
        private System.Windows.Forms.Label TruckersMPUpdateProgressLabel;
    }
}