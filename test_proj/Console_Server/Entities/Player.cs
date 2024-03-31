using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Player : IUnit, IEntity
    {
        int positionX, positionY;
        Map map;
        string icon;
        Walkable isWalkable;

        public string Icon { get => icon; init => icon = value; }
        public Walkable IsWalkable { get => isWalkable; init => isWalkable = value; }
        public int PositionX { get => positionX; private set => positionX = value; }
        public int PositionY { get => positionY; private set => positionY = value; }

        public Player(int positionX, int positionY, ref Map map, string icon, Walkable isWalkable)
        {
            PositionX = positionX;
            PositionY = positionY;
            this.map = map;
            Icon = icon;
            IsWalkable = isWalkable;
            map.InitPlayer(this, positionX, positionY);
        }

        public void Move(MoveDirection moveDirection)
        {
            int nextX = 0, nextY = 0;
            switch(moveDirection)
            {
                case MoveDirection.Up:
                    nextX = PositionX - 1;
                    nextY = PositionY;
                    break;
                case MoveDirection.Down:
                    nextX = PositionX + 1;
                    nextY = PositionY;
                    break;
                case MoveDirection.Right:
                    nextX = PositionX;
                    nextY = PositionY + 1;
                    break;
                case MoveDirection.Left:
                    nextX = PositionX;
                    nextY = PositionY - 1;
                    break;
                default:
                    break;
            }
            if (map.ArrangeUnit(PositionX, PositionY, nextX, nextY))
            {
                PositionX = nextX;
                PositionY = nextY;
            }
        }
    }
}
