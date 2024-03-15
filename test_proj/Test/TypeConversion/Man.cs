using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_proj.Test
{
    internal class Man : Unit
    {
        public Man(int a) : base(a)
        {
            Console.WriteLine("ctor man");
        }

        public void ChangeValue(int nVal)
        {
            this.a = nVal;
        }
    }
}
