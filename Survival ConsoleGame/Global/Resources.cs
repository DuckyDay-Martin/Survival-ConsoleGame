using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survival_ConsoleGame.Global
{
    internal class Resources
    {
        public void AvailableResources(Dictionary<int, string> availableResources)
        {
           
            availableResources.Add(1, "Wood");
            availableResources.Add(2, "Iron");
            availableResources.Add(3, "Grass");
            availableResources.Add(4, "Stone");
            availableResources.Add(5, "Meat");

        }


    }
}
