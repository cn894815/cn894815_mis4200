using cn894815_mis4200.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace cn894815_mis4200.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {
            // this method is a 'constructor' and is called when a new context is created

        }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }
}