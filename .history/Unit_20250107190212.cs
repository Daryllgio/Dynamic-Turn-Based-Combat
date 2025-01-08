using System;

namespace TurnBasedBattle
{
    internal class Unit
    {
        private int currentHP;
        private int maxHP;
        private int attackPower;
        private int healPower;
        private string unitName;
        private string statusEffect; // Burn, Stun, etc.
        private Random random = new Random();

        public int Hp => currentHP;
        public string UnitName => unitName;
        public bool IsDead => currentHP <= 0;
        public string StatusEffect => statusEffect;

        public Unit(int maxHP, int attackPower, int healPower, string unitName)
        {
            this.maxHP = maxHP;
            this.currentHP = maxHP;
            this.attackPower = attackPower;
            this.healPower = healPower;
            this.unitName = unitName;
            this.statusEffect = "None"; // Default status
        }

        public void Attack(Unit unitToAttack)
        {
            double rng = random.NextDouble();
            rng = rng / 2 + 0.75f;
            int damage = (int)(attackPower * rng);
            unitToAttack.TakeDamage(damage);
            Console.WriteLine($"{unitName} attacks {unitToAttack.UnitName} for {damage} damage!");
        }

        public void TakeDamage(int damage)
        {
            currentHP -= damage;
            if (IsDead)
            {
                Console.WriteLine($"{unitName} has been defeated!");
            }
        }

        public void Heal()
        {
            double rng = random.NextDouble();
            rng = rng / 2 + 0.75f;
            int heal = (int)(healPower * rng);
            currentHP = Math.Min(currentHP + heal, maxHP);
            Console.WriteLine($"{unitName} heals for {heal} HP.");
        }

        public void ApplyStatusEffect(string effect)
        {
            statusEffect = effect;
            Console.WriteLine($"{unitName} is now affected by {effect}!");
        }

        public void ClearStatusEffect()
        {
            statusEffect = "None";
        }
    }
}
