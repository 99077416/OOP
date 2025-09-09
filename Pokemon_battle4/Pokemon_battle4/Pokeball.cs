using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_battle4
{
    public class Pokeball
    {
        public Pokemon capturedPokemon;
        public bool hasPokemon;

        public void capturePokemon(Pokemon pokemon)
        {
            capturedPokemon = pokemon;
        }

        public Pokemon Open()
        {
            Console.WriteLine($"{capturedPokemon.Name} released");
            hasPokemon = false;
            return capturedPokemon;
        }

        public void close()
        {
            Console.WriteLine($"{capturedPokemon.Name} returned");
            hasPokemon = true;
        }
    }
}
