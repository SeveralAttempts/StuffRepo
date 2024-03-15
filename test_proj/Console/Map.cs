using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Map
    {
        string[ , ] map;
        
        public Map(int area)
        {
            map = new string[area, area];

            for (int i = 0; i < area; i++)
            {
                for (int j = 0; j < area; j++)
                {
                    if (i == 0 || i == area - 1)
                    {
                        map[j, i] = "|";
                    }
                    if (j == 0 || j == area - 1)
                    {
                        map[j, i] = "_";
                    }
                    else
                        map[j, i] = " ";
                }
            }
        }

        public void Show()
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
