using System;
using System.Runtime.InteropServices;

namespace UI
{
    class Animate
    {
        public const int HOR_Positive = 0x1;
        public const int VER_POSITIVE = 0X4;
        public const int CENTER = 0X10;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int AnimateWindow(IntPtr hwand, int dwTime, int dwFlag);
    }
}
