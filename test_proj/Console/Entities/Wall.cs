using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Wall : AEntity
    {
        public Wall(string icon, Walkable isWalkable) : base(icon, isWalkable)
        {
        }
    }
}
