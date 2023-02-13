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

//this should be account details

namespace PaySheetMenagementSystemForInterns.Views.UserControlsForAddNewToMAsterTableContent
{
    /// <summary>
    /// Interaction logic for UserControlForSalaryDetailsShowing.xaml
    /// </summary>
    public partial class UserControlForSalaryDetailsShowing : UserControl
    {
        public UserControlForSalaryDetailsShowing()
        {
            InitializeComponent();
            bankAccountDetailsToGridViewCommand1.BankAccountDetailsLoadToDataGrid(this,connection);
        }

        BankAccountDetailsToGridViewCommand bankAccountDetailsToGridViewCommand1 = new BankAccountDetailsToGridViewCommand();
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-KHI8921;Initial Catalog=CPC_Interns_Salary_Management_System_Database;Integrated Security=True;TrustServerCertificate=True");

    }
}
