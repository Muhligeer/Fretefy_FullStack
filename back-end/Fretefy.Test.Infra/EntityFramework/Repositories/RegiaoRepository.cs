using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fretefy.Test.Infra.EntityFramework.Repositories
{
    public class RegiaoRepository : Repository<Regiao>, IRegiaoRepository
    {

        public RegiaoRepository(TestDbContext dbContext) : base(dbContext)
        {
        }
    }
}
