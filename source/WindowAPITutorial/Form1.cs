using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowAPITutorial
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(String sClassName, String sAppName);

        private IntPtr thisWindow;
        private Hotkey hotkey;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            thisWindow = FindWindow(null, "Form1");
            hotkey = new Hotkey(thisWindow);
            hotkey.RegisterHotKeys();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            hotkey.UnRegisterHotKeys();
        }

        protected override void WndProc(ref Message keyPressed)
        {
            if (keyPressed.Msg == 0x0312)
            {
                Console.WriteLine();
            }
            base.WndProc(ref keyPressed);
        }
    }
}
