using PaySheetMenagementSystemForInterns.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PaySheetMenagementSystemForInterns.Commands
{
    internal class FileNameNamingControlCommand
    {
        public void fileNameNaming(UserControlForSalaryEnteringWindow obj, object sender, TextChangedEventArgs e)
        {
            //only allow numbers
            Regex regex = new Regex("[^\\d]+");
            TextBox yyTextBox = sender as TextBox;
            if (yyTextBox != null)
            {
                yyTextBox.Text = regex.Replace(yyTextBox.Text, "");
            }

            //check all fields are filled
            if (!(string.IsNullOrEmpty(obj.yy.Text)) && !(string.IsNullOrEmpty(obj.mm.Text)) && !(string.IsNullOrEmpty(obj.dd.Text)))
            {
                obj.theFolderNameToSavePaySheet.Text = "20" + obj.yy.Text + obj.mm.Text + obj.dd.Text;
                obj.dataExportToaTextFile.IsEnabled = true;
            }
            else
            {
                obj.dataExportToaTextFile.IsEnabled = false;
            }
        }
    }
}
