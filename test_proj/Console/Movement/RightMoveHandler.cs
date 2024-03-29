using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class RightMoveHandler : AMoveHandler
    {
        public RightMoveHandler() : base()
        {

        }

        public override MoveDirection HandleKey(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.RightArrow)
            {
                return MoveDirection.Right;
            }
            return next is not null ? next.HandleKey(key) : MoveDirection.Stay;
        }
    }
}
