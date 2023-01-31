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
    class SearchBarButtonInUCforSalaryEnteringCommand

        //have to implememt
    {
        public void searchedIDIsCheckIfThereIsOrIsNot(UserControlForSalaryEnteringWindow obj, SqlConnection connection)
        {
            //check is there any input
            if (string.IsNullOrEmpty(obj.IDforSearch.Text)) 
            { 
                MessageBox.Show("Enter ID before click the button", "Oops!", MessageBoxButton.OK, MessageBoxImage.Warning);
                obj.IDforSearch.Focus();
            }

            //if there is data lets check is it in the grid
            if (!(string.IsNullOrEmpty(obj.IDforSearch.Text)))
            {
                try
                {
                    connection.Open();

                    //check is that data available
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT count(ID) FROM TempararySalaryTable WHERE ID = '" + obj.IDforSearch.Text + "'", connection);
                    DataTable dt = new DataTable();
                    dt.AcceptChanges();
                    sda.Fill(dt);

                    if (dt.Rows[0][0].ToString() == "0")
                    {
                        MessageBox.Show("ID is unavailable", " Error ", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                        
                    }
                    else
                    {
                        SqlCommand sqlcommandforsearch = new SqlCommand("SELECT Month,TotalSalaryAmount,AccountNo FROM TempararySalaryTable WHERE ID = '" + obj.IDforSearch.Text + "'", connection);
                        SqlDataAdapter sda1 = new SqlDataAdapter(sqlcommandforsearch);
                        DataTable showdatatable = new DataTable();
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
