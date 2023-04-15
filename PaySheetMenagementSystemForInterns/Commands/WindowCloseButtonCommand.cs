using PaySheetMenagementSystemForInterns.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PaySheetMenagementSystemForInterns.Commands
{
    public class WindowCloseButtonCommand
    {
        //close command
        public void WindowClose()
        {
            if (MessageBox.Show("Are you sure you want to close this window?", "Confirm", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        } 


        //maximuze command

        int flagForWState  = 0 ; //to store current Window State

        public int WindowdMaximize(WindowState state, Window window)
        {
            
            if (state == WindowState.Normal && flagForWState == 0)
            {
                window.WindowState = WindowState.Maximized;
                return flagForWState++;
            }
            else
            {
                window.WindowState = WindowState.Normal;
                return flagForWState--;
            }

        }


        //minimize command
        public void WindowMinimize(Window window)
        {
            window.WindowState = WindowState.Minimized;
        }
    }
}
