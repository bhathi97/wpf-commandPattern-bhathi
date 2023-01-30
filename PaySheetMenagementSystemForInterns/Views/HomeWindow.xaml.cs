using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using PaySheetMenagementSystemForInterns.Commands;

namespace PaySheetMenagementSystemForInterns.Views
{

    public partial class HomeWindow : Window
    {
        public WindowState _state;
        

        WindowCloseButtonCommand windowCloseButtonCommand1 = new WindowCloseButtonCommand();

        public WindowCloseButtonCommand WindowCloseButtonCommand1 { get => windowCloseButtonCommand1; set => windowCloseButtonCommand1 = value; }

        public HomeWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void MenuItemHome_Click(object sender, RoutedEventArgs e)
        {
            UserControlLoader1.Content = new UserControlForSalaryEnteringWindow();
                
        }

        private void MenuItemNewbie_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItemSetting_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            WindowCloseButtonCommand1.WindowClose();
        }

        private void MaximizeButton_Click(object sender, RoutedEventArgs e)
        {
            WindowCloseButtonCommand1.WindowdMaximize(_state, this);
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            WindowCloseButtonCommand1.WindowMinimize(this);
        }

        
    }
}
