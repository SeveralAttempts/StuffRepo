using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Engine
    {
        Player player;
        Map map;
        ConsoleKeyInfo cki;
        UpMoveHandler upMove;
        DownMoveHandler downMove;
        RightMoveHandler rightMove;
        LeftMoveHandler leftMove;
        Camera camera;

        public Engine(int area)
        {
            upMove = new();
            downMove = new();
            rightMove = new();
            leftMove = new();
            upMove.Next = downMove;
            downMove.Next = rightMove;
            rightMove.Next = leftMove;
            map = new(area);
            player = new(Convert.ToInt32(area / 2), Convert.ToInt32(area / 2), ref map, "@", Walkable.False);
            camera = new Camera(5);
        }

        public void Start()
        {
            while (true)
            {
                camera.Show(map, player);
                cki = Console.ReadKey(false);
                if (cki.Key == ConsoleKey.Escape)
                {
                    break;
                }
                else if(cki.Key == ConsoleKey.M)
                {
                    map.ShowEntireMap();
                    Console.ReadKey();
                }

                player.Move(upMove.HandleKey(cki));
                Console.Clear();
            }
        }
    }
}
