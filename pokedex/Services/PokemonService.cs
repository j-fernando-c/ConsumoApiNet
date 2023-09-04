using pokedex.Models;

namespace pokedex.Services
{
    public class PokemonService
    {
        private readonly HttpClient _httpClient;

        public PokemonService(HttpClient httpClient)
        {
            _httpClient = httpClient;

        }

        public async Task<IEnumerable<Pokemon>> GetPokemons()
        {
            var response = await _httpClient.GetFromJsonAsync<PokemonApiResponse>("https://rickandmortyapi.com/api/character");
                return response.Results;
        }

        public class PokemonApiResponse
        {
            public IEnumerable<Pokemon> Results { get; set; }

            public PokemonApiResponse()
            {
                Results = new List<Pokemon>();
            }
        }
    }
}
