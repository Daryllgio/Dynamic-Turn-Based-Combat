using System;
using System.Collections.Generic;

namespace Turn_Based_Battle
{
    internal class Inventory
    {
        private Dictionary<string, int> items = new Dictionary<string, int>();

        public void AddItem(string itemName, int count)
        {
            if (items.ContainsKey(itemName))
            {
                items[itemName] += count;
            }
            else
            {
                items[itemName] = count;
            }
        }

        public bool UseItem(string itemName, Unit unit)
        {
            if (items.ContainsKey(itemName) && items[itemName] > 0)
            {
                items[itemName]--;
                if (itemName == "Health Potion")
                {
                    unit.Heal();
                    Console.WriteLine($"{unit.UnitName} used a Health Potion!");
                }
                return true;
            }
            else
            {
                Console.WriteLine("You don't have any " + itemName + " left!");
                return false;
            }
        }

        public void ShowInventory()
        {
            Console.WriteLine("Inventory:");
            foreach (var item in items)
            {
                Console.WriteLine($"- {item.Key}: {item.Value}");
            }
        }
    }
}
