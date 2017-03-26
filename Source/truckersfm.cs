using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NAudio;
using NAudio.Wave;
using System.IO;
using System.Net;
using System.Threading;
using System.Globalization;
using Newtonsoft.Json.Linq;

namespace truckersmplauncher
{
    public partial class truckersfm : Form
    {

        enum StreamingPlaybackState
        {
            Stopped,
            Playing,
            Buffering,
            Paused
        }

        public truckersfm()
        {
            InitializeComponent();

            Disposed += MP3StreamingPanel_Disposing;
        }

        void OnVolumeSliderChanged(object sender, EventArgs e)
        {
            if (volumeProvider != null)
            {
                volumeProvider.Volume = trackBar1.Value / 100;
            }
        }

        private BufferedWaveProvider bufferedWaveProvider;
        private IWavePlayer waveOut;
        private volatile StreamingPlaybackState playbackState;
        private volatile bool fullyDownloaded;
        private HttpWebRequest webRequest;
        private VolumeWaveProvider16 volumeProvider;

        delegate void ShowErrorDelegate(string message);

        private void ShowError(string message)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new ShowErrorDelegate(ShowError), message);
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private void StreamMp3(object state)
        {
            fullyDownloaded = false;
            var url = (string)state;
            webRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse resp;
            try
            {
                resp = (HttpWebResponse)webRequest.GetResponse();
            }
            catch (WebException e)
            {
                if (e.Status != WebExceptionStatus.RequestCanceled)
                {
                    ShowError(e.Message);
                }
                return;
            }
            var buffer = new byte[16384 * 4]; // needs to be big enough to hold a decompressed frame

            IMp3FrameDecompressor decompressor = null;
            try
            {
                using (var responseStream = resp.GetResponseStream())
                {
                    var readFullyStream = new ReadFullyStream(responseStream);
                    do
                    {
                        if (IsBufferNearlyFull)
                        {
                            Thread.Sleep(500);
                        }
                        else
                        {
                            Mp3Frame frame;
                            try
                            {
                                frame = Mp3Frame.LoadFromStream(readFullyStream);
                            }
                            catch (EndOfStreamException)
                            {
                                fullyDownloaded = true;
                                // reached the end of the MP3 file / stream
                                break;
                            }
                            catch (WebException)
                            {
                                // probably we have aborted download from the GUI thread
                                break;
                            }
                            if (decompressor == null)
                            {
                                // don't think these details matter too much - just help ACM select the right codec
                                // however, the buffered provider doesn't know what sample rate it is working at
                                // until we have a frame
                                decompressor = CreateFrameDecompressor(frame);
                                bufferedWaveProvider = new BufferedWaveProvider(decompressor.OutputFormat);
                                bufferedWaveProvider.BufferDuration = TimeSpan.FromSeconds(20); // allow us to get well ahead of ourselves
                                //this.bufferedWaveProvider.BufferedDuration = 250;
                            }
                            int decompressed = decompressor.DecompressFrame(frame, buffer, 0);
                            //Debug.WriteLine(String.Format("Decompressed a frame {0}", decompressed));
                            bufferedWaveProvider.AddSamples(buffer, 0, decompressed);
                        }

                    } while (playbackState != StreamingPlaybackState.Stopped);
                    // was doing this in a finally block, but for some reason
                    // we are hanging on response stream .Dispose so never get there
                    decompressor.Dispose();
                }
            }
            finally
            {
                if (decompressor != null)
                {
                    decompressor.Dispose();
                }
            }
        }

        private static IMp3FrameDecompressor CreateFrameDecompressor(Mp3Frame frame)
        {
            WaveFormat waveFormat = new Mp3WaveFormat(frame.SampleRate, frame.ChannelMode == ChannelMode.Mono ? 1 : 2,
                frame.FrameLength, frame.BitRate);
            return new AcmMp3FrameDecompressor(waveFormat);
        }

        private bool IsBufferNearlyFull
        {
            get
            {
                return bufferedWaveProvider != null &&
                       bufferedWaveProvider.BufferLength - bufferedWaveProvider.BufferedBytes
                       < bufferedWaveProvider.WaveFormat.AverageBytesPerSecond / 4;
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (playbackState == StreamingPlaybackState.Stopped)
            {
                playbackState = StreamingPlaybackState.Buffering;
                bufferedWaveProvider = null;
                ThreadPool.QueueUserWorkItem(StreamMp3, "http://radio.truckers.fm/");
                timer1.Enabled = true;
            }
            else if (playbackState == StreamingPlaybackState.Paused)
            {
                playbackState = StreamingPlaybackState.Buffering;
            }
        }

        private void StopPlayback()
        {
            if (playbackState != StreamingPlaybackState.Stopped)
            {
                if (!fullyDownloaded)
                {
                    webRequest.Abort();
                }

                playbackState = StreamingPlaybackState.Stopped;
                if (waveOut != null)
                {
                    waveOut.Stop();
                    waveOut.Dispose();
                    waveOut = null;
                }
                timer1.Enabled = false;
                // n.b. streaming thread may not yet have exited
                Thread.Sleep(500);
            }

            Launcher.TFMRadioPlaying = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (playbackState != StreamingPlaybackState.Stopped)
            {
                if (waveOut == null && bufferedWaveProvider != null)
                {
                    waveOut = CreateWaveOut();
                    waveOut.PlaybackStopped += OnPlaybackStopped;
                    volumeProvider = new VolumeWaveProvider16(bufferedWaveProvider);
                    volumeProvider.Volume = (float)trackBar1.Value / 1000f;
                    waveOut.Init(volumeProvider);
                }
                else if (bufferedWaveProvider != null)
                {
                    var bufferedSeconds = bufferedWaveProvider.BufferedDuration.TotalSeconds;
                    // make it stutter less if we buffer up a decent amount before playing
                    if (bufferedSeconds < 0.5 && playbackState == StreamingPlaybackState.Playing && !fullyDownloaded)
                    {
                        Pause();
                    }
                    else if (bufferedSeconds > 4 && playbackState == StreamingPlaybackState.Buffering)
                    {
                        Play();
                    }
                    else if (fullyDownloaded && bufferedSeconds == 0)
                    {
                        StopPlayback();
                    }
                }

            }
        }

        private void Play()
        {
            waveOut.Play();
            playbackState = StreamingPlaybackState.Playing;

            Launcher.TFMRadioPlaying = true;
        }

        private void Pause()
        {
            playbackState = StreamingPlaybackState.Buffering;
            waveOut.Pause();

            Launcher.TFMRadioPlaying = true;
        }

        private IWavePlayer CreateWaveOut()
        {
            return new WaveOut();
        }

        private void MP3StreamingPanel_Disposing(object sender, EventArgs e)
        {
            StopPlayback();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            if (playbackState == StreamingPlaybackState.Playing || playbackState == StreamingPlaybackState.Buffering)
            {
                waveOut.Pause();
                playbackState = StreamingPlaybackState.Paused;
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            StopPlayback();
        }

        private void OnPlaybackStopped(object sender, StoppedEventArgs e)
        {
            if (e.Exception != null)
            {
                MessageBox.Show(String.Format("Playback Error {0}", e.Exception.Message));
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (volumeProvider != null)
            {
                volumeProvider.Volume = (float)trackBar1.Value / 1000f;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (playbackState != StreamingPlaybackState.Stopped)
            {
                StopPlayback();

                pictureBox2.BackgroundImage = Properties.Resources.tfm_play;
            }
            else
            {
                if (playbackState == StreamingPlaybackState.Stopped)
                {
                    playbackState = StreamingPlaybackState.Buffering;
                    bufferedWaveProvider = null;
                    ThreadPool.QueueUserWorkItem(StreamMp3, "http://radio.truckers.fm/");
                    timer1.Enabled = true;
                }
                else if (playbackState == StreamingPlaybackState.Paused)
                {
                    playbackState = StreamingPlaybackState.Buffering;
                }

                pictureBox2.BackgroundImage = Properties.Resources.tfm_stop;
            }
        }

        private void goto_tfm_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://truckers.fm");
        }

        private void truckersfm_Load(object sender, EventArgs e)
        {
            System.Threading.ThreadPool.QueueUserWorkItem(delegate
            {
                int d = 20;
                while (true)
                {
                    if (Launcher.tfm.IsDisposed)
                        Thread.CurrentThread.Abort();

                    if(d == 20) {
                        d = 0;
                        JArray lastplayed = new JArray();
                        JObject currentDJ = new JObject();
                        using (WebClient client = new WebClient())
                        {
                            try
                            {
                                lastplayed = JArray.Parse(client.DownloadString("https://api.truckers.fm/lastplayed/1"));
                                currentDJ = JObject.Parse(client.DownloadString("https://api.truckers.fm/shows"));

                                string dj = (string)currentDJ["currentdj"]["dj"];
                                string song = (string)lastplayed[0]["song"];
                                string artist = (string)lastplayed[0]["artist"];
                                tfm_currently_playing.Invoke((MethodInvoker)(() => tfm_currently_playing.Text = dj + " playing " + artist + " - " + song));
                            }
                            catch (WebException)
                            {
                                Console.WriteLine("Unable to connect to TruckersFM API. Cannot get TFM Data");
                            }
                        }
                    }

                    d++;
                    Thread.Sleep(500);
                }
            });
        }

        private void open_launcher_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();

            open_launcher.Visible = false;
        }
    }
}
