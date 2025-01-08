using System;

namespace TurnBasedBattle
{
    internal class BattleManager
    {
        private Unit player;
        private Unit enemy;
        private Inventory inventory;
        private Skill fireball = new Skill("Fireball", 20, "Burn");
        private Skill shieldBash = new Skill("Shield Bash", 15, "Stun");
        private Random random = new Random();

        public BattleManager(Unit player, Unit enemy, Inventory inventory)
        {
            this.player = player;
            this.enemy = enemy;
            this.inventory = inventory;
        }

        public void StartBattle()
        {
            while (!player.IsDead && !enemy.IsDead)
            {
                Console.WriteLine($"\n{player.UnitName} HP: {player.Hp} | {enemy.UnitName} HP: {enemy.Hp}");
                Console.WriteLine("Player's turn! Choose an action:\n1. Attack\n2. Heal\n3. Use Skill\n4. Use Item");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    player.Attack(enemy);
                }
                else if (choice == "2")
                {
                    player.Heal();
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Choose a skill: 1. Fireball  2. Shield Bash");
                    string skillChoice = Console.ReadLine();
                    if (skillChoice == "1") fireball.Use(player, enemy);
                    else if (skillChoice == "2") shieldBash.Use(player, enemy);
                }
                else if (choice == "4")
                {
                    inventory.ShowInventory();
                    Console.WriteLine("Enter the item name to use:");
                    string item = Console.ReadLine();
                    inventory.UseItem(item, player);
                }

                if (enemy.IsDead) break;

                Console.WriteLine("\nEnemy's turn!");
                if (enemy.StatusEffect == "Stun")
                {
                    Console.WriteLine($"{enemy.UnitName} is stunned and skips their turn!");
                    enemy.ClearStatusEffect();
                }
                else
                {
                    int enemyAction = random.Next(0, 2);
                    if (enemyAction == 0) enemy.Attack(player);
                    else enemy.Heal();
                }
            }

            Console.WriteLine(player.IsDead ? "Game Over! You have been defeated." : "Victory! You defeated the enemy.");
        }
    }
}
