using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAO.Persistence.Contexts;

namespace TAO.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<TaoDbContext>
    {
        public TaoDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<TaoDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseSqlServer(Configuration.ConnectionString);
            return new(dbContextOptionsBuilder.Options);
        }
    }
}
