using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace PractTask3
{
    public class Select : DataBase
    {
        private SqlCommand command;
        public Select(string columnName)
        {
            Connection();
            command = new SqlCommand($"Select {columnName} From [DataUsers]", connection);
            Console.WriteLine(command.ExecuteScalar());
        }
    }
}
