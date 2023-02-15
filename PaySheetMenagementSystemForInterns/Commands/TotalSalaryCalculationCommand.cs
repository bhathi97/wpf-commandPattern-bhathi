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
                float halfDays = float.Parse(obj.AddingHalfWorkDays.Text);
                float total = (float)(halfDays * 0.5);
                obj.ShowTotalWorkDays.Text = total.ToString();
                totalSalary(obj);

            }
            else if (string.IsNullOrEmpty(obj.AddingHalfWorkDays.Text))
            {
                obj.ShowTotalWorkDays.Text = obj.AddingFullWorkDays.Text;
                totalSalary(obj);
            }
            else
            {
                float fullDays = float.Parse(obj.AddingFullWorkDays.Text);
                float halfDays = float.Parse(obj.AddingHalfWorkDays.Text);
                float total = (float)(fullDays + (halfDays * 0.5));
                obj.ShowTotalWorkDays.Text = total.ToString();
                totalSalary(obj);
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
