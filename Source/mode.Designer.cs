namespace truckersmplauncher
{
    partial class Mode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mode));
            this.Header_Panel = new System.Windows.Forms.Panel();
            this.title_lbl = new System.Windows.Forms.Label();
            this.simpleMode_btn = new System.Windows.Forms.Button();
            this.advancedMode_btn = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.advancedMode_lbl = new System.Windows.Forms.Label();
            this.simpleMode_lbl = new System.Windows.Forms.Label();
            this.subtitle_lbl = new System.Windows.Forms.Label();
            this.Header_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
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
            this.Header_Panel.Size = new System.Drawing.Size(608, 66);
            this.Header_Panel.TabIndex = 61;
            // 
            // title_lbl
            // 
            this.title_lbl.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            this.title_lbl.Location = new System.Drawing.Point(0, 82);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(608, 39);
            this.title_lbl.TabIndex = 62;
            this.title_lbl.Text = "Which mode would you like?";
            this.title_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // simpleMode_btn
            // 
            this.simpleMode_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleMode_btn.BackgroundImage = global::truckersmplauncher.Properties.Resources.simpleMode;
            this.simpleMode_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.simpleMode_btn.Location = new System.Drawing.Point(315, 154);
            this.simpleMode_btn.Name = "simpleMode_btn";
            this.simpleMode_btn.Size = new System.Drawing.Size(281, 159);
            this.simpleMode_btn.TabIndex = 64;
            this.simpleMode_btn.UseVisualStyleBackColor = true;
            this.simpleMode_btn.Click += new System.EventHandler(this.simpleMode_btn_Click);
            // 
            // advancedMode_btn
            // 
            this.advancedMode_btn.BackgroundImage = global::truckersmplauncher.Properties.Resources.advancedMode;
            this.advancedMode_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.advancedMode_btn.Location = new System.Drawing.Point(12, 154);
            this.advancedMode_btn.Name = "advancedMode_btn";
            this.advancedMode_btn.Size = new System.Drawing.Size(281, 159);
            this.advancedMode_btn.TabIndex = 63;
            this.advancedMode_btn.UseVisualStyleBackColor = true;
            this.advancedMode_btn.Click += new System.EventHandler(this.advancedMode_btn_Click);
            // 
            // Logo
            // 
            this.Logo.BackgroundImage = global::truckersmplauncher.Properties.Resources.launcherlogo;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.Location = new System.Drawing.Point(0, -9);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(289, 84);
            this.Logo.TabIndex = 2;
            this.Logo.TabStop = false;
            // 
            // advancedMode_lbl
            // 
            this.advancedMode_lbl.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advancedMode_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            this.advancedMode_lbl.Location = new System.Drawing.Point(14, 316);
            this.advancedMode_lbl.Name = "advancedMode_lbl";
            this.advancedMode_lbl.Size = new System.Drawing.Size(279, 39);
            this.advancedMode_lbl.TabIndex = 65;
            this.advancedMode_lbl.Text = "Advanced Mode";
            this.advancedMode_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // simpleMode_lbl
            // 
            this.simpleMode_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleMode_lbl.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleMode_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            this.simpleMode_lbl.Location = new System.Drawing.Point(315, 316);
            this.simpleMode_lbl.Name = "simpleMode_lbl";
            this.simpleMode_lbl.Size = new System.Drawing.Size(281, 39);
            this.simpleMode_lbl.TabIndex = 66;
            this.simpleMode_lbl.Text = "Simple Mode";
            this.simpleMode_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // subtitle_lbl
            // 
            this.subtitle_lbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitle_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(71)))));
            this.subtitle_lbl.Location = new System.Drawing.Point(0, 121);
            this.subtitle_lbl.Name = "subtitle_lbl";
            this.subtitle_lbl.Size = new System.Drawing.Size(608, 30);
            this.subtitle_lbl.TabIndex = 67;
            this.subtitle_lbl.Text = "You can always change it in the settings!";
            this.subtitle_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Mode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(608, 372);
            this.Controls.Add(this.subtitle_lbl);
            this.Controls.Add(this.simpleMode_lbl);
            this.Controls.Add(this.advancedMode_lbl);
            this.Controls.Add(this.simpleMode_btn);
            this.Controls.Add(this.advancedMode_btn);
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.Header_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TruckersMP Launcher";
            this.Header_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel Header_Panel;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Button advancedMode_btn;
        private System.Windows.Forms.Button simpleMode_btn;
        private System.Windows.Forms.Label advancedMode_lbl;
        private System.Windows.Forms.Label simpleMode_lbl;
        private System.Windows.Forms.Label subtitle_lbl;
    }
}