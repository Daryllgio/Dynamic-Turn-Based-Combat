using Turn_Based_Battle_System;

Unit player = new Unit(100, 20, 12, "Player");
Unit enemy = new Unit(75, 10, 7, "Enemy Mage");

Console.WriteLine(player.unitName + " HP = " + player.Hp + ". " + enemy.unitName + " HP = " + enemy.Hp);
Console.WriteLine("Player turn! What will you do ? (press 'a' to attack )");
string choice = Console.ReadLine();

if (choice == "a")
    player.Attack(enemy);

Console.WriteLine(player.unitName + " HP = " + player.Hp + ". " + enemy.unitName + " HP = " + enemy.Hp);
