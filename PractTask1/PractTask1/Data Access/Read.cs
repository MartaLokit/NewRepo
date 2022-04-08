using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace PractTask1.Data_Access
{
    public class Read
    {
        //public string textFromFile;
        public async Task AReadFile()
        {
            string path = "text.txt";
            using (FileStream fstream = File.OpenRead(path))
            {
                // выделяем массив для считывания данных из файла
                byte[] buffer = new byte[fstream.Length];
                // считываем данные
                await fstream.ReadAsync(buffer, 0, buffer.Length);
                // декодируем байты в строку
                string textFromFile = Encoding.Default.GetString(buffer);
                Console.WriteLine(textFromFile);
            }
        }
        public string ReadFile()
        {
            //StreamReader sr = new StreamReader("text.txt");
            //string line=" ";
            //while (!sr.EndOfStream)
            //{
            //    line = sr.ReadLine();
            //    Console.WriteLine(line);
            //}
            //sr.Close();
            //return line;
            return File.ReadAllText("text.txt");
        }

    }
}
