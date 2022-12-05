using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    public class Roll
    {
        public void Outcome()
        {
            int PositionP1 = 0;
            int Dice;
                Random random = new Random();
                Dice = random.Next(1, 6);
                Console.WriteLine(" Player rolls the die to get a number:" + Dice);

        }
    }
}
