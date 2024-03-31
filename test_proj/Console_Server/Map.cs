using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimplexNoise;

namespace ConsoleTest
{
    class Map
    {

        List<List<Stack<IEntity>>> map;
        int area;
        
        public Map(int area)
        {
            this.area = area;
            map = new List<List<Stack<IEntity>>>(area);
            for (int i = 0; i < map.Capacity; i++)
            {
                map.Add(new List<Stack<IEntity>>(area));
                for (int j = 0; j < map[i].Capacity; j++)
                {
                    map[i].Add(new Stack<IEntity>());
                }
            }
            CubeMapGeneration();
            ShowEntireMap();
            NoiseMapGeneration();
        }

        private void CubeMapGeneration()
        {
            for (int i = 0; i < area; i++)
            {
                for (int j = 0; j < area; j++)
                {
                    if (i == 0 || j == 0 || i == area - 1 || j == area - 1)
                        map[i][j].Push(new Wall("W", Walkable.False));
                    else
                        map[i][j].Push(new Floor(" ", Walkable.True));
                }
            }
        }

        private void RandomMapGeneration()
        {
            var rand = new Random();
            for (int i = 1; i < area - 1; i++)
            {
                for (int j = 1; j < area - 1; j++)
                {
                    if (rand.NextDouble() >= 0.5)
                        map[j][i].Push(new Wall("G", Walkable.False));
                    else
                        map[j][i].Push(new Floor(" ", Walkable.True));
                }
            }
        }

        private void NoiseMapGeneration()
        {
            var m = Noise.Calc2D(area - 1, area - 1, 3f);
            for (int i = 1; i < area - 1; i++)
            {
                for (int j = 1; j < area - 1; j++)
                {
                    if (m[i,j] >= 128)
                        map[j][i].Push(new Wall("G", Walkable.False));
                    else
                        map[j][i].Push(new Floor(" ", Walkable.True));
                }
            }
        }

        public void ShowEntireMap()
        {
            Console.WriteLine();
            for (int i = 1; i < area; i++)
            {
                for (int j = 1; j < area; j++)
                {
                    Console.Write(map[j][i].Peek().Icon);
                }
                Console.WriteLine();
            }
        }

        public void InitPlayer(Player player, int x, int y)
        {
            if (map[y][x].Peek().IsWalkable == Walkable.True)
            {
                map[y][x].Push(player);
            }
        }

        public bool ArrangeUnit(int x, int y, int nextX, int nextY)
        {
            if (map[nextY][nextX].Peek().IsWalkable == Walkable.True)
            {
                map[nextY][nextX].Push(map[y][x].Pop());
                return true;
            }
            return false;
        }

        public List<List<Stack<IEntity>>> GetMap()
        {
            return map;
        }
    }
}
