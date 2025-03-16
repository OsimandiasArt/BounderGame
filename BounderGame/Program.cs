using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BounderGame
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Witaj Strzelcu!");
            Console.WriteLine("Jak Ci na imię?");

                var shooter = Console.ReadLine();

            Console.WriteLine("No dobra, " + shooter + "!");
            Console.WriteLine("Pokaż na co Cię stać!");
        }
    }
}
