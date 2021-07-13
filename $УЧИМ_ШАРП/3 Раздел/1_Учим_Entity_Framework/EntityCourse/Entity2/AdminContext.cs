using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Entity2
{
    public class AdminContext : DataBaseContext
    {
        public DbSet<Admin> Admin { get; set; }
        public override Admin Read<Admin>()
        {
            throw new ArgumentException();
        }
    }
}
