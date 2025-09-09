using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_battle4
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
            return ball.Open();
        }
        public void Return(int i)
        {
            Pokeball ball = belt[i];
            if (ball.hasPokemon == false)
            {
                ball.close();
            }
        }
    }
}
