using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survival_ConsoleGame.Destinations
{
    internal class Mountains
    {
        public void Destination_MountainsMenu()
        {

            Console.WriteLine("Tip: In those cold mountains you can try to get some resources but you need to be strong because it's dangerouse");
            Console.WriteLine();
            Console.WriteLine("~1.Mine (+Iron,+Rocks, -energy)");
            Console.WriteLine("~2.Collect Water (+Water)");
            Console.WriteLine("~3.Hunt Wolfs (+++Meat, -Health, --Energy)");

            Console.WriteLine();
            Console.WriteLine(">");
            int n = int.Parse(Console.ReadLine());
        }

    }
}
