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
            Engine engine = new Engine();
            _Player player = new _Player();

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
