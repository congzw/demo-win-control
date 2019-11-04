using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DemoApp.Helpers
{
    public class ClsWin32
    {
        [DllImport("user32.dll", EntryPoint = "FindWindowEx", SetLastError = true)]
        public static extern IntPtr FindWindowEx(IntPtr handleParent, IntPtr handleChildAfter, string lpszClass, string lpszWindow);

        [DllImport("user32.dll", EntryPoint = "ShowWindow", SetLastError = true)]
        public static extern bool ShowWindow(IntPtr hWnd, uint nCmdShow);

        public static string Shell_TrayWnd = "Shell_TrayWnd";

        public static void HideTask(bool isHide)
        {
            var trayHandle = FindWindowEx(IntPtr.Zero, IntPtr.Zero, Shell_TrayWnd, null);
            ShowWindow(trayHandle, isHide ? (uint) 0 : (uint) 1);
        }

        public static void SwitchFullScreen(Form theForm)
        {
            if (theForm.WindowState == FormWindowState.Maximized)
            {
                //theForm.FormBorderStyle = FormBorderStyle.None;
                theForm.FormBorderStyle = FormBorderStyle.SizableToolWindow;
                theForm.WindowState = FormWindowState.Normal;
                HideTask(false);
            }
            else
            {
                theForm.FormBorderStyle = FormBorderStyle.None;
                theForm.WindowState = FormWindowState.Maximized;
                HideTask(true);
            }
        }
    }
}
