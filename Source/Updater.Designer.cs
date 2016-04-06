namespace truckersmplauncher
{
    partial class Updater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Updater));
            this.updater_action = new System.Windows.Forms.Label();
            this.subline_title = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Header_Panel = new System.Windows.Forms.Panel();
            this.updater_progress = new truckersmplauncher.CProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.Header_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // updater_action
            // 
            this.updater_action.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updater_action.Location = new System.Drawing.Point(100, 90);
            this.updater_action.Name = "updater_action";
            this.updater_action.Size = new System.Drawing.Size(424, 24);
            this.updater_action.TabIndex = 0;
            this.updater_action.Text = "Updater is launching!";
            this.updater_action.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subline_title
            // 
            this.subline_title.AutoSize = true;
            this.subline_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            this.subline_title.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subline_title.ForeColor = System.Drawing.Color.White;
            this.subline_title.Location = new System.Drawing.Point(14, 40);
            this.subline_title.Name = "subline_title";
            this.subline_title.Size = new System.Drawing.Size(226, 18);
            this.subline_title.TabIndex = 61;
            this.subline_title.Text = "UNOFFICIAL LAUNCHER X.XX ALPHA";
            // 
            // Logo
            // 
            this.Logo.BackgroundImage = global::truckersmplauncher.Properties.Resources.logo;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.Location = new System.Drawing.Point(17, -3);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(213, 57);
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // Header_Panel
            // 
            this.Header_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            this.Header_Panel.Controls.Add(this.subline_title);
            this.Header_Panel.Controls.Add(this.Logo);
            this.Header_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header_Panel.Location = new System.Drawing.Point(0, 0);
            this.Header_Panel.Name = "Header_Panel";
            this.Header_Panel.Size = new System.Drawing.Size(608, 66);
            this.Header_Panel.TabIndex = 63;
            // 
            // updater_progress
            // 
            this.updater_progress.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            this.updater_progress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            this.updater_progress.FillStyle = truckersmplauncher.CProgressBar.FillStyles.Solid;
            this.updater_progress.Location = new System.Drawing.Point(100, 120);
            this.updater_progress.Maximum = 100;
            this.updater_progress.Minimum = 0;
            this.updater_progress.Name = "updater_progress";
            this.updater_progress.Size = new System.Drawing.Size(424, 25);
            this.updater_progress.Step = 10;
            this.updater_progress.TabIndex = 64;
            this.updater_progress.Value = 0;
            // 
            // Updater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(608, 175);
            this.Controls.Add(this.updater_progress);
            this.Controls.Add(this.Header_Panel);
            this.Controls.Add(this.updater_action);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Updater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TruckersMP Launcher | Updater";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.Header_Panel.ResumeLayout(false);
            this.Header_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label updater_action;
        internal System.Windows.Forms.Label subline_title;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel Header_Panel;
        private CProgressBar updater_progress;
    }
}