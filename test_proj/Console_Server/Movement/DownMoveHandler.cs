using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class DownMoveHandler : AMoveHandler
    {
        public DownMoveHandler() : base()
        {
            
        }

        public override MoveDirection HandleKey(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.DownArrow)
            {
                return MoveDirection.Down;
            }
            return next is not null ? next.HandleKey(key) : MoveDirection.Stay;
        }
    }
}
