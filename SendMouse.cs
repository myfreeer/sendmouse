namespace SendMouse
{
    using System;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    public class Program
    {
        private const int MOUSEEVENTF_ABSOLUTE = 0x8000;
        private const int MOUSEEVENTF_LEFTDOWN = 2;
        private const int MOUSEEVENTF_LEFTUP = 4;
        private const int MOUSEEVENTF_MIDDLEDOWN = 0x20;
        private const int MOUSEEVENTF_MIDDLEUP = 0x40;
        private const int MOUSEEVENTF_MOVE = 1;
        private const int MOUSEEVENTF_RIGHTDOWN = 8;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        private static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            try
            {
                x = Convert.ToInt32(args[0]);
                y = Convert.ToInt32(args[1]);
            }
            catch
            {
                Console.WriteLine("Usage:SendMouse.exe x y");
                Console.Write("x=");
                Console.WriteLine(Control.MousePosition.X);
                Console.Write("y=");
                Console.WriteLine(Control.MousePosition.Y);
                Environment.Exit(-1);
            }
            Console.Write("x=");
            Console.WriteLine(Control.MousePosition.X);
            Console.Write("y=");
            Console.WriteLine(Control.MousePosition.Y);
            SetCursorPos(x, y);
            mouse_event(0x8002, x, y, 0, 0);
            mouse_event(4, x, y, 0, 0);
        }

        [DllImport("user32")]
        private static extern int mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        [DllImport("user32.dll")]
        private static extern bool SetCursorPos(int X, int Y);
    }
}
