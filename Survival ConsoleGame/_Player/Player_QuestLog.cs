using Survival_ConsoleGame.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Survival_ConsoleGame
{
    internal class Player_QuestLog
    {
        public PlayerInventory inventory;
        public _Player player;

        public Player_QuestLog(PlayerInventory inventory, _Player playerRef)
        { 
            this.inventory = inventory;
            this.player = playerRef;
        }
        public void Player_QuestLogView(PlayerInventory inventory)
        {
            Console.WriteLine("~Quest Log~");          
            Console.WriteLine("1.Gather 15 Wood(+10 Gold)");
            Console.WriteLine("2.Gather 10 Rocks(+15 Gold)");
            Console.WriteLine("3.Gather 5 Meat(+6 Gold)");

            
        }

    }
}
