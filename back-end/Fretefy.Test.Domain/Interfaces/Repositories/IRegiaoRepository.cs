using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Infra.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Fretefy.Test.Domain.Interfaces.Repositories
{
    public interface IRegiaoRepository : IRepository<Regiao>
    {
        Task<bool> NomeExiste(string nome);
        Task<bool> NomeExiste(string nome, Guid ignoreId);
    }
}
