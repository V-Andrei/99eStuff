using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _99eStuff.Data
{
    public class ConnectionManager
    {
        private const string ConnectionString = "Data Source=.;Initial Catalog=ninetyNineEStuff;Integrated Security=True";

        private static SqlConnection connection;

        public static SqlConnection GetConnection()
        {
            if (connection != null)
            {
                return connection;
            }

            connection = new SqlConnection
            {
                ConnectionString = ConnectionString
            };

            connection.Open();

            return connection;
        }
    }
}
