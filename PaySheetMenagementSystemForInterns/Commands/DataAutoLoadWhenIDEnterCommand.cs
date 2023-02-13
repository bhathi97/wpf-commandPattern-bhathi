using PaySheetMenagementSystemForInterns.Views;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace PaySheetMenagementSystemForInterns.Commands
{
    class DataAutoLoadWhenIDEnterCommand
    {
        
        public void dataAutoLoad(UserControlForSalaryEnteringWindow obj, SqlConnection connection)
        {
            
            try
            {
                connection.Open();
                SqlCommand commandAutofillFields = new SqlCommand("SELECT * FROM [BANK-ACCOUNTS_TRAINEE] WHERE [Trainee No] = '" + obj.InternID.Text + "'", connection);
                SqlDataReader dataReader = commandAutofillFields.ExecuteReader();
                while (dataReader.Read())
                {
                    obj.InternName.Text = dataReader["Name"].ToString();
                    obj.InternBankAccNo.Text = dataReader["Account No"].ToString();
                    obj.InternBankName.Text = dataReader["Bank Name"].ToString();
                    obj.InternBankCode.Text = dataReader["Bank Code"].ToString();
                    obj.InternBranchName.Text = dataReader["Branch Name"].ToString();
                    obj.InternBranchCode.Text = dataReader["Branch Code"].ToString();
                    obj.InternSalaryPerDay.Text = "500";
                }

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "loading error1", MessageBoxButton.OK);
            }
            finally
            {
                connection.Close();
            }            
        }
    }
}
