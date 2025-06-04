using Fretefy.Test.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fretefy.Test.Domain.Interfaces.Services
{
    public interface IRegiaoService
    {
        Regiao Get(Guid id);
        IEnumerable<Regiao> List();
        Regiao Create(Regiao regiao);
        Regiao Update(Regiao regiao);
        void Delete(Guid id);
    }
}
