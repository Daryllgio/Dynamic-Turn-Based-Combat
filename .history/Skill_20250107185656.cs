using System;

namespace Turn_Based_Battle
{
    internal class Skill
    {
        public string Name { get; }
        public int Power { get; }
        public string Effect { get; }

        public Skill(string name, int power, string effect)
        {
            Name = name;
            Power = power;
            Effect = effect;
        }

        public void Use(Unit caster, Unit target)
        {
            Console.WriteLine($"{caster.UnitName} uses {Name} on {target.UnitName}!");
            target.TakeDamage(Power);

            if (Effect == "Burn")
            {
                Console.WriteLine($"{target.UnitName} is burned and will take additional damage over time!");
                target.TakeDamage(5); // Apply burn effect
            }
            else if (Effect == "Stun")
            {
                Console.WriteLine($"{target.UnitName} is stunned and will skip their next turn!");
                // Stun logic can be implemented in BattleManager
            }
        }
    }
}
