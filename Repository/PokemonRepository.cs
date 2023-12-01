using PokemonReviewApp.Data;
using PokemonReviewApp.Models;
using System.Runtime.CompilerServices;

namespace PokemonReviewApp.Repsitory
{
    public class PokemonRepository
    {
        private readonly DataContext _context;
        public PokemonRepository(DataContext context) 
        {
            _context = context;
        }

        public ICollection<Pokemon> GetPokemons()
        {
            return _context.Pokemon.OrderBy(p => p.Id).ToList();
        }
    }
}
