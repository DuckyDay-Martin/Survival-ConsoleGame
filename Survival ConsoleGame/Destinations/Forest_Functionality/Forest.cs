using Survival_ConsoleGame.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survival_ConsoleGame.Destinations
{
    internal class Forest
    {
        Player player = new Player();
        List<int> inventory = new List<int>();
        Resources resources = new Resources();
        Dictionary<int, string> availableResources = new Dictionary<int, string>();
        
        public void Destination_ForestMenu()
        {
            resources.AvailableResources(availableResources);


            Console.WriteLine("Tip: Here in the forest you can be chill and just get tired a bit but that's all");
            Console.WriteLine();
            Console.WriteLine("~1.Hunt Deers (+Meat, -energy)");
            Console.WriteLine("~2.Chop Trees (+Wood, -energy)");
            Console.WriteLine("~3.Collect Grass (+Grass, -energy)");

            Console.WriteLine();
            Console.WriteLine(">   ");
            int n = int.Parse(Console.ReadLine());

            
            switch (n)
            {
                case 1:
                    Forest_Hunt(inventory);
                    player.Player_Inventory(inventory, availableResources);
                    break;

                case 2:
                    Forest_ChopTrees(inventory);
                    player.Player_Inventory(inventory, availableResources);
                    break;

                case 3:
                    Forest_CollectGrass(inventory);
                    player.Player_Inventory(inventory, availableResources);
                    break;
            }
        }

        public void Forest_Hunt(List<int> inventory)
        {
            //To Do:Make random drop for meat
            inventory.Add(5);
            inventory.Add(5);
            Console.WriteLine("You hunted 2 meat!");
        }

        public void Forest_ChopTrees(List<int> inventory)
        {
            //To Do:Make random drop for wood
            inventory.Add(1);
            Console.WriteLine("Congrats, now you have +1 wood in your inventroy");
        }

        public void Forest_CollectGrass(List<int> inventory)
        {
            inventory.Add(1);
            inventory.Add(1);
            inventory.Add(1);
            inventory.Add(1);
            inventory.Add(1);
            Console.WriteLine("I mean ,collecting grass can be hard too...well you've collected 5 grass");
        }
    }
}
