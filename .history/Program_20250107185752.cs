using Turn_Based_Battle;

Unit player = new Unit(100, 20, 10, "Player");
Unit enemy = new Unit(80, 15, 8, "Enemy Orc");
Inventory inventory = new Inventory();
inventory.AddItem("Health Potion", 3);

BattleManager battleManager = new BattleManager(player, enemy, inventory);
battleManager.StartBattle();
