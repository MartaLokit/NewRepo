using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Configuration;

namespace PractTask3
{
    public class BilingSystem
    {
        private DataSet dataSet = new DataSet();
        private SqlDataAdapter adapter=new SqlDataAdapter();
        private SqlConnection connection;
        private SqlCommand command;
        private CollectionNumberPhone numberPhone= new CollectionNumberPhone();
        private void Connection()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
            connection.Open();
            //if (connection.State == ConnectionState.Open)
            //    Console.WriteLine("Подключено");
        }
        public int Select(string name, string lastName)
        {
            Connection();
            command = new SqlCommand("Select [ID] From [DataUsers]" +
               $"where [Name] = N'{name}' and [LastName] = N'{lastName}'",connection);
            return command.ExecuteNonQuery();
        }
        public void SelectAll()
        {
            Connection();
            adapter = new SqlDataAdapter("Select * From[DataUsers]", connection);
            adapter.Fill(dataSet);
            foreach (DataTable data in dataSet.Tables)
            {
                foreach (DataColumn column in data.Columns)
                {
                    Console.Write($"\t{column.ColumnName}");                 
                }
                Console.WriteLine();
                foreach (DataRow dataRow in data.Rows)
                {
                    var cells = dataRow.ItemArray;
                    foreach (object cell in cells)
                    {
                        Console.Write($"\t{cell}");                       
                    }
                    Console.WriteLine();
                }
            }
        }
        public string InsertDataUser(string name, string lastName)
        {
            Connection();
            string phone = numberPhone.Random();
            command = new SqlCommand("Insert Into [DataUsers](Name,LastName,Phone) Values(@Name, @LastName, @Phone)", connection);
            command.Parameters.AddWithValue("Name", name);
            command.Parameters.AddWithValue("LastName", lastName);
            command.Parameters.AddWithValue("Phone", phone);
            return command.ExecuteNonQuery().ToString();
        }
        public void Registration(string name, string lastName)
        {
            if(Select(name,lastName)>=1)
            {
                DelegateNumberPhone delegat=new DelegateNumberPhone(true);
            }
            else
            {
                InsertDataUser(name, lastName);
                DelegateNumberPhone delegat = new DelegateNumberPhone(false);
            }
        }
    }
}
