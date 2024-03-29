using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Camera
    {
        int radius;

        public Camera(int radius)
        {
            this.radius = radius;
        }

        public void Show(Map map,Player player)
        {
            List<List<Stack<IEntity>>> m = map.GetMap();

            for (int i = player.PositionX - radius; i < player.PositionX + radius; i++)
            {
                for (int j = player.PositionY - radius; j < player.PositionY + radius; j++)
                { 
                    Console.Write(m?.ElementAtOrDefault(j)?.ElementAtOrDefault(i)?.Peek().Icon);
                }
                Console.WriteLine();
            }
        }
    }
}
