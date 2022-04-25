using System;
using System.Collections.Generic;
using System.Text;

namespace PractTask3
{
    public class DelegateNumberPhone
    {
        public delegate string MessageCondition(string mess);
        public event MessageCondition message;
        public DelegateNumberPhone(bool conditions)
        {
            if(conditions==true)
            {
                Console.WriteLine(MessagTrue()); 
            }
            if (conditions==false)
            {
                Console.WriteLine(MessagFalse()); 
            }
        }
        public string MessagTrue()
        {
            return message("Пользователь с такими данными уже есть");
        }
        public string MessagFalse()
        {
            return message("Cпасибо за регистрацию, ваш номер телефона");
        }
    }
}
