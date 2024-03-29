using Survival_ConsoleGame.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survival_ConsoleGame
{
    internal class Player
    {
        public string nickname;

        private int hp = 100;
        public int defense = 100;
        public int attack = 10;
        public int xp = 0;
        public int lvl = 1;
        public int energy = 100;

        public int HP
        {
            get { return hp; }
            set { hp = value; }
        }

        public int Defense
        {
            get { return defense; }
            set { defense = value; }
        }

        public int Attack
        {
            get { return attack; }
            set { attack = value; }
        }
        
        public int XP
        {
            get { return xp; }
            set { hp = value; }
        }

        public int Level
        {
            get { return lvl; }
            set { lvl = value; }
        }
        
        public int Energy
        {
            get { return energy; }
            set { energy = value; }
        }

        public void Player_PlayerStats()
        {
            Console.WriteLine("_____________________");
            Console.WriteLine(nickname);
            Console.WriteLine("Stats:");
            Console.WriteLine("* Health: " + HP);
            Console.WriteLine("* Armour: " + defense);
            Console.WriteLine("* Level: " + Level);
            Console.WriteLine("* XP: " + XP);
            Console.WriteLine("_____________________");
        }
        
        public void Player_Inventory(List<int> inventory, Dictionary<int, string> availableResources)
        {
            string checkedItem;
            foreach (int item in inventory) 
            {
                if (inventory.Contains(item))
                {
                    checkedItem = availableResources.GetValueOrDefault(item);
                    Console.WriteLine(checkedItem);
                }           
            }
        }

        

        //On Sleep regeining some energy
        public int Player_EnergySleep(int currentEnergy)
        {
            int onSleepRegain = 50;

            int regainedEnergy = onSleepRegain + currentEnergy;

            if (regainedEnergy > 100)
            {
                regainedEnergy = 100;
                return regainedEnergy;
            }
            else
            {
                return regainedEnergy;
            }
        }

        //On Sleep regeining some health
        public int Player_HealthSleep(int currentHealth)
        {
            int onSleepRegain = 35;

            int regainedHealth = onSleepRegain + currentHealth;

            if (regainedHealth > 100)
            {
                regainedHealth = 100;
                return regainedHealth;
            }
            else
            {
                return regainedHealth;
            }
        }


    }
}
