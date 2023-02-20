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
                            // Get the string value from the 13th column of the DataRowView
                            string stringValue = dr[12].ToString();
                            //casting
                            float.TryParse(stringValue, out float floatValue);
                            //to get the last two digits also as the salry amount 
                            int intAmount = (int)(floatValue*100);
                            // Convert the float value to a string and remove the decimal places
                            string stringAmount = intAmount.ToString("0");


                            writer.WriteLine("0000" //Filler ('0000')
                                + dr[6].ToString() //Destination Bank No.
                                + dr[8].ToString() //Destination Branch No.
                                + dr[4].ToString().PadLeft(12, '0') //Destination A/C No.
                                + dr[3].ToString().PadRight(20, ' ')  //Destination A/C Name.
                                + "23" //Transaction Code('23')
                                + "00" //Return Code ('00')
                                + "0" //Filler('0')
                                + "000000" //Filler ('000000')
                                + stringAmount.PadLeft(12,'0') //Amount
                                + "SLR" //Filler ('SLR')
                                + "7010" //Originating Bank No. ('7010')
                                + "660" //Originating Branch No. (660')
                                + "000000001174"       //Originating Account No.(12 digits)
                                + "CEYLON PETROLEUM CRP" //Originating Account Name. (20 digits)
                                + new string(' ', 15) //Particulars (15 digits)
                                + new string(' ', 15) //Reference
                                + obj.yy.Text + obj.mm.Text + obj.dd.Text //Value Date (YYMMDD)
                                + "000000" //Filler ('000000')

                                );
                        }


                    }
                    MessageBox.Show("Successfully exported as .txt file", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }



        }
    }

}
