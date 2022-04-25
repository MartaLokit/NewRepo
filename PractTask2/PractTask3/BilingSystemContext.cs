using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace PractTask3
{
    public class BilingSystemContext : DbContext
    {
        public BilingSystemContext():base("conStr")
        {

        }
        public DbSet<DataUsers> users { get; set; }
    }
}
