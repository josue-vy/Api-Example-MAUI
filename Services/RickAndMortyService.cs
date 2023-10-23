using ApiExample.Models;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace ApiExample.Services
{
    public class RickAndMortyService : IRickAndMortyService
    {
        private string urlApi="https://rickandmortyapi.com/api/character";

        public async Task<List<PersonajesResponse>> Get()
        {
            var client = new HttpClient();
            var response = await client.GetAsync(urlApi);
            var responseBody = await response.Content.ReadAsStringAsync();
            JsonNode nodes = JsonNode.Parse(responseBody);
            JsonNode results = nodes["results"];

            var personajeData = JsonSerializer.Deserialize<List<PersonajesResponse>>(results.ToString());
            return personajeData;

        }
    }
}