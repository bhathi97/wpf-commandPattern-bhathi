using PaySheetMenagementSystemForInterns.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PaySheetMenagementSystemForInterns
{
    //here this is the entry oint for the hall application 
    //starting window is HomeWindow
    public partial class App : Application
    {
        private HomeWindow _homeWindow;
        public HomeWindow HomeWindow
        {
            get => _homeWindow;
            set => _homeWindow = value;
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            HomeWindow = new HomeWindow();
            HomeWindow.Show();
            base.OnStartup(e);
        }
    }
}
