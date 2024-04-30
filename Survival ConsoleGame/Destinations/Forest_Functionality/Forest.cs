
using Survival_ConsoleGame.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survival_ConsoleGame.Destinations
{
    internal class Forest
    {
        PlayerInventory playerInventory;
        _Player player;

        public Forest(PlayerInventory inventory, _Player playerIns)
        {
            playerInventory = inventory;
            player = playerIns;
        }



        public void Destination_ForestMenu()
        {
                Console.WriteLine("Tip: Here in the forest you can be chill and just get tired a bit but that's all");
                Console.WriteLine();
                Console.WriteLine("~1.Hunt Deers (+Meat(2), -energy(50))");
                Console.WriteLine("~2.Chop Trees (+Wood(2), -energy(40))");
                Console.WriteLine("~3.Collect Grass (+Grass(5), -energy(10))");
                Console.WriteLine("~4.Check Inventory");
                Console.WriteLine("~5.Go Back");
                int n;
                Console.WriteLine();
                Console.WriteLine(">   ");

            while (true)
            {
                n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Hunt(playerInventory);                       
                        break;

                    case 2:
                       
                        ChopTrees(playerInventory);
                        break;

                    case 3:
                       
                        CollectGrass(playerInventory);
                        break;

                    case 4:

                        playerInventory.DisplayItems();
                        break;

                    case 5:
                        player.Start_PlayerMenu();
                        break;
                }
            }
        }

        //Hunt get +2 Meat
        public void Hunt(PlayerInventory playerInventory)
        {
            playerInventory.AddItem(6, 2);
        }

        //Chopping Trees get +3 Wood
        public void ChopTrees(PlayerInventory playerInventory)
        {
            playerInventory.AddItem(1, 3);
        }

        //Collect Grass get +5 Grass
        public void CollectGrass(PlayerInventory playerInventory)
        {
            playerInventory.AddItem(5, 5);
        }


    }
}
