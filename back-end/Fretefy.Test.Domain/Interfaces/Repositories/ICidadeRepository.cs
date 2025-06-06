﻿using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Infra.EntityFramework.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Fretefy.Test.Domain.Interfaces.Repositories
{
    public interface ICidadeRepository : IRepository<Cidade>
    {
        IEnumerable<Cidade> ListByUf(string uf);
        IEnumerable<Cidade> Query(string terms);
    }
}
