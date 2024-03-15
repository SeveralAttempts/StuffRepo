﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPract
{
    class LeftHandler : AHandler
    {
        public LeftHandler() : base()
        {

        }

        public override void HandleKey(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.LeftArrow)
            {
                Console.WriteLine(key.Key.ToString());
            }
            if (next is null)
                return;
            this.next.HandleKey(key);
        }
    }
}
