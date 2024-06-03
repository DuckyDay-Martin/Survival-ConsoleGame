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
                [6] = "Meat",
                [7] = "Water",
                //Craftable items
                [8] = "Knife",
                [9] = "Axe",
                [10] = "Lighter",
                [11] = "Rope",
                [12] = "Pickaxe"
            };
                      
        }

        public bool HasItem(int item)
        {           
           return inventory.Contains(item);
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

            //itemIndexer[item] is giving me the name of the value this item is associated with
            var groupedItems = inventory
                               .GroupBy(item => itemIndexer[item])
                               .Select(g => new { Name = g.Key, Count = g.Count() });

            foreach (var item in groupedItems)
            {
                Console.WriteLine($"|{item.Count}| {item.Name}");
            }
        }
    }
}
