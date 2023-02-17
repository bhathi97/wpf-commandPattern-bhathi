using PaySheetMenagementSystemForInterns.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;
using winForms = System.Windows.Forms;

namespace PaySheetMenagementSystemForInterns.Commands
{
    class ExportTemperaryDataToATextFileAsBankPaySheetCommand
    {
        public void exportDatatoSaaryTableAndSaveAsBankPaysheetTxtFile(UserControlForSalaryEnteringWindow obj, SqlConnection connection)
        {
            if (string.IsNullOrEmpty(obj.theFolderNameToSavePaySheet.Text)) MessageBox.Show("File Name missing", "Need", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (string.IsNullOrEmpty(obj.theFolderNameToSavePaySheet.Text) == false) 
            {
                winForms.FolderBrowserDialog dialog = new winForms.FolderBrowserDialog();
                winForms.DialogResult pathSelected = dialog.ShowDialog();

                if (pathSelected == winForms.DialogResult.OK)
                {
                    //define path to store
                    string pathToSave = dialog.SelectedPath;
                    string fname = obj.theFolderNameToSavePaySheet.Text;
                    string path = System.IO.Path.Combine(pathToSave, fname + ".txt");
             
                    using (TextWriter writer = new StreamWriter(path))
                    {
                        foreach (DataRowView dr in obj.dataShowingTable.ItemsSource)
                        {
                            writer.WriteLine(dr[0].ToString().PadRight(10, '0') /*+ dr[13].ToString().PadRight(10, '0') + dr[1].ToString())*/);
                        }


                    }
                    MessageBox.Show("Successfully exported as .txt file", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }



        }
    }

}
