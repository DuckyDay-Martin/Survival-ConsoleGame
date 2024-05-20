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

        //Player needs energy implemented, the half is done
        public void Destination_MountainsMenu()
        {
            //Clear the Console every time to update the current health status
            Console.WriteLine("Tip: In those cold mountains you can try to get some resources but you need to be strong because it's dangerouse");
            Console.WriteLine();
            Console.WriteLine($"Health: {player.Player_DisplayHealth()} ");
            Console.WriteLine($"Energy: {player.Player_DisplayEnergy()}");
            Console.WriteLine();
            Console.WriteLine("~1.Mine (Iron(+1),Rocks(+3), energy(-40))");
            Console.WriteLine("~2.Collect Water (Water(+1))");
            Console.WriteLine("~3.Hunt Wolfs (Meat(+6), Health(-60), Energy(-70))");
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
                        Console.WriteLine();
                        Console.WriteLine("+2 Meat was added to your inventory! ");
                        Mine(playerInventory);
                        break;

                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("+1 Water Bottle was added to your inventory! ");
                        CollectWater(playerInventory);
                        break;

                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("+6 Meat was added to your inventory! ");
                        player.Player_UpdateHealth(60, 0);
                        HuntWolfes(playerInventory);
                        Console.Clear();
                        Destination_MountainsMenu();
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
