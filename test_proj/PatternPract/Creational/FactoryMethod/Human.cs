using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPract
{
    class Human : IUnit
    {
        private int damage;
        private int health;

        public Human()
        {
            damage = 0;
            health = 0;
        }

        public Human(int damage, int health) : this()
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
