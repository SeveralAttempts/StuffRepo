using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPract
{
    class UpHandler : AHandler
    {
        public UpHandler() : base()
        {

        }

        public override void HandleKey(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.UpArrow)
            {
                Console.WriteLine(key.Key.ToString());
            }
            if (next is null)
                return;
            next.HandleKey(key);
        }
    }
}
