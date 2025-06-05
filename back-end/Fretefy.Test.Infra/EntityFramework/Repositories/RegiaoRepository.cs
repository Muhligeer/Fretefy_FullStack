using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fretefy.Test.Infra.EntityFramework.Repositories
{
    public class RegiaoRepository : Repository<Regiao>, IRegiaoRepository
    {

        public RegiaoRepository(TestDbContext dbContext) : base(dbContext)
        {
        }

        public override async Task<Regiao> CreateAsync(Regiao entity)
        {
            await base.CreateAsync(entity);

            return await _context.Regiao
                .Include(r => r.Cidades)
                    .ThenInclude(rc => rc.Cidade)
                .FirstOrDefaultAsync(r => r.Id == entity.Id);
        }

        public override async Task<Regiao> UpdateAsync(Regiao entity)
        {
            await base.UpdateAsync(entity);

            return await _context.Regiao
                .Include(r => r.Cidades)
                    .ThenInclude(rc => rc.Cidade)
                .FirstOrDefaultAsync(r => r.Id == entity.Id);
        }

        public override async Task<Regiao> GetAsync(Guid id)
        {
            return await _context.Regiao
                .Include(r => r.Cidades)
                .ThenInclude(rc => rc.Cidade)
                .FirstOrDefaultAsync(r => r.Id == id);
        }

        public override async Task<IEnumerable<Regiao>> ListAsync()
        {
            return await _context.Regiao
                .Include(r => r.Cidades)
                .ThenInclude(rc => rc.Cidade)
                .ToListAsync();
        }

        public async Task<bool> NomeExiste(string nome)
        {
            return await _context.Regiao.AnyAsync(r => r.Nome.ToLower() == nome.ToLower());
        }

        public async Task<bool> NomeExiste(string nome, Guid ignoreId)
        {
            return await _context.Regiao
                .AnyAsync(r => r.Nome.ToLower() == nome.ToLower() && r.Id != ignoreId);
        }
    }
}
