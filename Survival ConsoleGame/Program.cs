using Survival_ConsoleGame.Player;
using System;

namespace Survival_ConsoleGame
{
    class Program
    { 
    
        static void Main(string[] args) 
        {
            Console.WriteLine("1.Start");
            Console.WriteLine("2.Exit");
            int n = int.Parse(Console.ReadLine());
            PlayerInventory playerInventory = new PlayerInventory();
            Engine engine = new Engine();
            _Player player = new _Player(playerInventory, 100, 0, 100);

            switch (n)
            {
                case 1:
                    engine.Start_Tutorial(); 
                    player.Start_PlayerMenu();
                    break;

                    case 2:
                    break;

                default:
                    break;
            }
        }
    
    }
}
