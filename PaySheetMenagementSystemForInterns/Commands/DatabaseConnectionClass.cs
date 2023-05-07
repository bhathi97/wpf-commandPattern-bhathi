using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaySheetMenagementSystemForInterns.Commands
{
    public static class DatabaseConnectionClass
    {
        public static string ConnectionString  //static because without making object
        {
            get
            {
                return "Data Source=DESKTOP-KHI8921;Initial Catalog=aviationProjectDB;Integrated Security=True";
            }
        }
    }
       
}
