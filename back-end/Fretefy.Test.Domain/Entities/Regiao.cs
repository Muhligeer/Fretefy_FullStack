using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fretefy.Test.Domain.Entities
{
    public class Regiao : IEntity
    {
        private readonly List<RegiaoCidade> _cidades = new List<RegiaoCidade>();

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public IReadOnlyCollection<RegiaoCidade> Cidades => _cidades.AsReadOnly();

        public Regiao()
        {
        }

        public Regiao(string nome, IEnumerable<Guid> cidades)
        {
            Id = Guid.NewGuid();
            AtualizarNome(nome);
            Ativo = true;
            DefinirCidades(cidades);
        }

        public void Atualizar(string nome, IEnumerable<Guid> cidades, bool ativo)
        {
            AtualizarNome(nome);
            DefinirCidades(cidades);
            Ativo = ativo;
        }

        public void AlterarStatus(bool ativo)
        {
            Ativo = ativo;
        }

        private void AtualizarNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("O nome da região é obrigatório.");

            Nome = nome;
        }

        private void DefinirCidades(IEnumerable<Guid> cidadeIds)
        {
            if (cidadeIds == null || !cidadeIds.Any())
                throw new ArgumentException("É necessário informar ao menos uma cidade.");

            if (cidadeIds.Count() != cidadeIds.Distinct().Count())
                throw new ArgumentException("Não é permitido repetir a mesma cidade.");

            _cidades.Clear();
            foreach (var cidadeId in cidadeIds)
            {
                _cidades.Add(new RegiaoCidade
                {
                    CidadeId = cidadeId,
                    RegiaoId = Id
                });
            }
        }
    }
}
