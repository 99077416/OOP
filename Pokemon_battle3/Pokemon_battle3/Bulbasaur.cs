using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_battle3
{
    public class Bulbasaur : Pokemon
    {
        public Bulbasaur(string name) : base(name)
        {
            this.name = name;
            this.strength = "grass";
            this.weakness = "fire";
        }
    }
}
