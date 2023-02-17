using PaySheetMenagementSystemForInterns.Views;
using PaySheetMenagementSystemForInterns.Views.UserControlsForAddNewToMAsterTableContent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace PaySheetMenagementSystemForInterns.Commands
{
    internal class EmptyBoxesOFNewUserAddingCheckCommand
    {
        //text box value check is empty or not
        public int emptyTextBoxCheck ( UserControlForAddNewTraineeToTheDataBase obj)
        {
            int flag1 = 0;
            TextBox[] textBox = { obj.TraineeIDToDB, obj.TraineeNameToDB ,obj.TraineeNumberToDB , obj.TraineeTelephoneNoToDB, obj.TraineeBankAccNoToDB };
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
        public int emptyTextBlockCheck (UserControlForAddNewTraineeToTheDataBase obj)
        {

            int flag2 = 0;
            TextBlock[] textBlock = {obj.TraineeBankCodeToDB , obj.TraineeBranchCodeToDB};
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
        public int emptyComboBoxCheck(UserControlForAddNewTraineeToTheDataBase obj)
        {
            int flag3 = 0;
            ComboBox[] comboBoxes = {obj.TraineeBankNameToDB , obj.TraineeBranchNameToDB, obj.TraineeShouPayOrNoToDB, obj.TraineeLocationToDB };
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
