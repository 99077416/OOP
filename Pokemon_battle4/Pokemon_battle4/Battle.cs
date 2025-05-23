using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pokemon_battle4
{
    public static class Battle
    {

        public static void startBattle(Trainer trainer1, Trainer trainer2)
        {



            Random random = new Random();

                trainer1.belt = trainer1.belt.OrderBy(i => Guid.NewGuid()).ToList();
                trainer2.belt = trainer2.belt.OrderBy(i => Guid.NewGuid()).ToList();

            for
                {
                Pokemon pokemon1 = trainer1.Throw(0);
                Pokemon pokemon2 = trainer2.Throw(0);

                if (pokemon1.strength == pokemon2.weakness)
                {
                    Arena.addscore(1);

                }
                if (pokemon1.weakness == pokemon2.strength)
                {
                    Arena.addscore(2);

                }
                if (pokemon1.strength == pokemon2.strength)
                {
                    Arena.addscore(1);
                    Arena.addscore(2);

                }



            }




            
            while (trainer1.belt.Count > 1 || trainer2.belt.Count > 1) 
            {
               
                Pokemon pokemon1 = trainer1.Throw(0);
                Pokemon pokemon2 = trainer2.Throw(0);

                string win = pokemon1.name;

                if (pokemon1.strength == pokemon2.weakness)
                {
                    Arena.addscore(1);
                    trainer2.belt.Remove(trainer2.belt[0]);
                    trainer2.belt = trainer2.belt.OrderBy(i => Guid.NewGuid()).ToList();
                    win = pokemon1.name;
                }
                if (pokemon1.weakness == pokemon2.strength)
                {
                    Arena.addscore(2);
                    trainer1.belt.Remove(trainer1.belt[0]);
                    trainer1.belt = trainer1.belt.OrderBy(i => Guid.NewGuid()).ToList();
                    win = pokemon2.name;
                }
                if (pokemon1.strength == pokemon2.strength)
                {
                    Arena.addscore(1);
                    Arena.addscore(2);

                }

                Console.WriteLine(trainer1.belt.Count);
                Console.WriteLine(trainer2.belt.Count);
                Console.WriteLine();
                Console.WriteLine(Arena.score1);
                Console.WriteLine(Arena.score2);
            }
        }
    }
}
