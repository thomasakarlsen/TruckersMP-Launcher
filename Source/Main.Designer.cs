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
            this.Server1Container = new System.Windows.Forms.PictureBox();
            this.Server2Container = new System.Windows.Forms.PictureBox();
            this.Server3Container = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.About_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServerListHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Server1Container)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Server2Container)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Server3Container)).BeginInit();
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
            this.Play_btn.Location = new System.Drawing.Point(538, 500);
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
            // Server1Container
            // 
            this.Server1Container.BackColor = System.Drawing.Color.Transparent;
            this.Server1Container.Image = global::ets2mplauncher.Properties.Resources.ServerStatusModule;
            this.Server1Container.Location = new System.Drawing.Point(12, 127);
            this.Server1Container.Name = "Server1Container";
            this.Server1Container.Size = new System.Drawing.Size(226, 75);
            this.Server1Container.TabIndex = 3;
            this.Server1Container.TabStop = false;
            // 
            // Server2Container
            // 
            this.Server2Container.BackColor = System.Drawing.Color.Transparent;
            this.Server2Container.Image = global::ets2mplauncher.Properties.Resources.ServerStatusModule;
            this.Server2Container.Location = new System.Drawing.Point(12, 202);
            this.Server2Container.Name = "Server2Container";
            this.Server2Container.Size = new System.Drawing.Size(226, 75);
            this.Server2Container.TabIndex = 4;
            this.Server2Container.TabStop = false;
            // 
            // Server3Container
            // 
            this.Server3Container.BackColor = System.Drawing.Color.Transparent;
            this.Server3Container.Image = global::ets2mplauncher.Properties.Resources.ServerStatusModule;
            this.Server3Container.Location = new System.Drawing.Point(12, 277);
            this.Server3Container.Name = "Server3Container";
            this.Server3Container.Size = new System.Drawing.Size(226, 75);
            this.Server3Container.TabIndex = 5;
            this.Server3Container.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(720, 562);
            this.Controls.Add(this.Server3Container);
            this.Controls.Add(this.Server2Container);
            this.Controls.Add(this.Server1Container);
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
            ((System.ComponentModel.ISupportInitialize)(this.Server1Container)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Server2Container)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Server3Container)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox About_btn;
        private System.Windows.Forms.PictureBox Play_btn;
        private System.Windows.Forms.PictureBox ServerListHeader;
        private System.Windows.Forms.PictureBox Server1Container;
        private System.Windows.Forms.PictureBox Server2Container;
        private System.Windows.Forms.PictureBox Server3Container;

    }
}

