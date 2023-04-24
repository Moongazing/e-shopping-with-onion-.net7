using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAO.Application.Repositories;
using TAO.Domain.Entities;

namespace TAO.Persistence.Repositories
{
    public class ProductReadRepository:ReadRepository<Product>, IProductReadRepository
    {
    }
}
