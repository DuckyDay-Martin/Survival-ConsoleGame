﻿
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

        //Creating player ref so i can keep the PlayerInventory instance consistent
        public Forest(PlayerInventory inventory, _Player playerRef)
        {
            playerInventory = inventory;
            player = playerRef;
        }



        public void Destination_ForestMenu()
        {
                Console.WriteLine("Tip: Here in the forest you can be chill and just get tired a bit but that's all");
                Console.WriteLine();
                Console.WriteLine($"Health: {player.Player_DisplayHealth()}");
                Console.WriteLine($"Energy: {player.Player_DisplayEnergy()}");
                Console.WriteLine();
                Console.WriteLine("~1.Hunt Deers (Meat(+2), Energy(-50))");
                Console.WriteLine("~2.Chop Trees (Wood(+3), Energy(-40))");
                Console.WriteLine("~3.Collect Grass (Grass(+5), Energy(-10))");
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
                        Console.WriteLine();
                        Console.WriteLine("+2 Meat was added to your inventory! ");
                        player.Player_UpdateEnergy(50, 0);
                        Hunt(playerInventory);
                        Console.Clear();
                        Destination_ForestMenu();
                        break;

                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("+3 Wood was added to your inventory! ");
                        player.Player_UpdateEnergy(40, 0);
                        ChopTrees(playerInventory);
                        Console.Clear();
                        Destination_ForestMenu();
                        break;

                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("+5 Grass was added to your inventory! ");
                        player.Player_UpdateEnergy(10, 0);
                        CollectGrass(playerInventory);
                        Console.Clear();
                        Destination_ForestMenu();
                        break;

                    case 4:

                        playerInventory.DisplayItems();
                        break;

                    case 5:
                        Console.Clear();
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
