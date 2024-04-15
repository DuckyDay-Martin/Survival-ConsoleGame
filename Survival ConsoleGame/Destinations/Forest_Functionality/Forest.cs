
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survival_ConsoleGame.Destinations
{
    internal class Forest
    {

        private Engine engine;

        public Forest (Engine engine)
        {
            this.engine = engine;
        }

        public void Destination_ForestMenu()
        {            
            Console.WriteLine("Tip: Here in the forest you can be chill and just get tired a bit but that's all");
            Console.WriteLine();
            Console.WriteLine("~1.Hunt Deers (+Meat(2), -energy(50))");
            Console.WriteLine("~2.Chop Trees (+Wood(2), -energy(40))");
            Console.WriteLine("~3.Collect Grass (+Grass(5), -energy(10))");

            Console.WriteLine();
            Console.WriteLine(">   ");
            int n = int.Parse(Console.ReadLine());

            
            switch (n)
            {
                case 1:
                    engine.Hunt();
                    break;

                case 2:
                    engine.ChopTrees();
                    break;

                case 3:
                    engine.CollectGrass();
                    break;
            }
        }

    }
}
