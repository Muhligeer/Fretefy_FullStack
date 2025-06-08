using System;
using System.Collections.Generic;
using System.Text;

namespace Fretefy.Test.Domain.Entities
{
    public class RegiaoCidade
    {
        public Guid RegiaoId { get; set; }
        public Regiao Regiao { get; set; }

        public Guid CidadeId { get; set; }
        public Cidade Cidade { get; set; }
    }
}
