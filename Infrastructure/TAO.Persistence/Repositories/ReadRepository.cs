﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TAO.Application.Repositories;
using TAO.Domain.Entities.Common;
using TAO.Persistence.Contexts;

namespace TAO.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly TaoDbContext _context;
        public ReadRepository(TaoDbContext context)
        {
            _context = context;
        }
        public DbSet<T> Table => _context.Set<T>();
        public IQueryable<T> GetAll() => Table;
        public IQueryable<T> Where(Expression<Func<T, bool>> expression) => Table.Where(expression);
        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> expression) => await Table.FirstOrDefaultAsync(expression);
        public async Task<T> GetByIdAsync(string id) => await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
    
    }
}
