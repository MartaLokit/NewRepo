using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using PractTask1.Busines;
namespace PractTask1.Data_Access
{
    public class Save
    {
        public void SaveText()
        {
            StreamWriter writer = new StreamWriter("Save.txt");
            writer.WriteLine();
            writer.Close();
        }
    }
}
