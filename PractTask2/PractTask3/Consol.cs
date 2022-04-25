using System;
using System.Collections.Generic;
using System.Text;

namespace PractTask3
{
    public class Consol
    {
        BilingSystem biling = new BilingSystem();
        void Method()
        {
            for (int i = 0; i < 40; i++)
            {
                Console.Write('*');
            }
        }
        public Consol()
        {
            Method();
            Console.Write("\n1-Регистрация 2-Вызов 9-Провайдер\n");
            Method();
            Console.Write("\n");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Registretion();
                    break;
                case 2:
                    new Call();
                    break;
                case 9:
                    biling.SelectAll();
                      break;
            }
        }
        void Registretion()
        {
            Console.Write("Фамилия имя:");
            string NF = Console.ReadLine();
            string[] splitText = NF.Split(' ');
            var name = splitText[1];
            var lastName = splitText[0];
            biling.Registration(name, lastName);
        }
        
    }
}
