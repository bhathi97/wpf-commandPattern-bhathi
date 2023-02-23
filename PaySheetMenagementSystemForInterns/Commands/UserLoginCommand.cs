using PaySheetMenagementSystemForInterns.Views;
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
    class UserLoginCommand
    {
        public int login(LoginWindow obj, SqlConnection con)
        {
            if(string.IsNullOrEmpty(obj.userNameForLogin.Text))
            {
                MessageBox.Show("User Name field is Empty", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                obj.userNameForLogin.Focus();
                return 0;
            }
            else if (string.IsNullOrEmpty(obj.userPasswordForLogin.Password))
            {
                MessageBox.Show("User Password field is Empty", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                obj.userPasswordForLogin.Focus();
                return 0;
            }
            else       
            {
                try
                {
                    con.Open();
                    //first check the username is valid
                    // Create a parameterized query to check the temporary table
                    SqlCommand cmdUserCheck = new SqlCommand("SELECT COUNT([UserName]) FROM [LOGIN_TABLE] WHERE [UserName] = @un", con);
                    cmdUserCheck.Parameters.AddWithValue("@un", obj.userNameForLogin.Text);
                    // Create a data adapter to fill the DataTable with the result of the query
                    SqlDataAdapter sda1 = new SqlDataAdapter(cmdUserCheck);
                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);

                    //if use name is valid
                    if(dt1.Rows[0][0].ToString() != "0")
                    {
                        //check the password
                        //paramerterized quary
                        SqlCommand cmdPWCheck = new SqlCommand("SELECT [Password] FROM [LOGIN_TABLE] WHERE [UserName] = @un", con);
                        //add parameters
                        cmdPWCheck.Parameters.AddWithValue("@un", obj.userNameForLogin.Text);
                        //get pw to a string
                        string pw = cmdPWCheck.ExecuteScalar().ToString();

                        //check with pw
                        string enteredpw = obj.userPasswordForLogin.Password;

                        if (pw == enteredpw) 
                        {
                            return 1;
                        }
                        
                    }

                    else
                    {
                        MessageBox.Show("Invalid User Name", "LOGIN ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                        return 0;

                    }


                }
                catch
                {
                    
                }
                finally
                {
                    con.Close();
                }

            }
            return 0;
        }

    }
}
