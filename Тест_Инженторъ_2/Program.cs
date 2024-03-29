using System;
using System.Linq;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace Test_Inventory_2
{
    class Program
    {
        public static void Main(string[] args)
        {

            Dictionary<int, string> availableResources = new Dictionary<int, string>();
            Resources(availableResources);

            List<int> inventory = new List<int>();

            Hunt(inventory);
            CheckInventory(availableResources, inventory);




        }

        public static void Hunt(List<int> inventory)
        {
            inventory.Add(1);
            inventory.Add(3);
            inventory.Add(2);
            inventory.Add(2);
        }

        public static void Resources(Dictionary<int, string> inventory) 
        {
            inventory.Add(1, "Wood");
            inventory.Add(2, "Iron");
            inventory.Add(3, "Plastic");
        }
        public static void CheckInventory(Dictionary<int, string> availableResources, List<int> inventory)
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
    }
}