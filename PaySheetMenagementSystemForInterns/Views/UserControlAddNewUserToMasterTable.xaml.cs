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

        //initialize to reuse
        private UserControlForMasterDataShowing _ucMasterDataShowingWindow;
        private UserControlForSalaryDetailsShowing _ucSalaryDetailShowingWindow;
        private UserControlForPaidSalaryDetailsShowing _ucPaidSalaryDetailShowingWindow;
        private UserControlForAddNewTraineeToTheDataBase _ucAddNewTraineeWindow;
        private UserControlForEdidTraineeDetails _ucEditTraineeDetailsWindow;
        private UserControlForBankAndBranchCrud _ucBankBranchDetailWindow;


        //to see table of details of all interns in a grid  
        private void seeMasterTableData_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (_ucMasterDataShowingWindow == null)
                {
                    _ucMasterDataShowingWindow = new UserControlForMasterDataShowing();
                    UserControlLoaderToAddNew.Content = _ucMasterDataShowingWindow;
                }
                else
                {
                    UserControlLoaderToAddNew.Content = _ucMasterDataShowingWindow;
                }
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        //to see table of Bank account details of all interns in a grid  
        private void seeAccountTableData_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(_ucSalaryDetailShowingWindow == null)
                {
                    _ucSalaryDetailShowingWindow = new UserControlForSalaryDetailsShowing();
                    UserControlLoaderToAddNew.Content = _ucSalaryDetailShowingWindow;
                }
                else
                {
                    UserControlLoaderToAddNew.Content = _ucSalaryDetailShowingWindow;
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void seeSalaryTableData_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(_ucPaidSalaryDetailShowingWindow == null)
                {
                    _ucPaidSalaryDetailShowingWindow = new UserControlForPaidSalaryDetailsShowing();
                    UserControlLoaderToAddNew.Content = _ucPaidSalaryDetailShowingWindow;
                }
                else
                {
                    UserControlLoaderToAddNew.Content = _ucPaidSalaryDetailShowingWindow;
                }
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        //add new trainee to the database | both master and account tables
        private void addNewTrainee_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(_ucAddNewTraineeWindow  == null)
                {
                    _ucAddNewTraineeWindow = new UserControlForAddNewTraineeToTheDataBase();
                    UserControlLoaderToAddNew.Content = _ucAddNewTraineeWindow;
                }
                else
                {
                    UserControlLoaderToAddNew.Content = _ucAddNewTraineeWindow;
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        //edit existing User in the database
        private void updateOrDeleteTableData_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(_ucEditTraineeDetailsWindow == null)
                {
                    _ucEditTraineeDetailsWindow = new UserControlForEdidTraineeDetails();
                    UserControlLoaderToAddNew.Content = _ucEditTraineeDetailsWindow;
                }
                else
                {
                    UserControlLoaderToAddNew.Content = _ucEditTraineeDetailsWindow;
                }
               
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
        //edit bank detils
        private void bankAndBranchDetails_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(_ucBankBranchDetailWindow == null)
                {
                    _ucBankBranchDetailWindow = new UserControlForBankAndBranchCrud();
                    UserControlLoaderToAddNew.Content = _ucBankBranchDetailWindow;
                }
                else
                {
                    UserControlLoaderToAddNew.Content = _ucBankBranchDetailWindow;
                }                
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
