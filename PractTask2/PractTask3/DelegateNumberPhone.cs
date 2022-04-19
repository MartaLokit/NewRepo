using System;
using System.Collections.Generic;
using System.Text;

namespace PractTask3
{
    public class DelegateNumberPhone
    {
        public delegate string MessageCondition();
        public event MessageCondition? Notify;
        delegate void Insert(string numberPhone, string name, string lastName);
        public DelegateNumberPhone(bool action)
        {
            MessageCondition message;
            Insert insert;
            if (action == true)
            {
                object p = Notify?.Invoke($"{MessagTrue}");
                //message = MessagTrue;
            }
            else
            {
                insert = MessagFalse;
            }
        }
        public string MessagTrue()
        {
            return "Пользователь с такими данными уже есть";
            //new Insert();
        }
        public void MessagFalse(string numberPhone, string name, string lastName)
        {
            new Insert(numberPhone, name, lastName);         
        }
    }
}
