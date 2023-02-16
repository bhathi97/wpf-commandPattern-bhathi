using PaySheetMenagementSystemForInterns.Views;
using PaySheetMenagementSystemForInterns.Views.UserControlsForAddNewToMAsterTableContent;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PaySheetMenagementSystemForInterns.Commands
{
    internal class NewTraineeDataSendToDataBaseCommand : EmptyBoxesOFNewUserAddingCheckCommand
    {
        public void addNewTraineeToDataTables(UserControlForAddNewTraineeToTheDataBase obj, SqlConnection conn)
        {
            try
            {
                //check empty boxes
                if (emptyComboBoxCheck(obj) == 0 && emptyTextBlockCheck(obj) == 0 && emptyTextBoxCheck(obj) == 0 )
                {
                    //check dates asre okay
                    DateTime startDate = obj.TraineeStartDateToDB.SelectedDate.Value;
                    DateTime endDate = obj.TraineeEndtDateToDB.SelectedDate.Value;
                    int Months = endDate.Month - startDate.Month;

                    if (startDate < endDate)
                    {


                        try
                        {
                            conn.Open();
                            //validate - check if the data allready in the Master table
                            SqlDataAdapter sda1 = new SqlDataAdapter("SELECT count([Trainee No]) FROM [MASTER-DETAILS_TRAINEE] WHERE [Trainee No] ='" + obj.TraineeNumberToDB.Text + "'",conn);
                            DataTable dt1 = new DataTable();
                            dt1.AcceptChanges();
                            sda1.Fill(dt1);


                            if (dt1.Rows[0][0].ToString() == "0")
                            {
                                SqlCommand sqlCommand1 = new SqlCommand("INSERT INTO [MASTER-DETAILS_TRAINEE] ([Trainee No],[Name],[ID],[Location],[Should pay or no],[Telephone No],[Start Date],[End Date],[Months]) VALUES ('" + obj.TraineeNumberToDB.Text +  "','" + obj.TraineeNameToDB.Text + "','" + obj.TraineeIDToDB.Text + "','" + obj.TraineeLocationToDB.Text + "','" + obj.TraineeShouPayOrNoToDB.Text + "','" + int.Parse(obj.TraineeTelephoneNoToDB.Text) + "','" + DateOnly.Parse(obj.TraineeStartDateToDB.Text) + "','" + DateOnly.Parse(obj.TraineeEndtDateToDB.Text) + "','"  + Months + "')", conn);
                                SqlCommand sqlCommand2 = new SqlCommand("INSERT INTO [BANK-ACCOUNTS_TRAINEE] ([Trainee No],[Name]),[Account No],[Bank Name],[Bank Code],[Branch Name],[Branch Code]) VALUES ('" + obj.TraineeNumberToDB.Text + "','" + obj.TraineeNameToDB.Text + "','" + obj.TraineeBankAccNoToDB.Text + "','" + obj.TraineeBankNameToDB.Text + "','" + obj.TraineeBankCodeToDB + "','" + obj.TraineeBranchNameToDB.Text + "','" + obj.TraineeBranchCodeToDB.Text + "')", conn);
                                sqlCommand1.ExecuteNonQuery();
                                sqlCommand2.ExecuteNonQuery();

                                MessageBox.Show("New Trainee added to the DataBase", "SUCCESS" , MessageBoxButton.OK, MessageBoxImage.Exclamation);

                            }


                            if (dt1.Rows[0][0].ToString() != "0")
                            {
                                MessageBox.Show("User is already added", " Error ", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                            }

                        }catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        



                    }
                    else
                    {
                        MessageBox.Show("End date is earlier or equal to Start date.");
                    }

                }

            }catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            
        }
    }
}
