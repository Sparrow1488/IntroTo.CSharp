using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Entity2
{
    public class UserContext : DataBaseContext
    {
        public DbSet<User> Users { get; set; }

        public override User Read<User>()
        {
            throw new NotImplementedException();
        }
    }
}
