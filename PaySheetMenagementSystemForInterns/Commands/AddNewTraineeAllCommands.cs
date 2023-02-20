using PaySheetMenagementSystemForInterns.Views.UserControlsForAddNewToMAsterTableContent;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Forms.Design.Behavior;
using System.Windows.Markup;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace PaySheetMenagementSystemForInterns.Commands
{
    internal class AddNewTraineeAllCommands
    {

        //load locations
        public void loadsLocationsToComboBox(SqlConnection con, UserControlForAddNewTraineeToTheDataBase obj)
        {
            try
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("SELECT * FROM [LOCATION_TABLE]", con);
                //cmd1.ExecuteNonQuery();
                SqlDataReader reader = cmd1.ExecuteReader();

                while (reader.Read())
                {
                    string location = reader.GetString(0); // Assuming the "Location" column is of type string
                    obj.TraineeLocationToDB.Items.Add(location);
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        //load banks
        public void loadBanksToComboBox(SqlConnection con, UserControlForAddNewTraineeToTheDataBase obj)
        {
            try
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("SELECT * FROM [MASTER_TABLE-BANK]", con);
                SqlDataReader reader = cmd1.ExecuteReader();

                while (reader.Read())
                {
                    string bankNames = reader.GetString(1); // Assuming the "Bank Name" column is of type string
                    obj.TraineeBankNameToDB.Items.Add(bankNames);
                }

                reader.Close();

            }
            catch(Exception ex) { }
            finally
            {
                con.Close() ;
            }
        }

        //load bank code according to the selected bank
        public void loadBankCodeToTextBlock(SqlConnection con, UserControlForAddNewTraineeToTheDataBase obj)
        {
            try
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("SELECT [Bank Code] FROM [MASTER_TABLE-BANK] where [Bank Name] = @bankName", con);
                cmd1.Parameters.AddWithValue("@bankName", obj.TraineeBankNameToDB.Text);
                object result = cmd1.ExecuteScalar();
                if (result != null)
                {
                    int bankCode = Convert.ToInt32(result);
                    obj.TraineeBankCodeToDB.Text = bankCode.ToString();


                    //load data to combo
                    SqlCommand cmd = new SqlCommand("SELECT [Branch Name] FROM [MASTER_TABLE-BRANCH] where [Bank Code] = @bankCode", con);
                    cmd.Parameters.AddWithValue("bankCode", bankCode);
                    SqlDataAdapter sqldataadapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    sqldataadapter.Fill(dataTable);

                    obj.TraineeBranchNameToDB.ItemsSource = dataTable.DefaultView;
                    obj.TraineeBranchNameToDB.DisplayMemberPath = "[Branch Name]";

                }

            }
            catch (Exception ex) { }
            finally
            {
                con.Close();
            }

        }

        //auto load branch code
        public void loadBranchCodeToTextBlock(SqlConnection con, UserControlForAddNewTraineeToTheDataBase obj)
        {
            try
            {
                con.Open();
                SqlCommand cmd2 = new SqlCommand("SELECT [Branch Code] FROM [MASTER_TABLE-BRANCH] where [Branch Name] = @branchName", con);
                cmd2.Parameters.AddWithValue("@branchName", obj.TraineeBranchNameToDB.Text);
                object result = cmd2.ExecuteScalar();
                if (result != null)
                {
                    int branchCode = Convert.ToInt32(result);
                    obj.TraineeBranchCodeToDB.Text = branchCode.ToString();

                }

            }
            catch (Exception ex) { }
            finally
            {
                con.Close();
            }
        }

        


    }
}
