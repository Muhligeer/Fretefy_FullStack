using System;
using System.Collections.Generic;
using System.Text;

namespace Fretefy.Test.Domain.DTO
{
    public class CriarRegiaoDto
    {
        public string Nome { get; set; }
        public List<Guid> Cidades { get; set; } = new List<Guid>();
    }
}
