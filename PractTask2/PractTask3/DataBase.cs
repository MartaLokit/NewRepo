using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Configuration;

namespace PractTask3
{
    public class DataBase
    {
        protected SqlConnection connection;
        protected void Connection()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
            connection.Open();
            //if (connection.State == ConnectionState.Open)
            //    Console.WriteLine("Подключено");
        }
    }
}
