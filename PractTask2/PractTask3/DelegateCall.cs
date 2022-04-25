using System;
using System.Collections.Generic;
using System.Text;

namespace PractTask3
{
    public class DelegateCall
    {
        public delegate string MessageCondition(string mess);
        public event MessageCondition message;
        public DelegateCall(StatusChange status)
        {
            if(status==StatusChange.free)
            {
                Console.WriteLine(message("Вызов...")); 
            }
            if (status == StatusChange.busy)
            {
                Console.WriteLine(message("Абонент временно занят..."));
            }
            if (status == StatusChange.blocked)
            {
                Console.WriteLine(message("Абонент временно недоступен..."));              
            }
        }
    }
}
