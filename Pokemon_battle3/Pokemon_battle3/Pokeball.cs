using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_battle3
{
    public class Pokeball
    {
        public Pokemon capturedPokemon;
        public bool hasPokemon;

        public void capturePokemon(Pokemon pokemon)
        {
            capturedPokemon = pokemon;
        }

        public Pokemon open()
        {
            Console.WriteLine($"{capturedPokemon.Name} released");
            hasPokemon = false;
            return capturedPokemon;
        }

        public void close(Pokemon pokemon)
        {
            Console.WriteLine($"{pokemon.Name} returned");
            hasPokemon = true;
        }
    }
}
