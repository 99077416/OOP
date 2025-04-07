using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_battle3
{
    public class Trainer
    {
        public string Name;
        public List<Pokeball> belt;

        public Trainer(string name)
        {
            Name = name;
            belt = new List<Pokeball>();
        }

        public void Addball(Pokeball pokeball)
        {
            belt.Add(pokeball);
        }

        public Pokemon Throw(int i)
        {
            Pokeball ball = belt[i];
            return ball.open();
        }
        public void Return(Pokemon pokemon, int i)
        {
            Pokeball ball = belt[i];
            if (ball.hasPokemon == false)
            {
                ball.close(pokemon);
            }
        }
    }
}
