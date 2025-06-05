using Fretefy.Test.Domain.DTO;
using Fretefy.Test.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Fretefy.Test.Domain.Interfaces.Services
{
    public interface IRegiaoService
    {
        Task<ListarRegiaoDto> GetAsync(Guid id);
        Task<IEnumerable<ListarRegiaoDto>> ListAsync();
        Task<ListarRegiaoDto> CreateAsync(CriarRegiaoDto regiao);
        Task<ListarRegiaoDto> UpdateAsync(AtualizarRegiaoDto regiao);
        Task DeleteAsync(Guid id);
        Task AtualizarStatusAsync(AtualizarRegiaoStatusDto dto);
    }
}
