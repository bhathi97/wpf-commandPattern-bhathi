using PaySheetMenagementSystemForInterns.Views.UserControlsForAddNewToMAsterTableContent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace PaySheetMenagementSystemForInterns.Commands
{
    class EmptyBoxesCheckBeforeUpdateTraineeCommand
    {
        //text box value check is empty or not
        public int emptyTextBoxCheck(UserControlForEdidTraineeDetails obj)
        {
            int flag1 = 0;
            TextBox[] textBox = { obj.TBforUpdateTraineeName, obj.TBforUpdateTraineeNumber, obj.TBforUpdateTraineeID, obj.TBforUpdateTraineeTelephoneNumber, obj.TBforUpdateBankAccountNo };
            foreach (var textbox in textBox)
            {
                if (string.IsNullOrEmpty(textbox.Text))
                {
                    MessageBox.Show(textbox.Name + " is empty", "empty field", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                    textbox.Focus();
                    flag1 = 1;
                    return flag1;
                }

            }
            return flag1;

        }

        //text block value check is empty or not
        public int emptyTextBlockCheck(UserControlForEdidTraineeDetails obj)
        {

            int flag2 = 0;
            TextBlock[] textBlock = { obj.TBforUpdateBankCode, obj.TBforUpdateBranchCode };
            foreach (var textblock in textBlock)
            {
                if (string.IsNullOrEmpty(textblock.Text))
                {
                    MessageBox.Show(textblock.Name + " is empty", "empty field", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                    textblock.Focus();
                    flag2 = 1;
                    return flag2;
                }

            }
            return flag2;
        }

        //combo box value check is empty or not
        public int emptyComboBoxCheck(UserControlForEdidTraineeDetails obj)
        {
            int flag3 = 0;
            ComboBox[] comboBoxes = { obj.TBforUpdateBankName, obj.TBforUpdateBranchName, obj.TBforUpdateTraineePay, obj.TBforUpdateTraineeLocation };
            foreach (var comboBox in comboBoxes)
            {
                if (string.IsNullOrEmpty(comboBox.Text))
                {
                    MessageBox.Show(comboBox.Name + "  is empty", "empty field", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                    flag3 = 1;
                    return flag3;

                }
            }
            return flag3;
        }

    }
}
