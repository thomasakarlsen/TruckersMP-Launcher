using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ets2mplauncher
{
    class launcher
    {
        public void Launch()
        {
            LaunchCheck();
            Main main = new Main();
            main.Show();
        }
        public void LaunchCheck() 
        {
            if (Properties.Settings.Default.mploc == "") 
            {
                locpopup frm = new locpopup();
                frm.ShowDialog();
            }
        }
    }
}
