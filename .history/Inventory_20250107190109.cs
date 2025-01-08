using System;
using System.Collections.Generic;

namespace TurnBasedBattle
{
    internal class Inventory
    {
        private Dictionary<string, int> items = new Dictionary<string, int>();

        public void AddItem(string itemName, int count)
        {
            if (items.ContainsKey(itemName))
                items[itemName] += count;
            else
                items[itemName] = count;
        }

        public bool UseItem(string itemName, Unit target)
        {
            if (items.ContainsKey(itemName) && items[itemName] > 0)
            {
                items[itemName]--;
                if (itemName == "Health Potion")
                {
                    target.Heal();
                }
                Console.WriteLine($"{target.UnitName} used {itemName}!");
                return true;
            }
            else
            {
                Console.WriteLine($"No {itemName} available!");
                return false;
            }
        }

        public void ShowInventory()
        {
            Console.WriteLine("Inventory:");
            foreach (var item in items)
                Console.WriteLine($"- {item.Key}: {item.Value}");
        }
    }
}
