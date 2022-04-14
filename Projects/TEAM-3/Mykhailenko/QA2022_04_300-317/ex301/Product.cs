using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex301
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; } 
        public double Ost { get; set; }

        public Product (string _name, double _price, double _ost) { Name = _name; Price = _price; Ost = _ost; }

        public void Add_Ost (double _ost) { Ost += _ost; }
        public void Sub_Ost (double _ost) { Ost -= _ost; }
        public string Print() 
        {
            return "Info for product\nName   : " +this.Name+ "\nPrice  : "+ this.Price + "\nOst    : "+this.Ost;
        }
    }
}
