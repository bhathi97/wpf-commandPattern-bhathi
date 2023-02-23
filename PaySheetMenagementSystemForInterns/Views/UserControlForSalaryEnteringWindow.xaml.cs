using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            years = new int[] { 2020,2021,2022, 2023, 2024, 2025, 2026 };
           
            
            //fill combo boxes
            AddingYear.ItemsSource = years;
            AddingMonth.ItemsSource = months;
            
            this.DataContext = this;

            //disable at the beginning
            dataExportToaTextFile.IsEnabled= false;

           

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
            try
            {
                dataSeeBtnClickCommand1.DataseeButtonClick(dataShowingTable, connection,this);
            }
            catch (Exception ex)
            {

            }
            
             
        }
        
        //when datagrid view data select, autofill textboxes -> if update need to use
        private void dataShowingTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                dataGridViewSelectionAutofillCommand1.dataSelectionAutofill(this);
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
            
        }
        //validate fulldays input
        private void AddingFullWorkDays_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            dataValidationOfFullAndHalfDaysCommand1.dataValidation(sender, e);
        }

        //validate halfdays input
        private void AddingHalfWorkDays_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            try
            {
                dataValidationOfFullAndHalfDaysCommand1.dataValidation(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
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
            try
            {
                yearAndMonthIsInRangeCheckCommand1.validateYearAndMonth(this, connection);
                if (yearAndMonthIsInRangeCheckCommand1.flag == 1)
                {
                    dataSendToTemperoryTableCommand1.dataSendAfterValidate(this, connection);
                    dataSeeBtnClickCommand1.DataseeButtonClick(dataShowingTable, connection,this);
                    lastAddedIDShowingLable.Content = InternID.Text;
                }
                else if (yearAndMonthIsInRangeCheckCommand1.flag == 0)
                {
                    MessageBox.Show("Entered month or year is out of bound", "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                }

            }catch (Exception ex){}
             
        }


        //add new record - clrear all fields for add new
        private void AddNewRecord_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                cleanFieldsToAddNewDataCommand1.cleanFieldsToAddNewData(this, connection);

            }catch (Exception ex) { }
        }


        //update existing data of the data grid view 
        private void UpdateExistingRecord_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                yearAndMonthIsInRangeCheckCommand1.validateYearAndMonth(this, connection);
                if (yearAndMonthIsInRangeCheckCommand1.flag == 1)
                {
                    selectedGridDataUpdateCommand1.dataUpdateAndSaveTotheTable(this, connection);
                    dataSeeBtnClickCommand1.DataseeButtonClick(dataShowingTable, connection, this);
                }
                else if (yearAndMonthIsInRangeCheckCommand1.flag == 0)
                {
                    MessageBox.Show("Entered month or year is out of bound", "Error", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                }

            }
            catch (Exception ex) { }
        }


        //delete selected data from the dataGrid
        private void DeleteExistingRecord_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                deleteSelectedDataFromTemperarydataTableCommand1.deleteDataFromTemperaryDataTablePermenently(this, connection);
                dataSeeBtnClickCommand1.DataseeButtonClick(dataShowingTable, connection, this);
            }
            catch(Exception ex) { }

        }

        //serchbox ID search btn click
        private void SearchIsIDInGridView_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                searchBarButtonInUCforSalaryEnteringCommand1.searchedIDIsCheckIfThereIsOrIsNot(this, connection);
                
            }
            catch(Exception ex) { }
            
        }

        //autofill data enterings to help if there is some update > then can do easily
        private void SearchResultOfTemperaryDataTableGridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SearchDataGridViewDataAutoFillWhenclickOnCommand1.searchedResultDataSelectionAutofill(this);
        }


        //export button enable
        /*private void theFolderNameToSavePaySheet_TextChanged(object sender, TextChangedEventArgs e)
        {
            dataExportToaTextFile.IsEnabled = true;
        }*/

        //button for export temperary data to a text file as bank pay sheet style and save a selected loacation
        private void dataExportToaTextFile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                exportTemperaryDataToATextFileAsBankPaySheetCommand1.exportDatatoSaaryTableAndSaveAsBankPaysheetTxtFile(this, connection);
                temperaryDataSendToPaidSalaryTableCommand1.sendDataToAllSalaryDetails(this, connection);
                //theFolderNameToSavePaySheet.Clear();
                dataSeeBtnClickCommand1.DataseeButtonClick(dataShowingTable, connection, this);

                //add dta to permenent table


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error popup | Saving process crashed | try again",MessageBoxButton.OK,MessageBoxImage.Error);
            }
            
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
        SelectedGridDataUpdateCommand selectedGridDataUpdateCommand1 = new SelectedGridDataUpdateCommand();
        DeleteSelectedDataFromTemperarydataTableCommand deleteSelectedDataFromTemperarydataTableCommand1 = new DeleteSelectedDataFromTemperarydataTableCommand();
        SearchBarButtonInUCforSalaryEnteringCommand searchBarButtonInUCforSalaryEnteringCommand1 = new SearchBarButtonInUCforSalaryEnteringCommand();
        SearchDataGridViewDataAutoFillWhenclickOnCommand SearchDataGridViewDataAutoFillWhenclickOnCommand1 = new SearchDataGridViewDataAutoFillWhenclickOnCommand();
        ExportTemperaryDataToATextFileAsBankPaySheetCommand exportTemperaryDataToATextFileAsBankPaySheetCommand1 = new ExportTemperaryDataToATextFileAsBankPaySheetCommand();
        TemperaryDataSendToPaidSalaryTableCommand temperaryDataSendToPaidSalaryTableCommand1 = new TemperaryDataSendToPaidSalaryTableCommand();
        FileNameNamingControlCommand fileNameNamingControlCommand1 = new FileNameNamingControlCommand();
        private void StackPanel_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }

        private void yy_TextChanged(object sender, TextChangedEventArgs e)
        {
            fileNameNamingControlCommand1.fileNameNaming(this, sender, e);
        }

        private void yy_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                // Limit the length of the entered text to 2 characters
                if (textBox.Text.Length == 2)
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
        }

        

















        //testing-------------------



    }


}
