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
                                   obj.InternName,
                                   obj.InternSalaryPerDay,
                                   obj.InternBranchName,
                                   obj.InternBankName,
                                   obj.InternBankAccNo,
                                   obj.InternBankCode,
                                   obj.InternBranchCode,
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
