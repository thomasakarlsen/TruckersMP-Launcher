namespace truckersmplauncher
{
    partial class truckersfm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(truckersfm));
            this.Header_Panel = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Footer_seperator = new System.Windows.Forms.Panel();
            this.Footer_Panel = new System.Windows.Forms.Panel();
            this.open_launcher = new System.Windows.Forms.Label();
            this.goto_tfm = new System.Windows.Forms.Label();
            this.tfm_currently_playing = new System.Windows.Forms.Label();
            this.Header_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Footer_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header_Panel
            // 
            this.Header_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Header_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            this.Header_Panel.Controls.Add(this.Logo);
            this.Header_Panel.Location = new System.Drawing.Point(0, 0);
            this.Header_Panel.Name = "Header_Panel";
            this.Header_Panel.Size = new System.Drawing.Size(468, 66);
            this.Header_Panel.TabIndex = 64;
            // 
            // Logo
            // 
            this.Logo.BackgroundImage = global::truckersmplauncher.Properties.Resources.launcherlogo;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.Location = new System.Drawing.Point(0, -9);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(289, 84);
            this.Logo.TabIndex = 3;
            this.Logo.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(93, 230);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(363, 45);
            this.trackBar1.TabIndex = 70;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.Value = 300;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.label1.Location = new System.Drawing.Point(93, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 19);
            this.label1.TabIndex = 71;
            this.label1.Text = "Volume";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::truckersmplauncher.Properties.Resources.tfm_play;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(12, 208);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 67);
            this.pictureBox2.TabIndex = 72;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::truckersmplauncher.Properties.Resources.tfm;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(444, 130);
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // Footer_seperator
            // 
            this.Footer_seperator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Footer_seperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Footer_seperator.Location = new System.Drawing.Point(0, 0);
            this.Footer_seperator.Name = "Footer_seperator";
            this.Footer_seperator.Size = new System.Drawing.Size(468, 1);
            this.Footer_seperator.TabIndex = 50;
            // 
            // Footer_Panel
            // 
            this.Footer_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Footer_Panel.Controls.Add(this.open_launcher);
            this.Footer_Panel.Controls.Add(this.goto_tfm);
            this.Footer_Panel.Controls.Add(this.Footer_seperator);
            this.Footer_Panel.Location = new System.Drawing.Point(0, 281);
            this.Footer_Panel.Name = "Footer_Panel";
            this.Footer_Panel.Size = new System.Drawing.Size(468, 37);
            this.Footer_Panel.TabIndex = 65;
            // 
            // open_launcher
            // 
            this.open_launcher.AutoSize = true;
            this.open_launcher.BackColor = System.Drawing.Color.Transparent;
            this.open_launcher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.open_launcher.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_launcher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            this.open_launcher.Location = new System.Drawing.Point(12, 10);
            this.open_launcher.Name = "open_launcher";
            this.open_launcher.Size = new System.Drawing.Size(113, 18);
            this.open_launcher.TabIndex = 52;
            this.open_launcher.Text = "OPEN LAUNCHER";
            this.open_launcher.Visible = false;
            this.open_launcher.Click += new System.EventHandler(this.open_launcher_Click);
            // 
            // goto_tfm
            // 
            this.goto_tfm.AutoSize = true;
            this.goto_tfm.BackColor = System.Drawing.Color.Transparent;
            this.goto_tfm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goto_tfm.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goto_tfm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            this.goto_tfm.Location = new System.Drawing.Point(319, 10);
            this.goto_tfm.Name = "goto_tfm";
            this.goto_tfm.Size = new System.Drawing.Size(137, 18);
            this.goto_tfm.TabIndex = 51;
            this.goto_tfm.Text = "GO TO TRUCKERS.FM";
            this.goto_tfm.Click += new System.EventHandler(this.goto_tfm_Click);
            // 
            // tfm_currently_playing
            // 
            this.tfm_currently_playing.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.tfm_currently_playing.Location = new System.Drawing.Point(12, 165);
            this.tfm_currently_playing.Name = "tfm_currently_playing";
            this.tfm_currently_playing.Size = new System.Drawing.Size(444, 37);
            this.tfm_currently_playing.TabIndex = 73;
            this.tfm_currently_playing.Text = "Loading...";
            this.tfm_currently_playing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // truckersfm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(468, 318);
            this.Controls.Add(this.tfm_currently_playing);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Footer_Panel);
            this.Controls.Add(this.Header_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "truckersfm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TruckersMP Launcher | Truckers.FM Player";
            this.Load += new System.EventHandler(this.truckersfm_Load);
            this.Header_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Footer_Panel.ResumeLayout(false);
            this.Footer_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Header_Panel;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel Footer_seperator;
        private System.Windows.Forms.Panel Footer_Panel;
        internal System.Windows.Forms.Label goto_tfm;
        private System.Windows.Forms.Label tfm_currently_playing;
        internal System.Windows.Forms.Label open_launcher;
    }
}