using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_battle5
{
    public class Bulbasaur : Pokemon
    {
        public Bulbasaur(string name) : base(name, Type.Grass, Type.Fire)
        {

        }
        public override void Battlecry()
        {
            Console.WriteLine($"{this.GetName()}!");
        }
    }
}
