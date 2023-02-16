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
    /// Interaction logic for UserControlForAddNewTraineeToTheDataBase.xaml
    /// </summary>
    public partial class UserControlForAddNewTraineeToTheDataBase : UserControl
    {
        //connection
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-KHI8921;Initial Catalog=CPC_Interns_Salary_Management_System_Database;Integrated Security=True;TrustServerCertificate=True");
        AddNewTraineeAllCommands addNewTraineeAllCommands1 = new AddNewTraineeAllCommands();
        NewTraineeDataSendToDataBaseCommand newTraineeDataSendToDataBaseCommand1 = new NewTraineeDataSendToDataBaseCommand();
        public UserControlForAddNewTraineeToTheDataBase()
        {   
            InitializeComponent();
            

            //combo boxe pay or no
            string[] isPay = { "YES", "NO" };
            TraineeShouPayOrNoToDB.ItemsSource = isPay;

            //combo box locations
            addNewTraineeAllCommands1.loadsLocationsToComboBox(connection, this);
            addNewTraineeAllCommands1.loadBanksToComboBox(connection, this);
            

        }

        private void LoadAddDataToDataBase_Click(object sender, RoutedEventArgs e)
        {
            newTraineeDataSendToDataBaseCommand1.addNewTraineeToDataTables(this,connection);
        }

        //autoload code of bank
        private void TraineeBankNameToDB_DropDownClosed_1(object sender, EventArgs e)
        {
            addNewTraineeAllCommands1.loadBankCodeToTextBlock(connection, this);
           
        }

        private void TraineeBranchNameToDB_DropDownClosed(object sender, EventArgs e)
        {
            addNewTraineeAllCommands1.loadBranchCodeToTextBlock(connection, this);
        }
    }
}
