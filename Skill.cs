namespace TurnBasedBattle
{
    internal class Skill
    {
        public string Name { get; }
        public int Power { get; }
        public string Effect { get; }

        public Skill(string name, int power, string effect = "None")
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
                target.ApplyStatusEffect("Burn");
                Console.WriteLine($"{target.UnitName} will take additional damage over time!");
            }
            else if (Effect == "Stun")
            {
                target.ApplyStatusEffect("Stun");
                Console.WriteLine($"{target.UnitName} is stunned and will skip their next turn!");
            }
        }
    }
}
