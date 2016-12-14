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
        internal struct ProcessInformation
        {
            public IntPtr hProcess;

            public IntPtr hThread;

            public int dwProcessId;

            public int dwThreadId;
        }

        public struct SecurityAttributes
        {
            public int nLength;

            public IntPtr lpSecurityDescriptor;

            public int bInheritHandle;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        private struct Startupinfo
        {
            public int cb;

            public string lpReserved;

            public string lpDesktop;

            public string lpTitle;

            public int dwX;

            public int dwY;

            public int dwXSize;

            public int dwYSize;

            public int dwXCountChars;

            public int dwYCountChars;

            public int dwFillAttribute;

            public int dwFlags;

            public short wShowWindow;

            public short cbReserved2;

            public IntPtr lpReserved2;

            public IntPtr hStdInput;

            public IntPtr hStdOutput;

            public IntPtr hStdError;
        }

        public enum AllocationType
        {
            Commit = 4096,
            Reserve = 8192,
            Decommit = 16384,
            Release = 32768,
            Reset = 524288,
            Physical = 4194304,
            TopDown = 1048576,
            WriteWatch = 2097152,
            LargePages = 536870912
        }

        [Flags]
        public enum MemoryProtection
        {
            Execute = 16,
            ExecuteRead = 32,
            ExecuteReadWrite = 64,
            ExecuteWriteCopy = 128,
            NoAccess = 1,
            ReadOnly = 2,
            ReadWrite = 4,
            WriteCopy = 8,
            GuardModifierflag = 256,
            NoCacheModifierflag = 512,
            WriteCombineModifierflag = 1024
        }

        [Flags]
        public enum FreeType
        {
            Decommit = 16384,
            Release = 32768
        }

        private static Launcher _instance;

        private const uint CreateSuspended = 4u;

        private const uint Infinite = 4294967295u;

        private const uint WaitAbandoned = 128u;

        private const uint WaitObject0 = 0u;

        private const uint WaitTimeout = 258u;

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool CreateProcess(string lpApplicationName, string lpCommandLine, ref Game.SecurityAttributes lpProcessAttributes, ref Game.SecurityAttributes lpThreadAttributes, bool bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, [In] ref Game.Startupinfo lpStartupInfo, out Game.ProcessInformation lpProcessInformation);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern uint ResumeThread(IntPtr hThread);

        [DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
        private static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, Game.AllocationType flAllocationType, Game.MemoryProtection flProtect);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int nSize, out IntPtr lpNumberOfBytesWritten);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, IntPtr lpBuffer, int nSize, out IntPtr lpNumberOfBytesWritten);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        private static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

        [DllImport("kernel32.dll")]
        private static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, out IntPtr lpThreadId);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern uint WaitForSingleObject(IntPtr hHandle, uint dwMilliseconds);

        [DllImport("kernel32.dll")]
        private static extern bool GetExitCodeThread(IntPtr hThread, out uint lpExitCode);

        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success), SuppressUnmanagedCodeSecurity]
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool CloseHandle(IntPtr hObject);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool FreeLibrary(IntPtr hModule);

        [DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
        private static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, int dwSize, Game.FreeType dwFreeType);

        private static string Inject(IntPtr process, string dllPath)
        {
            if (!System.IO.File.Exists(dllPath))
            {
                return "DLL file not found (" + dllPath + ")";
            }
            IntPtr moduleHandle = Game.GetModuleHandle("kernel32.dll");
            if (moduleHandle == IntPtr.Zero)
            {
                return "can not get module handle of kernel32.dll";
            }
            IntPtr procAddress = Game.GetProcAddress(moduleHandle, "LoadLibraryA");
            if (procAddress == IntPtr.Zero)
            {
                return "can not get LoadLibraryA address";
            }
            byte[] bytes = Encoding.ASCII.GetBytes(dllPath + "\0");
            IntPtr intPtr = Game.VirtualAllocEx(process, IntPtr.Zero, (IntPtr)bytes.Length, (Game.AllocationType)12288, Game.MemoryProtection.ReadWrite);
            if (intPtr == IntPtr.Zero)
            {
                return "can not allocate memory";
            }
            IntPtr zero = IntPtr.Zero;
            IntPtr arg_A8_1 = intPtr;
            byte[] expr_A3 = bytes;
            if (!Game.WriteProcessMemory(process, arg_A8_1, expr_A3, expr_A3.Length, out zero))
            {
                return "can not write memory";
            }
            if ((int)zero != bytes.Length)
            {
                return "bytes written and path length does not match";
            }
            IntPtr intPtr3;
            IntPtr intPtr2 = Game.CreateRemoteThread(process, IntPtr.Zero, 0u, procAddress, intPtr, 0u, out intPtr3);
            if (intPtr2 == IntPtr.Zero)
            {
                return "can not create remote thread";
            }
            Game.WaitForSingleObject(intPtr2, 4294967295u);
            uint num;
            Game.GetExitCodeThread(intPtr2, out num);
            if (num == 0u)
            {
                return "initialization of client failed";
            }
            Game.CloseHandle(intPtr2);
            Game.FreeLibrary(moduleHandle);
            return "success";
        }

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
