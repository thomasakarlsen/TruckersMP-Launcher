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
            this.closeDelay_numeric = new System.Windows.Forms.NumericUpDown();
            this.StartSteam_chkbox = new System.Windows.Forms.CheckBox();
            this.ets2_tab = new System.Windows.Forms.TabPage();
            this.ets2_gameoptions = new System.Windows.Forms.GroupBox();
            this.ets_save_format = new System.Windows.Forms.TextBox();
            this.ets_save_format_lbl = new System.Windows.Forms.Label();
            this.ets2_show_fps = new System.Windows.Forms.CheckBox();
            this.ets2_online_loading = new System.Windows.Forms.CheckBox();
            this.ets2_traffic = new System.Windows.Forms.CheckBox();
            this.ets2_console = new System.Windows.Forms.CheckBox();
            this.ets2_launchoptions = new System.Windows.Forms.GroupBox();
            this.ets2_launchargs = new System.Windows.Forms.TextBox();
            this.ets2sin_chkbox = new System.Windows.Forms.CheckBox();
            this.ets2_launchargs_label = new System.Windows.Forms.Label();
            this.ats_tab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ats_save_format = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ats_show_fps = new System.Windows.Forms.CheckBox();
            this.ats_online_loading = new System.Windows.Forms.CheckBox();
            this.ats_traffic = new System.Windows.Forms.CheckBox();
            this.ats_console = new System.Windows.Forms.CheckBox();
            this.ats_launchoptions = new System.Windows.Forms.GroupBox();
            this.ats_launchargs = new System.Windows.Forms.TextBox();
            this.atssin_chkbox = new System.Windows.Forms.CheckBox();
            this.ats_launchargs_label = new System.Windows.Forms.Label();
            this.Header_Panel = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Footer_Panel = new System.Windows.Forms.Panel();
            this.Footer_seperator = new System.Windows.Forms.Panel();
            this.tmp_update_info = new System.Windows.Forms.Label();
            this.Settings_tabControl.SuspendLayout();
            this.Launcher_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeDelay_numeric)).BeginInit();
            this.ets2_tab.SuspendLayout();
            this.ets2_gameoptions.SuspendLayout();
            this.ets2_launchoptions.SuspendLayout();
            this.ats_tab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ats_launchoptions.SuspendLayout();
            this.Header_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.Footer_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AutoUpdate_chkbox
            // 
            this.AutoUpdate_chkbox.AutoSize = true;
            this.AutoUpdate_chkbox.Location = new System.Drawing.Point(8, 64);
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
            this.LauncherClose_chkbox.Size = new System.Drawing.Size(260, 23);
            this.LauncherClose_chkbox.TabIndex = 0;
            this.LauncherClose_chkbox.Text = "Close launcher after            seconds";
            this.LauncherClose_chkbox.UseVisualStyleBackColor = true;
            // 
            // UpdateCheck_btn
            // 
            this.UpdateCheck_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UpdateCheck_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCheck_btn.Location = new System.Drawing.Point(7, 5);
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
            this.Done_btn.Location = new System.Drawing.Point(481, 5);
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
            this.Settings_tabControl.Location = new System.Drawing.Point(0, 72);
            this.Settings_tabControl.Name = "Settings_tabControl";
            this.Settings_tabControl.SelectedIndex = 0;
            this.Settings_tabControl.Size = new System.Drawing.Size(566, 238);
            this.Settings_tabControl.TabIndex = 3;
            // 
            // Launcher_tab
            // 
            this.Launcher_tab.Controls.Add(this.tmp_update_info);
            this.Launcher_tab.Controls.Add(this.closeDelay_numeric);
            this.Launcher_tab.Controls.Add(this.StartSteam_chkbox);
            this.Launcher_tab.Controls.Add(this.LauncherClose_chkbox);
            this.Launcher_tab.Controls.Add(this.AutoUpdate_chkbox);
            this.Launcher_tab.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Launcher_tab.Location = new System.Drawing.Point(4, 28);
            this.Launcher_tab.Name = "Launcher_tab";
            this.Launcher_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Launcher_tab.Size = new System.Drawing.Size(558, 206);
            this.Launcher_tab.TabIndex = 0;
            this.Launcher_tab.Text = "Launcher";
            this.Launcher_tab.UseVisualStyleBackColor = true;
            // 
            // closeDelay_numeric
            // 
            this.closeDelay_numeric.BackColor = System.Drawing.Color.White;
            this.closeDelay_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.closeDelay_numeric.Location = new System.Drawing.Point(165, 8);
            this.closeDelay_numeric.Name = "closeDelay_numeric";
            this.closeDelay_numeric.ReadOnly = true;
            this.closeDelay_numeric.Size = new System.Drawing.Size(37, 23);
            this.closeDelay_numeric.TabIndex = 4;
            this.closeDelay_numeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // StartSteam_chkbox
            // 
            this.StartSteam_chkbox.AutoSize = true;
            this.StartSteam_chkbox.Location = new System.Drawing.Point(8, 35);
            this.StartSteam_chkbox.Name = "StartSteam_chkbox";
            this.StartSteam_chkbox.Size = new System.Drawing.Size(194, 23);
            this.StartSteam_chkbox.TabIndex = 3;
            this.StartSteam_chkbox.Text = "Start steam with launcher";
            this.StartSteam_chkbox.UseVisualStyleBackColor = true;
            // 
            // ets2_tab
            // 
            this.ets2_tab.Controls.Add(this.ets2_gameoptions);
            this.ets2_tab.Controls.Add(this.ets2_launchoptions);
            this.ets2_tab.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ets2_tab.Location = new System.Drawing.Point(4, 28);
            this.ets2_tab.Name = "ets2_tab";
            this.ets2_tab.Size = new System.Drawing.Size(558, 206);
            this.ets2_tab.TabIndex = 2;
            this.ets2_tab.Text = "ETS2";
            this.ets2_tab.UseVisualStyleBackColor = true;
            // 
            // ets2_gameoptions
            // 
            this.ets2_gameoptions.Controls.Add(this.ets_save_format);
            this.ets2_gameoptions.Controls.Add(this.ets_save_format_lbl);
            this.ets2_gameoptions.Controls.Add(this.ets2_show_fps);
            this.ets2_gameoptions.Controls.Add(this.ets2_online_loading);
            this.ets2_gameoptions.Controls.Add(this.ets2_traffic);
            this.ets2_gameoptions.Controls.Add(this.ets2_console);
            this.ets2_gameoptions.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ets2_gameoptions.Location = new System.Drawing.Point(3, 84);
            this.ets2_gameoptions.Name = "ets2_gameoptions";
            this.ets2_gameoptions.Size = new System.Drawing.Size(552, 116);
            this.ets2_gameoptions.TabIndex = 3;
            this.ets2_gameoptions.TabStop = false;
            this.ets2_gameoptions.Text = "Options";
            // 
            // ets_save_format
            // 
            this.ets_save_format.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ets_save_format.Location = new System.Drawing.Point(336, 50);
            this.ets_save_format.Name = "ets_save_format";
            this.ets_save_format.Size = new System.Drawing.Size(34, 27);
            this.ets_save_format.TabIndex = 3;
            // 
            // ets_save_format_lbl
            // 
            this.ets_save_format_lbl.AutoSize = true;
            this.ets_save_format_lbl.Location = new System.Drawing.Point(240, 53);
            this.ets_save_format_lbl.Name = "ets_save_format_lbl";
            this.ets_save_format_lbl.Size = new System.Drawing.Size(90, 19);
            this.ets_save_format_lbl.TabIndex = 6;
            this.ets_save_format_lbl.Text = "Save format:";
            // 
            // ets2_show_fps
            // 
            this.ets2_show_fps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ets2_show_fps.AutoSize = true;
            this.ets2_show_fps.Location = new System.Drawing.Point(146, 52);
            this.ets2_show_fps.Name = "ets2_show_fps";
            this.ets2_show_fps.Size = new System.Drawing.Size(88, 23);
            this.ets2_show_fps.TabIndex = 3;
            this.ets2_show_fps.Text = "Show FPS";
            this.ets2_show_fps.UseVisualStyleBackColor = true;
            // 
            // ets2_online_loading
            // 
            this.ets2_online_loading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ets2_online_loading.AutoSize = true;
            this.ets2_online_loading.Location = new System.Drawing.Point(294, 23);
            this.ets2_online_loading.Name = "ets2_online_loading";
            this.ets2_online_loading.Size = new System.Drawing.Size(177, 23);
            this.ets2_online_loading.TabIndex = 2;
            this.ets2_online_loading.Text = "Online loading screens";
            this.ets2_online_loading.UseVisualStyleBackColor = true;
            // 
            // ets2_traffic
            // 
            this.ets2_traffic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ets2_traffic.AutoSize = true;
            this.ets2_traffic.Location = new System.Drawing.Point(14, 52);
            this.ets2_traffic.Name = "ets2_traffic";
            this.ets2_traffic.Size = new System.Drawing.Size(114, 23);
            this.ets2_traffic.TabIndex = 1;
            this.ets2_traffic.Text = "Enable traffic";
            this.ets2_traffic.UseVisualStyleBackColor = true;
            // 
            // ets2_console
            // 
            this.ets2_console.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ets2_console.AutoSize = true;
            this.ets2_console.Location = new System.Drawing.Point(14, 23);
            this.ets2_console.Name = "ets2_console";
            this.ets2_console.Size = new System.Drawing.Size(274, 23);
            this.ets2_console.TabIndex = 0;
            this.ets2_console.Text = "Enable console and developer camera";
            this.ets2_console.UseVisualStyleBackColor = true;
            // 
            // ets2_launchoptions
            // 
            this.ets2_launchoptions.Controls.Add(this.ets2_launchargs);
            this.ets2_launchoptions.Controls.Add(this.ets2sin_chkbox);
            this.ets2_launchoptions.Controls.Add(this.ets2_launchargs_label);
            this.ets2_launchoptions.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ets2_launchoptions.Location = new System.Drawing.Point(3, 3);
            this.ets2_launchoptions.Name = "ets2_launchoptions";
            this.ets2_launchoptions.Size = new System.Drawing.Size(552, 81);
            this.ets2_launchoptions.TabIndex = 1;
            this.ets2_launchoptions.TabStop = false;
            this.ets2_launchoptions.Text = "Launch arguments";
            // 
            // ets2_launchargs
            // 
            this.ets2_launchargs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ets2_launchargs.Location = new System.Drawing.Point(120, 20);
            this.ets2_launchargs.Name = "ets2_launchargs";
            this.ets2_launchargs.Size = new System.Drawing.Size(425, 27);
            this.ets2_launchargs.TabIndex = 2;
            // 
            // ets2sin_chkbox
            // 
            this.ets2sin_chkbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ets2sin_chkbox.AutoSize = true;
            this.ets2sin_chkbox.Location = new System.Drawing.Point(457, 52);
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
            this.ats_tab.Controls.Add(this.groupBox1);
            this.ats_tab.Controls.Add(this.ats_launchoptions);
            this.ats_tab.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ats_tab.Location = new System.Drawing.Point(4, 28);
            this.ats_tab.Name = "ats_tab";
            this.ats_tab.Padding = new System.Windows.Forms.Padding(3);
            this.ats_tab.Size = new System.Drawing.Size(558, 206);
            this.ats_tab.TabIndex = 1;
            this.ats_tab.Text = "ATS";
            this.ats_tab.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ats_save_format);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ats_show_fps);
            this.groupBox1.Controls.Add(this.ats_online_loading);
            this.groupBox1.Controls.Add(this.ats_traffic);
            this.groupBox1.Controls.Add(this.ats_console);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 116);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // ats_save_format
            // 
            this.ats_save_format.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ats_save_format.Location = new System.Drawing.Point(336, 50);
            this.ats_save_format.Name = "ats_save_format";
            this.ats_save_format.Size = new System.Drawing.Size(34, 27);
            this.ats_save_format.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Save format:";
            // 
            // ats_show_fps
            // 
            this.ats_show_fps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ats_show_fps.AutoSize = true;
            this.ats_show_fps.Location = new System.Drawing.Point(146, 52);
            this.ats_show_fps.Name = "ats_show_fps";
            this.ats_show_fps.Size = new System.Drawing.Size(88, 23);
            this.ats_show_fps.TabIndex = 3;
            this.ats_show_fps.Text = "Show FPS";
            this.ats_show_fps.UseVisualStyleBackColor = true;
            // 
            // ats_online_loading
            // 
            this.ats_online_loading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ats_online_loading.AutoSize = true;
            this.ats_online_loading.Location = new System.Drawing.Point(294, 23);
            this.ats_online_loading.Name = "ats_online_loading";
            this.ats_online_loading.Size = new System.Drawing.Size(177, 23);
            this.ats_online_loading.TabIndex = 2;
            this.ats_online_loading.Text = "Online loading screens";
            this.ats_online_loading.UseVisualStyleBackColor = true;
            // 
            // ats_traffic
            // 
            this.ats_traffic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ats_traffic.AutoSize = true;
            this.ats_traffic.Location = new System.Drawing.Point(14, 52);
            this.ats_traffic.Name = "ats_traffic";
            this.ats_traffic.Size = new System.Drawing.Size(114, 23);
            this.ats_traffic.TabIndex = 1;
            this.ats_traffic.Text = "Enable traffic";
            this.ats_traffic.UseVisualStyleBackColor = true;
            // 
            // ats_console
            // 
            this.ats_console.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ats_console.AutoSize = true;
            this.ats_console.Location = new System.Drawing.Point(14, 23);
            this.ats_console.Name = "ats_console";
            this.ats_console.Size = new System.Drawing.Size(274, 23);
            this.ats_console.TabIndex = 0;
            this.ats_console.Text = "Enable console and developer camera";
            this.ats_console.UseVisualStyleBackColor = true;
            // 
            // ats_launchoptions
            // 
            this.ats_launchoptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ats_launchoptions.Controls.Add(this.ats_launchargs);
            this.ats_launchoptions.Controls.Add(this.atssin_chkbox);
            this.ats_launchoptions.Controls.Add(this.ats_launchargs_label);
            this.ats_launchoptions.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ats_launchoptions.Location = new System.Drawing.Point(3, 3);
            this.ats_launchoptions.Name = "ats_launchoptions";
            this.ats_launchoptions.Size = new System.Drawing.Size(552, 81);
            this.ats_launchoptions.TabIndex = 2;
            this.ats_launchoptions.TabStop = false;
            this.ats_launchoptions.Text = "Launch arguments";
            // 
            // ats_launchargs
            // 
            this.ats_launchargs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ats_launchargs.Location = new System.Drawing.Point(120, 20);
            this.ats_launchargs.Name = "ats_launchargs";
            this.ats_launchargs.Size = new System.Drawing.Size(425, 27);
            this.ats_launchargs.TabIndex = 2;
            // 
            // atssin_chkbox
            // 
            this.atssin_chkbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.atssin_chkbox.AutoSize = true;
            this.atssin_chkbox.Location = new System.Drawing.Point(457, 52);
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
            // Header_Panel
            // 
            this.Header_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Header_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            this.Header_Panel.Controls.Add(this.Logo);
            this.Header_Panel.Controls.Add(this.Settings_tabControl);
            this.Header_Panel.Location = new System.Drawing.Point(0, 0);
            this.Header_Panel.Name = "Header_Panel";
            this.Header_Panel.Size = new System.Drawing.Size(564, 306);
            this.Header_Panel.TabIndex = 63;
            // 
            // Logo
            // 
            this.Logo.BackgroundImage = global::truckersmplauncher.Properties.Resources.launcherlogo;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.Location = new System.Drawing.Point(0, -9);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(289, 84);
            this.Logo.TabIndex = 4;
            this.Logo.TabStop = false;
            // 
            // Footer_Panel
            // 
            this.Footer_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Footer_Panel.Controls.Add(this.Footer_seperator);
            this.Footer_Panel.Controls.Add(this.UpdateCheck_btn);
            this.Footer_Panel.Controls.Add(this.Done_btn);
            this.Footer_Panel.Location = new System.Drawing.Point(0, 306);
            this.Footer_Panel.Name = "Footer_Panel";
            this.Footer_Panel.Size = new System.Drawing.Size(564, 37);
            this.Footer_Panel.TabIndex = 64;
            // 
            // Footer_seperator
            // 
            this.Footer_seperator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Footer_seperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Footer_seperator.Location = new System.Drawing.Point(0, 0);
            this.Footer_seperator.Name = "Footer_seperator";
            this.Footer_seperator.Size = new System.Drawing.Size(564, 1);
            this.Footer_seperator.TabIndex = 50;
            // 
            // tmp_update_info
            // 
            this.tmp_update_info.AutoSize = true;
            this.tmp_update_info.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.tmp_update_info.Location = new System.Drawing.Point(26, 90);
            this.tmp_update_info.Name = "tmp_update_info";
            this.tmp_update_info.Size = new System.Drawing.Size(267, 19);
            this.tmp_update_info.TabIndex = 5;
            this.tmp_update_info.Text = "TruckersMP will be automaticly updated";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(564, 343);
            this.Controls.Add(this.Footer_Panel);
            this.Controls.Add(this.Header_Panel);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TruckersMP Launcher | Settings";
            this.Settings_tabControl.ResumeLayout(false);
            this.Launcher_tab.ResumeLayout(false);
            this.Launcher_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeDelay_numeric)).EndInit();
            this.ets2_tab.ResumeLayout(false);
            this.ets2_gameoptions.ResumeLayout(false);
            this.ets2_gameoptions.PerformLayout();
            this.ets2_launchoptions.ResumeLayout(false);
            this.ets2_launchoptions.PerformLayout();
            this.ats_tab.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ats_launchoptions.ResumeLayout(false);
            this.ats_launchoptions.PerformLayout();
            this.Header_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.Footer_Panel.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox ats_launchoptions;
        private System.Windows.Forms.TextBox ats_launchargs;
        private System.Windows.Forms.CheckBox atssin_chkbox;
        private System.Windows.Forms.Label ats_launchargs_label;
        private System.Windows.Forms.Panel Header_Panel;
        private System.Windows.Forms.Panel Footer_Panel;
        private System.Windows.Forms.Panel Footer_seperator;
        private System.Windows.Forms.CheckBox StartSteam_chkbox;
        private System.Windows.Forms.NumericUpDown closeDelay_numeric;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.GroupBox ets2_gameoptions;
        private System.Windows.Forms.CheckBox ets2_console;
        private System.Windows.Forms.TextBox ets_save_format;
        private System.Windows.Forms.Label ets_save_format_lbl;
        private System.Windows.Forms.CheckBox ets2_show_fps;
        private System.Windows.Forms.CheckBox ets2_online_loading;
        private System.Windows.Forms.CheckBox ets2_traffic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ats_save_format;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ats_show_fps;
        private System.Windows.Forms.CheckBox ats_online_loading;
        private System.Windows.Forms.CheckBox ats_traffic;
        private System.Windows.Forms.CheckBox ats_console;
        private System.Windows.Forms.Label tmp_update_info;
    }
}