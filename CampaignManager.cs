using System;

namespace TurnBasedBattle
{
    internal class CampaignManager
    {
        public void StartCampaign(Unit player, Inventory inventory)
        {
            Unit[] enemies = { new Unit(70, 15, 10, "Goblin"), new Unit(90, 20, 5, "Orc"), new Unit(120, 25, 10, "Dragon") };

            foreach (Unit enemy in enemies)
            {
                Console.WriteLine($"\nA wild {enemy.UnitName} appears!");
                BattleManager battleManager = new BattleManager(player, enemy, inventory);
                battleManager.StartBattle();

                if (player.IsDead)
                {
                    Console.WriteLine("You have been defeated in the campaign!");
                    return;
                }

                Console.WriteLine($"You defeated the {enemy.UnitName}! Prepare for the next battle.");
                inventory.AddItem("Health Potion", 1); // Reward
            }

            Console.WriteLine("Congratulations! You completed the campaign!");
        }
    }
}
