using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBattle2;

namespace PokemonBattle2
{
    class Pokeball(Charmander pokemon)
    {
        public Charmander pokemon = pokemon;
        public bool hasPokemon;

        public Charmander open()
        {
            Console.WriteLine($"{pokemon.name} released");
            hasPokemon = false;
            return pokemon;
        }

        public void close(Charmander pokemon)
        {
            Console.WriteLine($"{pokemon.name} returned");
            hasPokemon = true;
        }
    }
}
