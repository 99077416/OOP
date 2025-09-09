using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pokemon_battle4
{
    abstract public class Pokemon
    {

        public string Name;
        public string Strength;
        public string Weakness;

        public Pokemon(string name, string strength, string weakness)
        {
            Name = name;
            Strength = strength;
            Weakness = weakness;

        }
        public abstract void Battlecry();
    }
}
