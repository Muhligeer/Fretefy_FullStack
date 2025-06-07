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
            if (string.IsNullOrWhiteSpace(dto.Nome))
                throw new ArgumentException("Nome da região é obrigatório.");

            if (await _regiaoRepository.NomeExiste(dto.Nome))
                throw new ArgumentException("Já existe uma região com esse nome.");

            if (dto.Cidades == null || !dto.Cidades.Any())
                throw new ArgumentException("É necessário informar ao menos uma cidade.");

            if (dto.Cidades.Count != dto.Cidades.Distinct().Count())
                throw new ArgumentException("Não é permitido repetir a mesma cidade.");

            var regiao = new Regiao
            {
                Id = Guid.NewGuid(),
                Nome = dto.Nome,
                Ativo = true,
                Cidades = dto.Cidades.Select(cid => new RegiaoCidade
                {
                    CidadeId = cid
                }).ToList()
            };

            var created = await _regiaoRepository.CreateAsync(regiao);

            return new ListarRegiaoDto
            {
                Id = created.Id,
                Nome = created.Nome,
                Ativo = created.Ativo,
                Cidades = created.Cidades.Select(c => new CidadeDto
                {
                    Id = c.Cidade.Id,
                    Nome = c.Cidade.Nome,
                    UF = c.Cidade.UF
                }).ToList()
            };
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
            if (regiao == null) return null;

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

        public async Task<IEnumerable<Regiao>> ListAsync()
        {
            var regioes = await _regiaoRepository.ListAsync();
            return regioes;
        }

        public async Task<ListarRegiaoDto> UpdateAsync(AtualizarRegiaoDto dto)
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            if (string.IsNullOrWhiteSpace(dto.Nome))
                throw new ArgumentException("Nome da região é obrigatório.");

            if (dto.Cidades == null || !dto.Cidades.Any())
                throw new ArgumentException("Informe ao menos uma cidade.");

            if (dto.Cidades.Count != dto.Cidades.Distinct().Count())
                throw new ArgumentException("Cidades duplicadas não são permitidas.");

            var regiao = await _regiaoRepository.GetAsync(dto.Id);
            if (regiao == null)
                throw new KeyNotFoundException("Região não encontrada.");

            var nomeExistente = await _regiaoRepository.NomeExiste(dto.Nome, dto.Id);
            if (nomeExistente)
                throw new ArgumentException("Já existe uma região com esse nome.");

            regiao.Nome = dto.Nome;
            regiao.Ativo = dto.Ativo;

            regiao.Cidades = dto.Cidades.Select(cid => new RegiaoCidade
            {
                RegiaoId = regiao.Id,
                CidadeId = cid
            }).ToList();

            await _regiaoRepository.UpdateAsync(regiao);

            return new ListarRegiaoDto
            {
                Id = regiao.Id,
                Nome = regiao.Nome,
                Ativo = regiao.Ativo,
                Cidades = regiao.Cidades.Select(rc => new CidadeDto
                {
                    Id = rc.Cidade.Id,
                    Nome = rc.Cidade.Nome,
                    UF = rc.Cidade.UF
                }).ToList()
            };
        }

        public async Task AtualizarStatusAsync(AtualizarRegiaoStatusDto dto)
        {
            if (dto.Id == Guid.Empty)
                throw new ArgumentException("ID inválido.");

            var regiao = await _regiaoRepository.GetAsync(dto.Id);
            if (regiao == null)
                throw new KeyNotFoundException("Região não encontrada.");

            regiao.Ativo = dto.Ativo;
            await _regiaoRepository.UpdateAsync(regiao);
        }
    }
}
