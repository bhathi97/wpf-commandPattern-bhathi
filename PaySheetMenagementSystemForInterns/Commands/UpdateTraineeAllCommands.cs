using PaySheetMenagementSystemForInterns.Views.UserControlsForAddNewToMAsterTableContent;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PaySheetMenagementSystemForInterns.Commands
{
    class UpdateTraineeAllCommands : EmptyBoxesCheckBeforeUpdateTraineeCommand
    {
        //
        public int start;
        public int end;



        //load locations
        public void loadsLocationsToComboBox(SqlConnection con, UserControlForEdidTraineeDetails obj)
        {
            try
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("SELECT * FROM [LOCATION_TABLE]", con);
                
                SqlDataReader reader = cmd1.ExecuteReader();

                while (reader.Read())
                {
                    string location = reader.GetString(0); // Assuming the "Location" column is of type string
                    obj.TBforUpdateTraineeLocation.Items.Add(location);
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
        public void loadBanksToComboBox(SqlConnection con, UserControlForEdidTraineeDetails obj)
        {
            try
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("SELECT * FROM [MASTER_TABLE-BANK]", con);
                SqlDataReader reader = cmd1.ExecuteReader();

                while (reader.Read())
                {
                    string bankNames = reader.GetString(1); // Assuming the "Bank Name" column is of type string
                    obj.TBforUpdateBankName.Items.Add(bankNames);
                }

                reader.Close();

            }
            catch (Exception ex) { }
            finally
            {
                con.Close();
            }
        }

        //load bank code according to the selected bank
        public void loadBankCodeToTextBlock(SqlConnection con, UserControlForEdidTraineeDetails obj)
        {
            try
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("SELECT [Bank Code] FROM [MASTER_TABLE-BANK] where [Bank Name] = '" + obj.TBforUpdateBankName.Text + "'", con);
                object result = cmd1.ExecuteScalar();
                if (result != null)
                {
                    int bankCode = Convert.ToInt32(result);
                    obj.TBforUpdateBankCode.Text = bankCode.ToString();


                    //load data to combo
                    SqlCommand cmd = new SqlCommand("SELECT [Branch Name] FROM [MASTER_TABLE-BRANCH] where [Bank Code] = '" + bankCode + "'", con);
                    SqlDataAdapter sqldataadapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    sqldataadapter.Fill(dataTable);

                    obj.TBforUpdateBranchName.ItemsSource = dataTable.DefaultView;
                    obj.TBforUpdateBranchName.DisplayMemberPath = "[Branch Name]";

                }

            }
            catch (Exception ex) { }
            finally
            {
                con.Close();
            }

        }

        //auto load branch code
        public void loadBranchCodeToTextBlock(SqlConnection con, UserControlForEdidTraineeDetails obj)
        {
            try
            {
                con.Open();
                SqlCommand cmd2 = new SqlCommand("SELECT [Branch Code] FROM [MASTER_TABLE-BRANCH] where [Branch Name] = '" + obj.TBforUpdateBranchName.Text + "'", con);
                object result = cmd2.ExecuteScalar();
                if (result != null)
                {
                    int branchCode = Convert.ToInt32(result);
                    obj.TBforUpdateBranchCode.Text = branchCode.ToString();

                }

            }
            catch (Exception ex) { }
            finally
            {
                con.Close();
            }
        }

        //autoload data from database when the Trainee number type
        public void loadDataToFieldsWhenTraineeNumberAdd(SqlConnection con, UserControlForEdidTraineeDetails obj)
        {
            try
            {
                con.Open();
                SqlCommand autoFillMaster = new SqlCommand("SELECT * FROM [MASTER-DETAILS_TRAINEE] WHERE [Trainee No] = '" + obj.TBforUpdateTraineeNumber.Text + "'", con);
                SqlCommand autoFillSalary = new SqlCommand("SELECT * FROM [BANK-ACCOUNTS_TRAINEE] WHERE [Trainee No] = '" + obj.TBforUpdateTraineeNumber.Text + "'", con);

                SqlDataReader dataReader = autoFillMaster.ExecuteReader();
                while (dataReader.Read())
                {
                    obj.TBforUpdateTraineeName.Text = dataReader["Name"].ToString();
                    obj.TBforUpdateTraineeID.Text = dataReader["ID"].ToString();
                    obj.TBforUpdateTraineeLocation.Text = dataReader["Location"].ToString();
                    obj.TBforUpdateTraineePay.Text = dataReader["Should pay or no"].ToString();
                    obj.TBforUpdateTraineeTelephoneNumber.Text = dataReader["Telephone No"].ToString();
                    obj.TBforUpdateTraineeStartDate.Text = dataReader["Start Date"].ToString();
                    obj.TBforUpdateTraineeEndDate.Text = dataReader["End Date"].ToString();
                    obj.TBforUpdateTraineeMonths.Text = dataReader["Months"].ToString();
                }
                dataReader.Close();
                SqlDataReader dataReader1 = autoFillSalary.ExecuteReader();
                while (dataReader1.Read())
                {
                    obj.TBforUpdateBankAccountNo.Text = dataReader1["Account No"].ToString();
                    obj.TBforUpdateBankName.Text = dataReader1["Bank Name"].ToString();
                    obj.TBforUpdateBankCode.Text = dataReader1["Bank Code"].ToString();
                    obj.TBforUpdateBranchName.Text = dataReader1["Branch Name"].ToString();
                    obj.TBforUpdateBranchCode.Text = dataReader1["Branch Code"].ToString();
                }
                dataReader1.Close();
            }
            catch(Exception ex) { }
            finally 
            {
                con.Close(); 
            }
        }

        //update values
        public void updateTrainee(SqlConnection con, UserControlForEdidTraineeDetails obj)
        {
            if(emptyComboBoxCheck(obj) == 0 && emptyTextBoxCheck(obj) == 0)
            {
                try
                {
                    con.Open();
                    SqlCommand c1 = new SqlCommand("UPDATE [MASTER-DETAILS_TRAINEE] SET Name = '" + obj.TBforUpdateTraineeName.Text + "', ID = '" + obj.TBforUpdateTraineeID.Text + "', [Location] = '" + obj.TBforUpdateTraineeLocation.Text + "', [Should pay or no] = '" + obj.TBforUpdateTraineePay.Text + "', [Telephone No] = '" + obj.TBforUpdateTraineeTelephoneNumber.Text + "', [Start Date] = '" + DateOnly.Parse(obj.TBforUpdateTraineeStartDate.Text) + "', [End Date] = '" + DateOnly.Parse(obj.TBforUpdateTraineeEndDate.Text) + "', [Months] = '" + obj.TBforUpdateTraineeMonths .Text + "' WHERE [Trainee No] = '" + obj.TBforUpdateTraineeNumber.Text + "'", con);
                    SqlCommand c2 = new SqlCommand("UPDATE [BANK-ACCOUNTS_TRAINEE] SET Name = '" + obj.TBforUpdateTraineeName.Text + "', [Account No] = '" + obj.TBforUpdateBankAccountNo.Text + "', [Bank Name] = '" + obj.TBforUpdateBankName.Text + "', [Bank Code] = '" + obj.TBforUpdateBankCode.Text + "',  [Branch Name] = '" + obj.TBforUpdateBranchName.Text + "', [Branch Code] = '" + obj.TBforUpdateBranchCode.Text + "' WHERE [Trainee No] = '" + obj.TBforUpdateTraineeNumber.Text + "'", con);
                    c1.ExecuteNonQuery();
                    c2.ExecuteNonQuery();
                    MessageBox.Show("Successfully UPDATE the Record", "success", MessageBoxButton.OK, MessageBoxImage.Information);


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"ERROR",MessageBoxButton.OK, MessageBoxImage.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        //delete values
        public void deleteTrainee(SqlConnection con, UserControlForEdidTraineeDetails obj)
        {
            if (MessageBox.Show("Do you Want to delete " + obj.TBforUpdateTraineeNumber.Text + " from the datatable?", "Worning", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
            {
                try
                {
                    con.Open();
                    var name = obj.TBforUpdateTraineeNumber.Text;
                    SqlCommand sqlCommand1 = new SqlCommand("DELETE FROM [BANK-ACCOUNTS_TRAINEE]  WHERE [Trainee No] = '" + obj.TBforUpdateTraineeNumber.Text + "'", con);
                    SqlCommand sqlCommand2 = new SqlCommand("DELETE FROM [MASTER-DETAILS_TRAINEE]  WHERE [Trainee No] = '" + obj.TBforUpdateTraineeNumber.Text + "'", con);
                    MessageBox.Show("Trainee " + name + " removed from database", "SUCCESS", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                finally
                {
                    con.Close();
                }
            }

        }

        //calculate months using datepicker
        public void monthsCalculationFunction(UserControlForEdidTraineeDetails obj)
        {
            if (string.IsNullOrEmpty(obj.TBforUpdateTraineeStartDate .Text))
            {
                obj.TBforUpdateTraineeMonths.Text = "0";
            }
            if (string.IsNullOrEmpty(obj.TBforUpdateTraineeEndDate.Text))
            {
                obj.TBforUpdateTraineeMonths.Text = "0";
            }
            else
            {
                DateOnly start = DateOnly.Parse(obj.TBforUpdateTraineeStartDate.Text);
                DateOnly end = DateOnly.Parse(obj.TBforUpdateTraineeEndDate.Text);
                int startMonth =  start.Month;
                int endMonth = end.Month;
                int month = endMonth - startMonth;
                obj.TBforUpdateTraineeMonths.Text = month.ToString();
            }

        }
    }
}
