using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survival_ConsoleGame.Player
{
    internal class PlayerInventory
    {
        private List<int> inventory = new List<int>();
        private Dictionary<int, string> itemIndexer = new Dictionary<int, string>();

        public PlayerInventory()
        {
            inventory = new List<int>();
            itemIndexer = new()
            {
                [1] = "Wood",
                [2] = "Rock",
                [3] = "Plastic",
                [4] = "Iron",
                [5] = "Grass",
                [6] = "Meat"
            };

        }

        public void AddItem(int item,int count)
        {
            for (int i = 0; i < count; i++) 
            {
                inventory.Add(item);
            }
        }
        
        public void RemoveItem(int item) 
        {
            inventory.Remove(item);
        }

        public void DisplayItems()
        {
            Console.WriteLine("Inventory: ");
            string itemName;

            foreach (int item in inventory)
            {
                if (itemIndexer.ContainsKey(item))
                {
                    itemName = (string)itemIndexer[item];
                    Console.WriteLine(" - " + itemName);
                }
            }
        }
    }
}
