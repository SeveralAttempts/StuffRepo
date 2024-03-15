using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPract
{
    class ElfSpawner : ISpawner
    {
        public IUnit SpawnUnit()
        {
            return new Elf();
        }
    }
}
