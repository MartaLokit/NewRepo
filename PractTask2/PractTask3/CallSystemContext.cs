using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace PractTask3
{
    public class CallSystemContext:DbContext
    {
        public CallSystemContext() : base("conStr")
        {

        }
        public DbSet<CallSystem> users { get; set; }
    }
}
