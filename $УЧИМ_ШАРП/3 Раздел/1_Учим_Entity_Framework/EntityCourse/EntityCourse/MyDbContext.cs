using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityCourse
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base()
        {

        }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Song> Songs { get; set; }
    }
}
