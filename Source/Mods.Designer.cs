namespace truckersmplauncher
{
    partial class Mods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mods));
            this.subline_title = new System.Windows.Forms.Label();
            this.Header_Panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ModsTitle = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.modspanel = new System.Windows.Forms.Panel();
            this.Header_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // subline_title
            // 
            this.subline_title.AutoSize = true;
            this.subline_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            this.subline_title.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subline_title.ForeColor = System.Drawing.Color.White;
            this.subline_title.Location = new System.Drawing.Point(18, 41);
            this.subline_title.Name = "subline_title";
            this.subline_title.Size = new System.Drawing.Size(216, 18);
            this.subline_title.TabIndex = 61;
            this.subline_title.Text = "UNOFFICIAL LAUNCHER 0.6 ALPHA";
            // 
            // Header_Panel
            // 
            this.Header_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Header_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            this.Header_Panel.Controls.Add(this.label1);
            this.Header_Panel.Controls.Add(this.ModsTitle);
            this.Header_Panel.Controls.Add(this.Logo);
            this.Header_Panel.Location = new System.Drawing.Point(0, 0);
            this.Header_Panel.Name = "Header_Panel";
            this.Header_Panel.Size = new System.Drawing.Size(1000, 66);
            this.Header_Panel.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(240, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 19);
            this.label1.TabIndex = 64;
            this.label1.Text = "Missing a mod? PM @theunknowno on the TruckersMP forum!";
            // 
            // ModsTitle
            // 
            this.ModsTitle.AutoSize = true;
            this.ModsTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            this.ModsTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModsTitle.ForeColor = System.Drawing.Color.White;
            this.ModsTitle.Location = new System.Drawing.Point(239, 9);
            this.ModsTitle.Name = "ModsTitle";
            this.ModsTitle.Size = new System.Drawing.Size(188, 26);
            this.ModsTitle.TabIndex = 63;
            this.ModsTitle.Text = "Supported MP Mods";
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
            // modspanel
            // 
            this.modspanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modspanel.Location = new System.Drawing.Point(0, 66);
            this.modspanel.Name = "modspanel";
            this.modspanel.Size = new System.Drawing.Size(1000, 444);
            this.modspanel.TabIndex = 63;
            // 
            // Mods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1000, 510);
            this.Controls.Add(this.modspanel);
            this.Controls.Add(this.subline_title);
            this.Controls.Add(this.Header_Panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1016, 549);
            this.Name = "Mods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TruckersMP - Mods";
            this.Header_Panel.ResumeLayout(false);
            this.Header_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label subline_title;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel Header_Panel;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label ModsTitle;
        private System.Windows.Forms.Panel modspanel;
    }
}