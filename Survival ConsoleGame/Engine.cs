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
       // Player player = new Player();
        
        private Dictionary<int, string> availableResources;
        private PlayerInventory inventory;

        public Engine() 
        {
            availableResources = new Dictionary<int, string>();
            inventory = new PlayerInventory();
        }

        public void AvailableResources()
        {
                availableResources.Add(1, "Wood");
                availableResources.Add(2, "Iron");
                availableResources.Add(3, "Grass");
                availableResources.Add(4, "Stone");
                availableResources.Add(5, "Meat");
        }


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

        //Forest Func
        public void Hunt()
        {
            inventory.Add_ItemToInventory(5, 2);
        }
        public void ChopTrees()
        {
            inventory.Add_ItemToInventory(1, 2);
        }
        public void CollectGrass()
        {
            inventory.Add_ItemToInventory(3, 5);
        }

    
    }
}
/*
Now ,the functionality for every destination will be implemented here - in the Engine because it's easier for me to keep track on the inventory and to keep track on the current
game state, and also to save the items in the list
*/