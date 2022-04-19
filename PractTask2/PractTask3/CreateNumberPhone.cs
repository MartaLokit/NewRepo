using System;
using System.Collections.Generic;
using System.Text;

namespace PractTask3
{
    public class CreateNumberPhone
    {
        public string Random()
        {
            Random random = new Random();
            var telCode = "+375";
            int[] operCode = new int[3] { 29, 25, 44 };
            var code = telCode + operCode[random.Next(0, operCode.Length)];
            int number=0;
            Console.Write(code);
            for (int i = 0; i <7; i++)
            {
                number = random.Next(0, 9);
                Console.Write(number);
            }
            return code+number;
        }
    }
}
