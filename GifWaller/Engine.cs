using System;
using System.Threading;
using System.Windows.Forms;

namespace GifWaller
{
    static class Engine
    {
        internal static IntPtr WorkerW = IntPtr.Zero;   //handle to WorkerW. This is what controls the wallpaper on a Wind@ws 10 system.
        internal static IntPtr progman = IntPtr.Zero;

        [STAThread]
        static void Main()
        {
            Mutex mutex = new Mutex(false, "D8F605C9-8728-49E6-828E-ACAF3BBE81DE");

            if (!mutex.WaitOne(TimeSpan.Zero, true))
            {
                if (MessageBox.Show("Start another instance?", "Already Running", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    mutex.ReleaseMutex();

                    Application.Exit();
                }
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            init();     //get the handle to WorkerW

            Application.Run(new UI());

            mutex.ReleaseMutex();
        }

        private static void init()
        {
            IntPtr lpdwResult = IntPtr.Zero;


            progman = WINAPI.FindWindow("Progman", null);

            WINAPI.SendMessageTimeout(
                progman,
                0x052C,
                IntPtr.Zero,
                IntPtr.Zero,
                0, 1000,
                lpdwResult
                );      //spawn a WorkerW

            //go through all windows and boil down from SHELLDLL_DefView to WorkerW to find it's handle
            WINAPI.EnumWindows(new WINAPI.EnumWindowsProc((tophandle, topparamhandle) =>
            {
                IntPtr pInt = WINAPI.FindWindowEx(tophandle, IntPtr.Zero, "SHELLDLL_DefView", string.Empty);

                if (pInt != IntPtr.Zero)
                    WorkerW = WINAPI.FindWindowEx(
                        IntPtr.Zero,
                        tophandle,
                        "WorkerW",
                        string.Empty
                        );

                return true;
            }), IntPtr.Zero);

            //we now have the handle to WorkerW
        }
    }
}
