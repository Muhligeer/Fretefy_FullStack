using Fretefy.Test.Application.Interfaces;
using Fretefy.Test.Domain.DTO;
using Fretefy.Test.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Fretefy.Test.Application.Services
{
    public class RegiaoAppService : IRegiaoAppService
    {
        private readonly IRegiaoService _regiaoService;

        public RegiaoAppService(IRegiaoService regiaoService)
        {
            _regiaoService = regiaoService;
        }

        public async Task<ListarRegiaoDto> CreateAsync(CriarRegiaoDto dto)
        {
            return await _regiaoService.CreateAsync(dto);
        }

        public async Task<ListarRegiaoDto> UpdateAsync(AtualizarRegiaoDto dto)
        {
            return await _regiaoService.UpdateAsync(dto);
        }

        public async Task AtualizarStatusAsync(AtualizarRegiaoStatusDto dto)
        {
            await _regiaoService.AtualizarStatusAsync(dto);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _regiaoService.DeleteAsync(id);
        }

        public async Task<ListarRegiaoDto> GetAsync(Guid id)
        {
            return await _regiaoService.GetAsync(id);
        }

        public async Task<IEnumerable<ListarRegiaoDto>> ListAsync()
        {
            return await _regiaoService.ListAsync();
        }
    }
}
