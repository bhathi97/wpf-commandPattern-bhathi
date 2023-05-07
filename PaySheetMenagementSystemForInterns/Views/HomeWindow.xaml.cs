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
using System.Windows.Interop;
using System.Windows.Threading;
using System.Data.SqlClient;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Security.Policy;
using Microsoft.VisualBasic;

namespace PaySheetMenagementSystemForInterns.Views
{

    public partial class HomeWindow : Window
    {
        public WindowState _state;
        DispatcherTimer timer;

        SqlConnection connection = new SqlConnection(DatabaseConnectionClass.ConnectionString);

        //commands as objects
        WindowCloseButtonCommand windowCloseButtonCommand1 = new WindowCloseButtonCommand();
        ShowingDatabaseIsConennectedOrNotAtTheBeginningCommand ShowingDatabaseIsConennectedOrNotAtTheBeginningCommand1 = new ShowingDatabaseIsConennectedOrNotAtTheBeginningCommand();

        public WindowCloseButtonCommand WindowCloseButtonCommand1 { get => windowCloseButtonCommand1; set => windowCloseButtonCommand1 = value; }

        //to passname
        public string namePass { get; set; }

        public HomeWindow()
        {
            InitializeComponent();
          
            this.DataContext = this;
            ShowingDatabaseIsConennectedOrNotAtTheBeginningCommand1.showISDAtaBAseConnecetAtTheBeginning(this, connection);
            //UserControlLoader1.Content = new UserControlForSalaryEnteringWindow();
            

            //show real time and date
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();

            if (_salaryEnteringWindow == null)
            {
                // Load the control if it hasn't been loaded yet
                _salaryEnteringWindow = new UserControlForSalaryEnteringWindow();
                UserControlLoader1.Content = _salaryEnteringWindow;
            }
            else
            {
                // Reuse the existing control
                UserControlLoader1.Content = _salaryEnteringWindow;
            }

        }

        //define usercontrol instances to reuse
        private UserControlForSalaryEnteringWindow _salaryEnteringWindow;
        private UserControlAddNewUserToMasterTable _addNewUserToMasterWindow;

        private void Timer_Tick(object sender, EventArgs e)
        {
            realTimeDateShowingLable.Content = DateTime.Now.ToString("f");
        }

        //add windows system properties
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WindowInteropHelper helper = new WindowInteropHelper(this);
            SendMessage(helper.Handle, 161, 2, 0);
        }

        //menu items commands
        private void MenuItemHome_Click(object sender, RoutedEventArgs e)
        {
            if (_salaryEnteringWindow == null)
            {
                // Load the control if it hasn't been loaded yet
                _salaryEnteringWindow = new UserControlForSalaryEnteringWindow();
                UserControlLoader1.Content = _salaryEnteringWindow;
            }
            else
            {
                // Reuse the existing control
                UserControlLoader1.Content = _salaryEnteringWindow;
            }
        }
       

        //add new trainee command
        private void MenuItemNewbie_Click(object sender, RoutedEventArgs e)
        {
           
            if(_addNewUserToMasterWindow == null)
            {
                //load the control if hasent been loaded yet
                _addNewUserToMasterWindow = new UserControlAddNewUserToMasterTable();
                UserControlLoader1.Content = _addNewUserToMasterWindow;
            }else
            {
                //reuse the existing control
                UserControlLoader1.Content = _addNewUserToMasterWindow;
            }


        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                WindowCloseButtonCommand1.WindowClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
          
        }

        private void MaximizeButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                WindowCloseButtonCommand1.WindowdMaximize(_state, this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                WindowCloseButtonCommand1.WindowMinimize(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            
        }

        internal void SetBinding(double actualHeight, Binding binding)
        {
            throw new NotImplementedException();
        }

        private void UserControlLoader1_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            //userControlForSalaryEnteringWindow      .Width = e.NewSize.Width;
        }

        private void webBrowserLoadButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Process.Start(@"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe", "https://ceypetco.gov.lk/");
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
           
        }

        private void notePadLoadButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Process.Start("notepad.exe");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
    }
}
