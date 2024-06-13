using Survival_ConsoleGame.Destinations.Hut_functionality;
using Survival_ConsoleGame.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Survival_ConsoleGame.Destinations
{
    internal class Hut 
    {
         PlayerInventory playerInventory;
         _Player player;
        Hut_CraftingTable craftingTable;
        Hut_Oven oven;

        public Hut(PlayerInventory inventory, _Player playerRef)
        {
            playerInventory = inventory;
            player = playerRef;
            craftingTable = new Hut_CraftingTable(playerInventory, playerRef);
            oven = new Hut_Oven(playerInventory, playerRef);
        }

        public void Destination_HutMenu()
        {

            Console.WriteLine("Tip: So, here is your house ,where you can rest a bit from the harsh truth...\n");
            Console.WriteLine();
            Console.WriteLine($"Health: {player.Player_DisplayHealth()}");
            Console.WriteLine($"Energy: {player.Player_DisplayEnergy()}");
            Console.WriteLine();
            Console.WriteLine("~1.Go to Bed(+100 Energy, +50 Health)");
            Console.WriteLine("~2.Crafting Table");
            Console.WriteLine("~3.Oven");
            Console.WriteLine("~4.Go Back Outside. ");
            HutView();
            Console.WriteLine();
            Console.WriteLine(">");
            int n;

            while (true)
            {
                n = int.Parse(Console.ReadLine());

                switch (n)
                {

                    case 1:
                        Console.WriteLine();
                        player.Player_UpdateHealth(0 , 50);
                        player.Player_UpdateEnergy(0 , 100);
                        Console.Clear();
                        Destination_HutMenu();                       
                        break;

                    case 2:
                        craftingTable.Hut_CraftinTable();
                        break;

                    case 3:
                        Console.Clear();
                        oven.Hut_OvenView();
                        break;

                    case 4:
                        Console.Clear();
                        player.Start_PlayerMenu();
                        break;
                }
            }

            
        }


        public void HutView()
        {
            
            Console.WriteLine("       ^       \n" +
                              "      / \\     \n" +
                              "     /   \\    \n" +
                              "    /_____\\   \n" +
                              "   /|     |\\  \n" +
                              "  / |     | \\ \n" +
                              " /  |     |  \\ \n" +
                              "/___|_____|___\\ \n" +
                              "|  _|_____|_  |  \n" +
                              "| |         | |  \n" +
                              "| |   ___   | |  \n" +
                              "| |  |   |  | |  \n" +
                              "|_|__|___|__|_|");
        }
    }
}
