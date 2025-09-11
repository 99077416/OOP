using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pokemon_battle5
{

    public enum Type
    {
        Fire,
        Water,
        Grass,
    }

    abstract public class Pokemon
    {

        private string Name;
        private Type Strength;
        private Type Weakness;

        public Pokemon(string name, Type strength, Type weakness)
        {
            Name = name;
            Strength = strength;
            Weakness = weakness;

        }
        public string GetName()
        {
            return Name;
        }

        public Type GetStrength()
        {
            return Strength;
        }

        public Type GetWeakness()
        {
            return Weakness;
        }

        public abstract void Battlecry();
    }
}
