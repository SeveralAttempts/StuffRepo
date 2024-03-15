using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPract
{
    interface IUnit
    {
        void DealDamage(IUnit damageConsumer);
        void TakeDamage(IUnit damageDealer);
        
    }
}
