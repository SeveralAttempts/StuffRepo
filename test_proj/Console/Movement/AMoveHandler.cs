using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    abstract class AMoveHandler : IMoveHandler
    {
        protected IMoveHandler next;

        protected AMoveHandler()
        {
            next = null;
        }

        public IMoveHandler Next
        {
            set
            {
                next = value;
            }
        }

        public abstract MoveDirection HandleKey(ConsoleKeyInfo key);
    }
}
