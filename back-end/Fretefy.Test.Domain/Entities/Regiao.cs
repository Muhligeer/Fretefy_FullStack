using System;
using System.Collections.Generic;
using System.Text;

namespace Fretefy.Test.Domain.Entities
{
    public class Regiao : IEntity
    {
        public Regiao()
        {
        }

        public Regiao(string nome, bool ativo)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Ativo = ativo;
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public ICollection<RegiaoCidade> Cidades { get; set; } = new List<RegiaoCidade>();
    }
}
