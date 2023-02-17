using PaySheetMenagementSystemForInterns.Views;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PaySheetMenagementSystemForInterns.Commands
{
    class CleanFieldsToAddNewDataCommand
    {
        public void cleanFieldsToAddNewData(UserControlForSalaryEnteringWindow obj, SqlConnection connection)
        {
            TextBox[] txtBoxes = { obj.InternID, 
                                   obj.AddingFullWorkDays
                                 };
            foreach (var i in txtBoxes)
            {
                i.Clear();
            }
            obj.AddingMonth.Text = string.Empty;
            obj.AddingYear.Text = string.Empty;
            obj.ShowTotalSalary.Text = string.Empty;
            obj.ShowTotalWorkDays.Text = string.Empty;
            obj.InternName.Text = string.Empty;
            obj.InternSalaryPerDay.Text = string.Empty;
            obj.InternBranchName.Text = string.Empty;
            obj.InternBankName.Text = string.Empty;
            obj.InternBankAccNo.Text = string.Empty;
            obj.InternBankCode.Text = string.Empty;
            obj.InternBranchCode.Text = string.Empty;
            
            try
            {
                obj.AddingHalfWorkDays.Text = string.Empty;
            }
            catch (Exception ex)
            {
                //exceptions
            }

        }
    }
}
