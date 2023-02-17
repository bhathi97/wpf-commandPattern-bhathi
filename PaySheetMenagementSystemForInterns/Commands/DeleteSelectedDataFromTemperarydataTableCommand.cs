using PaySheetMenagementSystemForInterns.Views;
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
    class DeleteSelectedDataFromTemperarydataTableCommand
    {
        public void deleteDataFromTemperaryDataTablePermenently(UserControlForSalaryEnteringWindow obj, SqlConnection connection)
        {
            //let check ID field is empty
            if (string.IsNullOrEmpty(obj.InternID.Text)) MessageBox.Show("Wrong command","Warning!",MessageBoxButton.OK,MessageBoxImage.Warning);

            //let chech that ID data in the temperary data table and do the deletion
            if (!(string.IsNullOrEmpty(obj.InternID.Text)))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter sda1 = new SqlDataAdapter("SELECT count([Trainee No]) FROM [TEMP_SALARY-DETAILS_TRAINEE] WHERE [Trainee No] ='" + obj.InternID.Text + "'", connection);
                    DataTable dt1 = new DataTable();
                    dt1.AcceptChanges();
                    sda1.Fill(dt1);

                    if (dt1.Rows[0][0].ToString() == "0")
                    {
                        MessageBox.Show("Already deleted or wrong ID", " Error ", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                    }
                    //if the ID is inthe table, the do the deletion
                    else if(dt1.Rows[0][0].ToString() != "0")
                    {
                        if ((MessageBox.Show("Do you Want to delete " + obj.InternID.Text + " from the datatable?", "Warning", MessageBoxButton.OKCancel, MessageBoxImage.Warning)) == MessageBoxResult.OK)
                        {
                            try
                            {
                                //delete coomand
                                SqlCommand sqlCommandDelete = new SqlCommand("DELETE FROM [TEMP_SALARY-DETAILS_TRAINEE] WHERE [Trainee No] = '" + obj.InternID.Text + "'", connection);
                                sqlCommandDelete.ExecuteNonQuery();
                                MessageBox.Show("Successfully deleted", "success", MessageBoxButton.OK, MessageBoxImage.Information);

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                            }
                            
                        }
                    }

                }
                catch(Exception ex) 
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                finally { connection.Close(); }

                
            }

        }
    }
}
