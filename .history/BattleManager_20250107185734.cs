using System;

namespace Turn_Based_Battle
{
    internal class BattleManager
    {
        private Unit player;
        private Unit enemy;
        private Inventory playerInventory;
        private Skill fireball = new Skill("Fireball", 15, "Burn");
        private Skill shieldBash = new Skill("Shield Bash", 10, "Stun");

        public BattleManager(Unit player, Unit enemy, Inventory inventory)
        {
            this.player = player;
            this.enemy = enemy;
            this.playerInventory = inventory;
        }

        public void StartBattle()
        {
            Random random = new Random();
            while (!player.IsDead && !enemy.IsDead)
            {
                Console.WriteLine($"\n{player.UnitName} HP: {player.Hp} | {enemy.UnitName} HP: {enemy.Hp}");
                Console.WriteLine("Player turn! Choose an action:");
                Console.WriteLine("1. Attack\n2. Heal\n3. Use Skill (Fireball or Shield Bash)\n4. Use Item");

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
                    if (skillChoice == "1")
                        fireball.Use(player, enemy);
                    else if (skillChoice == "2")
                        shieldBash.Use(player, enemy);
                    else
                        Console.WriteLine("Invalid skill choice.");
                }
                else if (choice == "4")
                {
                    playerInventory.ShowInventory();
                    Console.WriteLine("Type the name of the item to use:");
                    string itemChoice = Console.ReadLine();
                    playerInventory.UseItem(itemChoice, player);
                }
                else
                {
                    Console.WriteLine("Invalid choice! Turn skipped.");
                }

                if (enemy.IsDead) break;

                Console.WriteLine("\nEnemy's turn!");
                int rand = random.Next(0, 2);
                if (rand == 0)
                {
                    enemy.Attack(player);
                }
                else
                {
                    enemy.Heal();
                }
            }

            Console.WriteLine(player.IsDead
                ? $"{player.UnitName} has been defeated. Game over!"
                : $"{enemy.UnitName} has been defeated. You win!");
        }
    }
}
