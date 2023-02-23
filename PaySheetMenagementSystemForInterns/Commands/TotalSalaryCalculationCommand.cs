using PaySheetMenagementSystemForInterns.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaySheetMenagementSystemForInterns.Commands
{
    class TotalSalaryCalculationCommand: DataValidationOfFullAndHalfDaysCommand
    {
        public void totalSalaryAutoCalculate(UserControlForSalaryEnteringWindow obj)
        {
            if (string.IsNullOrEmpty(obj.AddingFullWorkDays.Text))
            {
                if (float.TryParse(obj.AddingHalfWorkDays.Text, out float halfDays))
                {
                    // The string is a valid float value, and the 'halfDays' variable now contains the parsed value
                    float total = (float)(halfDays * 0.5);
                    obj.ShowTotalWorkDays.Text = total.ToString();
                    totalSalary(obj);
                }

            }
            else if (string.IsNullOrEmpty(obj.AddingHalfWorkDays.Text))
            {
                obj.ShowTotalWorkDays.Text = obj.AddingFullWorkDays.Text;
                totalSalary(obj);
            }
            else
            {
                if(float.TryParse(obj.AddingFullWorkDays.Text, out float fullDays) && float.TryParse(obj.AddingHalfWorkDays.Text, out float halfDays))
                {
                    // The strings are valid float values, and the 'fullDays' and 'halfDays' variables now contain the parsed values
                    float total = (float)(fullDays + (halfDays * 0.5));
                    obj.ShowTotalWorkDays.Text = total.ToString();
                    totalSalary(obj);
                }
            }
        }

        public void totalSalary(UserControlForSalaryEnteringWindow obj)
        {
            if (!(string.IsNullOrEmpty(obj.InternSalaryPerDay.Text)) && !(string.IsNullOrEmpty(obj.ShowTotalWorkDays.Text)))
            {
                float perDay = float.Parse(obj.InternSalaryPerDay.Text);
                float days = float.Parse(obj.ShowTotalWorkDays.Text);
                obj.ShowTotalSalary.Text = (perDay * days).ToString();
            }
            else
            {
                obj.ShowTotalSalary.Text = "0";
            }
        }
    }
}
