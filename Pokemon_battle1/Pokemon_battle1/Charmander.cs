using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_battle1
{
    public class Charmander
    {
        public string name;
        public string strength;
        public string weakness;

        public Charmander(string name, string strength, string weakness)
        {
            this.name = name;
            this.strength = strength;
            this.weakness = weakness;
        }
        public string Battlecry()
        {
            Console.WriteLine(name + "!");
            return name;
        }
    }
}
