using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_battle5
{
    public class Trainer
    {
        private string Name;
        private List<Pokeball> belt;

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

        public string GetName()
        {
            return Name;
        }

        public List<Pokeball> GetBelt()
        {
            return belt;
        }
    }
}
