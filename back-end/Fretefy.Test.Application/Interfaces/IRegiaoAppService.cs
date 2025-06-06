using Fretefy.Test.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Fretefy.Test.Application.Interfaces
{
    public interface IRegiaoAppService
    {
        Task<ListarRegiaoDto> CreateAsync(CriarRegiaoDto dto);
        Task<ListarRegiaoDto> UpdateAsync(AtualizarRegiaoDto dto);
        Task AtualizarStatusAsync(AtualizarRegiaoStatusDto dto);
        Task DeleteAsync(Guid id);
        Task<ListarRegiaoDto> GetAsync(Guid id);
        Task<IEnumerable<ListarRegiaoDto>> ListAsync();
    }
}
