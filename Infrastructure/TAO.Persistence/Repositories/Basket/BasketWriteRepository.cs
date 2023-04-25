﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAO.Application.Repositories;
using TAO.Domain.Entities;
using TAO.Persistence.Contexts;

namespace TAO.Persistence.Repositories
{
    public class BasketWriteRepository : WriteRepository<Basket>, IBasketWriteRepository
    {
        public BasketWriteRepository(TaoDbContext context) : base(context)
        {
        }
    }
}
