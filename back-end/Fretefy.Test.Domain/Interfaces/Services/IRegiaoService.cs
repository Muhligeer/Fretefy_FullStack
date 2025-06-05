using Fretefy.Test.Domain.DTO;
using Fretefy.Test.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fretefy.Test.Domain.Interfaces.Services
{
    public interface IRegiaoService
    {
        ListarRegiaoDto Get(Guid id);
        IEnumerable<ListarRegiaoDto> List();
        ListarRegiaoDto Create(CriarRegiaoDto regiao);
        ListarRegiaoDto Update(AtualizarRegiaoDto regiao);
        void Delete(Guid id);
    }
}
