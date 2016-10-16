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
            this.Header_Panel = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.updater_progress = new truckersmplauncher.CProgressBar();
            this.Header_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
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
            // Header_Panel
            // 
            this.Header_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            this.Header_Panel.Controls.Add(this.Logo);
            this.Header_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header_Panel.Location = new System.Drawing.Point(0, 0);
            this.Header_Panel.Name = "Header_Panel";
            this.Header_Panel.Size = new System.Drawing.Size(608, 66);
            this.Header_Panel.TabIndex = 63;
            // 
            // Logo
            // 
            this.Logo.BackgroundImage = global::truckersmplauncher.Properties.Resources.launcherlogo;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.Location = new System.Drawing.Point(0, -9);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(289, 84);
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
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
            this.Header_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label updater_action;
        private System.Windows.Forms.Panel Header_Panel;
        private CProgressBar updater_progress;
        private System.Windows.Forms.PictureBox Logo;
    }
}