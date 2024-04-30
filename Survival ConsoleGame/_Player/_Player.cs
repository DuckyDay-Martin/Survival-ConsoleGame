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
        Engine engine = new Engine();
        
        Forest destination_FOREST;
        Mountains destination_MOUNTAINS = new Mountains();
        PlayerInventory playerInventory;

        public _Player(PlayerInventory inventory)
        {
            playerInventory = inventory;
            destination_FOREST = new Forest(playerInventory, this);
        }

        // On Sleep regaining some energy
        public int Player_EnergySleep(int currentEnergy)
        {
            int onSleepRegain = 50;

            int regainedEnergy = onSleepRegain + currentEnergy;

            if (regainedEnergy > 100)
            {
                regainedEnergy = 100;
            }

            return regainedEnergy;
        }

        // On Sleep regaining some health
        public int Player_HealthSleep(int currentHealth)
        {
            int onSleepRegain = 35;

            int regainedHealth = onSleepRegain + currentHealth;

            if (regainedHealth > 100)
            {
                regainedHealth = 100;
            }

            return regainedHealth;
        }

        public void Start_PlayerMenu()
        {          
            Console.WriteLine("Tip: So, here are your options or freedom for what you can do or where to go");

            Console.WriteLine("~1. Your Hut");
            Console.WriteLine("~2. Forest");
            Console.WriteLine("~3. Mountains");
            Console.WriteLine("~4. City");
            Console.WriteLine("~5. Player");

            Console.WriteLine();
            Console.WriteLine("> ");
            int n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.Clear();
                   // destination_HUT.Destination_HutMenu();
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
            }
        }
    }
}
