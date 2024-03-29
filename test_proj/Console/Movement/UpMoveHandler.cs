using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class UpMoveHandler : AMoveHandler
    {
        public UpMoveHandler() : base()
        {

        }

        public override MoveDirection HandleKey(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.UpArrow)
            {
                return MoveDirection.Up;
            }
            return next is not null ? next.HandleKey(key) : MoveDirection.Stay;
        }
    }
}
