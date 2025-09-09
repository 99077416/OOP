using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pokemon_battle4
{
    public class Battle
    {

        static Random rnd = new Random();
        static List<int> UsedPokemons1 = new List<int>();
        static List<int> UsedPokemons2 = new List<int>();

        public static void StartBattle(Trainer trainer1, Trainer trainer2)
        {
            Arena.ResetScore();
            UsedPokemons1.Clear();
            UsedPokemons2.Clear();

            while (UsedPokemons1.Count < 6)
            {

                int rndint1 = rnd.Next(trainer1.belt.Count);
                int rndint2 = rnd.Next(trainer2.belt.Count);

                while (UsedPokemons1.Contains(rndint1) == true)
                {
                    rndint1 = rnd.Next(trainer1.belt.Count);
                }
                UsedPokemons1.Add(rndint1);
                Pokemon pokemon1 = trainer1.Throw(rndint1);

                while (UsedPokemons2.Contains(rndint2) == true)
                {
                    rndint2 = rnd.Next(trainer2.belt.Count);
                }
                UsedPokemons2.Add(rndint2);
                
                
                
                Pokemon pokemon2 = trainer2.Throw(rndint2);
                
                
                if (pokemon1.Strength == pokemon2.Weakness)
                {
                    Console.WriteLine($"{pokemon1.Name} wins");
                    Arena.Addscore(1);
                }

                if (pokemon2.Strength == pokemon1.Weakness)
                {
                    Console.WriteLine($"{pokemon2.Name} wins");
                    Arena.Addscore(2);
                }
                
                if (pokemon2.Strength == pokemon1.Strength)
                {
                    Console.WriteLine("draw");
                }
                
                trainer1.Return(rndint1);
                trainer2.Return(rndint2);
                
                Console.WriteLine();
                Arena.Addround();
            }
            
            Arena.Addbattle();
        }
    }
}
