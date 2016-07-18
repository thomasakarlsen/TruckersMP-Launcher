using System;
using System.Diagnostics;
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
                    Process.Start(Launcher.TruckersMPLocation + "\\launcher_ets2mp.exe ", "-nointro " + Properties.Settings.Default.ETS2LaunchArguments);
                }
                else
                {
                    Process.Start(Launcher.TruckersMPLocation + "\\launcher_ets2mp.exe ", Properties.Settings.Default.ETS2LaunchArguments);
                }

                if (Properties.Settings.Default.closeLauncher)
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
                    Process.Start(Launcher.TruckersMPLocation + "\\launcher_atsmp.exe ", "-nointro " + Properties.Settings.Default.ATSLaunchArguments);
                }
                else
                {
                    Process.Start(Launcher.TruckersMPLocation + "\\launcher_atsmp.exe ", Properties.Settings.Default.ATSLaunchArguments);
                }

                if (Properties.Settings.Default.closeLauncher)
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
                    Process.Start(Launcher.ETS2Location + binPath + "\\eurotrucks2.exe ", "-nointro " + Properties.Settings.Default.ETS2LaunchArguments);
                }
                else
                {
                    Process.Start(Launcher.ETS2Location + binPath + "\\eurotrucks2.exe ", Properties.Settings.Default.ETS2LaunchArguments);
                }

                if (Properties.Settings.Default.closeLauncher)
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
                    Process.Start(Launcher.ATSLocation + "\\bin\\win_x64\\amtrucks.exe ", "-nointro " + Properties.Settings.Default.ATSLaunchArguments);
                }
                else
                {
                    Process.Start(Launcher.ATSLocation + "\\bin\\win_x64\\amtrucks.exe ", Properties.Settings.Default.ATSLaunchArguments);
                }

                if (Properties.Settings.Default.closeLauncher)
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
    }
}
