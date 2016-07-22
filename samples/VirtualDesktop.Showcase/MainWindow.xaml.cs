using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using WindowsDesktop;
using NHotkey.Wpf;


namespace VirtualDesktopShowcase
{
	partial class MainWindow
	{
		public MainWindow()
		{
			this.InitializeComponent();

            HotkeyManager.Current.AddOrReplace("SetWindow1", Key.F1, ModifierKeys.Control, OnSetWindow1);
            HotkeyManager.Current.AddOrReplace("SetWindow2", Key.F2, ModifierKeys.Control, OnSetWindow2);
            HotkeyManager.Current.AddOrReplace("SetWindow3", Key.F3, ModifierKeys.Control, OnSetWindow3);
            HotkeyManager.Current.AddOrReplace("SetWindow4", Key.F4, ModifierKeys.Control, OnSetWindow4);
        }

        private void OnSetWindow1(object sender, NHotkey.HotkeyEventArgs e)
        {
            var desktops = WindowsDesktop.VirtualDesktop.GetDesktops();

            if (desktops.Length - 1 >= 0)
            {
                this.MoveToDesktop(desktops[0]);
                desktops[0].Switch();
                TEXT.Text = "1";
            }
        }

        private void OnSetWindow2(object sender, NHotkey.HotkeyEventArgs e)
        {
            var desktops = WindowsDesktop.VirtualDesktop.GetDesktops();

            if (desktops.Length - 1 >= 1)
            {
                this.MoveToDesktop(desktops[1]);
                desktops[1].Switch();
                TEXT.Text = "2";
            }
        }

        private void OnSetWindow3(object sender, NHotkey.HotkeyEventArgs e)
        {
            var desktops = WindowsDesktop.VirtualDesktop.GetDesktops();

            if (desktops.Length - 1 >= 2)
            {
                this.MoveToDesktop(desktops[2]);
                desktops[2].Switch();
                TEXT.Text = "3";
            }
        }

        private void OnSetWindow4(object sender, NHotkey.HotkeyEventArgs e)
        {
            var desktops = WindowsDesktop.VirtualDesktop.GetDesktops();

            if ( desktops.Length-1 >= 3)
            {
                this.MoveToDesktop(desktops[3]);
                desktops[3].Switch();
                TEXT.Text = "4";
            }

        }
	}
}
