using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtualization
{
    class Person
    {
        protected string name;

        public string Name
        {
            get
            {
                Console.WriteLine("person get");
                return name;
            }
            set
            {
                name = value;
                Console.WriteLine("person set");
            }
        }

        public Person(string name)
        {
            this.name = name;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Person {name}");
        }
    }
}
