using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fretefy.Test.Infra.EntityFramework.Repositories
{
    public class CidadeRepository : Repository<Cidade>, ICidadeRepository
    {

        public CidadeRepository(TestDbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<Cidade> ListByUf(string uf)
        {
            return _context.
                Set<Cidade>().
                Where(w => EF.Functions.Like(w.UF, $"%{uf}%"));
        }

        public IEnumerable<Cidade> Query(string terms)
        {

            return _context.
                Set<Cidade>().
                Where(w => EF.Functions.Like(w.Nome, $"%{terms}%") || EF.Functions.Like(w.UF, $"%{terms}%"));
        }

        public async Task<List<Cidade>> ObterPorIdsAsync(IEnumerable<Guid> ids)
        {
            if (ids == null || !ids.Any())
                return new List<Cidade>();

            return await _context.Cidade
                .Where(c => ids.Contains(c.Id))
                .ToListAsync();
        }
    }
}
