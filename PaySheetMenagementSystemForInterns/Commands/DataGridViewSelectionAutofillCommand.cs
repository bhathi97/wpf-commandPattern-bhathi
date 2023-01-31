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
    class DataGridViewSelectionAutofillCommand
    {
        public void dataSelectionAutofill(UserControlForSalaryEnteringWindow obj, SqlConnection connection)
        {
            DataGrid dataGrid = (DataGrid)obj.dataShowingTable;
            DataRowView rowView = dataGrid.SelectedItem as DataRowView;
            if (rowView != null)
            {
                obj.InternID.Text = rowView["ID"].ToString();
                obj.AddingMonth.Text = rowView["Month"].ToString();
                obj.AddingYear.Text = rowView["Year"].ToString();
                obj.AddingFullWorkDays.Text = rowView["FullWorkDays"].ToString();
                obj.AddingHalfWorkDays.Text = rowView["HalfWorkDays"].ToString();
            }
        }
    }
}
