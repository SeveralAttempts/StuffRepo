using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtualization
{
    class Employee : Person
    {
        string company;

        public Employee(string name, string company) : base(name)
        {
            this.company = company;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"company {company}");
        }

        public new string Name
        {
            get
            {
                Console.WriteLine("emp get");
                return base.Name;
            }
            set
            {
                base.Name = value;
                Console.WriteLine("emp set");
            }
        }
    }
}
