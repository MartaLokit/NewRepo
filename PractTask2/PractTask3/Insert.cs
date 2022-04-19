using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace PractTask3
{
    public class Insert:DataBase
    {
        DelegateNumberPhone phone = new DelegateNumberPhone(true);   
        DataTable data;
        SqlDataAdapter adapter;
        SqlCommand command = new SqlCommand();
        public Insert(string numberPhone,string name,string lastName)
        {
            Connection();
            command = new SqlCommand($"Insert Into DataUsers valuese('{numberPhone}','{name}','{lastName}')", connection);
            adapter = new SqlDataAdapter(command);
            data = new DataTable();
            adapter.Fill(data);
            if (data.Rows.Contains(lastName)&&(data.Rows.Contains(name)))
            {
                
            }
            connection.Close();
        }

    }
}
