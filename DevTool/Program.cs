using System;
using System.Threading;
using System.Windows.Forms;
using DevTool.Properties;

namespace DevTool
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static Mutex _mutex = new Mutex(true, "{8F6F0AC4-B9A1-45fd-A8CF-72F04E6BDE8F}");
        [STAThread]
        static void Main()
        {
            if (_mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new TaskTrayApplicationContext());
                _mutex.ReleaseMutex();
            }
            else
            {
                // send our Win32 message to make the currently running instance
                MessageBox.Show(Resources.WAN001, Resources.AppName, MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

        }
    }
}
