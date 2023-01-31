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
            if (emptyComboBoxCheck(obj) == 0 && emptyTextBoxCheck(obj) == 0)
            {
                try
                {
                    connection.Open();
                    //validate - check if the data allready in the SalaryStoreTable or temperarySalaryTable
                    //check salarySotere table
                    SqlDataAdapter sda1 = new SqlDataAdapter("SELECT count(ID) FROM SalaryStoreTable WHERE ID ='" + obj.InternID.Text + "' AND Month ='" + obj.AddingMonth.Text + "' AND Year ='" + obj.AddingYear.Text + "' AND AccountNo ='" + obj.InternBankAccNo.Text + "'", connection);
                    DataTable dt1 = new DataTable();
                    dt1.AcceptChanges();
                    sda1.Fill(dt1);

                    //check temperary table
                    SqlDataAdapter sda2 = new SqlDataAdapter("SELECT count(ID) FROM TempararySalaryTable WHERE ID ='" + obj.InternID.Text + "'", connection);
                    DataTable dt2 = new DataTable();
                    dt2.AcceptChanges();
                    sda2.Fill(dt2);

                    //check thet Id in the master table
                    SqlDataAdapter sda3 = new SqlDataAdapter("SELECT count(ID) FROM InternsMasterTable WHERE ID ='" + obj.InternID.Text + "'", connection);
                    DataTable dt3 = new DataTable();
                    dt3.AcceptChanges();
                    sda3.Fill(dt3);

                    if (dt3.Rows[0][0].ToString() == "0")
                    {
                        MessageBox.Show("User is Invalid", " Error ", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                    }

                    else if (dt1.Rows[0][0].ToString() == "0" && dt2.Rows[0][0].ToString() == "0")
                    {
                        
                                        
                        SqlCommand c1 = new SqlCommand("INSERT INTO TempararySalaryTable (ID, AccountNo, Month , Year, BankName, BankCode, BranchName, BranchCode, SalaryPerDay, FullWorkDays, HalfWorkDays,TotalWorkDays, TotalSalaryAmount, Name) VALUES ('" + obj.InternID.Text + "','" + obj.InternBankAccNo.Text + "','" + obj.AddingMonth.Text + "','" + int.Parse(obj.AddingYear.Text) + "','" + obj.InternBankName.Text + "','" + obj.InternBankCode.Text + "','" + obj.InternBranchName.Text + "','" + obj.InternBranchCode.Text + "','" + float.Parse(obj.InternSalaryPerDay.Text) + "','" + int.Parse(obj.AddingFullWorkDays.Text) + "','" + int.Parse(obj.AddingHalfWorkDays.Text) + "','" + float.Parse(obj.ShowTotalWorkDays.Text) + "','" + float.Parse(obj.ShowTotalSalary.Text) + "','" + obj.InternName.Text + "')", connection);
                        c1.ExecuteNonQuery();
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

        

    }
}
