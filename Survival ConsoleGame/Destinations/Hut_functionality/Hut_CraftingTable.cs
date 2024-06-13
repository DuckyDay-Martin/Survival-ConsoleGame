using Survival_ConsoleGame.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Survival_ConsoleGame.Destinations.Hut_functionality
{
    internal class Hut_CraftingTable
    {

        PlayerInventory playerInventory;
        _Player player;
        
      

        public Hut_CraftingTable(PlayerInventory inventory, _Player playerRef)
        {
            this.playerInventory = inventory;
            this.player = playerRef;

        }

        public void Hut_CraftinTable()
        {
            Console.Clear();
            //re-do the menu
            Console.WriteLine("Tip: By using those items your living will get a bit easier\n" +
                              "");            
            Console.WriteLine("1.Knife - (1)Wood / (1)Rock / (1)Rope\n" +
                              "--> Will reduce the damage taken while hunting by 40%");
            Console.WriteLine();
            Console.WriteLine("2.Axe - (2)Wood / (1)Rock / (2)Rope\n" +
                              "--> Will reduce the energy lost while chopping woods by 60%");
            Console.WriteLine();
            Console.WriteLine("3.Lighter - (1)Plastic / (1)Rock\n" + 
                              "--> Will help you cook and keep warm in your hut");
            Console.WriteLine();
            Console.WriteLine("4.Rope - (5)Grass\n" +
                              "--> Will help you craft the knife and also some other cool stuff");
            Console.WriteLine();
            Console.WriteLine("5.Pickaxe - (2)Wood / (2)Rock / (2)Rope\n" +
                              "--> Will reduce the energy taken while mining");
            Console.WriteLine();
            Console.WriteLine("6. Go Back.");

            Console.WriteLine();
            Console.WriteLine("> ");
            int n;

            while (true)//re-do the crafting system - Create ItemsNeeded Method for not adding evrything manualy
            { 
                n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        int[] knifeNeededItems = { 1, 2, 11 };
                        IfCanCreateItem(playerInventory, 8, knifeNeededItems);
                        
                        break;

                    case 2:
                        int[] axeNeededItems = { 1, 1, 2, 11, 11};
                        IfCanCreateItem(playerInventory, 9, axeNeededItems);

                        break;

                    case 3:
                        int[] lighterNeededItems = { 3, 2 };
                        IfCanCreateItem(playerInventory, 10, lighterNeededItems);

                        break;

                    case 4:
                        int[] ropeNeededItems = { 5, 5, 5, 5, 5};
                        IfCanCreateItem(playerInventory, 11, ropeNeededItems);      
                        
                        break;

                    case 5:
                        int[] pickaxeNeededItems = { 1, 1, 2, 2, 11, 11};
                        IfCanCreateItem(playerInventory, 12, pickaxeNeededItems);
                        break;

                    case 6:
                        Console.Clear();
                        player.Start_PlayerMenu();
                        break;

                }
            }
        }


        public bool IfCanCreateItem(PlayerInventory inventory, int item, int[] itemsNeeded, int itemCountToBeAdded = 1)
        {
            foreach (var itemNeeded in itemsNeeded)
            {
                if (!inventory.HasItem(itemNeeded))
                {
                    Console.WriteLine("You don't have the materials for this item!\n" +
                                      "Go and get them , then come back!");
                    return false;
                }

            }

            foreach (var itemNeeded in itemsNeeded)
            {
                inventory.RemoveItem(itemNeeded);               
            }

            playerInventory.AddItem(item, itemCountToBeAdded);
            Console.WriteLine($"{item.GetType()} was crafted and added to your inventory!");
            return true;
        }
    }
}
