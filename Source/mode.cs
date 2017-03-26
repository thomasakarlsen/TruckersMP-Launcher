using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace truckersmplauncher
{
    public partial class Mode : Form
    {
        public Mode()
        {
            InitializeComponent();
        }

        private void advancedMode_btn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.mode = "advanced";
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void simpleMode_btn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.mode = "simple";
            Simple simple = new Simple();
            simple.Show();
            this.Close();
        }
    }
}
