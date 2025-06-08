using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Infra.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fretefy.Test.Domain.Interfaces.Repositories
{
    public interface ICidadeRepository : IRepository<Cidade>
    {
        IEnumerable<Cidade> ListByUf(string uf);
        IEnumerable<Cidade> Query(string terms);
        Task<List<Cidade>> ObterPorIdsAsync(IEnumerable<Guid> ids);
    }
}
