using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace PractTask3
{
    public class BilingSystem
    {
        CollectionNumberPhone collection = new CollectionNumberPhone();
        public void InsertDataUsers(string name, string lastName)
        {
            using (BilingSystemContext context = new BilingSystemContext())
            {
                DataUsers data = new DataUsers() { Name = $"{name}", LastName = $"{lastName}", Phone =$"{collection.Random()}"};
                context.users.Add(data);
                context.SaveChanges();
            }
        }
        public void SelectAll()
        {
            using (BilingSystemContext context = new BilingSystemContext())
            {
                var users = context.users;
                foreach (DataUsers data in users)
                {
                    Console.WriteLine($"ID:{data.ID} | Name: {data.Name} | LastName: {data.LastName} | NumberPhone: {data.Phone}");
                }
            }
        }
        int SelectRegistration(string name,string lastName)
        {
            using (BilingSystemContext context = new BilingSystemContext())
            {
                var users = context.users.Where(u=> u.Name==name && u.LastName==lastName);
                return users.Count();
            }
        }
        public string SelectName(string name)
        {
            using (BilingSystemContext context = new BilingSystemContext())
            {
                var users = context.users.Where(u => u.Name == name);
                return users.ToString();
            }
        }
        public void Registration(string name, string lastName)
        {
            if(SelectRegistration(name,lastName)>=1)
            {
                DelegateNumberPhone delegat = new DelegateNumberPhone(true);
            }
            else
            {
                InsertDataUsers(name, lastName);
                DelegateNumberPhone delegat = new DelegateNumberPhone(false);
            }
        }
    }
}
