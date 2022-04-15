using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace PracTask1._2
{
    public class Read
    {
        public Read()
        {
            string text = File.ReadAllText("text.txt");
            List<object> collection = new List<object>();
            foreach (var item in text)
            {
                collection.Add(item);
                Console.Write(item);
            }
           
        }
    }
}
