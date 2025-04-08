using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_battle4
{
    public class Arena
    {
        public static int score1;
        public static int score2;

        public static void addscore(int num)
        {
            if (num == 1)
            {
                score1++;
            }
            if (num == 2)
            {
                score2++;
            }
        }
    }
}
