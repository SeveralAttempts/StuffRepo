using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPract
{
    class CharMove
    {
        UpHandler up = new();
        DownHandler down = new();
        LeftHandler left = new();
        RightHandler right = new();
        ConsoleKeyInfo cki;

        public CharMove()
        {
            up.Next = down;
            down.Next = left;
            left.Next = right;
        }

        public void Move()
        {
            while (true)
            {
                cki = Console.ReadKey(false);

                up.HandleKey(cki);
            }
        }
    }
}
