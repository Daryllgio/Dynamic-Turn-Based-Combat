using System;
using System.Collection.Generic;
using System.linq;
using System.Text;
using System.Threading.Tasks;

namespace Turn_Based_Battle
{
    internal class Unit
    {
        private int currentHP;
        private int maxHP;
        private int attackPower;
        private int healPower;
        private string unitName;
        private Random random = new Random();

        public int Hp { get { return currentHP; } }
        public string UnitName { get { return unitName; } }
        public bool IsDead { get { return currentHP <= 0; } }

        public Unit(int maxHP, int attackPower, int healPower, string unitName)
        {
            this.maxHP = maxHP;
            this.attackPower = attackPower;
            this.healPower = healPower;
            this.unitName = unitName;
        }

        public void Attack(Unit unitToAttack)
        {
            double rng = random.NextDouble();
            rng = rng / 2 + 0.75f;
            int randDamage = (int)(attackPower * rng);
            unitToAttack.TakeDamage(randDamage);
            Console.WriteLine(unitName + " attacks " + unitToAttack.unitName + " and deals " + randDamage + "damage !");
        }

        public void TakeDamage(int damage)
        {
            currentHP -= damage;

            if (IsDead)
            {
                Console.WriteLine(unitName + " has been defeated ");
            }
        }

        public void Heal()
        {
            double rng = random.NextDouble();
            rng = rng / 2 + 0.75f;
            int heal = (int)(healPower * rng);
            currentHP = heal + currentHP > maxHP ? maxHP : currentHP + heal;
            Console.WriteLine(unitName + " heals " + heal);
        }
    }
}






