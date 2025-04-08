using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_battle4
{
    public class Pokemon
    {
        public string name;
        public string strength;
        public string weakness;

        public Pokemon(string name)
        {
            name = name;
        }
        public void Battlecry()
        {
            Console.WriteLine(name + "!");
        }
    }
}
