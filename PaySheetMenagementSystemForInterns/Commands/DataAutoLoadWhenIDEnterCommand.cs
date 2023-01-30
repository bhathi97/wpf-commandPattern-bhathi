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
                SqlCommand commandAutofillFields = new SqlCommand("SELECT * FROM InternsMasterTable WHERE ID = '" + obj.InternID.Text + "'", connection);
                SqlDataReader dataReader = commandAutofillFields.ExecuteReader();
                while (dataReader.Read())
                {
                    obj.InternName.Text = dataReader["Name"].ToString();
                    obj.InternBankAccNo.Text = dataReader["BankAccountNo"].ToString();
                    obj.InternBankName.Text = dataReader["BankName"].ToString();
                    obj.InternBankCode.Text = dataReader["BankCode"].ToString();
                    obj.InternBranchName.Text = dataReader["BranchName"].ToString();
                    obj.InternBranchCode.Text = dataReader["BranchCode"].ToString();
                    obj.InternSalaryPerDay.Text = dataReader["SalaryPerDay"].ToString();
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
