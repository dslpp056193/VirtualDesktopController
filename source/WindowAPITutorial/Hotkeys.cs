using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowAPITutorial
{
    public class Hotkeys
    {
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private readonly IntPtr _hwnd;

        public Hotkeys(IntPtr hwnd)
        {
            _hwnd = hwnd;
        }

        public void RegisterHotkeys()
        {
            RegisterHotKey(_hwnd, 1, (int)WindowKeys.Control, (int)Keys.A);
        }

        public void UnregisterHotKeys()
        {
            UnregisterHotKey(_hwnd, 1);
        }
        /// <summary>
        /// Typical hotkey assigngments (fsMod)
        /// </summary>
        public enum WindowKeys
        {
            Alt = 0x0001,
            Control = 0x0002,
            Shift = 0x0004, // Changes!
            Window = 0x0008,
        }
    }
}
