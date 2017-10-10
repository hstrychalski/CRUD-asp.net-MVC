using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Workers.Models
{
    public class WorkersDbContext : DbContext
    {
        public DbSet<Worker> Workers { get; set; }
    }
}