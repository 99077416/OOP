﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_battle3
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
