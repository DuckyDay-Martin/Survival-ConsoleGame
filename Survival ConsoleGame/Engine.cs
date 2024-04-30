using Survival_ConsoleGame.Destinations;
using Survival_ConsoleGame.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survival_ConsoleGame
{
    public class Engine
    {
      
        public void Start_Tutorial()
        {
            Console.WriteLine("Before we proceed , please enter you nickname...");
            Console.WriteLine();       
            Console.WriteLine();
            Console.WriteLine("Hello and welcome to the ~VOID~");
            Console.WriteLine("A survival console ,menu based mini game");
            Console.WriteLine("Basically you will have the option to 1.Craft 2.Fight 3.Farm Materials 4.Sleep and other stuff");
            Console.WriteLine("On every player menu page there will be a brief explanation what the option is doing so no worries");
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue");

            string input = Console.ReadLine();

            if (input == "x")
            {
                Console.Clear();
            }
            else
            {                
                Console.Clear();
            }
        }

    }
}
/*
Fuck that shit
*/