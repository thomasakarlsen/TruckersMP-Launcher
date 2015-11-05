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
            this.ets2mp_brw_btn = new System.Windows.Forms.Button();
            this.ets2mp_dir_txt = new System.Windows.Forms.TextBox();
            this.ets2mp_dir_label = new System.Windows.Forms.Label();
            this.Launcher_container = new System.Windows.Forms.GroupBox();
            this.LauncherClose_chkbox = new System.Windows.Forms.CheckBox();
            this.Done_btn = new System.Windows.Forms.Button();
            this.AutoUpdate_chkbox = new System.Windows.Forms.CheckBox();
            this.Directories_container.SuspendLayout();
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
            this.Directories_container.Controls.Add(this.ets2mp_brw_btn);
            this.Directories_container.Controls.Add(this.ets2mp_dir_txt);
            this.Directories_container.Controls.Add(this.ets2mp_dir_label);
            this.Directories_container.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Directories_container.Location = new System.Drawing.Point(12, 62);
            this.Directories_container.Name = "Directories_container";
            this.Directories_container.Size = new System.Drawing.Size(526, 56);
            this.Directories_container.TabIndex = 9;
            this.Directories_container.TabStop = false;
            this.Directories_container.Text = "Directory";
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
            // ets2mp_dir_txt
            // 
            this.ets2mp_dir_txt.Location = new System.Drawing.Point(77, 20);
            this.ets2mp_dir_txt.Name = "ets2mp_dir_txt";
            this.ets2mp_dir_txt.Size = new System.Drawing.Size(362, 27);
            this.ets2mp_dir_txt.TabIndex = 2;
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
            // Launcher_container
            // 
            this.Launcher_container.Controls.Add(this.AutoUpdate_chkbox);
            this.Launcher_container.Controls.Add(this.LauncherClose_chkbox);
            this.Launcher_container.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Launcher_container.Location = new System.Drawing.Point(12, 124);
            this.Launcher_container.Name = "Launcher_container";
            this.Launcher_container.Size = new System.Drawing.Size(526, 79);
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
            this.Done_btn.Location = new System.Drawing.Point(463, 209);
            this.Done_btn.Name = "Done_btn";
            this.Done_btn.Size = new System.Drawing.Size(75, 27);
            this.Done_btn.TabIndex = 13;
            this.Done_btn.Text = "Done";
            this.Done_btn.UseVisualStyleBackColor = true;
            this.Done_btn.Click += new System.EventHandler(this.Done_btn_Click);
            // 
            // AutoUpdate_chkbox
            // 
            this.AutoUpdate_chkbox.AutoSize = true;
            this.AutoUpdate_chkbox.Checked = true;
            this.AutoUpdate_chkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoUpdate_chkbox.Location = new System.Drawing.Point(7, 50);
            this.AutoUpdate_chkbox.Name = "AutoUpdate_chkbox";
            this.AutoUpdate_chkbox.Size = new System.Drawing.Size(285, 23);
            this.AutoUpdate_chkbox.TabIndex = 1;
            this.AutoUpdate_chkbox.Text = "Check for launcher updates automaticly";
            this.AutoUpdate_chkbox.UseVisualStyleBackColor = true;
            // 
            // FirstTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 244);
            this.Controls.Add(this.Directories_container);
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
        private System.Windows.Forms.Button ets2mp_brw_btn;
        private System.Windows.Forms.TextBox ets2mp_dir_txt;
        private System.Windows.Forms.Label ets2mp_dir_label;
        private System.Windows.Forms.GroupBox Launcher_container;
        private System.Windows.Forms.CheckBox LauncherClose_chkbox;
        private System.Windows.Forms.Button Done_btn;
        private System.Windows.Forms.CheckBox AutoUpdate_chkbox;
    }
}