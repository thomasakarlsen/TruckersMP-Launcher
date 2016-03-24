namespace truckersmplauncher
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.AutoUpdate_chkbox = new System.Windows.Forms.CheckBox();
            this.LauncherClose_chkbox = new System.Windows.Forms.CheckBox();
            this.UpdateCheck_btn = new System.Windows.Forms.Button();
            this.Done_btn = new System.Windows.Forms.Button();
            this.Browse_Dialog = new System.Windows.Forms.FolderBrowserDialog();
            this.Settings_tabControl = new System.Windows.Forms.TabControl();
            this.Launcher_tab = new System.Windows.Forms.TabPage();
            this.AutoUpdate_TMP_chkbox = new System.Windows.Forms.CheckBox();
            this.ets2_tab = new System.Windows.Forms.TabPage();
            this.ets2_launchoptions = new System.Windows.Forms.GroupBox();
            this.ets2_launchargs = new System.Windows.Forms.TextBox();
            this.ets2sin_chkbox = new System.Windows.Forms.CheckBox();
            this.ets2_launchargs_label = new System.Windows.Forms.Label();
            this.ats_tab = new System.Windows.Forms.TabPage();
            this.ats_launchoptions = new System.Windows.Forms.GroupBox();
            this.ats_launchargs = new System.Windows.Forms.TextBox();
            this.atssin_chkbox = new System.Windows.Forms.CheckBox();
            this.ats_launchargs_label = new System.Windows.Forms.Label();
            this.Settings_tabControl.SuspendLayout();
            this.Launcher_tab.SuspendLayout();
            this.ets2_tab.SuspendLayout();
            this.ets2_launchoptions.SuspendLayout();
            this.ats_tab.SuspendLayout();
            this.ats_launchoptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // AutoUpdate_chkbox
            // 
            this.AutoUpdate_chkbox.AutoSize = true;
            this.AutoUpdate_chkbox.Location = new System.Drawing.Point(8, 35);
            this.AutoUpdate_chkbox.Name = "AutoUpdate_chkbox";
            this.AutoUpdate_chkbox.Size = new System.Drawing.Size(285, 23);
            this.AutoUpdate_chkbox.TabIndex = 1;
            this.AutoUpdate_chkbox.Text = "Check for launcher updates automaticly";
            this.AutoUpdate_chkbox.UseVisualStyleBackColor = true;
            // 
            // LauncherClose_chkbox
            // 
            this.LauncherClose_chkbox.AutoSize = true;
            this.LauncherClose_chkbox.Location = new System.Drawing.Point(8, 6);
            this.LauncherClose_chkbox.Name = "LauncherClose_chkbox";
            this.LauncherClose_chkbox.Size = new System.Drawing.Size(291, 23);
            this.LauncherClose_chkbox.TabIndex = 0;
            this.LauncherClose_chkbox.Text = "Do not close launcher after game launch";
            this.LauncherClose_chkbox.UseVisualStyleBackColor = true;
            // 
            // UpdateCheck_btn
            // 
            this.UpdateCheck_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UpdateCheck_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCheck_btn.Location = new System.Drawing.Point(4, 280);
            this.UpdateCheck_btn.Name = "UpdateCheck_btn";
            this.UpdateCheck_btn.Size = new System.Drawing.Size(140, 27);
            this.UpdateCheck_btn.TabIndex = 2;
            this.UpdateCheck_btn.Text = "Check for updates";
            this.UpdateCheck_btn.UseVisualStyleBackColor = true;
            this.UpdateCheck_btn.Click += new System.EventHandler(this.UpdateCheck_btn_Click);
            // 
            // Done_btn
            // 
            this.Done_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Done_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Done_btn.Location = new System.Drawing.Point(471, 280);
            this.Done_btn.Name = "Done_btn";
            this.Done_btn.Size = new System.Drawing.Size(75, 27);
            this.Done_btn.TabIndex = 1;
            this.Done_btn.Text = "Done";
            this.Done_btn.UseVisualStyleBackColor = true;
            this.Done_btn.Click += new System.EventHandler(this.Done_btn_Click);
            // 
            // Settings_tabControl
            // 
            this.Settings_tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Settings_tabControl.Controls.Add(this.Launcher_tab);
            this.Settings_tabControl.Controls.Add(this.ets2_tab);
            this.Settings_tabControl.Controls.Add(this.ats_tab);
            this.Settings_tabControl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings_tabControl.Location = new System.Drawing.Point(0, 0);
            this.Settings_tabControl.Name = "Settings_tabControl";
            this.Settings_tabControl.SelectedIndex = 0;
            this.Settings_tabControl.Size = new System.Drawing.Size(550, 274);
            this.Settings_tabControl.TabIndex = 3;
            // 
            // Launcher_tab
            // 
            this.Launcher_tab.Controls.Add(this.AutoUpdate_TMP_chkbox);
            this.Launcher_tab.Controls.Add(this.LauncherClose_chkbox);
            this.Launcher_tab.Controls.Add(this.AutoUpdate_chkbox);
            this.Launcher_tab.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Launcher_tab.Location = new System.Drawing.Point(4, 28);
            this.Launcher_tab.Name = "Launcher_tab";
            this.Launcher_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Launcher_tab.Size = new System.Drawing.Size(542, 242);
            this.Launcher_tab.TabIndex = 0;
            this.Launcher_tab.Text = "Launcher";
            this.Launcher_tab.UseVisualStyleBackColor = true;
            // 
            // AutoUpdate_TMP_chkbox
            // 
            this.AutoUpdate_TMP_chkbox.AutoSize = true;
            this.AutoUpdate_TMP_chkbox.Location = new System.Drawing.Point(8, 64);
            this.AutoUpdate_TMP_chkbox.Name = "AutoUpdate_TMP_chkbox";
            this.AutoUpdate_TMP_chkbox.Size = new System.Drawing.Size(303, 23);
            this.AutoUpdate_TMP_chkbox.TabIndex = 2;
            this.AutoUpdate_TMP_chkbox.Text = "Check for TruckersMP updates automaticly";
            this.AutoUpdate_TMP_chkbox.UseVisualStyleBackColor = true;
            // 
            // ets2_tab
            // 
            this.ets2_tab.Controls.Add(this.ets2_launchoptions);
            this.ets2_tab.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ets2_tab.Location = new System.Drawing.Point(4, 28);
            this.ets2_tab.Name = "ets2_tab";
            this.ets2_tab.Size = new System.Drawing.Size(542, 242);
            this.ets2_tab.TabIndex = 2;
            this.ets2_tab.Text = "ETS2";
            this.ets2_tab.UseVisualStyleBackColor = true;
            // 
            // ets2_launchoptions
            // 
            this.ets2_launchoptions.Controls.Add(this.ets2_launchargs);
            this.ets2_launchoptions.Controls.Add(this.ets2sin_chkbox);
            this.ets2_launchoptions.Controls.Add(this.ets2_launchargs_label);
            this.ets2_launchoptions.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ets2_launchoptions.Location = new System.Drawing.Point(3, 3);
            this.ets2_launchoptions.Name = "ets2_launchoptions";
            this.ets2_launchoptions.Size = new System.Drawing.Size(536, 81);
            this.ets2_launchoptions.TabIndex = 1;
            this.ets2_launchoptions.TabStop = false;
            this.ets2_launchoptions.Text = "Launch arguments";
            // 
            // ets2_launchargs
            // 
            this.ets2_launchargs.Location = new System.Drawing.Point(109, 20);
            this.ets2_launchargs.Name = "ets2_launchargs";
            this.ets2_launchargs.Size = new System.Drawing.Size(421, 27);
            this.ets2_launchargs.TabIndex = 2;
            // 
            // ets2sin_chkbox
            // 
            this.ets2sin_chkbox.AutoSize = true;
            this.ets2sin_chkbox.Location = new System.Drawing.Point(442, 52);
            this.ets2sin_chkbox.Name = "ets2sin_chkbox";
            this.ets2sin_chkbox.Size = new System.Drawing.Size(88, 23);
            this.ets2sin_chkbox.TabIndex = 0;
            this.ets2sin_chkbox.Text = "Skip intro";
            this.ets2sin_chkbox.UseVisualStyleBackColor = true;
            // 
            // ets2_launchargs_label
            // 
            this.ets2_launchargs_label.AutoSize = true;
            this.ets2_launchargs_label.Location = new System.Drawing.Point(6, 23);
            this.ets2_launchargs_label.Name = "ets2_launchargs_label";
            this.ets2_launchargs_label.Size = new System.Drawing.Size(106, 19);
            this.ets2_launchargs_label.TabIndex = 0;
            this.ets2_launchargs_label.Text = "Command line:";
            // 
            // ats_tab
            // 
            this.ats_tab.Controls.Add(this.ats_launchoptions);
            this.ats_tab.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ats_tab.Location = new System.Drawing.Point(4, 28);
            this.ats_tab.Name = "ats_tab";
            this.ats_tab.Padding = new System.Windows.Forms.Padding(3);
            this.ats_tab.Size = new System.Drawing.Size(542, 242);
            this.ats_tab.TabIndex = 1;
            this.ats_tab.Text = "ATS";
            this.ats_tab.UseVisualStyleBackColor = true;
            // 
            // ats_launchoptions
            // 
            this.ats_launchoptions.Controls.Add(this.ats_launchargs);
            this.ats_launchoptions.Controls.Add(this.atssin_chkbox);
            this.ats_launchoptions.Controls.Add(this.ats_launchargs_label);
            this.ats_launchoptions.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ats_launchoptions.Location = new System.Drawing.Point(3, 3);
            this.ats_launchoptions.Name = "ats_launchoptions";
            this.ats_launchoptions.Size = new System.Drawing.Size(536, 81);
            this.ats_launchoptions.TabIndex = 2;
            this.ats_launchoptions.TabStop = false;
            this.ats_launchoptions.Text = "Launch arguments";
            // 
            // ats_launchargs
            // 
            this.ats_launchargs.Location = new System.Drawing.Point(109, 20);
            this.ats_launchargs.Name = "ats_launchargs";
            this.ats_launchargs.Size = new System.Drawing.Size(421, 27);
            this.ats_launchargs.TabIndex = 2;
            // 
            // atssin_chkbox
            // 
            this.atssin_chkbox.AutoSize = true;
            this.atssin_chkbox.Location = new System.Drawing.Point(442, 52);
            this.atssin_chkbox.Name = "atssin_chkbox";
            this.atssin_chkbox.Size = new System.Drawing.Size(88, 23);
            this.atssin_chkbox.TabIndex = 0;
            this.atssin_chkbox.Text = "Skip intro";
            this.atssin_chkbox.UseVisualStyleBackColor = true;
            // 
            // ats_launchargs_label
            // 
            this.ats_launchargs_label.AutoSize = true;
            this.ats_launchargs_label.Location = new System.Drawing.Point(6, 23);
            this.ats_launchargs_label.Name = "ats_launchargs_label";
            this.ats_launchargs_label.Size = new System.Drawing.Size(106, 19);
            this.ats_launchargs_label.TabIndex = 0;
            this.ats_launchargs_label.Text = "Command line:";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 319);
            this.Controls.Add(this.Done_btn);
            this.Controls.Add(this.UpdateCheck_btn);
            this.Controls.Add(this.Settings_tabControl);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TruckersMP Launcher - Settings";
            this.Settings_tabControl.ResumeLayout(false);
            this.Launcher_tab.ResumeLayout(false);
            this.Launcher_tab.PerformLayout();
            this.ets2_tab.ResumeLayout(false);
            this.ets2_launchoptions.ResumeLayout(false);
            this.ets2_launchoptions.PerformLayout();
            this.ats_tab.ResumeLayout(false);
            this.ats_launchoptions.ResumeLayout(false);
            this.ats_launchoptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox LauncherClose_chkbox;
        private System.Windows.Forms.Button UpdateCheck_btn;
        private System.Windows.Forms.Button Done_btn;
        private System.Windows.Forms.FolderBrowserDialog Browse_Dialog;
        private System.Windows.Forms.TabControl Settings_tabControl;
        private System.Windows.Forms.TabPage Launcher_tab;
        private System.Windows.Forms.TabPage ats_tab;
        private System.Windows.Forms.TabPage ets2_tab;
        private System.Windows.Forms.CheckBox ets2sin_chkbox;
        private System.Windows.Forms.CheckBox AutoUpdate_chkbox;
        private System.Windows.Forms.GroupBox ets2_launchoptions;
        private System.Windows.Forms.TextBox ets2_launchargs;
        private System.Windows.Forms.Label ets2_launchargs_label;
        private System.Windows.Forms.CheckBox AutoUpdate_TMP_chkbox;
        private System.Windows.Forms.GroupBox ats_launchoptions;
        private System.Windows.Forms.TextBox ats_launchargs;
        private System.Windows.Forms.CheckBox atssin_chkbox;
        private System.Windows.Forms.Label ats_launchargs_label;
    }
}