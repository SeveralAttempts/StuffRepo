using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Records
{
    record Rec
    {
        private readonly List<string> _test;
        public List<string> Test
        {
            get { return _test; }
        }

        public Rec(List<string> test)
        {
            _test = test;
        }
    }
}