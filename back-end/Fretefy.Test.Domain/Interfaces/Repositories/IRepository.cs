using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fretefy.Test.Infra.EntityFramework.Repositories
{
    public interface IRepository<T>
    {
        T Get(Guid id);
        IQueryable<T> List();
        T Create(T entity);
        T Update(T entity);
        void Delete(Guid id);
    }
}
