using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPract
{
    interface IFigure
    {
        string Display(int deep);
        void Add(IFigure figure);
        void Remove(IFigure figure);
        string GetFigureType();
    }
}
