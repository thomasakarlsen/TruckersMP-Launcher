namespace ets2mplauncher
{
    partial class FirstTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstTime));
            this.Title_Label = new System.Windows.Forms.Label();
            this.Browse_Dialog = new System.Windows.Forms.FolderBrowserDialog();
            this.Title_Desc = new System.Windows.Forms.Label();
            this.Directories_container = new System.Windows.Forms.GroupBox();
            this.steam_brw_btn = new System.Windows.Forms.Button();
            this.ets2mp_brw_btn = new System.Windows.Forms.Button();
            this.steam_dir_txt = new System.Windows.Forms.TextBox();
            this.ets2mp_dir_txt = new System.Windows.Forms.TextBox();
            this.steam_dir_label = new System.Windows.Forms.Label();
            this.ets2mp_dir_label = new System.Windows.Forms.Label();
            this.Steam_container = new System.Windows.Forms.GroupBox();
            this.SteamLaunchInt_label = new System.Windows.Forms.Label();
            this.SteamLaunchInt_num = new System.Windows.Forms.NumericUpDown();
            this.steam_launch_chkbox = new System.Windows.Forms.CheckBox();
            this.Launcher_container = new System.Windows.Forms.GroupBox();
            this.LauncherClose_chkbox = new System.Windows.Forms.CheckBox();
            this.Done_btn = new System.Windows.Forms.Button();
            this.Directories_container.SuspendLayout();
            this.Steam_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SteamLaunchInt_num)).BeginInit();
            this.Launcher_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title_Label
            // 
            this.Title_Label.AutoSize = true;
            this.Title_Label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_Label.Location = new System.Drawing.Point(93, 8);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.Size = new System.Drawing.Size(348, 23);
            this.Title_Label.TabIndex = 0;
            this.Title_Label.Text = "Welcome to the unoffical ETS2MP Launcher!";
            // 
            // Title_Desc
            // 
            this.Title_Desc.AutoSize = true;
            this.Title_Desc.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_Desc.Location = new System.Drawing.Point(33, 31);
            this.Title_Desc.Name = "Title_Desc";
            this.Title_Desc.Size = new System.Drawing.Size(482, 18);
            this.Title_Desc.TabIndex = 8;
            this.Title_Desc.Text = "Before you start using this launcher, there are a few things we need to setup.\r\n";
            // 
            // Directories_container
            // 
            this.Directories_container.Controls.Add(this.steam_brw_btn);
            this.Directories_container.Controls.Add(this.ets2mp_brw_btn);
            this.Directories_container.Controls.Add(this.steam_dir_txt);
            this.Directories_container.Controls.Add(this.ets2mp_dir_txt);
            this.Directories_container.Controls.Add(this.steam_dir_label);
            this.Directories_container.Controls.Add(this.ets2mp_dir_label);
            this.Directories_container.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Directories_container.Location = new System.Drawing.Point(12, 62);
            this.Directories_container.Name = "Directories_container";
            this.Directories_container.Size = new System.Drawing.Size(526, 92);
            this.Directories_container.TabIndex = 9;
            this.Directories_container.TabStop = false;
            this.Directories_container.Text = "Directories";
            // 
            // steam_brw_btn
            // 
            this.steam_brw_btn.Location = new System.Drawing.Point(445, 53);
            this.steam_brw_btn.Name = "steam_brw_btn";
            this.steam_brw_btn.Size = new System.Drawing.Size(75, 27);
            this.steam_brw_btn.TabIndex = 5;
            this.steam_brw_btn.Text = "Browse";
            this.steam_brw_btn.UseVisualStyleBackColor = true;
            this.steam_brw_btn.Click += new System.EventHandler(this.steam_brw_btn_Click);
            // 
            // ets2mp_brw_btn
            // 
            this.ets2mp_brw_btn.Location = new System.Drawing.Point(445, 20);
            this.ets2mp_brw_btn.Name = "ets2mp_brw_btn";
            this.ets2mp_brw_btn.Size = new System.Drawing.Size(75, 27);
            this.ets2mp_brw_btn.TabIndex = 4;
            this.ets2mp_brw_btn.Text = "Browse";
            this.ets2mp_brw_btn.UseVisualStyleBackColor = true;
            this.ets2mp_brw_btn.Click += new System.EventHandler(this.ets2mp_brw_btn_Click);
            // 
            // steam_dir_txt
            // 
            this.steam_dir_txt.Location = new System.Drawing.Point(77, 53);
            this.steam_dir_txt.Name = "steam_dir_txt";
            this.steam_dir_txt.Size = new System.Drawing.Size(362, 27);
            this.steam_dir_txt.TabIndex = 3;
            // 
            // ets2mp_dir_txt
            // 
            this.ets2mp_dir_txt.Location = new System.Drawing.Point(77, 20);
            this.ets2mp_dir_txt.Name = "ets2mp_dir_txt";
            this.ets2mp_dir_txt.Size = new System.Drawing.Size(362, 27);
            this.ets2mp_dir_txt.TabIndex = 2;
            // 
            // steam_dir_label
            // 
            this.steam_dir_label.AutoSize = true;
            this.steam_dir_label.Location = new System.Drawing.Point(18, 53);
            this.steam_dir_label.Name = "steam_dir_label";
            this.steam_dir_label.Size = new System.Drawing.Size(53, 19);
            this.steam_dir_label.TabIndex = 1;
            this.steam_dir_label.Text = "Steam:";
            // 
            // ets2mp_dir_label
            // 
            this.ets2mp_dir_label.AutoSize = true;
            this.ets2mp_dir_label.Location = new System.Drawing.Point(6, 23);
            this.ets2mp_dir_label.Name = "ets2mp_dir_label";
            this.ets2mp_dir_label.Size = new System.Drawing.Size(65, 19);
            this.ets2mp_dir_label.TabIndex = 0;
            this.ets2mp_dir_label.Text = "ETS2MP:";
            // 
            // Steam_container
            // 
            this.Steam_container.Controls.Add(this.SteamLaunchInt_label);
            this.Steam_container.Controls.Add(this.SteamLaunchInt_num);
            this.Steam_container.Controls.Add(this.steam_launch_chkbox);
            this.Steam_container.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Steam_container.Location = new System.Drawing.Point(12, 160);
            this.Steam_container.Name = "Steam_container";
            this.Steam_container.Size = new System.Drawing.Size(257, 76);
            this.Steam_container.TabIndex = 10;
            this.Steam_container.TabStop = false;
            this.Steam_container.Text = "Steam";
            // 
            // SteamLaunchInt_label
            // 
            this.SteamLaunchInt_label.AutoSize = true;
            this.SteamLaunchInt_label.Location = new System.Drawing.Point(51, 44);
            this.SteamLaunchInt_label.Name = "SteamLaunchInt_label";
            this.SteamLaunchInt_label.Size = new System.Drawing.Size(200, 19);
            this.SteamLaunchInt_label.TabIndex = 2;
            this.SteamLaunchInt_label.Text = "Game launch delay (Seconds)\r\n";
            // 
            // SteamLaunchInt_num
            // 
            this.SteamLaunchInt_num.Location = new System.Drawing.Point(6, 42);
            this.SteamLaunchInt_num.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.SteamLaunchInt_num.Name = "SteamLaunchInt_num";
            this.SteamLaunchInt_num.Size = new System.Drawing.Size(39, 27);
            this.SteamLaunchInt_num.TabIndex = 1;
            this.SteamLaunchInt_num.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // steam_launch_chkbox
            // 
            this.steam_launch_chkbox.AutoSize = true;
            this.steam_launch_chkbox.Checked = true;
            this.steam_launch_chkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.steam_launch_chkbox.Location = new System.Drawing.Point(6, 18);
            this.steam_launch_chkbox.Name = "steam_launch_chkbox";
            this.steam_launch_chkbox.Size = new System.Drawing.Size(153, 23);
            this.steam_launch_chkbox.TabIndex = 0;
            this.steam_launch_chkbox.Text = "Auto launch steam.";
            this.steam_launch_chkbox.UseVisualStyleBackColor = true;
            // 
            // Launcher_container
            // 
            this.Launcher_container.Controls.Add(this.LauncherClose_chkbox);
            this.Launcher_container.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Launcher_container.Location = new System.Drawing.Point(275, 160);
            this.Launcher_container.Name = "Launcher_container";
            this.Launcher_container.Size = new System.Drawing.Size(263, 76);
            this.Launcher_container.TabIndex = 12;
            this.Launcher_container.TabStop = false;
            this.Launcher_container.Text = "Launcher";
            // 
            // LauncherClose_chkbox
            // 
            this.LauncherClose_chkbox.AutoSize = true;
            this.LauncherClose_chkbox.Location = new System.Drawing.Point(7, 21);
            this.LauncherClose_chkbox.Name = "LauncherClose_chkbox";
            this.LauncherClose_chkbox.Size = new System.Drawing.Size(227, 23);
            this.LauncherClose_chkbox.TabIndex = 0;
            this.LauncherClose_chkbox.Text = "Don\'t close after game launch.";
            this.LauncherClose_chkbox.UseVisualStyleBackColor = true;
            // 
            // Done_btn
            // 
            this.Done_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Done_btn.Location = new System.Drawing.Point(457, 242);
            this.Done_btn.Name = "Done_btn";
            this.Done_btn.Size = new System.Drawing.Size(75, 27);
            this.Done_btn.TabIndex = 13;
            this.Done_btn.Text = "Done";
            this.Done_btn.UseVisualStyleBackColor = true;
            this.Done_btn.Click += new System.EventHandler(this.Done_btn_Click);
            // 
            // FirstTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 280);
            this.Controls.Add(this.Directories_container);
            this.Controls.Add(this.Steam_container);
            this.Controls.Add(this.Launcher_container);
            this.Controls.Add(this.Done_btn);
            this.Controls.Add(this.Title_Desc);
            this.Controls.Add(this.Title_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FirstTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ETS2MP Launcher - First time setup";
            this.Load += new System.EventHandler(this.FirstTime_Load);
            this.Directories_container.ResumeLayout(false);
            this.Directories_container.PerformLayout();
            this.Steam_container.ResumeLayout(false);
            this.Steam_container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SteamLaunchInt_num)).EndInit();
            this.Launcher_container.ResumeLayout(false);
            this.Launcher_container.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title_Label;
        private System.Windows.Forms.FolderBrowserDialog Browse_Dialog;
        private System.Windows.Forms.Label Title_Desc;
        private System.Windows.Forms.GroupBox Directories_container;
        private System.Windows.Forms.Button steam_brw_btn;
        private System.Windows.Forms.Button ets2mp_brw_btn;
        private System.Windows.Forms.TextBox steam_dir_txt;
        private System.Windows.Forms.TextBox ets2mp_dir_txt;
        private System.Windows.Forms.Label steam_dir_label;
        private System.Windows.Forms.Label ets2mp_dir_label;
        private System.Windows.Forms.GroupBox Steam_container;
        private System.Windows.Forms.Label SteamLaunchInt_label;
        private System.Windows.Forms.NumericUpDown SteamLaunchInt_num;
        private System.Windows.Forms.CheckBox steam_launch_chkbox;
        private System.Windows.Forms.GroupBox Launcher_container;
        private System.Windows.Forms.CheckBox LauncherClose_chkbox;
        private System.Windows.Forms.Button Done_btn;
    }
}