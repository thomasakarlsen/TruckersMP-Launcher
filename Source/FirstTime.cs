using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ets2mplauncher
{
    public partial class FirstTime : Form
    {
        public FirstTime()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(FirstTime_FormClosed);
        }

        private void FirstTime_Load(object sender, EventArgs e)
        {

        }

        //
        // Buttons
        //

        private void ets2mp_brw_btn_Click(object sender, EventArgs e)
        {
            if (Browse_Dialog.ShowDialog() == DialogResult.OK)
            {
                ets2mp_dir_txt.Text = Browse_Dialog.SelectedPath;
            }
        }

        private void Done_btn_Click(object sender, EventArgs e)
        {

            if (ets2mp_dir_txt.Text == "")
            {
                MessageBox.Show("It is important to set the ETS2MP directory for this launcher to work!", "ETS2MP Launcher - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Directory
            Properties.Settings.Default.mploc = ets2mp_dir_txt.Text;

            //Launcher
            Properties.Settings.Default.launchclose = LauncherClose_chkbox.Checked;
            Properties.Settings.Default.aplauncher = AutoUpdate_chkbox.Checked;

            Properties.Settings.Default.Save();
            this.Close();
        }

        

        void FirstTime_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ets2mp_dir_txt.Text == "")
            {
                Application.Exit();
            }

            //Directory
            Properties.Settings.Default.mploc = ets2mp_dir_txt.Text;

            //Launcher
            Properties.Settings.Default.launchclose = LauncherClose_chkbox.Checked;
            Properties.Settings.Default.aplauncher = AutoUpdate_chkbox.Checked;

            Properties.Settings.Default.Save();
            this.Close();
        }

    }
}
