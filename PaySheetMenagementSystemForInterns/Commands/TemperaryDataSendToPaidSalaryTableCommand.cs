using PaySheetMenagementSystemForInterns.Classes;
using PaySheetMenagementSystemForInterns.Views;

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace PaySheetMenagementSystemForInterns.Commands
{
    internal class TemperaryDataSendToPaidSalaryTableCommand
    {
        public void sendDataToAllSalaryDetails(UserControlForSalaryEnteringWindow obj , SqlConnection conn)
        {
            //obj.dataShowingTable
            try
            {
                conn.Open();
                // Retrieve the data from the source table
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM [TEMP_SALARY-DETAILS_TRAINEE]", conn))
                {
                    DataTable sourceData = new DataTable();
                    adapter.Fill(sourceData);

                    // Insert the data into the destination table
                    using (SqlBulkCopy bulkCopy = new SqlBulkCopy(conn))
                    {
                        bulkCopy.DestinationTableName = "[ALL_SALARY-DETAILS_TRAINEE]";
                        bulkCopy.WriteToServer(sourceData);
                    }
                }

                // Clear the data from the source table
                using (SqlCommand cmd = new SqlCommand("TRUNCATE TABLE [TEMP_SALARY-DETAILS_TRAINEE]", conn))
                {
                    cmd.ExecuteNonQuery();
                }

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
        }
    }
}
