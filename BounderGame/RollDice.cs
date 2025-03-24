using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BounderGame
{

public class DiceRoller
    {
        private Random random;

        public DiceRoller()
        {
            random = new Random();
        }

        public int Roll(int sides)
        {
            if (sides < 2)
            {
                throw new ArgumentException("Kość musi mieć co najmniej 2 ścianki.");
            }
            return random.Next(1, sides + 1);
        }
     }
}
