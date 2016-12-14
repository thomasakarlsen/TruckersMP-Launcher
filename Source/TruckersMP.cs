using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Security;
using System.Runtime.ConstrainedExecution;

namespace truckersmplauncher
{
    public class TruckersMP
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
        public static Int32 latestVersion() {
            JObject versiondata = new JObject();
            using (WebClient client = new WebClient())
            {
                try
                {
                    versiondata = JObject.Parse(client.DownloadString("https://api.truckersmp.com/v2/version/"));
                }
                catch (WebException)
                {
                    Console.WriteLine("Unable to connect to TruckersMP. Cannot check for TMP version");
                    return 0;
                }
            }
            return (Int32)versiondata["numeric"];
        }

        public static Int32 checkUpdate() {
            JObject versiondata = new JObject();
            using (WebClient client = new WebClient())
            {
                try
                {
                    versiondata = JObject.Parse(client.DownloadString("https://api.truckersmp.com/v2/version/"));
                }
                catch (WebException)
                {
                    Console.WriteLine("Unable to connect to TruckersMP. Cannot check for new TMP version");
                    return 0;
                }
            }

            if (System.IO.File.Exists(Launcher.TruckersMPLocation + "\\core_ets2mp.dll"))
            {
                var localchecksum = MD5(Launcher.TruckersMPLocation + "\\core_ets2mp.dll");
                var gotchecksum = (string)versiondata["ets2mp_checksum"]["dll"];

                if (String.Compare(gotchecksum, localchecksum, true) != 0)
                {

                    return (Int32)versiondata["numeric"];
                }
            }

            if (System.IO.File.Exists(Launcher.TruckersMPLocation + "\\core_atsmp.dll"))
            {
                var localchecksum = MD5(Launcher.TruckersMPLocation + "\\core_atsmp.dll");
                var gotchecksum = (string)versiondata["atsmp_checksum"]["dll"];

                if (String.Compare(gotchecksum, localchecksum, true) != 0)
                {
                    return (Int32)versiondata["numeric"];
                }
            }

            return 0;
        }

        public static void install(CProgressBar TruckersMPUpdateProgress, Label TruckersMPUpdateProgressLabel) {

            var version = latestVersion();

            TruckersMPUpdateProgress.Visible = true;
            TruckersMPUpdateProgressLabel.Visible = true;

            TruckersMPUpdateProgress.Maximum = 125;

            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TMPLauncher")) {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TMPLauncher");
            }

            using (WebClient downloadClient = new WebClient())
            {
                downloadClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(delegate (object sender, DownloadProgressChangedEventArgs e)
                {
                    TruckersMPUpdateProgress.Value = e.ProgressPercentage;
                });

                downloadClient.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler
                    (delegate (object sender, System.ComponentModel.AsyncCompletedEventArgs e)
                    {
                        if (e.Error == null && !e.Cancelled)
                        {
                            System.Threading.ThreadPool.QueueUserWorkItem(delegate
                            {
                                TruckersMPUpdateProgressLabel.Invoke((MethodInvoker)(() => TruckersMPUpdateProgressLabel.Text = "Unpacking TruckersMP..."));
                                System.IO.Compression.ZipFile.ExtractToDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TMPLauncher\\client_" + version + ".zip", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TMPLauncher\\client_" + version);
                                TruckersMPUpdateProgress.Value = 110;

                                TruckersMPUpdateProgressLabel.Invoke((MethodInvoker)(() => TruckersMPUpdateProgressLabel.Text = "Installing TruckersMP..."));

                                ProcessStartInfo startInfo = new ProcessStartInfo();
                                startInfo.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TMPLauncher\\client_" + version + "\\Install TruckersMP.exe";
                                
                                try
                                {
                                    using (Process exeProcess = Process.Start(startInfo))
                                    {
                                        exeProcess.WaitForExit();
                                    }
                                }
                                catch
                                {
                                   // Log Error
                                }
                                TruckersMPUpdateProgress.Value = 120;

                                TruckersMPUpdateProgressLabel.Invoke((MethodInvoker)(() => TruckersMPUpdateProgressLabel.Text = "Cleaning up..."));
                                try
                                {
                                    System.IO.Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TMPLauncher\\client_" + version, true);
                                    System.IO.File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TMPLauncher\\client_" + version + ".zip");
                                }
                                catch
                                {
                                    // Log error.
                                }

                                TruckersMPUpdateProgress.Value = 125;

                                TruckersMPUpdateProgress.Invoke((MethodInvoker)(() => TruckersMPUpdateProgress.Visible = false));
                                TruckersMPUpdateProgressLabel.Invoke((MethodInvoker)(() => TruckersMPUpdateProgressLabel.Text = "TruckersMP Installed!"));

                                System.Threading.Thread.Sleep(6000);
                                TruckersMPUpdateProgressLabel.Invoke((MethodInvoker)(() => TruckersMPUpdateProgressLabel.Visible = false));
                            });

                        }
                    });

                downloadClient.DownloadFileAsync(new Uri("http://download.ets2mp.com/client/client_" + version + ".zip"), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TMPLauncher\\client_" + version + ".zip");
            }
        }

        public static void update(CProgressBar TruckersMPUpdateProgress, Label TruckersMPUpdateProgressLabel, Int32 version, bool runGame = false, String game = "")
        {

            TruckersMPUpdateProgress.Visible = true;
            TruckersMPUpdateProgressLabel.Visible = true;

            TruckersMPUpdateProgress.Maximum = 125;

            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TMPLauncher"))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TMPLauncher");
            }

            using (WebClient downloadClient = new WebClient())
            {
                downloadClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(delegate (object sender, DownloadProgressChangedEventArgs e)
                {
                    TruckersMPUpdateProgress.Value = e.ProgressPercentage;
                });

                downloadClient.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler
                    (delegate (object sender, System.ComponentModel.AsyncCompletedEventArgs e)
                    {
                        if (e.Error == null && !e.Cancelled)
                        {
                            System.Threading.ThreadPool.QueueUserWorkItem(delegate
                            {
                                TruckersMPUpdateProgressLabel.Invoke((MethodInvoker)(() => TruckersMPUpdateProgressLabel.Text = "Unpacking TruckersMP..."));
                                System.IO.Compression.ZipFile.ExtractToDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TMPLauncher\\client_" + version + ".zip", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TMPLauncher\\client_" + version);
                                TruckersMPUpdateProgress.Value = 110;

                                TruckersMPUpdateProgressLabel.Invoke((MethodInvoker)(() => TruckersMPUpdateProgressLabel.Text = "Updating TruckersMP..."));

                                ProcessStartInfo startInfo = new ProcessStartInfo();
                                startInfo.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TMPLauncher\\client_" + version + "\\Install TruckersMP.exe";
                                startInfo.Arguments = "/verysilent";

                                try
                                {
                                    using (Process exeProcess = Process.Start(startInfo))
                                    {
                                        exeProcess.WaitForExit();
                                    }
                                }
                                catch
                                {
                                    // Log Error
                                }
                                TruckersMPUpdateProgress.Value = 120;

                                TruckersMPUpdateProgressLabel.Invoke((MethodInvoker)(() => TruckersMPUpdateProgressLabel.Text = "Cleaning up..."));
                                try
                                {
                                    System.IO.Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TMPLauncher\\client_" + version, true);
                                    System.IO.File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TMPLauncher\\client_" + version + ".zip");
                                }
                                catch
                                {
                                    // Log error.
                                }

                                TruckersMPUpdateProgress.Value = 125;

                                TruckersMPUpdateProgress.Invoke((MethodInvoker)(() => TruckersMPUpdateProgress.Visible = false));
                                TruckersMPUpdateProgressLabel.Invoke((MethodInvoker)(() => TruckersMPUpdateProgressLabel.Text = "TruckersMP Updated!"));
                                if (runGame)
                                {
                                    if (game == "ETS2MP")
                                    {
                                        Game.runETS2MP();
                                    }
                                    else if (game == "ATSMP")
                                    {
                                        Game.runATSMP();
                                    }
                                }
                                System.Threading.Thread.Sleep(6000);
                                TruckersMPUpdateProgressLabel.Invoke((MethodInvoker)(() => TruckersMPUpdateProgressLabel.Visible = false));
                            });

                        }
                    });

                downloadClient.DownloadFileAsync(new Uri("http://download.ets2mp.com/client/client_" + version + ".zip"), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\TMPLauncher\\client_" + version + ".zip");
            }
        }

        protected static string MD5(string fileName)
        {
            FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] retVal = md5.ComputeHash(file);
            file.Close();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < retVal.Length; i++)
            {
                sb.Append(retVal[i].ToString("x2"));
            }
            return sb.ToString();
        }

        public static bool launch(string game, string arguments) {

            String binPath;
            String exe;
            String dll;

            //Lets get our games straight
            if (game == "ETS2")
            {
                Environment.SetEnvironmentVariable("SteamGameId", "227300");
                Environment.SetEnvironmentVariable("SteamAppID", "227300");

                binPath = Launcher.ETS2Location + "\\bin\\win_x64";
                exe = "\\eurotrucks2.exe";
                dll = "\\core_ets2mp.dll";
                arguments += " -64bit";
            }
            else if(game == "ATS")
            {
                Environment.SetEnvironmentVariable("SteamGameId", "270880");
                Environment.SetEnvironmentVariable("SteamAppID", "270880");

                binPath = Launcher.ATSLocation + "\\bin\\win_x64";
                exe = "\\amtrucks.exe";
                dll = "\\core_atsmp.dll";
                arguments += " -64bit";
            }
            else
            {
                return false; //Invalid game, lets not do this
            }

            //Intialize variables 'n stuff
            ProcessInformation processInformation = default(ProcessInformation);
            Startupinfo startupinfo = default(Startupinfo);
            SecurityAttributes securityAttributes = default(SecurityAttributes);
            SecurityAttributes securityAttributes2 = default(SecurityAttributes);
            startupinfo.cb = Marshal.SizeOf(startupinfo);
            securityAttributes.nLength = Marshal.SizeOf(securityAttributes);
            securityAttributes2.nLength = Marshal.SizeOf(securityAttributes2);

            //Lets run the game!

            if (!CreateProcess(binPath + exe, arguments, ref securityAttributes, ref securityAttributes2, false, 4u, IntPtr.Zero, binPath, ref startupinfo, out processInformation))
                return false;

            if (!Inject(processInformation.hProcess, Launcher.TruckersMPLocation + dll))
                return false;

            ResumeThread(processInformation.hThread);
            return true;
        }
        private static bool Inject(IntPtr process, string dllPath)
        {
            if (!System.IO.File.Exists(dllPath))
                return false;

            byte[] bytes = Encoding.ASCII.GetBytes(dllPath + "\0");
            byte[] expr_A3 = bytes;
            uint num;
            IntPtr moduleHandle = GetModuleHandle("kernel32.dll");
            IntPtr procAddress = GetProcAddress(moduleHandle, "LoadLibraryA");
            IntPtr intPtr = VirtualAllocEx(process, IntPtr.Zero, (IntPtr)bytes.Length, (AllocationType)12288, MemoryProtection.ReadWrite);
            IntPtr zero = IntPtr.Zero;
            IntPtr arg_A8_1 = intPtr;
            IntPtr intPtr3;


            if (moduleHandle == IntPtr.Zero || procAddress == IntPtr.Zero || intPtr == IntPtr.Zero)
                return false;

            if (!WriteProcessMemory(process, arg_A8_1, expr_A3, expr_A3.Length, out zero))
                return false;
            if ((int)zero != bytes.Length)
                return false;
            
            IntPtr intPtr2 = CreateRemoteThread(process, IntPtr.Zero, 0u, procAddress, intPtr, 0u, out intPtr3);
            if (intPtr2 == IntPtr.Zero)
                return false;

            WaitForSingleObject(intPtr2, 4294967295u);
            GetExitCodeThread(intPtr2, out num);

            if (num == 0u)
                return false;

            CloseHandle(intPtr2);
            FreeLibrary(moduleHandle);

            return true;
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool CreateProcess(string lpApplicationName, string lpCommandLine, ref SecurityAttributes lpProcessAttributes, ref SecurityAttributes lpThreadAttributes, bool bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, [In] ref Startupinfo lpStartupInfo, out ProcessInformation lpProcessInformation);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern uint ResumeThread(IntPtr hThread);

        [DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
        private static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, AllocationType flAllocationType, MemoryProtection flProtect);

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
        private static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, int dwSize, FreeType dwFreeType);

    }
}
