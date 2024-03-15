using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPract
{
    abstract class AFigure : IFigure
    {
        public AFigure()
        {
            
        }

        public abstract string Display(int deep);

        public virtual void Add(IFigure figure) { }
        public virtual void Remove(IFigure figure) { }

        public abstract string GetFigureType();
    }
}
