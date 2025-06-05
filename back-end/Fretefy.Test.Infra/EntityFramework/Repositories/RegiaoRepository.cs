using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fretefy.Test.Infra.EntityFramework.Repositories
{
    public class RegiaoRepository : Repository<Regiao>, IRegiaoRepository
    {

        public RegiaoRepository(TestDbContext dbContext) : base(dbContext)
        {
        }

        public override Regiao Create(Regiao entity)
        {
            base.Create(entity);

            return _context.Regiao
                .Include(r => r.Cidades)
                    .ThenInclude(rc => rc.Cidade)
                .FirstOrDefault(r => r.Id == entity.Id);
        }

        public override Regiao Update(Regiao entity)
        {
            base.Update(entity);

            return _context.Regiao
                .Include(r => r.Cidades)
                    .ThenInclude(rc => rc.Cidade)
                .FirstOrDefault(r => r.Id == entity.Id);
        }

        public override Regiao Get(Guid id)
        {
            return _context.Regiao
                .Include(r => r.Cidades)
                .ThenInclude(rc => rc.Cidade)
                .FirstOrDefault(r => r.Id == id);
        }

        public override IQueryable<Regiao> List()
        {
            return _context.Regiao
                .Include(r => r.Cidades)
                .ThenInclude(rc => rc.Cidade);
        }

        public bool NomeExiste(string nome)
        {
            return _context.Regiao.Any(r => r.Nome.ToLower() == nome.ToLower());
        }

        public bool NomeExiste(string nome, Guid ignoreId)
        {
            return _context.Regiao
                .Any(r => r.Nome.ToLower() == nome.ToLower() && r.Id != ignoreId);
        }
    }
}
