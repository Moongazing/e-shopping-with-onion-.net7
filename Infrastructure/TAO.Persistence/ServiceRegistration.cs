using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAO.Application.Repositories;
using TAO.Persistence.Configurations;
using TAO.Persistence.Contexts;
using TAO.Persistence.Repositories;

namespace TAO.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceServices(this IServiceCollection services)
        {

           
            services.AddDbContext<TaoDbContext>(options => options.UseSqlServer(Configurations.Configuration.ConnectionString));


            services.AddScoped<ICustomerReadRepository,CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();

            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();

            services.AddScoped<IOrderReadRepository, OrderReadRepository>();

            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();



        }
    }
}
