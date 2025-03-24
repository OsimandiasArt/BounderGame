using BounderGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BounderGame.DiceRoller;

Console.WriteLine("Howdy Shooter!");
Console.WriteLine("How'd they call Ya?");

var shooter = Console.ReadLine();

Console.WriteLine("Alrighty, " + shooter + "!");
Console.WriteLine("Show'em those guns!");

int pouch = (50);

Console.WriteLine("Your pocket gots " + pouch + " gold coins!");
Console.WriteLine("Make good use of'em!");

Console.WriteLine("What is Yer first bet?");

string bet = Console.ReadLine();
var bet1 = int.Parse(bet);

Console.WriteLine("So Yer puttin " + bet + " gold!");
Console.WriteLine("Shoot'em " + shooter);

DiceRoller diceRoller = new DiceRoller();

var firstShot = diceRoller.Roll(20);
var secondShot = diceRoller.Roll(20);
var houseShotOne = diceRoller.Roll(6);
var houseShotTwo = diceRoller.Roll(6);
var houseShotThree = diceRoller.Roll(6);
var houseShots = (houseShotOne + houseShotTwo + houseShotThree);

Console.WriteLine("Your first shot is: " + firstShot);
Console.WriteLine("...");

Console.WriteLine("My turn!");
Console.WriteLine("First is: " + houseShotOne);
Console.WriteLine("...");
Console.WriteLine("Next one: " + houseShotTwo);
Console.WriteLine("...");
Console.WriteLine("And the last shot: " + houseShotThree);
Console.WriteLine("...");
Console.WriteLine("That's " + houseShots + " in total! What do Ya say, boy?");
Console.WriteLine("...");

Console.WriteLine("Yer second shot is: " + secondShot);
Console.WriteLine("So You got " + firstShot + " and " + secondShot + " ! Pretty nice!");
Console.WriteLine("...");
Console.WriteLine("I got " + houseShots + "! Are ye winning " + shooter + " ?");


if (houseShots == firstShot)
{
    Console.WriteLine("Sorry, not a chance!");
    
}
else if (firstShot < houseShots && houseShots < secondShot)
{
    Console.WriteLine("Huzzah Boy! Ya win this round!Here's yer " + bet1 * 2 + " gold coins!");
    
}

else if (secondShot < houseShots && houseShots < firstShot)
{
    Console.WriteLine("Huzzah Boy! Ya wind this round! Here's yer " + bet1 * 2 + " gold coins!");
    
}
else
{
    Console.WriteLine("Aww, that's over shooted... another time " + shooter + ", another time...");
  
}
