using System;
using System.Collections.Generic;
using System.Text;

namespace PractTask3
{
    public class Consol
    {
        CreateNumberPhone create;
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
            Console.Write("\n1-Регистрация\n");
            Method();
            Console.Write("\n");
        }
        void DateUser(string NF)
        {
            string[] splitText = NF.Split(' ');
            var name = splitText[1];
            var lastName = splitText[0];
            new Insert(create.Random(), name, lastName);

        }
    }
}
