using PaySheetMenagementSystemForInterns.Views;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaySheetMenagementSystemForInterns.Commands
{
    class ShowingDatabaseIsConennectedOrNotAtTheBeginningCommand
    {
        public void showISDAtaBAseConnecetAtTheBeginning(HomeWindow obj, SqlConnection connection)
        {
            try
            {
                connection.Open();
                obj.connectionStateShowingLabel.Content = "DB connection established.";

            }
            catch(Exception ex)
            {
                obj.connectionStateShowingLabel.Content = "DB connection failed.";
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
