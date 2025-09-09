using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokemon_battle4;

namespace Pokemon_battle4
{
    public class Squirtle : Pokemon
    {
        public Squirtle(string name) : base(name, "water", "grass")
        {

        }
        public override void Battlecry()
        {
            Console.WriteLine($"{this.Name}!");
        }
    }
}
