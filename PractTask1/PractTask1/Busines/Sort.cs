using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using PractTask1.Data_Access;
namespace PractTask1.Busines
{
    public class Sort:Read
    {
        public void SotrFile()
        {
            var text = ReadFile();
            var allwords = text.Split(' ', '.', '\n',',');
            var unique = (from word in allwords select word.ToLower()).Distinct().OrderBy(name => name);
            foreach (var item in unique)
            {
                Console.WriteLine(item);
            }
        }
    }
}
