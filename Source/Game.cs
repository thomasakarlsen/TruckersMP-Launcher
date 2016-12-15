using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Windows.Forms;

namespace truckersmplauncher
{
    class Game
    {

        public static void runETS2MP()
        {
            if (Process.GetProcessesByName("eurotrucks2").Length == 0)
            {
                if (Properties.Settings.Default.ETS2NoIntro)
                {
                    TruckersMP.launch("ETS2", Properties.Settings.Default.ETS2LaunchArguments + " -nointro");
                }
                else
                {
                    TruckersMP.launch("ETS2", Properties.Settings.Default.ETS2LaunchArguments);
                }

                if (Properties.Settings.Default.closeLauncher && !Launcher.TFMRadioPlaying)
                {
                    System.Threading.ThreadPool.QueueUserWorkItem(delegate
                    {
                        System.Threading.Thread.Sleep((int)Properties.Settings.Default.closeDelay * 1000);
                        Application.Exit();
                    });
                }
            }
            else
            {
                MessageBox.Show("Euro Truck Simulator 2 (Multiplayer) is already running!", "TruckersMP Launcher - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public static void runATSMP()
        {
            if (Process.GetProcessesByName("amtrucks").Length == 0)
            {
                if (Properties.Settings.Default.ATSNoIntro)
                {
                    TruckersMP.launch("ATS", Properties.Settings.Default.ATSLaunchArguments + " -nointro");
                }
                else
                {
                    TruckersMP.launch("ATS", Properties.Settings.Default.ATSLaunchArguments);
                }

                if (Properties.Settings.Default.closeLauncher && !Launcher.TFMRadioPlaying)
                {
                    System.Threading.ThreadPool.QueueUserWorkItem(delegate
                    {
                        System.Threading.Thread.Sleep((int)Properties.Settings.Default.closeDelay * 1000);
                        Application.Exit();
                    });
                }
            }
            else
            {
                MessageBox.Show("American Truck Simulator (Multiplayer) is already running!", "TruckersMP Launcher - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public static void runETS2()
        {
            if (Process.GetProcessesByName("eurotrucks2").Length == 0)
            {
                var binPath = "\\bin\\win_x86";

                if (Environment.Is64BitOperatingSystem)
                {
                    binPath = "\\bin\\win_x64";
                    Properties.Settings.Default.ETS2LaunchArguments += " -64bit";
                }

                if (Properties.Settings.Default.ETS2NoIntro)
                {
                    Process process = new Process()
                    {
                        StartInfo = new ProcessStartInfo(Launcher.ETS2Location + binPath + "\\eurotrucks2.exe ", Properties.Settings.Default.ETS2LaunchArguments + " -nointro")
                        {
                            WindowStyle = ProcessWindowStyle.Normal,
                            WorkingDirectory = binPath
                        }
                    };
                    process.Start();
                }
                else
                {
                    Process process = new Process()
                    {
                        StartInfo = new ProcessStartInfo(Launcher.ETS2Location + binPath + "\\eurotrucks2.exe ", Properties.Settings.Default.ETS2LaunchArguments)
                        {
                            WindowStyle = ProcessWindowStyle.Normal,
                            WorkingDirectory = binPath
                        }
                    };
                    process.Start();
                }

                if (Properties.Settings.Default.closeLauncher && !Launcher.TFMRadioPlaying)
                {
                    System.Threading.ThreadPool.QueueUserWorkItem(delegate
                    {
                        System.Threading.Thread.Sleep((int)Properties.Settings.Default.closeDelay * 1000);
                        Application.Exit();
                    });
                }
            }
            else
            {
                MessageBox.Show("Euro Truck Simulator 2 is already running!", "TruckersMP Launcher - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public static void runATS()
        {
            if (Process.GetProcessesByName("amtrucks").Length == 0)
            {
                if (Properties.Settings.Default.ATSNoIntro)
                {
                    Process process = new Process()
                    {
                        StartInfo = new ProcessStartInfo(Launcher.ATSLocation + "\\bin\\win_x64\\amtrucks.exe ", Properties.Settings.Default.ATSLaunchArguments + " -nointro")
                        {
                            WindowStyle = ProcessWindowStyle.Normal,
                            WorkingDirectory = Launcher.ATSLocation + "\\bin\\win_x64"
                        }
                    };
                    process.Start();
                }
                else
                {
                    Process process = new Process()
                    {
                        StartInfo = new ProcessStartInfo(Launcher.ATSLocation + "\\bin\\win_x64\\amtrucks.exe ", Properties.Settings.Default.ATSLaunchArguments)
                        {
                            WindowStyle = ProcessWindowStyle.Normal,
                            WorkingDirectory = Launcher.ATSLocation + "\\bin\\win_x64"
                        }
                    };
                    process.Start();
                }

                if (Properties.Settings.Default.closeLauncher && !Launcher.TFMRadioPlaying)
                {
                    System.Threading.ThreadPool.QueueUserWorkItem(delegate
                    {
                        System.Threading.Thread.Sleep((int)Properties.Settings.Default.closeDelay * 1000);
                        Application.Exit();
                    });
                }
            }
            else
            {
                MessageBox.Show("American Truck Simulator is already running!", "TruckersMP Launcher - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public static Dictionary<string, string> getConfig(string game) {
            string configPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Euro Truck Simulator 2/config.cfg";
            Dictionary<string, string> config = new Dictionary<string, string>();

            if (game == "ATS")
                configPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/American Truck Simulator/config.cfg";

            if (!System.IO.File.Exists(configPath))
                return null;

            string line;
            try
            {

                System.IO.StreamReader file = new System.IO.StreamReader(configPath);
                while ((line = file.ReadLine()) != null)
                {
                    if (line == "")
                        continue;

                    if (line.Substring(0, 4) != "uset")
                        continue;

                    string[] sline = line.Split(null);
                    config.Add(sline[1], (sline[2].Replace("\"", "")));
                }

                file.Close();
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }
            return config;
        }

        public static Boolean writeConfig(string game, Dictionary<string, string> config) {
            string configPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Euro Truck Simulator 2/config.cfg";

            if (game == "ATS")
                configPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/American Truck Simulator/config.cfg";

            if (!System.IO.File.Exists(configPath))
                return false;

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(configPath))
            {
                file.WriteLine("# Written by Unofficial TruckersMP Launcher");
                file.WriteLine("# Tool created by: TheUnknownNO");
                file.WriteLine("");
                file.WriteLine("# prism3d variable config data");
                file.WriteLine("");

                foreach (KeyValuePair<string, string> entry in config)
                {
                    file.WriteLine("uset " + entry.Key + " \"" + entry.Value + "\"");
                }
            }
            return true;
        }
    }
}
