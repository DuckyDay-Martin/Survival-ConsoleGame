using Survival_ConsoleGame.Destinations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survival_ConsoleGame
{
    internal class Engine : Player
    {
       // Player player = new Player();
        Hut destination_HUT = new Hut();
        Forest destination_FOREST = new Forest();
        Mountains destination_MOUNTAINS = new Mountains();



        public void Start_Tutorial()
        {
            Console.WriteLine("Before we proceed , please enter you nickname...");
            Console.WriteLine();
            nickname = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hello and welcome " + nickname + " to the ~VOID~");
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

        public void Start_PlayerMenu()
        {           
            Console.WriteLine("Tip: So , here are your options or freedom for what you can do or where to go");

            Console.WriteLine("~1.Your Hut");
            Console.WriteLine("~2.Forest");
            Console.WriteLine("~3.Mountains");
            Console.WriteLine("~4.City");
            Console.WriteLine("~5.Player");
            
            
            Console.WriteLine();
            Console.WriteLine("> ");
            int n = int.Parse(Console.ReadLine());

            switch (n)
            {

                case 1:
                    Console.Clear();
                    destination_HUT.Destination_HutMenu();
                    break;

                case 2:
                    Console.Clear();
                    destination_FOREST.Destination_ForestMenu();
                    break;

                case 3:
                    Console.Clear();
                    destination_MOUNTAINS.Destination_MountainsMenu();
                    break;
            
            }
        }
       
    }
}
