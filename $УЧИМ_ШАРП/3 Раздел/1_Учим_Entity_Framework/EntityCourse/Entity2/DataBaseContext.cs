using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Entity2
{
    public abstract class DataBaseContext  : DbContext
    {
        public DataBaseContext() : base("DbConnectionString")
        {

        }
        public abstract T Read<T>();
    }
}
