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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PaySheetMenagementSystemForInterns.Views.UserControlsForAddNewToMAsterTableContent
{
    /// <summary>
    /// Interaction logic for UserControlForPaidSalaryDetailsShowing.xaml
    /// </summary>
    public partial class UserControlForPaidSalaryDetailsShowing : UserControl
    {
        public UserControlForPaidSalaryDetailsShowing()
        {
            InitializeComponent();
            paidSalariesDetailsToGridViewCommand1.SalaryDeytailsLoadToGridView(this, connection);
        }

        PaidSalariesDetailsToGridViewCommand paidSalariesDetailsToGridViewCommand1 = new PaidSalariesDetailsToGridViewCommand();
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-KHI8921;Initial Catalog=CPC_Interns_Salary_Management_System_Database;Integrated Security=True;TrustServerCertificate=True");

        private void searchCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SearchPAidSalariesFromMasterTB_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
