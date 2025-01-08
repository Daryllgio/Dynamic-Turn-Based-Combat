using Turn_Based_Battle;

Unit player = new Unit(100, 20, 12, "Player");
Unit enemy = new Unit(75, 10, 7, "Enemy Mage");
Random random = new Random();

while (!player.IsDead && !enemy.IsDead)
{
    Console.WriteLine(player.UnitName + " HP = " + player.Hp + ". " + enemy.UnitName + " HP = " + enemy.Hp);
    Console.WriteLine("Player turn! What will you do? (press 'a' to attack the enemy or 'h' to heal yourself)");
    string choice = Console.ReadLine();

    if (choice == "a")
    {
        player.Attack(enemy);
    }
    else if (choice == "h")
    {
        player.Heal();
    }
    else
    {
        Console.WriteLine("Invalid choice! Turn skipped.");
    }

    if (player.IsDead || enemy.IsDead)
    {
        break;
    }

    Console.WriteLine(player.UnitName + " HP = " + player.Hp + ". " + enemy.UnitName + " HP = " + enemy.Hp);
    Console.WriteLine("Enemy Turn");

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

if (player.IsDead)
{
    Console.WriteLine(player.UnitName + " has been defeated. Game over!");
}
else if (enemy.IsDead)
{
    Console.WriteLine(enemy.UnitName + " has been defeated. You win!");
}
