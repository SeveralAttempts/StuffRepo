using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_proj.Test
{
    public class Animal : Unit
    {
        string howl;
        public string Howl { get { return howl; } }
        public Animal(int a, string howl) : base(a)
        {
            this.howl = howl;
            Console.WriteLine("ctor animal");
        }

        public void ChangeValue(int nVal)
        {
            this.a = nVal;
        }
    }
}
