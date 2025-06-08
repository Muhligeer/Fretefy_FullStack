using Fretefy.Test.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Fretefy.Test.Domain.Interfaces.Services
{
    public interface ILocalizacaoService
    {
        Task<CoordenadaDto> ObterCoordenadasAsync(string cidade, string uf);
    }
}
