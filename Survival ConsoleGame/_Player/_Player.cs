﻿
using Survival_ConsoleGame.Destinations;
using Survival_ConsoleGame.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survival_ConsoleGame
{
    internal class _Player
    {

        Player_QuestLog questLog;
        Forest destination_FOREST;
        Mountains destination_MOUNTAINS;
        PlayerInventory playerInventory;
        Hut destination_HUT;
        List<Player_QuestLog> quests;

        //Player needs energy implemented, the half is done

        private int maxHealth;//Max Health will be 100
        private int currentHealth;

        private int startingXP;//Starting XP will be zero//Will do later in the game...
        private int currentXP;

        private int currentEnergy;
        private int maxEnergy;//Max Energy Will be 100


        public _Player(PlayerInventory inventory, int maxHealth, int startingXP, int maxEnergy)
        {
            playerInventory = inventory;
            destination_FOREST = new Forest(playerInventory, this);
            destination_MOUNTAINS = new Mountains(playerInventory, this);
            destination_HUT = new Hut(playerInventory, this);


            quests = new List<Player_QuestLog>
            {
                //Quest Log _1
                new Player_QuestLog(playerInventory, this, "1.Gather 15 Meat", 6 ,15 ,10),
                new Player_QuestLog(playerInventory, this, "2.Gather 10 Rocks", 2 ,10 ,15),
                new Player_QuestLog(playerInventory, this, "3.Gather 15 Wood", 1 ,15 ,10),
                
                //Quest Log _2
                new Player_QuestLog(playerInventory, this, "1.Craft 1 Knife", 8 ,1 ,10),
                new Player_QuestLog(playerInventory, this, "2.Craft 4 Rope", 11 ,4 ,15),
                new Player_QuestLog(playerInventory, this, "3.Craft 1 Pickaxe", 12 ,1 ,10),
            };

            this.maxHealth = maxHealth;
            this.currentHealth = maxHealth;

            this.startingXP = startingXP;
            this.currentXP = startingXP;

            this.maxEnergy = maxEnergy;
            this.currentEnergy = maxEnergy;
        }

        //Energy
        public void Player_EnergyDrained(int energyAmount)
        {
            currentEnergy -= energyAmount;
        }

        public void Player_EnergyReceived(int energyAmount)
        {
            int energyAfterRegen = currentEnergy + energyAmount;
            if (energyAfterRegen >= 100)
            {
                currentEnergy = 100;
            }
            else
            {
                currentEnergy += energyAmount;
            }

        }

        public void Player_UpdateEnergy(int energyDrained, int energyReceived)
        {
            Player_EnergyDrained(energyDrained);
            Player_EnergyReceived(energyReceived);
        }

        public int Player_DisplayEnergy()
        {
            if (currentEnergy < 0)
            {
                Console.Clear();
                Player_UpdateHealth(15, 0);
                Console.WriteLine("--> You are getting tired...a lot(-15HP)\n--> Try to get back home and rest for a while!");
                Console.WriteLine("Health: " + Player_DisplayHealth());
                currentEnergy = 0;
            }
            return currentEnergy;
        }

        //Health
        public void Player_TakeDamage(int damageTaken)
        {           
                currentHealth -= damageTaken;          
        }

        public void Player_Heal(int healAmount)
        { 
            int healthAfterHealing = currentHealth + healAmount;
            if (healthAfterHealing >= 100) 
            {
                currentHealth = 100;
            }
            else
            {
                currentHealth += healAmount;
            }
        }

        public void Player_UpdateHealth(int damageAmount, int healAmount)
        {
            Player_TakeDamage(damageAmount);
            Player_Heal(healAmount);
        }
        public int Player_DisplayHealth()
        {
            if (currentHealth < 0)
            {
                Console.Clear();
                currentHealth = 0;
                Console.WriteLine("Game Over!\n You couldn't make it this time...");
            }
            return currentHealth;
        }

        //Use item
        public void Player_UseItem(PlayerInventory inventory)
        {
            Console.WriteLine();
            Console.WriteLine("Which item do you want to use?");
            Console.WriteLine();
            inventory.DisplayItems();
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    //To-DO
                    break;
            }
        }
        //QuestLog Helper
        public void QuestLogHelper(PlayerInventory inventory)
        {
            int questCount = 0;

            while (questCount < 6) 
            {
                if (questCount < 3)
                {
                    quests[0].CheckIfQuestIsCompleted(inventory, questCount);
                    quests[1].CheckIfQuestIsCompleted(inventory, questCount);
                    quests[2].CheckIfQuestIsCompleted(inventory, questCount);
                    break;
                }
                else
                {
                    quests[3].CheckIfQuestIsCompleted(inventory, questCount);
                    quests[4].CheckIfQuestIsCompleted(inventory, questCount);
                    quests[5].CheckIfQuestIsCompleted(inventory, questCount);
                    break;
                }

            }

        }


       //Menu
        public void Start_PlayerMenu()
        {          
            Console.WriteLine("Tip: So, here are your options or freedom for what you can do or where to go!\n" +
                              "Also your ~Quest Log~ will be everywhere with you so you can keep track of your progress!\n");           
            Console.WriteLine("~1. Your Hut");
            Console.WriteLine("~2. Forest");
            Console.WriteLine("~3. Mountains");
            Console.WriteLine("~4. City");
            Console.WriteLine("~5. Quest Log");

            Console.WriteLine();
            Console.WriteLine("> ");
            int n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.Clear();
                    destination_HUT.Destination_HutMenu();
                    break;

                case 2:
                    Console.Clear();
                    destination_FOREST = new Forest(playerInventory, this); // Corrected variable name
                    destination_FOREST.Destination_ForestMenu();
                    break;

                case 3:
                    Console.Clear();
                    destination_MOUNTAINS.Destination_MountainsMenu();
                    break;

                case 4:
                    Console.Clear();
                    //To-Do City
                    break;

                case 5:
                    Console.Clear();
                    Console.WriteLine("When compleating a task ,you will get rewarded.\n" +
                                      "Go to the Hut for more info!");
                    Console.WriteLine("_____________________________");
                    QuestLogHelper(playerInventory);
                    Console.WriteLine("_____________________________");
                    Console.WriteLine();
                    Start_PlayerMenu();                                  
                    break;
            }
        }
    }
}
