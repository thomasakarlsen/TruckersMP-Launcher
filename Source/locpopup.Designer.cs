namespace ets2mplauncher
{
    partial class locpopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(locpopup));
            this.Title_Label = new System.Windows.Forms.Label();
            this.ets2mp_browse_btn = new System.Windows.Forms.Button();
            this.steam_browse_btn = new System.Windows.Forms.Button();
            this.ets2mp_txtbox = new System.Windows.Forms.TextBox();
            this.steam_txtbox = new System.Windows.Forms.TextBox();
            this.Done_btn = new System.Windows.Forms.Button();
            this.ets2mp_label = new System.Windows.Forms.Label();
            this.steam_label = new System.Windows.Forms.Label();
            this.Browse_Dialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // Title_Label
            // 
            this.Title_Label.AutoSize = true;
            this.Title_Label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_Label.Location = new System.Drawing.Point(59, 9);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.Size = new System.Drawing.Size(373, 23);
            this.Title_Label.TabIndex = 0;
            this.Title_Label.Text = "Please find your ETS2MP and Steam directorys!";
            // 
            // ets2mp_browse_btn
            // 
            this.ets2mp_browse_btn.Location = new System.Drawing.Point(357, 58);
            this.ets2mp_browse_btn.Name = "ets2mp_browse_btn";
            this.ets2mp_browse_btn.Size = new System.Drawing.Size(75, 23);
            this.ets2mp_browse_btn.TabIndex = 1;
            this.ets2mp_browse_btn.Text = "Browse";
            this.ets2mp_browse_btn.UseVisualStyleBackColor = true;
            this.ets2mp_browse_btn.Click += new System.EventHandler(this.ets2mp_browse_btn_Click);
            // 
            // steam_browse_btn
            // 
            this.steam_browse_btn.Location = new System.Drawing.Point(357, 88);
            this.steam_browse_btn.Name = "steam_browse_btn";
            this.steam_browse_btn.Size = new System.Drawing.Size(75, 23);
            this.steam_browse_btn.TabIndex = 2;
            this.steam_browse_btn.Text = "Browse";
            this.steam_browse_btn.UseVisualStyleBackColor = true;
            this.steam_browse_btn.Click += new System.EventHandler(this.steam_browse_btn_Click);
            // 
            // ets2mp_txtbox
            // 
            this.ets2mp_txtbox.Location = new System.Drawing.Point(119, 60);
            this.ets2mp_txtbox.Name = "ets2mp_txtbox";
            this.ets2mp_txtbox.Size = new System.Drawing.Size(232, 20);
            this.ets2mp_txtbox.TabIndex = 3;
            // 
            // steam_txtbox
            // 
            this.steam_txtbox.Location = new System.Drawing.Point(119, 90);
            this.steam_txtbox.Name = "steam_txtbox";
            this.steam_txtbox.Size = new System.Drawing.Size(232, 20);
            this.steam_txtbox.TabIndex = 4;
            // 
            // Done_btn
            // 
            this.Done_btn.Location = new System.Drawing.Point(357, 127);
            this.Done_btn.Name = "Done_btn";
            this.Done_btn.Size = new System.Drawing.Size(75, 23);
            this.Done_btn.TabIndex = 5;
            this.Done_btn.Text = "Done";
            this.Done_btn.UseVisualStyleBackColor = true;
            this.Done_btn.Click += new System.EventHandler(this.Done_btn_Click);
            // 
            // ets2mp_label
            // 
            this.ets2mp_label.AutoSize = true;
            this.ets2mp_label.Location = new System.Drawing.Point(60, 63);
            this.ets2mp_label.Name = "ets2mp_label";
            this.ets2mp_label.Size = new System.Drawing.Size(53, 13);
            this.ets2mp_label.TabIndex = 6;
            this.ets2mp_label.Text = "ETS2MP:";
            // 
            // steam_label
            // 
            this.steam_label.AutoSize = true;
            this.steam_label.Location = new System.Drawing.Point(73, 91);
            this.steam_label.Name = "steam_label";
            this.steam_label.Size = new System.Drawing.Size(40, 13);
            this.steam_label.TabIndex = 7;
            this.steam_label.Text = "Steam:";
            // 
            // locpopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 160);
            this.Controls.Add(this.steam_label);
            this.Controls.Add(this.ets2mp_label);
            this.Controls.Add(this.Done_btn);
            this.Controls.Add(this.steam_txtbox);
            this.Controls.Add(this.ets2mp_txtbox);
            this.Controls.Add(this.steam_browse_btn);
            this.Controls.Add(this.ets2mp_browse_btn);
            this.Controls.Add(this.Title_Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "locpopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ETS2MP - Launcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title_Label;
        private System.Windows.Forms.Button ets2mp_browse_btn;
        private System.Windows.Forms.Button steam_browse_btn;
        private System.Windows.Forms.TextBox ets2mp_txtbox;
        private System.Windows.Forms.TextBox steam_txtbox;
        private System.Windows.Forms.Button Done_btn;
        private System.Windows.Forms.Label ets2mp_label;
        private System.Windows.Forms.Label steam_label;
        private System.Windows.Forms.FolderBrowserDialog Browse_Dialog;
    }
}