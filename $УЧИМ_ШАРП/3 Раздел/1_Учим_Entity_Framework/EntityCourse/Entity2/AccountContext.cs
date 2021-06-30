using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Entity2
{
    public class AccountContext : DataBaseContext
    {
        public DbSet<Account> Accounts { get; set; }

        public override T Read<T>()
        {
            throw new NotImplementedException();
        }
    }
}
