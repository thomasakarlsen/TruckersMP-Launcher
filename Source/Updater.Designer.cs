namespace ets2mplauncher
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
            this.updater_progress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // updater_action
            // 
            this.updater_action.AutoSize = true;
            this.updater_action.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updater_action.Location = new System.Drawing.Point(140, 9);
            this.updater_action.Name = "updater_action";
            this.updater_action.Size = new System.Drawing.Size(187, 24);
            this.updater_action.TabIndex = 0;
            this.updater_action.Text = "Updater is launching!";
            // 
            // updater_progress
            // 
            this.updater_progress.Location = new System.Drawing.Point(12, 47);
            this.updater_progress.Name = "updater_progress";
            this.updater_progress.Size = new System.Drawing.Size(452, 23);
            this.updater_progress.TabIndex = 1;
            // 
            // Updater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 84);
            this.Controls.Add(this.updater_progress);
            this.Controls.Add(this.updater_action);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Updater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ETS2MP Launcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label updater_action;
        private System.Windows.Forms.ProgressBar updater_progress;
    }
}