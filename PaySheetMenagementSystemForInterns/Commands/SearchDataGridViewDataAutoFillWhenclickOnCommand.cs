using PaySheetMenagementSystemForInterns.Views;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace PaySheetMenagementSystemForInterns.Commands
{
    class SearchDataGridViewDataAutoFillWhenclickOnCommand
    {
        public void searchedResultDataSelectionAutofill(UserControlForSalaryEnteringWindow obj)
        {
            
            try
            {
                
                DataGrid dataGrid = obj.SearchResultOfTemperaryDataTableGridView;
                DataRowView rowView = dataGrid.SelectedItem as DataRowView;

                if (rowView != null)
                {
                    obj.InternID.Text = rowView["ID"].ToString();
                    obj.AddingFullWorkDays.Text = rowView["FullWorkDays"].ToString();
                    obj.AddingHalfWorkDays.Text = rowView["HalfWorkDays"].ToString();
                    obj.AddingYear.Text = rowView["Year"].ToString();
                    obj.AddingMonth.Text = rowView["month"].ToString();
                    obj.IDforSearch.Clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                
            }
            
        }
    }
}
