using System;

namespace Test_Inventory
{
    class Program
    { 
        public static void Main(string[] args) 
        {
            
            Dictionary<int, string> inventory = new Dictionary<int, string>();
            Hunt(inventory);
            CheckInventory(inventory);




        }

        public static void Hunt(Dictionary<int, string> inventory)
        {
            inventory.Add(1 , "Meat");
            
        }

        public static void CheckInventory(Dictionary<int, string> inventory)
        {
            int key = 1;
            var checkInventory = inventory.Where(x => x.Key == key).FirstOrDefault();
            Console.WriteLine(checkInventory);
        }
    }
}