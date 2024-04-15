
using Survival_ConsoleGame.Destinations;
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
        //Hut destination_HUT = new Hut();
        Forest destination_FOREST;
        Mountains destination_MOUNTAINS = new Mountains();
        //Needs Refactoring
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
            Console.WriteLine("Stats:");
            Console.WriteLine("* Health: " + HP);
            Console.WriteLine("* Armour: " + defense);
            Console.WriteLine("* Level: " + Level);
            Console.WriteLine("* XP: " + XP);
            Console.WriteLine("_____________________");
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

        public void Start_PlayerMenu()
        {
            Console.WriteLine("Tip: So , here are your options or freedom for what you can do or where to go");

            Console.WriteLine("~1.Your Hut");
            Console.WriteLine("~2.Forest");
            Console.WriteLine("~3.Mountains");
            Console.WriteLine("~4.City");
            Console.WriteLine("~5.Player");


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
                    destination_FOREST = new Forest(engine);
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
