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
    public partial class locpopup : Form
    {
        public locpopup()
        {
            InitializeComponent();
        }

        private void ets2mp_browse_btn_Click(object sender, EventArgs e)
        {
            if (Browse_Dialog.ShowDialog() == DialogResult.OK)
            {
                ets2mp_txtbox.Text = Browse_Dialog.SelectedPath;
            }
        }

        private void steam_browse_btn_Click(object sender, EventArgs e)
        {
            if (Browse_Dialog.ShowDialog() == DialogResult.OK)
            {
                steam_txtbox.Text = Browse_Dialog.SelectedPath;
            }
        }

        private void Done_btn_Click(object sender, EventArgs e)
        {
            if (ets2mp_txtbox.Text == "" && steam_txtbox.Text == "")
            {
                MessageBox.Show("You need to fill in this for the launcher to work!","ERROR");
            }
            else
            {
                Properties.Settings.Default.mploc = ets2mp_txtbox.Text;
                Properties.Settings.Default.steamloc = steam_txtbox.Text;
                Properties.Settings.Default.Save();
                this.Close();
            }
        }
    }
}
