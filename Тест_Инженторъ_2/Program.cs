using System;
using System.Collections.Generic;

public class InventorySystem
{
    private List<int> inventory;
    private Dictionary<int, string> itemIndexer = new Dictionary<int, string>();

    public InventorySystem()
    {
        inventory = new List<int>();
        itemIndexer = new()
        {
            [1] = "Wood",
            [2] = "Iron",
        };
    }

    public void AddItem(int item)
    {
        inventory.Add(item);
        Console.WriteLine(item + " has been added to the inventory.");
    }

    public void DisplayInventory()
    {
        Console.WriteLine("Inventory:");
        string itemName;
        foreach (int item in inventory)
        { 
          if (itemIndexer.ContainsKey(item))
          {
                itemName = (string)itemIndexer[item];
                Console.WriteLine(itemName);
          }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        InventorySystem inventorySystem = new InventorySystem();
        Forest forest = new Forest();

        Hunt(inventorySystem);
        forest.ChopTrees(inventorySystem);
        // Displaying the inventory
        inventorySystem.AddItem(1);

        inventorySystem.DisplayInventory();
    }

    

    public static void Hunt(InventorySystem inventorySystem)
    {
       
        inventorySystem.AddItem(1);
        inventorySystem.AddItem(2);

        
    }
}

public class Lake
{
    
    public void CollectWater(InventorySystem inventorySystem)
    {
        inventorySystem.AddItem(2);
        Console.WriteLine("WaterActually:)");
    }


}

public class Forest
{
   public void ChopTrees(InventorySystem inventorySystem)
    {
        inventorySystem.AddItem(2);
        inventorySystem.AddItem(2);
    }
}