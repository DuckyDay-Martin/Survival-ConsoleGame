using Survival_ConsoleGame.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Net.Quic;

namespace Survival_ConsoleGame
{
    internal class Player_QuestLog
    {
        public PlayerInventory inventory;
        public _Player player;

        public string questDescription { get; set; }
        public int questItemNeededID { get; set; }
        public int questItemNeededCount { get; set; }
        public int questRewardGold { get; set; }

        public bool isCompleted { get; set; } = false;
        public Player_QuestLog(PlayerInventory inventory, _Player playerRef,string questDescription, int questItemNeededID, int questItemNeededCount, int questRewardGold)
        { 
            this.inventory = inventory;
            this.player = playerRef;

            this.questDescription = questDescription;
            this.questItemNeededID = questItemNeededID;
            this.questItemNeededCount = questItemNeededCount;
            this.questRewardGold = questRewardGold;
        }
        public void Player_QuestLogView(PlayerInventory inventory)
        {
            //The quest will be updateing when is acomplished 
            //So we can keep it simple on the screen constantly there will be 3 Quests at the same time
            //After the quest is done the bool flag will turn True and this way the Quest won't be displayed again

            //We need to keep count on the quests after they are acomplished so we can change the Quest Log afterwords           
            
            

        }
        public void CheckIfQuestIsCompleted(PlayerInventory inventory, int questCount)
        {
            if (!isCompleted)
            {
                if (inventory.CountItems(questItemNeededID) < questItemNeededCount)
                {
                    Console.WriteLine($"{questDescription} +{questRewardGold} Gold");
                    isCompleted = false;
                }
                else
                {
                    Console.WriteLine($"Well Done! Here is your {questRewardGold} Gold!");
                    isCompleted = true;
                    questCount++;
                }
            }
            else
            {
                Console.WriteLine("Well Done!");
            }
        }


    }
}
