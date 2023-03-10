using System;
using System.Collections.Generic;
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
using PaySheetMenagementSystemForInterns.Views.UserControlsForAddNewToMAsterTableContent;

namespace PaySheetMenagementSystemForInterns.Views
{
    /// <summary>
    /// Interaction logic for UserControlAddNewUserToMasterTable.xaml
    /// </summary>
    public partial class UserControlAddNewUserToMasterTable : UserControl
    {
        public UserControlAddNewUserToMasterTable()
        {
            InitializeComponent();
        }
        

        //to see table of details of all interns in a grid  
        private void seeMasterTableData_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                UserControlLoaderToAddNew.Content = new UserControlForMasterDataShowing();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        //to see table of Bank account details of all interns in a grid  
        private void seeAccountTableData_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                UserControlLoaderToAddNew.Content = new UserControlForSalaryDetailsShowing();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void seeSalaryTableData_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                UserControlLoaderToAddNew.Content = new UserControlForPaidSalaryDetailsShowing();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        //add new trainee to the database | both master and account tables
        private void addNewTrainee_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                UserControlLoaderToAddNew.Content = new UserControlForAddNewTraineeToTheDataBase();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        //edit existing User in the database
        private void updateOrDeleteTableData_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                UserControlLoaderToAddNew.Content = new UserControlForEdidTraineeDetails();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
        //edit bank detils
        private void bankAndBranchDetails_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                UserControlLoaderToAddNew.Content = new UserControlForBankAndBranchCrud();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
