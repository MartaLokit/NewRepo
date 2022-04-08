using PractTask1.Busines;
using System;

namespace PractTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Consol consol = new Consol();
        M1:
            consol.Load();
            try
            {
                while (true)
                {
                    consol.Number(int.Parse(Console.ReadLine()));
                }
            }
            catch
            {
                Console.WriteLine("Некорректный ввод");
                goto M1;
            }
        }
    }
}
