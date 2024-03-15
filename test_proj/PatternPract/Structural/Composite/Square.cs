using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPract
{
    class Square : AFigure
    {
        string name;

        public Square(string name) : base()
        {
            this.name = name;
        }

        public override string Display(int deep)
        {
            return "\n" + string.Join("", Enumerable.Repeat("\t", deep)) + this.ToString();
        }

        public override string ToString()
        {
            return name;
        }

        public override string GetFigureType()
        {
            return "Square";
        }
    }
}
