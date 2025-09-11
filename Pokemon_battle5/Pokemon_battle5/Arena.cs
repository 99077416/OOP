using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_battle5
{

    public static class Arena
    {
        private static int score1;
        private static int score2;

        private static int rounds;
        private static int battles;

        public static void CreateBattle(Trainer trainer1, Trainer trainer2)
        {

            Battle.StartBattle(trainer1, trainer2);
        }

        public static void ResetScore()
        {
            score1 = 0;
            score2 = 0;
        }

        public static void Addscore(int i)
        {
            if (i == 1)
            {
                score1 += 1;
            }
            if (i == 2)
            {
                score2 += 1;
            }

        }
        public static void Addround()
        {
            rounds += 1;
        }
        public static void Addbattle()
        {
            battles += 1;
        }
        public static int GetBattlesFought()
        {
            return battles;
        }
        public static int GetRoundsFought()
        {
            return rounds;
        }

        public static int GetScore1()
        {
            return score1;
        }

        public static int GetScore2()
        {
            return score2;
        }



    }
}
