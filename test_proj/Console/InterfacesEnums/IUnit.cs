using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    enum MoveDirection
    {
        Up,
        Down,
        Left,
        Right,
        Stay
    }

    //enum Enteraction
    //{
    //    Move,
    //    Stay
    //}

    interface IUnit
    {
        void Move(MoveDirection moveDirection);
        //void Enteract(Enteraction enteraction);
    }
}
