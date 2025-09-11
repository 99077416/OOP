using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_battle5
{
    public class Pokeball
    {
        private Pokemon capturedPokemon;
        private bool hasPokemon;

        public void capturePokemon(Pokemon pokemon)
        {
            capturedPokemon = pokemon;
        }

        public Pokemon Open()
        {
            Console.WriteLine($"{capturedPokemon.GetName()} released");
            hasPokemon = false;
            return capturedPokemon;
        }

        public void close()
        {
            Console.WriteLine($"{capturedPokemon.GetName()} returned");
            hasPokemon = true;
        }

        public Pokemon CapturedPokemon()
        {
            return capturedPokemon;
        }

        public bool HasPokemon()
        {
            return hasPokemon;
        }
    }
}
