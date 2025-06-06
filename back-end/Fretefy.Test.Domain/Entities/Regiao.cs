using Fretefy.Test.Domain.Entities.Interfaces;
using Fretefy.Test.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fretefy.Test.Domain.Entities
{
    public class Regiao : IEntity, IAggregateRoot
    {
        public Guid Id { get; set; }
        public Nome Nome { get; set; }
        public bool Ativo { get; set; }
        public ICollection<RegiaoCidade> Cidades { get; set; }

        public Regiao()
        {
        }

        public Regiao(Guid id, Nome nome, IEnumerable<Guid> cidadeIds)
        {
            Id = id == Guid.Empty ? Guid.NewGuid() : id;
            SetNome(nome);
            Ativar();
            DefinirCidades(cidadeIds);
        }

        public void SetNome(Nome nome)
        {
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
        }

        public void Ativar() => Ativo = true;

        public void Desativar() => Ativo = false;

        public void DefinirCidades(IEnumerable<Guid> cidadeIds)
        {
            if (cidadeIds == null || !cidadeIds.Any())
                throw new ArgumentException("A região deve conter ao menos uma cidade.");

            if (cidadeIds.Count() != cidadeIds.Distinct().Count())
                throw new ArgumentException("Não é permitido repetir cidades.");

            Cidades = cidadeIds
                .Select(id => new RegiaoCidade { RegiaoId = Id, CidadeId = id })
                .ToList();
        }
    }
}
