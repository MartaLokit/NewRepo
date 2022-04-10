using System;
using System.Collections.Generic;
using System.Text;

namespace PractTask1.Busines
{
    public class Consol
    {
        Action action = new Action();
        void Cycle()
        {
            for (int i = 0; i < 80; i++)
                System.Console.Write('*');
        }
        public void Load()
        {
            Cycle();
            System.Console.WriteLine("\n1-Вывод содержимого 2-Слова 3-Символы 4-Сортировка 5-Выход");
            Cycle();
            System.Console.WriteLine(" ");
        }
        public void Number(int number)
        {
            switch (number)
            {
                case 1:
                    action.Read();
                    break;
                case 2:
                    action.NumberWord();
                    break;
                case 3:
                    action.NumberChar();
                    break;
                case 4:
                    action.Sort();         
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    System.Console.WriteLine("Нет такого пункта!");
                    Load();
                    break;
            }
        }
    }
}
