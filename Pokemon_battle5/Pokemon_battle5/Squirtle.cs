using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pokemon_battle5
{
    public class Squirtle : Pokemon
    {
        public Squirtle(string name) : base(name, Type.Water, Type.Grass)
        {

        }
        public override void Battlecry()
        {
            Console.WriteLine($"{this.GetName()}!");
        }
    }
}
