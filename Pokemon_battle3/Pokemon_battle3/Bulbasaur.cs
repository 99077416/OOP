using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_battle3
{
    public class Bulbasaur : Pokemon
    {
        public Bulbasaur(string name) : base(name,"grass","fire")
        {

        }
        public override void Battlecry()
        {
            Console.WriteLine($"{this.Name}!");
        }
    }
}
