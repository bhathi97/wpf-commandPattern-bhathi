using PaySheetMenagementSystemForInterns.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace PaySheetMenagementSystemForInterns.Commands
{
    class SearchBarButtonInUCforSalaryEnteringCommand

        //have to implememt
    {
        public void searchedIDIsCheckIfThereIsOrIsNot(UserControlForSalaryEnteringWindow obj, SqlConnection connection)
        {
            //check is there any input
            if (string.IsNullOrEmpty(obj.IDforSearch.Text)) 
            { 
                MessageBox.Show("Enter Trainee No before click the button", "Oops!", MessageBoxButton.OK, MessageBoxImage.Warning);
                obj.IDforSearch.Focus();
            }

            //if there is data lets check is it in the grid
            if (!(string.IsNullOrEmpty(obj.IDforSearch.Text)))
            {
                try
                {
                    connection.Open();


                    //****************updated. but not checked


                    //check is that data available
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT count([Trainee No]) FROM [TEMP_SALARY-DETAILS_TRAINEE] WHERE [Trainee No] = @TID ", connection);
                    sda.SelectCommand.Parameters.AddWithValue("@TID", obj.IDforSearch.Text);
                    DataTable dt = new DataTable();
                    dt.AcceptChanges();
                    sda.Fill(dt);

                    if (dt.Rows[0][0].ToString() == "0")
                    {
                        MessageBox.Show("Trainee No is unavailable", " Error ", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                        
                    }
                    else
                    {
                        SqlCommand sqlcommandforsearch = new SqlCommand("SELECT * FROM [TEMP_SALARY-DETAILS_TRAINEE] WHERE [Trainee No] = '" + obj.IDforSearch.Text + "'", connection);
                        SqlDataAdapter sda1 = new SqlDataAdapter(sqlcommandforsearch);
                        DataTable showdatatable = new DataTable();
                        showdatatable.AcceptChanges();
                        sda1.Fill(showdatatable);
                        obj.SearchResultOfTemperaryDataTableGridView.ItemsSource = showdatatable.DefaultView;
                        

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Error",MessageBoxButton.OK, MessageBoxImage.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
