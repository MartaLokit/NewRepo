using System;
using System.Collections.Generic;
using System.Text;

namespace PractTask3
{
    public class Call
    {      
        BilingSystem biling = new BilingSystem();
        public Call()
        {
            DataRequest();
            biling.SelectName(DataRequest());
            if (biling.SelectName(DataRequest())!=null || StatusCondition.statusChange != StatusChange.busy.ToString())
            {
                new DelegateCall(StatusChange.free);
                StatusCondition.statusChange = StatusChange.busy.ToString();        
            }
            if (StatusCondition.statusChange == StatusChange.busy.ToString())
            {
                new DelegateCall(StatusChange.busy);
            }
        }
        public string DataRequest()
        {
            Console.Write("Ввод имени  ");
            string resault=Console.ReadLine();
            return resault;
        }
    }
}
