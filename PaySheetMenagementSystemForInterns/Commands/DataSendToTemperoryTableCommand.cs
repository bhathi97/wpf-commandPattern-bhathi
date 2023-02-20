using PaySheetMenagementSystemForInterns.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PaySheetMenagementSystemForInterns.Commands
{
    class DataSendToTemperoryTableCommand : EmptyBoxesCheckCommand
    {
        public void dataSendAfterValidate(UserControlForSalaryEnteringWindow obj, SqlConnection connection)
        {
            try
            {
                if (emptyComboBoxCheck(obj) == 0 && emptyTextBoxCheck(obj) == 0) //empty fields check
                {
                    try
                    {
                        connection.Open();
                        //validate - check if the data allready in the SalaryStoreTable or temperarySalaryTable
                        //check salarySotere table
                        // create a SQL query using parameterized queries
                        string sqlQuery0 = "SELECT count([Trainee No]) FROM [ALL_SALARY-DETAILS_TRAINEE] WHERE [Trainee No] = @InternID AND Month = @AddingMonth AND Year = @AddingYear AND [Account No] = @InternBankAccNo";
                        // create a SqlCommand object and set the parameter values
                        SqlCommand command0 = new SqlCommand(sqlQuery0, connection);
                        command0.Parameters.AddWithValue("@InternID", obj.InternID.Text);
                        command0.Parameters.AddWithValue("@AddingMonth", obj.AddingMonth.Text);
                        command0.Parameters.AddWithValue("@AddingYear", obj.AddingYear.Text);
                        command0.Parameters.AddWithValue("@InternBankAccNo", obj.InternBankAccNo.Text);
                        // create a SqlDataAdapter and fill the DataTable with the query result
                        SqlDataAdapter sda1 = new SqlDataAdapter(command0);
                        DataTable dt1 = new DataTable();
                        sda1.Fill(dt1);
                            
                        // Create a parameterized query to check the temporary table
                        SqlCommand cmd2 = new SqlCommand("SELECT COUNT([Trainee No]) FROM [TEMP_SALARY-DETAILS_TRAINEE] WHERE [Trainee No] = @InternID", connection);
                        cmd2.Parameters.AddWithValue("@InternID", obj.InternID.Text);
                        // Create a data adapter to fill the DataTable with the result of the query
                        SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                        DataTable dt2 = new DataTable();
                        sda2.Fill(dt2);


                        //check thet Id in the master table
                        // Create a parameterized query to check the MASTER-DETAILS_TRAINEE table
                        SqlCommand cmd3 = new SqlCommand("SELECT COUNT([Trainee No]) FROM [MASTER-DETAILS_TRAINEE] WHERE [Trainee No] = @InternID", connection);
                        cmd3.Parameters.AddWithValue("@InternID", obj.InternID.Text);
                        // Create a data adapter to fill the DataTable with the result of the query
                        SqlDataAdapter sda3 = new SqlDataAdapter(cmd3);
                        DataTable dt3 = new DataTable();
                        sda3.Fill(dt3);

                        if (dt2.Rows[0][0].ToString() != "0")
                        {
                            MessageBox.Show("User is already added", " Error ", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                        }


                        else if (dt3.Rows[0][0].ToString() == "0")
                        {
                            MessageBox.Show("User is Invalid", " Error ", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                        }

                        else if (dt1.Rows[0][0].ToString() == "0" && dt2.Rows[0][0].ToString() == "0")
                        {

                            //data insert query               
                            // create a SQL query using parameterized queries
                            string sqlQuery = "INSERT INTO [TEMP_SALARY-DETAILS_TRAINEE] ([Trainee No], [Account No], Month , Year, [Bank Name], [Bank Code], [Branch Name], [Branch Code], [Work Days- FULL], [Work Days- HALF],[Work Days- Total], [Salary Amount], Name) " +
                                "VALUES (@InternID, @InternBankAccNo, @AddingMonth, @AddingYear, @InternBankName, @InternBankCode, @InternBranchName, @InternBranchCode, @AddingFullWorkDays, @AddingHalfWorkDays, @ShowTotalWorkDays, @ShowTotalSalary, @InternName)";

                            // create a SqlCommand object and set the parameter values
                            using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                            {
                                command.Parameters.AddWithValue("@InternID", obj.InternID.Text);
                                command.Parameters.AddWithValue("@InternBankAccNo", obj.InternBankAccNo.Text);
                                command.Parameters.AddWithValue("@AddingMonth", obj.AddingMonth.Text);
                                command.Parameters.AddWithValue("@AddingYear", int.Parse(obj.AddingYear.Text));
                                command.Parameters.AddWithValue("@InternBankName", obj.InternBankName.Text);
                                command.Parameters.AddWithValue("@InternBankCode", obj.InternBankCode.Text);
                                command.Parameters.AddWithValue("@InternBranchName", obj.InternBranchName.Text);
                                command.Parameters.AddWithValue("@InternBranchCode", obj.InternBranchCode.Text);
                                command.Parameters.AddWithValue("@AddingFullWorkDays", int.Parse(obj.AddingFullWorkDays.Text));
                                command.Parameters.AddWithValue("@AddingHalfWorkDays", int.Parse(obj.AddingHalfWorkDays.Text));
                                command.Parameters.AddWithValue("@ShowTotalWorkDays", float.Parse(obj.ShowTotalWorkDays.Text));
                                command.Parameters.AddWithValue("@ShowTotalSalary", float.Parse(obj.ShowTotalSalary.Text));
                                command.Parameters.AddWithValue("@InternName", obj.InternName.Text);

                                // execute the query
                                command.ExecuteNonQuery();
                            }

                            MessageBox.Show("Successfully added to the table", "success", MessageBoxButton.OK, MessageBoxImage.Information);

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButton.OKCancel);
                    }
                    finally
                    {
                        connection.Close();

                    }
                }
            }
            catch (Exception ex)
            {
                
            }
            
        }

        

    }
}
