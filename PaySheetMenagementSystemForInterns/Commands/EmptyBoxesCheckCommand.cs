 using PaySheetMenagementSystemForInterns.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace PaySheetMenagementSystemForInterns.Commands
{
    public class EmptyBoxesCheckCommand
    {
        public int emptyTextBoxCheck(UserControlForSalaryEnteringWindow obj)
        {
            int flag = 0;
            TextBox[] textBox = { obj.InternID, obj.InternName, obj.InternBankAccNo, obj.InternBankName, obj.InternBankCode, obj.InternBranchName, obj.InternBranchCode, obj.InternSalaryPerDay, obj.AddingFullWorkDays, obj.AddingHalfWorkDays };
            foreach (var textbox in textBox)
            {
                if (string.IsNullOrEmpty(textbox.Text))
                {
                    MessageBox.Show(textbox.Name + " is empty", "empty field", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                    textbox.Focus();
                    flag = 1;
                    return flag;
                }

            }
            return flag;

        }

        //check empty combobox
        public int emptyComboBoxCheck(UserControlForSalaryEnteringWindow obj)
        {
            int flag2 = 0;
            ComboBox[] comboBoxes = { obj.AddingYear, obj.AddingMonth };
            foreach (var comboBox in comboBoxes)
            {
                if (string.IsNullOrEmpty(comboBox.Text))
                {
                    MessageBox.Show(comboBox.Name + "  is empty", "empty field", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                    flag2 = 1;
                    return flag2;

                }
            }
            return flag2;
        }

    }
}
