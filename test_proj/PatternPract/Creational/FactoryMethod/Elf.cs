using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPract
{
    class Elf : IUnit
    {
        private int damage;
        private int health;

        public Elf()
        {
            damage = 0;
            health = 0;
        }

        public Elf(int damage, int health) : this()
        {
            this.damage = damage;
            this.health = health;
        }

        public void DealDamage(IUnit damageConsumer)
        {
            throw new NotImplementedException();
        }

        public void TakeDamage(IUnit damageDealer)
        {
            throw new NotImplementedException();
        }
    }
}
