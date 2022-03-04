using System;
using System.Runtime.InteropServices;
using System.Drawing;
namespace MouseControl
{

    public class Mouse
    {
        [DllImport("user32.dll", EntryPoint = "mouse_event")]
        public static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);

        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        private static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll", EntryPoint = "GetCursorPos")]
        private static extern bool GetCursorPos(out POINT lpPoint);

        public struct POINT
        {
            public int X;
            public int Y;

            public static implicit operator Point(POINT point)
            {
                return new Point(point.X, point.Y);
            }
        }

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;
        private const int MOUSEEVENTF_MIDDLEDOWN = 0x20;
        private const int MOUSEEVENTF_MIDDLEUP = 0x40;
        private const int MOUSEEVENTF_WHEEL = 0x800;
        private const int WHEEL_DELTA = 120;
        private const int MOUSEEVENTF_LEFTCLICK = MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP;
        private const int MOUSEEVENTF_RIGHTCLICK = MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP;
        private const int MOUSEEVENTF_MIDDLECLICK = MOUSEEVENTF_MIDDLEDOWN | MOUSEEVENTF_MIDDLEUP;
        


        public static void release(int x)
        {
            // MOUSEEVENTF_LEFTUP or 0x04 = Release Left Mouse Button
            // MOUSEEVENTF_RIGHTUP or 0x10 = Release Right Mouse Button
            // MOUSEEVENTF_MIDDLEUP or 0x40 = Release Middle Mouse Button

            mouse_event(x, 0, 0, 0, 0);
        }
        public static void press(int x)
        {
            // MOUSEEVENTF_LEFTDOWN or 0x02 = Press Left Mouse Button
            // MOUSEEVENTF_RIGHTDOWN or 0x08 = Press Right Mouse Button
            // MOUSEEVENTF_MIDDLEDOWN or 0x20 = Press Middle Mouse Button

            mouse_event(x, 0, 0, 0, 0);
        }
        public static void click(int x)
        {
            // MOUSEEVENTF_LEFTCLICK = Click Left Mouse Button
            // MOUSEEVENTF_RIGHTCLICK = Click Right Mouse Button
            // MOUSEEVENTF_MIDDLECLICK = Click Middle Mouse Button

            mouse_event(x, 0, 0, 0, 0);
        }
        public static void MoveMouseTo(int x,int y)
        {
            // Set cursor position to specified location
            // See MoveMouseRelative for moving relative to current position

            SetCursorPos(x,y);
        }
        public static void MoveMouseRelative(int x, int y)
        {
            // Move cursor relative to the current position of the cursor

            mouse_event(0, x, y, 0, 0);
        }
        public static void MoveMouseWheel(int x)
        {
            // Move scroll wheel
            // One mouse scroll click = 1
            // Two mouse scroll click = 2

            mouse_event(MOUSEEVENTF_WHEEL, 0, 0, (WHEEL_DELTA * x), 0);
        }
        public static (int, int) GetCursorPos()
        {
            // Get current cursor position
            // (x,y) = x cord, y cord

            POINT lpPoint;
            GetCursorPos(out lpPoint);
            int x = lpPoint.X;
            int y = lpPoint.Y;
            return (x, y);
        }
    }
}