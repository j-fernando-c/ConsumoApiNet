using Microsoft.AspNetCore.Mvc;
using pokedex.Services;

namespace pokedex.Controllers
{
    public class PokemonController : Controller
    {
        private readonly PokemonService _pokemonService;

        public PokemonController(PokemonService pokemonService)
        {
            _pokemonService = pokemonService;
        }

        [HttpGet]

        public async Task<IActionResult>index() { 
            var pokemons = await _pokemonService.GetPokemons();
            return View(pokemons);
        }

    }
}
