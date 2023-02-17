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
    /// Interaction logic for UserControlForEdidTraineeDetails.xaml
    /// </summary>
    public partial class UserControlForEdidTraineeDetails : UserControl
    {
        //connections
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-KHI8921;Initial Catalog=CPC_Interns_Salary_Management_System_Database;Integrated Security=True;TrustServerCertificate=True");
        UpdateTraineeAllCommands updateTraineeAllCommands1 = new UpdateTraineeAllCommands();


        public UserControlForEdidTraineeDetails()
        {
            InitializeComponent();

            //combo boxe pay or no
            string[] isPay = { "Yes", "No" };
            TBforUpdateTraineePay.ItemsSource = isPay;

            //load locations and banks combo boxes
            updateTraineeAllCommands1.loadsLocationsToComboBox(connection, this);
            updateTraineeAllCommands1.loadBanksToComboBox(connection, this);
        }

        private void updateData_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                updateTraineeAllCommands1.updateTrainee(connection, this);
            }
            catch(Exception ex) { }
            
        }

        private void DeleteData_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                updateTraineeAllCommands1.deleteTrainee(connection, this);
            }
            catch (Exception ex) { }
        }

        //load branch names
        private void TBforUpdateBankName_DropDownClosed(object sender, EventArgs e)
        {
            updateTraineeAllCommands1.loadBankCodeToTextBlock(connection, this);
        }

        //load branch code
        private void TBforUpdateBranchName_DropDownClosed(object sender, EventArgs e)
        {
            updateTraineeAllCommands1.loadBranchCodeToTextBlock(connection, this);
        }

        //load data
        private void TBforUpdateTraineeNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            updateTraineeAllCommands1.loadDataToFieldsWhenTraineeNumberAdd(connection, this);
        }

        /*private void TBforUpdateTraineeStartDate_CalendarClosed(object sender, RoutedEventArgs e)
        {
            updateTraineeAllCommands1.monthsCalculationFunction(this);
        }*/

        private void TBforUpdateTraineeStartDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            updateTraineeAllCommands1.monthsCalculationFunction(this);
        }
    }
}
