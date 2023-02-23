using PaySheetMenagementSystemForInterns.Commands;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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

namespace PaySheetMenagementSystemForInterns.Views
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

       
        //connect with database
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-KHI8921;Initial Catalog=CPC_Interns_Salary_Management_System_Database;Integrated Security=True;TrustServerCertificate=True");
        UserLoginCommand userLoginCommand = new UserLoginCommand();
        //login button
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            int permitted = userLoginCommand.login(this, connection);
            if (permitted == 1)
            {
                //when username and pw is correct
                HomeWindow homeWindow = new HomeWindow();
                homeWindow.namePass = userNameForLogin.Text;
                homeWindow.Show();
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Invalid Password", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                userPasswordForLogin.Focus();
            }
        }

        //exit button
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        
    }
}
