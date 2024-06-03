
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
        Mountains destination_MOUNTAINS;
        PlayerInventory playerInventory;
        Hut destination_HUT;

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
            if (currentEnergy > maxEnergy)
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
            if (currentHealth > maxHealth) 
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

       //Menu
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
            }
        }
    }
}
