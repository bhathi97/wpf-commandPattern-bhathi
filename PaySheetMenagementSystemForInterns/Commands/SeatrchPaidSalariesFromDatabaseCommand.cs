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
    internal class SeatrchPaidSalariesFromDatabaseCommand
    {
        public void searchSalariDetailsFromDB(UserControlForPaidSalaryDetailsShowing obj, SqlConnection conn)
        {
            //get selection of comboBox and store it in a variable 
            //there ara always a selection -> so no null passing
            string key = obj.searchCombo.SelectionBoxItem.ToString();

            if (!(string.IsNullOrEmpty(obj.MasterTableSearchTextBox.Text)))
            {
                //gate function to load data
                //when select the month
                if (key == "Month")
                {
                    try
                    {
                        conn.Open();

                        //let check the data is available
                        SqlDataAdapter sda = new SqlDataAdapter("SELECT count([Trainee No]) FROM [ALL_SALARY-DETAILS_TRAINEE] WHERE [Month] LIKE '%" + obj.MasterTableSearchTextBox.Text + "%'", conn);
                        DataTable dt = new DataTable();
                        dt.AcceptChanges();
                        sda.Fill(dt);

                        if (dt.Rows[0][0].ToString() == "0")
                        {
                            MessageBox.Show("No Data available", " Error ", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                            conn.Close();
                        }
                        else //if there is data available then data
                        {
                            SqlCommand cmd = new SqlCommand("SELECT * FROM [ALL_SALARY-DETAILS_TRAINEE] WHERE [Month] LIKE '%" + obj.MasterTableSearchTextBox.Text + "%'", conn);
                            conn.Close();
                            SqlDataAdapter sda1 = new SqlDataAdapter(cmd);
                            DataTable showdatatable = new DataTable();
                            showdatatable.AcceptChanges();
                            sda1.Fill(showdatatable);
                            obj.PaidSalaryDetailsTableViewDataGrid.ItemsSource = showdatatable.DefaultView;
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Double Check the Month", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                    finally
                    {
                        conn.Close();
                    }

                }
                //when the trainee number is selected
                if (key == "Trainee Number")
                {
                    try
                    {
                        conn.Open();

                        //let check the data is available
                        SqlDataAdapter sda = new SqlDataAdapter("SELECT count([Trainee No]) FROM [ALL_SALARY-DETAILS_TRAINEE] WHERE [Trainee No] LIKE '" + obj.MasterTableSearchTextBox.Text + "'", conn);
                        DataTable dt = new DataTable();
                        dt.AcceptChanges();
                        sda.Fill(dt);

                        if (dt.Rows[0][0].ToString() == "0")
                        {
                            MessageBox.Show("No Data available", " Error ", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                            conn.Close();
                        }
                        else //if there is data available then data
                        {
                            SqlCommand cmd = new SqlCommand("SELECT * FROM [ALL_SALARY-DETAILS_TRAINEE] WHERE [Trainee No] = '" + obj.MasterTableSearchTextBox.Text + "'", conn);
                            conn.Close();
                            SqlDataAdapter sda1 = new SqlDataAdapter(cmd);
                            DataTable showdatatable = new DataTable();
                            showdatatable.AcceptChanges();
                            sda1.Fill(showdatatable);
                            obj.PaidSalaryDetailsTableViewDataGrid.ItemsSource = showdatatable.DefaultView;
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Double Check the Trainee number", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                    finally
                    {
                        conn.Close();
                    }


                }
               

            }
        }
    }
}
