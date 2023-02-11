using Microsoft.Win32;
using PaySheetMenagementSystemForInterns.Classes;
using PaySheetMenagementSystemForInterns.Views.UserControlsForAddNewToMAsterTableContent;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PaySheetMenagementSystemForInterns.Commands
{
    class ImportExelDataToMasterDataTableCommand
    {
        public void dataGridFillUsingExelData(UserControlForDataImportFromExcel obj)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.ShowDialog();
                

                Trainee trainee = new Trainee();
                string[] TraineeArray;

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Trainee No", typeof(string));
                dataTable.Columns.Add("Name",typeof(string));
                dataTable.Columns.Add("ID",typeof(string));
                dataTable.Columns.Add("Location",typeof(string));
                dataTable.Columns.Add("Should pay or no",typeof(string));
                dataTable.Columns.Add("Telephone No", typeof(int));
                dataTable.Columns.Add("Start Date", typeof(DateOnly));
                dataTable.Columns.Add("End Date", typeof(DateOnly));
                dataTable.Columns.Add("Months",typeof(string));


                using (StreamReader streamReader = new StreamReader(openFileDialog.FileName))
                {
                    while (!streamReader.EndOfStream)
                    {
                        TraineeArray = streamReader.ReadLine().Split(";");

                        trainee.TraineeNo = TraineeArray[0];
                        trainee.Name = TraineeArray[1];
                        trainee.ID = TraineeArray[2];
                        trainee.Location = TraineeArray[3];
                        trainee.ShouldPay = TraineeArray[4];
                        trainee.TelephoneNo = TraineeArray[5];
                        trainee.StartDate = DateOnly.Parse(TraineeArray[6]);
                        trainee.EndDate = DateOnly.Parse(TraineeArray[7]);
                        trainee.Months = TraineeArray[8];

                        dataTable.Rows.Add(trainee.TraineeNo, trainee.Name, trainee.ID, trainee.Location, trainee.ShouldPay, trainee.TelephoneNo, trainee.StartDate, trainee.EndDate, trainee.Months);
                    }

                    DataView dataView = new DataView(dataTable);
                    obj.importedDataShowingTable.ItemsSource = dataView;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"ERROR",MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}