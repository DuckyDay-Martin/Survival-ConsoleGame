using Survival_ConsoleGame.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survival_ConsoleGame.Destinations.Hut_functionality
{
    internal class Hut_Oven
    {
        PlayerInventory playerInventory;
        _Player player;
        Hut_CraftingTable hut;

        public Hut_Oven(PlayerInventory inventory, _Player playerRef) 
        {
            this.playerInventory = inventory;
            this.player = playerRef;
            hut = new Hut_CraftingTable(inventory, playerRef);
        }



        public void Hut_OvenView()
        {
            Console.Clear();
            Console.WriteLine("Tip:Here you can cook something to eat or drink!\n" +
                              "All the food that you will cook here will be added\n" +
                              "to your inventory so you can use them whenever you want!\n" +
                              "But keep in mind that you will need at least 2 wood everythime you are cooking something.\n" +
                              "\n" +
                              "~1.Cook Meat(+35 HP)\n" +
                              "--> 2 Meat needed\n" +
                              "\n" +
                              "~2.Cook Grilled Fish(+50 HP)\n" +
                              "--> 1 Fish needed per portion\n" +
                              "\n" +
                              "~3.Fruit Salad(+ 20 HP)\n" +
                              "--> 1 pack of Berries, 2 Apples needed\n" +
                              "\n" +
                              "~4.Stew(+ 45 HP)\n" +
                              "--> 1 Meat, 5 Herbs needed\n" +
                              "\n" +
                              "~5.Cooked Fish(+ 30 HP)\n" +
                              "--> 1 Fish needed\n" +
                              "\n" +
                              "~6. Inventory\n" +
                              "\n" +
                              "~7. Go Back\n" +
                              "\n" +
                              "> ");

            int n;

            while (true)
            {
                n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        int[] cookedMeatNeededItems = { 6, 6 };
                        hut.IfCanCreateItem(playerInventory, 18, cookedMeatNeededItems);

                        break;

                    case 2:
                        int[] grilledFishNeededItems = { 16 };
                        hut.IfCanCreateItem(playerInventory, 19, grilledFishNeededItems);

                        break;

                    case 3:
                        int[] fruitNeededItems = { 14, 13, 13 };
                        hut.IfCanCreateItem(playerInventory, 20, fruitNeededItems);

                        break;

                    case 4:
                        int[] stewNeededItems = { 6, 17, 17, 17, 17, 17 };
                        hut.IfCanCreateItem(playerInventory, 21, stewNeededItems);

                        break;

                    case 5:
                        int[] cookedFishNeededItems = { 16 };
                        hut.IfCanCreateItem(playerInventory, 22, cookedFishNeededItems);
                        break;

                    case 6:
                        playerInventory.DisplayItems();
                        break;

                    case 7:
                        Console.Clear();
                        player.Start_PlayerMenu();
                        break;

                }

            }
        }

     
    }
}
