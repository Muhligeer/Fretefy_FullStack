using Fretefy.Test.Domain.DTO;
using Fretefy.Test.Domain.Interfaces.Services;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Fretefy.Test.Infra.Services
{
    public class MapboxLocalizacaoService : ILocalizacaoService
    {
        private readonly HttpClient _httpClient;
        private readonly string _accessToken;

        public MapboxLocalizacaoService(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _httpClient = httpClientFactory.CreateClient();
            _accessToken = configuration["Mapbox:AccessToken"];
        }
        public async Task<CoordenadaDto> ObterCoordenadasAsync(string cidade, string uf)
        {
            var url = $"https://api.mapbox.com/geocoding/v5/mapbox.places/{cidade},{uf}.json?access_token={_accessToken}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            var obj = JsonDocument.Parse(json);

            var features = obj.RootElement.GetProperty("features");
            if (features.GetArrayLength() == 0)
                return null;

            var coords = features[0].GetProperty("geometry").GetProperty("coordinates");
            return new CoordenadaDto
            {
                Longitude = coords[0].GetDouble(),
                Latitude = coords[1].GetDouble()
            };
        }
    }
}
