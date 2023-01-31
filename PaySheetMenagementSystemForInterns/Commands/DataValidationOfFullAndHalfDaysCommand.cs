using PaySheetMenagementSystemForInterns.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace PaySheetMenagementSystemForInterns.Commands
{
    class DataValidationOfFullAndHalfDaysCommand
    {
        public void dataValidation(object sender, TextCompositionEventArgs e)
        {
            //only numbers
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
            //only between 1-31
            e.Handled = !IsValid(((TextBox)sender).Text + e.Text);
        }

        public static bool IsValid(string str)
        {
            int i;
            return int.TryParse(str, out i) && i >= 0 && i <= 31;
        }
    }
}
