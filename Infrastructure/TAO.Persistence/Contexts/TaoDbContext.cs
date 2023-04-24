using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAO.Domain.Entities;

namespace TAO.Persistence.Contexts
{
    public class TaoDbContext:DbContext
    {
        public TaoDbContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Product> Products{ get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
