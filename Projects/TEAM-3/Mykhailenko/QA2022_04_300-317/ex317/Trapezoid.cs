using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex317
{
    internal class Trapezoid : Figure
    {
        double y;
        double z; //висота

        public Trapezoid(double _x, double _y, double _z) : base (_x)
        {
            this.y = _y;
            this.z = _z;
        }

        public override double Square()
        {
            return ((this.x+this.y)*this.z)/2;
        }
    }
}
