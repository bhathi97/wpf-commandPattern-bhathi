using PaySheetMenagementSystemForInterns.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PaySheetMenagementSystemForInterns.Commands
{
    class DataSeeBtnClickCommand
    {
        public void DataseeButtonClick(DataGrid grid, SqlConnection con, UserControlForSalaryEnteringWindow obj)
        {
            SqlCommand sqlcommand = new SqlCommand("select * from TempararySalaryTable", con);
            SqlDataAdapter sqldataadapter = new SqlDataAdapter(sqlcommand);
            DataTable showdatatable = new DataTable();
            sqldataadapter.Fill(showdatatable);
            grid.ItemsSource = showdatatable.DefaultView;

            obj.sayToClickEyeButtonLbl.Content = "Temparary Data Table"; 

        }

    }
}
