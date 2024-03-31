using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    enum Walkable
    {
        True,
        False
    }

    interface IEntity
    {
        Walkable IsWalkable { get; init; }
        string Icon { get; }
    }
}
