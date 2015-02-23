namespace ets2mplauncher
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
            this.About_btn = new System.Windows.Forms.PictureBox();
            this.Play_btn = new System.Windows.Forms.PictureBox();
            this.ServerListHeader = new System.Windows.Forms.PictureBox();
            this.Banner = new System.Windows.Forms.PictureBox();
            this.UpdateOrMods_Btn = new System.Windows.Forms.PictureBox();
            this.Server1_Name = new System.Windows.Forms.Label();
            this.ServerContainer = new System.Windows.Forms.Panel();
            this.Server3_Players = new System.Windows.Forms.Label();
            this.Server3_Status = new System.Windows.Forms.Label();
            this.Server3_Name = new System.Windows.Forms.Label();
            this.Server2_Players = new System.Windows.Forms.Label();
            this.Server2_Status = new System.Windows.Forms.Label();
            this.Server2_Name = new System.Windows.Forms.Label();
            this.Server1_Players = new System.Windows.Forms.Label();
            this.Server1_Status = new System.Windows.Forms.Label();
            this.Settings_btn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.About_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServerListHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Banner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateOrMods_Btn)).BeginInit();
            this.ServerContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Settings_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // About_btn
            // 
            this.About_btn.BackColor = System.Drawing.Color.Transparent;
            this.About_btn.Image = global::ets2mplauncher.Properties.Resources.Button_About;
            this.About_btn.Location = new System.Drawing.Point(621, 12);
            this.About_btn.Name = "About_btn";
            this.About_btn.Size = new System.Drawing.Size(87, 37);
            this.About_btn.TabIndex = 0;
            this.About_btn.TabStop = false;
            this.About_btn.Click += new System.EventHandler(this.About_btn_Click);
            // 
            // Play_btn
            // 
            this.Play_btn.BackColor = System.Drawing.Color.Transparent;
            this.Play_btn.Image = global::ets2mplauncher.Properties.Resources.Button_Play;
            this.Play_btn.Location = new System.Drawing.Point(510, 500);
            this.Play_btn.Name = "Play_btn";
            this.Play_btn.Size = new System.Drawing.Size(170, 50);
            this.Play_btn.TabIndex = 1;
            this.Play_btn.TabStop = false;
            this.Play_btn.Click += new System.EventHandler(this.Play_btn_Click);
            // 
            // ServerListHeader
            // 
            this.ServerListHeader.BackColor = System.Drawing.Color.Transparent;
            this.ServerListHeader.BackgroundImage = global::ets2mplauncher.Properties.Resources.ServerStatusHeader;
            this.ServerListHeader.Location = new System.Drawing.Point(12, 97);
            this.ServerListHeader.Name = "ServerListHeader";
            this.ServerListHeader.Size = new System.Drawing.Size(226, 30);
            this.ServerListHeader.TabIndex = 2;
            this.ServerListHeader.TabStop = false;
            // 
            // Banner
            // 
            this.Banner.BackColor = System.Drawing.Color.Transparent;
            this.Banner.Image = global::ets2mplauncher.Properties.Resources.Banner_Telemetry;
            this.Banner.Location = new System.Drawing.Point(12, 377);
            this.Banner.Name = "Banner";
            this.Banner.Size = new System.Drawing.Size(455, 173);
            this.Banner.TabIndex = 6;
            this.Banner.TabStop = false;
            this.Banner.Click += new System.EventHandler(this.Banner_Click);
            // 
            // UpdateOrMods_Btn
            // 
            this.UpdateOrMods_Btn.BackColor = System.Drawing.Color.Transparent;
            this.UpdateOrMods_Btn.Image = global::ets2mplauncher.Properties.Resources.Button_UpdateMods;
            this.UpdateOrMods_Btn.Location = new System.Drawing.Point(510, 444);
            this.UpdateOrMods_Btn.Name = "UpdateOrMods_Btn";
            this.UpdateOrMods_Btn.Size = new System.Drawing.Size(170, 50);
            this.UpdateOrMods_Btn.TabIndex = 7;
            this.UpdateOrMods_Btn.TabStop = false;
            this.UpdateOrMods_Btn.Click += new System.EventHandler(this.UpdateOrMods_Btn_Click);
            // 
            // Server1_Name
            // 
            this.Server1_Name.AutoSize = true;
            this.Server1_Name.BackColor = System.Drawing.Color.Transparent;
            this.Server1_Name.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Server1_Name.ForeColor = System.Drawing.Color.White;
            this.Server1_Name.Location = new System.Drawing.Point(3, 3);
            this.Server1_Name.Name = "Server1_Name";
            this.Server1_Name.Size = new System.Drawing.Size(88, 23);
            this.Server1_Name.TabIndex = 8;
            this.Server1_Name.Text = "Europe #1";
            // 
            // ServerContainer
            // 
            this.ServerContainer.BackColor = System.Drawing.Color.Transparent;
            this.ServerContainer.BackgroundImage = global::ets2mplauncher.Properties.Resources.ServerStatusModule;
            this.ServerContainer.Controls.Add(this.Server3_Players);
            this.ServerContainer.Controls.Add(this.Server3_Status);
            this.ServerContainer.Controls.Add(this.Server3_Name);
            this.ServerContainer.Controls.Add(this.Server2_Players);
            this.ServerContainer.Controls.Add(this.Server2_Status);
            this.ServerContainer.Controls.Add(this.Server2_Name);
            this.ServerContainer.Controls.Add(this.Server1_Players);
            this.ServerContainer.Controls.Add(this.Server1_Status);
            this.ServerContainer.Controls.Add(this.Server1_Name);
            this.ServerContainer.Location = new System.Drawing.Point(12, 127);
            this.ServerContainer.Name = "ServerContainer";
            this.ServerContainer.Size = new System.Drawing.Size(226, 225);
            this.ServerContainer.TabIndex = 9;
            // 
            // Server3_Players
            // 
            this.Server3_Players.AutoSize = true;
            this.Server3_Players.BackColor = System.Drawing.Color.Transparent;
            this.Server3_Players.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Server3_Players.ForeColor = System.Drawing.Color.White;
            this.Server3_Players.Location = new System.Drawing.Point(3, 195);
            this.Server3_Players.Name = "Server3_Players";
            this.Server3_Players.Size = new System.Drawing.Size(102, 23);
            this.Server3_Players.TabIndex = 16;
            this.Server3_Players.Text = "Players: 0/0";
            // 
            // Server3_Status
            // 
            this.Server3_Status.AutoSize = true;
            this.Server3_Status.BackColor = System.Drawing.Color.Transparent;
            this.Server3_Status.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Server3_Status.ForeColor = System.Drawing.Color.White;
            this.Server3_Status.Location = new System.Drawing.Point(3, 175);
            this.Server3_Status.Name = "Server3_Status";
            this.Server3_Status.Size = new System.Drawing.Size(140, 23);
            this.Server3_Status.TabIndex = 15;
            this.Server3_Status.Text = "Status: unknown";
            // 
            // Server3_Name
            // 
            this.Server3_Name.AutoSize = true;
            this.Server3_Name.BackColor = System.Drawing.Color.Transparent;
            this.Server3_Name.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Server3_Name.ForeColor = System.Drawing.Color.White;
            this.Server3_Name.Location = new System.Drawing.Point(3, 155);
            this.Server3_Name.Name = "Server3_Name";
            this.Server3_Name.Size = new System.Drawing.Size(135, 23);
            this.Server3_Name.TabIndex = 14;
            this.Server3_Name.Text = "United States #1";
            // 
            // Server2_Players
            // 
            this.Server2_Players.AutoSize = true;
            this.Server2_Players.BackColor = System.Drawing.Color.Transparent;
            this.Server2_Players.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Server2_Players.ForeColor = System.Drawing.Color.White;
            this.Server2_Players.Location = new System.Drawing.Point(3, 120);
            this.Server2_Players.Name = "Server2_Players";
            this.Server2_Players.Size = new System.Drawing.Size(102, 23);
            this.Server2_Players.TabIndex = 13;
            this.Server2_Players.Text = "Players: 0/0";
            // 
            // Server2_Status
            // 
            this.Server2_Status.AutoSize = true;
            this.Server2_Status.BackColor = System.Drawing.Color.Transparent;
            this.Server2_Status.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Server2_Status.ForeColor = System.Drawing.Color.White;
            this.Server2_Status.Location = new System.Drawing.Point(3, 100);
            this.Server2_Status.Name = "Server2_Status";
            this.Server2_Status.Size = new System.Drawing.Size(140, 23);
            this.Server2_Status.TabIndex = 12;
            this.Server2_Status.Text = "Status: unknown";
            // 
            // Server2_Name
            // 
            this.Server2_Name.AutoSize = true;
            this.Server2_Name.BackColor = System.Drawing.Color.Transparent;
            this.Server2_Name.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Server2_Name.ForeColor = System.Drawing.Color.White;
            this.Server2_Name.Location = new System.Drawing.Point(3, 80);
            this.Server2_Name.Name = "Server2_Name";
            this.Server2_Name.Size = new System.Drawing.Size(181, 23);
            this.Server2_Name.TabIndex = 11;
            this.Server2_Name.Text = "Europe #2 -  Freeroam";
            // 
            // Server1_Players
            // 
            this.Server1_Players.AutoSize = true;
            this.Server1_Players.BackColor = System.Drawing.Color.Transparent;
            this.Server1_Players.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Server1_Players.ForeColor = System.Drawing.Color.White;
            this.Server1_Players.Location = new System.Drawing.Point(3, 43);
            this.Server1_Players.Name = "Server1_Players";
            this.Server1_Players.Size = new System.Drawing.Size(102, 23);
            this.Server1_Players.TabIndex = 10;
            this.Server1_Players.Text = "Players: 0/0";
            // 
            // Server1_Status
            // 
            this.Server1_Status.AutoSize = true;
            this.Server1_Status.BackColor = System.Drawing.Color.Transparent;
            this.Server1_Status.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Server1_Status.ForeColor = System.Drawing.Color.White;
            this.Server1_Status.Location = new System.Drawing.Point(3, 23);
            this.Server1_Status.Name = "Server1_Status";
            this.Server1_Status.Size = new System.Drawing.Size(140, 23);
            this.Server1_Status.TabIndex = 9;
            this.Server1_Status.Text = "Status: unknown";
            // 
            // Settings_btn
            // 
            this.Settings_btn.BackColor = System.Drawing.Color.Transparent;
            this.Settings_btn.Image = global::ets2mplauncher.Properties.Resources.Button_Settings;
            this.Settings_btn.Location = new System.Drawing.Point(528, 12);
            this.Settings_btn.Name = "Settings_btn";
            this.Settings_btn.Size = new System.Drawing.Size(87, 37);
            this.Settings_btn.TabIndex = 10;
            this.Settings_btn.TabStop = false;
            this.Settings_btn.Click += new System.EventHandler(this.Settings_btn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(720, 562);
            this.Controls.Add(this.Settings_btn);
            this.Controls.Add(this.ServerContainer);
            this.Controls.Add(this.UpdateOrMods_Btn);
            this.Controls.Add(this.Banner);
            this.Controls.Add(this.ServerListHeader);
            this.Controls.Add(this.Play_btn);
            this.Controls.Add(this.About_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ETS2MP - Launcher";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.About_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServerListHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Banner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateOrMods_Btn)).EndInit();
            this.ServerContainer.ResumeLayout(false);
            this.ServerContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Settings_btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox About_btn;
        private System.Windows.Forms.PictureBox Play_btn;
        private System.Windows.Forms.PictureBox ServerListHeader;
        private System.Windows.Forms.PictureBox Banner;
        private System.Windows.Forms.PictureBox UpdateOrMods_Btn;
        private System.Windows.Forms.Label Server1_Name;
        private System.Windows.Forms.Panel ServerContainer;
        private System.Windows.Forms.Label Server1_Players;
        private System.Windows.Forms.Label Server1_Status;
        private System.Windows.Forms.Label Server3_Players;
        private System.Windows.Forms.Label Server3_Status;
        private System.Windows.Forms.Label Server3_Name;
        private System.Windows.Forms.Label Server2_Players;
        private System.Windows.Forms.Label Server2_Status;
        private System.Windows.Forms.Label Server2_Name;
        private System.Windows.Forms.PictureBox Settings_btn;

    }
}

