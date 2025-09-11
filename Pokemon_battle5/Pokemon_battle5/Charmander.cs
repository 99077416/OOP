using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Pokemon_battle5;

namespace Pokemon_battle5
{
    public class Charmander : Pokemon
    {
        public Charmander(string Name) : base(Name, Type.Fire, Type.Water)
        {

        }

        public override void Battlecry()
        {
            Console.WriteLine($"{this.GetName()}!");
        }
    }
}
