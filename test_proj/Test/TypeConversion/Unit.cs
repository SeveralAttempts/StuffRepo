using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_proj.Test
{
    public class Unit
    {
        protected int a;

        public int A { get { return a; } }

        public Unit(int a)
        {
            this.a = a;
            Console.WriteLine("ctor unit");
        }
    }
}
