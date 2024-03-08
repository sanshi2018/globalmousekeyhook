using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Gma.System.MouseKeyHook.WinApi
{
    public static class WindowNativeMethods
    {
        [DllImport("user32.dll")]
        internal static extern int GetWindowTextLength(IntPtr hWnd);
        
        /// <summary>
        /// 该函数将指定窗口的标题条文本（如果存在）拷贝到一个缓存区内。如果指定的窗口是一个控制，则拷贝控制的文本。但是，GetWindowTeXt不能接收在其他应用程序中的控制文本
        /// </summary>
        /// <param name="hWnd">带文本的窗口或控制的句柄</param>
        /// <param name="lpString">指向接收文本的缓冲区的指针</param>
        /// <param name="nMaxCount">指定要保存在缓冲区内的字符的最大个数，其中包含NULL字符。如果文本超过界限，它就被截断。</param>
        /// <returns>如果函数成功，返回值是拷贝的字符串的字符个数，不包括中断的空字符；如果窗口无标题栏或文本，或标题栏为空，或窗口或控制的句柄无效，则返回值为零。若想获得更多错误信息，请调用GetLastError函数。函数不能返回在其他应用程序中的编辑控制的文本</returns>
        [DllImport("user32.dll", CharSet=CharSet.Auto, SetLastError=true)]
        internal static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString,
            int nMaxCount);
    }
}