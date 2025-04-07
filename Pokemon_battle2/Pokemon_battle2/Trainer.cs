using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pokemon_battle2
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

        public Charmander Throw(int i)
        {
            Pokeball ball = belt[i];
            return ball.open();
        }
        public void Return(Charmander pokemon, int i)
        {
            Pokeball ball = belt[i];
            if (ball.hasPokemon == false)
            {
                ball.close(pokemon);
            }
        }
    }
}