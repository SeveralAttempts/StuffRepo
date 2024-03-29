using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class LeftMoveHandler : AMoveHandler
    {
        public LeftMoveHandler() : base()
        {

        }

        public override MoveDirection HandleKey(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.LeftArrow)
            {
                return MoveDirection.Left;
            }
            return next is not null ? next.HandleKey(key) : MoveDirection.Stay;
        }
    }
}
