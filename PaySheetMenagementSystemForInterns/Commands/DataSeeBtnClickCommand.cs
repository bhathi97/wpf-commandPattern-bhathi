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
using System.Windows.Forms;

namespace PaySheetMenagementSystemForInterns.Commands
{
    class DataSeeBtnClickCommand
    {
        public void DataseeButtonClick(DataGrid grid, SqlConnection con, UserControlForSalaryEnteringWindow obj)
        {
            

            try
            {
                con.Open();
                SqlCommand sqlcommand = new SqlCommand("select * from [TEMP_SALARY-DETAILS_TRAINEE]", con);
                SqlDataAdapter sqldataadapter = new SqlDataAdapter(sqlcommand);
                DataTable showdatatable = new DataTable();
                sqldataadapter.Fill(showdatatable);
                obj.dataShowingTable.AutoGenerateColumns = false;
                grid.ItemsSource = showdatatable.DefaultView;

            }
            catch(Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message,"Error",MessageBoxButton.OK,MessageBoxImage.Error);
            }
            finally { con.Close(); }
            obj.sayToClickEyeButtonLbl.Content = "Temparary Data Table";



        }

    }
}
