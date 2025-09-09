using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Pokemon_battle4;

namespace Pokemon_battle4
{
    public class Charmander : Pokemon
    {
        public Charmander(string Name) : base(Name, "fire", "water")
        {

        }

        public override void Battlecry()
        {
            Console.WriteLine($"{this.Name}!");
        }
    }
}
