using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex317
{
    internal class Circle: Figure
    {
        public Circle(double _x) : base(_x) { }

        public override double Square()
        {
            return (Math.PI * this.x*this.x);
        }
    }
}
