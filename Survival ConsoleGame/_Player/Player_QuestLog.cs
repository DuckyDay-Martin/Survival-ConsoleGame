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
            //The quest will be updateing when is acomplished 
            //So we can keep it simple on the screen constantly there will be 3 Quests at the same time           
            Console.WriteLine("~Quest Log~");
            if (inventory.CountItems(1) < 15)
            {
                Console.WriteLine("1.Gather 15 Wood(+10 Gold)");
            }
            else 
            {
                //Add Gold
                //Change the quest
            }

            if (inventory.CountItems(2) < 10)
            {
                Console.WriteLine("2.Gather 10 Rocks(+15 Gold)");
            }
            else 
            {
                //Add Gold
                //Change the quest
            }

            Console.WriteLine("3.Gather 5 Meat(+6 Gold)");

            
        }

    }
}
