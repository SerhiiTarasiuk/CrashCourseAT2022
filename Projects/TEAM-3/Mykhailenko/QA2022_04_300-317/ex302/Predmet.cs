using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex302
{
    internal class Predmet
    {
        public string Name { get; set; }
        public byte Mark { get; set; }

        public Predmet(string _name, byte _mark)
        {
            Name = _name;
            Mark = _mark;
        }

    }
}
