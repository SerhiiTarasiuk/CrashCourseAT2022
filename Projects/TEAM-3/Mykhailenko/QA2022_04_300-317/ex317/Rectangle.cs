using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex317
{
    internal class Rectangle : Figure
    {
        public double y;

        public Rectangle(double _x, double _y) : base(_x) 
        {
            y = _y;
        }
        public override double Square()
        {
            return (this.x * this.y);
        }
    }
}
