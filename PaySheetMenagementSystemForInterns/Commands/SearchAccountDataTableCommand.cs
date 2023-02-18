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
    internal class SearchAccountDataTableCommand
    {
        public void SearchAccountDataTableCommandFromDB(UserControlForSalaryDetailsShowing obj, SqlConnection conn)
        {
            //get selection of comboBox and store it in a variable 
            //there ara always a selection -> so no null passing
            string key = obj.searchCombo.SelectionBoxItem.ToString();

            //when search box is not emty
            if (!(string.IsNullOrEmpty(obj.MasterTableSearchTextBox.Text)))
            {
                //gate function to load data
                //when select the trainee Number
                if (key == "Trainee Number")
                {
                    try
                    {
                        conn.Open();
                        //let check the data is available
                        SqlDataAdapter sda = new SqlDataAdapter("SELECT count([Trainee No]) FROM [BANK-ACCOUNTS_TRAINEE] WHERE [Trainee No] LIKE '%" + obj.MasterTableSearchTextBox.Text + "%'", conn);
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
                            SqlCommand cmd = new SqlCommand("SELECT * FROM [BANK-ACCOUNTS_TRAINEE] WHERE [Trainee No] LIKE '%" + obj.MasterTableSearchTextBox.Text + "%'", conn);
                            conn.Close();
                            SqlDataAdapter sda1 = new SqlDataAdapter(cmd);
                            DataTable showdatatable = new DataTable();
                            showdatatable.AcceptChanges();
                            sda1.Fill(showdatatable);
                            obj.AccountDetailsTableViewDataGrid.ItemsSource = showdatatable.DefaultView;
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Double Check the Trainee Number", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                if(key == "Bank Name")
                {
                    try
                    {
                        conn.Open();
                        //let check the data is available
                        SqlDataAdapter sda = new SqlDataAdapter("SELECT count([Trainee No]) FROM [BANK-ACCOUNTS_TRAINEE] WHERE [Bank Name] LIKE '%" + obj.MasterTableSearchTextBox.Text + "%'", conn);
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
                            SqlCommand cmd = new SqlCommand("SELECT * FROM [BANK-ACCOUNTS_TRAINEE] WHERE [Bank Name] LIKE '%" + obj.MasterTableSearchTextBox.Text + "%'", conn);
                            conn.Close();
                            SqlDataAdapter sda1 = new SqlDataAdapter(cmd);
                            DataTable showdatatable = new DataTable();
                            showdatatable.AcceptChanges();
                            sda1.Fill(showdatatable);
                            obj.AccountDetailsTableViewDataGrid.ItemsSource = showdatatable.DefaultView;
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Double Check the Bank Name", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                if (key == "Branch Name")
                {
                    try
                    {
                        conn.Open();
                        //let check the data is available
                        SqlDataAdapter sda = new SqlDataAdapter("SELECT count([Trainee No]) FROM [BANK-ACCOUNTS_TRAINEE] WHERE [Branch Name] LIKE '%" + obj.MasterTableSearchTextBox.Text + "%'", conn);
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
                            SqlCommand cmd = new SqlCommand("SELECT * FROM [BANK-ACCOUNTS_TRAINEE] WHERE [Branch Name] LIKE '%" + obj.MasterTableSearchTextBox.Text + "%'", conn);
                            conn.Close();
                            SqlDataAdapter sda1 = new SqlDataAdapter(cmd);
                            DataTable showdatatable = new DataTable();
                            showdatatable.AcceptChanges();
                            sda1.Fill(showdatatable);
                            obj.AccountDetailsTableViewDataGrid.ItemsSource = showdatatable.DefaultView;
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Double Check the Branch Name", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                if (key == "Trainee Name")
                {
                    try
                    {
                        conn.Open();
                        //let check the data is available
                        SqlDataAdapter sda = new SqlDataAdapter("SELECT count([Trainee No]) FROM [BANK-ACCOUNTS_TRAINEE] WHERE [Trainee Name] LIKE '%" + obj.MasterTableSearchTextBox.Text + "%'", conn);
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
                            SqlCommand cmd = new SqlCommand("SELECT * FROM [BANK-ACCOUNTS_TRAINEE] WHERE [Trainee Name] LIKE '%" + obj.MasterTableSearchTextBox.Text + "%'", conn);
                            conn.Close();
                            SqlDataAdapter sda1 = new SqlDataAdapter(cmd);
                            DataTable showdatatable = new DataTable();
                            showdatatable.AcceptChanges();
                            sda1.Fill(showdatatable);
                            obj.AccountDetailsTableViewDataGrid.ItemsSource = showdatatable.DefaultView;
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Double Check the Trainee Name", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
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
