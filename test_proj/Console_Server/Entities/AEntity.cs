using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class AEntity : IEntity
    {
        protected Walkable isWalkable;
        protected string icon;

        public string Icon { get => icon; init => icon = value; }

        public AEntity(string icon, Walkable isWalkable)
        {
            Icon = icon;
            IsWalkable = isWalkable;
        }

        public Walkable IsWalkable { get => isWalkable; init => isWalkable = value; }
    }
}
