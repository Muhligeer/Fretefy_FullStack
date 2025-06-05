using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fretefy.Test.Infra.EntityFramework.Repositories
{
    public interface IRepository<T>
    {
        Task<T> CreateAsync(T entity);
        Task DeleteAsync(Guid id);
        Task<T> GetAsync(Guid id);
        Task<IEnumerable<T>> ListAsync();
        IQueryable<T> Query();
        Task<T> UpdateAsync(T entity);
    }
}
