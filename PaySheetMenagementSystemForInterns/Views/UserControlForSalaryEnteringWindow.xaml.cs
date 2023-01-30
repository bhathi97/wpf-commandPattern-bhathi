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
using System.Windows.Navigation;
using System.Windows.Shapes;
using PaySheetMenagementSystemForInterns.Commands;

namespace PaySheetMenagementSystemForInterns.Views
{
    /// <summary>
    /// Interaction logic for UserControlForSalaryEnteringWindow.xaml
    /// </summary>
    public partial class UserControlForSalaryEnteringWindow : UserControl
    {



        public UserControlForSalaryEnteringWindow()
        {
            InitializeComponent();
            InternID.Focus();

           
        }
        
        
        private void InternID_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void InternID_SelectionChanged(object sender, RoutedEventArgs e)
        {
            
            DataAutoLoadWhenIDEnterCommand1.dataAutoLoad(this,connection);
        }


        private void seeTableData_Click(object sender, RoutedEventArgs e)
        {
            dataSeeBtnClickCommand1.DataseeButtonClick(dataShowingTable, connection);   
        }

        //---parameters to pass
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-KHI8921;Initial Catalog=CPC_Interns_Salary_Management_System_Database;Integrated Security=True;TrustServerCertificate=True");

        
        
        


        //---command binding
        DataSeeBtnClickCommand dataSeeBtnClickCommand1 = new DataSeeBtnClickCommand();
        DataAutoLoadWhenIDEnterCommand DataAutoLoadWhenIDEnterCommand1 = new DataAutoLoadWhenIDEnterCommand();
    }


}
