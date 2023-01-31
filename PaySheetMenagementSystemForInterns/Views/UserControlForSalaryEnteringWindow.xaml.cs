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
            months = new string[] { "january", "february", "march", "april", "may", "june", "july", "august", "september", "octomber", "november", "december" };
            years = new int[] { 2022, 2023, 2024, 2025, 2026 };
            
            //fill combo boxes
            AddingYear.ItemsSource = years;
            AddingMonth.ItemsSource = months;
            this.DataContext = this;

        }
        
        
        private void InternID_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
        
        //when Id text box data change, autofill ohter data according
        private void InternID_SelectionChanged(object sender, RoutedEventArgs e)
        {
            dataAutoLoadWhenIDEnterCommand1.dataAutoLoad(this,connection);
        }

        //button click event to see remaining data of temperary data table
        private void seeTableData_Click(object sender, RoutedEventArgs e)
        {
            dataSeeBtnClickCommand1.DataseeButtonClick(dataShowingTable, connection);   
        }
        
        //when datagrid view data select, autofill textboxes -> if update need to use
        private void dataShowingTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            dataGridViewSelectionAutofillCommand1.dataSelectionAutofill(this,connection);
        }
        //validate fulldays input
        private void AddingFullWorkDays_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            dataValidationOfFullAndHalfDaysCommand1.dataValidation(sender, e);
        }

        //validate halfdays input
        private void AddingHalfWorkDays_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            dataValidationOfFullAndHalfDaysCommand1.dataValidation(sender, e);
        }

        //auto calculate total salary
        private void TotalSalaryCalculate(object sender, TextChangedEventArgs e)
        {
            TotalSalaryCalculationCommand1.totalSalaryAutoCalculate(this);
        }
        private void InternSalaryPerDay_TextChanged(object sender, TextChangedEventArgs e)
        {
            TotalSalaryCalculationCommand1.totalSalary(this);
        }

        //button click event to sent data to the temperary table/monthly table
        private void SendToTable_Click(object sender, RoutedEventArgs e)
        {
            yearAndMonthIsInRangeCheckCommand1.validateYearAndMonth(this, connection);
            if(yearAndMonthIsInRangeCheckCommand1.flag == 1)
            {
                dataSendToTemperoryTableCommand1.dataSendAfterValidate(this, connection);
                dataSeeBtnClickCommand1.DataseeButtonClick(dataShowingTable, connection);
            }
            else if(yearAndMonthIsInRangeCheckCommand1.flag == 0)
            {
                MessageBox.Show("Entered month or year is out of bound", "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }            
        }


        //add new record - clrear all fields for add new
        private void AddNewRecord_Click(object sender, RoutedEventArgs e)
        {
            cleanFieldsToAddNewDataCommand1.cleanFieldsToAddNewData(this,connection);
        }




        //---parameters to pass
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-KHI8921;Initial Catalog=CPC_Interns_Salary_Management_System_Database;Integrated Security=True;TrustServerCertificate=True");
        public string[] months { get; set; }
        public int[] years { get; set; }





        //---command binding
        DataSeeBtnClickCommand dataSeeBtnClickCommand1 = new DataSeeBtnClickCommand();
        DataAutoLoadWhenIDEnterCommand dataAutoLoadWhenIDEnterCommand1 = new DataAutoLoadWhenIDEnterCommand();
        DataGridViewSelectionAutofillCommand dataGridViewSelectionAutofillCommand1 = new DataGridViewSelectionAutofillCommand();
        DataValidationOfFullAndHalfDaysCommand dataValidationOfFullAndHalfDaysCommand1 = new DataValidationOfFullAndHalfDaysCommand();
        TotalSalaryCalculationCommand TotalSalaryCalculationCommand1 = new TotalSalaryCalculationCommand();
        DataSendToTemperoryTableCommand dataSendToTemperoryTableCommand1 = new DataSendToTemperoryTableCommand();
        YearAndMonthIsInRangeCheckCommand yearAndMonthIsInRangeCheckCommand1 = new YearAndMonthIsInRangeCheckCommand();
        CleanFieldsToAddNewDataCommand cleanFieldsToAddNewDataCommand1 = new CleanFieldsToAddNewDataCommand();









        //testing-------------------



    }


}
