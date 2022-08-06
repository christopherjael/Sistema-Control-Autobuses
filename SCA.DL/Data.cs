using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace SCA.DL
{
    public class Data
    {
        //private readonly string _connectionString;
        //SqlConnection connection;

        //public Data()
        //{
        //    _connectionString = ConfigurationManager.ConnectionStrings["dbContacts"].ToString();
        //    connection = new SqlConnection(_connectionString);
        //}
        static public SqlConnection GetConnection()
        {
            string settings = ConfigurationManager.ConnectionStrings["AutobusesConnection"].ToString();
            SqlConnection conn = new SqlConnection(settings);
            return conn;
        }
    }
}
