using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPract
{
    abstract class AHandler : IKeyHandler
    {
        protected IKeyHandler next;

        protected AHandler()
        {
            next = null;
        }

        public IKeyHandler Next
        {
            set
            {
                next = value;
            }
        }

        public abstract void HandleKey(ConsoleKeyInfo key);
    }
}
