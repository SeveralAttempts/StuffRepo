using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    interface IMoveHandler
    {
        IMoveHandler Next { set; }
        MoveDirection HandleKey(ConsoleKeyInfo key);
    }
}
