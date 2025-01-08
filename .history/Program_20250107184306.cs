using Turn_Based_Battle;

Unit player = new Unit(100, 20, 12, "Player");
Unit enemy = new Unit(75, 10, 7, "Enemy Mage");

Console.WriteLine(player.unitName + " HP = " + player.Hp + ". " + enemy.unitName + " HP = " + enemy.Hp);
Console.WriteLine("Player turn! What will you do ? (press 'a' to attack the enemy or 'h' to heal yourself)");
string choice = Console.ReadLine();

if (choice == "a"){
    player.Attack(enemy);
} else {
    player.Heal();
}


Console.WriteLine(player.unitName + " HP = " + player.Hp + ". " + enemy.unitName + " HP = " + enemy.Hp);
