using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survival_ConsoleGame.Player
{
    internal class PlayerInventory
    {
        private List<int> inventory;
        public PlayerInventory()
        { 
            inventory = new List<int>();    
        }

        
        
        public void Add_ItemToInventory(int itemID, int numberOfItemsBeingAdded)
        {
            for (int i = 0; i < numberOfItemsBeingAdded; i++)
            { 
                 inventory.Add(itemID);
            }               
        }

        public void Check_PlayerInventory(List<int> inventory, Dictionary<int, string> availableResources)
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
