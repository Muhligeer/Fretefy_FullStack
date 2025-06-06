using System;
using System.Collections.Generic;
using System.Text;

namespace Fretefy.Test.Domain.ValueObjects
{
    public class Nome
    {
        public string Valor { get; }

        protected Nome() { }

        public Nome(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
                throw new ArgumentException("Nome inválido.");

            Valor = valor.Trim();
        }

        public override string ToString() => Valor;

        public override bool Equals(object obj) =>
            obj is Nome nome && Valor.Equals(nome.Valor, StringComparison.OrdinalIgnoreCase);

        public override int GetHashCode() => Valor.GetHashCode();
    }
}
