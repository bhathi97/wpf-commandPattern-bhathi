using PaySheetMenagementSystemForInterns.Views.UserControlsForAddNewToMAsterTableContent;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace PaySheetMenagementSystemForInterns.Commands
{
    class MasterDataShowingCommand
    {
        public void MasterDAtaLoadTogridView(UserControlForMasterDataShowing obj, SqlConnection con)
        {
            try
            {
                con.Open();
                SqlCommand sqlcommand = new SqlCommand("select * from [MASTER-DETAILS_TRAINEE]", con);
                SqlDataAdapter sqldataadapter = new SqlDataAdapter(sqlcommand);
                DataTable showdatatable = new DataTable();
                sqldataadapter.Fill(showdatatable);
                //obj.masterTableViewDataGrid.AutoGenerateColumns = false;
                obj.masterTableViewDataGrid.ItemsSource = showdatatable.DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally { con.Close(); }

        }
    }
}
