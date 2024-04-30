using Survival_ConsoleGame.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Survival_ConsoleGame.Destinations
{
    internal class Mountains
    {
        PlayerInventory playerInventory;
        _Player player;

        public Mountains(PlayerInventory inventory, _Player playerRef)
        {
            playerInventory = inventory;
            player = playerRef;
        }

        public void Destination_MountainsMenu()
        {

            Console.WriteLine("Tip: In those cold mountains you can try to get some resources but you need to be strong because it's dangerouse");
            Console.WriteLine();
            Console.WriteLine("~1.Mine (+Iron,+Rocks, -energy)");
            Console.WriteLine("~2.Collect Water (+Water)");
            Console.WriteLine("~3.Hunt Wolfs (+++Meat, -Health, --Energy)");
            Console.WriteLine("~4.Display Inventory");
            Console.WriteLine("~5.Go Back");
            int n;
            Console.WriteLine();
            Console.WriteLine(">");


            while (true)
            {
                n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Mine(playerInventory);
                        break;

                    case 2:

                        CollectWater(playerInventory);
                        break;

                    case 3:

                        HuntWolfes(playerInventory);
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

        //Mine and get +2 Iron
        public void Mine(PlayerInventory playerInventory)
        {
            playerInventory.AddItem(4, 2);
        }

        //Collect Water and get +1 Bottle of Water
        public void CollectWater(PlayerInventory playerInventory)
        {
            playerInventory.AddItem(7, 1);
        }

        //Hunt Wolves and get more meat(Wolve meat) +5
        public void HuntWolfes(PlayerInventory playerInventory)
        {
            playerInventory.AddItem(6, 5);
        }
    }
}
