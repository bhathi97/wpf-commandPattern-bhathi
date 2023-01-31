using PaySheetMenagementSystemForInterns.Views;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaySheetMenagementSystemForInterns.Commands
{
    class YearAndMonthIsInRangeCheckCommand
    {
        //initialize the flag
        public int flag;

        //validate month and year
        public int startMonth;
        public int startYear;
        public int endYear;
        public int endMonth;
        public int inputYear;
        public string inputMonth;

        public string startMonthFromDB;
        public string endMonthFromDB;
        public int inputMonthForCompare;


        public int validateYearAndMonth(UserControlForSalaryEnteringWindow obj, SqlConnection connection)
        {
            //input year
            inputYear = int.Parse(obj.AddingYear.Text);

            //inputMonth
            inputMonth = obj.AddingMonth.Text;
            
            try
            {
                connection.Open();
                //start year,start month,end year and end month get from master table considering user id

                SqlCommand command1 = new SqlCommand("SELECT WorkStartMonth FROM InternsMasterTable where ID = '" + obj.InternID.Text + "'", connection);
                startMonthFromDB=(string)command1.ExecuteScalar();
                startMonth = int.Parse(startMonthFromDB);

                SqlCommand command2 = new SqlCommand("SELECT WorkStartYear FROM InternsMasterTable where ID = '" + obj.InternID.Text + "'", connection);
                startYear = (int)command2.ExecuteScalar();

                SqlCommand command3 = new SqlCommand("SELECT WorkEndYear FROM InternsMasterTable where ID = '" + obj.InternID.Text + "'", connection);
                endYear = (int)command3.ExecuteScalar();

                SqlCommand command4 = new SqlCommand("SELECT WorkEndMonth FROM InternsMasterTable where ID = '" + obj.InternID.Text + "'", connection);
                endMonthFromDB = (string)command4.ExecuteScalar();
                endMonth = int.Parse(endMonthFromDB);

                
                int flag2 = 0;
                while (flag2 == 0)
                {
                    if (inputMonth == "january") { inputMonthForCompare = 1; flag2 = 1; } 
                    if (inputMonth == "february") { inputMonthForCompare = 2; flag2 = 1; } 
                    if (inputMonth == "march") { inputMonthForCompare = 3; flag2 = 1; } 
                    if (inputMonth == "april") { inputMonthForCompare = 4; flag2 = 1; } 
                    if (inputMonth == "may") { inputMonthForCompare = 5; flag2 = 1; }
                    if (inputMonth == "june") { inputMonthForCompare = 6; flag2 = 1; }
                    if (inputMonth == "july") { inputMonthForCompare = 7; flag2 = 1; }
                    if (inputMonth == "august") { inputMonthForCompare = 8; flag2 = 1; }
                    if (inputMonth == "september") { inputMonthForCompare = 9; flag2 = 1; } 
                    if (inputMonth == "octomber") { inputMonthForCompare = 10; flag2 = 1; } 
                    if (inputMonth == "november") { inputMonthForCompare = 11; flag2 = 1; } 
                    if (inputMonth == "december") { inputMonthForCompare = 12; flag2 = 1; } 
                }


                //check between start yyyy.mm and end yyyy.mmm
                if (inputYear == startYear && inputMonthForCompare != 0)
                {
                    if (startYear == endYear)
                    {
                        if (startMonth <= inputMonthForCompare && inputMonthForCompare <= endMonth) return flag = 1;
                    }
                    if (startYear < endYear)
                    {
                        if (startMonth <= inputMonthForCompare && inputMonthForCompare <= 12) return flag = 1;
                    }
                }
                if (inputYear == endYear && inputMonthForCompare != 0)
                {
                    if (startYear == endYear)
                    {
                        if (startMonth <= inputMonthForCompare && inputMonthForCompare <= endMonth) return flag = 1;
                    }
                    if (startYear < endYear)
                    {
                        if (1 <= inputMonthForCompare && inputMonthForCompare <= endMonth) return flag = 1;
                    }
                }

            }
            catch (Exception ex)
            {
                //exception handle to b done
            }
            finally
            {
                connection.Close();
            }
            return flag;
        }
    }
}
