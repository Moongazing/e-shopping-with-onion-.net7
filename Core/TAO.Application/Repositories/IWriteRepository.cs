using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAO.Domain.Entities.Common;

namespace TAO.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T entity);
        Task<bool> AddRangeAsync(List<T> entities);
        bool Remove(T entity);
        Task<bool> Remove(string id);
        bool RemoveRange(List<T> entities);
        bool UpdateAsync(T entity);
        Task<int> SaveAsync();

    }
}
