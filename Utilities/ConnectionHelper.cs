using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace Utilities
{
    public static  class ConnectionHelper
    {

           public static SqlConnection GetConnection()
            {
                string connectionString = ConfigurationManager.ConnectionStrings["BMSConnectionString"].ConnectionString;
                return new SqlConnection(connectionString);
            }
        
    }
}
