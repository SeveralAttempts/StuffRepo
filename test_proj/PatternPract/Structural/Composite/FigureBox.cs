using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPract
{
    class FigureBox : AFigure
    {
        List<IFigure> children;
        string name;

        public FigureBox(string name) : base()
        {
            children = new();
            this.name = name;
        }

        public override string Display(int deep = 1)
        {
            string temp = "";
            temp += "\n" + string.Join("", Enumerable.Repeat("\t", deep)) + this.ToString();
            deep++;
            foreach (var child in children)
            {
                temp += child.Display(deep);
            }
            return temp;
        }

        public override void Add(IFigure figure) 
        {
            children.Add(figure);
        }
        public override void Remove(IFigure figure) 
        {
            if (!children.Any())
                return;
            children.Remove(figure);
        }

        public override string ToString()
        {
            return name;
        }

        public override string GetFigureType()
        {
            return "FigureBox";
        }
    }
}
