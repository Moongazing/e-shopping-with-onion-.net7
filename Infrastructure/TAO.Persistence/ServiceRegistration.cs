using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAO.Persistence.Configurations;
using TAO.Persistence.Contexts;

namespace TAO.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceServices(this IServiceCollection services)
        {

           
            services.AddDbContext<TaoDbContext>(options => options.UseSqlServer(Configurations.Configuration.ConnectionString));
            
        }
    }
}
