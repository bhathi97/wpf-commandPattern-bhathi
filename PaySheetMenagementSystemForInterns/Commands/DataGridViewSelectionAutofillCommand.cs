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
        public void dataSelectionAutofill(UserControlForSalaryEnteringWindow obj)
        {
            DataGrid dataGrid = (DataGrid)obj.dataShowingTable;
            DataRowView rowView = dataGrid.SelectedItem as DataRowView;

            if (rowView != null)
            {
                obj.InternID.Text = rowView["Trainee No"].ToString();
                obj.AddingMonth.Text = rowView["Month"].ToString();
                obj.AddingYear.Text = rowView["Year"].ToString();
                obj.AddingFullWorkDays.Text = rowView["Work Days- FULL"].ToString();
                obj.AddingHalfWorkDays.Text = rowView["Work Days- HALF"].ToString();
            }
        }
    }
}
