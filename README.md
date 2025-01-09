Turn-Based Battle Game
A C# console-based turn-based battle simulation game where players take on the role of a hero battling through a campaign of enemies. 
The game combines strategic decision-making, dynamic combat mechanics, and inventory management to deliver an engaging experience.

I) Features

1. Turn-Based Combat

Players and enemies take alternating turns to perform actions like:

 - Attack: Deal damage to the opponent.
 - Heal: Restore health.
 - Use Skills: Employ strategic abilities such as:
 - Fireball: Inflicts burn damage over time.
 - Shield Bash: Stuns the enemy for one turn.
 - Use Items: Leverage items like health potions for survival.

2. Campaign Mode

Progress through battles against a variety of enemies:

 - Goblin: Agile but weak.
 - Orc: Balanced with moderate strength.
 - Dragon: A challenging boss with high damage.
 - Earn rewards like health potions after each victory to prepare for the next challenge.

Complete the campaign by defeating all enemies without losing the hero.

3. Inventory System

 - Maintain and manage a collection of usable items. 
 - Use health potions to heal during battles.
 - Inventory dynamically updates as items are used or earned.

4. Dynamic AI and Status Effects

 - Enemy AI: Decides between attacking or healing based on the battle context. Reacts to status effects like "Burn" or "Stun."
 - Status Effects:
 - Burn: Deals damage over time.
 - Stun: Skips the enemy’s next turn.

II) Gameplay Example

Player's Turn:

Hero HP: 100 | Goblin HP: 70
Choose an action:
1. Attack
2. Heal
3. Use Skill
4. Use Item

Enemy’s Turn:

Goblin attacks Hero for 15 damage!

Victory:

You defeated the Goblin! Prepare for the next battle.

III) Technologies Used

 - C#: Core programming language.
 - .NET Framework: Used for building and running the application.
 - Object-Oriented Programming (OOP):
 - Modular design for units, skills, inventory, and battle management.

IV) Project Structure

 - Unit.cs: Defines player and enemy attributes such as health, attack power, and healing abilities.

 - Skill.cs: Implements skills with special effects like "Burn" and "Stun."

 - Inventory.cs: Manages items like health potions for use during battles.

 - BattleManager.cs: Orchestrates individual battles between the player and enemies.

 - CampaignManager.cs: Oversees campaign progression through multiple battles.

Planned Enhancements

V) Add a graphical user interface (GUI) for better visualization and interactivity.
 - Introduce a leveling system with experience points (XP) and skill upgrades.
 - Add more enemy types, skills, and items for variety.
 - Implement save/load functionality for campaign progress.

Acknowledgments
Developed by Daryll Giovanny Bikak Mbal as a demonstration of C# programming skills and object-oriented design principles.

