using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_battle4
{
    public class Charmander : Pokemon
    {
        public Charmander(string name) : base(name)
        {
            this.name = name;
            this.strength = "fire";
            this.weakness = "water";
        }
    }
}
