using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AxWMPLib;

namespace ets2mplauncher.Kharenis
{
    class EuroTruckRadio
    {
        private string url = @"http://radio.eurotruckradio.com:8002/stream";
        private AxWindowsMediaPlayer player;
        public bool IsPlaying = false;
        public EuroTruckRadio(AxWindowsMediaPlayer player)
        {
            this.player = player;
            this.player.settings.volume = 25;
        }

        public bool StartListening()
        {
            try
            {
                this.player.Visible = true;
                this.player.URL = this.url;
                IsPlaying = true;
            }
            catch(Exception e)
            {
                return false;
            }

            return true;
        }

        public void StopListening()
        {
            this.player.Visible = false;
            this.player.Ctlcontrols.stop();
            IsPlaying = false;
        }
    }
}
