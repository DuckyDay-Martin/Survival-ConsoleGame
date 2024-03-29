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
        public void Hut_CraftinTable()
        {           
            Console.WriteLine("1.Knife - (1)Wood / (1)Rock / (1)Rope");
            Console.WriteLine("2.Axe - (2)Wood / (1)Rock / (2)Rope");
            Console.WriteLine("3.Lighter - (1)Plastic / (1)Rock");
            Console.WriteLine("4.Rope - (5)Grass");
            Console.WriteLine("5.Pickaxe - (2)Wood / (2)Rock / (2)Rope");
            Console.WriteLine("6.Water Bottle - (2)Plastic");

            Console.WriteLine();
            Console.WriteLine("> ");
            int n = int.Parse(Console.ReadLine());

        }

    }
}
