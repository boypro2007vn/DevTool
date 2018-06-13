using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DevTool.Services
{
    public class WindowApi
    {
        #region Public Const Variable

        internal const uint WM_GETTEXT = 0x0D;

        internal const uint WM_GETTEXTLENGTH = 0x0E;

        internal const uint EM_GETSEL = 0xB0;

        #endregion

        /// <summary>
        /// Get window's focused
        /// </summary>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern IntPtr GetForegroundWindow();

        /// <summary>
        /// Set window's focused
        /// </summary>
        /// <returns></returns>
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        internal static extern bool SetForegroundWindow(IntPtr hwnd);

        /// <summary>
        /// Get current thread id
        /// </summary>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        internal static extern int GetCurrentThreadId();

        /// <summary>
        /// Get the thread id of the current window
        /// </summary>
        /// <param name="vHandle">Active window</param>
        /// <param name="vProcessId">Output thread id of the current window</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern int GetWindowThreadProcessId(int vHandle, out int vProcessId);

        /// <summary>
        ///  Attach the thread to the current thread. 
        /// </summary>
        /// <param name="idAttach">Window process id base</param>
        /// <param name="idAttachTo">Window process id to replace</param>
        /// <param name="fAttach">Flag Attach</param>
        /// <returns></returns>
        [DllImport("user32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        internal static extern int AttachThreadInput(int idAttach, int idAttachTo, bool fAttach);

        /// <summary>
        /// Get window's title text
        /// </summary>
        /// <param name="hWnd">Active Window</param>
        /// <param name="text"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        /// <summary>
        /// Get length of window's title text
        /// </summary>
        /// <param name="hWnd">Active Window</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern int GetWindowTextLength(IntPtr hWnd);

        /// <summary>
        /// Get windows based on cursor position
        /// </summary>
        /// <param name="lpPoint">Cursor position</param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        internal static extern IntPtr WindowFromPoint(Point lpPoint);

        /// <summary>
        ///  Get current mouse position
        /// </summary>
        /// <param name="lpPoint">Mouse position</param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        internal static extern bool GetCursorPos(out Point lpPoint);

        /// <summary>
        /// Focus to window
        /// </summary>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        internal static extern IntPtr GetFocus();

        /// <summary>
        /// Send message
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="msg"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        internal static extern int SendMessage(IntPtr hWnd, uint Msg, int wParam, StringBuilder lParam);

        /// <summary>
        /// Send message
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="msg"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        internal static extern int SendMessage(IntPtr hWnd, uint msg, out int wParam, out int lParam);

        /// <summary>
        /// Send message
        /// </summary>
        /// <param name="hwnd"></param>
        /// <param name="wMsg"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);
        
        /// <summary>
        /// Send key
        /// </summary>
        /// <param name="bVk"></param>
        /// <param name="bScan"></param>
        /// <param name="dwFlags"></param>
        /// <param name="dwExtraInfo"></param>
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);
    }
}
