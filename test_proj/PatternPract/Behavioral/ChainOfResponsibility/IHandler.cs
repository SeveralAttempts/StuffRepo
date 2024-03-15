using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPract
{
    interface IKeyHandler
    {
        IKeyHandler Next { set; }
        void HandleKey(ConsoleKeyInfo key);
    }
}
