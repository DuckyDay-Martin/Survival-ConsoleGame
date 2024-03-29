using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survival_ConsoleGame.Destinations
{
    internal class Hut : Player
    {
        public void Destination_HutMenu()
        {            
           Player player = new Player();

            Console.WriteLine("Tip: So, here is your house ,where you can rest ,craft and eat");
            Console.WriteLine();
            Console.WriteLine("~1.Bed");
            Console.WriteLine("~2.Oven");
            Console.WriteLine("~3.Poution Table");
            Console.WriteLine("~4.Crafting Table");

            Console.WriteLine();
            Console.WriteLine(">");
            int n = int.Parse(Console.ReadLine());

          
            switch (n) 
            {

                case 1:
                   // player.Player_EnergySleep();
                    break;

            }
        }

    }
}
