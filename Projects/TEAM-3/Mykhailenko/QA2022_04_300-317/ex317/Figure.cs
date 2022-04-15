using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex317
{
    internal abstract class Figure
    {
        public double x;
        
        protected Figure(double _x)
        {
            x = _x;
        }

        public abstract double Square();
    }
}
