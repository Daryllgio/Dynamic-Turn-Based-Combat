using TurnBasedBattle;

Unit player = new Unit(100, 20, 10, "Hero");
Inventory inventory = new Inventory();
inventory.AddItem("Health Potion", 3);

CampaignManager campaign = new CampaignManager();
campaign.StartCampaign(player, inventory);
