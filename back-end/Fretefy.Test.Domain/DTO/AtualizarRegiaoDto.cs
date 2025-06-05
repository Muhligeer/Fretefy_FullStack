using System;
using System.Collections.Generic;
using System.Text;

namespace Fretefy.Test.Domain.DTO
{
    public class AtualizarRegiaoDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public List<Guid> Cidades { get; set; }
    }
}
