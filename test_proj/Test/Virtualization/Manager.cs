using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtualization
{
    class Manager : Employee
    {
        protected string post;

        public Manager(string name, string company, string post) : base(name, company)
        {
            this.post = post;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Post {post}");
        }
    }
}
