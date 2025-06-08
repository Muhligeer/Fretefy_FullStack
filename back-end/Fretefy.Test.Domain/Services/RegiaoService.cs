using Fretefy.Test.Domain.DTO;
using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Fretefy.Test.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fretefy.Test.Domain.Services
{
    public class RegiaoService : IRegiaoService
    {
        private readonly IRegiaoRepository _regiaoRepository;
        public RegiaoService(IRegiaoRepository regiaoRepository)
        {
            _regiaoRepository = regiaoRepository;
        }

        public async Task<ListarRegiaoDto> CreateAsync(CriarRegiaoDto dto)
        {
            if (await _regiaoRepository.NomeExiste(dto.Nome))
                throw new ArgumentException("Já existe uma região com esse nome.");

            var regiao = new Regiao(dto.Nome, dto.Cidades);

            var created = await _regiaoRepository.CreateAsync(regiao);

            return MapToDto(created);
        }

        public async Task DeleteAsync(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentException("ID inválido.", nameof(id));
            }
            await _regiaoRepository.DeleteAsync(id);
        }

        public async Task<ListarRegiaoDto> GetAsync(Guid id)
        {
            var regiao = await _regiaoRepository.GetAsync(id);
            return regiao == null ? null : MapToDto(regiao);
        }

        public async Task<IEnumerable<Regiao>> ListAsync()
        {
            return await _regiaoRepository.ListAsync();
        }

        public async Task<ListarRegiaoDto> UpdateAsync(AtualizarRegiaoDto dto)
        {
            var regiao = await _regiaoRepository.GetAsync(dto.Id);
            if (regiao == null)
                throw new KeyNotFoundException("Região não encontrada.");

            if (await _regiaoRepository.NomeExiste(dto.Nome, dto.Id))
                throw new ArgumentException("Já existe uma região com esse nome.");

            regiao.Atualizar(dto.Nome, dto.Cidades, dto.Ativo);

            await _regiaoRepository.UpdateAsync(regiao);

            return MapToDto(regiao);
        }

        public async Task AtualizarStatusAsync(AtualizarRegiaoStatusDto dto)
        {
            var regiao = await _regiaoRepository.GetAsync(dto.Id);
            if (regiao == null)
                throw new KeyNotFoundException("Região não encontrada.");

            regiao.AlterarStatus(dto.Ativo);

            await _regiaoRepository.UpdateAsync(regiao);
        }

        private ListarRegiaoDto MapToDto(Regiao regiao)
        {
            return new ListarRegiaoDto
            {
                Id = regiao.Id,
                Nome = regiao.Nome,
                Ativo = regiao.Ativo,
                Cidades = regiao.Cidades.Select(c => new CidadeDto
                {
                    Id = c.Cidade.Id,
                    Nome = c.Cidade.Nome,
                    UF = c.Cidade.UF
                }).ToList()
            };
        }
    }
}
